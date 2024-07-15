Public Class Form8

    Private Sub Form8_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form7.Enabled = True
        Form7.BringToFront()
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        disab()
    End Sub
    Sub disab()
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        TextBox7.Enabled = False
        TextBox11.Enabled = False
        TextBox8.Enabled = False
        TextBox9.Enabled = False
        TextBox10.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()

    End Sub
End Class