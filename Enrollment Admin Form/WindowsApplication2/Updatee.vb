Imports MySql.Data.MySqlClient

Public Class Updatee

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub Updatee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox2.Enabled = False

        Me.Top = (My.Computer.Screen.WorkingArea.Height / 3)
        Me.Left = (My.Computer.Screen.WorkingArea.Width / 2.75)
        ComboBox1.AutoCompleteMode = AutoCompleteMode.Append
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDown
        ComboBox1.AutoCompleteSource = AutoCompleteSource.ListItems
        Dim con As New MySqlConnection
        Dim cmd As New MySqlCommand
        Dim da As New MySqlDataAdapter

        con.ConnectionString = ("server=localhost;user id=root;password=root;database=enrollment_db")
        con.Open()
        Try
            'we open Connection


            With cmd
                .Connection = con
                .CommandText = "SELECT `fullname` from tbl_infos;"
            End With
            'declare dt as new datatable
            Dim dt As New DataTable

            With ComboBox1
                da.SelectCommand = cmd
                'it fills the da values into dt
                da.Fill(dt)
                'dt provides the data surce of combobox
                .DataSource = dt
                'specify the what to display
                .DisplayMember = "fullname"
                'and the value
                .ValueMember = "fullname"

            End With


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Dim last As String
        last = ComboBox1.Items.Count - 1
        ComboBox1.SelectedIndex = last
        con.Close()

    End Sub
    Public Fname As String
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Assestment.Fname = ComboBox1.Text
        Grade.Fname = ComboBox1.Text
        Me.Close()
        Assestment.Show()

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        CONNECTION()
        Dim Query As String
        Query = "Select lrn from tbl_infos where fullname='" & ComboBox1.Text & "'"
        SQLCOM = New MySqlCommand(Query, SQLCON)
        SQLREAD = SQLCOM.ExecuteReader
        While SQLREAD.Read
            Try
                TextBox2.Text = SQLREAD.GetString("Lrn")
            Catch ex As Exception
                MsgBox("Invalid Information")
            End Try

        End While
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Main.Show()
        Me.Close()

    End Sub
End Class