Imports System.Data.OleDb
Imports System.IO
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Core
Imports System.Xml.XPath
Imports System.Xml
Imports System.Linq
Imports System.Data
Imports System.Data.SqlClient
Public Class frmlist
    Dim search As String = "Select * from tbllatecomers order by Studentno "
    Dim lc As String
    Dim cun As String

    Private Sub frmlist_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        AILSSH.Show()
    End Sub
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datashow()
        dayday.Visible = False
        TextBox1.Enabled = False
        bilang()
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub
    Sub bilang()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        Dim count As Double
        conn.Open()
        cun = "SELECT COUNT(Studentno) from tbllatecomers"
        Dim cmd As New OleDbCommand(cun, conn)
        count = cmd.ExecuteScalar

        num.Text = "Numbers of Late: No." & count
        conn.Close()
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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If ComboBox1.Text <> "" Then
            search = "Select * from tbllatecomers where " & ComboBox1.Text & " like '" & TextBox1.Text.Replace("'", "") & "%'"
            'conn.Open()
            'Dim da As New OleDbDataAdapter("Select * from tbllatecomers order by " & TextBox1.Text & "", conn)
            'Dim dt As New DataTable
            'da.Fill(dt)
            'DataGridView1.DataSource = dt.AsDataView
            'conn.Close()
            datashow()
            num.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn.Open()
        Dim da As New OleDbDataAdapter("Select * from tbllatecomers where Day = '" & DateTimePicker1.Value.ToShortDateString & "'", conn)
        Dim ds As New DataSet
        da.Fill(ds, "tbllatecomers")
        DataGridView1.DataSource = ds.Tables("tbllatecomers")
        'datashow()
        conn.Close()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        AILSSH.Show()
        Me.Dispose()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        main.Show()
        Me.Dispose()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim da As New OleDbDataAdapter("Select * from tbllatecomers where Day between  '" & DateTimePicker2.Value.ToString & "' and '" & DateTimePicker3.Value.ToString & "'", conn)
        Dim dt As New DataTable
        da.Fill(dt) '"' and '" & DateTimePicker2.Value.Date &between
        DataGridView1.DataSource = dt
    End Sub
    Sub combo2()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.Open()
        Dim da As New OleDbDataAdapter("Select * from tbllatecomers order by LRN", conn)
        Dim dt As New DataTable
        da.Fill(dt)
        ComboBox2.Text = ""
        ComboBox2.DataSource = dt
        ComboBox2.ValueMember = "LRN"
        ComboBox2.DisplayMember = "Grade"
        conn.Close()
    End Sub

    Private Sub SearchByTwoDatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchByTwoDatesToolStripMenuItem.Click
        dayday.Visible = True
        dayday.Location = New Point(12, 186)
        dayday.Width = (422)
        dayday.Height = (50)
        day.Visible = False
    End Sub

    Private Sub SearchByOneDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchByOneDateToolStripMenuItem.Click
        dayday.Visible = False
        day.Visible = True
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Dim f7 As New Form5
        f7.TextBox9.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        f7.TextBox1.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        f7.TextBox2.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        f7.TextBox3.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        f7.TextBox4.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        f7.TextBox5.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        f7.TextBox6.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        f7.TextBox7.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString
        f7.TextBox8.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString
        f7.TextBox10.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString
        f7.PictureBox1.ImageLocation = DataGridView1.CurrentRow.Cells(9).Value.ToString
        Me.Enabled = False
        f7.Show()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        datashow()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        datashow()
    End Sub

    Private Sub DateTimePicker3_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker3.ValueChanged
        datashow()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox1.Enabled = True
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        'Dim cs As String = String.Empty
        'For Each column As DataGridViewColumn In DataGridView1.Columns
        '    cs = cs & column.HeaderText & ","
        'Next
        'cs = cs.TrimEnd(",")
        'cs = cs & vbCr & vbLf
        'For Each row As DataGridViewRow In DataGridView1.Rows
        '    For Each cel As DataGridViewCell In row.Cells
        '        cs = cs & cel.FormattedValue & ","
        '    Next
        '    cs = cs.TrimEnd(",")
        '    cs = cs & vbCr & vbLf
        'Next
        'lc = "C:\Users\JOSHUA O. LUCERNA\Desktop\Student monitoring"

        'My.Computer.FileSystem.WriteAllText(lc & ".csv", cs, True)
        'MsgBox("Successfuly save")

        SaveFileDialog1.Filter = "Excel Document (*.xlsx)|*.xlsx"
        If SaveFileDialog1.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            MsgBox("Please Wait...")
            Dim a As Microsoft.Office.Interop.Excel.Application
            Dim w As Microsoft.Office.Interop.Excel.Workbook
            Dim s As Microsoft.Office.Interop.Excel.Worksheet
            Dim o As Object = System.Reflection.Missing.Value

            Dim i As New Integer
            Dim j As New Integer

            a = New Microsoft.Office.Interop.Excel.Application
            w = a.Workbooks.Add(o)
            s = w.Sheets("sheet1")

            For i = 0 To DataGridView1.RowCount - 1
                For j = 0 To DataGridView1.ColumnCount - 1
                    For k As Integer = 1 To DataGridView1.Columns.Count
                        s.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
                        s.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString
                    Next

                Next
            Next

            s.SaveAs(SaveFileDialog1.FileName)
            w.Close()
            a.Quit()
            MsgBox("Successfully saved" & vbCrLf & "File are save at: " & SaveFileDialog1.FileName, MsgBoxStyle.Information, "Information")

        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        conn.Open()
        Dim da As New OleDbDataAdapter("Select * from tbllatecomers order by " & ComboBox2.Text & "", conn)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView1.DataSource = dt
        conn.Close()
    End Sub
    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            GroupBox2.Visible = True
            ComboBox2.Visible = True
            ComboBox2.Text = ""
        End If
        If CheckBox1.Checked = False Then
            ComboBox2.Visible = False
            GroupBox2.Visible = False
            GroupBox1.Visible = True
            'datashow()
            ComboBox2.Text = ""
        End If
    End Sub

End Class
