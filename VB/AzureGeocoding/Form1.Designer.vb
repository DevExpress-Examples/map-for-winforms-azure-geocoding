Namespace AzureGeocoding

    Partial Class Form1

        ''' <summary>
        '''  Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        '''  Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        ''' <summary>
        '''  Required method for Designer support - do not modify
        '''  the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.mapControl1 = New DevExpress.XtraMap.MapControl()
            Me.imageLayer = New DevExpress.XtraMap.ImageLayer()
            Me.azureMapDataProvider1 = New DevExpress.XtraMap.AzureMapDataProvider()
            Me.informationLayer = New DevExpress.XtraMap.InformationLayer()
            Me.azureGeocodeDataProvider1 = New DevExpress.XtraMap.AzureGeocodeDataProvider()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.memoEdit1 = New DevExpress.XtraEditors.MemoEdit()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.textEdit2 = New DevExpress.XtraEditors.TextEdit()
            Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            CType(Me.mapControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.textEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' mapControl1
            ' 
            Me.mapControl1.Layers.Add(Me.imageLayer)
            Me.mapControl1.Layers.Add(Me.informationLayer)
            Me.mapControl1.Location = New Point(3, 1)
            Me.mapControl1.Name = "mapControl1"
            Me.mapControl1.Size = New Size(545, 448)
            Me.mapControl1.TabIndex = 0
            Me.imageLayer.DataProvider = Me.azureMapDataProvider1
            Me.informationLayer.DataProvider = Me.azureGeocodeDataProvider1
            Me.azureGeocodeDataProvider1.AzureKey = Nothing
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.memoEdit1)
            Me.layoutControl1.Controls.Add(Me.simpleButton1)
            Me.layoutControl1.Controls.Add(Me.textEdit2)
            Me.layoutControl1.Controls.Add(Me.textEdit1)
            Me.layoutControl1.Location = New Point(563, 12)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New Rectangle(1075, 0, 812, 500)
            Me.layoutControl1.Root = Me.Root
            Me.layoutControl1.Size = New Size(225, 430)
            Me.layoutControl1.TabIndex = 1
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' memoEdit1
            ' 
            Me.memoEdit1.Location = New Point(12, 95)
            Me.memoEdit1.Name = "memoEdit1"
            Me.memoEdit1.Size = New Size(201, 323)
            Me.memoEdit1.StyleController = Me.layoutControl1
            Me.memoEdit1.TabIndex = 7
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Location = New Point(12, 64)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New Size(201, 27)
            Me.simpleButton1.StyleController = Me.layoutControl1
            Me.simpleButton1.TabIndex = 6
            Me.simpleButton1.Text = "Search for Location"
            ' 
            ' textEdit2
            ' 
            Me.textEdit2.Location = New Point(84, 38)
            Me.textEdit2.Name = "textEdit2"
            Me.textEdit2.Size = New Size(129, 22)
            Me.textEdit2.StyleController = Me.layoutControl1
            Me.textEdit2.TabIndex = 5
            ' 
            ' textEdit1
            ' 
            Me.textEdit1.Location = New Point(84, 12)
            Me.textEdit1.Name = "textEdit1"
            Me.textEdit1.Size = New Size(129, 22)
            Me.textEdit1.StyleController = Me.layoutControl1
            Me.textEdit1.TabIndex = 4
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4})
            Me.Root.Name = "Root"
            Me.Root.Size = New Size(225, 430)
            Me.Root.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.textEdit1
            Me.layoutControlItem1.Location = New Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New Size(205, 26)
            Me.layoutControlItem1.Text = "Latitude:"
            Me.layoutControlItem1.TextSize = New Size(60, 16)
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.textEdit2
            Me.layoutControlItem2.Location = New Point(0, 26)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New Size(205, 26)
            Me.layoutControlItem2.Text = "Longitude:"
            Me.layoutControlItem2.TextSize = New Size(60, 16)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.simpleButton1
            Me.layoutControlItem3.Location = New Point(0, 52)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New Size(205, 31)
            Me.layoutControlItem3.TextSize = New Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.memoEdit1
            Me.layoutControlItem4.Location = New Point(0, 83)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New Size(205, 327)
            Me.layoutControlItem4.TextSize = New Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' Form1
            ' 
            AutoScaleDimensions = New SizeF(8F, 20F)
            AutoScaleMode = AutoScaleMode.Font
            ClientSize = New Size(800, 450)
            Controls.Add(Me.layoutControl1)
            Controls.Add(Me.mapControl1)
            Name = "Form1"
            Text = "Form1"
            Load += AddressOf Form1_Load
            CType(Me.mapControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.textEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.layoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
        End Sub

#End Region
        Private mapControl1 As DevExpress.XtraMap.MapControl

        Private imageLayer As DevExpress.XtraMap.ImageLayer

        Private informationLayer As DevExpress.XtraMap.InformationLayer

        Private azureMapDataProvider1 As DevExpress.XtraMap.AzureMapDataProvider

        Private azureGeocodeDataProvider1 As DevExpress.XtraMap.AzureGeocodeDataProvider

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private memoEdit1 As DevExpress.XtraEditors.MemoEdit

        Private simpleButton1 As DevExpress.XtraEditors.SimpleButton

        Private textEdit2 As DevExpress.XtraEditors.TextEdit

        Private textEdit1 As DevExpress.XtraEditors.TextEdit

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
