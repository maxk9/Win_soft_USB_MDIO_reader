using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Microsoft.Win32;
using System.IO;
using System.Globalization;

namespace FiberTreid_CFP_Reader
{
	public partial class form1 : Form
	{
		private int count_rx_byte = 0;
		private byte[] read_buffer = new byte[8000];
		private SerialPort _serialPort = new SerialPort();
		// Create an ASCII encoding.
		Encoding ascii = Encoding.ASCII;
		//  Thread readThread = new Thread(Read);



		/// <summary>
		/// Compile an array of COM port names associated with given VID and PID
		/// </summary>
		/// <param name="VID"></param>
		/// <param name="PID"></param>
		/// <returns></returns>
		List<string> ComPortNames(String VID, String PID)
		{
			String pattern = String.Format("^VID_{0}.PID_{1}", VID, PID);
			Regex _rx = new Regex(pattern, RegexOptions.IgnoreCase);
			List<string> comports = new List<string>();
			RegistryKey rk1 = Registry.LocalMachine;
			RegistryKey rk2 = rk1.OpenSubKey("SYSTEM\\CurrentControlSet\\Enum");
			foreach (String s3 in rk2.GetSubKeyNames())
			{
				RegistryKey rk3 = rk2.OpenSubKey(s3);
				foreach (String s in rk3.GetSubKeyNames())
				{
					if (_rx.Match(s).Success)
					{
						RegistryKey rk4 = rk3.OpenSubKey(s);
						foreach (String s2 in rk4.GetSubKeyNames())
						{
							RegistryKey rk5 = rk4.OpenSubKey(s2);
							RegistryKey rk6 = rk5.OpenSubKey("Device Parameters");
							comports.Add((string)rk6.GetValue("PortName"));
						}
					}
				}
			}
			rk1.Close();
			rk2.Close();


			return comports;
		}



		public form1()
		{
			InitializeComponent();
			
			status_date.ToolTipText = "Started: " + System.DateTime.Now.ToShortTimeString();
			status_date.Text = System.DateTime.Today.ToLongDateString();

			Array.Clear(read_buffer, 0, read_buffer.Length);
		}

		private string CharArrayToString(Char[] strM1)
		{
			string result = "";
			for (int i = 0; i < strM1.Length; i++)
				result = result + strM1[i];

			return (result);
		}

		private void SetText(string text)
		{
			// InvokeRequired required compares the thread ID of the
			// calling thread to the thread ID of the creating thread.
			// If these threads are different, it returns true.
			if (this.textBox1.InvokeRequired)
			{
				SetTextCallback d = new SetTextCallback(SetText);
				this.Invoke(d, new object[] { text });
			}
			else
			{
				this.status_lbl.Text = text;
			}
		}

		private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
		{
			SerialPort sp = (SerialPort)sender;

			count_rx_byte = sp.BytesToRead;
			// sp.Read(read_buffer, 0, count_rx_byte);
			// status_lbl.Text = sp.ReadExisting();
			//status_lbl.Text = BitConverter.ToString(read_buffer);
			//this.SetText(read_buffer.ToString());
		}

		private void connect_Click(object sender, EventArgs e)
		{
			List<string> names = ComPortNames("04B4", "F232");  //Cypress dem board
			pr_bar.Value = 0;

			foreach (String s in SerialPort.GetPortNames())
			{
				if (names.Contains(s))
				{
					status_lbl.Text = "Cypress board is " + s + " opened";
					//SerialPort _serialPort = new SerialPort(s, 250000, Parity.None, 8, StopBits.One);
					_serialPort.PortName = s;
					_serialPort.BaudRate = 115200;
					_serialPort.Parity = Parity.None;
					_serialPort.DataBits = 8;
					_serialPort.StopBits = StopBits.One;
					_serialPort.Handshake = Handshake.None;
					_serialPort.DtrEnable = true;
					_serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

					// Set the read/write timeouts
					_serialPort.ReadTimeout = 300;
					_serialPort.WriteTimeout = 300;
					// readThread.Start();
					try
					{
						_serialPort.Open();
						connect.Enabled = false;
						break;
					}
					catch (ArgumentNullException)
					{
						status_lbl.Text = "Serial port " + s + " not opened";
					}
				}
				else
					status_lbl.Text = "Cypress board not found";
			}
		}

		private void save_to_file_Click(object sender, EventArgs e)
		{

		}

		private void load_from_file_Click(object sender, EventArgs e)
		{

		}

		private void read_cfp_Click(object sender, EventArgs e)
		{
			if (_serialPort.IsOpen)
			{ }
		}

		private void write_cfp_Click(object sender, EventArgs e)
		{
			if (_serialPort.IsOpen)
			{ }
		}

		private void btn_read_cfp_nvr_Click(object sender, EventArgs e)
		{
			if (_serialPort.IsOpen)
			{
				try
				{
					
					string strr = "   ", str_label = "";
					int count_word = 0x1ff+1, sub_cnt=25,addr;
					//int count_word = 0x01;

					addr = 0x8000;
					MDIO_Set_Read_addr_reg_dev(addr);
					MDIO_read_word_to_buffer(sub_cnt);

					dtg_cfp_nvr.Rows.Clear();

					while (count_word > 0)
					{
						for (int i = 0; (i < (count_rx_byte>>1))&&(count_word>0); i++)
						{
							--count_word;
							
							if (count_word <= 0x7F)
								str_label = "CFP NVR4";
							if (count_word <= 0xFF && count_word > 0x7F)
								str_label = "CFP NVR3";
							if (count_word <= 0x17F && count_word > 0xFF)
								str_label = "CFP NVR2";
							if (count_word > 0x17F)
								str_label = "CFP NVR1";

							strr = "0x" + string.Format("{0:x2}", (read_buffer[i * 2 + 1])).ToUpper();
							dtg_cfp_nvr.Rows.Add(str_label, "0x" + string.Format("{0:x4}", (addr)).ToUpper(), strr,"'"+Convert.ToChar(read_buffer[i * 2 + 1])+"'");
							++addr;

							//if (addr == 0x81ff)
							//	--count_word;
						}

						MDIO_Set_Read_addr_reg_dev(addr);
						MDIO_read_word_to_buffer(sub_cnt);
					}

					if (count_rx_byte >= (count_word + 1) * 2)
						status_lbl.Text = "Read complete. " + count_rx_byte.ToString();
					else
						status_lbl.Text = "read incomplet " + count_rx_byte.ToString();


					_serialPort.DiscardInBuffer();
				}
				catch (Exception ex)
				{
					status_lbl.Text = ex.ToString();
					//MessageBox.Show(ex.ToString());

				}
			}
		}

