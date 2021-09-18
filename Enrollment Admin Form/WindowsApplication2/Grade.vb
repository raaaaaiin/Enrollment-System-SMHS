Imports MySql.Data.MySqlClient

Public Class Grade
    Public Fname As String

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim asd As String
        Dim com As String
        asd = ComboBox1.Text

        CONNECTION()
        com = "UPDATE tbl_infos SET Grade = '" + asd + "' WHERE fullname = '" + Fname + "';"
        SQLCOM = New MySqlCommand(com, SQLCON)
        SQLCOM.ExecuteReader()
        Main.Show()
        Assestment.Close()
        Me.Close()



    End Sub

    Private Sub Grade_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = (My.Computer.Screen.WorkingArea.Height / 3)
        Me.Left = (My.Computer.Screen.WorkingArea.Width / 2.75)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Assestment.Show()
        Me.Close()
    End Sub
End Class