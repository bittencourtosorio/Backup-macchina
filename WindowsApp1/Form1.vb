Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Public Class Form1
    'Global Variables declaration
    Public Class GlobalVariables

        Public Shared maquina As String
        Public Shared tecnico As String
        Public Shared particao As String
        Public Shared razao As String
        Public Shared data As String
        Public Shared drive As String
        Public Shared endereco As Boolean
        Public Shared root As String

    End Class

    'Program introduction. First message box
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If MsgBox("Please execute the program with administrator rights", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
            Application.Exit()
        End If

        'Determinate date
        date_dtp.Format = DateTimePickerFormat.Short
        date_dtp.Value.ToString("dd-mm-yyyy")

        'Get machine number from the registry or from PC name
        Dim readValue = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Microsoft\Microsoft SQL Server\100\Machines", "OriginalMachineName", Nothing)
        If readValue = Nothing Then Label2.Text = System.Windows.Forms.SystemInformation.ComputerName Else Label2.Text = readValue
        partition_cb.Items.AddRange(System.IO.Directory.GetLogicalDrives)

    End Sub

    'Selection to use the revealed machine number
    Private Sub Yes_btn_Click(sender As Object, e As EventArgs) Handles yes_btn.Click
        macnum_txt.Text = Label2.Text
        macnum_txt.Enabled = False
    End Sub

    'Selection to type the machine number
    Private Sub No_btn_Click(sender As Object, e As EventArgs) Handles no_btn.Click
        macnum_txt.Text = ""
        macnum_txt.Enabled = True
        macnum_txt.Text = GlobalVariables.drive
    End Sub

    'Finishes the Form1 and loads the input data to Global Variables
    Private Sub Proceed_btn_Click(sender As Object, e As EventArgs) Handles Proceed_btn.Click
        Dim selection As Integer
        Dim reason As Integer
        Dim tec As Integer
        Dim num As Integer
        GlobalVariables.data = date_dtp.Value.ToString("dd-mm-yyyy")
        GlobalVariables.razao = reason_rtb.Text
        GlobalVariables.particao = partition_cb.SelectedItem
        GlobalVariables.tecnico = technician_txt.Text
        GlobalVariables.maquina = macnum_txt.Text

        'Decision to use Selected folder or standard partition
        If partition_cb.Enabled = True Then
            GlobalVariables.particao = partition_cb.Text
        Else
            GlobalVariables.endereco = True
        End If

        selection = 0
        If partition_cb.Text <> "" Then
            selection = 1
        ElseIf location_txt.Text <> "" Then
            selection = 1
        End If

        If macnum_txt.Text = "" Then
            MsgBox("Please select machine number", MsgBoxStyle.Exclamation)
        Else
            num = 1
        End If

        If technician_txt.Text = "" Then
            MsgBox("Please enter your name", MsgBoxStyle.Exclamation)
        Else
            tec = 1
        End If

        If reason_rtb.Text = "" Then
            MsgBox("Please select backup reason", MsgBoxStyle.Exclamation)
        Else
            reason = 1
        End If

        If selection = 0 Then
            MsgBox("Please select location to save backup", MsgBoxStyle.Exclamation)
        ElseIf num = 1 And tec = 1 And reason = 1 Then
            Me.Hide()
            Form2.Show()
        Else
            MsgBox("Some crutial data is missing. Please check it!", MsgBoxStyle.Exclamation)
        End If


    End Sub

    'Refreshes the Drives conected to the machine
    Private Sub Refresh_btn_Click(sender As Object, e As EventArgs) Handles refresh_btn.Click
        partition_cb.Items.Clear()
        partition_cb.Items.AddRange(System.IO.Directory.GetLogicalDrives)
    End Sub

    'Open folder selection box
    Private Sub Folder_btn_Click(sender As Object, e As EventArgs) Handles folder_btn.Click
        Dim folderdialog As New FolderBrowserDialog
        folderdialog.ShowNewFolderButton = True
        If (folderdialog.ShowDialog() = DialogResult.OK) Then
            location_txt.Text = folderdialog.SelectedPath
            GlobalVariables.root = folderdialog.SelectedPath
        End If

    End Sub

    'Choose to enable standard partition location
    Private Sub Partition_btn_Click(sender As Object, e As EventArgs) Handles partition_btn.Click
        partition_lbl.Enabled = True
        partition_cb.Enabled = True
        refresh_btn.Enabled = True
        browse_lbl.Enabled = False
        location_txt.Enabled = False
        folder_btn.Enabled = False

    End Sub

    'Choose to enable folder location 
    Private Sub Browse_btn_Click(sender As Object, e As EventArgs) Handles browse_btn.Click
        partition_lbl.Enabled = False
        partition_cb.Enabled = False
        refresh_btn.Enabled = False
        browse_lbl.Enabled = True
        location_txt.Enabled = True
        folder_btn.Enabled = True
    End Sub


End Class