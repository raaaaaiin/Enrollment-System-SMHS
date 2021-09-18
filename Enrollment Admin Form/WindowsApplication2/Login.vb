Imports MySql.Data.MySqlClient

Public Class Login
    Dim USERNAME_VALIDATE As Boolean = False
    Dim PASSWORD_VALIDATE As Boolean = False

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = (My.Computer.Screen.WorkingArea.Height / 3)
        Me.Left = (My.Computer.Screen.WorkingArea.Width / 3)

    End Sub
    Private Function GetUsername(ByVal UserINPUT As String) As Boolean
        Dim TheInput As String = UserINPUT
        Dim TheResults As Boolean = False
        CONNECTION()
        SQLCOM = New MySqlCommand("SELECT Username,Password FROM tbl_admin WHERE Username ='" + UserINPUT + "' ", SQLCON)
        SQLREAD = SQLCOM.ExecuteReader
        If SQLREAD.Read = True Then
            TheResults = True
        ElseIf SQLREAD.Read = False Then
            TheResults = False
        End If
        Return TheResults


    End Function
    Private Function GetPassword(ByVal PassInput As String) As Boolean
        Dim PTheInput As String = PassInput
        Dim PTheResults As Boolean = False
        CONNECTION()
        SQLCOM = New MySqlCommand("SELECT Password From tbl_admin WHERE Password ='" + PassInput + "' ", SQLCON)
        SQLREAD = SQLCOM.ExecuteReader
        If SQLREAD.Read = True Then
            PTheResults = True
        ElseIf SQLREAD.Read = False Then
            PTheResults = False
        End If
        Return PTheResults
    End Function

    Private Sub TextBox2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            If GetPassword(TextBox2.Text) = True And GetUsername(TextBox1.Text) Then
                PASSWORD_VALIDATE = True
                Me.Hide()
                LoadingBes.Show()


            Else

                PASSWORD_VALIDATE = False
                MessageBox.Show("Wrong Information", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End If


        End If
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            If GetUsername(TextBox1.Text) = True And GetPassword(TextBox2.Text) Then
                USERNAME_VALIDATE = True
                Me.Hide()
                LoadingBes.Show()
            Else
                USERNAME_VALIDATE = False
                MessageBox.Show("Wrong Information", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)


            End If
        End If
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If GetPassword(TextBox2.Text) = True And GetUsername(TextBox1.Text) Then
            PASSWORD_VALIDATE = True
            LoadingBes.Show()
            Me.Hide()

        Else

            PASSWORD_VALIDATE = False
            MessageBox.Show("Wrong Information", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        End If

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
