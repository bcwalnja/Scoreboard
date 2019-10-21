namespace Scoreboard
{
    partial class DisplayForm
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
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.gaugeControl11 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.txtGameTime = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge();
            this.digitalBackgroundLayerComponent11 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gaugeControl3 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.txtHomeScore = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge();
            this.digitalBackgroundLayerComponent7 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gaugeControl2 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.txtAwayScore = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge();
            this.digitalBackgroundLayerComponent6 = new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblHome = new DevExpress.XtraEditors.LabelControl();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lblAway = new DevExpress.XtraEditors.LabelControl();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGameTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHomeScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAwayScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.emptySpaceItem5,
            this.emptySpaceItem6,
            this.emptySpaceItem7,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1270, 688);
            this.Root.TextVisible = false;
            // 
            // layoutControl1
            // 
            this.layoutControl1.BackColor = System.Drawing.Color.Transparent;
            this.layoutControl1.Controls.Add(this.lblAway);
            this.layoutControl1.Controls.Add(this.lblHome);
            this.layoutControl1.Controls.Add(this.gaugeControl11);
            this.layoutControl1.Controls.Add(this.gaugeControl3);
            this.layoutControl1.Controls.Add(this.gaugeControl2);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1270, 688);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 334);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1250, 167);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // gaugeControl11
            // 
            this.gaugeControl11.BackColor = System.Drawing.Color.Transparent;
            this.gaugeControl11.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gaugeControl11.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.txtGameTime});
            this.gaugeControl11.LayoutPadding = new DevExpress.XtraGauges.Core.Base.Thickness(2);
            this.gaugeControl11.Location = new System.Drawing.Point(326, 12);
            this.gaugeControl11.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.gaugeControl11.Name = "gaugeControl11";
            this.gaugeControl11.Size = new System.Drawing.Size(618, 330);
            this.gaugeControl11.TabIndex = 4;
            // 
            // txtGameTime
            // 
            this.txtGameTime.AppearanceOff.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#400000");
            this.txtGameTime.AppearanceOn.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#FF5050");
            this.txtGameTime.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent[] {
            this.digitalBackgroundLayerComponent11});
            this.txtGameTime.Bounds = new System.Drawing.Rectangle(2, 2, 614, 326);
            this.txtGameTime.DigitCount = 4;
            this.txtGameTime.DisplayMode = DevExpress.XtraGauges.Core.Model.DigitalGaugeDisplayMode.SevenSegment;
            this.txtGameTime.Name = "txtGameTime";
            this.txtGameTime.Padding = new DevExpress.XtraGauges.Core.Base.TextSpacing(26, 20, 26, 20);
            this.txtGameTime.Text = "0:00";
            // 
            // digitalBackgroundLayerComponent11
            // 
            this.digitalBackgroundLayerComponent11.BottomRight = new DevExpress.XtraGauges.Core.Base.PointF2D(211.1F, 106.075F);
            this.digitalBackgroundLayerComponent11.Name = "digitalBackgroundLayerComponent1";
            this.digitalBackgroundLayerComponent11.Shader = new DevExpress.XtraGauges.Core.Drawing.OpacityShader("");
            this.digitalBackgroundLayerComponent11.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style6;
            this.digitalBackgroundLayerComponent11.TopLeft = new DevExpress.XtraGauges.Core.Base.PointF2D(26F, 0F);
            this.digitalBackgroundLayerComponent11.ZOrder = 1000;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.BestFitWeight = 200;
            this.layoutControlItem1.Control = this.gaugeControl11;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(314, 0);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.OptionsTableLayoutItem.ColumnIndex = 3;
            this.layoutControlItem1.OptionsTableLayoutItem.ColumnSpan = 7;
            this.layoutControlItem1.OptionsTableLayoutItem.RowSpan = 4;
            this.layoutControlItem1.Size = new System.Drawing.Size(622, 334);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // gaugeControl3
            // 
            this.gaugeControl3.BackColor = System.Drawing.Color.Transparent;
            this.gaugeControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gaugeControl3.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.txtHomeScore});
            this.gaugeControl3.Location = new System.Drawing.Point(12, 133);
            this.gaugeControl3.Name = "gaugeControl3";
            this.gaugeControl3.Size = new System.Drawing.Size(310, 209);
            this.gaugeControl3.TabIndex = 6;
            // 
            // txtHomeScore
            // 
            this.txtHomeScore.AppearanceOff.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#3C3C00");
            this.txtHomeScore.AppearanceOn.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#FFFF64");
            this.txtHomeScore.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent[] {
            this.digitalBackgroundLayerComponent7});
            this.txtHomeScore.Bounds = new System.Drawing.Rectangle(6, 6, 298, 197);
            this.txtHomeScore.DigitCount = 2;
            this.txtHomeScore.DisplayMode = DevExpress.XtraGauges.Core.Model.DigitalGaugeDisplayMode.SevenSegment;
            this.txtHomeScore.Name = "txtHomeScore";
            this.txtHomeScore.Padding = new DevExpress.XtraGauges.Core.Base.TextSpacing(26, 20, 26, 20);
            this.txtHomeScore.Text = "00";
            // 
            // digitalBackgroundLayerComponent7
            // 
            this.digitalBackgroundLayerComponent7.BottomRight = new DevExpress.XtraGauges.Core.Base.PointF2D(118.55F, 106.075F);
            this.digitalBackgroundLayerComponent7.Name = "digitalBackgroundLayerComponent1";
            this.digitalBackgroundLayerComponent7.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style3;
            this.digitalBackgroundLayerComponent7.TopLeft = new DevExpress.XtraGauges.Core.Base.PointF2D(26F, 0F);
            this.digitalBackgroundLayerComponent7.ZOrder = 1000;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.BestFitWeight = 50;
            this.layoutControlItem3.Control = this.gaugeControl3;
            this.layoutControlItem3.CustomizationFormText = "HOME";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 121);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.OptionsTableLayoutItem.ColumnSpan = 2;
            this.layoutControlItem3.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem3.OptionsTableLayoutItem.RowSpan = 2;
            this.layoutControlItem3.Size = new System.Drawing.Size(314, 213);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "HOME";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // gaugeControl2
            // 
            this.gaugeControl2.BackColor = System.Drawing.Color.Transparent;
            this.gaugeControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gaugeControl2.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.txtAwayScore});
            this.gaugeControl2.Location = new System.Drawing.Point(948, 133);
            this.gaugeControl2.Name = "gaugeControl2";
            this.gaugeControl2.Size = new System.Drawing.Size(310, 209);
            this.gaugeControl2.TabIndex = 5;
            // 
            // txtAwayScore
            // 
            this.txtAwayScore.AppearanceOff.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#34000000");
            this.txtAwayScore.AppearanceOn.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#FFFF64");
            this.txtAwayScore.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent[] {
            this.digitalBackgroundLayerComponent6});
            this.txtAwayScore.Bounds = new System.Drawing.Rectangle(6, 6, 298, 197);
            this.txtAwayScore.DigitCount = 2;
            this.txtAwayScore.DisplayMode = DevExpress.XtraGauges.Core.Model.DigitalGaugeDisplayMode.SevenSegment;
            this.txtAwayScore.Name = "txtAwayScore";
            this.txtAwayScore.Padding = new DevExpress.XtraGauges.Core.Base.TextSpacing(26, 20, 26, 20);
            this.txtAwayScore.Text = "00";
            // 
            // digitalBackgroundLayerComponent6
            // 
            this.digitalBackgroundLayerComponent6.BottomRight = new DevExpress.XtraGauges.Core.Base.PointF2D(118.55F, 106.075F);
            this.digitalBackgroundLayerComponent6.Name = "digitalBackgroundLayerComponent1";
            this.digitalBackgroundLayerComponent6.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style3;
            this.digitalBackgroundLayerComponent6.TopLeft = new DevExpress.XtraGauges.Core.Base.PointF2D(26F, 0F);
            this.digitalBackgroundLayerComponent6.ZOrder = 1000;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.BestFitWeight = 50;
            this.layoutControlItem2.Control = this.gaugeControl2;
            this.layoutControlItem2.CustomizationFormText = "AWAY";
            this.layoutControlItem2.Location = new System.Drawing.Point(936, 121);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnIndex = 10;
            this.layoutControlItem2.OptionsTableLayoutItem.ColumnSpan = 2;
            this.layoutControlItem2.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlItem2.OptionsTableLayoutItem.RowSpan = 2;
            this.layoutControlItem2.Size = new System.Drawing.Size(314, 213);
            this.layoutControlItem2.Text = "AWAY";
            this.layoutControlItem2.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Bottom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextToControlDistance = 0;
            this.layoutControlItem2.TextVisible = false;
            // 
            // lblHome
            // 
            this.lblHome.Appearance.Font = new System.Drawing.Font("Calibri", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblHome.Appearance.Options.UseFont = true;
            this.lblHome.Appearance.Options.UseForeColor = true;
            this.lblHome.Location = new System.Drawing.Point(12, 12);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(257, 117);
            this.lblHome.StyleController = this.layoutControl1;
            this.lblHome.TabIndex = 27;
            this.lblHome.Text = "HOME";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.lblHome;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(261, 121);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.BestFitWeight = 1;
            this.emptySpaceItem5.Location = new System.Drawing.Point(261, 0);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(53, 121);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.BestFitWeight = 1;
            this.emptySpaceItem6.Location = new System.Drawing.Point(936, 0);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(57, 121);
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem7
            // 
            this.emptySpaceItem7.AllowHotTrack = false;
            this.emptySpaceItem7.Location = new System.Drawing.Point(0, 501);
            this.emptySpaceItem7.Name = "emptySpaceItem7";
            this.emptySpaceItem7.Size = new System.Drawing.Size(1250, 167);
            this.emptySpaceItem7.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lblAway
            // 
            this.lblAway.Appearance.Font = new System.Drawing.Font("Calibri", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAway.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblAway.Appearance.Options.UseFont = true;
            this.lblAway.Appearance.Options.UseForeColor = true;
            this.lblAway.Location = new System.Drawing.Point(1005, 12);
            this.lblAway.Name = "lblAway";
            this.lblAway.Size = new System.Drawing.Size(253, 117);
            this.lblAway.StyleController = this.layoutControl1;
            this.lblAway.TabIndex = 28;
            this.lblAway.Text = "AWAY";
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.lblAway;
            this.layoutControlItem5.Location = new System.Drawing.Point(993, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(257, 121);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // DisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Tile;
            this.BackgroundImageStore = global::Scoreboard.Properties.Resources.Metal_Background;
            this.ClientSize = new System.Drawing.Size(1270, 688);
            this.Controls.Add(this.layoutControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.Name = "DisplayForm";
            this.Text = "DisplayForm";
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGameTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHomeScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAwayScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digitalBackgroundLayerComponent6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl11;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge txtGameTime;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent digitalBackgroundLayerComponent11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl3;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge txtHomeScore;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent digitalBackgroundLayerComponent7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl2;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge txtAwayScore;
        private DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent digitalBackgroundLayerComponent6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.LabelControl lblHome;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraEditors.LabelControl lblAway;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}