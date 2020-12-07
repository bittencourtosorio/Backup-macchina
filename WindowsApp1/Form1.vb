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
        DateTimePicker1.Format = DateTimePickerFormat.Short
        DateTimePicker1.Value.ToString("dd-mm-yyyy")

        'Get machine number from the registry or from PC name
        Dim readValue = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Microsoft\Microsoft SQL Server\100\Machines", "OriginalMachineName", Nothing)
        If readValue = Nothing Then Label2.Text = System.Windows.Forms.SystemInformation.ComputerName Else Label2.Text = readValue
        ComboBox1.Items.AddRange(System.IO.Directory.GetLogicalDrives)
    End Sub

    'Selection to use the revealed machine number
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = Label2.Text
        TextBox1.Enabled = False
    End Sub

    'Selection to type the machine number
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox1.Enabled = True
        TextBox1.Text = GlobalVariables.drive
    End Sub

    'Finishes the Form1 and loads the input data to Global Variables
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        GlobalVariables.data = DateTimePicker1.Value.ToString("dd-mm-yyyy")
        GlobalVariables.razao = RichTextBox1.Text
        GlobalVariables.particao = ComboBox1.SelectedItem
        GlobalVariables.tecnico = TextBox2.Text
        GlobalVariables.maquina = TextBox1.Text

        'Decision to use Selected folder or standard partition
        If ComboBox1.Enabled = True Then
            GlobalVariables.particao = ComboBox1.Text
        Else
            GlobalVariables.endereco = True
        End If
        Me.Hide()
        Form2.Show()


    End Sub

    'Refreshes the Drives conected to the machine
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ComboBox1.Items.Clear()
        ComboBox1.Items.AddRange(System.IO.Directory.GetLogicalDrives)
    End Sub

    'Open folder selection box
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim folderdialog As New FolderBrowserDialog
        folderdialog.ShowNewFolderButton = True
        If (folderdialog.ShowDialog() = DialogResult.OK) Then
            TextBox3.Text = folderdialog.SelectedPath
            GlobalVariables.root = folderdialog.SelectedPath
        End If

    End Sub

    'Choose to enable standard partition location
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Label8.Enabled = True
        ComboBox1.Enabled = True
        Button4.Enabled = True
        Label9.Enabled = False
        TextBox3.Enabled = False
        Button5.Enabled = False

    End Sub

    'Choose to enable folder location 
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Label8.Enabled = False
        ComboBox1.Enabled = False
        Button4.Enabled = False
        Label9.Enabled = True
        TextBox3.Enabled = True
        Button5.Enabled = True
    End Sub
End Class