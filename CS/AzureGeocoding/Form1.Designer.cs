namespace AzureGeocoding
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mapControl1 = new DevExpress.XtraMap.MapControl();
            imageLayer = new DevExpress.XtraMap.ImageLayer();
            azureMapDataProvider1 = new DevExpress.XtraMap.AzureMapDataProvider();
            informationLayer = new DevExpress.XtraMap.InformationLayer();
            azureGeocodeDataProvider1 = new DevExpress.XtraMap.AzureGeocodeDataProvider();
            layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            Root = new DevExpress.XtraLayout.LayoutControlGroup();
            layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)mapControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).BeginInit();
            layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)memoEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Root).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
            SuspendLayout();
            // 
            // mapControl1
            // 
            mapControl1.Layers.Add(imageLayer);
            mapControl1.Layers.Add(informationLayer);
            mapControl1.Location = new Point(3, 1);
            mapControl1.Name = "mapControl1";
            mapControl1.Size = new Size(545, 448);
            mapControl1.TabIndex = 0;
            imageLayer.DataProvider = azureMapDataProvider1;
            informationLayer.DataProvider = azureGeocodeDataProvider1;
            azureGeocodeDataProvider1.AzureKey = null;
            // 
            // layoutControl1
            // 
            layoutControl1.Controls.Add(memoEdit1);
            layoutControl1.Controls.Add(simpleButton1);
            layoutControl1.Controls.Add(textEdit2);
            layoutControl1.Controls.Add(textEdit1);
            layoutControl1.Location = new Point(563, 12);
            layoutControl1.Name = "layoutControl1";
            layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new Rectangle(1075, 0, 812, 500);
            layoutControl1.Root = Root;
            layoutControl1.Size = new Size(225, 430);
            layoutControl1.TabIndex = 1;
            layoutControl1.Text = "layoutControl1";
            // 
            // memoEdit1
            // 
            memoEdit1.Location = new Point(12, 95);
            memoEdit1.Name = "memoEdit1";
            memoEdit1.Size = new Size(201, 323);
            memoEdit1.StyleController = layoutControl1;
            memoEdit1.TabIndex = 7;
            // 
            // simpleButton1
            // 
            simpleButton1.Location = new Point(12, 64);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new Size(201, 27);
            simpleButton1.StyleController = layoutControl1;
            simpleButton1.TabIndex = 6;
            simpleButton1.Text = "Search for Location";
            // 
            // textEdit2
            // 
            textEdit2.Location = new Point(84, 38);
            textEdit2.Name = "textEdit2";
            textEdit2.Size = new Size(129, 22);
            textEdit2.StyleController = layoutControl1;
            textEdit2.TabIndex = 5;
            // 
            // textEdit1
            // 
            textEdit1.Location = new Point(84, 12);
            textEdit1.Name = "textEdit1";
            textEdit1.Size = new Size(129, 22);
            textEdit1.StyleController = layoutControl1;
            textEdit1.TabIndex = 4;
            // 
            // Root
            // 
            Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            Root.GroupBordersVisible = false;
            Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlItem1, layoutControlItem2, layoutControlItem3, layoutControlItem4 });
            Root.Name = "Root";
            Root.Size = new Size(225, 430);
            Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            layoutControlItem1.Control = textEdit1;
            layoutControlItem1.Location = new Point(0, 0);
            layoutControlItem1.Name = "layoutControlItem1";
            layoutControlItem1.Size = new Size(205, 26);
            layoutControlItem1.Text = "Latitude:";
            layoutControlItem1.TextSize = new Size(60, 16);
            // 
            // layoutControlItem2
            // 
            layoutControlItem2.Control = textEdit2;
            layoutControlItem2.Location = new Point(0, 26);
            layoutControlItem2.Name = "layoutControlItem2";
            layoutControlItem2.Size = new Size(205, 26);
            layoutControlItem2.Text = "Longitude:";
            layoutControlItem2.TextSize = new Size(60, 16);
            // 
            // layoutControlItem3
            // 
            layoutControlItem3.Control = simpleButton1;
            layoutControlItem3.Location = new Point(0, 52);
            layoutControlItem3.Name = "layoutControlItem3";
            layoutControlItem3.Size = new Size(205, 31);
            layoutControlItem3.TextSize = new Size(0, 0);
            layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            layoutControlItem4.Control = memoEdit1;
            layoutControlItem4.Location = new Point(0, 83);
            layoutControlItem4.Name = "layoutControlItem4";
            layoutControlItem4.Size = new Size(205, 327);
            layoutControlItem4.TextSize = new Size(0, 0);
            layoutControlItem4.TextVisible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(layoutControl1);
            Controls.Add(mapControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)mapControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControl1).EndInit();
            layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)memoEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)Root).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
            ((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraMap.MapControl mapControl1;
        private DevExpress.XtraMap.ImageLayer imageLayer;
        private DevExpress.XtraMap.InformationLayer informationLayer;
        private DevExpress.XtraMap.AzureMapDataProvider azureMapDataProvider1;
        private DevExpress.XtraMap.AzureGeocodeDataProvider azureGeocodeDataProvider1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}
