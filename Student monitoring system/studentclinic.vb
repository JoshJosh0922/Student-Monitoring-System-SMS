Imports System.Data.OleDb
Public Class studentclinic
    Dim search As String = "Select * from tblstudentinfo order by LRN"

    Private Sub studentclinic_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        main.Show()
    End Sub
    Private Sub studentclinic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        datashow()
        hak()
    End Sub
    Public Sub datashow()
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter(search, conn)
        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
        conn.Close()
    End Sub
    Sub hak()
        TextBox1.Enabled = False
        TextBox1.Text = ""
        ComboBox1.Text = ""
    End Sub
    Sub dog()
        If ComboBox1.Text <> "" Then
            TextBox1.Enabled = True
        End If
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If ComboBox1.Text <> "" Then
            search = "Select * from tblstudentinfo where " & ComboBox1.Text & " like '" & TextBox1.Text.Replace("'", "") & "%'"
            datashow()
        End If
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Dim f7 As New Form6
        f7.ne()
        f7.TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        f7.TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        f7.TextBox3.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        f7.TextBox4.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        f7.TextBox5.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        f7.TextBox6.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        f7.TextBox7.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        f7.PictureBox1.ImageLocation = DataGridView1.CurrentRow.Cells(6).Value.ToString
        Me.Enabled = False
        f7.Show()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Form7.datashow()
        Form7.bilang()
        Form7.Show()
        Form7.dub()
        hak()
        Me.Dispose()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        main.Show()
        Me.Dispose()
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        frmCreate.Show()
        frmCreate.enab()
        Me.Enabled = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        dog()
    End Sub

End Class