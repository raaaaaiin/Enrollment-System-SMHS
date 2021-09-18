Imports MySql.Data.MySqlClient

Module sql
    Public SQLCON As MySqlConnection
    Public SQLCOM As MySqlCommand
    Public SQLREAD As MySqlDataReader
    Public SQLADPT As MySqlDataAdapter
    Public Sub CONNECTION()
        SQLCON = New MySqlConnection("SERVER=localhost;PORT=3306;DATABASE=enrollment_db;UID=root;PASSWORD=root")
        SQLCON.Open()
    End Sub


    Public Sub Color(ByVal A As System.Windows.Forms.PaintEventArgs)
        ControlPaint.DrawBorder(A.Graphics, A.ClipRectangle, Drawing.Color.Black, ButtonBorderStyle.Solid)
    End Sub

End Module
