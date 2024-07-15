Imports System.Data.OleDb
Imports System.IO
Public Class Form10

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox7.Enabled = False
        TextBox1.Enabled = False
        If Not Directory.Exists("img") Then
            Directory.CreateDirectory("img")
        End If
    End Sub
    Sub enab()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        PictureBox1.Image = Nothing
    End Sub
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim lr As String = TextBox1.Text
        conn.Open()
        If TextBox1.Text = "" And TextBox2.Text = "" And TextBox3.Text = "" And TextBox4.Text = "" And ComboBox1.Text = "" And TextBox6.Text = "" Then
            MessageBox.Show("Please input")
        Else
            
            Try
                If TextBox1.Text > 0 Then
                    Dim ako As New OleDbCommand("Delete from tblstudentinfo where LRN = '" & TextBox1.Text & "'", conn)
                    ako.ExecuteNonQuery()
                    Try
                        Dim cmd As New OleDb.OleDbCommand("Insert into tblstudentinfo values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & ComboBox1.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "') ", conn)
                        cmd.ExecuteNonQuery()
                        File.Copy(TextBox7.Text, "img\" & lr & ".jpg")

                    Catch s As Exception
                        MessageBox.Show("Successfully save")
                        AILSSH.populate()
                        Me.Hide()
                        AILSSH.Enabled = True
                        AILSSH.BringToFront()
                    End Try
                End If
                conn.Close()
            Catch s As Exception
                MsgBox("Invalid LRN", MsgBoxStyle.Exclamation)
            End Try
        End If
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Hide()
        AILSSH.Enabled = True
        AILSSH.BringToFront()
    End Sub

    Private Sub btnpic_Click(sender As Object, e As EventArgs) Handles btnpic.Click
        If Windows.Forms.DialogResult.Cancel Then
            Try

                Dim df As New OpenFileDialog
                df.ShowDialog()
                PictureBox1.Image = Image.FromFile(df.FileName)
                TextBox7.Text = df.FileName
            Catch ex As Exception
                MsgBox("You cancel your uploading")
            End Try
        Else
            MsgBox(MsgBoxStyle.OkOnly)
        End If
    End Sub
End Class