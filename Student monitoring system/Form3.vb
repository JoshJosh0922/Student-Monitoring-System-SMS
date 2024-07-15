Imports System.Data.OleDb
Imports System.IO

Public Class frmCreate

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox7.Enabled = False
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

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Hide()
        studentclinic.Enabled = True
        studentclinic.BringToFront()
        main.Enabled = True
        main.BringToFront()
        AILSSH.Enabled = True
        AILSSH.BringToFront()
    End Sub
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim lr As String = TextBox3.Text
        conn.Open()
        If TextBox1.Text = "" Or TextBox2.Text = "" And TextBox3.Text = "" And ComboBox1.Text = "" And TextBox6.Text = "" Then
            MessageBox.Show("Please input")
        Else
            Try
                If TextBox1.Text > 0 Then
                    Try
                        Dim cmd As New OleDb.OleDbCommand("Insert into tblStudentinfo values ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & ComboBox1.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "') ", conn)
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Successfully save")
                        Me.Hide()
                        main.Enabled = True
                        main.BringToFront()
                        AILSSH.Enabled = True
                        AILSSH.BringToFront()
                        AILSSH.populate()
                        studentclinic.Enabled = True
                        studentclinic.datashow()
                        studentclinic.BringToFront()
                        Try
                            File.Copy(TextBox7.Text, "img\" & lr & ".jpg")
                        Catch ex As Exception
                            MessageBox.Show("Successfully save")
                            Me.Hide()
                            main.Enabled = True
                            main.BringToFront()
                            AILSSH.Enabled = True
                            AILSSH.BringToFront()
                            AILSSH.populate()
                            studentclinic.Enabled = True
                            studentclinic.datashow()
                            studentclinic.BringToFront()
                        End Try
                    Catch ex As Exception
                        MsgBox("LRN is already save.", MsgBoxStyle.Information)
                    End Try
                End If
            Catch ex As Exception
                MsgBox("Invalid LRN!")
            End Try
        End If
        conn.Close()
    End Sub
    Private Sub btnpic_Click(sender As Object, e As EventArgs) Handles btnpic.Click
        'End If
        If Windows.Forms.DialogResult.Cancel Then
            Try

                Dim df As New OpenFileDialog
                df.Title = "Open Image"
                df.Filter = "PNG Image|*.png|JPEG Image|*.jpg"
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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class