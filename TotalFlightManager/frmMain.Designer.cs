
namespace TotalFlightManager
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.radThemeManager1 = new Telerik.WinControls.RadThemeManager();
            this.fluentDarkTheme1 = new Telerik.WinControls.Themes.FluentDarkTheme();
            this.radRibbonBar1 = new Telerik.WinControls.UI.RadRibbonBar();
            this.ribbonTab1 = new Telerik.WinControls.UI.RibbonTab();
            this.radRibbonBarGroup1 = new Telerik.WinControls.UI.RadRibbonBarGroup();
            this.cmdConnect = new Telerik.WinControls.UI.RadButtonElement();
            this.cmdDisconnect = new Telerik.WinControls.UI.RadButtonElement();
            this.radButtonElement3 = new Telerik.WinControls.UI.RadButtonElement();
            this.ribbonTab2 = new Telerik.WinControls.UI.RibbonTab();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radStatusStrip1 = new Telerik.WinControls.UI.RadStatusStrip();
            this.radLabelElement1 = new Telerik.WinControls.UI.RadLabelElement();
            this.radSplitContainer1 = new Telerik.WinControls.UI.RadSplitContainer();
            this.splitPanel1 = new Telerik.WinControls.UI.SplitPanel();
            this.textBox_groundaltitude = new System.Windows.Forms.TextBox();
            this.label_groundaltitude = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.label_trueheading = new System.Windows.Forms.Label();
            this.label_longitude = new System.Windows.Forms.Label();
            this.label_latitude = new System.Windows.Forms.Label();
            this.textBox_trueheading = new System.Windows.Forms.TextBox();
            this.textBox_longitude = new System.Windows.Forms.TextBox();
            this.textBox_latitude = new System.Windows.Forms.TextBox();
            this.splitPanel2 = new Telerik.WinControls.UI.SplitPanel();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).BeginInit();
            this.radSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).BeginInit();
            this.splitPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).BeginInit();
            this.splitPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radRibbonBar1
            // 
            this.radRibbonBar1.CommandTabs.AddRange(new Telerik.WinControls.RadItem[] {
            this.ribbonTab1,
            this.ribbonTab2});
            // 
            // 
            // 
            // 
            // 
            // 
            this.radRibbonBar1.ExitButton.ButtonElement.ShowBorder = false;
            this.radRibbonBar1.ExitButton.Text = "Exit";
            this.radRibbonBar1.LocalizationSettings.LayoutModeText = "Simplified Layout";
            this.radRibbonBar1.Location = new System.Drawing.Point(0, 0);
            this.radRibbonBar1.Name = "radRibbonBar1";
            // 
            // 
            // 
            // 
            // 
            // 
            this.radRibbonBar1.OptionsButton.ButtonElement.ShowBorder = false;
            this.radRibbonBar1.OptionsButton.Text = "Options";
            this.radRibbonBar1.SimplifiedHeight = 100;
            this.radRibbonBar1.Size = new System.Drawing.Size(800, 159);
            this.radRibbonBar1.StartButtonImage = ((System.Drawing.Image)(resources.GetObject("radRibbonBar1.StartButtonImage")));
            this.radRibbonBar1.StartMenuItems.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1});
            this.radRibbonBar1.TabIndex = 0;
            this.radRibbonBar1.Text = "Total Air Manager";
            this.radRibbonBar1.ThemeName = "FluentDark";
            this.radRibbonBar1.Click += new System.EventHandler(this.radRibbonBar1_Click);
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.IsSelected = true;
            this.ribbonTab1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radRibbonBarGroup1});
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "File";
            this.ribbonTab1.UseMnemonic = false;
            // 
            // radRibbonBarGroup1
            // 
            this.radRibbonBarGroup1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.cmdConnect,
            this.cmdDisconnect,
            this.radButtonElement3});
            this.radRibbonBarGroup1.Name = "radRibbonBarGroup1";
            this.radRibbonBarGroup1.Text = "Sim Connect";
            this.radRibbonBarGroup1.Click += new System.EventHandler(this.radRibbonBarGroup1_Click);
            // 
            // cmdConnect
            // 
            this.cmdConnect.Name = "cmdConnect";
            this.cmdConnect.Text = "Connect";
            this.cmdConnect.Click += new System.EventHandler(this.cmdConnect_Click);
            // 
            // cmdDisconnect
            // 
            this.cmdDisconnect.Name = "cmdDisconnect";
            this.cmdDisconnect.Text = "Disconnect";
            // 
            // radButtonElement3
            // 
            this.radButtonElement3.Name = "radButtonElement3";
            this.radButtonElement3.Text = "radButtonElement3";
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.Name = "ribbonTab2";
            this.ribbonTab2.Text = "Edit";
            this.ribbonTab2.UseMnemonic = false;
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "radMenuItem1";
            // 
            // radStatusStrip1
            // 
            this.radStatusStrip1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radLabelElement1});
            this.radStatusStrip1.Location = new System.Drawing.Point(0, 623);
            this.radStatusStrip1.Name = "radStatusStrip1";
            this.radStatusStrip1.Size = new System.Drawing.Size(800, 26);
            this.radStatusStrip1.TabIndex = 1;
            // 
            // radLabelElement1
            // 
            this.radLabelElement1.Name = "radLabelElement1";
            this.radStatusStrip1.SetSpring(this.radLabelElement1, false);
            this.radLabelElement1.Text = "rsStatusLabel";
            this.radLabelElement1.TextWrap = true;
            // 
            // radSplitContainer1
            // 
            this.radSplitContainer1.Controls.Add(this.splitPanel1);
            this.radSplitContainer1.Controls.Add(this.splitPanel2);
            this.radSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radSplitContainer1.Location = new System.Drawing.Point(0, 159);
            this.radSplitContainer1.Name = "radSplitContainer1";
            // 
            // 
            // 
            this.radSplitContainer1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.radSplitContainer1.Size = new System.Drawing.Size(800, 464);
            this.radSplitContainer1.SplitterWidth = 8;
            this.radSplitContainer1.TabIndex = 2;
            this.radSplitContainer1.TabStop = false;
            this.radSplitContainer1.ThemeName = "FluentDark";
            // 
            // splitPanel1
            // 
            this.splitPanel1.Controls.Add(this.textBox_groundaltitude);
            this.splitPanel1.Controls.Add(this.label_groundaltitude);
            this.splitPanel1.Controls.Add(this.label_status);
            this.splitPanel1.Controls.Add(this.label_trueheading);
            this.splitPanel1.Controls.Add(this.label_longitude);
            this.splitPanel1.Controls.Add(this.label_latitude);
            this.splitPanel1.Controls.Add(this.textBox_trueheading);
            this.splitPanel1.Controls.Add(this.textBox_longitude);
            this.splitPanel1.Controls.Add(this.textBox_latitude);
            this.splitPanel1.Location = new System.Drawing.Point(0, 0);
            this.splitPanel1.Name = "splitPanel1";
            // 
            // 
            // 
            this.splitPanel1.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel1.Size = new System.Drawing.Size(396, 464);
            this.splitPanel1.TabIndex = 0;
            this.splitPanel1.TabStop = false;
            this.splitPanel1.Text = "splitPanel1";
            this.splitPanel1.ThemeName = "FluentDark";
            // 
            // textBox_groundaltitude
            // 
            this.textBox_groundaltitude.Location = new System.Drawing.Point(107, 128);
            this.textBox_groundaltitude.Name = "textBox_groundaltitude";
            this.textBox_groundaltitude.ReadOnly = true;
            this.textBox_groundaltitude.Size = new System.Drawing.Size(140, 20);
            this.textBox_groundaltitude.TabIndex = 17;
            // 
            // label_groundaltitude
            // 
            this.label_groundaltitude.AutoSize = true;
            this.label_groundaltitude.Location = new System.Drawing.Point(3, 135);
            this.label_groundaltitude.Name = "label_groundaltitude";
            this.label_groundaltitude.Size = new System.Drawing.Size(89, 13);
            this.label_groundaltitude.TabIndex = 16;
            this.label_groundaltitude.Text = "ground altitude";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_status.ForeColor = System.Drawing.Color.Red;
            this.label_status.Location = new System.Drawing.Point(12, 15);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(129, 13);
            this.label_status.TabIndex = 15;
            this.label_status.Text = "Not Connected to sim";
            // 
            // label_trueheading
            // 
            this.label_trueheading.AutoSize = true;
            this.label_trueheading.Location = new System.Drawing.Point(3, 111);
            this.label_trueheading.Name = "label_trueheading";
            this.label_trueheading.Size = new System.Drawing.Size(74, 13);
            this.label_trueheading.TabIndex = 14;
            this.label_trueheading.Text = "true heading";
            // 
            // label_longitude
            // 
            this.label_longitude.AutoSize = true;
            this.label_longitude.Location = new System.Drawing.Point(12, 79);
            this.label_longitude.Name = "label_longitude";
            this.label_longitude.Size = new System.Drawing.Size(58, 13);
            this.label_longitude.TabIndex = 13;
            this.label_longitude.Text = "longitude";
            // 
            // label_latitude
            // 
            this.label_latitude.AutoSize = true;
            this.label_latitude.Location = new System.Drawing.Point(12, 43);
            this.label_latitude.Name = "label_latitude";
            this.label_latitude.Size = new System.Drawing.Size(47, 13);
            this.label_latitude.TabIndex = 12;
            this.label_latitude.Text = "latitude";
            // 
            // textBox_trueheading
            // 
            this.textBox_trueheading.Location = new System.Drawing.Point(106, 102);
            this.textBox_trueheading.Name = "textBox_trueheading";
            this.textBox_trueheading.ReadOnly = true;
            this.textBox_trueheading.Size = new System.Drawing.Size(140, 20);
            this.textBox_trueheading.TabIndex = 11;
            this.textBox_trueheading.TextChanged += new System.EventHandler(this.textBox_trueheading_TextChanged);
            // 
            // textBox_longitude
            // 
            this.textBox_longitude.Location = new System.Drawing.Point(106, 76);
            this.textBox_longitude.Name = "textBox_longitude";
            this.textBox_longitude.ReadOnly = true;
            this.textBox_longitude.Size = new System.Drawing.Size(140, 20);
            this.textBox_longitude.TabIndex = 10;
            // 
            // textBox_latitude
            // 
            this.textBox_latitude.Location = new System.Drawing.Point(106, 40);
            this.textBox_latitude.Name = "textBox_latitude";
            this.textBox_latitude.ReadOnly = true;
            this.textBox_latitude.Size = new System.Drawing.Size(140, 20);
            this.textBox_latitude.TabIndex = 9;
            // 
            // splitPanel2
            // 
            this.splitPanel2.Controls.Add(this.gMapControl1);
            this.splitPanel2.Location = new System.Drawing.Point(404, 0);
            this.splitPanel2.Name = "splitPanel2";
            // 
            // 
            // 
            this.splitPanel2.RootElement.MinSize = new System.Drawing.Size(25, 25);
            this.splitPanel2.Size = new System.Drawing.Size(396, 464);
            this.splitPanel2.TabIndex = 1;
            this.splitPanel2.TabStop = false;
            this.splitPanel2.Text = "splitPanel2";
            this.splitPanel2.ThemeName = "FluentDark";
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(0, 0);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(396, 464);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 649);
            this.Controls.Add(this.radSplitContainer1);
            this.Controls.Add(this.radStatusStrip1);
            this.Controls.Add(this.radRibbonBar1);
            this.Name = "frmMain";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Total Air Manager";
            this.ThemeName = "FluentDark";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radRibbonBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radStatusStrip1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radSplitContainer1)).EndInit();
            this.radSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel1)).EndInit();
            this.splitPanel1.ResumeLayout(false);
            this.splitPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitPanel2)).EndInit();
            this.splitPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.RadThemeManager radThemeManager1;
        private Telerik.WinControls.Themes.FluentDarkTheme fluentDarkTheme1;
        private Telerik.WinControls.UI.RadRibbonBar radRibbonBar1;
        private Telerik.WinControls.UI.RibbonTab ribbonTab1;
        private Telerik.WinControls.UI.RadRibbonBarGroup radRibbonBarGroup1;
        private Telerik.WinControls.UI.RibbonTab ribbonTab2;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadButtonElement cmdConnect;
        private Telerik.WinControls.UI.RadButtonElement cmdDisconnect;
        private Telerik.WinControls.UI.RadButtonElement radButtonElement3;
        private Telerik.WinControls.UI.RadStatusStrip radStatusStrip1;
        private Telerik.WinControls.UI.RadLabelElement radLabelElement1;
        private Telerik.WinControls.UI.RadSplitContainer radSplitContainer1;
        private Telerik.WinControls.UI.SplitPanel splitPanel1;
        private Telerik.WinControls.UI.SplitPanel splitPanel2;
        private System.Windows.Forms.TextBox textBox_groundaltitude;
        private System.Windows.Forms.Label label_groundaltitude;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label label_trueheading;
        private System.Windows.Forms.Label label_longitude;
        private System.Windows.Forms.Label label_latitude;
        private System.Windows.Forms.TextBox textBox_trueheading;
        private System.Windows.Forms.TextBox textBox_longitude;
        private System.Windows.Forms.TextBox textBox_latitude;
        private System.Windows.Forms.Timer timer1;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
    }
}