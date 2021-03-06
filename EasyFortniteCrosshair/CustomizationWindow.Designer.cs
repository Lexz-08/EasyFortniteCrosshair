
namespace EasyFortniteCrosshair
{
	partial class CustomizationWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomizationWindow));
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel_minimize = new System.Windows.Forms.Panel();
			this.lbl_minimize = new System.Windows.Forms.Label();
			this.panel_close = new System.Windows.Forms.Panel();
			this.lbl_close = new System.Windows.Forms.Label();
			this.captionbar_title = new System.Windows.Forms.Label();
			this.captionbar_icon = new System.Windows.Forms.PictureBox();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.imageResize = new System.Windows.Forms.CheckBox();
			this.imageY = new System.Windows.Forms.NumericUpDown();
			this.label4 = new System.Windows.Forms.Label();
			this.imageX = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.imageHeight = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.imageWidth = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.windowShowIconInWindow = new System.Windows.Forms.CheckBox();
			this.windowShowInTaskbar = new System.Windows.Forms.CheckBox();
			this.windowTopMost = new System.Windows.Forms.CheckBox();
			this.windowTitle = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.confirmationSettings = new System.Windows.Forms.Button();
			this.systemTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
			this.systrayico_menustrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.systrayico_ExitApp = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1.SuspendLayout();
			this.panel_minimize.SuspendLayout();
			this.panel_close.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.captionbar_icon)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.imageY)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imageX)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imageHeight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imageWidth)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.systrayico_menustrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.panel1.Controls.Add(this.panel_minimize);
			this.panel1.Controls.Add(this.panel_close);
			this.panel1.Controls.Add(this.captionbar_title);
			this.panel1.Controls.Add(this.captionbar_icon);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(485, 40);
			this.panel1.TabIndex = 0;
			this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm);
			// 
			// panel_minimize
			// 
			this.panel_minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
			this.panel_minimize.Controls.Add(this.lbl_minimize);
			this.panel_minimize.Location = new System.Drawing.Point(419, 6);
			this.panel_minimize.Name = "panel_minimize";
			this.panel_minimize.Size = new System.Drawing.Size(27, 27);
			this.panel_minimize.TabIndex = 2;
			// 
			// lbl_minimize
			// 
			this.lbl_minimize.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbl_minimize.Font = new System.Drawing.Font("Webdings", 10F);
			this.lbl_minimize.Location = new System.Drawing.Point(0, 0);
			this.lbl_minimize.Name = "lbl_minimize";
			this.lbl_minimize.Size = new System.Drawing.Size(27, 27);
			this.lbl_minimize.TabIndex = 0;
			this.lbl_minimize.Text = "0";
			this.lbl_minimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl_minimize.Click += new System.EventHandler(this.lbl_minimize_Click);
			this.lbl_minimize.MouseEnter += new System.EventHandler(this.lbl_minimize_MouseEnter);
			this.lbl_minimize.MouseLeave += new System.EventHandler(this.lbl_minimize_MouseLeave);
			// 
			// panel_close
			// 
			this.panel_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
			this.panel_close.Controls.Add(this.lbl_close);
			this.panel_close.Location = new System.Drawing.Point(452, 6);
			this.panel_close.Name = "panel_close";
			this.panel_close.Size = new System.Drawing.Size(27, 27);
			this.panel_close.TabIndex = 1;
			// 
			// lbl_close
			// 
			this.lbl_close.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbl_close.Font = new System.Drawing.Font("Webdings", 10F);
			this.lbl_close.ForeColor = System.Drawing.Color.White;
			this.lbl_close.Location = new System.Drawing.Point(0, 0);
			this.lbl_close.Name = "lbl_close";
			this.lbl_close.Size = new System.Drawing.Size(27, 27);
			this.lbl_close.TabIndex = 0;
			this.lbl_close.Text = "r";
			this.lbl_close.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl_close.Click += new System.EventHandler(this.lbl_close_Click);
			this.lbl_close.MouseEnter += new System.EventHandler(this.lbl_close_MouseEnter);
			this.lbl_close.MouseLeave += new System.EventHandler(this.lbl_close_MouseLeave);
			// 
			// captionbar_title
			// 
			this.captionbar_title.AutoSize = true;
			this.captionbar_title.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.captionbar_title.Location = new System.Drawing.Point(34, 8);
			this.captionbar_title.Name = "captionbar_title";
			this.captionbar_title.Size = new System.Drawing.Size(169, 21);
			this.captionbar_title.TabIndex = 1;
			this.captionbar_title.Text = "Easy Fortnite Crosshair";
			this.captionbar_title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm);
			// 
			// captionbar_icon
			// 
			this.captionbar_icon.Location = new System.Drawing.Point(5, 5);
			this.captionbar_icon.Name = "captionbar_icon";
			this.captionbar_icon.Size = new System.Drawing.Size(29, 29);
			this.captionbar_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.captionbar_icon.TabIndex = 0;
			this.captionbar_icon.TabStop = false;
			this.captionbar_icon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm);
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 46);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(461, 210);
			this.tabControl1.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.imageResize);
			this.tabPage1.Controls.Add(this.imageY);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.imageX);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.imageHeight);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.imageWidth);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new System.Drawing.Point(4, 26);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(453, 180);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Image Settings";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// imageResize
			// 
			this.imageResize.AutoSize = true;
			this.imageResize.Checked = true;
			this.imageResize.CheckState = System.Windows.Forms.CheckState.Checked;
			this.imageResize.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.imageResize.Location = new System.Drawing.Point(15, 144);
			this.imageResize.Name = "imageResize";
			this.imageResize.Size = new System.Drawing.Size(58, 19);
			this.imageResize.TabIndex = 8;
			this.imageResize.Text = "Resize";
			this.imageResize.UseVisualStyleBackColor = true;
			// 
			// imageY
			// 
			this.imageY.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.imageY.Location = new System.Drawing.Point(60, 104);
			this.imageY.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.imageY.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            -2147483648});
			this.imageY.Name = "imageY";
			this.imageY.Size = new System.Drawing.Size(379, 23);
			this.imageY.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label4.Location = new System.Drawing.Point(12, 106);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(17, 15);
			this.label4.TabIndex = 6;
			this.label4.Text = "Y:";
			// 
			// imageX
			// 
			this.imageX.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.imageX.Location = new System.Drawing.Point(60, 75);
			this.imageX.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.imageX.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            -2147483648});
			this.imageX.Name = "imageX";
			this.imageX.Size = new System.Drawing.Size(379, 23);
			this.imageX.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label3.Location = new System.Drawing.Point(12, 77);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(17, 15);
			this.label3.TabIndex = 4;
			this.label3.Text = "X:";
			// 
			// imageHeight
			// 
			this.imageHeight.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.imageHeight.Location = new System.Drawing.Point(60, 46);
			this.imageHeight.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.imageHeight.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            -2147483648});
			this.imageHeight.Name = "imageHeight";
			this.imageHeight.Size = new System.Drawing.Size(379, 23);
			this.imageHeight.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label2.Location = new System.Drawing.Point(12, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 15);
			this.label2.TabIndex = 2;
			this.label2.Text = "Height:";
			// 
			// imageWidth
			// 
			this.imageWidth.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.imageWidth.Location = new System.Drawing.Point(60, 17);
			this.imageWidth.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.imageWidth.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            -2147483648});
			this.imageWidth.Name = "imageWidth";
			this.imageWidth.Size = new System.Drawing.Size(379, 23);
			this.imageWidth.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label1.Location = new System.Drawing.Point(12, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Width:";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.windowShowIconInWindow);
			this.tabPage2.Controls.Add(this.windowShowInTaskbar);
			this.tabPage2.Controls.Add(this.windowTopMost);
			this.tabPage2.Controls.Add(this.windowTitle);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(453, 184);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Window Settings";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// windowShowIconInWindow
			// 
			this.windowShowIconInWindow.AutoSize = true;
			this.windowShowIconInWindow.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.windowShowIconInWindow.Location = new System.Drawing.Point(206, 51);
			this.windowShowIconInWindow.Name = "windowShowIconInWindow";
			this.windowShowIconInWindow.Size = new System.Drawing.Size(132, 19);
			this.windowShowIconInWindow.TabIndex = 4;
			this.windowShowIconInWindow.Text = "ShowIconInWindow";
			this.windowShowIconInWindow.UseVisualStyleBackColor = true;
			// 
			// windowShowInTaskbar
			// 
			this.windowShowInTaskbar.AutoSize = true;
			this.windowShowInTaskbar.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.windowShowInTaskbar.Location = new System.Drawing.Point(96, 51);
			this.windowShowInTaskbar.Name = "windowShowInTaskbar";
			this.windowShowInTaskbar.Size = new System.Drawing.Size(104, 19);
			this.windowShowInTaskbar.TabIndex = 3;
			this.windowShowInTaskbar.Text = "ShowInTaskbar";
			this.windowShowInTaskbar.UseVisualStyleBackColor = true;
			// 
			// windowTopMost
			// 
			this.windowTopMost.AutoSize = true;
			this.windowTopMost.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.windowTopMost.Location = new System.Drawing.Point(18, 51);
			this.windowTopMost.Name = "windowTopMost";
			this.windowTopMost.Size = new System.Drawing.Size(72, 19);
			this.windowTopMost.TabIndex = 2;
			this.windowTopMost.Text = "TopMost";
			this.windowTopMost.UseVisualStyleBackColor = true;
			// 
			// windowTitle
			// 
			this.windowTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.windowTitle.Location = new System.Drawing.Point(53, 13);
			this.windowTitle.Name = "windowTitle";
			this.windowTitle.Size = new System.Drawing.Size(387, 23);
			this.windowTitle.TabIndex = 1;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label6.Location = new System.Drawing.Point(15, 16);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 15);
			this.label6.TabIndex = 0;
			this.label6.Text = "Title:";
			// 
			// confirmationSettings
			// 
			this.confirmationSettings.Location = new System.Drawing.Point(12, 258);
			this.confirmationSettings.Name = "confirmationSettings";
			this.confirmationSettings.Size = new System.Drawing.Size(461, 37);
			this.confirmationSettings.TabIndex = 2;
			this.confirmationSettings.Text = "Confirm Settings";
			this.confirmationSettings.UseVisualStyleBackColor = true;
			this.confirmationSettings.Click += new System.EventHandler(this.confirmationSettings_Click);
			// 
			// systemTrayIcon
			// 
			this.systemTrayIcon.ContextMenuStrip = this.systrayico_menustrip;
			this.systemTrayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("systemTrayIcon.Icon")));
			this.systemTrayIcon.Text = "Easy Fortnite Crosshair";
			this.systemTrayIcon.Visible = true;
			// 
			// systrayico_menustrip
			// 
			this.systrayico_menustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systrayico_ExitApp});
			this.systrayico_menustrip.Name = "systemTrayIcon_Exit";
			this.systrayico_menustrip.Size = new System.Drawing.Size(94, 26);
			// 
			// systrayico_ExitApp
			// 
			this.systrayico_ExitApp.Name = "systrayico_ExitApp";
			this.systrayico_ExitApp.Size = new System.Drawing.Size(93, 22);
			this.systrayico_ExitApp.Text = "Exit";
			this.systrayico_ExitApp.Click += new System.EventHandler(this.systrayico_ExitApp_Click);
			// 
			// CustomizationWindow
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(485, 307);
			this.Controls.Add(this.confirmationSettings);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "CustomizationWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Easy Fortnite Crosshair";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel_minimize.ResumeLayout(false);
			this.panel_close.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.captionbar_icon)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.imageY)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imageX)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imageHeight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imageWidth)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.systrayico_menustrip.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label captionbar_title;
		private System.Windows.Forms.PictureBox captionbar_icon;
		private System.Windows.Forms.Panel panel_close;
		private System.Windows.Forms.Label lbl_close;
		private System.Windows.Forms.Panel panel_minimize;
		private System.Windows.Forms.Label lbl_minimize;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.NumericUpDown imageY;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown imageX;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.NumericUpDown imageHeight;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown imageWidth;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox imageResize;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox windowTitle;
		private System.Windows.Forms.CheckBox windowTopMost;
		private System.Windows.Forms.CheckBox windowShowIconInWindow;
		private System.Windows.Forms.CheckBox windowShowInTaskbar;
		private System.Windows.Forms.Button confirmationSettings;
		private System.Windows.Forms.NotifyIcon systemTrayIcon;
		private System.Windows.Forms.ToolStripMenuItem systrayico_ExitApp;
		private System.Windows.Forms.ContextMenuStrip systrayico_menustrip;
	}
}

