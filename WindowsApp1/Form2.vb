Imports System.ComponentModel
Imports System.Drawing.Text
Imports System.IO
Imports System.Linq.Expressions
Imports System.Reflection.Emit
Imports System.Runtime.InteropServices
Imports System.Security
Imports System.Security.Cryptography.X509Certificates
Imports Microsoft.VisualBasic.CompilerServices

Public Class Form2
    'Global Variables declaration
    Public Class GlobalVariables
        Public Shared pasta As String
        Public Shared pasta1 As String

    End Class
    Dim backup As String

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim timer1 As String
        Dim razao1 As String
        Dim maquina1 As String
        Dim tecnico1 As String
        Dim particao1 As String

        razao1 = Form1.GlobalVariables.razao
        maquina1 = Form1.GlobalVariables.maquina
        tecnico1 = Form1.GlobalVariables.tecnico
        timer1 = Form1.date_dtp.Value.ToString("dd-MM-yyyy")
        particao1 = Form1.GlobalVariables.particao
        GlobalVariables.pasta1 = "\"

        If Form1.GlobalVariables.endereco = True Then
            GlobalVariables.pasta = (Form1.GlobalVariables.root & "\")
        Else
            GlobalVariables.pasta = particao1
        End If

        backup = GlobalVariables.pasta & GlobalVariables.pasta1 & "Backup " & timer1
        Directory.CreateDirectory(backup)
        Directory.CreateDirectory(backup & GlobalVariables.pasta1 & "PC")
        Directory.CreateDirectory(backup & GlobalVariables.pasta1 & "CN")
        File.Create(backup & GlobalVariables.pasta1 & "README.txt").Dispose()

        'Creating README file
        Using writer As New StreamWriter(backup & GlobalVariables.pasta1 & "README.txt", True)
            writer.WriteLine(timer1)
            writer.WriteLine("")
            writer.WriteLine(maquina1)
            writer.WriteLine("")
            writer.WriteLine(tecnico1)
            writer.WriteLine("")
            writer.WriteLine(razao1)
            writer.WriteLine("")
        End Using

        Dim wwm = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\WALTER AG", "Build", Nothing)
        Dim wwm1 = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WALTER AG\License", "License", Nothing)

        If wwm <> "" Then
            Using writer As New StreamWriter(backup & GlobalVariables.pasta1 & "README.txt", True)
                writer.WriteLine("WWM Version")
                writer.WriteLine("")
                writer.WriteLine(wwm)
                writer.WriteLine("")
                writer.WriteLine("WWM License")
                writer.WriteLine("")
                writer.WriteLine(wwm1)
                writer.WriteLine("")
            End Using
        End If

        'Verifying the kind of OS (32 or 64 bits)
        If System.Environment.Is64BitOperatingSystem = True Then
            GoTo 64
        Else
            GoTo 32
        End If

        'Getting ToolStudio informations for 64 bits
64:
        Dim ts20 As New System.IO.DirectoryInfo("C:\Program Files (x86)\Walter\ToolStudio2.0")
        Dim ts21 As New System.IO.DirectoryInfo("C:\Program Files (x86)\Walter\ToolStudio2.1")
        Dim ts3 As New System.IO.DirectoryInfo("C:\Program Files (x86)\Walter\ToolStudio3")

        If ts20.Exists = True Then
            Dim licenca20 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Walter\ToolStudio 2.0\Common\Application", "License Key", Nothing)
            Dim versao20 = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Walter\ToolStudio 2.0", "version", Nothing)

            Using writer As New StreamWriter(backup & GlobalVariables.pasta1 & "README.txt", True)
                writer.WriteLine("ToolStudio Version:")
                writer.WriteLine(versao20)
                writer.WriteLine("")
                writer.WriteLine("ToolStudio License:")
                writer.WriteLine(licenca20)
                writer.WriteLine("")
            End Using

        ElseIf ts21.Exists = True Then
            Dim licenca21 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Walter\ToolStudio 2.1\Common\Application", "License Key", Nothing)
            Dim versao21 = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Walter\ToolStudio 2.1", "version", Nothing)

            Using writer As New StreamWriter(backup & GlobalVariables.pasta1 & "README.txt", True)
                writer.WriteLine("ToolStudio Version:")
                writer.WriteLine(versao21)
                writer.WriteLine("")
                writer.WriteLine("ToolStudio License:")
                writer.WriteLine(licenca21)
                writer.WriteLine("")
            End Using

        ElseIf ts3.Exists = True Then
            Dim licenca3 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Walter\ToolStudio 3\Common\Application", "License Key", Nothing)
            Dim versao3 = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Walter\ToolStudio 3", "version", Nothing)

            Using writer As New StreamWriter(backup & GlobalVariables.pasta1 & "README.txt", True)
                writer.WriteLine("ToolStudio Version:")
                writer.WriteLine(versao3)
                writer.WriteLine("")
                writer.WriteLine("ToolStudio License:")
                writer.WriteLine(licenca3)
                writer.WriteLine("")
            End Using
        End If

        'Getting ToolStudio informations for 32 bits
32:
        Dim ts220 As New System.IO.DirectoryInfo("C:\Programs\Walter\ToolStudio2.0")
        Dim ts221 As New System.IO.DirectoryInfo("C:\Programs\Walter\ToolStudio2.1")
        Dim ts23 As New System.IO.DirectoryInfo("C:\Programs\Walter\ToolStudio3")

        If ts220.Exists = True Then
            Dim licenca220 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Walter\ToolStudio 2.0\Common\Application", "License Key", Nothing)
            Dim versao220 = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Walter\ToolStudio 2.0", "version", Nothing)

            Using writer As New StreamWriter(backup & GlobalVariables.pasta1 & "README.txt", True)
                writer.WriteLine("ToolStudio Version:")
                writer.WriteLine(versao220)
                writer.WriteLine("")
                writer.WriteLine("ToolStudio License:")
                writer.WriteLine(licenca220)
                writer.WriteLine("")
            End Using

        ElseIf ts221.Exists = True Then
            Dim licenca221 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Walter\ToolStudio 2.1\Common\Application", "License Key", Nothing)
            Dim versao221 = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\WOW6432Node\Walter\ToolStudio 2.1", "version", Nothing)

            Using writer As New StreamWriter(backup & GlobalVariables.pasta1 & "README.txt", True)
                writer.WriteLine("ToolStudio Version:")
                writer.WriteLine(versao221)
                writer.WriteLine("")
                writer.WriteLine("ToolStudio License:")
                writer.WriteLine(licenca221)
                writer.WriteLine("")
            End Using

        ElseIf ts23.Exists = True Then
            Dim licenca23 = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Walter\ToolStudio 3\Common\Application", "License Key", Nothing)
            Dim versao23 = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Walter\ToolStudio 3", "version", Nothing)

            Using writer As New StreamWriter(backup & GlobalVariables.pasta1 & "README.txt", True)
                writer.WriteLine("ToolStudio Version:")
                writer.WriteLine(versao23)
                writer.WriteLine("")
                writer.WriteLine("ToolStudio License:")
                writer.WriteLine(licenca23)
                writer.WriteLine("")
            End Using
        End If

    End Sub

    'Verifying if it should close the software
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            Application.Exit()
        End If
    End Sub

    'Selection of kind of backup you want to do
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If RadioButton1.Checked = True Then
            GoTo Folders
        ElseIf RadioButton2.Checked = True Then
            GoTo WWM
        ElseIf RadioButton3.Checked = True Then
            GoTo ToolStudio
        ElseIf RadioButton4.Checked = True Then
            GoTo Hard
        ElseIf RadioButton5.Checked = True Then
            GoTo Complete
        ElseIf RadioButton6.Checked = True Then
            GoTo Schedule
        End If

        'Folders will be created anyway
Folders:
        MsgBox("Folders created", MsgBoxStyle.Exclamation)
        GoTo Fim

        'Backup of WWM folders and files
WWM:
        'Creation of WWM folders
        Directory.CreateDirectory(backup & GlobalVariables.pasta1 & "PC" & GlobalVariables.pasta1 & "DB")
        Directory.CreateDirectory(backup & GlobalVariables.pasta1 & "PC" & GlobalVariables.pasta1 & "Profil37")
        Directory.CreateDirectory(backup & GlobalVariables.pasta1 & "PC" & GlobalVariables.pasta1 & "Andron" & GlobalVariables.pasta1 & "P1" & GlobalVariables.pasta1 & "5")
        Directory.CreateDirectory(backup & GlobalVariables.pasta1 & "PC" & GlobalVariables.pasta1 & "Andron" & GlobalVariables.pasta1 & "P1" & GlobalVariables.pasta1 & "6")
        Directory.CreateDirectory(backup & GlobalVariables.pasta1 & "PC" & GlobalVariables.pasta1 & "Profil32")
        Directory.CreateDirectory(backup & GlobalVariables.pasta1 & "PC" & GlobalVariables.pasta1 & "Profil52")
        Directory.CreateDirectory(backup & GlobalVariables.pasta1 & "PC" & GlobalVariables.pasta1 & "Profil57")
        Directory.CreateDirectory(backup & GlobalVariables.pasta1 & "PC" & GlobalVariables.pasta1 & "Profil18")
        Directory.CreateDirectory(backup & GlobalVariables.pasta1 & "PC" & GlobalVariables.pasta1 & "Generator")

        'Backing up WWM files
        Dim para As String = "C:\PR004\NSNT\DB\para.mdb"
        Dim paralokal As String = "C:\PR004\NSNT\DB\para_lokal.mdb"
        Dim wheel As String = "C:\PR004\NSNT\DB\wheeldatabase.fdb"
        Dim wflex As String = "C:\PR004\NSNT\DB\WFLEXPROG.mdb"
        Dim flexprog As String = "C:\PR004\NSNT\DB\FLEXPROG.mdb"

        'Backing up WWM folders 
        Dim P18 As String
        Dim P181 As String
        Dim P37 As String
        Dim P371 As String
        Dim Generator As String
        Dim Generator1 As String
        Dim P275 As String
        Dim P2751 As String
        Dim P276 As String
        Dim P2761 As String
        Dim P32 As String
        Dim P321 As String
        Dim P52 As String
        Dim P521 As String
        Dim P57 As String
        Dim P571 As String

        ' Backup of all files in Generator directory
        Generator = "C:\PR004\NSNT\Generator"
        Generator1 = backup & GlobalVariables.pasta1 & "PC" & GlobalVariables.pasta1 & "Generator"
        My.Computer.FileSystem.CopyDirectory(Generator, Generator1, True)

        ' Backup of all files in Profil18 directory
        P18 = "C:\PR004\NSNT\Profil18"
        P181 = backup & GlobalVariables.pasta1 & "PC" & GlobalVariables.pasta1 & "Profil18"
        My.Computer.FileSystem.CopyDirectory(P18, P181, True)

        ' Backup of all ISO codes
        P275 = "C:\PR004\NSNT\Andron\P1\5"
        P276 = "C:\PR004\NSNT\Andron\P1\6"
        P2751 = backup & GlobalVariables.pasta1 & "PC" & GlobalVariables.pasta1 & "Andron" & GlobalVariables.pasta1 & "P1" & GlobalVariables.pasta1 & "5"
        P2761 = backup & GlobalVariables.pasta1 & "PC" & GlobalVariables.pasta1 & "Andron" & GlobalVariables.pasta1 & "P1" & GlobalVariables.pasta1 & "6"
        My.Computer.FileSystem.CopyDirectory(P275, P2751, True)
        My.Computer.FileSystem.CopyDirectory(P276, P2761, True)

        ' Backup of all files in Profil32 directory
        P32 = "C:\PR004\NSNT\Profil32"
        P321 = backup & GlobalVariables.pasta1 & "PC" & GlobalVariables.pasta1 & "Profil32"
        My.Computer.FileSystem.CopyDirectory(P32, P321, True)

        ' Backup of all files in Profil37 directory
        P37 = "C:\PR004\NSNT\Profil37"
        P371 = backup & GlobalVariables.pasta1 & "PC" & GlobalVariables.pasta1 & "Profil37"
        My.Computer.FileSystem.CopyDirectory(P37, P371, True)

        ' Backup of all files in Profil52 directory
        P52 = "C:\PR004\NSNT\Profil52"
        P521 = backup & GlobalVariables.pasta1 & "PC" & GlobalVariables.pasta1 & "Profil52"
        My.Computer.FileSystem.CopyDirectory(P52, P521, True)

        ' Backup of all files in Profil57 directory
        P57 = "C:\PR004\NSNT\Profil57"
        P571 = backup & GlobalVariables.pasta1 & "PC" & GlobalVariables.pasta1 & "Profil57"
        My.Computer.FileSystem.CopyDirectory(P57, P571, True)

        MsgBox("WWM Backup completed", MsgBoxStyle.Exclamation)
        GoTo Fim

ToolStudio:


Hard:


Complete:


Schedule:


Fim:
    End Sub


End Class