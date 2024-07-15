Imports System.Data.OleDb
Public Class Form9

    Private Sub Form9_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        SHS.Enabled = True
        SHS.BringToFront()
    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox6.Text = "Yes"

        enab()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("Insert into tblvl values ('" & TextBox1.Text & "','" & id.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & dte.Text & "','" & tme.Text & "','" & TextBox6.Text & "') ", conn)
            cmd.ExecuteNonQuery()
            conn.Close()
            Me.Hide()
            SHS.Enabled = True
            SHS.BringToFront()
            listofvisitor.datashow()
        Catch ex As Exception
            MsgBox("All Ready Submited")
            Me.Hide()
            SHS.Enabled = True
            SHS.BringToFront()
        End Try
    End Sub
    Sub enab()
        id.Enabled = False
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox6.Enabled = False
        dte.Enabled = False
        tme.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Hide()
        SHS.Enabled = True
        SHS.BringToFront()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        dte.Text = Date.Today
        tme.Text = TimeOfDay
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class