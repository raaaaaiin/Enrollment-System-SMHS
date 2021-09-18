Imports MySql.Data.MySqlClient
Public Class Assestment
    Public Track As String = ""
    Public Strand As String = ""
    Public Status
    Public Payment
    Public Fname As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CheckBox9.Checked = True Then
            Status = "RESERVED"
        ElseIf CheckBox10.Checked = True Then
            Status = "REGISTERED"
        ElseIf CheckBox11.Checked = True Then
            Status = "ENROLLED"
        ElseIf CheckBox12.Checked = True Then
            Status = "SCHOLAR"
        ElseIf CheckBox13.Checked = True Then
            Status = "TRANSFEREE"
        ElseIf CheckBox14.Checked = True Then
            Status = "OLD STUDENT/RETURNEE"
        End If
        If CheckBox15.Checked = True Then
            Payment = "Monthly"
        ElseIf CheckBox16.Checked = True Then
            Payment = "SEMI-ANNUAL"
        ElseIf CheckBox17.Checked = True Then
            Payment = "QUARTERLY"
        ElseIf CheckBox18.Checked = True Then
            Payment = "CASH"
        End If
        Try
            CONNECTION()
            Dim Sql As String
            Sql = "UPDATE tbl_infos SET Status = '" + Status + "',Payment = '" + Payment + "',Track = '" + Track + "',Strand = '" + Strand + "' WHERE fullname = '" + Fname + "';"
            SQLCOM = New MySqlCommand(Sql, SQLCON)
            SQLCOM.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("wrong information")
        End Try
        Me.Hide()
        Grade.Show()




    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Main.Show()

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            CheckBox1.Enabled = False
            CheckBox3.Enabled = False
            CheckBox4.Enabled = False
            CheckBox5.Enabled = False
            CheckBox6.Enabled = False
            CheckBox7.Enabled = False
            CheckBox8.Enabled = False
            If CheckBox1.Checked = True Then
                Track = "Academic"
                Strand = "STEM"

            End If
            If CheckBox2.Checked = True Then
                Track = "Academic"
                Strand = "STEM"

            End If
            If CheckBox3.Checked = True Then

                Track = "Academic"
                Strand = "GAS"
            End If
            If CheckBox4.Checked = True Then
                Track = "Academic"
                Strand = "HUMSS"

            End If
            If CheckBox5.Checked = True Then
                Track = "Arts And Design"
                Strand = "Arts Production"

            End If
            If CheckBox6.Checked = True Then
                Track = "Arts And Design"
                Strand = "Performing arts"

            End If
            If CheckBox7.Checked = True Then
                Track = "TVL"
                Strand = "ICT"


            End If
            If CheckBox8.Checked = True Then
                Track = "TVL"
                Strand = "HE"
            End If
            TextBox1.Text = Track + " " + "(" + Strand + ")"

        ElseIf CheckBox2.Checked = False Then
            CheckBox1.Enabled = True
            CheckBox3.Enabled = True
            CheckBox4.Enabled = True
            CheckBox5.Enabled = True
            CheckBox6.Enabled = True
            CheckBox7.Enabled = True
            CheckBox8.Enabled = True
            If CheckBox1.Checked = True Then
                Track = "Academic"
                Strand = "STEM"

            End If
            If CheckBox2.Checked = True Then
                Track = "Academic"
                Strand = "STEM"

            End If
            If CheckBox3.Checked = True Then

                Track = "Academic"
                Strand = "GAS"
            End If
            If CheckBox4.Checked = True Then
                Track = "Academic"
                Strand = "HUMSS"

            End If
            If CheckBox5.Checked = True Then
                Track = "Arts And Design"
                Strand = "Arts Production"

            End If
            If CheckBox6.Checked = True Then
                Track = "Arts And Design"
                Strand = "Performing arts"

            End If
            If CheckBox7.Checked = True Then
                Track = "TVL"
                Strand = "ICT"


            End If
            If CheckBox8.Checked = True Then
                Track = "TVL"
                Strand = "HE"
            End If
            TextBox1.Text = Track + " " + "(" + Strand + ")"
        End If
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
            CheckBox4.Enabled = False
            CheckBox5.Enabled = False
            CheckBox6.Enabled = False
            CheckBox7.Enabled = False
            CheckBox8.Enabled = False
            If CheckBox1.Checked = True Then
                Track = "Academic"
                Strand = "STEM"

            End If
            If CheckBox2.Checked = True Then
                Track = "Academic"
                Strand = "STEM"

            End If
            If CheckBox3.Checked = True Then

                Track = "Academic"
                Strand = "GAS"
            End If
            If CheckBox4.Checked = True Then
                Track = "Academic"
                Strand = "HUMSS"

            End If
            If CheckBox5.Checked = True Then
                Track = "Arts And Design"
                Strand = "Arts Production"

            End If
            If CheckBox6.Checked = True Then
                Track = "Arts And Design"
                Strand = "Performing arts"

            End If
            If CheckBox7.Checked = True Then
                Track = "TVL"
                Strand = "ICT"


            End If
            If CheckBox8.Checked = True Then
                Track = "TVL"
                Strand = "HE"
            End If
            TextBox1.Text = Track + " " + "(" + Strand + ")"

        ElseIf CheckBox1.Checked = False Then
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
            CheckBox4.Enabled = True
            CheckBox5.Enabled = True
            CheckBox6.Enabled = True
            CheckBox7.Enabled = True
            CheckBox8.Enabled = True
            If CheckBox1.Checked = True Then
                Track = "Academic"
                Strand = "STEM"

            End If
            If CheckBox2.Checked = True Then
                Track = "Academic"
                Strand = "STEM"

            End If
            If CheckBox3.Checked = True Then

                Track = "Academic"
                Strand = "GAS"
            End If
            If CheckBox4.Checked = True Then
                Track = "Academic"
                Strand = "HUMSS"

            End If
            If CheckBox5.Checked = True Then
                Track = "Arts And Design"
                Strand = "Arts Production"

            End If
            If CheckBox6.Checked = True Then
                Track = "Arts And Design"
                Strand = "Performing arts"

            End If
            If CheckBox7.Checked = True Then
                Track = "TVL"
                Strand = "ICT"


            End If
            If CheckBox8.Checked = True Then
                Track = "TVL"
                Strand = "HE"
            End If
            TextBox1.Text = Track + " " + "(" + Strand + ")"
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            CheckBox1.Enabled = False
            CheckBox2.Enabled = False
            CheckBox4.Enabled = False
            CheckBox5.Enabled = False
            CheckBox6.Enabled = False
            CheckBox7.Enabled = False
            CheckBox8.Enabled = False

        ElseIf CheckBox3.Checked = False Then
            CheckBox1.Enabled = True
            CheckBox2.Enabled = True
            CheckBox4.Enabled = True
            CheckBox5.Enabled = True
            CheckBox6.Enabled = True
            CheckBox7.Enabled = True
            CheckBox8.Enabled = True

        End If
        If CheckBox1.Checked = True Then
            Track = "Academic"
            Strand = "STEM"

        End If
        If CheckBox2.Checked = True Then
            Track = "Academic"
            Strand = "STEM"

        End If
        If CheckBox3.Checked = True Then

            Track = "Academic"
            Strand = "GAS"
        End If
        If CheckBox4.Checked = True Then
            Track = "Academic"
            Strand = "HUMSS"

        End If
        If CheckBox5.Checked = True Then
            Track = "Arts And Design"
            Strand = "Arts Production"

        End If
        If CheckBox6.Checked = True Then
            Track = "Arts And Design"
            Strand = "Performing arts"

        End If
        If CheckBox7.Checked = True Then
            Track = "TVL"
            Strand = "ICT"


        End If
        If CheckBox8.Checked = True Then
            Track = "TVL"
            Strand = "HE"
        End If
        TextBox1.Text = Track + " " + "(" + Strand + ")"

    End Sub

    Private Sub CheckBox4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            CheckBox1.Enabled = False
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
            CheckBox5.Enabled = False
            CheckBox6.Enabled = False
            CheckBox7.Enabled = False
            CheckBox8.Enabled = False

        ElseIf CheckBox4.Checked = False Then
            CheckBox1.Enabled = True
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
            CheckBox5.Enabled = True
            CheckBox6.Enabled = True
            CheckBox7.Enabled = True
            CheckBox8.Enabled = True
        End If
        If CheckBox1.Checked = True Then
            Track = "Academic"
            Strand = "STEM"

        End If
        If CheckBox2.Checked = True Then
            Track = "Academic"
            Strand = "STEM"

        End If
        If CheckBox3.Checked = True Then

            Track = "Academic"
            Strand = "GAS"
        End If
        If CheckBox4.Checked = True Then
            Track = "Academic"
            Strand = "HUMSS"

        End If
        If CheckBox5.Checked = True Then
            Track = "Arts And Design"
            Strand = "Arts Production"

        End If
        If CheckBox6.Checked = True Then
            Track = "Arts And Design"
            Strand = "Performing arts"

        End If
        If CheckBox7.Checked = True Then
            Track = "TVL"
            Strand = "ICT"


        End If
        If CheckBox8.Checked = True Then
            Track = "TVL"
            Strand = "HE"
        End If
        TextBox1.Text = Track + " " + "(" + Strand + ")"
    End Sub

    Private Sub CheckBox6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            CheckBox1.Enabled = False
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
            CheckBox4.Enabled = False
            CheckBox5.Enabled = False
            CheckBox7.Enabled = False
            CheckBox8.Enabled = False

        ElseIf CheckBox6.Checked = False Then
            CheckBox1.Enabled = True
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
            CheckBox4.Enabled = True
            CheckBox5.Enabled = True
            CheckBox7.Enabled = True
            CheckBox8.Enabled = True
        End If
        If CheckBox1.Checked = True Then
            Track = "Academic"
            Strand = "STEM"

        End If
        If CheckBox2.Checked = True Then
            Track = "Academic"
            Strand = "STEM"

        End If
        If CheckBox3.Checked = True Then

            Track = "Academic"
            Strand = "GAS"
        End If
        If CheckBox4.Checked = True Then
            Track = "Academic"
            Strand = "HUMSS"

        End If
        If CheckBox5.Checked = True Then
            Track = "Arts And Design"
            Strand = "Arts Production"

        End If
        If CheckBox6.Checked = True Then
            Track = "Arts And Design"
            Strand = "Performing arts"

        End If
        If CheckBox7.Checked = True Then
            Track = "TVL"
            Strand = "ICT"


        End If
        If CheckBox8.Checked = True Then
            Track = "TVL"
            Strand = "HE"
        End If
        TextBox1.Text = Track + " " + "(" + Strand + ")"
    End Sub

    Private Sub CheckBox5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            CheckBox1.Enabled = False
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
            CheckBox4.Enabled = False
            CheckBox6.Enabled = False
            CheckBox7.Enabled = False
            CheckBox8.Enabled = False

        ElseIf CheckBox5.Checked = False Then
            CheckBox1.Enabled = True
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
            CheckBox4.Enabled = True
            CheckBox6.Enabled = True
            CheckBox7.Enabled = True
            CheckBox8.Enabled = True
        End If
        If CheckBox1.Checked = True Then
            Track = "Academic"
            Strand = "STEM"

        End If
        If CheckBox2.Checked = True Then
            Track = "Academic"
            Strand = "STEM"

        End If
        If CheckBox3.Checked = True Then

            Track = "Academic"
            Strand = "GAS"
        End If
        If CheckBox4.Checked = True Then
            Track = "Academic"
            Strand = "HUMSS"

        End If
        If CheckBox5.Checked = True Then
            Track = "Arts And Design"
            Strand = "Arts Production"

        End If
        If CheckBox6.Checked = True Then
            Track = "Arts And Design"
            Strand = "Performing arts"

        End If
        If CheckBox7.Checked = True Then
            Track = "TVL"
            Strand = "ICT"


        End If
        If CheckBox8.Checked = True Then
            Track = "TVL"
            Strand = "HE"
        End If
        TextBox1.Text = Track + " " + "(" + Strand + ")"
    End Sub

    Private Sub CheckBox7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked = True Then
            CheckBox1.Enabled = False
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
            CheckBox4.Enabled = False
            CheckBox5.Enabled = False
            CheckBox6.Enabled = False
            CheckBox8.Enabled = False

        ElseIf CheckBox7.Checked = False Then
            CheckBox1.Enabled = True
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
            CheckBox4.Enabled = True
            CheckBox5.Enabled = True
            CheckBox6.Enabled = True
            CheckBox8.Enabled = True
        End If
        If CheckBox1.Checked = True Then
            Track = "Academic"
            Strand = "STEM"

        End If
        If CheckBox2.Checked = True Then
            Track = "Academic"
            Strand = "STEM"

        End If
        If CheckBox3.Checked = True Then

            Track = "Academic"
            Strand = "GAS"
        End If
        If CheckBox4.Checked = True Then
            Track = "Academic"
            Strand = "HUMSS"

        End If
        If CheckBox5.Checked = True Then
            Track = "Arts And Design"
            Strand = "Arts Production"

        End If
        If CheckBox6.Checked = True Then
            Track = "Arts And Design"
            Strand = "Performing arts"

        End If
        If CheckBox7.Checked = True Then
            Track = "TVL"
            Strand = "ICT"


        End If
        If CheckBox8.Checked = True Then
            Track = "TVL"
            Strand = "HE"
        End If
        TextBox1.Text = Track + " " + "(" + Strand + ")"
    End Sub

    Private Sub CheckBox8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.Checked = True Then
            CheckBox1.Enabled = False
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
            CheckBox4.Enabled = False
            CheckBox5.Enabled = False
            CheckBox6.Enabled = False
            CheckBox7.Enabled = False
        ElseIf CheckBox8.Checked = False Then
            CheckBox1.Enabled = True
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
            CheckBox4.Enabled = True
            CheckBox5.Enabled = True
            CheckBox6.Enabled = True
            CheckBox7.Enabled = True
        End If
        If CheckBox1.Checked = True Then
            Track = "Academic"
            Strand = "STEM"

        End If
        If CheckBox2.Checked = True Then
            Track = "Academic"
            Strand = "STEM"

        End If
        If CheckBox3.Checked = True Then

            Track = "Academic"
            Strand = "GAS"
        End If
        If CheckBox4.Checked = True Then
            Track = "Academic"
            Strand = "HUMSS"

        End If
        If CheckBox5.Checked = True Then
            Track = "Arts And Design"
            Strand = "Arts Production"

        End If
        If CheckBox6.Checked = True Then
            Track = "Arts And Design"
            Strand = "Performing arts"

        End If
        If CheckBox7.Checked = True Then
            Track = "TVL"
            Strand = "ICT"


        End If
        If CheckBox8.Checked = True Then
            Track = "TVL"
            Strand = "HE"
        End If
        TextBox1.Text = Track + " " + "(" + Strand + ")"
    End Sub

    Private Sub Assestment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Top = (My.Computer.Screen.WorkingArea.Height / 5)
        Me.Left = (My.Computer.Screen.WorkingArea.Width / 4)
        Dim Track As String = ""
        Dim Strand As String = ""
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Panel4_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel4.Paint

    End Sub


    Private Sub CheckBox9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox9.CheckedChanged
        If CheckBox9.Checked = True Then
            CheckBox10.Enabled = False
            CheckBox11.Enabled = False
            CheckBox12.Enabled = False
            CheckBox13.Enabled = False
            CheckBox14.Enabled = False
        ElseIf CheckBox9.Checked = False Then
            CheckBox10.Enabled = True
            CheckBox11.Enabled = True
            CheckBox12.Enabled = True
            CheckBox13.Enabled = True
            CheckBox14.Enabled = True
        End If
    End Sub

    Private Sub CheckBox10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox10.CheckedChanged
        If CheckBox10.Checked = True Then
            CheckBox9.Enabled = False
            CheckBox11.Enabled = False
            CheckBox12.Enabled = False
            CheckBox13.Enabled = False
            CheckBox14.Enabled = False
        ElseIf CheckBox10.Checked = False Then
            CheckBox9.Enabled = True
            CheckBox11.Enabled = True
            CheckBox12.Enabled = True
            CheckBox13.Enabled = True
            CheckBox14.Enabled = True
        End If
    End Sub

    Private Sub CheckBox11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox11.CheckedChanged
        If CheckBox11.Checked = True Then
            CheckBox9.Enabled = False
            CheckBox10.Enabled = False
            CheckBox12.Enabled = False
            CheckBox13.Enabled = False
            CheckBox14.Enabled = False
        ElseIf CheckBox9.Checked = False Then
            CheckBox9.Enabled = True
            CheckBox10.Enabled = True
            CheckBox12.Enabled = True
            CheckBox13.Enabled = True
            CheckBox14.Enabled = True
        End If
    End Sub

    Private Sub CheckBox14_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox14.CheckedChanged
        If CheckBox14.Checked = True Then
            CheckBox9.Enabled = False
            CheckBox10.Enabled = False
            CheckBox11.Enabled = False
            CheckBox12.Enabled = False
            CheckBox13.Enabled = False
        ElseIf CheckBox14.Checked = False Then
            CheckBox9.Enabled = True
            CheckBox10.Enabled = True
            CheckBox11.Enabled = True
            CheckBox12.Enabled = True
            CheckBox13.Enabled = True
        End If
    End Sub

    Private Sub CheckBox13_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox13.CheckedChanged
        If CheckBox13.Checked = True Then
            CheckBox9.Enabled = False
            CheckBox10.Enabled = False
            CheckBox11.Enabled = False
            CheckBox12.Enabled = False
            CheckBox14.Enabled = False
        ElseIf CheckBox13.Checked = False Then
            CheckBox9.Enabled = True
            CheckBox10.Enabled = True
            CheckBox11.Enabled = True
            CheckBox12.Enabled = True
            CheckBox14.Enabled = True
        End If
    End Sub

    Private Sub CheckBox12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox12.CheckedChanged
        If CheckBox12.Checked = True Then
            CheckBox9.Enabled = False
            CheckBox10.Enabled = False
            CheckBox11.Enabled = False
            CheckBox13.Enabled = False
            CheckBox14.Enabled = False
        ElseIf CheckBox9.Checked = False Then
            CheckBox9.Enabled = True
            CheckBox10.Enabled = True
            CheckBox11.Enabled = True
            CheckBox12.Enabled = True
            CheckBox13.Enabled = True
            CheckBox14.Enabled = True
        End If
    End Sub

    Private Sub CheckBox18_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox18.CheckedChanged
        If CheckBox18.Checked = True Then
            CheckBox15.Enabled = False
            CheckBox16.Enabled = False
            CheckBox17.Enabled = False
        ElseIf CheckBox18.Checked = False Then
            CheckBox15.Enabled = True
            CheckBox16.Enabled = True
            CheckBox17.Enabled = True
        End If
    End Sub

    Private Sub CheckBox17_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox17.CheckedChanged
        If CheckBox17.Checked = True Then
            CheckBox15.Enabled = False
            CheckBox16.Enabled = False
            CheckBox18.Enabled = False
        ElseIf CheckBox17.Checked = False Then
            CheckBox15.Enabled = True
            CheckBox16.Enabled = True
            CheckBox18.Enabled = True
        End If

    End Sub

    Private Sub CheckBox15_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox15.CheckedChanged
        If CheckBox15.Checked = True Then
            CheckBox16.Enabled = False
            CheckBox17.Enabled = False
            CheckBox18.Enabled = False
        ElseIf CheckBox15.Checked = False Then
            CheckBox16.Enabled = True
            CheckBox17.Enabled = True
            CheckBox18.Enabled = True
        End If
    End Sub

    Private Sub CheckBox16_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox16.CheckedChanged
        If CheckBox16.Checked = True Then
            CheckBox15.Enabled = False
            CheckBox17.Enabled = False
            CheckBox18.Enabled = False
        ElseIf CheckBox16.Checked = False Then
            CheckBox15.Enabled = True
            CheckBox17.Enabled = True
            CheckBox18.Enabled = True
        End If

    End Sub
End Class