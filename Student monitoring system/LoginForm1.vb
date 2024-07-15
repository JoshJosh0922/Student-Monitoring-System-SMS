Imports System.Data.OleDb
Public Class LoginForm1

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles Textbox1.Enter
        If Textbox1.Text = "User" Then
            Textbox1.Text = ""
        End If
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles Textbox1.Leave
        If Textbox1.Text = "" Then
            Textbox1.Text = "User"
        End If
    End Sub

    Private Sub TextBox2_Enter(sender As Object, e As EventArgs) Handles Textbox2.Enter
        If Textbox2.Text = "Password" Then
            Textbox2.Text = ""
            Textbox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles Textbox2.Leave
        If Textbox2.Text = "" Then
            Textbox2.Text = "Password"
            Textbox2.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'If Textbox1.Text = users And Textbox2.Text = "Password" Then
        '    MsgBox("Successfully Login")
        '    SplashScreen1.Show()
        '    Me.Hide()
        'Else
        '    MsgBox("Access denied")
        'End If
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        conn.Open()
        Dim cmd As New OleDbCommand("Select * from tblpas where [User] = '" & Textbox1.Text & "' and [Pass] = '" & Textbox2.Text & "'", conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader

        Dim userfound As Boolean = False

        While dr.Read
            userfound = True
        End While
        conn.Close()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim cmd3 As New OleDbCommand("Select * from tbllatecom where [User] = '" & Textbox1.Text & "' and [Pass] = '" & Textbox2.Text & "'", conn)
        Dim dr3 As OleDbDataReader = cmd3.ExecuteReader

        Dim userfound3 As Boolean = False
        While dr3.Read
            userfound3 = True
        End While
        conn.Close()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim cmd2 As New OleDbCommand("Select * from tblclinpas where [User] = '" & Textbox1.Text & "' and [Pass] = '" & Textbox2.Text & "'", conn)
        Dim dr2 As OleDbDataReader = cmd2.ExecuteReader

        Dim userfound2 As Boolean = False
        While dr2.Read
            userfound2 = True
        End While
        conn.Close()


        If userfound = True Or userfound2 = True Or userfound3 = True Then
            changepass.TextBox5.Text = Textbox1.Text
            main.TextBox3.Text = Textbox1.Text
            AILSSH.Label1.Text = Textbox1.Text
            SplashScreen1.Show()
            Me.Close()
        Else
            MsgBox("Access Denied!")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