		private void btn_write_cfp_nvr_Click(object sender, EventArgs e)
		{
			if (_serialPort.IsOpen)
			{ }
		}

		private void form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (_serialPort.IsOpen)
			{
				_serialPort.Close();
			}
		}

		private void btn_read_ven_nvr_Click(object sender, EventArgs e)
		{
			if (_serialPort.IsOpen)
			{
				try
				{
					

					string strr = "   ", str_label = "";
					int count_word = 0xff + 1, sub_cnt = 25, addr;
					//int count_word = 0x01;

					addr = 0x8400;
					MDIO_Set_Read_addr_reg_dev(addr);
					MDIO_read_word_to_buffer(sub_cnt);

					dtg_vendor.Rows.Clear();

					while (count_word > 0)
					{
						for (int i = 0; (i < (count_rx_byte >> 1)) && (count_word > 0); i++)
						{
							--count_word;

							if (count_word < 128)
								str_label = "Ven NVR2";
							if (count_word >= 128)
								str_label = "Ven NVR1";

							strr = "0x" + string.Format("{0:x2}", (read_buffer[i * 2 + 1])).ToUpper();
							dtg_vendor.Rows.Add(str_label, "0x" + string.Format("{0:x4}", (addr)).ToUpper(), strr, "'" + Convert.ToChar(read_buffer[i * 2 + 1]) + "'");
							++addr;

							//if (addr == 0x81ff)
							//	--count_word;
						}

						MDIO_Set_Read_addr_reg_dev(addr);
						MDIO_read_word_to_buffer(sub_cnt);
					}

					if (count_rx_byte >= (count_word + 1) * 2)
						status_lbl.Text = "Read complete. " + count_rx_byte.ToString();
					else
						status_lbl.Text = "read incomplet " + count_rx_byte.ToString();


					_serialPort.DiscardInBuffer();
				}
				catch (Exception ex)
				{
					status_lbl.Text = ex.ToString();
					//MessageBox.Show(ex.ToString());

				}
			}
		}

		public void MDIO_Set_Read_addr_reg_dev(int addr)
		{
			if (_serialPort.IsOpen)
			{
				try
				{
					byte dev = 0, phy = 0;
					// byte[] arr = new byte[10];
					// char[] read_buf = { ' ',' ',' '};
					string strr = "   ", str_label = "";
					byte[] arr = { 0, 0, 0 };

					byte.TryParse("1", out dev);
					byte.TryParse("0", out phy);

					_serialPort.DiscardInBuffer();
					_serialPort.DiscardOutBuffer();
					count_rx_byte = 0;

					Array.Clear(read_buffer, 0, read_buffer.Length);

					status_lbl.Text = "read ...";


					//arr[0] = Convert.ToByte('D');
					//arr[1] = 0;
					//arr[2] = dev;

					//_serialPort.Write(arr, 0, 3);

					//while (count_rx_byte < 3)
					//{
					//	Application.DoEvents();
					//}

					//// strr = (ascii.GetString(read_buffer));
					////status_lbl.Text = strr;
					//_serialPort.Read(read_buffer, 0, count_rx_byte);

					//if (!((read_buffer[0] == Convert.ToByte('D')) &&
					//	(read_buffer[1] == Convert.ToByte('O')) &&
					//	(read_buffer[2] == Convert.ToByte('K'))))
					//{
					//	status_lbl.Text = "         ";
					//	throw new Exception(strr);
					//}

					////else
					////    status_lbl.Text = (ascii.GetString(read_buffer));
					//_serialPort.DiscardInBuffer();

					//arr[0] = Convert.ToByte('H');
					//arr[1] = 0;
					//arr[2] = phy;

					//_serialPort.Write(arr, 0, 3);

					//while (count_rx_byte < 3)
					//{
					//	Application.DoEvents();
					//}

					//_serialPort.Read(read_buffer, 0, count_rx_byte);
					//strr = (ascii.GetString(read_buffer));

					//if (!((read_buffer[0] == Convert.ToByte('H')) &&
					//	(read_buffer[1] == Convert.ToByte('O')) &&
					//	(read_buffer[2] == Convert.ToByte('K'))))
					//{
					//	status_lbl.Text = "         ";
					//	throw new Exception(strr);
					//}

					//_serialPort.DiscardInBuffer();

					arr[0] = Convert.ToByte('A');
					arr[1] = Convert.ToByte((addr >> 8) & 0xFF);
					arr[2] = Convert.ToByte((addr) & 0xFF);

					_serialPort.Write(arr, 0, 3);

					while (count_rx_byte < 3)
					{
						Application.DoEvents();
					}

					_serialPort.Read(read_buffer, 0, count_rx_byte);
					strr = (ascii.GetString(read_buffer));

					if (!((read_buffer[0] == Convert.ToByte('A')) &&
						(read_buffer[1] == Convert.ToByte('O')) &&
						(read_buffer[2] == Convert.ToByte('K'))))
						throw new Exception(strr);
				}
				catch (Exception ex)
				{
					status_lbl.Text = ex.ToString();
					//MessageBox.Show(ex.ToString());

				}
			}
		}

