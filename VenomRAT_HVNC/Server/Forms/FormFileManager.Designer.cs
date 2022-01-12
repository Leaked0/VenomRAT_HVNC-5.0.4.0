namespace VenomRAT_HVNC.Server.Forms
{
	// Token: 0x0200007F RID: 127
	public partial class FormFileManager : global::System.Windows.Forms.Form
	{
		// Token: 0x060004B3 RID: 1203 RVA: 0x00034DD0 File Offset: 0x00034DD0
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00034DF0 File Offset: 0x00034DF0
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.Windows.Forms.ListViewGroup listViewGroup = new global::System.Windows.Forms.ListViewGroup("Folders", global::System.Windows.Forms.HorizontalAlignment.Left);
			global::System.Windows.Forms.ListViewGroup listViewGroup2 = new global::System.Windows.Forms.ListViewGroup("File", global::System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(global::VenomRAT_HVNC.Server.Forms.FormFileManager));
			this.listView1 = new global::System.Windows.Forms.ListView();
			this.columnHeader1 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new global::System.Windows.Forms.ColumnHeader();
			this.contextMenuStrip1 = new global::System.Windows.Forms.ContextMenuStrip(this.components);
			this.backToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator7 = new global::System.Windows.Forms.ToolStripSeparator();
			this.rEFRESHToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator8 = new global::System.Windows.Forms.ToolStripSeparator();
			this.gOTOToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.dESKTOPToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator17 = new global::System.Windows.Forms.ToolStripSeparator();
			this.aPPDATAToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator18 = new global::System.Windows.Forms.ToolStripSeparator();
			this.userProfileToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new global::System.Windows.Forms.ToolStripSeparator();
			this.driversListsToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
			this.downloadToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator9 = new global::System.Windows.Forms.ToolStripSeparator();
			this.uPLOADToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator10 = new global::System.Windows.Forms.ToolStripSeparator();
			this.eXECUTEToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator11 = new global::System.Windows.Forms.ToolStripSeparator();
			this.renameToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator12 = new global::System.Windows.Forms.ToolStripSeparator();
			this.copyToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator13 = new global::System.Windows.Forms.ToolStripSeparator();
			this.cutToolStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator14 = new global::System.Windows.Forms.ToolStripSeparator();
			this.pasteToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator15 = new global::System.Windows.Forms.ToolStripSeparator();
			this.dELETEToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new global::System.Windows.Forms.ToolStripSeparator();
			this.sevenZiplStripMenuItem1 = new global::System.Windows.Forms.ToolStripMenuItem();
			this.installToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator6 = new global::System.Windows.Forms.ToolStripSeparator();
			this.zipToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator16 = new global::System.Windows.Forms.ToolStripSeparator();
			this.unzipToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new global::System.Windows.Forms.ToolStripSeparator();
			this.createFolderToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new global::System.Windows.Forms.ToolStripSeparator();
			this.openClientFolderToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.imageList1 = new global::System.Windows.Forms.ImageList(this.components);
			this.statusStrip1 = new global::System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel2 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel3 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.guna2DragControl1 = new global::Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.guna2Panel1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.guna2Button1 = new global::Guna.UI2.WinForms.Guna2Button();
			this.guna2Button2 = new global::Guna.UI2.WinForms.Guna2Button();
			this.label1 = new global::System.Windows.Forms.Label();
			this.guna2Separator2 = new global::Guna.UI2.WinForms.Guna2Separator();
			this.guna2Separator1 = new global::Guna.UI2.WinForms.Guna2Separator();
			this.guna2ControlBox1 = new global::Guna.UI2.WinForms.Guna2ControlBox();
			this.guna2ResizeBox1 = new global::Guna.UI2.WinForms.Guna2ResizeBox();
			this.guna2DragControl2 = new global::Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.guna2BorderlessForm1 = new global::Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			this.contextMenuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.guna2Panel1.SuspendLayout();
			base.SuspendLayout();
			this.listView1.AllowColumnReorder = true;
			this.listView1.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right;
			this.listView1.BackColor = global::System.Drawing.Color.FromArgb(30, 30, 30);
			this.listView1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.listView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[] { this.columnHeader1, this.columnHeader2 });
			this.listView1.ContextMenuStrip = this.contextMenuStrip1;
			this.listView1.ForeColor = global::System.Drawing.Color.Gainsboro;
			listViewGroup.Header = "Folders";
			listViewGroup.Name = "Folders";
			listViewGroup2.Header = "File";
			listViewGroup2.Name = "File";
			this.listView1.Groups.AddRange(new global::System.Windows.Forms.ListViewGroup[] { listViewGroup, listViewGroup2 });
			this.listView1.HideSelection = false;
			this.listView1.LargeImageList = this.imageList1;
			this.listView1.Location = new global::System.Drawing.Point(0, 60);
			this.listView1.Margin = new global::System.Windows.Forms.Padding(2);
			this.listView1.Name = "listView1";
			this.listView1.ShowItemToolTips = true;
			this.listView1.Size = new global::System.Drawing.Size(977, 530);
			this.listView1.SmallImageList = this.imageList1;
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = global::System.Windows.Forms.View.Tile;
			this.listView1.DoubleClick += new global::System.EventHandler(this.listView1_DoubleClick);
			this.contextMenuStrip1.BackColor = global::System.Drawing.Color.FromArgb(240, 240, 240);
			this.contextMenuStrip1.ImageScalingSize = new global::System.Drawing.Size(24, 24);
			this.contextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.backToolStripMenuItem, this.toolStripSeparator7, this.rEFRESHToolStripMenuItem, this.toolStripSeparator8, this.gOTOToolStripMenuItem, this.toolStripSeparator1, this.downloadToolStripMenuItem, this.toolStripSeparator9, this.uPLOADToolStripMenuItem, this.toolStripSeparator10,
				this.eXECUTEToolStripMenuItem, this.toolStripSeparator11, this.renameToolStripMenuItem, this.toolStripSeparator12, this.copyToolStripMenuItem, this.toolStripSeparator13, this.cutToolStripMenuItem1, this.toolStripSeparator14, this.pasteToolStripMenuItem, this.toolStripSeparator15,
				this.dELETEToolStripMenuItem, this.toolStripSeparator4, this.sevenZiplStripMenuItem1, this.toolStripSeparator5, this.createFolderToolStripMenuItem, this.toolStripSeparator3, this.openClientFolderToolStripMenuItem
			});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.RenderMode = global::System.Windows.Forms.ToolStripRenderMode.System;
			this.contextMenuStrip1.Size = new global::System.Drawing.Size(191, 502);
			this.backToolStripMenuItem.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.backToolStripMenuItem.ForeColor = global::System.Drawing.Color.Black;
			this.backToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("backToolStripMenuItem.Image")));
			this.backToolStripMenuItem.Name = "backToolStripMenuItem";
			this.backToolStripMenuItem.Size = new global::System.Drawing.Size(190, 30);
			this.backToolStripMenuItem.Text = "Back";
			this.backToolStripMenuItem.Click += new global::System.EventHandler(this.backToolStripMenuItem_Click);
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new global::System.Drawing.Size(187, 6);
			this.rEFRESHToolStripMenuItem.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.rEFRESHToolStripMenuItem.ForeColor = global::System.Drawing.Color.Black;
			this.rEFRESHToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rEFRESHToolStripMenuItem.Image")));
			this.rEFRESHToolStripMenuItem.Name = "rEFRESHToolStripMenuItem";
			this.rEFRESHToolStripMenuItem.Size = new global::System.Drawing.Size(190, 30);
			this.rEFRESHToolStripMenuItem.Text = "Refresh";
			this.rEFRESHToolStripMenuItem.Click += new global::System.EventHandler(this.rEFRESHToolStripMenuItem_Click);
			this.toolStripSeparator8.Name = "toolStripSeparator8";
			this.toolStripSeparator8.Size = new global::System.Drawing.Size(187, 6);
			this.gOTOToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.dESKTOPToolStripMenuItem, this.toolStripSeparator17, this.aPPDATAToolStripMenuItem, this.toolStripSeparator18, this.userProfileToolStripMenuItem, this.toolStripSeparator2, this.driversListsToolStripMenuItem });
			this.gOTOToolStripMenuItem.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.gOTOToolStripMenuItem.ForeColor = global::System.Drawing.Color.Black;
			this.gOTOToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("gOTOToolStripMenuItem.Image")));
			this.gOTOToolStripMenuItem.Name = "gOTOToolStripMenuItem";
			this.gOTOToolStripMenuItem.Size = new global::System.Drawing.Size(190, 30);
			this.gOTOToolStripMenuItem.Text = "Go to";
			this.dESKTOPToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dESKTOPToolStripMenuItem.Image")));
			this.dESKTOPToolStripMenuItem.Name = "dESKTOPToolStripMenuItem";
			this.dESKTOPToolStripMenuItem.Size = new global::System.Drawing.Size(144, 22);
			this.dESKTOPToolStripMenuItem.Text = "Desktop";
			this.dESKTOPToolStripMenuItem.Click += new global::System.EventHandler(this.DESKTOPToolStripMenuItem_Click);
			this.toolStripSeparator17.Name = "toolStripSeparator17";
			this.toolStripSeparator17.Size = new global::System.Drawing.Size(141, 6);
			this.aPPDATAToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aPPDATAToolStripMenuItem.Image")));
			this.aPPDATAToolStripMenuItem.Name = "aPPDATAToolStripMenuItem";
			this.aPPDATAToolStripMenuItem.Size = new global::System.Drawing.Size(144, 22);
			this.aPPDATAToolStripMenuItem.Text = "AppData";
			this.aPPDATAToolStripMenuItem.Click += new global::System.EventHandler(this.APPDATAToolStripMenuItem_Click);
			this.toolStripSeparator18.Name = "toolStripSeparator18";
			this.toolStripSeparator18.Size = new global::System.Drawing.Size(141, 6);
			this.userProfileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("userProfileToolStripMenuItem.Image")));
			this.userProfileToolStripMenuItem.Name = "userProfileToolStripMenuItem";
			this.userProfileToolStripMenuItem.Size = new global::System.Drawing.Size(144, 22);
			this.userProfileToolStripMenuItem.Text = "User Profile";
			this.userProfileToolStripMenuItem.Click += new global::System.EventHandler(this.UserProfileToolStripMenuItem_Click);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new global::System.Drawing.Size(141, 6);
			this.driversListsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("driversListsToolStripMenuItem.Image")));
			this.driversListsToolStripMenuItem.Name = "driversListsToolStripMenuItem";
			this.driversListsToolStripMenuItem.Size = new global::System.Drawing.Size(144, 22);
			this.driversListsToolStripMenuItem.Text = "Drivers";
			this.driversListsToolStripMenuItem.Click += new global::System.EventHandler(this.DriversListsToolStripMenuItem_Click);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new global::System.Drawing.Size(187, 6);
			this.downloadToolStripMenuItem.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.downloadToolStripMenuItem.ForeColor = global::System.Drawing.Color.Black;
			this.downloadToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("downloadToolStripMenuItem.Image")));
			this.downloadToolStripMenuItem.Name = "downloadToolStripMenuItem";
			this.downloadToolStripMenuItem.Size = new global::System.Drawing.Size(190, 30);
			this.downloadToolStripMenuItem.Text = "Download";
			this.downloadToolStripMenuItem.Click += new global::System.EventHandler(this.downloadToolStripMenuItem_Click);
			this.toolStripSeparator9.Name = "toolStripSeparator9";
			this.toolStripSeparator9.Size = new global::System.Drawing.Size(187, 6);
			this.uPLOADToolStripMenuItem.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.uPLOADToolStripMenuItem.ForeColor = global::System.Drawing.Color.Black;
			this.uPLOADToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("uPLOADToolStripMenuItem.Image")));
			this.uPLOADToolStripMenuItem.Name = "uPLOADToolStripMenuItem";
			this.uPLOADToolStripMenuItem.Size = new global::System.Drawing.Size(190, 30);
			this.uPLOADToolStripMenuItem.Text = "Upload";
			this.uPLOADToolStripMenuItem.Click += new global::System.EventHandler(this.uPLOADToolStripMenuItem_Click);
			this.toolStripSeparator10.Name = "toolStripSeparator10";
			this.toolStripSeparator10.Size = new global::System.Drawing.Size(187, 6);
			this.eXECUTEToolStripMenuItem.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.eXECUTEToolStripMenuItem.ForeColor = global::System.Drawing.Color.Black;
			this.eXECUTEToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("eXECUTEToolStripMenuItem.Image")));
			this.eXECUTEToolStripMenuItem.Name = "eXECUTEToolStripMenuItem";
			this.eXECUTEToolStripMenuItem.Size = new global::System.Drawing.Size(190, 30);
			this.eXECUTEToolStripMenuItem.Text = "Execute";
			this.eXECUTEToolStripMenuItem.Click += new global::System.EventHandler(this.eXECUTEToolStripMenuItem_Click);
			this.toolStripSeparator11.Name = "toolStripSeparator11";
			this.toolStripSeparator11.Size = new global::System.Drawing.Size(187, 6);
			this.renameToolStripMenuItem.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.renameToolStripMenuItem.ForeColor = global::System.Drawing.Color.Black;
			this.renameToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("renameToolStripMenuItem.Image")));
			this.renameToolStripMenuItem.Name = "renameToolStripMenuItem";
			this.renameToolStripMenuItem.Size = new global::System.Drawing.Size(190, 30);
			this.renameToolStripMenuItem.Text = "Rename";
			this.renameToolStripMenuItem.Click += new global::System.EventHandler(this.RenameToolStripMenuItem_Click);
			this.toolStripSeparator12.Name = "toolStripSeparator12";
			this.toolStripSeparator12.Size = new global::System.Drawing.Size(187, 6);
			this.copyToolStripMenuItem.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.copyToolStripMenuItem.ForeColor = global::System.Drawing.Color.Black;
			this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.Size = new global::System.Drawing.Size(190, 30);
			this.copyToolStripMenuItem.Text = "Copy";
			this.copyToolStripMenuItem.Click += new global::System.EventHandler(this.CopyToolStripMenuItem_Click);
			this.toolStripSeparator13.Name = "toolStripSeparator13";
			this.toolStripSeparator13.Size = new global::System.Drawing.Size(187, 6);
			this.cutToolStripMenuItem1.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.cutToolStripMenuItem1.ForeColor = global::System.Drawing.Color.Black;
			this.cutToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem1.Image")));
			this.cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
			this.cutToolStripMenuItem1.Size = new global::System.Drawing.Size(190, 30);
			this.cutToolStripMenuItem1.Text = "Cut";
			this.cutToolStripMenuItem1.Click += new global::System.EventHandler(this.CutToolStripMenuItem1_Click);
			this.toolStripSeparator14.Name = "toolStripSeparator14";
			this.toolStripSeparator14.Size = new global::System.Drawing.Size(187, 6);
			this.pasteToolStripMenuItem.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.pasteToolStripMenuItem.ForeColor = global::System.Drawing.Color.Black;
			this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
			this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
			this.pasteToolStripMenuItem.Size = new global::System.Drawing.Size(190, 30);
			this.pasteToolStripMenuItem.Text = "Paste";
			this.pasteToolStripMenuItem.Click += new global::System.EventHandler(this.PasteToolStripMenuItem_Click_1);
			this.toolStripSeparator15.Name = "toolStripSeparator15";
			this.toolStripSeparator15.Size = new global::System.Drawing.Size(187, 6);
			this.dELETEToolStripMenuItem.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.dELETEToolStripMenuItem.ForeColor = global::System.Drawing.Color.Black;
			this.dELETEToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dELETEToolStripMenuItem.Image")));
			this.dELETEToolStripMenuItem.Name = "dELETEToolStripMenuItem";
			this.dELETEToolStripMenuItem.Size = new global::System.Drawing.Size(190, 30);
			this.dELETEToolStripMenuItem.Text = "Delete";
			this.dELETEToolStripMenuItem.Click += new global::System.EventHandler(this.dELETEToolStripMenuItem_Click);
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new global::System.Drawing.Size(187, 6);
			this.sevenZiplStripMenuItem1.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.installToolStripMenuItem, this.toolStripSeparator6, this.zipToolStripMenuItem, this.toolStripSeparator16, this.unzipToolStripMenuItem });
			this.sevenZiplStripMenuItem1.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.sevenZiplStripMenuItem1.ForeColor = global::System.Drawing.Color.Black;
			this.sevenZiplStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("sevenZiplStripMenuItem1.Image")));
			this.sevenZiplStripMenuItem1.Name = "sevenZiplStripMenuItem1";
			this.sevenZiplStripMenuItem1.Size = new global::System.Drawing.Size(190, 30);
			this.sevenZiplStripMenuItem1.Text = "7-Zip";
			this.installToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("installToolStripMenuItem.Image")));
			this.installToolStripMenuItem.Name = "installToolStripMenuItem";
			this.installToolStripMenuItem.Size = new global::System.Drawing.Size(109, 22);
			this.installToolStripMenuItem.Text = "Install";
			this.installToolStripMenuItem.Click += new global::System.EventHandler(this.InstallToolStripMenuItem_Click);
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new global::System.Drawing.Size(106, 6);
			this.zipToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("zipToolStripMenuItem.Image")));
			this.zipToolStripMenuItem.Name = "zipToolStripMenuItem";
			this.zipToolStripMenuItem.Size = new global::System.Drawing.Size(109, 22);
			this.zipToolStripMenuItem.Text = "Zip";
			this.zipToolStripMenuItem.Click += new global::System.EventHandler(this.ZipToolStripMenuItem_Click);
			this.toolStripSeparator16.Name = "toolStripSeparator16";
			this.toolStripSeparator16.Size = new global::System.Drawing.Size(106, 6);
			this.unzipToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("unzipToolStripMenuItem.Image")));
			this.unzipToolStripMenuItem.Name = "unzipToolStripMenuItem";
			this.unzipToolStripMenuItem.Size = new global::System.Drawing.Size(109, 22);
			this.unzipToolStripMenuItem.Text = "Unzip";
			this.unzipToolStripMenuItem.Click += new global::System.EventHandler(this.UnzipToolStripMenuItem_Click);
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new global::System.Drawing.Size(187, 6);
			this.createFolderToolStripMenuItem.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.createFolderToolStripMenuItem.ForeColor = global::System.Drawing.Color.Black;
			this.createFolderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("createFolderToolStripMenuItem.Image")));
			this.createFolderToolStripMenuItem.Name = "createFolderToolStripMenuItem";
			this.createFolderToolStripMenuItem.Size = new global::System.Drawing.Size(190, 30);
			this.createFolderToolStripMenuItem.Text = "New Folder";
			this.createFolderToolStripMenuItem.Click += new global::System.EventHandler(this.CreateFolderToolStripMenuItem_Click);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new global::System.Drawing.Size(187, 6);
			this.openClientFolderToolStripMenuItem.Font = new global::System.Drawing.Font("Segoe UI", 9.75f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.openClientFolderToolStripMenuItem.ForeColor = global::System.Drawing.Color.Black;
			this.openClientFolderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openClientFolderToolStripMenuItem.Image")));
			this.openClientFolderToolStripMenuItem.Name = "openClientFolderToolStripMenuItem";
			this.openClientFolderToolStripMenuItem.Size = new global::System.Drawing.Size(190, 30);
			this.openClientFolderToolStripMenuItem.Text = "Open Client folder";
			this.openClientFolderToolStripMenuItem.Click += new global::System.EventHandler(this.OpenClientFolderToolStripMenuItem_Click);
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = global::System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "AsyncFolder.ico");
			this.imageList1.Images.SetKeyName(1, "icons8_hdd.ico");
			this.imageList1.Images.SetKeyName(2, "icons8_usb_memory_stick_256.png");
			this.statusStrip1.AutoSize = false;
			this.statusStrip1.BackColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.statusStrip1.ImageScalingSize = new global::System.Drawing.Size(24, 24);
			this.statusStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[] { this.toolStripStatusLabel1, this.toolStripStatusLabel2, this.toolStripStatusLabel3 });
			this.statusStrip1.Location = new global::System.Drawing.Point(0, 592);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Padding = new global::System.Windows.Forms.Padding(1, 0, 9, 0);
			this.statusStrip1.Size = new global::System.Drawing.Size(977, 21);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			this.toolStripStatusLabel1.ActiveLinkColor = global::System.Drawing.Color.Gainsboro;
			this.toolStripStatusLabel1.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.toolStripStatusLabel1.LinkColor = global::System.Drawing.Color.Gainsboro;
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new global::System.Drawing.Size(13, 16);
			this.toolStripStatusLabel1.Text = "..";
			this.toolStripStatusLabel1.VisitedLinkColor = global::System.Drawing.Color.Gainsboro;
			this.toolStripStatusLabel2.ActiveLinkColor = global::System.Drawing.Color.Gainsboro;
			this.toolStripStatusLabel2.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.toolStripStatusLabel2.LinkColor = global::System.Drawing.Color.Gainsboro;
			this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
			this.toolStripStatusLabel2.Size = new global::System.Drawing.Size(13, 16);
			this.toolStripStatusLabel2.Text = "..";
			this.toolStripStatusLabel2.VisitedLinkColor = global::System.Drawing.Color.Gainsboro;
			this.toolStripStatusLabel3.ActiveLinkColor = global::System.Drawing.Color.Gainsboro;
			this.toolStripStatusLabel3.ForeColor = global::System.Drawing.Color.Gainsboro;
			this.toolStripStatusLabel3.LinkColor = global::System.Drawing.Color.Gainsboro;
			this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
			this.toolStripStatusLabel3.Size = new global::System.Drawing.Size(13, 16);
			this.toolStripStatusLabel3.Text = "..";
			this.toolStripStatusLabel3.VisitedLinkColor = global::System.Drawing.Color.Gainsboro;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new global::System.EventHandler(this.Timer1_Tick);
			this.guna2Panel1.BackColor = global::System.Drawing.Color.FromArgb(24, 24, 24);
			this.guna2Panel1.Controls.Add(this.guna2Button1);
			this.guna2Panel1.Controls.Add(this.guna2Button2);
			this.guna2Panel1.Controls.Add(this.label1);
			this.guna2Panel1.Controls.Add(this.guna2Separator2);
			this.guna2Panel1.Controls.Add(this.guna2Separator1);
			this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
			this.guna2Panel1.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.guna2Panel1.Location = new global::System.Drawing.Point(0, 0);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
			this.guna2Panel1.Size = new global::System.Drawing.Size(977, 60);
			this.guna2Panel1.TabIndex = 3;
			this.guna2Button1.CheckedState.Parent = this.guna2Button1;
			this.guna2Button1.CustomImages.Parent = this.guna2Button1;
			this.guna2Button1.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button1.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button1.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button1.DisabledState.Parent = this.guna2Button1;
			this.guna2Button1.FillColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.guna2Button1.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2Button1.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button1.HoverState.Parent = this.guna2Button1;
			this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
			this.guna2Button1.ImageSize = new global::System.Drawing.Size(25, 25);
			this.guna2Button1.Location = new global::System.Drawing.Point(787, 15);
			this.guna2Button1.Name = "guna2Button1";
			this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
			this.guna2Button1.Size = new global::System.Drawing.Size(110, 25);
			this.guna2Button1.TabIndex = 132;
			this.guna2Button1.Text = "Desktop";
			this.guna2Button1.Click += new global::System.EventHandler(this.guna2Button1_Click_1);
			this.guna2Button2.CheckedState.Parent = this.guna2Button2;
			this.guna2Button2.CustomImages.Parent = this.guna2Button2;
			this.guna2Button2.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.guna2Button2.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.guna2Button2.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.guna2Button2.DisabledState.Parent = this.guna2Button2;
			this.guna2Button2.FillColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.guna2Button2.Font = new global::System.Drawing.Font("Segoe UI", 9f);
			this.guna2Button2.ForeColor = global::System.Drawing.Color.White;
			this.guna2Button2.HoverState.Parent = this.guna2Button2;
			this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
			this.guna2Button2.ImageSize = new global::System.Drawing.Size(25, 25);
			this.guna2Button2.Location = new global::System.Drawing.Point(130, 15);
			this.guna2Button2.Name = "guna2Button2";
			this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
			this.guna2Button2.Size = new global::System.Drawing.Size(81, 25);
			this.guna2Button2.TabIndex = 131;
			this.guna2Button2.Text = "Back";
			this.guna2Button2.Click += new global::System.EventHandler(this.guna2Button1_Click);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(10, 17);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(101, 20);
			this.label1.TabIndex = 130;
			this.label1.Text = "File Manager";
			this.guna2Separator2.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right;
			this.guna2Separator2.FillColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.guna2Separator2.FillStyle = global::System.Drawing.Drawing2D.DashStyle.Custom;
			this.guna2Separator2.FillThickness = 2;
			this.guna2Separator2.Location = new global::System.Drawing.Point(0, 46);
			this.guna2Separator2.Name = "guna2Separator2";
			this.guna2Separator2.Size = new global::System.Drawing.Size(977, 14);
			this.guna2Separator2.TabIndex = 129;
			this.guna2Separator1.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right;
			this.guna2Separator1.FillColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.guna2Separator1.FillStyle = global::System.Drawing.Drawing2D.DashStyle.Custom;
			this.guna2Separator1.FillThickness = 2;
			this.guna2Separator1.Location = new global::System.Drawing.Point(0, -6);
			this.guna2Separator1.Name = "guna2Separator1";
			this.guna2Separator1.Size = new global::System.Drawing.Size(977, 20);
			this.guna2Separator1.TabIndex = 129;
			this.guna2ControlBox1.Anchor = global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Right;
			this.guna2ControlBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2ControlBox1.FillColor = global::System.Drawing.Color.Transparent;
			this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
			this.guna2ControlBox1.IconColor = global::System.Drawing.Color.White;
			this.guna2ControlBox1.Location = new global::System.Drawing.Point(924, 12);
			this.guna2ControlBox1.Name = "guna2ControlBox1";
			this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
			this.guna2ControlBox1.Size = new global::System.Drawing.Size(41, 32);
			this.guna2ControlBox1.TabIndex = 17;
			this.guna2ResizeBox1.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right;
			this.guna2ResizeBox1.BackColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.guna2ResizeBox1.FillColor = global::System.Drawing.Color.White;
			this.guna2ResizeBox1.ForeColor = global::System.Drawing.Color.Black;
			this.guna2ResizeBox1.Location = new global::System.Drawing.Point(956, 592);
			this.guna2ResizeBox1.Name = "guna2ResizeBox1";
			this.guna2ResizeBox1.Size = new global::System.Drawing.Size(21, 21);
			this.guna2ResizeBox1.TabIndex = 130;
			this.guna2ResizeBox1.TargetControl = this;
			this.guna2DragControl2.TargetControl = this.guna2Panel1;
			this.guna2BorderlessForm1.AnimateWindow = true;
			this.guna2BorderlessForm1.AnimationType = global::Guna.UI2.WinForms.Guna2BorderlessForm.AnimateWindowType.AW_VER_NEGATIVE;
			this.guna2BorderlessForm1.ContainerControl = this;
			this.guna2BorderlessForm1.DockIndicatorColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			this.guna2BorderlessForm1.ShadowColor = global::System.Drawing.Color.FromArgb(8, 104, 81);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(39, 39, 39);
			base.ClientSize = new global::System.Drawing.Size(977, 613);
			base.Controls.Add(this.guna2ResizeBox1);
			base.Controls.Add(this.guna2Panel1);
			base.Controls.Add(this.statusStrip1);
			base.Controls.Add(this.listView1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			base.Margin = new global::System.Windows.Forms.Padding(2);
			base.Name = "FormFileManager";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "File Manager";
			base.FormClosed += new global::System.Windows.Forms.FormClosedEventHandler(this.FormFileManager_FormClosed);
			this.contextMenuStrip1.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.guna2Panel1.ResumeLayout(false);
			this.guna2Panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x040003ED RID: 1005
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040003EE RID: 1006
		public global::System.Windows.Forms.ListView listView1;

		// Token: 0x040003EF RID: 1007
		public global::System.Windows.Forms.ImageList imageList1;

		// Token: 0x040003F0 RID: 1008
		private global::System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

		// Token: 0x040003F1 RID: 1009
		private global::System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;

		// Token: 0x040003F2 RID: 1010
		public global::System.Windows.Forms.StatusStrip statusStrip1;

		// Token: 0x040003F3 RID: 1011
		public global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

		// Token: 0x040003F4 RID: 1012
		public global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;

		// Token: 0x040003F5 RID: 1013
		private global::System.Windows.Forms.ToolStripMenuItem downloadToolStripMenuItem;

		// Token: 0x040003F6 RID: 1014
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

		// Token: 0x040003F7 RID: 1015
		private global::System.Windows.Forms.ToolStripMenuItem uPLOADToolStripMenuItem;

		// Token: 0x040003F8 RID: 1016
		private global::System.Windows.Forms.ToolStripMenuItem dELETEToolStripMenuItem;

		// Token: 0x040003F9 RID: 1017
		private global::System.Windows.Forms.ToolStripMenuItem rEFRESHToolStripMenuItem;

		// Token: 0x040003FA RID: 1018
		private global::System.Windows.Forms.ToolStripMenuItem eXECUTEToolStripMenuItem;

		// Token: 0x040003FB RID: 1019
		private global::System.Windows.Forms.ToolStripMenuItem gOTOToolStripMenuItem;

		// Token: 0x040003FC RID: 1020
		private global::System.Windows.Forms.ToolStripMenuItem dESKTOPToolStripMenuItem;

		// Token: 0x040003FD RID: 1021
		private global::System.Windows.Forms.ToolStripMenuItem aPPDATAToolStripMenuItem;

		// Token: 0x040003FE RID: 1022
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

		// Token: 0x040003FF RID: 1023
		private global::System.Windows.Forms.ToolStripMenuItem createFolderToolStripMenuItem;

		// Token: 0x04000400 RID: 1024
		private global::System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;

		// Token: 0x04000401 RID: 1025
		private global::System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;

		// Token: 0x04000402 RID: 1026
		private global::System.Windows.Forms.ToolStripMenuItem renameToolStripMenuItem;

		// Token: 0x04000403 RID: 1027
		public global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;

		// Token: 0x04000404 RID: 1028
		private global::System.Windows.Forms.ToolStripMenuItem userProfileToolStripMenuItem;

		// Token: 0x04000405 RID: 1029
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

		// Token: 0x04000406 RID: 1030
		private global::System.Windows.Forms.ToolStripMenuItem driversListsToolStripMenuItem;

		// Token: 0x04000407 RID: 1031
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

		// Token: 0x04000408 RID: 1032
		private global::System.Windows.Forms.ToolStripMenuItem openClientFolderToolStripMenuItem;

		// Token: 0x04000409 RID: 1033
		public global::System.Windows.Forms.Timer timer1;

		// Token: 0x0400040A RID: 1034
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator5;

		// Token: 0x0400040B RID: 1035
		private global::System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem1;

		// Token: 0x0400040C RID: 1036
		private global::System.Windows.Forms.ToolStripMenuItem sevenZiplStripMenuItem1;

		// Token: 0x0400040D RID: 1037
		private global::System.Windows.Forms.ToolStripMenuItem installToolStripMenuItem;

		// Token: 0x0400040E RID: 1038
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator6;

		// Token: 0x0400040F RID: 1039
		private global::System.Windows.Forms.ToolStripMenuItem zipToolStripMenuItem;

		// Token: 0x04000410 RID: 1040
		private global::System.Windows.Forms.ToolStripMenuItem unzipToolStripMenuItem;

		// Token: 0x04000411 RID: 1041
		private global::System.Windows.Forms.ColumnHeader columnHeader1;

		// Token: 0x04000412 RID: 1042
		private global::System.Windows.Forms.ColumnHeader columnHeader2;

		// Token: 0x04000413 RID: 1043
		private global::Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;

		// Token: 0x04000414 RID: 1044
		private global::Guna.UI2.WinForms.Guna2Panel guna2Panel1;

		// Token: 0x04000415 RID: 1045
		private global::Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;

		// Token: 0x04000416 RID: 1046
		private global::Guna.UI2.WinForms.Guna2Separator guna2Separator2;

		// Token: 0x04000417 RID: 1047
		private global::Guna.UI2.WinForms.Guna2Separator guna2Separator1;

		// Token: 0x04000418 RID: 1048
		private global::Guna.UI2.WinForms.Guna2ResizeBox guna2ResizeBox1;

		// Token: 0x04000419 RID: 1049
		private global::Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;

		// Token: 0x0400041A RID: 1050
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400041B RID: 1051
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator7;

		// Token: 0x0400041C RID: 1052
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator8;

		// Token: 0x0400041D RID: 1053
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator17;

		// Token: 0x0400041E RID: 1054
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator18;

		// Token: 0x0400041F RID: 1055
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator9;

		// Token: 0x04000420 RID: 1056
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator10;

		// Token: 0x04000421 RID: 1057
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator11;

		// Token: 0x04000422 RID: 1058
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator12;

		// Token: 0x04000423 RID: 1059
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator13;

		// Token: 0x04000424 RID: 1060
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator14;

		// Token: 0x04000425 RID: 1061
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator15;

		// Token: 0x04000426 RID: 1062
		private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator16;

		// Token: 0x04000427 RID: 1063
		private global::Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;

		// Token: 0x04000428 RID: 1064
		private global::Guna.UI2.WinForms.Guna2Button guna2Button2;

		// Token: 0x04000429 RID: 1065
		private global::Guna.UI2.WinForms.Guna2Button guna2Button1;
	}
}
