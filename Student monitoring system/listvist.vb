Imports System.Data.OleDb
Imports System.IO
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Core
'Imports System.Xml.XPath
'Imports System.Xml
'Imports System.Linq
'Imports System.Data
'Imports System.Data.SqlClient
Public Class listofvisitor
    Dim cun As String
    Dim lc As String
    Dim dat As String = "Select * from tblvl order by VisitorsNo"

    Private Sub listofvisitor_MaximizedBoundsChanged(sender As Object, e As EventArgs) Handles Me.MaximizedBoundsChanged

    End Sub
    Private Sub listofvisitor_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        SHS.Show()
    End Sub
    Private Sub listvist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Enabled = False
        bilang()
        datashow()
        enab()
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub
    Sub bilang()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        Dim count As Double
        conn.Open()
        cun = "SELECT COUNT(No) from tblvl"
        Dim cmd As New OleDbCommand(cun, conn)
        count = cmd.ExecuteScalar

        num.Text = "Numbers of Student: No." & count
        conn.Close()
    End Sub
    Sub datashow()
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter(dat, conn)
        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
        conn.Close()
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        'Dim dt As New OleDbDataAdapter
        'Dim dc As New OleDbConnection
        'Dim ds As New DataSet
        'Dim ex As String
        'Dim filed As New OpenFileDialog

        'filed.FileName = ""
        'filed.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        'filed.Filter = "All Files (*.*)|*.*|Excel files (*.xlsx)|*.xlsx|CSV files (*.csv)|*.csv|XLS Files (*.xls)|*.xls"

        'If (filed.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
        '    DataGridView1.Columns.Clear()

        '    Dim fl As New FileInfo(filed.FileName)
        '    Dim fn As String = filed.FileName
        '    ex = fl.FullName
        '    dc = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source" & ex & ";Extended Properties=Excel 12.0")
        '    dt = New OleDbDataAdapter("Select * From[Sheetl$]", dc)
        '    ds = New DataSet
        '    dt.Fill(ds, "[Sheetl$]")
        '    DataGridView1.DataSource = dt
        '    DataGridView1.DataMember = "[Sheetl$]"
        '    dc.Close()
        'End If
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

    Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
        TextBox2.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        id.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        TextBox6.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        TextBox3.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        tme.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        dte.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        TextBox7.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
    End Sub
    Sub enab()
        id.Enabled = False
        TextBox2.Enabled = False
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        TextBox6.Enabled = False
        TextBox7.Enabled = False
        tme.Enabled = False
        dte.Enabled = False
        id.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox6.Text = ""
        dayday.Visible = False
        TextBox7.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn.Open()
        Dim da As New OleDbDataAdapter("Select * from tblvl where Date = '" & DateTimePicker1.Value.ToShortDateString & "'", conn)
        Dim ds As New DataSet
        da.Fill(ds, "tblvl")
        DataGridView1.DataSource = ds.Tables("tblvl")
        'datashow()
        conn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim da As New OleDbDataAdapter("Select * from tblvl where Date between  '" & DateTimePicker2.Value.ToString & "' and '" & DateTimePicker3.Value.ToString & "'", conn)
        Dim dt As New DataTable
        da.Fill(dt) '"' and '" & DateTimePicker2.Value.Date &between
        DataGridView1.DataSource = dt
    End Sub

    Private Sub SearchByOneDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchByOneDateToolStripMenuItem.Click
        dayday.Visible = False
        day.Visible = True
    End Sub

    Private Sub SearchByTwoDatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchByTwoDatesToolStripMenuItem.Click
        dayday.Visible = True
        dayday.Location = New Point(12, 119)
        dayday.Width = (420)
        dayday.Height = (50)
        day.Visible = False
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If ComboBox1.Text <> "" Then
            dat = "Select * from tblvl where " & ComboBox1.Text & " like '" & TextBox1.Text.Replace("'", "") & "%'"
            datashow()
            num.Visible = False
        End If

        If TextBox1.Text < " " Then
            num.Visible = True
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        main.Show()
        Me.Dispose()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        SHS.Show()
        Me.Dispose()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text <> "" Then
            TextBox1.Enabled = True
        End If
    End Sub
End Class