		private void btn_read_user_nvr_Click(object sender, EventArgs e)
		{
			if (_serialPort.IsOpen)
			{
				try
				{
					string strr = "   ", str_label = "";
					int count_word = 0xff + 1, sub_cnt = 25, addr;
					//int count_word = 0x01;

					addr = 0x8800;
					MDIO_Set_Read_addr_reg_dev(addr);
					MDIO_read_word_to_buffer(sub_cnt);

					dtg_us_nvr.Rows.Clear();

					while (count_word > 0)
					{
						for (int i = 0; (i < (count_rx_byte >> 1)) && (count_word > 0); i++)
						{
							--count_word;

							if (count_word < 128)
								str_label = "User NVR2";
							if (count_word >= 128)
								str_label = "User NVR1";

							strr = "0x" + string.Format("{0:x2}", (read_buffer[i * 2 + 1])).ToUpper();
							dtg_us_nvr.Rows.Add(str_label, "0x" + string.Format("{0:x4}", (addr)).ToUpper(), strr, "'" + Convert.ToChar(read_buffer[i * 2 + 1]) + "'");
							++addr;

							//if (addr == 0x81ff)
							//	--count_word;
						}

						MDIO_Set_Read_addr_reg_dev(addr);
						MDIO_read_word_to_buffer(sub_cnt);
					}

					if (count_rx_byte >= (count_word + 1) * 2)
						status_lbl.Text = "Read complete. " + count_rx_byte.ToString();
					else
						status_lbl.Text = "read incomplet " + count_rx_byte.ToString();


					_serialPort.DiscardInBuffer();



				}
				catch (Exception ex)
				{
					status_lbl.Text = ex.ToString();
					//MessageBox.Show(ex.ToString());

				}
			}
		}

		private void btn_read_netw_nvr_Click(object sender, EventArgs e)
		{
			if (_serialPort.IsOpen)
			{
				try
				{

					string strr = "", str_label = "";
					int count_word = 383 + 1, sub_cnt = 25, addr;
					//int count_word = 0x01;

					addr = 0xA200;
					MDIO_Set_Read_addr_reg_dev(addr);
					MDIO_read_word_to_buffer(sub_cnt);

					dtg_net_lane.Rows.Clear();

					while (count_word > 0)
					{
						for (int i = 0; (i < (count_rx_byte >> 1)) && (count_word > 0); i++)
						{
							--count_word;

							if (count_word < 128)
								str_label = "Net Lane VR3";
							if (count_word < 256 && count_word >= 128)
								str_label = "Net Lane VR2";
							if (count_word >= 256)
								str_label = "Net Lane VR1";

							//strr = "0x" + string.Format("{0:x2}", (read_buffer[i * 2 + 1])).ToUpper();
							strr = "0x" + string.Format("{0:x4}", (read_buffer[i * 2] << 8 | read_buffer[i * 2 + 1])).ToUpper();
							dtg_net_lane.Rows.Add(str_label, "0x" + string.Format("{0:x4}", (addr)).ToUpper(), strr);
							++addr;

							//if (addr == 0x81ff)
							//	--count_word;
						}

						MDIO_Set_Read_addr_reg_dev(addr);
						MDIO_read_word_to_buffer(sub_cnt);
					}

					if (count_rx_byte >= (count_word + 1) * 2)
						status_lbl.Text = "Read complete. " + count_rx_byte.ToString();
					else
						status_lbl.Text = "read incomplet " + count_rx_byte.ToString();


					_serialPort.DiscardInBuffer();



				}
				catch (Exception ex)
				{
					status_lbl.Text = ex.ToString();
					//MessageBox.Show(ex.ToString());

				}
			}
		}

		private void btn_read_all_Click(object sender, EventArgs e)
		{
			if (_serialPort.IsOpen)
			{
				try
				{
					btn_read_cfp_nvr_Click(sender, e);
					btn_read_ven_nvr_Click(sender, e);
					btn_read_user_nvr_Click(sender, e);
					btn_read_netw_nvr_Click(sender, e);
					btn_cfp_VR1_Click(sender, e);
					btn_host_lane_Click(sender, e);
				}
				catch (Exception ex)
				{
					status_lbl.Text = ex.ToString();
					//MessageBox.Show(ex.ToString());

				}
			}
		}

