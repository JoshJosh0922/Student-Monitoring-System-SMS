Imports System.Data.OleDb
Public Class Form6

    Dim maxnumber1 As Integer

    Private Sub Form6_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        studentclinic.Enabled = True
        studentclinic.BringToFront()
    End Sub
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        disab()
    End Sub
    Sub ne()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim cmd As New OleDbCommand("Select SNo from tblCnum", conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader
        dr.Read()
        TextBox8.Text = "No:" & Format(dr(0) + 1, "00#")
        maxnumber1 = dr(0) + 1
        conn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ne()
        conn.Open()

        Dim cmd As New OleDb.OleDbCommand("Insert into tblclinic values ('" & TextBox8.Text & "','" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "','" & TextBox6.Text & "','" & ComboBox1.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox7.Text & "') ", conn)
        cmd.ExecuteNonQuery()

        Dim cm As New OleDbCommand("Update tblCnum set SNo = '" & maxnumber1 & "'", conn)
        cm.ExecuteNonQuery()
        MessageBox.Show("Successfully save")
        Me.Dispose()

        conn.Close()
        studentclinic.Enabled = True
        studentclinic.BringToFront()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextBox9.Text = Date.Today
        TextBox10.Text = TimeOfDay
    End Sub
    Sub disab()
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        TextBox7.Enabled = False
        TextBox8.Enabled = False
        TextBox9.Enabled = False
        TextBox10.Enabled = False
    End Sub

    Private Sub ewan_Click(sender As Object, e As EventArgs)
        Me.Hide()

    End Sub
End Class