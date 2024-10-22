Imports System.ComponentModel
Imports System.IO
Imports System.Text
Imports System.Xml
Imports DevExpress.XtraBars.Ribbon
Imports GEncrypted

Partial Public Class Frm_LogIn

    Dim dtLogin As DataTable


#Region "ApplicationConfig"
    Private strServerACE As String
    Private strACEDB As String
    Private strAppPath As String
    Private strSource As String
    Private strPrinterDocument As String
    Private strPrinterMini As String
    Private strPrinterCashier As String
    Private strPrinterKitchen As String
    Private strPrinterPantry As String
    Private strPrinterGrill As String
    Private strPrinterBar As String
#End Region


    Public Sub New()
        InitializeComponent()

        DevExpress.Skins.SkinManager.EnableFormSkins()

        dtLogin = Me.DataSet.sp_POS_LoginEntry

    End Sub

    Private Sub WindowsUIButtonPanel2_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs)


    End Sub


    Private Sub WindowsUIButtonKey4_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs)
        'If (e.Button.Properties.Caption = "back") Then
        '    If (Ed_Password.Focused) Then
        '        Ed_UserName.Focus()
        '    End If
        'ElseIf (e.Button.Properties.Caption = "x" And Len(Ed_Password.EditValue) <> 0) Then
        '    If (Ed_UserName.Focused) Then
        '        Ed_UserName.EditValue = (Ed_UserName.EditValue.ToString.Remove(Len(Ed_UserName.EditValue) - 1, 1))
        '    Else
        '        Ed_Password.EditValue = (Ed_Password.EditValue.ToString.Remove(Len(Ed_Password.EditValue) - 1, 1))
        '    End If

        'Else
        '    If (e.Button.Properties.Caption <> "x" And Len(Ed_Password.EditValue) < 4) Then
        '        If (Ed_UserName.Focused) Then
        '            Ed_UserName.EditValue = Ed_UserName.EditValue + e.Button.Properties.Caption
        '        Else

        '            Ed_Password.EditValue = Ed_Password.EditValue + e.Button.Properties.Caption
        '        End If
        '    End If
        'End If
    End Sub

    Private Sub SB_UpdateTable_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Frm_LogIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ed_Username.Focus()
        Try

            Dim Process As New Process
            Dim app As New Process
            Dim consoleopen As Boolean = False
            For Each Process In Process.GetProcesses(My.Computer.Name)
                If Process.ProcessName = "GCopyConsole" Then
                    'Process.Kill() 'for example, close file
                    consoleopen = True
                End If
            Next

            If consoleopen = False Then
                If Directory.Exists(My.Settings.GeneralPath) Then
                    'System.Diagnostics.Process.Start("GCopyConsole.exe", My.Settings.GeneralPath & " " & Application.StartupPath & " " & "*" & " " & "1")
                    Shell("GCopyConsole.exe """ & My.Settings.GeneralPath & """ """ & Application.StartupPath & """ " & "*" & " " & "1", AppWinStyle.Hide)
                End If

            End If
            LoadIsiConfig()

            'SB_LogOut.Enabled = False
            'SB_ChangePassword.Enabled = False
            'BSI_IPAddress.Caption = GetIPv4Address()

        Catch ex As Exception

        End Try

        ''Ini Load Form Login
        'LoadLogin()

        'Note: Ini ngatur Status login apa logout
        'InitLoad(False)

        'Ini Untuk Atur Border
        'For Each ctl As Control In Me.Controls
        '    If TypeOf ctl Is MdiClient Then
        '        Dim exstyle As Integer = GetWindowLong(ctl.Handle, GWL_EXSTYLE)
        '        exstyle = exstyle And Not WS_EX_CLIENTEDGE
        '        SetWindowLong(ctl.Handle, GWL_EXSTYLE, exstyle)
        '        Exit For
        '    End If
        'Next



        '     Load_Button_Favorite()
    End Sub

    Private Sub WindowsUIButtonPanel_ButtonClick(sender As Object, e As DevExpress.XtraBars.Docking2010.ButtonEventArgs)
        If (e.Button.Properties.Tag = 1) Then
            ChangeSetting()
        ElseIf (e.Button.Properties.Tag = 0) Then
            Me.Dispose()
            Me.Close()
        End If
    End Sub

    Public Sub ChangeSetting()
        Dim a As RibbonForm
        a = New Frm_ChangeSetting()
        a.ShowDialog()
    End Sub

    Public Sub InitLoad(ByVal stat As Boolean)

        ComboBox_Config.ReadOnly = stat
    End Sub

    Public Sub isiConfig()

        Ed_ACEServerAddress.EditValue = strServerACE
        LookUpEdit_ACEDB.EditValue = strACEDB

        SourceTextEdit.EditValue = strSource
        GeneralPathTextEdit.EditValue = strAppPath

        Ed_PrinterDokumen.EditValue = strPrinterDocument
        Ed_PrinterMini.EditValue = strPrinterMini
        Ed_PrinterCashier.EditValue = strPrinterCashier
        Ed_PrinterPantry.EditValue = strPrinterPantry
        Ed_PrinterKitchen.EditValue = strPrinterKitchen
        Ed_PrinterGrill.EditValue = strPrinterGrill
        Ed_PrinterBar.EditValue = strPrinterBar
    End Sub

    Private Sub ComboBox_Config_EditValueChanged(sender As Object, e As EventArgs) Handles ComboBox_Config.EditValueChanged
        Try
            Dim filename As String = Application.StartupPath & "\" & ComboBox_Config.EditValue.ToString
            UpdateAppSettings("ConfigFile", System.IO.Path.GetFileName(filename))
            My.Settings.Item("ConfigFile") = System.IO.Path.GetFileName(filename)
            ComboBox_Config.EditValue = My.Settings.ConfigFile
            LoadIsiConfig()
        Catch Ex As Exception
            MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
        Finally
            ' Check this again, since we need to make sure we didn't throw an exception on open. 

        End Try
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
                            ' DecryptData throws if the wrong password is used. 
                            Try
                                If enkrip = True Then
                                    plainText = wrapper.DecryptData(cipherText)
                                Else
                                    plainText = cipherText
                                End If

                                My.Settings.Item(element) = plainText
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

    Sub LoadConfigList()
        ' make a reference to a directory
        Dim di As New IO.DirectoryInfo(Application.StartupPath)
        Dim diar1 As IO.FileInfo() = di.GetFiles()
        Dim dra As IO.FileInfo

        'list the names of all files in the specified directory
        ComboBox_Config.Properties.Items.Clear()
        For Each dra In diar1
            If dra.Extension = ".conf" Then
                ComboBox_Config.Properties.Items.Add(dra)
            End If

        Next
        ComboBox_Config.Properties.Items.Clear()
        For Each dra In diar1
            If dra.Extension = ".conf" Then
                ComboBox_Config.Properties.Items.Add(dra)
            End If

        Next
    End Sub

    Sub LoadIsiConfig()
        LoadConfigList()
        ComboBox_Config.EditValue = My.Settings.ConfigFile

        isiSetting("ConnectionString", True, String.Format("Data Source={0};Initial Catalog={1};User ID=user;Password=pass", "(local)", "db"))
        isiSetting("Company", False, "Resto Keboen Rodjo")

        isiSetting("Source", False, "-")

        isiSetting("GeneralPath", False, "D:\Server")
        isiSetting("PrinterDocument", False)
        isiSetting("PrinterMini", False)
        isiSetting("PrinterCashier", False)
        isiSetting("PrinterPantry", False)
        isiSetting("PrinterKitchen", False)
        isiSetting("PrinterGrill", False)
        isiSetting("PrinterBar", False)

        isiSetting("DocumentPath", False)

        Dim strACECS As New SqlClient.SqlConnection(My.Settings.ConnectionString)
        strServerACE = strACECS.DataSource
        strACEDB = strACECS.Database
        strSource = My.Settings.Source
        strAppPath = My.Settings.GeneralPath
        strPrinterDocument = My.Settings.PrinterDocument
        strPrinterMini = My.Settings.PrinterMini
        strPrinterCashier = My.Settings.PrinterCashier
        strPrinterKitchen = My.Settings.PrinterKitchen
        strPrinterPantry = My.Settings.PrinterPantry
        strPrinterGrill = My.Settings.PrinterGrill
        strPrinterBar = My.Settings.PrinterBar

        UpdateAppSettings("ConnectionString", My.Settings.ConnectionString)
        'UpdateAppSettings("ACECS", My.Settings.ACECS)
        'ACSDB()

        UpdateAppSettings("PrinterDocument", My.Settings.PrinterDocument)
        UpdateAppSettings("PrinterMini", My.Settings.PrinterMini)
        UpdateAppSettings("PrinterCashier", My.Settings.PrinterCashier)
        UpdateAppSettings("PrinterPantry", My.Settings.PrinterPantry)
        UpdateAppSettings("PrinterGrill", My.Settings.PrinterGrill)
        UpdateAppSettings("PrinterBar", My.Settings.PrinterBar)
        UpdateAppSettings("PrinterKitchen", My.Settings.PrinterKitchen)

        UpdateAppSettings("DocumentPath", My.Settings.DocumentPath)


        Label_ModuleVersion.Text = "V : " & Me.ProductVersion
        isiConfig()
    End Sub


    Public Shared Sub UpdateAppSettings(ByVal KeyName As String, ByVal KeyValue As String)
        '  AppDomain.CurrentDomain.SetupInformation.ConfigurationFile 
        ' This will get the app.config file path from Current application Domain
        Dim XmlDoc As New XmlDocument()
        ' Load XML Document
        'XmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile)
        XmlDoc.Load("POS.exe.config")
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
        XmlDoc.Save("POS.exe.config")
        FileClose()
    End Sub

    Private Sub Ed_Password_TextChanged(sender As Object, e As EventArgs)
        Dim FormOrder As Form

        If (Len(Ed_Password.Text) = 4) Then
            Try
                Me.Sp_POS_LoginEntryTableAdapter.Fill(Me.DataSet.sp_POS_LoginEntry, Ed_Username.Text, Ed_Password.Text)
                If (dtLogin.Rows.Count = 0) Then
                    MessageBox.Show("Password salah")
                Else
                    My.Settings.EmployeeID = CInt(dtLogin(0)(0))
                    My.Settings.EmployeeName = dtLogin(0)(1).ToString
                    My.Settings.PositionID = CInt(dtLogin(0)(2))
                    My.Settings.UserName = CInt(dtLogin(0)(3))

                    FormOrder = New Frm_Order(My.Settings.EmployeeID, My.Settings.EmployeeName)


                    FormOrder.ShowDialog()
                End If
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try


        End If
    End Sub

    Private Sub BB_Setting_Click(sender As Object, e As EventArgs) Handles BB_Setting.Click
        ChangeSetting()
    End Sub

    Private Sub BB_Login_Click(sender As Object, e As EventArgs) Handles BB_Login.Click
        Dim FormOrder As Form
        If (Len(Ed_Password.Text) = 4) Then
            Try
                Me.Sp_POS_LoginEntryTableAdapter.Fill(Me.DataSet.sp_POS_LoginEntry, Ed_Username.Text, Ed_Password.Text)
                If (dtLogin.Rows.Count = 0) Then
                    MessageBox.Show("Password salah")
                Else
                    My.Settings.EmployeeID = CInt(dtLogin(0)(0))
                    My.Settings.EmployeeName = dtLogin(0)(1).ToString
                    My.Settings.PositionID = CInt(dtLogin(0)(2))
                    My.Settings.UserName = CInt(dtLogin(0)(3))

                    FormOrder = New Frm_Order(My.Settings.EmployeeID, My.Settings.EmployeeName)


                    FormOrder.ShowDialog()
                End If
            Catch ex As System.Exception
                System.Windows.Forms.MessageBox.Show(ex.Message)
            End Try


        End If
    End Sub
End Class
