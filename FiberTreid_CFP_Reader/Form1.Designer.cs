using System.Windows.Forms;

namespace FiberTreid_CFP_Reader
{
    partial class form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.connect = new System.Windows.Forms.Button();
            this.btn_read_all = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btn_write_cfp_nvr = new System.Windows.Forms.Button();
            this.textBox_psw_cfp_MSB = new System.Windows.Forms.TextBox();
            this.textBox_psw_cfp_LSB = new System.Windows.Forms.TextBox();
            this.textBox_psw_ven_LSB = new System.Windows.Forms.TextBox();
            this.textBox_psw_ven_MSB = new System.Windows.Forms.TextBox();
            this.btn_read_cfp_nvr = new System.Windows.Forms.Button();
            this.btn_read_ven_nvr = new System.Windows.Forms.Button();
            this.btn_write_ven_nvr = new System.Windows.Forms.Button();
            this.btn_read_user_nvr = new System.Windows.Forms.Button();
            this.btn_write_user_nvr = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_read_netw_nvr = new System.Windows.Forms.Button();
            this.btn_write_netw_nvr = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btn_stat_write = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status_lbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.pr_bar = new System.Windows.Forms.ToolStripProgressBar();
            this.status_date = new System.Windows.Forms.ToolStripStatusLabel();
            this.dtg_cfp_nvr = new System.Windows.Forms.DataGridView();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtg_net_lane = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_read_one = new System.Windows.Forms.Button();
            this.tb_hexaddr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtg_vendor = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtg_us_nvr = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btn_host_lane = new System.Windows.Forms.Button();
            this.btn_write_host_lane = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.dtg_host_lane = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtg_vr1_mlg = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_write_mod_VR = new System.Windows.Forms.Button();
            this.btn_cfp_VR1 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.file_open = new System.Windows.Forms.ToolStripMenuItem();
            this.file_save = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_read_data = new System.Windows.Forms.TextBox();
            this.t_st_stLBL_mod_abs = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ch_b_reset = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_cfp_nvr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_net_lane)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_vendor)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_us_nvr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_host_lane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_vr1_mlg)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.connect);
            this.flowLayoutPanel1.Controls.Add(this.btn_read_all);
            this.flowLayoutPanel1.Controls.Add(this.button6);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(532, 561);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(482, 33);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(3, 3);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(194, 23);
            this.connect.TabIndex = 0;
            this.connect.Text = "connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // btn_read_all
            // 
            this.btn_read_all.Enabled = false;
            this.btn_read_all.Location = new System.Drawing.Point(203, 3);
            this.btn_read_all.Name = "btn_read_all";
            this.btn_read_all.Size = new System.Drawing.Size(133, 23);
            this.btn_read_all.TabIndex = 1;
            this.btn_read_all.Text = "read all data CFP";
            this.btn_read_all.UseVisualStyleBackColor = true;
            this.btn_read_all.Click += new System.EventHandler(this.btn_read_all_Click);
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(342, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(133, 23);
            this.button6.TabIndex = 2;
            this.button6.Text = "write all data CFP";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // btn_write_cfp_nvr
            // 
            this.btn_write_cfp_nvr.Enabled = false;
            this.btn_write_cfp_nvr.Location = new System.Drawing.Point(199, 141);
            this.btn_write_cfp_nvr.Name = "btn_write_cfp_nvr";
            this.btn_write_cfp_nvr.Size = new System.Drawing.Size(133, 23);
            this.btn_write_cfp_nvr.TabIndex = 4;
            this.btn_write_cfp_nvr.Text = "write NVR";
            this.btn_write_cfp_nvr.UseVisualStyleBackColor = true;
            this.btn_write_cfp_nvr.Click += new System.EventHandler(this.btn_write_cfp_nvr_Click);
            // 
            // textBox_psw_cfp_MSB
            // 
            this.textBox_psw_cfp_MSB.Location = new System.Drawing.Point(274, 50);
            this.textBox_psw_cfp_MSB.Name = "textBox_psw_cfp_MSB";
            this.textBox_psw_cfp_MSB.Size = new System.Drawing.Size(58, 20);
            this.textBox_psw_cfp_MSB.TabIndex = 1;
            this.textBox_psw_cfp_MSB.Text = "0";
            // 
            // textBox_psw_cfp_LSB
            // 
            this.textBox_psw_cfp_LSB.Location = new System.Drawing.Point(274, 76);
            this.textBox_psw_cfp_LSB.Name = "textBox_psw_cfp_LSB";
            this.textBox_psw_cfp_LSB.Size = new System.Drawing.Size(58, 20);
            this.textBox_psw_cfp_LSB.TabIndex = 2;
            this.textBox_psw_cfp_LSB.Text = "0";
            // 
            // textBox_psw_ven_LSB
            // 
            this.textBox_psw_ven_LSB.Location = new System.Drawing.Point(610, 76);
            this.textBox_psw_ven_LSB.Name = "textBox_psw_ven_LSB";
            this.textBox_psw_ven_LSB.Size = new System.Drawing.Size(58, 20);
            this.textBox_psw_ven_LSB.TabIndex = 4;
            this.textBox_psw_ven_LSB.Text = "0";
            // 
            // textBox_psw_ven_MSB
            // 
            this.textBox_psw_ven_MSB.Location = new System.Drawing.Point(610, 50);
            this.textBox_psw_ven_MSB.Name = "textBox_psw_ven_MSB";
            this.textBox_psw_ven_MSB.Size = new System.Drawing.Size(58, 20);
            this.textBox_psw_ven_MSB.TabIndex = 3;
            this.textBox_psw_ven_MSB.Text = "0";
            // 
            // btn_read_cfp_nvr
            // 
            this.btn_read_cfp_nvr.Enabled = false;
            this.btn_read_cfp_nvr.Location = new System.Drawing.Point(199, 102);
            this.btn_read_cfp_nvr.Name = "btn_read_cfp_nvr";
            this.btn_read_cfp_nvr.Size = new System.Drawing.Size(133, 23);
            this.btn_read_cfp_nvr.TabIndex = 5;
            this.btn_read_cfp_nvr.Text = "read NVR";
            this.btn_read_cfp_nvr.UseVisualStyleBackColor = true;
            this.btn_read_cfp_nvr.Click += new System.EventHandler(this.btn_read_cfp_nvr_Click);
            // 
            // btn_read_ven_nvr
            // 
            this.btn_read_ven_nvr.Enabled = false;
            this.btn_read_ven_nvr.Location = new System.Drawing.Point(535, 102);
            this.btn_read_ven_nvr.Name = "btn_read_ven_nvr";
            this.btn_read_ven_nvr.Size = new System.Drawing.Size(133, 23);
            this.btn_read_ven_nvr.TabIndex = 6;
            this.btn_read_ven_nvr.Text = "read NVR";
            this.btn_read_ven_nvr.UseVisualStyleBackColor = true;
            this.btn_read_ven_nvr.Click += new System.EventHandler(this.btn_read_ven_nvr_Click);
            // 
            // btn_write_ven_nvr
            // 
            this.btn_write_ven_nvr.Enabled = false;
            this.btn_write_ven_nvr.Location = new System.Drawing.Point(535, 141);
            this.btn_write_ven_nvr.Name = "btn_write_ven_nvr";
            this.btn_write_ven_nvr.Size = new System.Drawing.Size(133, 23);
            this.btn_write_ven_nvr.TabIndex = 7;
            this.btn_write_ven_nvr.Text = "write NVR";
            this.btn_write_ven_nvr.UseVisualStyleBackColor = true;
            this.btn_write_ven_nvr.Click += new System.EventHandler(this.btn_write_ven_nvr_Click);
            // 
            // btn_read_user_nvr
            // 
            this.btn_read_user_nvr.Enabled = false;
            this.btn_read_user_nvr.Location = new System.Drawing.Point(192, 68);
            this.btn_read_user_nvr.Name = "btn_read_user_nvr";
            this.btn_read_user_nvr.Size = new System.Drawing.Size(133, 23);
            this.btn_read_user_nvr.TabIndex = 13;
            this.btn_read_user_nvr.Text = "read NVR";
            this.btn_read_user_nvr.UseVisualStyleBackColor = true;
            this.btn_read_user_nvr.Click += new System.EventHandler(this.btn_read_user_nvr_Click);
            // 
            // btn_write_user_nvr
            // 
            this.btn_write_user_nvr.Enabled = false;
            this.btn_write_user_nvr.Location = new System.Drawing.Point(192, 107);
            this.btn_write_user_nvr.Name = "btn_write_user_nvr";
            this.btn_write_user_nvr.Size = new System.Drawing.Size(133, 23);
            this.btn_write_user_nvr.TabIndex = 12;
            this.btn_write_user_nvr.Text = "write NVR";
            this.btn_write_user_nvr.UseVisualStyleBackColor = true;
            this.btn_write_user_nvr.Click += new System.EventHandler(this.btn_write_user_nvr_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(267, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(58, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "0";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(267, 16);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(58, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "pswd MSB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "pswd LSB";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(550, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "pswd LSB";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(550, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "pswd MSB";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(203, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "pswd LSB";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(203, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "pswd MSB";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(546, 344);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "pswd LSB";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(546, 318);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "pswd MSB";
            // 
            // btn_read_netw_nvr
            // 
            this.btn_read_netw_nvr.Enabled = false;
            this.btn_read_netw_nvr.Location = new System.Drawing.Point(535, 367);
            this.btn_read_netw_nvr.Name = "btn_read_netw_nvr";
            this.btn_read_netw_nvr.Size = new System.Drawing.Size(133, 23);
            this.btn_read_netw_nvr.TabIndex = 18;
            this.btn_read_netw_nvr.Text = "read NVR";
            this.btn_read_netw_nvr.UseVisualStyleBackColor = true;
            this.btn_read_netw_nvr.Click += new System.EventHandler(this.btn_read_netw_nvr_Click);
            // 
            // btn_write_netw_nvr
            // 
            this.btn_write_netw_nvr.Enabled = false;
            this.btn_write_netw_nvr.Location = new System.Drawing.Point(535, 406);
            this.btn_write_netw_nvr.Name = "btn_write_netw_nvr";
            this.btn_write_netw_nvr.Size = new System.Drawing.Size(133, 23);
            this.btn_write_netw_nvr.TabIndex = 17;
            this.btn_write_netw_nvr.Text = "write NVR";
            this.btn_write_netw_nvr.UseVisualStyleBackColor = true;
            this.btn_write_netw_nvr.Click += new System.EventHandler(this.btn_write_netw_nvr_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(610, 341);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(58, 20);
            this.textBox3.TabIndex = 16;
            this.textBox3.Text = "0";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(610, 315);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(58, 20);
            this.textBox4.TabIndex = 15;
            this.textBox4.Text = "0";
            // 
            // btn_stat_write
            // 
            this.btn_stat_write.Enabled = false;
            this.btn_stat_write.Location = new System.Drawing.Point(362, 566);
            this.btn_stat_write.Name = "btn_stat_write";
            this.btn_stat_write.Size = new System.Drawing.Size(46, 23);
            this.btn_stat_write.TabIndex = 35;
            this.btn_stat_write.Text = "write";
            this.btn_stat_write.UseVisualStyleBackColor = true;
            this.btn_stat_write.Click += new System.EventHandler(this.btn_stat_write_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_lbl,
            this.pr_bar,
            this.t_st_stLBL_mod_abs,
            this.status_date});
            this.statusStrip1.Location = new System.Drawing.Point(0, 597);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1021, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 37;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // status_lbl
            // 
            this.status_lbl.AutoSize = false;
            this.status_lbl.BorderStyle = System.Windows.Forms.Border3DStyle.Sunken;
            this.status_lbl.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.status_lbl.Name = "status_lbl";
            this.status_lbl.Size = new System.Drawing.Size(699, 17);
            this.status_lbl.Spring = true;
            this.status_lbl.Text = "Ready...";
            this.status_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pr_bar
            // 
            this.pr_bar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.pr_bar.Name = "pr_bar";
            this.pr_bar.Size = new System.Drawing.Size(200, 16);
            // 
            // status_date
            // 
            this.status_date.BorderStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.status_date.Name = "status_date";
            this.status_date.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.status_date.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.status_date.Size = new System.Drawing.Size(50, 17);
            this.status_date.Text = "date";
            this.status_date.ToolTipText = "Started: 17:34";
            // 
            // dtg_cfp_nvr
            // 
            this.dtg_cfp_nvr.AllowUserToAddRows = false;
            this.dtg_cfp_nvr.AllowUserToDeleteRows = false;
            this.dtg_cfp_nvr.AllowUserToResizeRows = false;
            this.dtg_cfp_nvr.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_cfp_nvr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtg_cfp_nvr.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtg_cfp_nvr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.desc,
            this.Column2,
            this.data,
            this.Column4});
            this.dtg_cfp_nvr.Location = new System.Drawing.Point(12, 50);
            this.dtg_cfp_nvr.Name = "dtg_cfp_nvr";
            this.dtg_cfp_nvr.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtg_cfp_nvr.RowHeadersVisible = false;
            this.dtg_cfp_nvr.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle1.Format = "X04";
            this.dtg_cfp_nvr.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_cfp_nvr.Size = new System.Drawing.Size(181, 228);
            this.dtg_cfp_nvr.TabIndex = 38;
            this.dtg_cfp_nvr.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.dtg_cfp_nvr_CellParsing);
            // 
            // desc
            // 
            this.desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.desc.HeaderText = "Desc";
            this.desc.Name = "desc";
            this.desc.ReadOnly = true;
            this.desc.Width = 57;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "addr";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 53;
            // 
            // data
            // 
            this.data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.data.HeaderText = "hex";
            this.data.Name = "data";
            this.data.Width = 49;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column4.HeaderText = "ASCII";
            this.Column4.Name = "Column4";
            this.Column4.Width = 59;
            // 
            // dtg_net_lane
            // 
            this.dtg_net_lane.AllowUserToAddRows = false;
            this.dtg_net_lane.AllowUserToDeleteRows = false;
            this.dtg_net_lane.AllowUserToResizeRows = false;
            this.dtg_net_lane.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_net_lane.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_net_lane.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtg_net_lane.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtg_net_lane.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn9});
            this.dtg_net_lane.Location = new System.Drawing.Point(348, 315);
            this.dtg_net_lane.Name = "dtg_net_lane";
            this.dtg_net_lane.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtg_net_lane.RowHeadersVisible = false;
            dataGridViewCellStyle2.Format = "x04";
            dataGridViewCellStyle2.NullValue = null;
            this.dtg_net_lane.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_net_lane.Size = new System.Drawing.Size(181, 228);
            this.dtg_net_lane.TabIndex = 38;
            this.dtg_net_lane.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.dtg_net_lane_CellParsing);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewTextBoxColumn5.HeaderText = "Desc";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 5;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewTextBoxColumn6.HeaderText = "addr";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 5;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewTextBoxColumn9.HeaderText = "hex";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(7, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 254);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CFP NVR (RO)";
            // 
            // btn_read_one
            // 
            this.btn_read_one.Enabled = false;
            this.btn_read_one.Location = new System.Drawing.Point(209, 566);
            this.btn_read_one.Name = "btn_read_one";
            this.btn_read_one.Size = new System.Drawing.Size(133, 23);
            this.btn_read_one.TabIndex = 0;
            this.btn_read_one.Text = "read";
            this.btn_read_one.UseVisualStyleBackColor = true;
            this.btn_read_one.Click += new System.EventHandler(this.btn_read_one_Click_1);
            // 
            // tb_hexaddr
            // 
            this.tb_hexaddr.AcceptsReturn = true;
            this.tb_hexaddr.Location = new System.Drawing.Point(46, 569);
            this.tb_hexaddr.Name = "tb_hexaddr";
            this.tb_hexaddr.Size = new System.Drawing.Size(58, 20);
            this.tb_hexaddr.TabIndex = 41;
            this.tb_hexaddr.Text = "8800";
            this.tb_hexaddr.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_hexaddr_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 572);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "addr";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtg_vendor);
            this.groupBox2.Location = new System.Drawing.Point(343, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 254);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vendor NVR (RO)";
            // 
            // dtg_vendor
            // 
            this.dtg_vendor.AllowUserToAddRows = false;
            this.dtg_vendor.AllowUserToDeleteRows = false;
            this.dtg_vendor.AllowUserToResizeRows = false;
            this.dtg_vendor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_vendor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_vendor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtg_vendor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtg_vendor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn16});
            this.dtg_vendor.Location = new System.Drawing.Point(6, 16);
            this.dtg_vendor.Name = "dtg_vendor";
            this.dtg_vendor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtg_vendor.RowHeadersVisible = false;
            dataGridViewCellStyle3.Format = "X04";
            this.dtg_vendor.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_vendor.Size = new System.Drawing.Size(181, 228);
            this.dtg_vendor.TabIndex = 38;
            this.dtg_vendor.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.dtg_cfp_nvr_CellParsing);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewTextBoxColumn1.HeaderText = "Desc";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 5;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewTextBoxColumn2.HeaderText = "addr";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 5;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewTextBoxColumn7.HeaderText = "hex";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 5;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewTextBoxColumn16.HeaderText = "ASCII";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(343, 294);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(335, 254);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Network lane VR (RW)";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtg_us_nvr);
            this.groupBox4.Controls.Add(this.textBox2);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.btn_read_user_nvr);
            this.groupBox4.Controls.Add(this.btn_write_user_nvr);
            this.groupBox4.Location = new System.Drawing.Point(679, 34);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(335, 254);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "User NVR (RW)";
            // 
            // dtg_us_nvr
            // 
            this.dtg_us_nvr.AllowUserToAddRows = false;
            this.dtg_us_nvr.AllowUserToDeleteRows = false;
            this.dtg_us_nvr.AllowUserToResizeRows = false;
            this.dtg_us_nvr.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_us_nvr.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_us_nvr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtg_us_nvr.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtg_us_nvr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn17});
            this.dtg_us_nvr.Location = new System.Drawing.Point(5, 16);
            this.dtg_us_nvr.Name = "dtg_us_nvr";
            this.dtg_us_nvr.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtg_us_nvr.RowHeadersVisible = false;
            dataGridViewCellStyle4.Format = "X04";
            this.dtg_us_nvr.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtg_us_nvr.Size = new System.Drawing.Size(181, 228);
            this.dtg_us_nvr.TabIndex = 38;
            this.dtg_us_nvr.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.dtg_cfp_nvr_CellParsing);
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewTextBoxColumn3.HeaderText = "Desc";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 5;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewTextBoxColumn4.HeaderText = "addr";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 5;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewTextBoxColumn8.HeaderText = "hex";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 5;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewTextBoxColumn17.HeaderText = "ASCII";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 5;
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(679, 294);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(335, 254);
            this.groupBox6.TabIndex = 40;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Host Lane, Common data, Allocated for OIF (RW)";
            // 
            // btn_host_lane
            // 
            this.btn_host_lane.Enabled = false;
            this.btn_host_lane.Location = new System.Drawing.Point(871, 367);
            this.btn_host_lane.Name = "btn_host_lane";
            this.btn_host_lane.Size = new System.Drawing.Size(133, 23);
            this.btn_host_lane.TabIndex = 18;
            this.btn_host_lane.Text = "read NVR";
            this.btn_host_lane.UseVisualStyleBackColor = true;
            this.btn_host_lane.Click += new System.EventHandler(this.btn_host_lane_Click);
            // 
            // btn_write_host_lane
            // 
            this.btn_write_host_lane.Enabled = false;
            this.btn_write_host_lane.Location = new System.Drawing.Point(871, 406);
            this.btn_write_host_lane.Name = "btn_write_host_lane";
            this.btn_write_host_lane.Size = new System.Drawing.Size(133, 23);
            this.btn_write_host_lane.TabIndex = 17;
            this.btn_write_host_lane.Text = "write NVR";
            this.btn_write_host_lane.UseVisualStyleBackColor = true;
            this.btn_write_host_lane.Click += new System.EventHandler(this.btn_write_netw_nvr_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(882, 318);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 13);
            this.label17.TabIndex = 30;
            this.label17.Text = "pswd MSB";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(946, 341);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(58, 20);
            this.textBox10.TabIndex = 16;
            this.textBox10.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(882, 344);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 13);
            this.label18.TabIndex = 31;
            this.label18.Text = "pswd LSB";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(946, 315);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(58, 20);
            this.textBox11.TabIndex = 15;
            this.textBox11.Text = "0";
            // 
            // dtg_host_lane
            // 
            this.dtg_host_lane.AllowUserToAddRows = false;
            this.dtg_host_lane.AllowUserToDeleteRows = false;
            this.dtg_host_lane.AllowUserToResizeRows = false;
            this.dtg_host_lane.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_host_lane.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_host_lane.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtg_host_lane.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtg_host_lane.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
            this.dtg_host_lane.Location = new System.Drawing.Point(684, 315);
            this.dtg_host_lane.Name = "dtg_host_lane";
            this.dtg_host_lane.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtg_host_lane.RowHeadersVisible = false;
            dataGridViewCellStyle5.Format = "x04";
            dataGridViewCellStyle5.NullValue = null;
            this.dtg_host_lane.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtg_host_lane.Size = new System.Drawing.Size(181, 228);
            this.dtg_host_lane.TabIndex = 38;
            this.dtg_host_lane.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.dtg_net_lane_CellParsing);
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewTextBoxColumn13.HeaderText = "Desc";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 5;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewTextBoxColumn14.HeaderText = "addr";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 5;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewTextBoxColumn15.HeaderText = "hex";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 5;
            // 
            // dtg_vr1_mlg
            // 
            this.dtg_vr1_mlg.AllowUserToAddRows = false;
            this.dtg_vr1_mlg.AllowUserToDeleteRows = false;
            this.dtg_vr1_mlg.AllowUserToResizeRows = false;
            this.dtg_vr1_mlg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_vr1_mlg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtg_vr1_mlg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtg_vr1_mlg.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtg_vr1_mlg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.dtg_vr1_mlg.Location = new System.Drawing.Point(5, 21);
            this.dtg_vr1_mlg.Name = "dtg_vr1_mlg";
            this.dtg_vr1_mlg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtg_vr1_mlg.RowHeadersVisible = false;
            dataGridViewCellStyle6.Format = "X04";
            this.dtg_vr1_mlg.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtg_vr1_mlg.Size = new System.Drawing.Size(181, 228);
            this.dtg_vr1_mlg.TabIndex = 47;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewTextBoxColumn10.HeaderText = "Desc";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 5;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewTextBoxColumn11.HeaderText = "addr";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 5;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.dataGridViewTextBoxColumn12.HeaderText = "hex";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "pswd LSB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "pswd MSB";
            // 
            // btn_write_mod_VR
            // 
            this.btn_write_mod_VR.Enabled = false;
            this.btn_write_mod_VR.Location = new System.Drawing.Point(192, 112);
            this.btn_write_mod_VR.Name = "btn_write_mod_VR";
            this.btn_write_mod_VR.Size = new System.Drawing.Size(133, 23);
            this.btn_write_mod_VR.TabIndex = 44;
            this.btn_write_mod_VR.Text = "write NVR";
            this.btn_write_mod_VR.UseVisualStyleBackColor = true;
            this.btn_write_mod_VR.Click += new System.EventHandler(this.btn_write_mod_VR_Click);
            // 
            // btn_cfp_VR1
            // 
            this.btn_cfp_VR1.Enabled = false;
            this.btn_cfp_VR1.Location = new System.Drawing.Point(192, 73);
            this.btn_cfp_VR1.Name = "btn_cfp_VR1";
            this.btn_cfp_VR1.Size = new System.Drawing.Size(133, 23);
            this.btn_cfp_VR1.TabIndex = 43;
            this.btn_cfp_VR1.Text = "read NVR";
            this.btn_cfp_VR1.UseVisualStyleBackColor = true;
            this.btn_cfp_VR1.Click += new System.EventHandler(this.btn_cfp_VR1_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(267, 43);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(58, 20);
            this.textBox6.TabIndex = 42;
            this.textBox6.Text = "0";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(267, 17);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(58, 20);
            this.textBox5.TabIndex = 41;
            this.textBox5.Text = "0";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.dtg_vr1_mlg);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.btn_write_mod_VR);
            this.groupBox5.Controls.Add(this.textBox6);
            this.groupBox5.Controls.Add(this.btn_cfp_VR1);
            this.groupBox5.Controls.Add(this.textBox5);
            this.groupBox5.Location = new System.Drawing.Point(7, 294);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(335, 254);
            this.groupBox5.TabIndex = 48;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "CFP module VR1. MLG VR1. (RW)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileOpenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1021, 24);
            this.menuStrip1.TabIndex = 49;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileOpenToolStripMenuItem
            // 
            this.fileOpenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_open,
            this.file_save});
            this.fileOpenToolStripMenuItem.Name = "fileOpenToolStripMenuItem";
            this.fileOpenToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileOpenToolStripMenuItem.Text = "File";
            // 
            // file_open
            // 
            this.file_open.Name = "file_open";
            this.file_open.Size = new System.Drawing.Size(131, 22);
            this.file_open.Text = "File open...";
            this.file_open.Click += new System.EventHandler(this.file_open_Click);
            // 
            // file_save
            // 
            this.file_save.Name = "file_save";
            this.file_save.Size = new System.Drawing.Size(131, 22);
            this.file_save.Text = "File save...";
            this.file_save.Click += new System.EventHandler(this.file_save_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 572);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "data";
            // 
            // tb_read_data
            // 
            this.tb_read_data.AcceptsReturn = true;
            this.tb_read_data.Location = new System.Drawing.Point(145, 568);
            this.tb_read_data.Name = "tb_read_data";
            this.tb_read_data.Size = new System.Drawing.Size(58, 20);
            this.tb_read_data.TabIndex = 41;
            this.tb_read_data.TextChanged += new System.EventHandler(this.tb_read_data_TextChanged);
            // 
            // t_st_stLBL_mod_abs
            // 
            this.t_st_stLBL_mod_abs.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.t_st_stLBL_mod_abs.Enabled = false;
            this.t_st_stLBL_mod_abs.Name = "t_st_stLBL_mod_abs";
            this.t_st_stLBL_mod_abs.Size = new System.Drawing.Size(55, 17);
            this.t_st_stLBL_mod_abs.Text = "mod_abs";
            // 
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ch_b_reset
            // 
            this.ch_b_reset.AutoSize = true;
            this.ch_b_reset.Enabled = false;
            this.ch_b_reset.Location = new System.Drawing.Point(433, 570);
            this.ch_b_reset.Name = "ch_b_reset";
            this.ch_b_reset.Size = new System.Drawing.Size(77, 17);
            this.ch_b_reset.TabIndex = 51;
            this.ch_b_reset.Text = "reset MOD";
            this.ch_b_reset.UseVisualStyleBackColor = true;
            this.ch_b_reset.CheckedChanged += new System.EventHandler(this.ch_b_reset_CheckedChanged);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 619);
            this.Controls.Add(this.ch_b_reset);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_read_data);
            this.Controls.Add(this.tb_hexaddr);
            this.Controls.Add(this.btn_read_one);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.dtg_host_lane);
            this.Controls.Add(this.dtg_net_lane);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btn_stat_write);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btn_write_host_lane);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_host_lane);
            this.Controls.Add(this.btn_write_netw_nvr);
            this.Controls.Add(this.btn_read_netw_nvr);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_write_ven_nvr);
            this.Controls.Add(this.btn_read_ven_nvr);
            this.Controls.Add(this.btn_read_cfp_nvr);
            this.Controls.Add(this.textBox_psw_ven_LSB);
            this.Controls.Add(this.textBox_psw_ven_MSB);
            this.Controls.Add(this.btn_write_cfp_nvr);
            this.Controls.Add(this.textBox_psw_cfp_LSB);
            this.Controls.Add(this.textBox_psw_cfp_MSB);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dtg_cfp_nvr);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "form1";
            this.Text = "FiberTreid CFP Reader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form1_FormClosing);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_cfp_nvr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_net_lane)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_vendor)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_us_nvr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_host_lane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_vr1_mlg)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button connect;

        delegate void SetTextCallback(string text);



        private void CreateMyStatusBar()
        {
            // Create a StatusBar control.
               StatusBar statusBar1 = new StatusBar();
            // Create two StatusBarPanel objects to display in the StatusBar.
            StatusBarPanel panel1 = new StatusBarPanel();
            StatusBarPanel panel2 = new StatusBarPanel();
            // Display the first panel with a sunken border style.
            panel1.BorderStyle = StatusBarPanelBorderStyle.Sunken;
            // Initialize the text of the panel.
            panel1.Text = "Ready...";
            // Set the AutoSize property to use all remaining space on the StatusBar.
            panel1.AutoSize = StatusBarPanelAutoSize.Spring;

            // Display the second panel with a raised border style.
            panel2.BorderStyle = StatusBarPanelBorderStyle.Raised;

            // Create ToolTip text that displays time the application was 
            //started.
            panel2.ToolTipText = "Started: " + System.DateTime.Now.ToShortTimeString();
            // Set the text of the panel to the current date.
            panel2.Text = System.DateTime.Today.ToLongDateString();
            // Set the AutoSize property to size the panel to the size of the contents.
            panel2.AutoSize = StatusBarPanelAutoSize.Contents;

            // Display panels in the StatusBar control.
            statusBar1.ShowPanels = true;

            // Add both panels to the StatusBarPanelCollection of the StatusBar.			
            statusBar1.Panels.Add(panel1);
            statusBar1.Panels.Add(panel2);

            // Add the StatusBar to the form.
            this.Controls.Add(statusBar1);
        }

        private Button btn_read_all;
        private Button button6;
        private Button btn_write_cfp_nvr;
        private TextBox textBox_psw_cfp_MSB;
        private TextBox textBox_psw_cfp_LSB;
        private TextBox textBox_psw_ven_LSB;
        private TextBox textBox_psw_ven_MSB;
        private Button btn_read_cfp_nvr;
        private Button btn_read_ven_nvr;
        private Button btn_write_ven_nvr;
        private Button btn_read_user_nvr;
        private Button btn_write_user_nvr;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button btn_read_netw_nvr;
        private Button btn_write_netw_nvr;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button btn_stat_write;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel status_lbl;
        private ToolStripProgressBar pr_bar;
        private ToolStripStatusLabel status_date;
        private DataGridView dtg_cfp_nvr;
		private DataGridView dtg_net_lane;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private GroupBox groupBox1;
		private GroupBox groupBox2;
		private GroupBox groupBox3;
		private GroupBox groupBox4;
		private GroupBox groupBox6;
		private Button btn_host_lane;
		private Button btn_write_host_lane;
		private Label label17;
		private TextBox textBox10;
		private Label label18;
		private TextBox textBox11;
		private DataGridView dtg_host_lane;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
		private DataGridView dtg_vr1_mlg;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
		private Label label4;
		private Label label3;
		private Button btn_write_mod_VR;
		private Button btn_cfp_VR1;
		private TextBox textBox6;
		private TextBox textBox5;
		private GroupBox groupBox5;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem fileOpenToolStripMenuItem;
		private ToolStripMenuItem file_save;
		private ToolStripMenuItem file_open;
		private Button btn_read_one;
		private TextBox tb_hexaddr;
		private Label label5;
		private DataGridView dtg_vendor;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
		private DataGridView dtg_us_nvr;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn desc;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn data;
        private DataGridViewTextBoxColumn Column4;
        private Label label6;
        private TextBox tb_read_data;
        private ToolStripStatusLabel t_st_stLBL_mod_abs;
        private Timer timer1;
        private CheckBox ch_b_reset;
    }
}

