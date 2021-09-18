Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For i As Integer = 1 To 5
            MessageBox.Show(i)
        Next
        
       


    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.MaxLength = 12
        Me.Top = (My.Computer.Screen.WorkingArea.Height / 8)
        Me.Left = (My.Computer.Screen.WorkingArea.Width / 5)

    End Sub


    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
    End Sub
    Private Sub Panel4_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel4.Paint
        Color(e)
    End Sub
    Private Sub Panel5_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel5.Paint
        Color(e)
    End Sub
    Private Sub Panel6_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel6.Paint
        Color(e)
    End Sub
    Private Sub Panel8_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        Color(e)
    End Sub
    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint
        Color(e)
    End Sub
    Private Sub Panel7_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel7.Paint
        Color(e)
    End Sub
    Private Sub Panel8_Paint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        Color(e)
    End Sub
    Private Sub Panel9_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        Color(e)
    End Sub
    Private Sub Panel10_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        Color(e)
    End Sub
    Private Sub Panel11_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel11.Paint
        Color(e)
    End Sub
    Private Sub Panel12_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel12.Paint
        Color(e)
    End Sub
    Private Sub Panel13_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel13.Paint
        Color(e)
    End Sub
    Private Sub Panel8_Paint_2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        Color(e)
    End Sub
    Private Sub Panel9_Paint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        Color(e)
    End Sub
    Private Sub Panel19_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel19.Paint
        Color(e)
    End Sub
    Private Sub Panel21_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel21.Paint
        Color(e)
    End Sub
    Private Sub Panel25_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel25.Paint
        Color(e)
    End Sub
    Private Sub Panel20_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel20.Paint
        Color(e)
    End Sub
    Private Sub Panel30_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel30.Paint
        Color(e)
    End Sub
    Private Sub Panel26_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel26.Paint
        Color(e)
    End Sub
    Private Sub Panel31_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel31.Paint
        Color(e)
    End Sub
    Private Sub Panel36_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        Color(e)
    End Sub
    Private Sub Panel32_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        Color(e)
    End Sub
    Private Sub Panel37_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        Color(e)
    End Sub
    Private Sub Panel38_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        Color(e)
    End Sub
    Private Sub Panel42_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        Color(e)
    End Sub
    Private Sub Panel43_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        Color(e)
    End Sub
    Private Sub Panel44_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        Color(e)
    End Sub
    Private Sub Panel48_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        Color(e)
    End Sub
    Private Sub Panel49_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        Color(e)
    End Sub
    Private Sub Panel52_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        Color(e)
    End Sub
    Private Sub Panel50_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        Color(e)
    End Sub
    Private Sub Panel51_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        Color(e)
    End Sub
    Private Sub Panel32_Paint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel32.Paint
        Color(e)
    End Sub
    Private Sub Panel36_Paint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel36.Paint
        Color(e)
    End Sub
    Private Sub Panel37_Paint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel37.Paint
        Color(e)
    End Sub
    Private Sub Panel38_Paint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        Color(e)
    End Sub
    Private Sub Panel42_Paint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel42.Paint
        Color(e)
    End Sub
    Private Sub Panel43_Paint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel43.Paint
        Color(e)
    End Sub
    Private Sub Panel44_Paint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel44.Paint
        Color(e)
    End Sub
    Private Sub Panel48_Paint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel48.Paint
        Color(e)
    End Sub
    Private Sub Panel49_Paint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel49.Paint
        Color(e)
    End Sub
    Private Sub Panel52_Paint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        Color(e)
    End Sub
    Private Sub Panel50_Paint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel50.Paint
        Color(e)
    End Sub
    Private Sub Panel51_Paint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        Color(e)
    End Sub
    Private Sub Panel56_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel56.Paint
        Color(e)
    End Sub
    Private Sub Panel58_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel58.Paint
        Color(e)
    End Sub
    Private Sub Panel57_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel57.Paint
        Color(e)
    End Sub
    Private Sub Panel62_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel62.Paint
        Color(e)
    End Sub
    Private Sub Panel38_Paint_2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel38.Paint
        Color(e)
    End Sub
    Private Sub Panel39_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel39.Paint
        Color(e)
    End Sub
    Private Sub Panel65_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel65.Paint
        Color(e)
    End Sub
    Private Sub Panel66_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel66.Paint
        Color(e)
    End Sub
    Private Sub Panel40_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel40.Paint
        Color(e)
    End Sub
    Private Sub Panel41_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel41.Paint
        Color(e)
    End Sub
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
    Private Sub Panel63_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel63.Paint
        Color(e)
    End Sub
    Private Sub Panel64_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel64.Paint
        Color(e)
    End Sub
    Private Sub Panel67_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel67.Paint
        Color(e)
    End Sub
    Private Sub Panel68_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel68.Paint
        Color(e)
    End Sub
    Private Sub Panel72_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel72.Paint
        Color(e)
    End Sub

    Private Sub TextBox32_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox32.TextChanged

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Dim FullName As String = TextBox2.Text + " " + TextBox3.Text + " " + TextBox4.Text
        Dim LSA As String = ""
        Dim Voucher As String = ""
        If CheckBox1.Checked = True Then
            LSA = "Private"
        End If
        If CheckBox2.Checked = True Then
            LSA = "Public"

        End If
        Dim PTheResults As Boolean = False
        MessageBox.Show("You may now go to Assestment", "Sumulong Memorial High School", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
        Me.Hide()
        Me.Show()
        Dim Lrn As String = TextBox1.Text
        Dim LastName As String = TextBox2.Text
        Dim FirstName As String = TextBox3.Text
        Dim MiddleName As String = TextBox4.Text
        Dim Suffix As String = TextBox5.Text
        Dim Dobb As String = TextBox6.Text
        Dim Dobm As String = TextBox7.Text
        Dim Doby As String = TextBox8.Text
        Dim Pob As String = TextBox9.Text
        Dim Rel As String = TextBox10.Text
        Dim Sex As String = TextBox11.Text
        Dim Natio As String = TextBox12.Text
        Dim Status As String = TextBox13.Text
        Dim Address As String = TextBox14.Text
        Dim Mobile As String = TextBox15.Text
        Dim Phone As String = TextBox16.Text
        Dim Emailadd As String = TextBox17.Text
        Dim Facebookacc As String = TextBox18.Text
        Dim FatherN As String = TextBox19.Text
        Dim FOccup As String = TextBox20.Text
        Dim FCont As String = TextBox21.Text
        Dim MName As String = TextBox39.Text
        Dim MOccup As String = TextBox23.Text
        Dim Mcont As String = TextBox24.Text
        Dim GName As String = TextBox25.Text
        Dim GOccup As String = TextBox26.Text
        Dim Grelation As String = TextBox27.Text
        Dim Gmobile As String = TextBox28.Text
        Dim Gphone As String = TextBox29.Text
        Dim GEmail As String = TextBox30.Text
        Dim GAddress As String = TextBox37.Text
        Dim SiblingB5 As String = TextBox32.Text
        Dim Sibling512 As String = TextBox33.Text
        Dim Sibling1316 As String = TextBox34.Text
        Dim ya As String = TextBox38.Text
        Dim slaadd As String = TextBox36.Text
        Dim nameofschool As String = TextBox35.Text
        If LSA = "Public" Then
            Voucher = "17,000"
        ElseIf LSA = "Private" Then
            Voucher = "14,000"
        End If
        CONNECTION()
        SQLCOM = New MySqlCommand("Insert into tbl_infos(Fullname,lrn,lastname,firstname,middlename,suffix,dobd,dobm ,doby,placeofbirth,religion,sex,nationality,civilstatus,currentaddress,mobileno,phoneno,emailaddress,facebookaccount,fathersname,foccupation,fcontact,mothersname,moccupation,mcontact,guardianssname,goccupation,grelationship,gmobile,gphone,gemailadd,ghomeaddress,siblingb5,sibling512,sibling1316,schoollastattended,yearattended,slaaddress,slapublicorprivate,Voucher) VALUES ('" + FullName + "','" + Lrn + "','" + LastName + "','" + FirstName + "','" + MiddleName + "','" + Suffix + "','" + Dobb + "','" + Dobm + "','" + Doby + "','" + Pob + "','" + Rel + "','" + Sex + "','" + Natio + "','" + Status + "','" + Address + "','" + Mobile + "','" + Phone + "','" + Emailadd + "','" + Facebookacc + "','" + FatherN + "','" + FOccup + "','" + FCont + "','" + MName + "','" + MOccup + "','" + Mcont + "','" + GName + "','" + GOccup + "','" + Grelation + "','" + Gmobile + "','" + Gphone + "','" + GEmail + "','" + GAddress + "','" + SiblingB5 + "','" + Sibling512 + "','" + Sibling1316 + "','" + nameofschool + "','" + ya + "','" + slaadd + "','" + LSA + "','" + Voucher + "')", SQLCON)
        SQLCOM.ExecuteNonQuery()
        Application.Restart()


    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox2.Enabled = False
        ElseIf CheckBox2.Checked = False Then
            CheckBox2.Enabled = True
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            CheckBox1.Enabled = False
        ElseIf CheckBox2.Checked = False Then
            CheckBox1.Enabled = True
        End If
    End Sub

    Private Sub TextBox35_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox35.TextChanged

    End Sub
End Class
