namespace VenomRAT_HVNC.Server.Forms
{
	// Token: 0x02000078 RID: 120
	public partial class FormAbout : global::System.Windows.Forms.Form
	{
		// Token: 0x0600045F RID: 1119 RVA: 0x0002B0AF File Offset: 0x0002B0AF
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x0002B0D0 File Offset: 0x0002B0D0
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(global::VenomRAT_HVNC.Server.Forms.FormAbout));
			base.SuspendLayout();
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(333, 164);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			base.Margin = new global::System.Windows.Forms.Padding(2);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "FormAbout";
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About";
			base.ResumeLayout(false);
		}

		// Token: 0x0400037D RID: 893
		private global::System.ComponentModel.IContainer components;
	}
}
