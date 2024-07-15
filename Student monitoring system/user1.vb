Imports System.Data.OleDb
Public Class user1

    Private Sub user1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        enub()
    End Sub
    Sub enub()
        rb1.Checked = False
        rb2.Checked = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox1.Enabled = False
        TextBox2.Enabled = False
    End Sub
    Private Sub c1_Click(sender As Object, e As EventArgs) Handles c1.Click
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        Try
            If TextBox1.Text <> "" Or TextBox2.Text <> "" Then
                conn.Open()
                Dim cmd3 As New OleDbCommand("Select * from tblclinpas where [User] = '" & TextBox1.Text & "'", conn)
                Dim dr3 As OleDbDataReader = cmd3.ExecuteReader

                Dim userfound3 As Boolean = False
                While dr3.Read
                    userfound3 = True
                End While
                conn.Close()
                If userfound3 = True Then
                    MsgBox("User name has all ready save")
                Else
                    If rb2.Checked = True Then

                        conn.Open()
                        Dim cmd As New OleDb.OleDbCommand("Insert into tblclinpas values ('" & TextBox1.Text & "','" & TextBox2.Text & "') ", conn)
                        cmd.ExecuteNonQuery()
                        conn.Close()
                        MsgBox("Successfuly Save")
                        Me.Hide()
                        main.Enabled = True
                        main.BringToFront()
                    End If
                End If
                '--------------------------------------------
                conn.Open()
                Dim cmd2 As New OleDbCommand("Select * from tbllatecom where [User] = '" & TextBox1.Text & "'", conn)
                Dim dr2 As OleDbDataReader = cmd2.ExecuteReader

                Dim userfound2 As Boolean = False
                While dr2.Read
                    userfound2 = True
                End While
                conn.Close()
                If userfound2 = True Then
                    MsgBox("User name has all ready save")
                Else
                    If rb1.Checked = True Then
                        conn.Open()
                        Dim cmd As New OleDb.OleDbCommand("Insert into tbllatecom values ('" & TextBox1.Text & "','" & TextBox2.Text & "') ", conn)
                        cmd.ExecuteNonQuery()
                        conn.Close()
                        MsgBox("Successfuly Save")
                        Me.Hide()
                        main.Enabled = True
                        main.BringToFront()

                    End If
                End If
                

            Else
                MsgBox("Please Input Username or Password", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox("Password is alredy save")
        End Try
    End Sub

    Private Sub c2_Click(sender As Object, e As EventArgs) Handles c2.Click
        Me.Hide()
        main.Enabled = True
        main.BringToFront()
    End Sub

    Private Sub TextBox2_Enter(sender As Object, e As EventArgs) Handles TextBox2.Enter
        TextBox2.UseSystemPasswordChar = True
    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles TextBox2.Leave
        If TextBox2.Text < "" Then
            TextBox2.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.UseSystemPasswordChar = False
        End If
        If CheckBox1.Checked = False Then
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub


    Private Sub rb1_CheckedChanged(sender As Object, e As EventArgs) Handles rb1.CheckedChanged
        TextBox2.Enabled = True
        TextBox1.Enabled = True
    End Sub

    Private Sub rb2_CheckedChanged(sender As Object, e As EventArgs) Handles rb2.CheckedChanged
        TextBox2.Enabled = True
        TextBox1.Enabled = True
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text <> "" Then
            CheckBox1.Enabled = True
        Else
            CheckBox1.Enabled = False
        End If
    End Sub
End Class