		private void btn_write_user_nvr_Click(object sender, EventArgs e)
		{
			if (_serialPort.IsOpen && dtg_us_nvr.Rows.Count != 0)
			{
				try
				{
					//string strr = "", str_label = "";
					int count_word = 0xff + 1, sub_cnt = 20, addr,cnt=0;
					string[] local_read_buff = new string[count_word];
					//int count_word = 0x01;


					//считываем в буффер CFP модуль
				addr = 0x8800;
					MDIO_Set_Read_addr_reg_dev(addr);
					MDIO_read_word_to_buffer(sub_cnt);

					while (count_word > 0)
					{
						for (int i = 0; (i < (count_rx_byte >> 1)) && (count_word > 0); i++)
						{
							local_read_buff[cnt] = "0x" + string.Format("{0:x2}", (read_buffer[i * 2 + 1])).ToUpper();
							++cnt;
							--count_word;
							++addr;
						}
						MDIO_Set_Read_addr_reg_dev(addr);
						MDIO_read_word_to_buffer(sub_cnt);
					}

					pr_bar.Maximum = dtg_us_nvr.Rows.Count;
				addr = 0x8800;
					//сравниваем с тем что в datagrid разницу сразу записываем
					UInt16 j= 0, tmp =0;
					cnt = 0;
					foreach (DataGridViewRow row in dtg_us_nvr.Rows)
					{
						if(row.Cells[2].Value.ToString() != local_read_buff[j])//записываем
						{
							++cnt;
							tmp = Convert.ToByte(row.Cells[2].Value.ToString(), 16);	//tmp = Convert.ToUInt16(row.Cells[2].Value);
							MDIO_set_addr_reg(addr + j);
							
							MDIO_write_word(tmp);
						}
						++j;
						pr_bar.Value = j;
					}

					if (cnt > 0)
						status_lbl.Text = "Write complete. " + cnt.ToString();
					else
						status_lbl.Text = "no differences";

					_serialPort.DiscardInBuffer();
				}
				catch (Exception ex)
				{
					status_lbl.Text = ex.ToString();
					//MessageBox.Show(ex.ToString());
				}
			}
		}
		private void MDIO_set_addr_reg(int addr)
		{
			if (_serialPort.IsOpen)
			{
				try
				{
					string strr = "   ";
					byte[] arr = { 0, 0, 0 };

					_serialPort.DiscardInBuffer();

					arr[0] = Convert.ToByte('A');
					arr[1] = Convert.ToByte((addr >> 8) & 0xFF);
					arr[2] = Convert.ToByte((addr) & 0xFF);

					_serialPort.Write(arr, 0, 3);

					while (count_rx_byte < 3)
					{
						Application.DoEvents();
					}

					_serialPort.Read(read_buffer, 0, count_rx_byte);
					strr = (ascii.GetString(read_buffer));

					if (!((read_buffer[0] == Convert.ToByte('A')) &&
						(read_buffer[1] == Convert.ToByte('O')) &&
						(read_buffer[2] == Convert.ToByte('K'))))
						throw new Exception(strr);
				}
				catch (Exception ex)
				{
					status_lbl.Text = ex.ToString();
					//MessageBox.Show(ex.ToString());

				}
			}
		}
		private void MDIO_read_ONE_byte_to_buffer(int addr)
		{
			if (_serialPort.IsOpen)
			{
				try
				{
					byte[] arr = { 0, 0, 0 };

					_serialPort.DiscardInBuffer();
					_serialPort.DiscardOutBuffer();

					count_rx_byte = 0;

					Array.Clear(read_buffer, 0, read_buffer.Length);

					arr[0] = Convert.ToByte('R');
					arr[1] = Convert.ToByte((addr >> 8) & 0xFF);
					arr[2] = Convert.ToByte((addr) & 0xFF);

					count_rx_byte = 0;
					_serialPort.Write(arr, 0, 3);

					pr_bar.Maximum = 2;
					pr_bar.Value = 0;

					while (count_rx_byte == 0)
					{
						Application.DoEvents();
					}

					if (pr_bar.Maximum < count_rx_byte)
					{
						pr_bar.Maximum = count_rx_byte;
						
					}
					pr_bar.Value = count_rx_byte;

					_serialPort.Read(read_buffer, 0, count_rx_byte);
				}
				catch (Exception ex)
				{
					status_lbl.Text = ex.ToString();
					//MessageBox.Show(ex.ToString());

				}
			}
		}
		private void MDIO_read_byte_to_buffer( int count_word)
		{
			if (_serialPort.IsOpen)
			{
				try
				{
					byte[] arr = { 0, 0, 0 };

					_serialPort.DiscardInBuffer();
					Array.Clear(read_buffer, 0, read_buffer.Length);

					arr[0] = Convert.ToByte('C');
					arr[1] = Convert.ToByte((count_word >> 8) & 0xFF);
					arr[2] = Convert.ToByte((count_word) & 0xFF);//read  bytes

					count_rx_byte = 0;
					_serialPort.Write(arr, 0, 3);

					pr_bar.Maximum = count_word * 2;
					pr_bar.Value = 0;


					while (count_rx_byte < count_word * 2 + 1)
					{
						Application.DoEvents();
						if (pr_bar.Maximum < count_rx_byte)
						{
							pr_bar.Maximum = count_rx_byte;
						}
						pr_bar.Value = count_rx_byte;
					}

					_serialPort.Read(read_buffer, 0, count_rx_byte);
				}
				catch (Exception ex)
				{
					status_lbl.Text = ex.ToString();
					//MessageBox.Show(ex.ToString());

				}
			}
		}
		private void MDIO_read_word_to_buffer(int count_word)
		{
			if (_serialPort.IsOpen)
			{
				try
				{
					byte[] arr = { 0, 0, 0 };

					_serialPort.DiscardInBuffer();
					Array.Clear(read_buffer, 0, read_buffer.Length);

					arr[0] = Convert.ToByte('V');
					arr[1] = Convert.ToByte((count_word >> 8) & 0xFF);
					arr[2] = Convert.ToByte((count_word) & 0xFF);//read WORDs

					count_rx_byte = 0;

					_serialPort.Write(arr, 0, 3);

					pr_bar.Maximum = count_word * 2;
					pr_bar.Value = 0;


					while (count_rx_byte < count_word * 2 + 1)
					{
						Application.DoEvents();
						if (pr_bar.Maximum < count_rx_byte)
						{
							pr_bar.Maximum = count_rx_byte;
						}
						pr_bar.Value = count_rx_byte;
					}

					_serialPort.Read(read_buffer, 0, count_rx_byte);
				}
				catch (Exception ex)
				{
					status_lbl.Text = ex.ToString();
					//MessageBox.Show(ex.ToString());

				}
			}
		}
		private void MDIO_write_word(int data_write)
		{
			if (_serialPort.IsOpen)
			{
				try
				{
					string strr = "   ";
					byte[] arr = { 0, 0, 0 };

					_serialPort.DiscardInBuffer();

					arr[0] = Convert.ToByte('W');
					arr[1] = Convert.ToByte((data_write >> 8) & 0xFF);
					arr[2] = Convert.ToByte((data_write) & 0xFF);

					count_rx_byte = 0;

					_serialPort.Write(arr, 0, 3);

					while (count_rx_byte < 3)
					{
						Application.DoEvents();
					}

					_serialPort.Read(read_buffer, 0, count_rx_byte);
					strr = (ascii.GetString(read_buffer));

					if (!((read_buffer[0] == Convert.ToByte('W')) &&
						(read_buffer[1] == Convert.ToByte('O')) &&
						(read_buffer[2] == Convert.ToByte('K'))))
						throw new Exception(strr);
				}
				catch (Exception ex)
				{
					status_lbl.Text = ex.ToString();
					//MessageBox.Show(ex.ToString());

				}
			}
		}

