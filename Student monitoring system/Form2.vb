Imports System.Data.OleDb
Public Class Form2
    Dim maxnumber As Integer

    Private Sub Form2_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        AILSSH.Enabled = True
        AILSSH.BringToFront()
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        disable()
    End Sub
    Private Sub btnlate_Click(sender As Object, e As EventArgs) Handles btnlate.Click
        generateEmpId()
        conn.Open()

        Dim cmd As New OleDb.OleDbCommand("Insert into tbllatecomers values ('" & TextBox9.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox10.Text & "') ", conn)
        cmd.ExecuteNonQuery()

        MessageBox.Show("Successfully save")

        Dim cm As New OleDbCommand("Update tblnumber set StudentNo = '" & maxnumber & "'", conn)
        cm.ExecuteNonQuery()

        AILSSH.Enabled = True
        Me.Dispose()
        AILSSH.BringToFront()
        conn.Close()
    End Sub
    Sub generateEmpId()
        conn.Open()
        Dim cmd As New OleDbCommand("Select StudentNo from tblnumber", conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        dr.Read()
        TextBox9.Text = "No:" & Format(dr(0) + 1, "00#")
        maxnumber = dr(0) + 1
        conn.Close()
    End Sub
    Sub disable()
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        TextBox9.Enabled = False
        TextBox10.Enabled = False
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextBox7.Text = Date.Today
        TextBox8.Text = TimeOfDay
    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        AILSSH.Enabled = True
        AILSSH.BringToFront()
    End Sub
End Class