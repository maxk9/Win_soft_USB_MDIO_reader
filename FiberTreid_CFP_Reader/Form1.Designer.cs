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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.status_lbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.pr_bar = new System.Windows.Forms.ToolStripProgressBar();
            this.t_st_stLBL_mod_abs = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_date = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.file_open = new System.Windows.Forms.ToolStripMenuItem();
            this.file_save = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ch_b_reset = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_read_data = new System.Windows.Forms.TextBox();
            this.tb_hexaddr = new System.Windows.Forms.TextBox();
            this.btn_read_one = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtg_vr1_mlg = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_write_mod_VR = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.btn_cfp_VR1 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dtg_host_lane = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtg_net_lane = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_stat_write = new System.Windows.Forms.Button();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btn_write_host_lane = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_host_lane = new System.Windows.Forms.Button();
            this.btn_write_netw_nvr = new System.Windows.Forms.Button();
            this.btn_read_netw_nvr = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_write_ven_nvr = new System.Windows.Forms.Button();
            this.btn_read_ven_nvr = new System.Windows.Forms.Button();
            this.btn_read_cfp_nvr = new System.Windows.Forms.Button();
            this.textBox_psw_ven_LSB = new System.Windows.Forms.TextBox();
            this.textBox_psw_ven_MSB = new System.Windows.Forms.TextBox();
            this.btn_write_cfp_nvr = new System.Windows.Forms.Button();
            this.textBox_psw_cfp_LSB = new System.Windows.Forms.TextBox();
            this.textBox_psw_cfp_MSB = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.connect = new System.Windows.Forms.Button();
            this.btn_read_all = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtg_us_nvr = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_read_user_nvr = new System.Windows.Forms.Button();
            this.btn_write_user_nvr = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtg_vendor = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtg_cfp_nvr = new System.Windows.Forms.DataGridView();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_vr1_mlg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_host_lane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_net_lane)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_us_nvr)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_vendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_cfp_nvr)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_lbl,
            this.pr_bar,
            this.t_st_stLBL_mod_abs,
            this.status_date});
            this.statusStrip1.Location = new System.Drawing.Point(0, 619);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1026, 22);
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
            this.status_lbl.Size = new System.Drawing.Size(704, 17);
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
            // t_st_stLBL_mod_abs
            // 
            this.t_st_stLBL_mod_abs.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.t_st_stLBL_mod_abs.Enabled = false;
            this.t_st_stLBL_mod_abs.Name = "t_st_stLBL_mod_abs";
            this.t_st_stLBL_mod_abs.Size = new System.Drawing.Size(55, 17);
            this.t_st_stLBL_mod_abs.Text = "mod_abs";
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileOpenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1026, 24);
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
            // timer1
            // 
            this.timer1.Interval = 300;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1026, 595);
            this.tabControl1.TabIndex = 50;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ch_b_reset);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.tb_read_data);
            this.tabPage1.Controls.Add(this.tb_hexaddr);
            this.tabPage1.Controls.Add(this.btn_read_one);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.dtg_host_lane);
            this.tabPage1.Controls.Add(this.dtg_net_lane);
            this.tabPage1.Controls.Add(this.btn_stat_write);
            this.tabPage1.Controls.Add(this.textBox11);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox10);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.btn_write_host_lane);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.btn_host_lane);
            this.tabPage1.Controls.Add(this.btn_write_netw_nvr);
            this.tabPage1.Controls.Add(this.btn_read_netw_nvr);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btn_write_ven_nvr);
            this.tabPage1.Controls.Add(this.btn_read_ven_nvr);
            this.tabPage1.Controls.Add(this.btn_read_cfp_nvr);
            this.tabPage1.Controls.Add(this.textBox_psw_ven_LSB);
            this.tabPage1.Controls.Add(this.textBox_psw_ven_MSB);
            this.tabPage1.Controls.Add(this.btn_write_cfp_nvr);
            this.tabPage1.Controls.Add(this.textBox_psw_cfp_LSB);
            this.tabPage1.Controls.Add(this.textBox_psw_cfp_MSB);
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.dtg_cfp_nvr);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1018, 569);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ch_b_reset
            // 
            this.ch_b_reset.AutoSize = true;
            this.ch_b_reset.Enabled = false;
            this.ch_b_reset.Location = new System.Drawing.Point(432, 542);
            this.ch_b_reset.Name = "ch_b_reset";
            this.ch_b_reset.Size = new System.Drawing.Size(77, 17);
            this.ch_b_reset.TabIndex = 92;
            this.ch_b_reset.Text = "reset MOD";
            this.ch_b_reset.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 544);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 91;
            this.label6.Text = "data";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 544);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 75;
            this.label5.Text = "addr";
            // 
            // tb_read_data
            // 
            this.tb_read_data.AcceptsReturn = true;
            this.tb_read_data.Location = new System.Drawing.Point(144, 540);
            this.tb_read_data.Name = "tb_read_data";
            this.tb_read_data.Size = new System.Drawing.Size(58, 20);
            this.tb_read_data.TabIndex = 87;
            // 
            // tb_hexaddr
            // 
            this.tb_hexaddr.AcceptsReturn = true;
            this.tb_hexaddr.Location = new System.Drawing.Point(45, 541);
            this.tb_hexaddr.Name = "tb_hexaddr";
            this.tb_hexaddr.Size = new System.Drawing.Size(58, 20);
            this.tb_hexaddr.TabIndex = 86;
            this.tb_hexaddr.Text = "a004";
            // 
            // btn_read_one
            // 
            this.btn_read_one.Enabled = false;
            this.btn_read_one.Location = new System.Drawing.Point(208, 538);
            this.btn_read_one.Name = "btn_read_one";
            this.btn_read_one.Size = new System.Drawing.Size(133, 23);
            this.btn_read_one.TabIndex = 88;
            this.btn_read_one.Text = "read";
            this.btn_read_one.UseVisualStyleBackColor = true;
            this.btn_read_one.Click += new System.EventHandler(this.btn_read_one_Click_1);
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
            this.groupBox5.Location = new System.Drawing.Point(6, 266);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(335, 254);
            this.groupBox5.TabIndex = 90;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "CFP module VR1. MLG VR1. (RW)";
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
            dataGridViewCellStyle1.Format = "X04";
            this.dtg_vr1_mlg.RowsDefaultCellStyle = dataGridViewCellStyle1;
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
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(267, 43);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(58, 20);
            this.textBox6.TabIndex = 42;
            this.textBox6.Text = "0";
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
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(267, 17);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(58, 20);
            this.textBox5.TabIndex = 41;
            this.textBox5.Text = "0";
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
            this.dtg_host_lane.Location = new System.Drawing.Point(683, 287);
            this.dtg_host_lane.Name = "dtg_host_lane";
            this.dtg_host_lane.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtg_host_lane.RowHeadersVisible = false;
            dataGridViewCellStyle2.Format = "x04";
            dataGridViewCellStyle2.NullValue = null;
            this.dtg_host_lane.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_host_lane.Size = new System.Drawing.Size(181, 228);
            this.dtg_host_lane.TabIndex = 79;
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
            this.dtg_net_lane.Location = new System.Drawing.Point(347, 287);
            this.dtg_net_lane.Name = "dtg_net_lane";
            this.dtg_net_lane.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtg_net_lane.RowHeadersVisible = false;
            dataGridViewCellStyle3.Format = "x04";
            dataGridViewCellStyle3.NullValue = null;
            this.dtg_net_lane.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_net_lane.Size = new System.Drawing.Size(181, 228);
            this.dtg_net_lane.TabIndex = 78;
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
            // btn_stat_write
            // 
            this.btn_stat_write.Enabled = false;
            this.btn_stat_write.Location = new System.Drawing.Point(361, 538);
            this.btn_stat_write.Name = "btn_stat_write";
            this.btn_stat_write.Size = new System.Drawing.Size(46, 23);
            this.btn_stat_write.TabIndex = 89;
            this.btn_stat_write.Text = "write";
            this.btn_stat_write.UseVisualStyleBackColor = true;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(945, 287);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(58, 20);
            this.textBox11.TabIndex = 61;
            this.textBox11.Text = "0";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(881, 316);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 13);
            this.label18.TabIndex = 76;
            this.label18.Text = "pswd LSB";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(609, 287);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(58, 20);
            this.textBox4.TabIndex = 62;
            this.textBox4.Text = "0";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(945, 313);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(58, 20);
            this.textBox10.TabIndex = 64;
            this.textBox10.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(545, 316);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 77;
            this.label11.Text = "pswd LSB";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(881, 290);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 13);
            this.label17.TabIndex = 73;
            this.label17.Text = "pswd MSB";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(609, 313);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(58, 20);
            this.textBox3.TabIndex = 63;
            this.textBox3.Text = "0";
            // 
            // btn_write_host_lane
            // 
            this.btn_write_host_lane.Enabled = false;
            this.btn_write_host_lane.Location = new System.Drawing.Point(870, 378);
            this.btn_write_host_lane.Name = "btn_write_host_lane";
            this.btn_write_host_lane.Size = new System.Drawing.Size(133, 23);
            this.btn_write_host_lane.TabIndex = 65;
            this.btn_write_host_lane.Text = "write NVR";
            this.btn_write_host_lane.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(545, 290);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 74;
            this.label12.Text = "pswd MSB";
            // 
            // btn_host_lane
            // 
            this.btn_host_lane.Enabled = false;
            this.btn_host_lane.Location = new System.Drawing.Point(870, 339);
            this.btn_host_lane.Name = "btn_host_lane";
            this.btn_host_lane.Size = new System.Drawing.Size(133, 23);
            this.btn_host_lane.TabIndex = 67;
            this.btn_host_lane.Text = "read NVR";
            this.btn_host_lane.UseVisualStyleBackColor = true;
            // 
            // btn_write_netw_nvr
            // 
            this.btn_write_netw_nvr.Enabled = false;
            this.btn_write_netw_nvr.Location = new System.Drawing.Point(534, 378);
            this.btn_write_netw_nvr.Name = "btn_write_netw_nvr";
            this.btn_write_netw_nvr.Size = new System.Drawing.Size(133, 23);
            this.btn_write_netw_nvr.TabIndex = 66;
            this.btn_write_netw_nvr.Text = "write NVR";
            this.btn_write_netw_nvr.UseVisualStyleBackColor = true;
            // 
            // btn_read_netw_nvr
            // 
            this.btn_read_netw_nvr.Enabled = false;
            this.btn_read_netw_nvr.Location = new System.Drawing.Point(534, 339);
            this.btn_read_netw_nvr.Name = "btn_read_netw_nvr";
            this.btn_read_netw_nvr.Size = new System.Drawing.Size(133, 23);
            this.btn_read_netw_nvr.TabIndex = 68;
            this.btn_read_netw_nvr.Text = "read NVR";
            this.btn_read_netw_nvr.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(549, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 72;
            this.label7.Text = "pswd LSB";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(549, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 71;
            this.label8.Text = "pswd MSB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 70;
            this.label2.Text = "pswd LSB";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 69;
            this.label1.Text = "pswd MSB";
            // 
            // btn_write_ven_nvr
            // 
            this.btn_write_ven_nvr.Enabled = false;
            this.btn_write_ven_nvr.Location = new System.Drawing.Point(534, 113);
            this.btn_write_ven_nvr.Name = "btn_write_ven_nvr";
            this.btn_write_ven_nvr.Size = new System.Drawing.Size(133, 23);
            this.btn_write_ven_nvr.TabIndex = 60;
            this.btn_write_ven_nvr.Text = "write NVR";
            this.btn_write_ven_nvr.UseVisualStyleBackColor = true;
            // 
            // btn_read_ven_nvr
            // 
            this.btn_read_ven_nvr.Enabled = false;
            this.btn_read_ven_nvr.Location = new System.Drawing.Point(534, 74);
            this.btn_read_ven_nvr.Name = "btn_read_ven_nvr";
            this.btn_read_ven_nvr.Size = new System.Drawing.Size(133, 23);
            this.btn_read_ven_nvr.TabIndex = 59;
            this.btn_read_ven_nvr.Text = "read NVR";
            this.btn_read_ven_nvr.UseVisualStyleBackColor = true;
            // 
            // btn_read_cfp_nvr
            // 
            this.btn_read_cfp_nvr.Enabled = false;
            this.btn_read_cfp_nvr.Location = new System.Drawing.Point(198, 74);
            this.btn_read_cfp_nvr.Name = "btn_read_cfp_nvr";
            this.btn_read_cfp_nvr.Size = new System.Drawing.Size(133, 23);
            this.btn_read_cfp_nvr.TabIndex = 58;
            this.btn_read_cfp_nvr.Text = "read NVR";
            this.btn_read_cfp_nvr.UseVisualStyleBackColor = true;
            this.btn_read_cfp_nvr.Click += new System.EventHandler(this.btn_read_cfp_nvr_Click);
            // 
            // textBox_psw_ven_LSB
            // 
            this.textBox_psw_ven_LSB.Location = new System.Drawing.Point(609, 48);
            this.textBox_psw_ven_LSB.Name = "textBox_psw_ven_LSB";
            this.textBox_psw_ven_LSB.Size = new System.Drawing.Size(58, 20);
            this.textBox_psw_ven_LSB.TabIndex = 57;
            this.textBox_psw_ven_LSB.Text = "0";
            // 
            // textBox_psw_ven_MSB
            // 
            this.textBox_psw_ven_MSB.Location = new System.Drawing.Point(609, 22);
            this.textBox_psw_ven_MSB.Name = "textBox_psw_ven_MSB";
            this.textBox_psw_ven_MSB.Size = new System.Drawing.Size(58, 20);
            this.textBox_psw_ven_MSB.TabIndex = 55;
            this.textBox_psw_ven_MSB.Text = "0";
            // 
            // btn_write_cfp_nvr
            // 
            this.btn_write_cfp_nvr.Enabled = false;
            this.btn_write_cfp_nvr.Location = new System.Drawing.Point(198, 113);
            this.btn_write_cfp_nvr.Name = "btn_write_cfp_nvr";
            this.btn_write_cfp_nvr.Size = new System.Drawing.Size(133, 23);
            this.btn_write_cfp_nvr.TabIndex = 56;
            this.btn_write_cfp_nvr.Text = "write NVR";
            this.btn_write_cfp_nvr.UseVisualStyleBackColor = true;
            this.btn_write_cfp_nvr.Click += new System.EventHandler(this.btn_write_cfp_nvr_Click);
            // 
            // textBox_psw_cfp_LSB
            // 
            this.textBox_psw_cfp_LSB.Location = new System.Drawing.Point(273, 48);
            this.textBox_psw_cfp_LSB.Name = "textBox_psw_cfp_LSB";
            this.textBox_psw_cfp_LSB.Size = new System.Drawing.Size(58, 20);
            this.textBox_psw_cfp_LSB.TabIndex = 54;
            this.textBox_psw_cfp_LSB.Text = "0";
            // 
            // textBox_psw_cfp_MSB
            // 
            this.textBox_psw_cfp_MSB.Location = new System.Drawing.Point(273, 22);
            this.textBox_psw_cfp_MSB.Name = "textBox_psw_cfp_MSB";
            this.textBox_psw_cfp_MSB.Size = new System.Drawing.Size(58, 20);
            this.textBox_psw_cfp_MSB.TabIndex = 53;
            this.textBox_psw_cfp_MSB.Text = "0";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.connect);
            this.flowLayoutPanel1.Controls.Add(this.btn_read_all);
            this.flowLayoutPanel1.Controls.Add(this.button6);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(531, 533);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(482, 33);
            this.flowLayoutPanel1.TabIndex = 52;
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(3, 3);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(194, 23);
            this.connect.TabIndex = 0;
            this.connect.Text = "connect";
            this.connect.UseVisualStyleBackColor = true;
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
            this.groupBox4.Location = new System.Drawing.Point(678, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(335, 254);
            this.groupBox4.TabIndex = 82;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(267, 16);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(58, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(267, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(58, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "0";
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(203, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "pswd LSB";
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
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(678, 266);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(335, 254);
            this.groupBox6.TabIndex = 83;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Host Lane, Common data, Allocated for OIF (RW)";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(342, 266);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(335, 254);
            this.groupBox3.TabIndex = 84;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Network lane VR (RW)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtg_vendor);
            this.groupBox2.Location = new System.Drawing.Point(342, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 254);
            this.groupBox2.TabIndex = 85;
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
            dataGridViewCellStyle5.Format = "X04";
            this.dtg_vendor.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtg_vendor.Size = new System.Drawing.Size(181, 228);
            this.dtg_vendor.TabIndex = 38;
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
            this.dtg_cfp_nvr.Location = new System.Drawing.Point(11, 22);
            this.dtg_cfp_nvr.Name = "dtg_cfp_nvr";
            this.dtg_cfp_nvr.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtg_cfp_nvr.RowHeadersVisible = false;
            this.dtg_cfp_nvr.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle6.Format = "X04";
            this.dtg_cfp_nvr.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtg_cfp_nvr.Size = new System.Drawing.Size(181, 228);
            this.dtg_cfp_nvr.TabIndex = 80;
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
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 254);
            this.groupBox1.TabIndex = 81;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CFP NVR (RO)";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1018, 569);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 641);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "form1";
            this.Text = "FiberTreid CFP Reader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form1_FormClosing);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_vr1_mlg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_host_lane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_net_lane)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_us_nvr)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_vendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_cfp_nvr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel status_lbl;
        private ToolStripProgressBar pr_bar;
        private ToolStripStatusLabel status_date;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem fileOpenToolStripMenuItem;
		private ToolStripMenuItem file_save;
		private ToolStripMenuItem file_open;
        private ToolStripStatusLabel t_st_stLBL_mod_abs;
        private Timer timer1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private CheckBox ch_b_reset;
        private Label label6;
        private Label label5;
        private TextBox tb_read_data;
        private TextBox tb_hexaddr;
        private Button btn_read_one;
        private GroupBox groupBox5;
        private Label label4;
        private DataGridView dtg_vr1_mlg;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private Label label3;
        private Button btn_write_mod_VR;
        private TextBox textBox6;
        private Button btn_cfp_VR1;
        private TextBox textBox5;
        private DataGridView dtg_host_lane;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridView dtg_net_lane;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private Button btn_stat_write;
        private TextBox textBox11;
        private Label label18;
        private TextBox textBox4;
        private TextBox textBox10;
        private Label label11;
        private Label label17;
        private TextBox textBox3;
        private Button btn_write_host_lane;
        private Label label12;
        private Button btn_host_lane;
        private Button btn_write_netw_nvr;
        private Button btn_read_netw_nvr;
        private Label label7;
        private Label label8;
        private Label label2;
        private Label label1;
        private Button btn_write_ven_nvr;
        private Button btn_read_ven_nvr;
        private Button btn_read_cfp_nvr;
        private TextBox textBox_psw_ven_LSB;
        private TextBox textBox_psw_ven_MSB;
        private Button btn_write_cfp_nvr;
        private TextBox textBox_psw_cfp_LSB;
        private TextBox textBox_psw_cfp_MSB;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button connect;
        private Button btn_read_all;
        private Button button6;
        private GroupBox groupBox4;
        private DataGridView dtg_us_nvr;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label10;
        private Label label9;
        private Button btn_read_user_nvr;
        private Button btn_write_user_nvr;
        private GroupBox groupBox6;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private DataGridView dtg_vendor;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridView dtg_cfp_nvr;
        private DataGridViewTextBoxColumn desc;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn data;
        private DataGridViewTextBoxColumn Column4;
        private GroupBox groupBox1;
        private TabPage tabPage2;
    }
}

