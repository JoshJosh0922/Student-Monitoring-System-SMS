Imports System.Data.OleDb
Public Class AILSSH

    Dim search As String = "Select * from tblstudentinfo order by LRN"

    Private Sub AILSSH_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        main.Show()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        del.Enabled = False
        ToolStripButton4.Enabled = False
        populate()
        TextBox1.Enabled = False
        u()
    End Sub
    Public Sub u()
        conn.Open()
        Dim cmd As New OleDbCommand("Select * from tblpas where [User] = '" & Label1.Text & "'", conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader

        Dim userfound As Boolean = False
        While dr.Read
            userfound = True
        End While
        If userfound = True Then
            del.Visible = True
        End If
        conn.Close()
    End Sub
    Sub ref()
        ComboBox1.Text = ""
        TextBox1.Text = ""
        TextBox1.Enabled = False
        populate()
    End Sub

    Sub populate()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        ListView1.Items.Clear()
        Dim cmd As New OleDbCommand(search, conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader

        While dr.Read
            Dim lv As New ListViewItem
            ListView1.Items.Add(lv)
            lv.Text = dr(0)
            lv.SubItems.Add(dr(1))
            lv.SubItems.Add(dr(2))
            lv.SubItems.Add(dr(3))
            lv.SubItems.Add(dr(4))
            lv.SubItems.Add(dr(5))
        End While
        conn.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If ComboBox1.Text <> "" Then
            search = "Select * from tblstudentinfo where " & ComboBox1.Text & " like '" & TextBox1.Text.Replace("'", "") & "%'"
            populate()
        End If
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        main.Show()
        Me.Dispose()
    End Sub

    Private Sub ToolStripButton2_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        frmlist.Show()
        frmlist.datashow()
        Me.Dispose()
        frmlist.bilang()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox1.Enabled = True
    End Sub
    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListView1_DoubleClick_1(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        Form2.generateEmpId()
        conn.Open()

        Dim i As New Integer
        For i = 0 To ListView1.Items.Count - 1

            If ListView1.Items(i).Selected = True Then
                Dim cmd As New OleDbCommand("Select * from tblstudentinfo where LRN = '" & ListView1.Items(i).Text & "'", conn)
                Dim dr As OleDbDataReader = cmd.ExecuteReader
                While dr.Read
                    Form2.TextBox1.Text = dr(0)
                    Form2.TextBox2.Text = dr(1)
                    Form2.TextBox3.Text = dr(2)
                    Form2.TextBox4.Text = dr(3)
                    Form2.TextBox5.Text = dr(4)
                    Form2.TextBox6.Text = dr(5)
                    Form2.TextBox10.Text = dr(6)
                    Form2.PictureBox1.ImageLocation = dr(6)
                    Form2.Show()
                End While
            End If
        Next
        conn.Close()
        Me.Enabled = False

    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        frmCreate.Show()
        frmCreate.enab()
        Me.Enabled = False
    End Sub
    Private Sub ListView1_Click(sender As Object, e As EventArgs) Handles ListView1.Click
        del1()
        ed1()
    End Sub

    Sub del1()
        ToolStripButton4.Enabled = True
        del.Enabled = True
    End Sub
    Sub del2()
        ToolStripButton4.Enabled = False
        del.Enabled = False
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        ed()
        Me.Enabled = False
    End Sub
    Sub ed()
        conn.Open()
        Dim s As New Integer
        For s = 0 To ListView1.Items.Count - 1
            If ListView1.Items(s).Selected = True Then
                Dim cmd As New OleDbCommand("Select * from tblstudentinfo where LRN = '" & ListView1.Items(s).Text & "'", conn)
                Dim dr As OleDbDataReader = cmd.ExecuteReader
                While dr.Read
                    Dim d As New Form10
                    d.TextBox1.Text = dr(0)
                    d.TextBox2.Text = dr(1)
                    d.TextBox3.Text = dr(2)
                    d.TextBox4.Text = dr(3)
                    d.ComboBox1.Text = dr(4)
                    d.TextBox6.Text = dr(5)
                    d.TextBox7.Text = dr(6)
                    d.PictureBox1.ImageLocation = dr(6)
                    d.Show()
                    Me.Enabled = False
                End While
            End If
        Next
        conn.Close()
    End Sub
    Sub ed1()
        conn.Open()
        Dim s As New Integer
        For s = 0 To ListView1.Items.Count - 1
            If ListView1.Items(s).Selected = True Then
                Dim cmd As New OleDbCommand("Select * from tblstudentinfo where LRN = '" & ListView1.Items(s).Text & "'", conn)
                Dim dr As OleDbDataReader = cmd.ExecuteReader
                While dr.Read
                    Dim d As New Form10
                    Label2.Text = dr(0)
                End While
            End If
        Next
        conn.Close()
    End Sub

    Private Sub del_Click(sender As Object, e As EventArgs) Handles del.Click
        If MsgBox("Are you sure you want to Delete the selected info?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            conn.Open()
            Dim ako As New OleDbCommand("Delete from tblstudentinfo where LRN = '" & Label2.Text & "'", conn)
            ako.ExecuteNonQuery()
            conn.Close()
            MsgBox("Successfully Delete")
            populate()
            del2()
        End If
    End Sub
    Private Sub ListView1_SelectedIndexChanged_1(sender As Object, e As EventArgs)
        ed1()
    End Sub

    Private Sub ListView1_Leave(sender As Object, e As EventArgs) Handles ListView1.Leave, ListView1.SelectedIndexChanged
        ToolStripButton4.Enabled = False
    End Sub
End Class
