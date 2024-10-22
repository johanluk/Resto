Imports DevExpress.XtraBars.Ribbon
Imports System.Xml
Imports GEncrypted
Imports System.IO

Public Class Frm_User


    Public WithEvents newEdit As DevExpress.XtraEditors.TextEdit


#Region "ApplicationConfig"
    Private strServerPOS As String
    Private strServerCP As String
    Private strPOSDB As String
    Private strCPDB As String
#End Region

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

    Public Sub isiConfig()
        'serverAddressTextEdit.EditValue = strServerAHRS
        'GSLServerAddressTextEdit.EditValue = strServerASPS
        'GTMSServerAddressTextEdit.EditValue = strServerAIPS
        'GACCServerAddressTextEdit.EditValue = strServerACS
        'GIIServerAddressTextEdit.EditValue = strServerACE

        'HRDatabaseLookupEdit.EditValue = strAHRSDB
        'GSLDatabaseLookUpEdit.EditValue = strASPSDB
        'GTMSDatabaseLookUpEdit.EditValue = strAIPSDB
        'GACCDatabaseLookUpEdit.EditValue = strACSDB
        'GIIDatabaseLookUpEdit.EditValue = strACEDB

        'SourceTextEdit.EditValue = strSource
        'WarehouseTextEdit.EditValue = strWarehouse
        'CropYearTextEdit.EditValue = strCropYear
        'GeneralPathTextEdit.EditValue = strAppPath
    End Sub

    Sub LoadIsiConfig()
        '   LoadConfigList()
        '       ConfigFileBarEditItem.EditValue = My.Settings.ConfigFile

        '   Me.Location = New System.Drawing.Point((System.Windows.Width / 2) - (Me.Width / 2), RibbonControl1.Height)
        isiSetting("ConnectionString", True, String.Format("Data Source={0};Initial Catalog={1};User ID=sa;Password=adm1n", "SERVER-PC", "AHR_Panglima"))
        isiSetting("CPCS", True, String.Format("Data Source={0};Initial Catalog={1};User ID=sa;Password=adm1n", "SERVER-PC", "AHR_Panglima"))

        'isiSetting("Source", False, "Genesys")
        'isiSetting("Warehouse", False, "Genesys")
        'isiSetting("Year", False, Now.Year)
        isiSetting("GeneralPath", False, "D:\Server")

        isiSetting("PrinterDocument", False)
        isiSetting("PrinterLX", False)
        isiSetting("PrinterCashier", False)
        isiSetting("PrinterPantry", False)
        isiSetting("PrinterBar", False)
        isiSetting("PrinterKitchen", False)
        'isiSetting("ScaleType", False)
        'isiSetting("Company", False, "Company Name")
        'isiSetting("Type", False, "-")
        'isiSetting("Subtype", False, "-")
        'isiSetting("ReportPath", False, "")
        'isiSetting("DocumentPath", False, "")
        'isiSetting("TemplatePath", False, "")

        Dim strConnectionString As New SqlClient.SqlConnection(My.Settings.ConnectionString)
        Dim strCPCS As New SqlClient.SqlConnection(My.Settings.CPCS)

        strServerPOS = strConnectionString.DataSource
        strServerCP = strCPCS.DataSource

        strPOSDB = strConnectionString.Database
        strCPDB = strCPCS.Database


        UpdateAppSettings("ConnectionString", My.Settings.ConnectionString)
        UpdateAppSettings("CPCS", My.Settings.CPCS)

        'ACSDB()

        UpdateAppSettings("GeneralPath", My.Settings.GeneralPath)

        UpdateAppSettings("PrinterDocument", My.Settings.PrinterDocument)
        UpdateAppSettings("PrinterLX", My.Settings.PrinterPantry)
        UpdateAppSettings("PrinterCashier", My.Settings.PrinterCashier1)
        UpdateAppSettings("PrinterPantry", My.Settings.PrinterGrill)
        UpdateAppSettings("PrinterBar", My.Settings.PrinterBar)
        UpdateAppSettings("PrinterKitchen", My.Settings.PrinterKitchen)

        '  VersionBarStaticItem.Caption = "Module Manager Version: " & Me.ProductVersion
        isiConfig()
    End Sub


    Private Sub Frm_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            PanelControl1.Visible = False

            PanelControl1.Left = (PanelControl2.Width - PanelControl1.Width) / 2
            '    LoadIsiConfig()
        Catch ex As Exception
            AlertControl1.Show(Me, "Login Problem", ex.Message)
        End Try
    End Sub


    Private Sub SB_Key_Click(sender As Object, e As EventArgs) Handles SB_01.Click, SB_09.Click, SB_08.Click, SB_07.Click, SB_06.Click, SB_05.Click, SB_04.Click, SB_03.Click, SB_02.Click, SB_00.Click
        newEdit.EditValue = newEdit.EditValue + sender.text
    End Sub

    Private Sub SB_BackSpace_Click(sender As Object, e As EventArgs) Handles SB_BackSpace.Click
        If (Len(newEdit.EditValue) > 0) Then
            newEdit.EditValue = newEdit.EditValue.ToString.Substring(0, Len(newEdit.EditValue) - 1)
        End If
    End Sub

    Private Sub SB_Next_Click(sender As Object, e As EventArgs) Handles SB_Next.Click
        Try

            If (newEdit.Name = Ed_UserName.Name) Then
                newEdit = Ed_Key
            Else

                Dim Status As Boolean
                Dim StatusAndEmployeeID As String
                Dim EmployeeName As String
                Dim Query As String

                StatusAndEmployeeID = Me.QueriesTableAdapter.sp_POS_MDEmployeeUser_GetSecurityPass(1, Ed_UserName.EditValue, Ed_Key.EditValue)
                My.Settings.EmployeeID = CInt(StatusAndEmployeeID.ToString.Substring(1, Len(StatusAndEmployeeID.ToString) - 1))

                My.Settings.PositionID = StatusAndEmployeeID.ToString.Substring(0, 1)
                Query = "Select EmployeeName from M_Employee where ID = " + CInt(StatusAndEmployeeID.ToString.Substring(1, Len(StatusAndEmployeeID.ToString) - 1)).ToString

                'If (My.Settings.PositionID = "2" Or My.Settings.PositionID = "3" Or My.Settings.PositionID = "4" Or My.Settings.PositionID = "5" Or My.Settings.PositionID = "6") Then
                '    EmployeeName = Me.QueriesTableAdapter.sp_DynamicQuery_GetData(0, "", "", "", Query)

                '    My.Settings.UserName = EmployeeName
                '    Dim FrmCashier As New DevExpress.XtraEditors.XtraForm
                '    FrmCashier = New Frm_OrderCashier(My.Settings.EmployeeID, EmployeeName)
                '    If (FrmCashier.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then

                '    End If


                'ElseIf (My.Settings.PositionID = "1") Then
                '    EmployeeName = Me.QueriesTableAdapter.sp_DynamicQuery_GetData(0, "", "", "", Query)
                '    My.Settings.UserName = EmployeeName
                '    Dim FrmCashier As New DevExpress.XtraEditors.XtraForm
                '    FrmCashier = New Frm_OrderWaitress(My.Settings.EmployeeID, EmployeeName)
                '    FrmCashier.ShowDialog()


                'Else
                '    MessageBox.Show("Error")
                'End If

            End If


        Catch ex As Exception
            AlertControl1.Show(Me, "Login Problem", ex.Message)
        End Try
    End Sub

    Private Sub TileNavCategory_Password_ElementClick(sender As Object, e As DevExpress.XtraBars.Navigation.NavElementEventArgs)
        'PanelControl1.Visible = True
        FlyoutPanel1.ShowPopup()
        Ed_UserName.Focus()
        newEdit = Ed_UserName
    End Sub

    Private Sub Ed_Key_Click(sender As Object, e As EventArgs) Handles Ed_Key.Click, Ed_UserName.Click
        newEdit = sender
    End Sub

    Private Sub NavButton_Close_ElementClick(sender As Object, e As DevExpress.XtraBars.Navigation.NavElementEventArgs) Handles NavButton_Close.ElementClick
        Application.Exit()
    End Sub

    Private Sub Frm_User_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Ed_UserName.EditValue = ""
        Ed_UserName.Focus()
        newEdit = Ed_UserName

        Ed_Key.EditValue = ""
    End Sub

    Private Sub NavButton_Setting_ElementClick(sender As Object, e As DevExpress.XtraBars.Navigation.NavElementEventArgs) Handles NavButton_Setting.ElementClick
        ChangeSetting()
    End Sub

    Public Sub ChangeSetting()
        Dim a As New Frm_ChangeSetting()
        a.ShowDialog()
    End Sub

    Private Sub FlyoutPanel1_ButtonClick(sender As Object, e As DevExpress.Utils.FlyoutPanelButtonClickEventArgs) Handles FlyoutPanel1.ButtonClick
        Me.FlyoutPanel1.HidePopup()
    End Sub

    Private Sub HyperlinkLabelControl_Update_Click(sender As Object, e As EventArgs) Handles HyperlinkLabelControl_Update.Click
        '      My.Settings.GeneralPath = "E:\New"
        MessageBox.Show("""" & Application.StartupPath & "\GCopyConsole.exe"" """ & My.Settings.GeneralPath & """ """ & Application.StartupPath & """ " & """*"" ""1""")
        'System.Diagnostics.Process.Start("GCopyConsole.exe", My.Settings.GeneralPath & " " & Application.StartupPath & " " & "*" & " " & "1")
        Shell("""" & Application.StartupPath & "\GCopyConsole.exe"" """ & My.Settings.GeneralPath & """ """ & Application.StartupPath & """ " & """*"" ""1""", AppWinStyle.Hide)

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
                '    My.Settings.ApplicationPath = "E:\New"
                MessageBox.Show("""" & Application.StartupPath & "\GCopyConsole.exe"" """ & My.Settings.GeneralPath & """ """ & Application.StartupPath & """ " & """*"" ""1""")
                'System.Diagnostics.Process.Start("GCopyConsole.exe", My.Settings.GeneralPath & " " & Application.StartupPath & " " & "*" & " " & "1")
                Shell("""" & Application.StartupPath & "\GCopyConsole.exe"" """ & My.Settings.GeneralPath & """ """ & Application.StartupPath & """ " & """*"" ""1""", AppWinStyle.Hide)
            End If

        End If
    End Sub
End Class