Partial Public Class Frm_LogIn
    Inherits DevExpress.XtraEditors.XtraForm

    ''' <summary>
    ''' Required designer variable.
    ''' </summary>
    Private components As System.ComponentModel.IContainer = Nothing

    ''' <summary>
    ''' Clean up any resources being used.
    ''' </summary>
    ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso (components IsNot Nothing) Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

#Region "Windows Form Designer generated code"

    ''' <summary>
    ''' Required method for Designer support - do not modify
    ''' the contents of this method with the code editor.
    ''' </summary>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_LogIn))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim BorderEdges2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Me.ImageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
        Me.PopupControlContainer2 = New DevExpress.XtraBars.PopupControlContainer(Me.components)
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.SimpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.DefaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
        Me.Label_ModuleVersion = New DevExpress.XtraEditors.LabelControl()
        Me.DataSet = New POS.DataSet()
        Me.TableAdapterManager = New POS.DataSetTableAdapters.TableAdapterManager()
        Me.Sp_POS_LoginEntryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_POS_LoginEntryTableAdapter = New POS.DataSetTableAdapters.sp_POS_LoginEntryTableAdapter()
        Me.Ed_Password = New DevExpress.XtraEditors.TextEdit()
        Me.Ed_Username = New DevExpress.XtraEditors.TextEdit()
        Me.BunifuPictureBox1 = New Bunifu.UI.WinForms.BunifuPictureBox()
        Me.ComboBox_Config = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Ed_PrinterKitchen = New DevExpress.XtraEditors.TextEdit()
        Me.GeneralPathTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.Ed_ACEServerAddress = New DevExpress.XtraEditors.TextEdit()
        Me.SourceTextEdit = New DevExpress.XtraEditors.TextEdit()
        Me.LookUpEdit_ACEDB = New DevExpress.XtraEditors.TextEdit()
        Me.Ed_PrinterCashier = New DevExpress.XtraEditors.TextEdit()
        Me.Ed_PrinterMini = New DevExpress.XtraEditors.TextEdit()
        Me.Ed_PrinterPantry = New DevExpress.XtraEditors.TextEdit()
        Me.Ed_PrinterGrill = New DevExpress.XtraEditors.TextEdit()
        Me.Ed_PrinterBar = New DevExpress.XtraEditors.TextEdit()
        Me.Ed_PrinterDokumen = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem20 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem54 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem25 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem22 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem34 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem44 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.BB_Setting = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.BB_Login = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupControlContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PopupControlContainer2.SuspendLayout()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_POS_LoginEntryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_Password.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_Username.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComboBox_Config.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_PrinterKitchen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GeneralPathTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_ACEServerAddress.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SourceTextEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpEdit_ACEDB.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_PrinterCashier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_PrinterMini.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_PrinterPantry.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_PrinterGrill.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_PrinterBar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ed_PrinterDokumen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem54, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem44, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageCollection1
        '
        Me.ImageCollection1.ImageStream = CType(resources.GetObject("ImageCollection1.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection1.Images.SetKeyName(0, "Normal.png")
        Me.ImageCollection1.Images.SetKeyName(1, "Hot.png")
        Me.ImageCollection1.Images.SetKeyName(2, "Pressed.png")
        '
        'PopupControlContainer2
        '
        Me.PopupControlContainer2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PopupControlContainer2.Controls.Add(Me.LayoutControl2)
        Me.PopupControlContainer2.Location = New System.Drawing.Point(381, 28)
        Me.PopupControlContainer2.Margin = New System.Windows.Forms.Padding(4)
        Me.PopupControlContainer2.Name = "PopupControlContainer2"
        Me.PopupControlContainer2.Padding = New System.Windows.Forms.Padding(22, 21, 22, 21)
        Me.PopupControlContainer2.Size = New System.Drawing.Size(861, 334)
        Me.PopupControlContainer2.TabIndex = 49
        Me.PopupControlContainer2.Visible = False
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Appearance.Control.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LayoutControl2.Appearance.Control.Options.UseFont = True
        Me.LayoutControl2.Controls.Add(Me.Ed_PrinterKitchen)
        Me.LayoutControl2.Controls.Add(Me.LabelControl1)
        Me.LayoutControl2.Controls.Add(Me.GeneralPathTextEdit)
        Me.LayoutControl2.Controls.Add(Me.Ed_ACEServerAddress)
        Me.LayoutControl2.Controls.Add(Me.SourceTextEdit)
        Me.LayoutControl2.Controls.Add(Me.LookUpEdit_ACEDB)
        Me.LayoutControl2.Controls.Add(Me.Ed_PrinterCashier)
        Me.LayoutControl2.Controls.Add(Me.Ed_PrinterMini)
        Me.LayoutControl2.Controls.Add(Me.Ed_PrinterPantry)
        Me.LayoutControl2.Controls.Add(Me.Ed_PrinterGrill)
        Me.LayoutControl2.Controls.Add(Me.Ed_PrinterBar)
        Me.LayoutControl2.Controls.Add(Me.Ed_PrinterDokumen)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(22, 21)
        Me.LayoutControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(792, 153, 250, 350)
        Me.LayoutControl2.Root = Me.LayoutControlGroup2
        Me.LayoutControl2.Size = New System.Drawing.Size(817, 292)
        Me.LayoutControl2.TabIndex = 0
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(3, 3)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(811, 19)
        Me.LabelControl1.StyleController = Me.LayoutControl2
        Me.LabelControl1.TabIndex = 7
        Me.LabelControl1.Text = "Application configuration"
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.AppearanceItemCaption.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LayoutControlGroup2.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlGroup2.CustomizationFormText = "Application configuration"
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.SimpleSeparator1, Me.LayoutControlItem15, Me.LayoutControlItem13, Me.LayoutControlItem20, Me.LayoutControlItem54, Me.LayoutControlItem25, Me.LayoutControlItem12, Me.LayoutControlItem9, Me.LayoutControlItem16, Me.LayoutControlItem22, Me.EmptySpaceItem3, Me.EmptySpaceItem4, Me.LayoutControlItem8, Me.LayoutControlItem34, Me.LayoutControlItem44})
        Me.LayoutControlGroup2.Name = "Root"
        Me.LayoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(3, 3, 3, 3)
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(817, 292)
        Me.LayoutControlGroup2.Text = "Application configuration"
        '
        'SimpleSeparator1
        '
        Me.SimpleSeparator1.AllowHotTrack = False
        Me.SimpleSeparator1.CustomizationFormText = "SimpleSeparator1"
        Me.SimpleSeparator1.Location = New System.Drawing.Point(0, 61)
        Me.SimpleSeparator1.Name = "SimpleSeparator1"
        Me.SimpleSeparator1.Size = New System.Drawing.Size(386, 1)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.LabelControl1
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem13.Name = "LayoutControlItem4"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(817, 25)
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(0, 98)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(386, 122)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(386, 25)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(15, 267)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'DefaultLookAndFeel1
        '
        Me.DefaultLookAndFeel1.LookAndFeel.SkinName = "WXI"
        '
        'Label_ModuleVersion
        '
        Me.Label_ModuleVersion.Location = New System.Drawing.Point(604, 457)
        Me.Label_ModuleVersion.Name = "Label_ModuleVersion"
        Me.Label_ModuleVersion.Size = New System.Drawing.Size(95, 18)
        Me.Label_ModuleVersion.TabIndex = 52
        Me.Label_ModuleVersion.Text = "LabelControl2"
        '
        'DataSet
        '
        Me.DataSet.DataSetName = "DataSet"
        Me.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = POS.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Sp_POS_LoginEntryBindingSource
        '
        Me.Sp_POS_LoginEntryBindingSource.DataMember = "sp_POS_LoginEntry"
        Me.Sp_POS_LoginEntryBindingSource.DataSource = Me.DataSet
        '
        'Sp_POS_LoginEntryTableAdapter
        '
        Me.Sp_POS_LoginEntryTableAdapter.ClearBeforeFill = True
        '
        'Ed_Password
        '
        Me.Ed_Password.Location = New System.Drawing.Point(46, 563)
        Me.Ed_Password.Name = "Ed_Password"
        Me.Ed_Password.Size = New System.Drawing.Size(100, 32)
        Me.Ed_Password.TabIndex = 51
        '
        'Ed_Username
        '
        Me.Ed_Username.Location = New System.Drawing.Point(46, 524)
        Me.Ed_Username.Name = "Ed_Username"
        Me.Ed_Username.Size = New System.Drawing.Size(100, 32)
        Me.Ed_Username.TabIndex = 50
        '
        'BunifuPictureBox1
        '
        Me.BunifuPictureBox1.AllowFocused = False
        Me.BunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BunifuPictureBox1.AutoSizeHeight = True
        Me.BunifuPictureBox1.BorderRadius = 247
        Me.BunifuPictureBox1.Image = CType(resources.GetObject("BunifuPictureBox1.Image"), System.Drawing.Image)
        Me.BunifuPictureBox1.IsCircle = True
        Me.BunifuPictureBox1.Location = New System.Drawing.Point(-229, -37)
        Me.BunifuPictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuPictureBox1.Name = "BunifuPictureBox1"
        Me.BunifuPictureBox1.Size = New System.Drawing.Size(494, 494)
        Me.BunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BunifuPictureBox1.TabIndex = 0
        Me.BunifuPictureBox1.TabStop = False
        Me.BunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle
        '
        'ComboBox_Config
        '
        Me.ComboBox_Config.Location = New System.Drawing.Point(137, 21)
        Me.ComboBox_Config.Margin = New System.Windows.Forms.Padding(4)
        Me.ComboBox_Config.Name = "ComboBox_Config"
        Me.ComboBox_Config.Properties.AllowFocused = False
        Me.ComboBox_Config.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ComboBox_Config.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.ComboBox_Config.Properties.Appearance.Options.UseBackColor = True
        Me.ComboBox_Config.Properties.Appearance.Options.UseFont = True
        Me.ComboBox_Config.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
        Me.ComboBox_Config.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.ComboBox_Config.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.ComboBox_Config.Size = New System.Drawing.Size(340, 34)
        Me.ComboBox_Config.TabIndex = 2
        Me.ComboBox_Config.Visible = False
        '
        'Ed_PrinterKitchen
        '
        Me.Ed_PrinterKitchen.Location = New System.Drawing.Point(530, 172)
        Me.Ed_PrinterKitchen.Margin = New System.Windows.Forms.Padding(4)
        Me.Ed_PrinterKitchen.Name = "Ed_PrinterKitchen"
        Me.Ed_PrinterKitchen.Properties.ReadOnly = True
        Me.Ed_PrinterKitchen.Size = New System.Drawing.Size(284, 30)
        Me.Ed_PrinterKitchen.StyleController = Me.LayoutControl2
        Me.Ed_PrinterKitchen.TabIndex = 20
        '
        'GeneralPathTextEdit
        '
        Me.GeneralPathTextEdit.Location = New System.Drawing.Point(128, 223)
        Me.GeneralPathTextEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.GeneralPathTextEdit.Name = "GeneralPathTextEdit"
        Me.GeneralPathTextEdit.Properties.ReadOnly = True
        Me.GeneralPathTextEdit.Size = New System.Drawing.Size(255, 30)
        Me.GeneralPathTextEdit.StyleController = Me.LayoutControl2
        Me.GeneralPathTextEdit.TabIndex = 19
        '
        'Ed_ACEServerAddress
        '
        Me.Ed_ACEServerAddress.Location = New System.Drawing.Point(129, 65)
        Me.Ed_ACEServerAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.Ed_ACEServerAddress.Name = "Ed_ACEServerAddress"
        Me.Ed_ACEServerAddress.Properties.ReadOnly = True
        Me.Ed_ACEServerAddress.Size = New System.Drawing.Size(254, 30)
        Me.Ed_ACEServerAddress.StyleController = Me.LayoutControl2
        Me.Ed_ACEServerAddress.TabIndex = 13
        '
        'SourceTextEdit
        '
        Me.SourceTextEdit.Location = New System.Drawing.Point(128, 259)
        Me.SourceTextEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.SourceTextEdit.Name = "SourceTextEdit"
        Me.SourceTextEdit.Properties.ReadOnly = True
        Me.SourceTextEdit.Size = New System.Drawing.Size(255, 30)
        Me.SourceTextEdit.StyleController = Me.LayoutControl2
        Me.SourceTextEdit.TabIndex = 6
        '
        'LookUpEdit_ACEDB
        '
        Me.LookUpEdit_ACEDB.Location = New System.Drawing.Point(129, 28)
        Me.LookUpEdit_ACEDB.Margin = New System.Windows.Forms.Padding(4)
        Me.LookUpEdit_ACEDB.Name = "LookUpEdit_ACEDB"
        Me.LookUpEdit_ACEDB.Properties.ReadOnly = True
        Me.LookUpEdit_ACEDB.Size = New System.Drawing.Size(254, 30)
        Me.LookUpEdit_ACEDB.StyleController = Me.LayoutControl2
        Me.LookUpEdit_ACEDB.TabIndex = 14
        '
        'Ed_PrinterCashier
        '
        Me.Ed_PrinterCashier.Location = New System.Drawing.Point(574, 100)
        Me.Ed_PrinterCashier.Margin = New System.Windows.Forms.Padding(4)
        Me.Ed_PrinterCashier.Name = "Ed_PrinterCashier"
        Me.Ed_PrinterCashier.Properties.ReadOnly = True
        Me.Ed_PrinterCashier.Size = New System.Drawing.Size(240, 30)
        Me.Ed_PrinterCashier.StyleController = Me.LayoutControl2
        Me.Ed_PrinterCashier.TabIndex = 6
        '
        'Ed_PrinterMini
        '
        Me.Ed_PrinterMini.Location = New System.Drawing.Point(574, 64)
        Me.Ed_PrinterMini.Margin = New System.Windows.Forms.Padding(4)
        Me.Ed_PrinterMini.Name = "Ed_PrinterMini"
        Me.Ed_PrinterMini.Properties.ReadOnly = True
        Me.Ed_PrinterMini.Size = New System.Drawing.Size(240, 30)
        Me.Ed_PrinterMini.StyleController = Me.LayoutControl2
        Me.Ed_PrinterMini.TabIndex = 15
        '
        'Ed_PrinterPantry
        '
        Me.Ed_PrinterPantry.Location = New System.Drawing.Point(574, 136)
        Me.Ed_PrinterPantry.Margin = New System.Windows.Forms.Padding(4)
        Me.Ed_PrinterPantry.Name = "Ed_PrinterPantry"
        Me.Ed_PrinterPantry.Properties.ReadOnly = True
        Me.Ed_PrinterPantry.Size = New System.Drawing.Size(240, 30)
        Me.Ed_PrinterPantry.StyleController = Me.LayoutControl2
        Me.Ed_PrinterPantry.TabIndex = 19
        '
        'Ed_PrinterGrill
        '
        Me.Ed_PrinterGrill.Location = New System.Drawing.Point(574, 208)
        Me.Ed_PrinterGrill.Margin = New System.Windows.Forms.Padding(4)
        Me.Ed_PrinterGrill.Name = "Ed_PrinterGrill"
        Me.Ed_PrinterGrill.Properties.ReadOnly = True
        Me.Ed_PrinterGrill.Size = New System.Drawing.Size(240, 30)
        Me.Ed_PrinterGrill.StyleController = Me.LayoutControl2
        Me.Ed_PrinterGrill.TabIndex = 19
        '
        'Ed_PrinterBar
        '
        Me.Ed_PrinterBar.Location = New System.Drawing.Point(575, 244)
        Me.Ed_PrinterBar.Margin = New System.Windows.Forms.Padding(4)
        Me.Ed_PrinterBar.Name = "Ed_PrinterBar"
        Me.Ed_PrinterBar.Properties.ReadOnly = True
        Me.Ed_PrinterBar.Size = New System.Drawing.Size(239, 30)
        Me.Ed_PrinterBar.StyleController = Me.LayoutControl2
        Me.Ed_PrinterBar.TabIndex = 19
        '
        'Ed_PrinterDokumen
        '
        Me.Ed_PrinterDokumen.Location = New System.Drawing.Point(575, 28)
        Me.Ed_PrinterDokumen.Margin = New System.Windows.Forms.Padding(4)
        Me.Ed_PrinterDokumen.Name = "Ed_PrinterDokumen"
        Me.Ed_PrinterDokumen.Properties.ReadOnly = True
        Me.Ed_PrinterDokumen.Size = New System.Drawing.Size(239, 30)
        Me.Ed_PrinterDokumen.StyleController = Me.LayoutControl2
        Me.Ed_PrinterDokumen.TabIndex = 19
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.Ed_PrinterMini
        Me.LayoutControlItem15.CustomizationFormText = "Warehouse:"
        Me.LayoutControlItem15.Location = New System.Drawing.Point(401, 61)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(416, 36)
        Me.LayoutControlItem15.Text = "Printer Mini :"
        Me.LayoutControlItem15.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(165, 21)
        Me.LayoutControlItem15.TextToControlDistance = 5
        '
        'LayoutControlItem20
        '
        Me.LayoutControlItem20.Control = Me.LookUpEdit_ACEDB
        Me.LayoutControlItem20.CustomizationFormText = "GII Database:"
        Me.LayoutControlItem20.Location = New System.Drawing.Point(0, 25)
        Me.LayoutControlItem20.Name = "LayoutControlItem11"
        Me.LayoutControlItem20.Size = New System.Drawing.Size(386, 36)
        Me.LayoutControlItem20.Text = "KR Database :"
        Me.LayoutControlItem20.TextSize = New System.Drawing.Size(110, 15)
        '
        'LayoutControlItem54
        '
        Me.LayoutControlItem54.Control = Me.Ed_PrinterDokumen
        Me.LayoutControlItem54.CustomizationFormText = "General Path"
        Me.LayoutControlItem54.Location = New System.Drawing.Point(401, 25)
        Me.LayoutControlItem54.Name = "LayoutControlItem54"
        Me.LayoutControlItem54.Size = New System.Drawing.Size(416, 36)
        Me.LayoutControlItem54.Text = "Printer Dokumen :"
        Me.LayoutControlItem54.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem54.TextSize = New System.Drawing.Size(168, 21)
        Me.LayoutControlItem54.TextToControlDistance = 3
        '
        'LayoutControlItem25
        '
        Me.LayoutControlItem25.Control = Me.Ed_PrinterCashier
        Me.LayoutControlItem25.CustomizationFormText = "Source: "
        Me.LayoutControlItem25.Location = New System.Drawing.Point(401, 97)
        Me.LayoutControlItem25.Name = "LayoutControlItem25"
        Me.LayoutControlItem25.Size = New System.Drawing.Size(416, 36)
        Me.LayoutControlItem25.Text = "Printer Cashier :"
        Me.LayoutControlItem25.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem25.TextSize = New System.Drawing.Size(165, 21)
        Me.LayoutControlItem25.TextToControlDistance = 5
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.Ed_ACEServerAddress
        Me.LayoutControlItem12.CustomizationFormText = "GII Server Address:"
        Me.LayoutControlItem12.Location = New System.Drawing.Point(0, 62)
        Me.LayoutControlItem12.Name = "LayoutControlItem10"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(386, 36)
        Me.LayoutControlItem12.Text = "KR Server Address :"
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(110, 15)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.SourceTextEdit
        Me.LayoutControlItem9.CustomizationFormText = "Source: "
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 256)
        Me.LayoutControlItem9.Name = "LayoutControlItem3"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(386, 36)
        Me.LayoutControlItem9.Text = "Source : "
        Me.LayoutControlItem9.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(120, 21)
        Me.LayoutControlItem9.TextToControlDistance = 5
        '
        'LayoutControlItem16
        '
        Me.LayoutControlItem16.Control = Me.GeneralPathTextEdit
        Me.LayoutControlItem16.CustomizationFormText = "General Path"
        Me.LayoutControlItem16.Location = New System.Drawing.Point(0, 220)
        Me.LayoutControlItem16.Name = "LayoutControlItem5"
        Me.LayoutControlItem16.Size = New System.Drawing.Size(386, 36)
        Me.LayoutControlItem16.Text = "General Path :"
        Me.LayoutControlItem16.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem16.TextSize = New System.Drawing.Size(120, 21)
        Me.LayoutControlItem16.TextToControlDistance = 5
        '
        'LayoutControlItem22
        '
        Me.LayoutControlItem22.Control = Me.Ed_PrinterPantry
        Me.LayoutControlItem22.CustomizationFormText = "General Path"
        Me.LayoutControlItem22.Location = New System.Drawing.Point(401, 133)
        Me.LayoutControlItem22.Name = "LayoutControlItem22"
        Me.LayoutControlItem22.Size = New System.Drawing.Size(416, 36)
        Me.LayoutControlItem22.Text = "Printer Pantry :"
        Me.LayoutControlItem22.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem22.TextSize = New System.Drawing.Size(165, 21)
        Me.LayoutControlItem22.TextToControlDistance = 5
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.Ed_PrinterKitchen
        Me.LayoutControlItem8.Location = New System.Drawing.Point(401, 169)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(416, 36)
        Me.LayoutControlItem8.Text = "Printer Kitchen :"
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(110, 15)
        '
        'LayoutControlItem34
        '
        Me.LayoutControlItem34.Control = Me.Ed_PrinterGrill
        Me.LayoutControlItem34.CustomizationFormText = "General Path"
        Me.LayoutControlItem34.Location = New System.Drawing.Point(401, 205)
        Me.LayoutControlItem34.Name = "LayoutControlItem34"
        Me.LayoutControlItem34.Size = New System.Drawing.Size(416, 36)
        Me.LayoutControlItem34.Text = "Printer Grill :"
        Me.LayoutControlItem34.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem34.TextSize = New System.Drawing.Size(165, 21)
        Me.LayoutControlItem34.TextToControlDistance = 5
        '
        'LayoutControlItem44
        '
        Me.LayoutControlItem44.Control = Me.Ed_PrinterBar
        Me.LayoutControlItem44.CustomizationFormText = "General Path"
        Me.LayoutControlItem44.Location = New System.Drawing.Point(401, 241)
        Me.LayoutControlItem44.Name = "LayoutControlItem44"
        Me.LayoutControlItem44.Size = New System.Drawing.Size(416, 51)
        Me.LayoutControlItem44.Text = "Printer Bar :"
        Me.LayoutControlItem44.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
        Me.LayoutControlItem44.TextSize = New System.Drawing.Size(168, 21)
        Me.LayoutControlItem44.TextToControlDistance = 3
        '
        'BB_Setting
        '
        Me.BB_Setting.AllowAnimations = True
        Me.BB_Setting.AllowMouseEffects = True
        Me.BB_Setting.AllowToggling = False
        Me.BB_Setting.AnimationSpeed = 200
        Me.BB_Setting.AutoGenerateColors = False
        Me.BB_Setting.AutoRoundBorders = False
        Me.BB_Setting.AutoSizeLeftIcon = True
        Me.BB_Setting.AutoSizeRightIcon = True
        Me.BB_Setting.BackColor = System.Drawing.Color.Transparent
        Me.BB_Setting.BackColor1 = System.Drawing.Color.DodgerBlue
        Me.BB_Setting.BackgroundImage = CType(resources.GetObject("BB_Setting.BackgroundImage"), System.Drawing.Image)
        Me.BB_Setting.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BB_Setting.ButtonText = "Setting"
        Me.BB_Setting.ButtonTextMarginLeft = 0
        Me.BB_Setting.ColorContrastOnClick = 45
        Me.BB_Setting.ColorContrastOnHover = 45
        Me.BB_Setting.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.BB_Setting.CustomizableEdges = BorderEdges1
        Me.BB_Setting.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BB_Setting.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BB_Setting.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BB_Setting.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BB_Setting.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BB_Setting.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BB_Setting.ForeColor = System.Drawing.Color.White
        Me.BB_Setting.IconLeft = Nothing
        Me.BB_Setting.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BB_Setting.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BB_Setting.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BB_Setting.IconMarginLeft = 11
        Me.BB_Setting.IconPadding = 10
        Me.BB_Setting.IconRight = Nothing
        Me.BB_Setting.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BB_Setting.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BB_Setting.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BB_Setting.IconSize = 25
        Me.BB_Setting.IdleBorderColor = System.Drawing.Color.DodgerBlue
        Me.BB_Setting.IdleBorderRadius = 1
        Me.BB_Setting.IdleBorderThickness = 1
        Me.BB_Setting.IdleFillColor = System.Drawing.Color.DodgerBlue
        Me.BB_Setting.IdleIconLeftImage = Nothing
        Me.BB_Setting.IdleIconRightImage = Nothing
        Me.BB_Setting.IndicateFocus = False
        Me.BB_Setting.Location = New System.Drawing.Point(3, 659)
        Me.BB_Setting.Name = "BB_Setting"
        Me.BB_Setting.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BB_Setting.OnDisabledState.BorderRadius = 1
        Me.BB_Setting.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BB_Setting.OnDisabledState.BorderThickness = 1
        Me.BB_Setting.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BB_Setting.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BB_Setting.OnDisabledState.IconLeftImage = Nothing
        Me.BB_Setting.OnDisabledState.IconRightImage = Nothing
        Me.BB_Setting.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BB_Setting.onHoverState.BorderRadius = 1
        Me.BB_Setting.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BB_Setting.onHoverState.BorderThickness = 1
        Me.BB_Setting.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BB_Setting.onHoverState.ForeColor = System.Drawing.Color.White
        Me.BB_Setting.onHoverState.IconLeftImage = Nothing
        Me.BB_Setting.onHoverState.IconRightImage = Nothing
        Me.BB_Setting.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue
        Me.BB_Setting.OnIdleState.BorderRadius = 1
        Me.BB_Setting.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BB_Setting.OnIdleState.BorderThickness = 1
        Me.BB_Setting.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue
        Me.BB_Setting.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.BB_Setting.OnIdleState.IconLeftImage = Nothing
        Me.BB_Setting.OnIdleState.IconRightImage = Nothing
        Me.BB_Setting.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BB_Setting.OnPressedState.BorderRadius = 1
        Me.BB_Setting.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BB_Setting.OnPressedState.BorderThickness = 1
        Me.BB_Setting.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BB_Setting.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.BB_Setting.OnPressedState.IconLeftImage = Nothing
        Me.BB_Setting.OnPressedState.IconRightImage = Nothing
        Me.BB_Setting.Size = New System.Drawing.Size(100, 26)
        Me.BB_Setting.TabIndex = 13
        Me.BB_Setting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BB_Setting.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BB_Setting.TextMarginLeft = 0
        Me.BB_Setting.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BB_Setting.UseDefaultRadiusAndThickness = True
        '
        'BB_Login
        '
        Me.BB_Login.AllowAnimations = True
        Me.BB_Login.AllowMouseEffects = True
        Me.BB_Login.AllowToggling = False
        Me.BB_Login.AnimationSpeed = 200
        Me.BB_Login.AutoGenerateColors = False
        Me.BB_Login.AutoRoundBorders = False
        Me.BB_Login.AutoSizeLeftIcon = True
        Me.BB_Login.AutoSizeRightIcon = True
        Me.BB_Login.BackColor = System.Drawing.Color.Transparent
        Me.BB_Login.BackColor1 = System.Drawing.Color.DodgerBlue
        Me.BB_Login.BackgroundImage = CType(resources.GetObject("BB_Login.BackgroundImage"), System.Drawing.Image)
        Me.BB_Login.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BB_Login.ButtonText = "Login"
        Me.BB_Login.ButtonTextMarginLeft = 0
        Me.BB_Login.ColorContrastOnClick = 45
        Me.BB_Login.ColorContrastOnHover = 45
        Me.BB_Login.Cursor = System.Windows.Forms.Cursors.Default
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = True
        Me.BB_Login.CustomizableEdges = BorderEdges2
        Me.BB_Login.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BB_Login.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BB_Login.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BB_Login.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BB_Login.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.BB_Login.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BB_Login.ForeColor = System.Drawing.Color.White
        Me.BB_Login.IconLeft = Nothing
        Me.BB_Login.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BB_Login.IconLeftCursor = System.Windows.Forms.Cursors.Default
        Me.BB_Login.IconLeftPadding = New System.Windows.Forms.Padding(11, 3, 3, 3)
        Me.BB_Login.IconMarginLeft = 11
        Me.BB_Login.IconPadding = 10
        Me.BB_Login.IconRight = Nothing
        Me.BB_Login.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BB_Login.IconRightCursor = System.Windows.Forms.Cursors.Default
        Me.BB_Login.IconRightPadding = New System.Windows.Forms.Padding(3, 3, 7, 3)
        Me.BB_Login.IconSize = 25
        Me.BB_Login.IdleBorderColor = System.Drawing.Color.DodgerBlue
        Me.BB_Login.IdleBorderRadius = 30
        Me.BB_Login.IdleBorderThickness = 1
        Me.BB_Login.IdleFillColor = System.Drawing.Color.DodgerBlue
        Me.BB_Login.IdleIconLeftImage = Nothing
        Me.BB_Login.IdleIconRightImage = Nothing
        Me.BB_Login.IndicateFocus = False
        Me.BB_Login.Location = New System.Drawing.Point(2, 2)
        Me.BB_Login.Name = "BB_Login"
        Me.BB_Login.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.BB_Login.OnDisabledState.BorderRadius = 30
        Me.BB_Login.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BB_Login.OnDisabledState.BorderThickness = 1
        Me.BB_Login.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BB_Login.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.BB_Login.OnDisabledState.IconLeftImage = Nothing
        Me.BB_Login.OnDisabledState.IconRightImage = Nothing
        Me.BB_Login.onHoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BB_Login.onHoverState.BorderRadius = 30
        Me.BB_Login.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BB_Login.onHoverState.BorderThickness = 1
        Me.BB_Login.onHoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BB_Login.onHoverState.ForeColor = System.Drawing.Color.White
        Me.BB_Login.onHoverState.IconLeftImage = Nothing
        Me.BB_Login.onHoverState.IconRightImage = Nothing
        Me.BB_Login.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue
        Me.BB_Login.OnIdleState.BorderRadius = 30
        Me.BB_Login.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BB_Login.OnIdleState.BorderThickness = 1
        Me.BB_Login.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue
        Me.BB_Login.OnIdleState.ForeColor = System.Drawing.Color.White
        Me.BB_Login.OnIdleState.IconLeftImage = Nothing
        Me.BB_Login.OnIdleState.IconRightImage = Nothing
        Me.BB_Login.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BB_Login.OnPressedState.BorderRadius = 30
        Me.BB_Login.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.BB_Login.OnPressedState.BorderThickness = 1
        Me.BB_Login.OnPressedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        Me.BB_Login.OnPressedState.ForeColor = System.Drawing.Color.White
        Me.BB_Login.OnPressedState.IconLeftImage = Nothing
        Me.BB_Login.OnPressedState.IconRightImage = Nothing
        Me.BB_Login.Size = New System.Drawing.Size(147, 48)
        Me.BB_Login.TabIndex = 10
        Me.BB_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BB_Login.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.BB_Login.TextMarginLeft = 0
        Me.BB_Login.TextPadding = New System.Windows.Forms.Padding(0)
        Me.BB_Login.UseDefaultRadiusAndThickness = True
        '
        'Frm_LogIn
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Appearance.Options.UseBackColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(842, 986)
        Me.Controls.Add(Me.Label_ModuleVersion)
        Me.Controls.Add(Me.Ed_Password)
        Me.Controls.Add(Me.Ed_Username)
        Me.Controls.Add(Me.BunifuPictureBox1)
        Me.Controls.Add(Me.ComboBox_Config)
        Me.Controls.Add(Me.PopupControlContainer2)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_LogIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.ImageCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupControlContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PopupControlContainer2.ResumeLayout(False)
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_POS_LoginEntryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_Password.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_Username.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComboBox_Config.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_PrinterKitchen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GeneralPathTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_ACEServerAddress.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SourceTextEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpEdit_ACEDB.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_PrinterCashier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_PrinterMini.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_PrinterPantry.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_PrinterGrill.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_PrinterBar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ed_PrinterDokumen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem54, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem44, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DefaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
    Friend WithEvents DataSet As DataSet
    Friend WithEvents Sp_POS_LoginEntryBindingSource As BindingSource
    Friend WithEvents Sp_POS_LoginEntryTableAdapter As DataSetTableAdapters.sp_POS_LoginEntryTableAdapter
    Friend WithEvents TableAdapterManager As DataSetTableAdapters.TableAdapterManager
    Friend WithEvents ImageCollection1 As DevExpress.Utils.ImageCollection
    Friend WithEvents ComboBox_Config As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents PopupControlContainer2 As DevExpress.XtraBars.PopupControlContainer
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Ed_PrinterKitchen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GeneralPathTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Ed_ACEServerAddress As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SourceTextEdit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LookUpEdit_ACEDB As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Ed_PrinterCashier As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Ed_PrinterMini As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Ed_PrinterPantry As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Ed_PrinterGrill As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Ed_PrinterBar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Ed_PrinterDokumen As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents SimpleSeparator1 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem20 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem54 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem25 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem22 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem34 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem44 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BB_Setting As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BB_Login As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents BunifuPictureBox1 As Bunifu.UI.WinForms.BunifuPictureBox
    Friend WithEvents Ed_Username As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Ed_Password As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label_ModuleVersion As DevExpress.XtraEditors.LabelControl

#End Region

End Class
