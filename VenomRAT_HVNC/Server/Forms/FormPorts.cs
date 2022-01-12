using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Interfaces;
using Server;
using VenomRAT_HVNC.Server.Helper;

namespace VenomRAT_HVNC.Server.Forms
{
    public class FormPorts : Form
    {
        private static bool isOK;
        private IContainer components;
        private Panel panel2;
        private Guna2ControlBox guna2ControlBox1;
        private Guna2DragControl guna2DragControl1;
        private Guna2Button button1;
        private Guna2ShadowPanel guna2ShadowPanel1;
        private Guna2Separator guna2Separator1;
        private Guna2ShadowPanel guna2ShadowPanel2;
        private Label label1;
        private Guna2BorderlessForm guna2BorderlessForm1;
        private Guna2NumericUpDown textPorts;

        public FormPorts()
        {
            this.InitializeComponent();
            this.Opacity = 0.0;
        }

        private void PortsFrm_Load(object sender, EventArgs e)
        {
            _ = Methods.FadeIn(this, 5);
            this.Text = Settings.Version + " | Welcome " + Environment.UserName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Ports = this.textPorts.Value.ToString();
            Properties.Settings.Default.Save();
            FormPorts.isOK = true;
            this.Close();
        }

        private void PortsFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (FormPorts.isOK)
                return;
            Program.form1.notifyIcon1.Dispose();
            Environment.Exit(0);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(((Control)this.textPorts).Text.Trim());
            }
            catch
            {
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = (IContainer)new Container();
            global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(FormPorts));
            this.panel2 = new Panel();
            this.label1 = new Label();
            this.guna2Separator1 = new Guna2Separator();
            this.guna2ShadowPanel1 = new Guna2ShadowPanel();
            this.button1 = new Guna2Button();
            this.guna2ControlBox1 = new Guna2ControlBox();
            this.guna2DragControl1 = new Guna2DragControl(this.components);
            this.guna2ShadowPanel2 = new Guna2ShadowPanel();
            this.guna2BorderlessForm1 = new Guna2BorderlessForm(this.components);
            this.textPorts = new Guna2NumericUpDown();
            this.panel2.SuspendLayout();
            ((Control)this.guna2ShadowPanel1).SuspendLayout();
            ((Control)this.guna2ShadowPanel2).SuspendLayout();
            ((ISupportInitialize)this.textPorts).BeginInit();
            this.SuspendLayout();
            this.panel2.BackColor = Color.FromArgb(24, 24, 24);
            this.panel2.Controls.Add((Control)this.label1);
            this.panel2.Controls.Add((Control)this.guna2Separator1);
            this.panel2.Controls.Add((Control)this.guna2ShadowPanel1);
            this.panel2.Controls.Add((Control)this.guna2ControlBox1);
            this.panel2.Location = new Point(9, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new Size(697, 377);
            this.panel2.TabIndex = 7;
            this.label1.AutoSize = true;
            this.label1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.label1.ForeColor = Color.White;
            this.label1.Location = new Point(35, 14);
            this.label1.Name = "label1";
            this.label1.Size = new Size(236, 20);
            this.label1.TabIndex = 129;
            this.label1.Text = "Venom RAT Start Port Listening";
            this.guna2Separator1.FillColor = Color.FromArgb(8, 104, 81);
            this.guna2Separator1.FillStyle = DashStyle.Custom;
            this.guna2Separator1.FillThickness = 2;
            ((Control)this.guna2Separator1).Location = new Point(0, 49);
            ((Control)this.guna2Separator1).Name = "guna2Separator1";
            ((Control)this.guna2Separator1).Size = new Size(697, 20);
            ((Control)this.guna2Separator1).TabIndex = 128;
            ((Control)this.guna2ShadowPanel1).BackColor = Color.Transparent;
            ((Control)this.guna2ShadowPanel1).Controls.Add((Control)this.textPorts);
            ((Control)this.guna2ShadowPanel1).Controls.Add((Control)this.button1);
            this.guna2ShadowPanel1.FillColor = Color.FromArgb(30, 30, 30);
            ((Control)this.guna2ShadowPanel1).ForeColor = Color.Transparent;
            ((Control)this.guna2ShadowPanel1).Location = new Point(39, 92);
            ((Control)this.guna2ShadowPanel1).Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = Color.FromArgb(8, 104, 81);
            this.guna2ShadowPanel1.ShadowShift = 8;
            ((Control)this.guna2ShadowPanel1).Size = new Size(619, 248);
            ((Control)this.guna2ShadowPanel1).TabIndex = (int)sbyte.MaxValue;
            this.button1.Animated = true;
            this.button1.BorderColor = Color.Maroon;
            this.button1.CheckedState.Parent = (ICustomButtonControl)this.button1;
            this.button1.CustomImages.Parent = (ICustomButtonControl)this.button1;
            this.button1.DisabledState.BorderColor = Color.DarkGray;
            this.button1.DisabledState.CustomBorderColor = Color.DarkGray;
            this.button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            this.button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            this.button1.DisabledState.Parent = (ICustomButtonControl)this.button1;
            this.button1.FillColor = Color.FromArgb(8, 104, 81);
            ((Control)this.button1).Font = new Font("Segoe UI", 9f);
            ((Control)this.button1).ForeColor = Color.White;
            this.button1.HoverState.Parent = (ICustomButtonControl)this.button1;
            ((Control)this.button1).Location = new Point(142, 108);
            ((Control)this.button1).Name = "button1";
            this.button1.ShadowDecoration.Parent = (Control)this.button1;
            ((Control)this.button1).Size = new Size(225, 28);
            ((Control)this.button1).TabIndex = 126;
            ((Control)this.button1).Text = "Port Listening";
            ((Control)this.button1).Click += new EventHandler(this.button1_Click);
            ((Control)this.guna2ControlBox1).Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ((Control)this.guna2ControlBox1).BackColor = Color.Transparent;
            this.guna2ControlBox1.FillColor = Color.Transparent;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = Color.White;
            ((Control)this.guna2ControlBox1).Location = new Point(653, 12);
            ((Control)this.guna2ControlBox1).Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = (Control)this.guna2ControlBox1;
            ((Control)this.guna2ControlBox1).Size = new Size(41, 32);
            ((Control)this.guna2ControlBox1).TabIndex = 10;
            this.guna2DragControl1.TargetControl = (Control)this.panel2;
            ((Control)this.guna2ShadowPanel2).BackColor = Color.FromArgb(8, 104, 81);
            ((Control)this.guna2ShadowPanel2).Controls.Add((Control)this.panel2);
            ((Control)this.guna2ShadowPanel2).Dock = DockStyle.Fill;
            this.guna2ShadowPanel2.FillColor = Color.FromArgb(24, 24, 24);
            ((Control)this.guna2ShadowPanel2).Location = new Point(0, 0);
            ((Control)this.guna2ShadowPanel2).Name = "guna2ShadowPanel2";
            this.guna2ShadowPanel2.ShadowColor = Color.FromArgb(8, 104, 81);
            this.guna2ShadowPanel2.ShadowDepth = 8;
            this.guna2ShadowPanel2.ShadowShift = 2;
            ((Control)this.guna2ShadowPanel2).Size = new Size(716, 397);
            ((Control)this.guna2ShadowPanel2).TabIndex = 8;
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationType = (Guna2BorderlessForm.AnimateWindowType)4;
            this.guna2BorderlessForm1.ContainerControl = (ContainerControl)this;
            this.guna2BorderlessForm1.DockIndicatorColor = Color.FromArgb(8, 104, 81);
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.5;
            this.guna2BorderlessForm1.ShadowColor = Color.FromArgb(8, 104, 81);
            ((Control)this.textPorts).BackColor = Color.Transparent;
            this.textPorts.BorderColor = Color.FromArgb(8, 104, 81);
            ((Control)this.textPorts).Cursor = Cursors.IBeam;
            this.textPorts.DisabledState.Parent = this.textPorts;
            this.textPorts.FillColor = Color.FromArgb(24, 24, 24);
            this.textPorts.FocusedState.BorderColor = Color.FromArgb(4, 143, 110);
            this.textPorts.FocusedState.Parent = this.textPorts;
            this.textPorts.Font = new Font("Segoe UI", 9f);
            this.textPorts.ForeColor = Color.Gainsboro;
            ((Control)this.textPorts).Location = new Point(384, 109);
            this.textPorts.Maximum = new Decimal(new int[4]
            {
        (int) ushort.MaxValue,
        0,
        0,
        0
            });
            this.textPorts.Minimum = new Decimal(new int[4]
            {
        1024,
        0,
        0,
        0
            });
            ((Control)this.textPorts).Name = "textPorts";
            this.textPorts.ShadowDecoration.Parent = (Control)this.textPorts;
            ((Control)this.textPorts).Size = new Size(79, 27);
            ((Control)this.textPorts).TabIndex = 128;
            this.textPorts.UpDownButtonFillColor = Color.FromArgb(8, 104, 81);
            this.textPorts.UpDownButtonForeColor = Color.Gainsboro;
            this.textPorts.Value = new Decimal(new int[4]
            {
        4449,
        0,
        0,
        0
            });
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(716, 397);
            this.Controls.Add((Control)this.guna2ShadowPanel2);
            this.FormBorderStyle = FormBorderStyle.None;
            //this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPorts";
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Listen ports";
            this.TopMost = true;
            this.FormClosed += new FormClosedEventHandler(this.PortsFrm_FormClosed);
            this.Load += new EventHandler(this.PortsFrm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((Control)this.guna2ShadowPanel1).ResumeLayout(false);
            ((Control)this.guna2ShadowPanel2).ResumeLayout(false);
            ((ISupportInitialize)this.textPorts).EndInit();
            this.ResumeLayout(false);
        }
    }
}