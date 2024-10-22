Imports System.Xml
Imports SQLConnectionTest
Imports System.Drawing.Printing
Imports GEncrypted

Public Class Frm_ChangeSetting


    Private parentFormName As Object
    Private RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Private RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar

    Public Sub New(ByVal Parent As DevExpress.XtraBars.Ribbon.RibbonForm, ByVal RibbonControl As DevExpress.XtraBars.Ribbon.RibbonControl, ByVal RibbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar)
        InitializeComponent()
        parentFormName = Parent
        RibbonControl1 = RibbonControl
        RibbonStatusBar1 = RibbonStatusBar
    End Sub

    Public Sub New()
        InitializeComponent()

    End Sub

    Public Sub isiSetting(ByVal element As String, Optional ByVal enkrip As Boolean = True, Optional ByVal defaultstr As String = "")
        Try
            If (IO.File.Exists(My.Settings.ConfigFile)) Then
                Dim document As XmlReader = New XmlTextReader(My.Settings.ConfigFile)
                While (document.Read())
                    Dim type = document.NodeType
                    If (type = XmlNodeType.Element) Then
                        If (document.Name = element) Then

                            Dim cipherText As String = document.ReadInnerXml.ToString()
                            Dim wrapper As New Simple3Des("conn123")
                            Dim plainText As String = ""
                            Dim plainBool As Boolean = False
                            ' DecryptData throws if the wrong password is used. 
                            Try
                                If enkrip = True Then
                                    plainText = wrapper.DecryptData(cipherText)
                                Else

                                    If (cipherText.ToString = "True" Or cipherText.ToString = "False") Then
                                        plainBool = CBool(cipherText)
                                        plainText = "bool"
                                    Else
                                        plainText = cipherText

                                    End If
                                End If
                                If (plainText = "bool") Then
                                    My.Settings.Item(element) = plainBool
                                Else
                                    My.Settings.Item(element) = plainText
                        End If
                            Catch ex As System.Security.Cryptography.CryptographicException
                                MsgBox("The data could not be decrypted with the password.")
                            End Try
                        End If
                    End If
                End While
            Else
                My.Settings.Item(element) = defaultstr
            End If
            FileClose()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function WriteSetting(ByVal FileName As String, ByVal element As String, ByVal isielement As String, Optional ByVal enkrip As Boolean = True)

        Dim wrapper As New Simple3Des("conn123")
        Dim cipherText As String
        If enkrip = True Then
            cipherText = wrapper.EncryptData(isielement)
        Else
            cipherText = isielement
        End If
        If IO.File.Exists(FileName) = False Then
            Dim settings As New XmlWriterSettings()
            Dim XmlWrt As XmlWriter = XmlWriter.Create(FileName, settings)
            With XmlWrt
                .WriteStartDocument()
                .WriteStartElement("Data")
                .WriteStartElement(element)

                .WriteString(cipherText)
                .WriteEndElement()
                .WriteEndElement()
                .WriteEndDocument()
                .Close()
            End With
        Else
            Dim TestXML As New XmlDocument
            TestXML.Load(FileName)
            Dim TestXMLNode As XmlNode = TestXML.SelectSingleNode("/Data/" & element)

            If TestXMLNode IsNot Nothing Then
                If TestXMLNode.ChildNodes(0) IsNot Nothing Then
                    TestXMLNode.ChildNodes(0).InnerText = cipherText
                Else
                    TestXMLNode.InnerText = cipherText
                End If
            Else
                Dim elem As XmlNode = TestXML.CreateNode(XmlNodeType.Element, element, Nothing)
                elem.InnerText = cipherText
                TestXML.DocumentElement.AppendChild(elem)

            End If ' Save the Xml.

            TestXML.Save(FileName)

            FileClose()
        End If
        Return cipherText
    End Function

    Function vstr(ByVal str As Object)
        Dim strresult As String
        strresult = IIf(IsNothing(str) = True, "", str)
        Return strresult
    End Function

    Sub GetSerialPortNames()
        ' Show all available COM ports. 
        For Each sp As String In My.Computer.Ports.SerialPortNames
            'ListBox1.Items.Add(sp)
            '      CommPortTextEdit.Properties.Items.Add(sp)
        Next
    End Sub

    Private Sub PopulateInstalledPrintersCombo()
        ' Add list of installed printers found to the combo box. 
        ' The pkInstalledPrinters string will be used to provide the display string. 
        Dim i As Integer
        Dim pkInstalledPrinters As String

        For i = 0 To PrinterSettings.InstalledPrinters.Count - 1
            pkInstalledPrinters = PrinterSettings.InstalledPrinters.Item(i)
            ComboBoxEdit_PrinterGrill.Properties.Items.Add(pkInstalledPrinters)
            ComboBoxEdit_PrinterDocument.Properties.Items.Add(pkInstalledPrinters)
            ComboBoxEdit_PrinterMini.Properties.Items.Add(pkInstalledPrinters)
            ComboBoxEdit_PrinterCashier.Properties.Items.Add(pkInstalledPrinters)
            ComboBoxEdit_PrinterPantry.Properties.Items.Add(pkInstalledPrinters)
            ComboBoxEdit_PrinterBar.Properties.Items.Add(pkInstalledPrinters)
            ComboBoxEdit_PrinterKitchen.Properties.Items.Add(pkInstalledPrinters)
        Next
    End Sub

    Private Sub frmChangeSetting_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        '   Me.Location = New System.Drawing.Point((System.Windows.Width / 2) - (Me.Width / 2), RibbonControl1.Height)
        isiSetting("ConnectionString", True, String.Format("Data Source={0};Initial Catalog={1};User ID=;Password=", "(local)", ""))
        isiSetting("CPCS", True, String.Format("Data Source={0};Initial Catalog={1};User ID=;Password=", "(local)", ""))

        'isiSetting("Source", False, "Genesys")
        'isiSetting("Warehouse", False, "Genesys")
        'isiSetting("Year", False, Now.Year)
        'isiSetting("GeneralPath", False, "D:\Server")

        isiSetting("PrinterDocument", False)
        isiSetting("PrinterCashier", False)
        isiSetting("PrinterMini", False)
        isiSetting("PrinterPantry", False)
        isiSetting("PrinterBar", False)
        isiSetting("PrinterKitchen", False)
        isiSetting("PrinterGrill", False)
        isiSetting("AutoPrint", False)
        'isiSetting("ScaleType", False)
        'isiSetting("Company", False, "Company Name")
        'isiSetting("Type", False, "-")
        'isiSetting("Subtype", False, "-")
        'isiSetting("ReportPath", False, "")
        'isiSetting("DocumentPath", False, "")
        'isiSetting("TemplatePath", False, "")

        'isiSetting("Department", False, "")
        'isiSetting("Divisi", False, "")

        PopulateInstalledPrintersCombo()
        GetSerialPortNames()

        POSConnectionStringComboBoxEdit.Properties.Items.Add(My.Settings.ConnectionString)
        POSConnectionStringComboBoxEdit.EditValue = My.Settings.ConnectionString

        CPConnectionStringComboBoxEdit.Properties.Items.Add(My.Settings.CPCS)
        CPConnectionStringComboBoxEdit.EditValue = My.Settings.CPCS

        'SourceTextEdit.EditValue = My.Settings.Source
        'WarehouseTextEdit.EditValue = My.Settings.Warehouse
        'YearTextEdit.EditValue = My.Settings.Year
        'CompanyTextEdit.EditValue = My.Settings.Company
        'TypeTextEdit.EditValue = My.Settings.Type
        'SubtypeTextEdit.EditValue = My.Settings.Subtype

        ComboBoxEdit_PrinterDocument.EditValue = My.Settings.PrinterDocument
        ComboBoxEdit_PrinterMini.EditValue = My.Settings.PrinterGazebo
        ComboBoxEdit_PrinterPantry.EditValue = My.Settings.PrinterPantry
        ComboBoxEdit_PrinterCashier.EditValue = My.Settings.PrinterCashier1
        ComboBoxEdit_PrinterGrill.EditValue = My.Settings.PrinterGrill
        ComboBoxEdit_PrinterBar.EditValue = My.Settings.PrinterBar
        ComboBoxEdit_PrinterKitchen.EditValue = My.Settings.PrinterLX
        CE_AutoPrint.Checked = My.Settings.AutoPrint


        'ReportPathTextEdit.EditValue = My.Settings.ReportPath
        'DocumentPathTextEdit.EditValue = My.Settings.DocumentPath
        'TemplatePathTextEdit.EditValue = My.Settings.TemplatePath

        'DepartmentTextEdit.EditValue = My.Settings.Department
        'DivisiTextEdit.EditValue = My.Settings.Divisi
    End Sub

    Private Sub OKSimpleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKSimpleButton.Click
        Try


            'WriteSetting(My.Settings.ConfigFile, "HRCS", vstr(HRConnectionStringComboBoxEdit.EditValue))
            'WriteSetting(My.Settings.ConfigFile, "GTMSCS", vstr(GTMSConnectionStringComboBoxEdit.EditValue))
            'WriteSetting(My.Settings.ConfigFile, "GSLCS", vstr(GSLConnectionStringComboBoxEdit.EditValue))
            'WriteSetting(My.Settings.ConfigFile, "GACCCS", vstr(GACCConnectionStringComboBoxEdit.EditValue))
            'WriteSetting(My.Settings.ConfigFile, "GIIConnectionString", vstr(GIIConnectionStringComboBoxEdit.EditValue))
            'WriteSetting(My.Settings.ConfigFile, "Source", vstr(SourceTextEdit.EditValue), False)
            'WriteSetting(My.Settings.ConfigFile, "Warehouse", vstr(WarehouseTextEdit.EditValue), False)
            'WriteSetting(My.Settings.ConfigFile, "Year", vstr(YearTextEdit.EditValue), False)
            WriteSetting(My.Settings.ConfigFile, "GeneralPath", vstr(GeneralPathTextEdit.EditValue), False)
            WriteSetting(My.Settings.ConfigFile, "PrinterDocument", vstr(ComboBoxEdit_PrinterDocument.EditValue), False)
            WriteSetting(My.Settings.ConfigFile, "PrinterMini", vstr(ComboBoxEdit_PrinterMini.EditValue), False)
            WriteSetting(My.Settings.ConfigFile, "PrinterCashier", vstr(ComboBoxEdit_PrinterCashier.EditValue), False)
            WriteSetting(My.Settings.ConfigFile, "PrinterPantry", vstr(ComboBoxEdit_PrinterPantry.EditValue), False)
            WriteSetting(My.Settings.ConfigFile, "PrinterBar", vstr(ComboBoxEdit_PrinterBar.EditValue), False)
            WriteSetting(My.Settings.ConfigFile, "PrinterKitchen", vstr(ComboBoxEdit_PrinterKitchen.EditValue), False)
            WriteSetting(My.Settings.ConfigFile, "PrinterGrill", vstr(ComboBoxEdit_PrinterGrill.EditValue), False)
            WriteSetting(My.Settings.ConfigFile, "AutoPrint", CE_AutoPrint.Checked, False)



            'WriteSetting(My.Settings.ConfigFile, "Company", vstr(CompanyTextEdit.EditValue), False)
            'WriteSetting(My.Settings.ConfigFile, "Type", vstr(TypeTextEdit.EditValue), False)
            'WriteSetting(My.Settings.ConfigFile, "Subtype", vstr(SubtypeTextEdit.EditValue), False)
            'WriteSetting(My.Settings.ConfigFile, "ReportPath", vstr(ReportPathTextEdit.EditValue), False)
            'WriteSetting(My.Settings.ConfigFile, "DocumentPath", vstr(DocumentPathTextEdit.EditValue), False)
            'WriteSetting(My.Settings.ConfigFile, "TemplatePath", vstr(TemplatePathTextEdit.EditValue), False)
            'WriteSetting(My.Settings.ConfigFile, "Department", vstr(DepartmentTextEdit.EditValue), False)
            'WriteSetting(My.Settings.ConfigFile, "Divisi", vstr(DivisiTextEdit.EditValue), False)


            UpdateAppSettings("POSConnEnkrip", WriteSetting(My.Settings.ConfigFile, "ConnectionString", vstr(POSConnectionStringComboBoxEdit.EditValue)))
            UpdateAppSettings("CPConnEnkrip", WriteSetting(My.Settings.ConfigFile, "CPCS", vstr(CPConnectionStringComboBoxEdit.EditValue)))

            UpdateAppSettings("ConnectionString", My.Settings.ConnectionString)
            UpdateAppSettings("CPCS", My.Settings.CPCS)

            'UpdateAppSettings("ScaleType", My.Settings.ScaleType)
            'UpdateAppSettings("Company", My.Settings.Company)
            'UpdateAppSettings("Type", My.Settings.Type)
            'UpdateAppSettings("Subtype", My.Settings.Subtype)

            UpdateAppSettings("PrinterDocument", My.Settings.PrinterDocument)
            UpdateAppSettings("PrinterMini", My.Settings.PrinterGazebo)
            UpdateAppSettings("PrinterCashier", My.Settings.PrinterCashier1)
            UpdateAppSettings("PrinterPantry", My.Settings.PrinterPantry)
            UpdateAppSettings("PrinterBar", My.Settings.PrinterBar)
            UpdateAppSettings("PrinterKitchen", My.Settings.PrinterLX)
            UpdateAppSettings("PrinterGrill", My.Settings.PrinterGrill)
            UpdateAppSettings("AutoPrint", My.Settings.AutoPrint)
            'UpdateAppSettings("ScaleType", My.Settings.ScaleType)
            'UpdateAppSettings("ReportPath", My.Settings.ReportPath)
            'UpdateAppSettings("TemplatePath", My.Settings.TemplatePath)
            'UpdateAppSettings("DocumentPath", My.Settings.DocumentPath)

            'UpdateAppSettings("Department", My.Settings.DocumentPath)
            'UpdateAppSettings("Divisi", My.Settings.DocumentPath)

            DialogResult = System.Windows.Forms.DialogResult.OK
        Catch ex As Exception
            'DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub SaveAsSimpleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveAsSimpleButton.Click
        Try

            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.InitialDirectory = Application.StartupPath
            saveFileDialog1.Filter = "Configuration files (*.conf)|*.conf"
            saveFileDialog1.FilterIndex = 2
            saveFileDialog1.RestoreDirectory = True

            If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                WriteSetting(saveFileDialog1.FileName, "ConnectionString", vstr(POSConnectionStringComboBoxEdit.EditValue))
                WriteSetting(saveFileDialog1.FileName, "CPCS", vstr(CPConnectionStringComboBoxEdit.EditValue))
                'WriteSetting(saveFileDialog1.FileName, "Source", vstr(SourceTextEdit.EditValue), False)
                'WriteSetting(saveFileDialog1.FileName, "Warehouse", vstr(WarehouseTextEdit.EditValue), False)
                'WriteSetting(saveFileDialog1.FileName, "Year", vstr(YearTextEdit.EditValue), False)
                WriteSetting(saveFileDialog1.FileName, "GeneralPath", vstr(GeneralPathTextEdit.EditValue), False)
                WriteSetting(saveFileDialog1.FileName, "PrinterDocument", vstr(ComboBoxEdit_PrinterDocument.EditValue), False)
                WriteSetting(saveFileDialog1.FileName, "PrinterMini", vstr(ComboBoxEdit_PrinterMini.EditValue), False)
                WriteSetting(saveFileDialog1.FileName, "PrinterCashier", vstr(ComboBoxEdit_PrinterCashier.EditValue), False)
                WriteSetting(saveFileDialog1.FileName, "PrinterPantry", vstr(ComboBoxEdit_PrinterPantry.EditValue), False)
                WriteSetting(saveFileDialog1.FileName, "PrinterBar", vstr(ComboBoxEdit_PrinterBar.EditValue), False)
                WriteSetting(saveFileDialog1.FileName, "PrinterKitchen", vstr(ComboBoxEdit_PrinterKitchen.EditValue), False)
                WriteSetting(saveFileDialog1.FileName, "PrinterGrill", vstr(ComboBoxEdit_PrinterGrill.EditValue), False)
                WriteSetting(saveFileDialog1.FileName, "AutoPrint", vstr(CE_AutoPrint.Checked), False)
                'WriteSetting(saveFileDialog1.FileName, "ScaleType", vstr(ScaleTypeComboBoxEdit.EditValue), False)
                'WriteSetting(My.Settings.ConfigFile, "Company", vstr(CompanyTextEdit.EditValue), False)
                'WriteSetting(My.Settings.ConfigFile, "Type", vstr(TypeTextEdit.EditValue), False)
                'WriteSetting(My.Settings.ConfigFile, "Subtype", vstr(SubtypeTextEdit.EditValue), False)
                'WriteSetting(My.Settings.ConfigFile, "ReportPath", vstr(ReportPathTextEdit.EditValue), False)
                'WriteSetting(My.Settings.ConfigFile, "DocumentPath", vstr(DocumentPathTextEdit.EditValue), False)
                'WriteSetting(My.Settings.ConfigFile, "TemplatePath", vstr(TemplatePathTextEdit.EditValue), False)
                'WriteSetting(My.Settings.ConfigFile, "Department", vstr(TemplatePathTextEdit.EditValue), False)
                'WriteSetting(My.Settings.ConfigFile, "Divisi", vstr(TemplatePathTextEdit.EditValue), False)

                My.Settings.Item("ConfigFile") = System.IO.Path.GetFileName(saveFileDialog1.FileName)
                UpdateAppSettings("ConfigFile", System.IO.Path.GetFileName(saveFileDialog1.FileName))


                UpdateAppSettings("POSConnEnkrip", WriteSetting(My.Settings.ConfigFile, "ConnectionString", vstr(POSConnectionStringComboBoxEdit.EditValue)))
                UpdateAppSettings("CPConnEnkrip", WriteSetting(My.Settings.ConfigFile, "CPCS", vstr(CPConnectionStringComboBoxEdit.EditValue)))

                UpdateAppSettings("ConnectionString", My.Settings.ConnectionString)
                UpdateAppSettings("CPCS", My.Settings.CPCS)

                'UpdateAppSettings("ScaleType", My.Settings.ScaleType)
                'UpdateAppSettings("Company", My.Settings.Company)
                'UpdateAppSettings("Type", My.Settings.Type)
                'UpdateAppSettings("Subtype", My.Settings.Subtype)

                UpdateAppSettings("PrinterDocument", My.Settings.PrinterDocument)
                UpdateAppSettings("PrinterMini", My.Settings.PrinterGazebo)
                UpdateAppSettings("PrinterCashier", My.Settings.PrinterCashier1)
                UpdateAppSettings("PrinterPantry", My.Settings.PrinterGrill)
                UpdateAppSettings("PrinterBar", My.Settings.PrinterBar)
                UpdateAppSettings("PrinterKitchen", My.Settings.PrinterLX)
                UpdateAppSettings("PrinterGrill", My.Settings.PrinterGrill)
                UpdateAppSettings("AutoPrint", My.Settings.AutoPrint)
                'UpdateAppSettings("ScaleType", My.Settings.ScaleType)
                'UpdateAppSettings("ReportPath", My.Settings.ReportPath)
                'UpdateAppSettings("TemplatePath", My.Settings.TemplatePath)
                'UpdateAppSettings("DocumentPath", My.Settings.DocumentPath)

                'UpdateAppSettings("Department", My.Settings.Department)
                'UpdateAppSettings("Divisi", My.Settings.Divisi)
                DialogResult = System.Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            'DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Shared Sub UpdateAppSettings(ByVal KeyName As String, ByVal KeyValue As String)
        '  AppDomain.CurrentDomain.SetupInformation.ConfigurationFile 
        ' This will get the app.config file path from Current application Domain
        Dim XmlDoc As New XmlDocument()
        ' Load XML Document
        'XmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile)
        XmlDoc.Load("ModuleManager.exe.config")
        ' Navigate Each XML Element of app.Config file
        For Each xElement As XmlElement In XmlDoc.DocumentElement
            If xElement.Name = "userSettings" Then
                ' Loop each node of appSettings Element 
                ' xNode.Attributes(0).Value , Mean First Attributes of Node , 
                ' KeyName Portion
                ' xNode.Attributes(1).Value , Mean Second Attributes of Node,
                ' KeyValue Portion
                For Each xNode As XmlNode In xElement.ChildNodes

                    For Each xNode2 As XmlNode In xNode.ChildNodes
                        If xNode2.Attributes(0).Value = KeyName Then
                            For Each xNode3 As XmlNode In xNode2.ChildNodes
                                xNode3.InnerText = KeyValue
                            Next
                        End If
                    Next

                Next
            End If

        Next
        ' Save app.config file
        XmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile)
        XmlDoc.Save("ModuleManager.exe.config")
        FileClose()
    End Sub

    Private Sub GeneralPathTextEdit_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles GeneralPathTextEdit.ButtonClick
        If e.Button.Index = 0 Then
            Dim openFolderDialog1 As New FolderBrowserDialog()

            openFolderDialog1.SelectedPath = GeneralPathTextEdit.EditValue
            If openFolderDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Try
                    GeneralPathTextEdit.EditValue = openFolderDialog1.SelectedPath
                Catch Ex As Exception
                    MessageBox.Show("Cannot open folder from disk. Original error: " & Ex.Message)
                Finally
                    ' Check this again, since we need to make sure we didn't throw an exception on open. 
                End Try
            End If
        End If
    End Sub

    Private Sub ReportPathTextEdit_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles ReportPathTextEdit.ButtonClick
        If e.Button.Index = 0 Then
            Dim openFolderDialog1 As New FolderBrowserDialog()

            openFolderDialog1.SelectedPath = ReportPathTextEdit.EditValue
            If openFolderDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Try
                    ReportPathTextEdit.EditValue = openFolderDialog1.SelectedPath
                Catch Ex As Exception
                    MessageBox.Show("Cannot open folder from disk. Original error: " & Ex.Message)
                Finally
                    ' Check this again, since we need to make sure we didn't throw an exception on open. 

                End Try
            End If
        End If
    End Sub

    Private Sub DocumentPathTextEdit_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles DocumentPathTextEdit.ButtonClick
        If e.Button.Index = 0 Then
            Dim openFolderDialog1 As New FolderBrowserDialog()

            openFolderDialog1.SelectedPath = DocumentPathTextEdit.EditValue
            If openFolderDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Try
                    DocumentPathTextEdit.EditValue = openFolderDialog1.SelectedPath
                Catch Ex As Exception
                    MessageBox.Show("Cannot open folder from disk. Original error: " & Ex.Message)
                Finally
                    ' Check this again, since we need to make sure we didn't throw an exception on open. 

                End Try
            End If
        End If
    End Sub

    Private Sub TemplatePathTextEdit_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
        'If e.Button.Index = 0 Then
        '    Dim openFolderDialog1 As New FolderBrowserDialog()

        '    openFolderDialog1.SelectedPath = TemplatePathTextEdit.EditValue
        '    If openFolderDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
        '        Try
        '            TemplatePathTextEdit.EditValue = openFolderDialog1.SelectedPath
        '        Catch Ex As Exception
        '            MessageBox.Show("Cannot open folder from disk. Original error: " & Ex.Message)
        '        Finally
        '            ' Check this again, since we need to make sure we didn't throw an exception on open. 

        '        End Try
        '    End If
        'End If
    End Sub

    Private Sub POSConnectionStringComboBoxEdit_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles POSConnectionStringComboBoxEdit.ButtonClick
        If e.Button.Index = 1 Then
            Dim DLG As New SQL_Connection_Dialog


            DLG.ConnectionString = POSConnectionStringComboBoxEdit.EditValue
            DLG.Title = "SQL Connection"

            If DLG.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then Exit Sub

            Dim CS As String = DLG.ConnectionString

            ''Update the settings
            Dim count As Integer = 0
            For Each item As String In POSConnectionStringComboBoxEdit.Properties.Items
                If item = DLG.ConnectionString Then
                    count += 1
                End If
            Next
            If count = 0 Then

                POSConnectionStringComboBoxEdit.Properties.Items.Add(DLG.ConnectionString)
                POSConnectionStringComboBoxEdit.EditValue = DLG.ConnectionString
            End If

            'DLG.SaveChange_To_App_Config("HRConnectionString")
            'My.MySettings.Default.Item("HRConnectionString") = DLG.ConnectionString


        End If
    End Sub

    Private Sub CPConnectionStringComboBoxEdit_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles CPConnectionStringComboBoxEdit.ButtonClick
        If e.Button.Index = 1 Then
            Dim DLG As New SQL_Connection_Dialog


            DLG.ConnectionString = CPConnectionStringComboBoxEdit.EditValue
            DLG.Title = "SQL Connection"

            If DLG.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then Exit Sub

            Dim CS As String = DLG.ConnectionString

            ''Update the settings
            Dim count As Integer = 0
            For Each item As String In CPConnectionStringComboBoxEdit.Properties.Items
                If item = DLG.ConnectionString Then
                    count += 1
                End If
            Next
            If count = 0 Then

                CPConnectionStringComboBoxEdit.Properties.Items.Add(DLG.ConnectionString)
                CPConnectionStringComboBoxEdit.EditValue = DLG.ConnectionString
            End If

            'DLG.SaveChange_To_App_Config("AIPSConnectionString")
            'My.MySettings.Default.Item("AIPSConnectionString") = DLG.ConnectionString
        End If
    End Sub


End Class