Imports MySql.Data.MySqlClient

Public Class PRINTINGFORM

    Public Fname As String
    Public a As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For i As Integer = 1 To 5
            MessageBox.Show(i)
        Next


    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.MaxLength = 12
        CheckBox8.Enabled = False
        CheckBox7.Enabled = False
        CheckBox3.Enabled = False
        CheckBox4.Enabled = False
        CheckBox6.Enabled = False
        CheckBox5.Enabled = False
        CheckBox19.Enabled = False
        CheckBox20.Enabled = False
        CheckBox9.Enabled = False
        CheckBox10.Enabled = False
        CheckBox11.Enabled = False
        CheckBox12.Enabled = False
        CheckBox13.Enabled = False
        CheckBox14.Enabled = False
        CheckBox15.Enabled = False
        CheckBox10.Enabled = False
        CheckBox11.Enabled = False
        CheckBox9.Enabled = False
        CheckBox18.Enabled = False
        CheckBox17.Enabled = False
        CheckBox16.Enabled = False


        Me.Top = (My.Computer.Screen.WorkingArea.Height / 300)
        Me.Left = (My.Computer.Screen.WorkingArea.Width / 4)
        CONNECTION()
        Dim Query As String
        Query = "Select Lrn,LastName,FirstName,MiddleName,Suffix,Dobd,Dobm,Doby,Placeofbirth,Religion,Sex,Nationality,CivilStatus,CurrentAddress,Mobileno,Phoneno,Emailaddress,Facebookaccount,FathersName,FOccupation,FContact,MothersName,MOccupation,Mcontact,GuardianssName,GOccupation,Grelationship,Gmobile,Gphone,GEmailAdd,GHomeAddress,SiblingB5,Sibling512,Sibling1316,slapublicorPrivate,yearattended,slaaddress,Schoollastattended,Strand,Status,Payment,Track from tbl_infos where fullname='" + Fname + "'"
        SQLCOM = New MySqlCommand(Query, SQLCON)
        SQLREAD = SQLCOM.ExecuteReader
        While SQLREAD.Read
            Try
                TextBox1.Text = SQLREAD.GetString("Lrn")
                TextBox2.Text = SQLREAD.GetString("LastName")
                TextBox3.Text = SQLREAD.GetString("FirstName")
                TextBox4.Text = SQLREAD.GetString("MiddleName")
                TextBox5.Text = SQLREAD.GetString("Suffix")
                TextBox6.Text = SQLREAD.GetString("Dobd")
                TextBox7.Text = SQLREAD.GetString("Dobm")
                TextBox8.Text = SQLREAD.GetString("Doby")
                TextBox9.Text = SQLREAD.GetString("Placeofbirth")
                TextBox10.Text = SQLREAD.GetString("Religion")
                TextBox11.Text = SQLREAD.GetString("Sex")
                TextBox12.Text = SQLREAD.GetString("Nationality")
                TextBox13.Text = SQLREAD.GetString("CivilStatus")
                TextBox14.Text = SQLREAD.GetString("CurrentAddress")
                TextBox15.Text = SQLREAD.GetString("Mobileno")
                TextBox16.Text = SQLREAD.GetString("Phoneno")
                TextBox17.Text = SQLREAD.GetString("Emailaddress")
                TextBox18.Text = SQLREAD.GetString("Facebookaccount")
                TextBox19.Text = SQLREAD.GetString("FathersName")
                TextBox20.Text = SQLREAD.GetString("FOccupation")
                TextBox21.Text = SQLREAD.GetString("FContact")
                TextBox39.Text = SQLREAD.GetString("Mothersname")
                TextBox23.Text = SQLREAD.GetString("MOccupation")
                TextBox24.Text = SQLREAD.GetString("Mcontact")
                TextBox25.Text = SQLREAD.GetString("GuardianssName")
                TextBox26.Text = SQLREAD.GetString("GOccupation")
                TextBox27.Text = SQLREAD.GetString("Grelationship")
                TextBox28.Text = SQLREAD.GetString("Gmobile")
                TextBox29.Text = SQLREAD.GetString("Gphone")
                TextBox30.Text = SQLREAD.GetString("GEmailadd")
                TextBox37.Text = SQLREAD.GetString("GHomeAddress")
                TextBox32.Text = SQLREAD.GetString("SiblingB5")
                TextBox33.Text = SQLREAD.GetString("Sibling512")
                TextBox34.Text = SQLREAD.GetString("Sibling1316")
                TextBox38.Text = SQLREAD.GetString("yearAttended")
                TextBox37.Text = SQLREAD.GetString("GhomeAddress")
                TextBox35.Text = SQLREAD.GetString("Schoollastattended")
                TextBox36.Text = SQLREAD.GetString("slaaddress")
                TextBox40.Text = SQLREAD.GetString("slapublicorprivate")
                TextBox42.Text = SQLREAD.GetString("Strand")
                TextBox43.Text = SQLREAD.GetString("Status")
                TextBox44.Text = SQLREAD.GetString("Payment")
                TextBox45.Text = SQLREAD.GetString("Track")

                If TextBox40.Text = "Public" Then

                    CheckBox2.CheckState = CheckState.Checked

                ElseIf TextBox40.Text = "Private" Then
                    CheckBox1.CheckState = CheckState.Checked

                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End While
        Try
            Dim zxc As String
            Dim stats As String
            Dim paym As String
            Dim truck As String
            stats = TextBox43.Text
            paym = TextBox44.Text
            zxc = TextBox42.Text
            truck = TextBox45.Text

            TextBox41.Text = truck + "(" + zxc + ")"

            If zxc = "STEM" Then

                CheckBox7.CheckState = CheckState.Checked
            ElseIf zxc = "ABM" Then
                CheckBox8.CheckState = CheckState.Checked

            ElseIf zxc = "GAS" Then
                CheckBox3.CheckState = CheckState.Checked
            ElseIf zxc = "HUMSS" Then
                CheckBox4.CheckState = CheckState.Checked
            ElseIf zxc = "Arts Production" Then
                CheckBox5.CheckState = CheckState.Checked
            ElseIf zxc = "Performing arts" Then
                CheckBox6.CheckState = CheckState.Checked
            ElseIf zxc = "ICT" Then
                CheckBox19.CheckState = CheckState.Checked
            ElseIf zxc = "HE" Then
                CheckBox20.CheckState = CheckState.Checked
            End If
            If stats = "RESERVED" Then
                CheckBox9.CheckState = CheckState.Checked
            ElseIf stats = "REGISTERED" Then
                CheckBox10.CheckState = CheckState.Checked
            ElseIf stats = "ENROLLED" Then
                CheckBox11.CheckState = CheckState.Checked
            ElseIf stats = "SCHOLAR" Then
                CheckBox12.CheckState = CheckState.Checked
            ElseIf stats = "TRANSFEREE" Then
                CheckBox13.CheckState = CheckState.Checked
            ElseIf stats = "OLD STUDENT/RETURNEE" Then
                CheckBox14.CheckState = CheckState.Checked
            End If
            If paym = "Monthly" Then
                CheckBox15.CheckState = CheckState.Checked
            ElseIf paym = "SEMI-ANNUAL" Then
                CheckBox16.CheckState = CheckState.Checked
            ElseIf paym = "QUARTERLY" Then
                CheckBox17.CheckState = CheckState.Checked
            ElseIf paym = "CASH" Then
                CheckBox18.CheckState = CheckState.Checked

            End If

        Catch ex As Exception

        End Try

    End Sub
    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
        Main.Show()

        Me.Close()





    End Sub
    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint
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
    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub TextBox40_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox40.TextChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Panel14_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel14.Paint

    End Sub

    Private Sub Panel16_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel16.Paint

    End Sub

    Private Sub Panel15_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel15.Paint

    End Sub

    Private Sub Label55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label55.Click

    End Sub

    Private Sub Label56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label56.Click

    End Sub

    Private Sub Panel71_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel71.Paint

    End Sub

    Private Sub Panel70_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel70.Paint

    End Sub

    Private Sub Panel69_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel69.Paint

    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click

    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.Click

    End Sub

    Private Sub TextBox12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox12.TextChanged

    End Sub

    Private Sub Label17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label17.Click

    End Sub

    Private Sub TextBox13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox13.TextChanged

    End Sub

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click

    End Sub

    Private Sub TextBox11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox11.TextChanged

    End Sub

    Private Sub Label14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label14.Click

    End Sub

    Private Sub TextBox10_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox10.TextChanged

    End Sub

    Private Sub Label13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label13.Click

    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub Label19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label19.Click

    End Sub

    Private Sub Label18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label18.Click

    End Sub

    Private Sub Label20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label20.Click

    End Sub

    Private Sub Label38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label38.Click

    End Sub

    Private Sub Label39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label39.Click

    End Sub

    Private Sub Label40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label40.Click

    End Sub

    Private Sub Label45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label45.Click

    End Sub

    Private Sub TextBox14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox14.TextChanged

    End Sub

    Private Sub Panel24_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel24.Paint

    End Sub

    Private Sub Panel23_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel23.Paint

    End Sub

    Private Sub Panel22_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel22.Paint

    End Sub

    Private Sub Panel75_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel75.Paint

    End Sub

    Private Sub Panel74_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel74.Paint

    End Sub

    Private Sub Panel73_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel73.Paint

    End Sub

    Private Sub Label22_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label22.Click

    End Sub

    Private Sub TextBox16_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox16.TextChanged

    End Sub

    Private Sub Label21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label21.Click

    End Sub

    Private Sub TextBox15_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox15.TextChanged

    End Sub

    Private Sub Label24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label24.Click

    End Sub

    Private Sub TextBox18_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox18.TextChanged

    End Sub

    Private Sub Label23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label23.Click

    End Sub

    Private Sub TextBox17_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox17.TextChanged

    End Sub

    Private Sub Panel29_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel29.Paint

    End Sub

    Private Sub Panel28_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel28.Paint

    End Sub

    Private Sub Panel27_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel27.Paint

    End Sub

    Private Sub Label25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label25.Click

    End Sub

    Private Sub TextBox19_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox19.TextChanged

    End Sub

    Private Sub Label27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label27.Click

    End Sub

    Private Sub TextBox21_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox21.TextChanged

    End Sub

    Private Sub Label26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label26.Click

    End Sub

    Private Sub TextBox20_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox20.TextChanged

    End Sub

    Private Sub Panel35_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel35.Paint

    End Sub

    Private Sub Panel34_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel34.Paint

    End Sub

    Private Sub Panel33_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel33.Paint

    End Sub

    Private Sub Label28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label28.Click

    End Sub

    Private Sub TextBox39_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox39.TextChanged

    End Sub

    Private Sub Label30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label30.Click

    End Sub

    Private Sub TextBox24_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox24.TextChanged

    End Sub

    Private Sub Label29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label29.Click

    End Sub

    Private Sub TextBox23_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox23.TextChanged

    End Sub

    Private Sub Panel47_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel47.Paint

    End Sub

    Private Sub Panel46_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel46.Paint

    End Sub

    Private Sub Panel45_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel45.Paint

    End Sub

    Private Sub Label34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label34.Click

    End Sub

    Private Sub TextBox28_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox28.TextChanged

    End Sub

    Private Sub Label36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label36.Click

    End Sub

    Private Sub TextBox30_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox30.TextChanged

    End Sub

    Private Sub Label35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label35.Click

    End Sub

    Private Sub TextBox29_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox29.TextChanged

    End Sub

    Private Sub Label41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label41.Click

    End Sub

    Private Sub Label49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label49.Click

    End Sub

    Private Sub Label44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label44.Click

    End Sub

    Private Sub Label43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label43.Click

    End Sub

    Private Sub Label42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label42.Click

    End Sub

    Private Sub Label37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label37.Click

    End Sub

    Private Sub TextBox37_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox37.TextChanged

    End Sub

    Private Sub Label47_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label47.Click

    End Sub

    Private Sub Label46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label46.Click

    End Sub

    Private Sub Label48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label48.Click

    End Sub

    Private Sub TextBox33_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox33.TextChanged

    End Sub

    Private Sub TextBox34_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox34.TextChanged

    End Sub

    Private Sub TextBox32_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox32.TextChanged

    End Sub

    Private Sub Panel61_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel61.Paint

    End Sub

    Private Sub Panel60_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel60.Paint

    End Sub

    Private Sub Panel59_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel59.Paint

    End Sub

    Private Sub Label50_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label50.Click

    End Sub

    Private Sub TextBox31_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox31.TextChanged

    End Sub

    Private Sub Label33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label33.Click

    End Sub

    Private Sub TextBox27_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox27.TextChanged

    End Sub

    Private Sub Label31_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label31.Click

    End Sub

    Private Sub TextBox22_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox22.TextChanged

    End Sub

    Private Sub TextBox25_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox25.TextChanged

    End Sub

    Private Sub Label32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label32.Click

    End Sub

    Private Sub TextBox26_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox26.TextChanged

    End Sub

    Private Sub Label51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label51.Click

    End Sub

    Private Sub Label54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label54.Click

    End Sub

    Private Sub TextBox38_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox38.TextChanged

    End Sub

    Private Sub Label52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label52.Click

    End Sub

    Private Sub TextBox35_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox35.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged

    End Sub

    Private Sub Label53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label53.Click

    End Sub

    Private Sub TextBox36_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox36.TextChanged

    End Sub

    Private Sub Panel8_Paint_3(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel8.Paint

    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Main.Show()
        Me.Close()

    End Sub
End Class