﻿namespace VenomRAT_HVNC.HVNC
{
	// Token: 0x0200001F RID: 31
	public partial class FrmVNC : global::System.Windows.Forms.Form
	{
		// Token: 0x06000119 RID: 281 RVA: 0x0000BF50 File Offset: 0x0000BF50
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0000BF70 File Offset: 0x0000BF70
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.guna2ResizeBox1 = new Guna.UI2.WinForms.Guna2ResizeBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.ToggleHVNC = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Separator4 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2ControlBox3 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.chkClone = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.IntervalLabel = new System.Windows.Forms.Label();
            this.IntervalScroll = new Guna.UI2.WinForms.Guna2TrackBar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.statusled = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.ResizeScroll = new Guna.UI2.WinForms.Guna2TrackBar();
            this.QualityScroll = new Guna.UI2.WinForms.Guna2TrackBar();
            this.ledstatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.CloseBtn = new Guna.UI2.WinForms.Guna2Button();
            this.powershellToolStripMenuItem = new Guna.UI2.WinForms.Guna2Button();
            this.test2ToolStripMenuItem = new Guna.UI2.WinForms.Guna2Button();
            this.braveToolStripMenuItem = new Guna.UI2.WinForms.Guna2Button();
            this.fileExplorerToolStripMenuItem = new Guna.UI2.WinForms.Guna2Button();
            this.edgeToolStripMenuItem = new Guna.UI2.WinForms.Guna2Button();
            this.test1ToolStripMenuItem = new Guna.UI2.WinForms.Guna2Button();
            this.chkClone1 = new System.Windows.Forms.Label();
            this.QualityLabel = new System.Windows.Forms.Label();
            this.VNCBox = new System.Windows.Forms.PictureBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VNCBox)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ResizeBox1
            // 
            this.guna2ResizeBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ResizeBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(104)))), ((int)(((byte)(81)))));
            this.guna2ResizeBox1.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2ResizeBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2ResizeBox1.Location = new System.Drawing.Point(1655, 929);
            this.guna2ResizeBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ResizeBox1.Name = "guna2ResizeBox1";
            this.guna2ResizeBox1.Size = new System.Drawing.Size(27, 25);
            this.guna2ResizeBox1.TabIndex = 35;
            this.guna2ResizeBox1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.panel1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel1.Controls.Add(this.ToggleHVNC);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.guna2Separator4);
            this.panel1.Controls.Add(this.guna2Separator3);
            this.panel1.Controls.Add(this.guna2Separator1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.guna2ControlBox3);
            this.panel1.Controls.Add(this.guna2ControlBox2);
            this.panel1.Controls.Add(this.guna2ControlBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1681, 78);
            this.panel1.TabIndex = 32;
            // 
            // ToggleHVNC
            // 
            this.ToggleHVNC.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ToggleHVNC.CheckedState.BorderRadius = 1;
            this.ToggleHVNC.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(64)))), ((int)(((byte)(50)))));
            this.ToggleHVNC.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ToggleHVNC.CheckedState.InnerBorderRadius = 0;
            this.ToggleHVNC.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(189)))), ((int)(((byte)(144)))));
            this.ToggleHVNC.CheckedState.InnerOffset = 2;
            this.ToggleHVNC.CheckedState.Parent = this.ToggleHVNC;
            this.ToggleHVNC.Location = new System.Drawing.Point(252, 26);
            this.ToggleHVNC.Margin = new System.Windows.Forms.Padding(4);
            this.ToggleHVNC.Name = "ToggleHVNC";
            this.ToggleHVNC.ShadowDecoration.Parent = this.ToggleHVNC;
            this.ToggleHVNC.Size = new System.Drawing.Size(69, 27);
            this.ToggleHVNC.TabIndex = 149;
            this.ToggleHVNC.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ToggleHVNC.UncheckedState.BorderRadius = 1;
            this.ToggleHVNC.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(64)))), ((int)(((byte)(50)))));
            this.ToggleHVNC.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ToggleHVNC.UncheckedState.InnerBorderRadius = 0;
            this.ToggleHVNC.UncheckedState.InnerColor = System.Drawing.SystemColors.WindowText;
            this.ToggleHVNC.UncheckedState.InnerOffset = 2;
            this.ToggleHVNC.UncheckedState.Parent = this.ToggleHVNC;
            this.ToggleHVNC.CheckedChanged += new System.EventHandler(this.ToggleHVNC_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(68, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 29);
            this.label2.TabIndex = 147;
            this.label2.Text = "Venom HVNC";
            // 
            // guna2Separator4
            // 
            this.guna2Separator4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2Separator4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(104)))), ((int)(((byte)(81)))));
            this.guna2Separator4.FillStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Separator4.FillThickness = 2;
            this.guna2Separator4.Location = new System.Drawing.Point(1481, 58);
            this.guna2Separator4.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Separator4.Name = "guna2Separator4";
            this.guna2Separator4.Size = new System.Drawing.Size(200, 12);
            this.guna2Separator4.TabIndex = 146;
            // 
            // guna2Separator3
            // 
            this.guna2Separator3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.guna2Separator3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(104)))), ((int)(((byte)(81)))));
            this.guna2Separator3.FillStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Separator3.FillThickness = 2;
            this.guna2Separator3.Location = new System.Drawing.Point(73, 58);
            this.guna2Separator3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(249, 12);
            this.guna2Separator3.TabIndex = 146;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(104)))), ((int)(((byte)(81)))));
            this.guna2Separator1.FillStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Separator1.FillThickness = 4;
            this.guna2Separator1.Location = new System.Drawing.Point(0, -2);
            this.guna2Separator1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1681, 12);
            this.guna2Separator1.TabIndex = 146;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(4, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 145;
            this.pictureBox1.TabStop = false;
            // 
            // guna2ControlBox3
            // 
            this.guna2ControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox3.HoverState.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox3.Location = new System.Drawing.Point(1481, 21);
            this.guna2ControlBox3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ControlBox3.Name = "guna2ControlBox3";
            this.guna2ControlBox3.ShadowDecoration.Parent = this.guna2ControlBox3;
            this.guna2ControlBox3.Size = new System.Drawing.Size(60, 36);
            this.guna2ControlBox3.TabIndex = 0;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1549, 20);
            this.guna2ControlBox2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(60, 36);
            this.guna2ControlBox2.TabIndex = 0;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1617, 20);
            this.guna2ControlBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(60, 36);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // chkClone
            // 
            this.chkClone.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkClone.CheckedState.BorderRadius = 1;
            this.chkClone.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(64)))), ((int)(((byte)(50)))));
            this.chkClone.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.chkClone.CheckedState.InnerBorderRadius = 0;
            this.chkClone.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(189)))), ((int)(((byte)(144)))));
            this.chkClone.CheckedState.InnerOffset = 2;
            this.chkClone.CheckedState.Parent = this.chkClone;
            this.chkClone.Location = new System.Drawing.Point(164, 43);
            this.chkClone.Margin = new System.Windows.Forms.Padding(4);
            this.chkClone.Name = "chkClone";
            this.chkClone.ShadowDecoration.Parent = this.chkClone;
            this.chkClone.Size = new System.Drawing.Size(99, 27);
            this.chkClone.TabIndex = 149;
            this.chkClone.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkClone.UncheckedState.BorderRadius = 1;
            this.chkClone.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(64)))), ((int)(((byte)(50)))));
            this.chkClone.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.chkClone.UncheckedState.InnerBorderRadius = 0;
            this.chkClone.UncheckedState.InnerColor = System.Drawing.SystemColors.WindowText;
            this.chkClone.UncheckedState.InnerOffset = 2;
            this.chkClone.UncheckedState.Parent = this.chkClone;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(26, 17);
            this.toolStripStatusLabel2.Text = "Idle";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(44, 17);
            this.toolStripStatusLabel1.Text = "Statut :";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.ForeColor = System.Drawing.Color.Gainsboro;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel3.Text = "Status";
            this.toolStripStatusLabel3.Visible = false;
            this.toolStripStatusLabel3.TextChanged += new System.EventHandler(this.toolStripStatusLabel3_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(104)))), ((int)(((byte)(81)))));
            this.statusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 932);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1681, 22);
            this.statusStrip1.TabIndex = 19;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // IntervalLabel
            // 
            this.IntervalLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IntervalLabel.AutoSize = true;
            this.IntervalLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.IntervalLabel.Location = new System.Drawing.Point(-81, 128);
            this.IntervalLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IntervalLabel.Name = "IntervalLabel";
            this.IntervalLabel.Size = new System.Drawing.Size(118, 17);
            this.IntervalLabel.TabIndex = 6;
            this.IntervalLabel.Text = "Interval (ms): 500";
            this.IntervalLabel.Visible = false;
            // 
            // IntervalScroll
            // 
            this.IntervalScroll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IntervalScroll.HoverState.Parent = this.IntervalScroll;
            this.IntervalScroll.Location = new System.Drawing.Point(44, 129);
            this.IntervalScroll.Margin = new System.Windows.Forms.Padding(4);
            this.IntervalScroll.Maximum = 1000;
            this.IntervalScroll.Name = "IntervalScroll";
            this.IntervalScroll.Size = new System.Drawing.Size(61, 32);
            this.IntervalScroll.TabIndex = 8;
            this.IntervalScroll.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(97)))), ((int)(((byte)(128)))));
            this.IntervalScroll.Value = 500;
            this.IntervalScroll.Visible = false;
            this.IntervalScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.IntervalScroll_Scroll);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel4.Controls.Add(this.statusled);
            this.panel4.Controls.Add(this.ResizeScroll);
            this.panel4.Controls.Add(this.chkClone);
            this.panel4.Controls.Add(this.QualityScroll);
            this.panel4.Controls.Add(this.ledstatus);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.guna2Separator2);
            this.panel4.Controls.Add(this.CloseBtn);
            this.panel4.Controls.Add(this.powershellToolStripMenuItem);
            this.panel4.Controls.Add(this.test2ToolStripMenuItem);
            this.panel4.Controls.Add(this.braveToolStripMenuItem);
            this.panel4.Controls.Add(this.fileExplorerToolStripMenuItem);
            this.panel4.Controls.Add(this.edgeToolStripMenuItem);
            this.panel4.Controls.Add(this.test1ToolStripMenuItem);
            this.panel4.Controls.Add(this.IntervalScroll);
            this.panel4.Controls.Add(this.IntervalLabel);
            this.panel4.Controls.Add(this.chkClone1);
            this.panel4.Controls.Add(this.QualityLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 851);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1681, 81);
            this.panel4.TabIndex = 39;
            // 
            // statusled
            // 
            this.statusled.ErrorImage = null;
            this.statusled.ImageRotate = 0F;
            this.statusled.Location = new System.Drawing.Point(16, 39);
            this.statusled.Margin = new System.Windows.Forms.Padding(4);
            this.statusled.Name = "statusled";
            this.statusled.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.statusled.ShadowDecoration.Parent = this.statusled;
            this.statusled.Size = new System.Drawing.Size(33, 31);
            this.statusled.TabIndex = 41;
            this.statusled.TabStop = false;
            // 
            // ResizeScroll
            // 
            this.ResizeScroll.Cursor = System.Windows.Forms.Cursors.Default;
            this.ResizeScroll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(143)))), ((int)(((byte)(110)))));
            this.ResizeScroll.HoverState.Parent = this.ResizeScroll;
            this.ResizeScroll.Location = new System.Drawing.Point(1236, 42);
            this.ResizeScroll.Margin = new System.Windows.Forms.Padding(4);
            this.ResizeScroll.Name = "ResizeScroll";
            this.ResizeScroll.Size = new System.Drawing.Size(148, 28);
            this.ResizeScroll.Style = Guna.UI2.WinForms.Enums.TrackBarStyle.Metro;
            this.ResizeScroll.TabIndex = 151;
            this.ResizeScroll.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(104)))), ((int)(((byte)(81)))));
            this.ResizeScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ResizeScroll_Scroll);
            // 
            // QualityScroll
            // 
            this.QualityScroll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(143)))), ((int)(((byte)(110)))));
            this.QualityScroll.HoverState.Parent = this.QualityScroll;
            this.QualityScroll.Location = new System.Drawing.Point(1236, 21);
            this.QualityScroll.Margin = new System.Windows.Forms.Padding(4);
            this.QualityScroll.Name = "QualityScroll";
            this.QualityScroll.Size = new System.Drawing.Size(148, 28);
            this.QualityScroll.Style = Guna.UI2.WinForms.Enums.TrackBarStyle.Metro;
            this.QualityScroll.TabIndex = 151;
            this.QualityScroll.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(104)))), ((int)(((byte)(81)))));
            this.QualityScroll.Scroll += new System.Windows.Forms.ScrollEventHandler(this.QualityScroll_Scroll);
            // 
            // ledstatus
            // 
            this.ledstatus.AutoSize = true;
            this.ledstatus.ForeColor = System.Drawing.Color.Gainsboro;
            this.ledstatus.Location = new System.Drawing.Point(55, 48);
            this.ledstatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ledstatus.Name = "ledstatus";
            this.ledstatus.Size = new System.Drawing.Size(31, 17);
            this.ledstatus.TabIndex = 150;
            this.ledstatus.Text = "N/A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(161, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 150;
            this.label3.Text = "Clone Account";
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(104)))), ((int)(((byte)(81)))));
            this.guna2Separator2.FillStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Separator2.FillThickness = 4;
            this.guna2Separator2.Location = new System.Drawing.Point(0, 0);
            this.guna2Separator2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(1681, 12);
            this.guna2Separator2.TabIndex = 146;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.Animated = true;
            this.CloseBtn.BorderColor = System.Drawing.Color.Maroon;
            this.CloseBtn.CheckedState.Parent = this.CloseBtn;
            this.CloseBtn.CustomImages.Parent = this.CloseBtn;
            this.CloseBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CloseBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CloseBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CloseBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CloseBtn.DisabledState.Parent = this.CloseBtn;
            this.CloseBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(104)))), ((int)(((byte)(81)))));
            this.CloseBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CloseBtn.ForeColor = System.Drawing.Color.White;
            this.CloseBtn.HoverState.Parent = this.CloseBtn;
            this.CloseBtn.Location = new System.Drawing.Point(1517, 20);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.ShadowDecoration.Parent = this.CloseBtn;
            this.CloseBtn.Size = new System.Drawing.Size(148, 49);
            this.CloseBtn.TabIndex = 131;
            this.CloseBtn.Text = "Close Window";
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // powershellToolStripMenuItem
            // 
            this.powershellToolStripMenuItem.Animated = true;
            this.powershellToolStripMenuItem.BorderColor = System.Drawing.Color.Maroon;
            this.powershellToolStripMenuItem.CheckedState.Parent = this.powershellToolStripMenuItem;
            this.powershellToolStripMenuItem.CustomImages.Parent = this.powershellToolStripMenuItem;
            this.powershellToolStripMenuItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.powershellToolStripMenuItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.powershellToolStripMenuItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.powershellToolStripMenuItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.powershellToolStripMenuItem.DisabledState.Parent = this.powershellToolStripMenuItem;
            this.powershellToolStripMenuItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(104)))), ((int)(((byte)(81)))));
            this.powershellToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.powershellToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.powershellToolStripMenuItem.HoverState.Parent = this.powershellToolStripMenuItem;
            this.powershellToolStripMenuItem.Location = new System.Drawing.Point(941, 20);
            this.powershellToolStripMenuItem.Margin = new System.Windows.Forms.Padding(4);
            this.powershellToolStripMenuItem.Name = "powershellToolStripMenuItem";
            this.powershellToolStripMenuItem.ShadowDecoration.Parent = this.powershellToolStripMenuItem;
            this.powershellToolStripMenuItem.Size = new System.Drawing.Size(123, 49);
            this.powershellToolStripMenuItem.TabIndex = 131;
            this.powershellToolStripMenuItem.Text = "Powershell";
            this.powershellToolStripMenuItem.Click += new System.EventHandler(this.powershellToolStripMenuItem_Click);
            // 
            // test2ToolStripMenuItem
            // 
            this.test2ToolStripMenuItem.Animated = true;
            this.test2ToolStripMenuItem.BorderColor = System.Drawing.Color.Maroon;
            this.test2ToolStripMenuItem.CheckedState.Parent = this.test2ToolStripMenuItem;
            this.test2ToolStripMenuItem.CustomImages.Parent = this.test2ToolStripMenuItem;
            this.test2ToolStripMenuItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.test2ToolStripMenuItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.test2ToolStripMenuItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.test2ToolStripMenuItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.test2ToolStripMenuItem.DisabledState.Parent = this.test2ToolStripMenuItem;
            this.test2ToolStripMenuItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(104)))), ((int)(((byte)(81)))));
            this.test2ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.test2ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.test2ToolStripMenuItem.HoverState.Parent = this.test2ToolStripMenuItem;
            this.test2ToolStripMenuItem.Location = new System.Drawing.Point(680, 20);
            this.test2ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(4);
            this.test2ToolStripMenuItem.Name = "test2ToolStripMenuItem";
            this.test2ToolStripMenuItem.ShadowDecoration.Parent = this.test2ToolStripMenuItem;
            this.test2ToolStripMenuItem.Size = new System.Drawing.Size(123, 49);
            this.test2ToolStripMenuItem.TabIndex = 132;
            this.test2ToolStripMenuItem.Text = "Firefox";
            this.test2ToolStripMenuItem.Click += new System.EventHandler(this.test2ToolStripMenuItem_Click);
            // 
            // braveToolStripMenuItem
            // 
            this.braveToolStripMenuItem.Animated = true;
            this.braveToolStripMenuItem.BorderColor = System.Drawing.Color.Maroon;
            this.braveToolStripMenuItem.CheckedState.Parent = this.braveToolStripMenuItem;
            this.braveToolStripMenuItem.CustomImages.Parent = this.braveToolStripMenuItem;
            this.braveToolStripMenuItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.braveToolStripMenuItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.braveToolStripMenuItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.braveToolStripMenuItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.braveToolStripMenuItem.DisabledState.Parent = this.braveToolStripMenuItem;
            this.braveToolStripMenuItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(104)))), ((int)(((byte)(81)))));
            this.braveToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.braveToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.braveToolStripMenuItem.HoverState.Parent = this.braveToolStripMenuItem;
            this.braveToolStripMenuItem.Location = new System.Drawing.Point(549, 20);
            this.braveToolStripMenuItem.Margin = new System.Windows.Forms.Padding(4);
            this.braveToolStripMenuItem.Name = "braveToolStripMenuItem";
            this.braveToolStripMenuItem.ShadowDecoration.Parent = this.braveToolStripMenuItem;
            this.braveToolStripMenuItem.Size = new System.Drawing.Size(123, 49);
            this.braveToolStripMenuItem.TabIndex = 134;
            this.braveToolStripMenuItem.Text = "Brave";
            this.braveToolStripMenuItem.Click += new System.EventHandler(this.braveToolStripMenuItem_Click);
            // 
            // fileExplorerToolStripMenuItem
            // 
            this.fileExplorerToolStripMenuItem.Animated = true;
            this.fileExplorerToolStripMenuItem.BorderColor = System.Drawing.Color.Maroon;
            this.fileExplorerToolStripMenuItem.CheckedState.Parent = this.fileExplorerToolStripMenuItem;
            this.fileExplorerToolStripMenuItem.CustomImages.Parent = this.fileExplorerToolStripMenuItem;
            this.fileExplorerToolStripMenuItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.fileExplorerToolStripMenuItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.fileExplorerToolStripMenuItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.fileExplorerToolStripMenuItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.fileExplorerToolStripMenuItem.DisabledState.Parent = this.fileExplorerToolStripMenuItem;
            this.fileExplorerToolStripMenuItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(104)))), ((int)(((byte)(81)))));
            this.fileExplorerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fileExplorerToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileExplorerToolStripMenuItem.HoverState.Parent = this.fileExplorerToolStripMenuItem;
            this.fileExplorerToolStripMenuItem.Location = new System.Drawing.Point(811, 20);
            this.fileExplorerToolStripMenuItem.Margin = new System.Windows.Forms.Padding(4);
            this.fileExplorerToolStripMenuItem.Name = "fileExplorerToolStripMenuItem";
            this.fileExplorerToolStripMenuItem.ShadowDecoration.Parent = this.fileExplorerToolStripMenuItem;
            this.fileExplorerToolStripMenuItem.Size = new System.Drawing.Size(123, 49);
            this.fileExplorerToolStripMenuItem.TabIndex = 135;
            this.fileExplorerToolStripMenuItem.Text = "Explorer";
            this.fileExplorerToolStripMenuItem.Click += new System.EventHandler(this.fileExplorerToolStripMenuItem_Click);
            // 
            // edgeToolStripMenuItem
            // 
            this.edgeToolStripMenuItem.Animated = true;
            this.edgeToolStripMenuItem.BorderColor = System.Drawing.Color.Maroon;
            this.edgeToolStripMenuItem.CheckedState.Parent = this.edgeToolStripMenuItem;
            this.edgeToolStripMenuItem.CustomImages.Parent = this.edgeToolStripMenuItem;
            this.edgeToolStripMenuItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.edgeToolStripMenuItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.edgeToolStripMenuItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.edgeToolStripMenuItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.edgeToolStripMenuItem.DisabledState.Parent = this.edgeToolStripMenuItem;
            this.edgeToolStripMenuItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(104)))), ((int)(((byte)(81)))));
            this.edgeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.edgeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.edgeToolStripMenuItem.HoverState.Parent = this.edgeToolStripMenuItem;
            this.edgeToolStripMenuItem.Location = new System.Drawing.Point(419, 20);
            this.edgeToolStripMenuItem.Margin = new System.Windows.Forms.Padding(4);
            this.edgeToolStripMenuItem.Name = "edgeToolStripMenuItem";
            this.edgeToolStripMenuItem.ShadowDecoration.Parent = this.edgeToolStripMenuItem;
            this.edgeToolStripMenuItem.Size = new System.Drawing.Size(123, 49);
            this.edgeToolStripMenuItem.TabIndex = 136;
            this.edgeToolStripMenuItem.Text = "Edge";
            this.edgeToolStripMenuItem.Click += new System.EventHandler(this.edgeToolStripMenuItem_Click);
            // 
            // test1ToolStripMenuItem
            // 
            this.test1ToolStripMenuItem.Animated = true;
            this.test1ToolStripMenuItem.BorderColor = System.Drawing.Color.Maroon;
            this.test1ToolStripMenuItem.CheckedState.Parent = this.test1ToolStripMenuItem;
            this.test1ToolStripMenuItem.CustomImages.Parent = this.test1ToolStripMenuItem;
            this.test1ToolStripMenuItem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.test1ToolStripMenuItem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.test1ToolStripMenuItem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.test1ToolStripMenuItem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.test1ToolStripMenuItem.DisabledState.Parent = this.test1ToolStripMenuItem;
            this.test1ToolStripMenuItem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(104)))), ((int)(((byte)(81)))));
            this.test1ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.test1ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.test1ToolStripMenuItem.HoverState.Parent = this.test1ToolStripMenuItem;
            this.test1ToolStripMenuItem.Location = new System.Drawing.Point(288, 20);
            this.test1ToolStripMenuItem.Margin = new System.Windows.Forms.Padding(4);
            this.test1ToolStripMenuItem.Name = "test1ToolStripMenuItem";
            this.test1ToolStripMenuItem.ShadowDecoration.Parent = this.test1ToolStripMenuItem;
            this.test1ToolStripMenuItem.Size = new System.Drawing.Size(123, 49);
            this.test1ToolStripMenuItem.TabIndex = 137;
            this.test1ToolStripMenuItem.Text = "Chrome";
            this.test1ToolStripMenuItem.Click += new System.EventHandler(this.test1ToolStripMenuItem_Click);
            // 
            // chkClone1
            // 
            this.chkClone1.AutoSize = true;
            this.chkClone1.ForeColor = System.Drawing.Color.Gainsboro;
            this.chkClone1.Location = new System.Drawing.Point(1137, 48);
            this.chkClone1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chkClone1.Name = "chkClone1";
            this.chkClone1.Size = new System.Drawing.Size(91, 17);
            this.chkClone1.TabIndex = 4;
            this.chkClone1.Text = "Resize : 50%";
            // 
            // QualityLabel
            // 
            this.QualityLabel.AutoSize = true;
            this.QualityLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.QualityLabel.Location = new System.Drawing.Point(1159, 26);
            this.QualityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QualityLabel.Name = "QualityLabel";
            this.QualityLabel.Size = new System.Drawing.Size(69, 17);
            this.QualityLabel.TabIndex = 5;
            this.QualityLabel.Text = "HQ : 50%";
            // 
            // VNCBox
            // 
            this.VNCBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.VNCBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VNCBox.ErrorImage = null;
            this.VNCBox.InitialImage = null;
            this.VNCBox.Location = new System.Drawing.Point(0, 78);
            this.VNCBox.Margin = new System.Windows.Forms.Padding(4);
            this.VNCBox.Name = "VNCBox";
            this.VNCBox.Size = new System.Drawing.Size(1681, 773);
            this.VNCBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.VNCBox.TabIndex = 40;
            this.VNCBox.TabStop = false;
            this.VNCBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VNCBox_MouseDown);
            this.VNCBox.MouseEnter += new System.EventHandler(this.VNCBox_MouseEnter);
            this.VNCBox.MouseLeave += new System.EventHandler(this.VNCBox_MouseLeave);
            this.VNCBox.MouseHover += new System.EventHandler(this.VNCBox_MouseHover);
            this.VNCBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.VNCBox_MouseMove);
            this.VNCBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.VNCBox_MouseUp);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(244, 6);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(104)))), ((int)(((byte)(81)))));
            this.guna2BorderlessForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(104)))), ((int)(((byte)(81)))));
            // 
            // FrmVNC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(33)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1681, 954);
            this.Controls.Add(this.VNCBox);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.guna2ResizeBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1493, 778);
            this.Name = "FrmVNC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VNCForm_FormClosing);
            this.Load += new System.EventHandler(this.VNCForm_Load);
            this.Click += new System.EventHandler(this.VNCForm_Click);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VNCForm_KeyPress);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VNCBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		// Token: 0x040000A5 RID: 165
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040000A6 RID: 166
		private global::Guna.UI2.WinForms.Guna2ResizeBox guna2ResizeBox1;

		// Token: 0x040000A7 RID: 167
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040000A8 RID: 168
		private global::Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;

		// Token: 0x040000A9 RID: 169
		private global::Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;

		// Token: 0x040000AA RID: 170
		public global::System.Windows.Forms.StatusStrip statusStrip1;

		// Token: 0x040000AB RID: 171
		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;

		// Token: 0x040000AC RID: 172
		private global::Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;

		// Token: 0x040000AD RID: 173
		private global::System.Windows.Forms.Timer timer2;

		// Token: 0x040000AE RID: 174
		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;

		// Token: 0x040000AF RID: 175
		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

		// Token: 0x040000B0 RID: 176
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x040000B1 RID: 177
		private global::Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox3;

		// Token: 0x040000B2 RID: 178
		private global::System.Windows.Forms.Panel panel4;

		// Token: 0x040000B3 RID: 179
		private global::Guna.UI2.WinForms.Guna2TrackBar IntervalScroll;

		// Token: 0x040000B4 RID: 180
		private global::System.Windows.Forms.Label IntervalLabel;

		// Token: 0x040000B5 RID: 181
		private global::System.Windows.Forms.PictureBox VNCBox;

		// Token: 0x040000B6 RID: 182
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x040000B7 RID: 183
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		// Token: 0x040000B8 RID: 184
		private global::Guna.UI2.WinForms.Guna2Button powershellToolStripMenuItem;

		// Token: 0x040000B9 RID: 185
		private global::Guna.UI2.WinForms.Guna2Button test2ToolStripMenuItem;

		// Token: 0x040000BA RID: 186
		private global::Guna.UI2.WinForms.Guna2Button braveToolStripMenuItem;

		// Token: 0x040000BB RID: 187
		private global::Guna.UI2.WinForms.Guna2Button fileExplorerToolStripMenuItem;

		// Token: 0x040000BC RID: 188
		private global::Guna.UI2.WinForms.Guna2Button edgeToolStripMenuItem;

		// Token: 0x040000BD RID: 189
		private global::Guna.UI2.WinForms.Guna2Button test1ToolStripMenuItem;

		// Token: 0x040000BE RID: 190
		private global::System.Windows.Forms.Label chkClone1;

		// Token: 0x040000BF RID: 191
		private global::System.Windows.Forms.Label QualityLabel;

		// Token: 0x040000C0 RID: 192
		private global::Guna.UI2.WinForms.Guna2Separator guna2Separator2;

		// Token: 0x040000C1 RID: 193
		private global::Guna.UI2.WinForms.Guna2Separator guna2Separator1;

		// Token: 0x040000C2 RID: 194
		private global::Guna.UI2.WinForms.Guna2Button CloseBtn;

		// Token: 0x040000C3 RID: 195
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040000C4 RID: 196
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040000C5 RID: 197
		private global::Guna.UI2.WinForms.Guna2ToggleSwitch ToggleHVNC;

		// Token: 0x040000C6 RID: 198
		private global::Guna.UI2.WinForms.Guna2Separator guna2Separator4;

		// Token: 0x040000C7 RID: 199
		private global::Guna.UI2.WinForms.Guna2Separator guna2Separator3;

		// Token: 0x040000C8 RID: 200
		private global::Guna.UI2.WinForms.Guna2TrackBar QualityScroll;

		// Token: 0x040000C9 RID: 201
		private global::Guna.UI2.WinForms.Guna2TrackBar ResizeScroll;

		// Token: 0x040000CA RID: 202
		private global::Guna.UI2.WinForms.Guna2ToggleSwitch chkClone;

		// Token: 0x040000CB RID: 203
		private global::Guna.UI2.WinForms.Guna2CirclePictureBox statusled;

		// Token: 0x040000CC RID: 204
		private global::System.Windows.Forms.Label ledstatus;

		// Token: 0x040000CD RID: 205
		private global::Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
	}
}
