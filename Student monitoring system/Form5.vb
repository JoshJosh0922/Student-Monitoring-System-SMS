Imports System.Data.OleDb
Public Class Form5
    Dim maxnumber As Integer

    Private Sub Form5_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frmlist.Enabled = True
        frmlist.BringToFront()
    End Sub
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        disable()
    End Sub
    Sub disable()
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
    'Sub generateEmpId()
    '    conn.Open()
    '    Dim cmd As New OleDbCommand("Select StudentNo from tblnumber", conn)
    '    Dim dr As OleDbDataReader = cmd.ExecuteReader
    '    dr.Read()
    '    TextBox9.Text = "No:" & Format(dr(0) - 1, "00#")
    '    maxnumber = dr(0) - 1
    '    conn.Close()
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Hide()
        frmlist.Enabled = True
        frmlist.BringToFront()
    End Sub
End Class