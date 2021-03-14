Imports System.Data.SqlClient
Imports System.Data
Imports System


Public Class TSBackup

    Dim myCmd As SqlCommand
    Dim myReader As SqlDataReader
    Public Shared databaseNames As New List(Of String)

    '   Private Sub TSBackup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Public Shared Function GetDatabaseNames() As List(Of String)
        Dim myConn As String
        '  Dim results As String
        '  Dim databaseNames As New List(Of String)
        myConn = "Data Source=localhost\TOOLSTUDIO;user id=ToolStudioUser;password=ts;Trusted_Connection=True"

        If Not String.IsNullOrWhiteSpace(myConn) Then
            Using cn As SqlConnection = New SqlConnection(myConn)
                ' Open the connection
                cn.Open()

                Using cmd As SqlCommand = New SqlCommand()
                    cmd.Connection = cn
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.CommandText = "sp_databases"

                    Using myReader As SqlDataReader = cmd.ExecuteReader()
                        While (myReader.Read())
                            databaseNames.Add(myReader.GetString(0))
                        End While
                        '  DataTable databasesSchemaTable = myConn.GetSchema("Databases");

                    End Using
                End Using
            End Using
        End If
        Return databaseNames


    End Function
    Private Sub TSBackup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.DataSource = databaseNames

    End Sub

    '       Dim pcname As String
    '      pcname = Form1.GlobalVariables.readValue
    '     myConn = New SqlConnection("Data Source=localhost\TOOLSTUDIO;user id=ToolStudioUser;password=ts;Trusted_Connection=True")
    '    Try
    '   myConn.Open()
    '  MsgBox("Connection Open ! ")
    ' myConn.Close()
    'Catch ex As Exception
    'MsgBox("Can not open connection ! ")
    'End Try
    ' End Sub
End Class