		private void btn_write_netw_nvr_Click(object sender, EventArgs e)
		{
			if (_serialPort.IsOpen && dtg_net_lane.Rows.Count != 0)
			{
				try
				{
					//string strr = "", str_label = "";
					int count_word = 0x1fe + 1, sub_cnt = 20, addr, cnt = 0;
					string[] local_read_buff = new string[count_word];
					//int count_word = 0x01;


					//считываем в буффер CFP модуль
					addr = 0xA200;
					MDIO_Set_Read_addr_reg_dev(addr);
					MDIO_read_word_to_buffer(sub_cnt);

					while (count_word > 0)
					{
						for (int i = 0; (i < (count_rx_byte >> 1)) && (count_word > 0); i++)
						{
							//strr = "0x" + string.Format("{0:x4}", (read_buffer[i * 2] << 8 | read_buffer[i * 2 + 1])).ToUpper();
							local_read_buff[cnt] = "0x" + string.Format("{0:x4}", (read_buffer[i * 2] << 8 | read_buffer[i * 2 + 1])).ToUpper();
							++cnt;
							--count_word;
							++addr;
						}
						MDIO_Set_Read_addr_reg_dev(addr);
						MDIO_read_word_to_buffer(sub_cnt);
					}

					pr_bar.Maximum = dtg_net_lane.Rows.Count;
					addr = 0xA200;
					//сравниваем с тем что в datagrid разницу сразу записываем
					int j = 0, tmp = 0;
					cnt = 0;
					foreach (DataGridViewRow row in dtg_net_lane.Rows)
					{
						if (row.Cells[2].Value.ToString() != local_read_buff[j])//записываем
						{
							++cnt;
							tmp = Convert.ToInt32(row.Cells[2].Value.ToString(), 16);    //tmp = Convert.ToUInt16(row.Cells[2].Value);
							MDIO_set_addr_reg(addr + j);

							MDIO_write_word(tmp);
						}
						++j;
						pr_bar.Value = j;
					}

					if (cnt > 0)
						status_lbl.Text = "Write complete. " + cnt.ToString();
					else
						status_lbl.Text = "no differences";

					_serialPort.DiscardInBuffer();
				}
				catch (Exception ex)
				{
					status_lbl.Text = ex.ToString();
					//MessageBox.Show(ex.ToString());
				}
			}











			/*

			if (_serialPort.IsOpen && dtg_net_lane.Rows.Count != 0)
			{
				try
				{
					string strr = "   ";
					byte cnt = 0;
					//int[,] data_user_nvr = new int[2,512];// буфер ТЕКУЩИХ данных
					int addr = 0xA200, i = 0;
					int tmp =0;
					_serialPort.DiscardInBuffer();
					Array.Clear(read_buffer, 0, read_buffer.Length);

					MDIO_set_addr_reg(addr);
					MDIO_read_word_to_buffer(383);


					pr_bar.Maximum = dtg_net_lane.Rows.Count;
					//сравниваем с тем что в datagrid разницу сразу записываем
					foreach (DataGridViewRow row in dtg_net_lane.Rows)
					{
						strr = "0x" + string.Format("{0:x4}", (read_buffer[i * 2] << 8 | read_buffer[i * 2 + 1])).ToUpper();
						++i;
						pr_bar.Value = i;

						if (row.Cells[2].Value.ToString() != strr)//записываем
						{
							++cnt;
							MDIO_set_addr_reg(addr);
							tmp = Convert.ToInt32(row.Cells[2].Value);
							MDIO_write_word(tmp);
						}
						addr += 1;
					}


					if (cnt > 0)
						status_lbl.Text = "Write complete. " + cnt.ToString();
					else
						status_lbl.Text = "no differences";



					_serialPort.DiscardInBuffer();
				}
				catch (Exception ex)
				{
					status_lbl.Text = ex.ToString();
					//MessageBox.Show(ex.ToString());

				}
			}
			*/
		}

		private void dtg_net_lane_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
		{
			//	try
			//	{
			//		UInt16 hex = (UInt16)Convert.ToInt16(e.Value.ToString(), 16);
			//	//int hex = Convert.ToInt32(e.Value.ToString(), 16);
			////	dtg_net_lane.R
			//		e.Value = hex;
			//		e.ParsingApplied = true;
			//	}
			//	catch (Exception ex)
			//	{
			//		// Not a Valid Hexadecimal
			//		status_lbl.Text = ex.ToString();
			//	}
		}

		private void dtg_us_nvr_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
		{

					try
					{
					UInt16 hex = (UInt16)Convert.ToInt16(e.Value.ToString(), 16);
				//UInt16 hex = Convert.ToInt32(e.Value.ToString(), 16);
						e.Value = hex;
						e.ParsingApplied = true;
					}
				catch (Exception ex)
					{
						// Not a Valid Hexadecimal
						status_lbl.Text = ex.ToString();
					}

		}

		private void dtg_vendor_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
		{
			try
			{
			UInt16 hex = (UInt16)Convert.ToInt16(e.Value.ToString(), 16);
			//UInt16 hex = Convert.ToInt32(e.Value.ToString(), 16);
				e.Value = hex;
				e.ParsingApplied = true;
			}
			catch (Exception ex)
			{
				// Not a Valid Hexadecimal
				status_lbl.Text = ex.ToString();
			}
		}

		private void dtg_cfp_nvr_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
		{
			//try
			//{
			//UInt16 hex = (UInt16)Convert.ToInt16(e.Value.ToString(), 16);
			////UInt16 hex = Convert.ToInt32(e.Value.ToString(), 16);
			//	e.Value = hex;
			//	e.ParsingApplied = true;
			//}
			//catch (Exception ex)
			//{
			//	// Not a Valid Hexadecimal
			//	status_lbl.Text = ex.ToString();
			//}
		}

