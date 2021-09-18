Imports MySql.Data.MySqlClient

Public Class Main
    Public MysqlConn As MySqlConnection
    Public ContactsCommand As New MySqlCommand
    Public ContactsAdapter As New MySqlDataAdapter
    Public ContactsData As New DataTable
    Public SQL As String
    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = (My.Computer.Screen.WorkingArea.Height / 11)
        Me.Left = (My.Computer.Screen.WorkingArea.Width / 6)
        DataGridView1.Hide()


    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub


    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        DataGridView1.Show()

        MysqlConn = New MySqlConnection()

        ' Define the SQL to grab data from table.
        SQL = "SELECT Lrn,FullName,Grade,Track,Strand,Voucher,Payment,Status from tbl_infos;"
        'Connection String

        MysqlConn.ConnectionString = "server=localhost;" _
        & "user id=root;" _
        & "password=root;" _
        & "database=enrollment_db"

        ' Try, Catch, Finally
        Try
            MysqlConn.Open()

            ContactsCommand.Connection = MysqlConn
            ContactsCommand.CommandText = SQL

            ContactsAdapter.SelectCommand = ContactsCommand
            ContactsAdapter.Fill(ContactsData)
            DataGridView1.DataSource = ContactsData

        Catch myerror As MySqlException
            MessageBox.Show("Cannot connect to database: " & myerror.Message)
        Finally
            MysqlConn.Close()
            MysqlConn.Dispose()
        End Try


    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Updatee.Show()
        Me.Close()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
        UserDelete.Show()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()

        USEREDIT.Show()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        USERPRINT.Show()

        Me.Close()

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class