		private void file_open_Click(object sender, EventArgs e)
		{
			Stream myStream = null;
			OpenFileDialog openFileDialog1 = new OpenFileDialog();

			//openFileDialog1.InitialDirectory = "c:\\";
			openFileDialog1.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
			openFileDialog1.FilterIndex = 2;
			openFileDialog1.RestoreDirectory = true;

			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				try
				{
					if ((myStream = openFileDialog1.OpenFile()) != null)
					{
						using (myStream)
						{
							// Insert code to read the stream here.
							string[] read_data_csv = File.ReadAllLines(openFileDialog1.FileName);
							string[] CFP_Values = null;
							string strr = "", str_label="";
							int[,] data_csv = new int[read_data_csv.Count()-3, 2];
							Int16 k = 0;
							dtg_host_lane.Rows.Clear();
							dtg_vendor.Rows.Clear();
							dtg_us_nvr.Rows.Clear();
							dtg_vr1_mlg.Rows.Clear();
							dtg_net_lane.Rows.Clear();
							dtg_host_lane.Rows.Clear();
							DataGridViewRow row = null;

							//"12/16/2016 10:40:11 AM"							0	
							//"CFP Host: MSA"									1
							//"Address, Hex, Decimal, ASCII, MSA Description"	2

							for (int i = 3; i < read_data_csv.Length; i++)//выбираем пары адрес - дата
							{
								if (!String.IsNullOrEmpty(read_data_csv[i]))
								{
									CFP_Values = read_data_csv[i].Split(',');
									CFP_Values[0] = CFP_Values[0].Substring(CFP_Values[0].IndexOf('(')+1, CFP_Values[0].IndexOf(')') - CFP_Values[0].IndexOf('(')-2);
									data_csv[k, 0] = Convert.ToInt32(CFP_Values[0], 16);
									data_csv[k, 1] = Convert.ToInt32(CFP_Values[1], 16);
									k++;
								}
							}
							//заполняем поля в датагриде
							int offset = 0;
							pr_bar.Value = 0;
							pr_bar.Maximum = data_csv.GetLength(0);

							for (int el = 0; el < data_csv.GetLength(0); el++)
							{
								pr_bar.Value = el;

								if ((data_csv[el, 0] >= (int)0x8000) && (data_csv[el, 0] <= (int)0x81FF))
								{
									offset = (data_csv[el, 0] - 0x8000);
									
									if (offset < 64)
										str_label = "CFP NVR1";
									if (offset < 128 && offset >= 64)
										str_label = "CFP NVR2";
									if (offset < 192 && offset >= 128)
										str_label = "CFP NVR3";
									if (offset < 256 && offset >= 192)
										str_label = "CFP NVR4";

									strr = "0x" + string.Format("{0:x2}", (data_csv[el, 1])).ToUpper();
									if(offset<256)
										dtg_cfp_nvr.Rows.Add(str_label, "0x" + string.Format("{0:x4}", data_csv[el, 0]).ToUpper(), strr,"'"+Convert.ToChar(data_csv[el, 1])+"'");
								}


								if ((data_csv[el, 0] >= (int)0x8400) && (data_csv[el, 0] <= (int)0x84FF))
								{
									offset = (data_csv[el, 0] - 0x8400);

									if (offset < 64)
										str_label = "Ven NVR1";
									if (offset < 128 && offset >= 64)
										str_label = "Ven NVR2";

									strr = "0x" + string.Format("{0:x2}", (data_csv[el, 1])).ToUpper();
									if (offset < 128)
										dtg_vendor.Rows.Add(str_label, "0x" + string.Format("{0:x4}", data_csv[el, 0] ).ToUpper(), strr,"'" + Convert.ToChar(data_csv[el, 1]) + "'");
								}


								if ((data_csv[el, 0] >= (int)0x8800) && (data_csv[el, 0] <= (int)0x88FF))
								{
									offset = (data_csv[el, 0] - 0x8800);

									if (offset < 64)
										str_label = "User NVR1";
									if (offset < 128 && offset >= 64)
										str_label = "User NVR2";

									strr = "0x" + string.Format("{0:x2}", data_csv[el, 1]).ToUpper();
									if (offset < 128)
										dtg_us_nvr.Rows.Add(str_label, "0x" + string.Format("{0:x4}", data_csv[el, 0]).ToUpper(), strr, "'" + Convert.ToChar(data_csv[el, 1]) + "'");
								}


								if ((data_csv[el, 0] >= (int)0xA000) && (data_csv[el, 0] <= (int)0xA0FF))
								{
									offset = (data_csv[el, 0] - 0xA000);

									if (offset < 128)
										str_label = "CFP m VR1";
									if (offset < 256 && offset >= 128)
										str_label = "MLG VR1";

									strr = "0x" + string.Format("{0:x4}", (data_csv[el, 1])).ToUpper();
									
									dtg_vr1_mlg.Rows.Add(str_label, "0x" + string.Format("{0:x4}", data_csv[el, 0]).ToUpper(), strr);
								}


								if ((data_csv[el, 0] >= (int)0xA200) && (data_csv[el, 0] <= (int)0xA37F))
								{
									offset = (data_csv[el, 0] - 0xA200);

									if (offset < 128)
										str_label = "Net Lane VR1";
									if (offset < 256 && offset >= 128)
										str_label = "Net Lane VR2";
									if (offset < 384 && offset >= 256)
										str_label = "Net Lane VR3";

									strr = "0x" + string.Format("{0:x4}", (data_csv[el, 1])).ToUpper();

									dtg_net_lane.Rows.Add(str_label, "0x" + string.Format("{0:x4}", data_csv[el, 0]).ToUpper(), strr);
								}


								if ((data_csv[el, 0] >= (int)0xA400) && (data_csv[el, 0] <= (int)0xA47F))
								{
									offset = (data_csv[el, 0] - 0xA400);

									if (offset < 128)
										str_label = "Host Lane VR1";
									//if (offset < 256 && offset >= 128)
									//	str_label = "Net Lane VR2";
									//if (offset < 384 && offset >= 256)
									//	str_label = "Net Lane VR3";

									strr = "0x" + string.Format("{0:x4}", (data_csv[el, 1])).ToUpper();

									dtg_host_lane.Rows.Add(str_label, "0x" + string.Format("{0:x4}", data_csv[el, 0]).ToUpper(), strr);
								}

								if ((data_csv[el, 0] >= (int)0xAC00) && (data_csv[el, 0] <= (int)0xBFFF))
								{
									offset = (data_csv[el, 0] - 0xAC00);

									if (offset < 128)
										str_label = "Comm data B R";
									if (offset < 256 && offset >= 128)
										str_label = "Net Lane VR2";
									//if (offset < 384 && offset >= 256)
									//	str_label = "Net Lane VR3";

									strr = "0x" + string.Format("{0:x4}", (data_csv[el, 1])).ToUpper();

									dtg_host_lane.Rows.Add(str_label, "0x" + string.Format("{0:x4}", data_csv[el, 0]).ToUpper(), strr);
								}
							}
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void file_save_Click(object sender, EventArgs e)
		{
			try
			{
				// диалоговое окно
				var save = new SaveFileDialog
				{
					AddExtension = true,
					DefaultExt = "csv",
					Filter = @"CSV-файл (*.csv)|*.csv",
					FilterIndex = 0,
					RestoreDirectory = true
				};

				if (save.ShowDialog() != DialogResult.OK) return;

				var sw = new StreamWriter(save.FileName, false, Encoding.UTF8);
				string str = "";
				DateTime thisDay = DateTime.Now;
				sw.WriteLine(thisDay.ToString(System.Globalization.CultureInfo.InvariantCulture));
				sw.WriteLine("CFP Host: MSA");
				sw.WriteLine("Address, Hex, Decimal, ASCII, MSA Description");

				foreach (DataGridViewRow row in dtg_cfp_nvr.Rows) //запись
					if (!row.IsNewRow)
					{

						foreach (DataGridViewCell cell in row.Cells)
						{
							switch(cell.ColumnIndex)
							{
								case 0:
									sw.Write(cell.Value.ToString());
									sw.Write(" ");
									break;
								case 1:
									str = cell.Value.ToString();

									//sw.Write("("+cell.Value.ToString()+"h)");
									str=str.Remove(0,2);
									sw.Write("(" + str +"h)");
									sw.Write(",");
									break;
								case 2:
									sw.Write(cell.Value.ToString());
									break;
								default:
									break;
							}
						}
						sw.WriteLine();
					}



				foreach (DataGridViewRow row in dtg_vendor.Rows) //запись
					if (!row.IsNewRow)
					{

						foreach (DataGridViewCell cell in row.Cells)
						{
							switch (cell.ColumnIndex)
							{
								case 0:
									sw.Write(cell.Value.ToString());
									sw.Write(" ");
									break;
								case 1:
									str = cell.Value.ToString();

									//sw.Write("("+cell.Value.ToString()+"h)");
									str = str.Remove(0, 2);
									sw.Write("(" + str + "h)");
									sw.Write(",");
									break;
								case 2:
									sw.Write(cell.Value.ToString());
									break;
								default:
									break;
							}
						}
						sw.WriteLine();
					}



				foreach (DataGridViewRow row in dtg_us_nvr.Rows) //запись
					if (!row.IsNewRow)
					{
						foreach (DataGridViewCell cell in row.Cells)
						{
							switch (cell.ColumnIndex)
							{
								case 0:
									sw.Write(cell.Value.ToString());
									sw.Write(" ");
									break;
								case 1:
									str = cell.Value.ToString();

									//sw.Write("("+cell.Value.ToString()+"h)");
									str = str.Remove(0, 2);
									sw.Write("(" + str + "h)");
									sw.Write(",");
									break;
								case 2:
									sw.Write(cell.Value.ToString());
									break;
								default:
									break;
							}
						}
						sw.WriteLine();
					}


				foreach (DataGridViewRow row in dtg_vr1_mlg.Rows) //запись
					if (!row.IsNewRow)
					{
						foreach (DataGridViewCell cell in row.Cells)
						{
							switch (cell.ColumnIndex)
							{
								case 0:
									sw.Write(cell.Value.ToString());
									sw.Write(" ");
									break;
								case 1:
									str = cell.Value.ToString();

									//sw.Write("("+cell.Value.ToString()+"h)");
									str = str.Remove(0, 2);
									sw.Write("(" + str + "h)");
									sw.Write(",");
									break;
								case 2:
									sw.Write(cell.Value.ToString());
									break;
								default:
									break;
							}
						}
						sw.WriteLine();
					}



				foreach (DataGridViewRow row in dtg_net_lane.Rows) //запись
					if (!row.IsNewRow)
					{
						foreach (DataGridViewCell cell in row.Cells)
						{
							switch (cell.ColumnIndex)
							{
								case 0:
									sw.Write(cell.Value.ToString());
									sw.Write(" ");
									break;
								case 1:
									str = cell.Value.ToString();

									//sw.Write("("+cell.Value.ToString()+"h)");
									str = str.Remove(0, 2);
									sw.Write("(" + str + "h)");
									sw.Write(",");
									break;
								case 2:
									sw.Write(cell.Value.ToString());
									break;
								default:
									break;
							}
						}
						sw.WriteLine();
					}


				foreach (DataGridViewRow row in dtg_host_lane.Rows) //запись
					if (!row.IsNewRow)
					{
						foreach (DataGridViewCell cell in row.Cells)
						{
							switch (cell.ColumnIndex)
							{
								case 0:
									sw.Write(cell.Value.ToString());
									sw.Write(" ");
									break;
								case 1:
									str = cell.Value.ToString();

									//sw.Write("("+cell.Value.ToString()+"h)");
									str = str.Remove(0, 2);
									sw.Write("(" + str + "h)");
									sw.Write(",");
									break;
								case 2:
									sw.Write(cell.Value.ToString());
									break;
								default:
									break;
							}
						}
						sw.WriteLine();
					}

				sw.Close();
			}
			catch (Exception ex)
			{
				status_lbl.Text = ex.ToString();
				//MessageBox.Show(ex.ToString());
			}
		}

		private void btn_cfp_VR1_Click(object sender, EventArgs e)
		{
			if (_serialPort.IsOpen)
			{
				try
				{
					
					string strr = "", str_label = "";
					int count_word = 0xff + 1, sub_cnt = 25, addr;
					//int count_word = 0x01;

					addr = 0xA000;
					MDIO_Set_Read_addr_reg_dev(addr);
					MDIO_read_word_to_buffer(sub_cnt);

					dtg_vr1_mlg.Rows.Clear();

					while (count_word > 0)
					{
						for (int i = 0; (i < (count_rx_byte >> 1)) && (count_word > 0); i++)
						{
							--count_word;

							if (count_word < 128)
								str_label = "MLG VR1";
							if (count_word >= 128)
								str_label = "CFP VR1";


							//strr = "0x" + string.Format("{0:x2}", (read_buffer[i * 2 + 1])).ToUpper();
							strr = "0x" + string.Format("{0:x4}", (read_buffer[i * 2] << 8 | read_buffer[i * 2 + 1])).ToUpper();
							dtg_vr1_mlg.Rows.Add(str_label, "0x" + string.Format("{0:x4}", (addr)).ToUpper(), strr);
							++addr;

							//if (addr == 0x81ff)
							//	--count_word;
						}

						MDIO_Set_Read_addr_reg_dev(addr);
						MDIO_read_word_to_buffer(sub_cnt);
					}

					if (count_rx_byte >= (count_word + 1) * 2)
						status_lbl.Text = "Read complete. " + count_rx_byte.ToString();
					else
						status_lbl.Text = "read incomplet " + count_rx_byte.ToString();


					_serialPort.DiscardInBuffer();



				}
				catch (Exception ex)
				{
					status_lbl.Text = ex.ToString();
					//MessageBox.Show(ex.ToString());

				}
			}
		}

		private void btn_host_lane_Click(object sender, EventArgs e)
		{
			if (_serialPort.IsOpen)
			{
				try
				{
					string strr = "", str_label = "";
					int count_word = 127 + 1, sub_cnt = 25, addr;
					//int count_word = 0x01;

					addr = 0xA400;
					MDIO_Set_Read_addr_reg_dev(addr);
					MDIO_read_word_to_buffer(sub_cnt);

					dtg_host_lane.Rows.Clear();

					while (count_word > 0)
					{
						for (int i = 0; (i < (count_rx_byte >> 1)) && (count_word > 0); i++)
						{
							--count_word;

							str_label = "Host VR1";

							//strr = "0x" + string.Format("{0:x2}", (read_buffer[i * 2 + 1])).ToUpper();
							strr = "0x" + string.Format("{0:x4}", (read_buffer[i * 2] << 8 | read_buffer[i * 2 + 1])).ToUpper();
							dtg_host_lane.Rows.Add(str_label, "0x" + string.Format("{0:x4}", (addr)).ToUpper(), strr);
							++addr;

							//if (addr == 0x81ff)
							//	--count_word;
						}

						MDIO_Set_Read_addr_reg_dev(addr);
						MDIO_read_word_to_buffer(sub_cnt);
					}


					addr = 0xAC00;
					count_word = 1023+1;

					MDIO_Set_Read_addr_reg_dev(addr);
					MDIO_read_word_to_buffer(sub_cnt);

					while (count_word > 0)
					{
						for (int i = 0; (i < (count_rx_byte >> 1)) && (count_word > 0); i++)
						{
							
							if (count_word > 1024)
								str_label = "Alloc";
							if (count_word <= 1024)
								str_label = "Com DB";

							--count_word;

							//strr = "0x" + string.Format("{0:x2}", (read_buffer[i * 2 + 1])).ToUpper();
							strr = "0x" + string.Format("{0:x4}", (read_buffer[i * 2] << 8 | read_buffer[i * 2 + 1])).ToUpper();
							dtg_host_lane.Rows.Add(str_label, "0x" + string.Format("{0:x4}", (addr)).ToUpper(), strr);
							++addr;

							//if (addr == 0x81ff)
							//	--count_word;
						}

						MDIO_Set_Read_addr_reg_dev(addr);
						MDIO_read_word_to_buffer(sub_cnt);
					}



					if (count_rx_byte >= (count_word + 1) * 2)
						status_lbl.Text = "Read complete. " + count_rx_byte.ToString();
					else
						status_lbl.Text = "read incomplet " + count_rx_byte.ToString();


					_serialPort.DiscardInBuffer();
				}
				catch (Exception ex)
				{
					status_lbl.Text = ex.ToString();
					//MessageBox.Show(ex.ToString());

				}
			}
		}

		private void btn_read_one_Click_1(object sender, EventArgs e)
		{
			if (_serialPort.IsOpen)
			{
				try
				{

					string strr = "   ";//, str_label = "";
				//	byte dev = 0, phy = 0;
					int addr = 0x8008;
					//int count_word = 0x01;

					//MDIO_Set_Read_addr_reg_dev(0x8000);
					//int.TryParse(tb_hexaddr.Text, out addr);

					addr = int.Parse(tb_hexaddr.Text, NumberStyles.HexNumber);
                    //btn_read_one.Text = "0x" + string.Format("{0:x4}", (addr)).ToUpper();
                    MDIO_Set_Read_addr_reg_dev(addr);
                    MDIO_read_ONE_byte_to_buffer(addr);

					dtg_cfp_nvr.Rows.Clear();

					strr = "0x" + string.Format("{0:x4}", (read_buffer[0] << 8 | read_buffer[1])).ToUpper();
					//str_label = "addr";
					dtg_cfp_nvr.Rows.Add("", "0x" + string.Format("{0:x4}", (addr)).ToUpper(), strr);

					status_lbl.Text = "Read complete. " + count_rx_byte.ToString();


					_serialPort.DiscardInBuffer();
				}
				catch (Exception ex)
				{
					status_lbl.Text = ex.ToString();
					//MessageBox.Show(ex.ToString());

				}
			}
		}

		private void tb_hexaddr_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
				btn_read_one_Click_1(sender, e);
		}

		private void btn_write_mod_VR_Click(object sender, EventArgs e)
		{
			if (_serialPort.IsOpen && dtg_net_lane.Rows.Count != 0)
			{
				try
				{
					//string strr = "", str_label = "";
					int count_word = 0xff + 1, sub_cnt = 20, addr, cnt = 0;
					string[] local_read_buff = new string[count_word];
					//int count_word = 0x01;


					//считываем в буффер CFP модуль
					addr = 0xA000;
					MDIO_Set_Read_addr_reg_dev(addr);
					MDIO_read_word_to_buffer(sub_cnt);

					while (count_word > 0)
					{
						for (int i = 0; (i < (count_rx_byte >> 1)) && (count_word > 0); i++)
						{
							//strr = "0x" + string.Format("{0:x4}", (read_buffer[i * 2] << 8 | read_buffer[i * 2 + 1])).ToUpper();
							local_read_buff[cnt] = "0x" + string.Format("{0:x4}", (read_buffer[i * 2] << 8 | read_buffer[i * 2 + 1])).ToUpper();
							++cnt;
							--count_word;
							++addr;
						}
						MDIO_Set_Read_addr_reg_dev(addr);
						MDIO_read_word_to_buffer(sub_cnt);
					}

					pr_bar.Maximum = dtg_vr1_mlg.Rows.Count;
					addr = 0xA000;
					//сравниваем с тем что в datagrid разницу сразу записываем
					int j = 0, tmp = 0;
					cnt = 0;
					foreach (DataGridViewRow row in dtg_vr1_mlg.Rows)
					{
						if (row.Cells[2].Value.ToString() != local_read_buff[j])//записываем
						{
							++cnt;
							tmp = Convert.ToInt32(row.Cells[2].Value.ToString(), 16);    //tmp = Convert.ToUInt16(row.Cells[2].Value);
							MDIO_set_addr_reg(addr + j);

							MDIO_write_word(tmp);
						}
						++j;
						pr_bar.Value = j;
					}

					if (cnt > 0)
						status_lbl.Text = "Write complete. " + cnt.ToString();
					else
						status_lbl.Text = "no differences";

					_serialPort.DiscardInBuffer();
				}
				catch (Exception ex)
				{
					status_lbl.Text = ex.ToString();
					//MessageBox.Show(ex.ToString());
				}
			}

		}

		private void btn_write_ven_nvr_Click(object sender, EventArgs e)
		{

		}

        private void btn_stat_read_Click(object sender, EventArgs e)
        {

        }
    }
}
