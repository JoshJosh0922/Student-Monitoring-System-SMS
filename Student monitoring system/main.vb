Imports System.Data.OleDb
Public Class main

    Private Sub main_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        LoginForm1.Show()
    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Enabled = False
        TextBox2.Enabled = False
        enab()
        admins()
    End Sub
    Sub enab()
        late1.Visible = False
        late2.Visible = False
        clini1.Visible = False
        visit.Visible = False
        time444.Visible = False
        cp.Visible = False
        su.Visible = False
    End Sub
    Sub adm()
        late1.Visible = True
        late2.Visible = True
        clini1.Visible = True
        visit.Visible = True
        time444.Visible = True
        cp.Visible = True
        su.Visible = True
    End Sub
    Sub clin()
        clini1.Visible = True
        visit.Visible = True

        late1.Visible = False
        late2.Visible = False
        time444.Visible = False
        cp.Visible = False
        su.Visible = False
    End Sub
    Sub late()
        late1.Visible = True
        late2.Visible = True


        clini1.Visible = False
        visit.Visible = False
        time444.Visible = False
        cp.Visible = False
        su.Visible = False
    End Sub

    Sub admins()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If

        conn.Open()
        Dim cmd As New OleDbCommand("Select * from tblpas where [User] = '" & TextBox3.Text & "'", conn)
        Dim dr As OleDbDataReader = cmd.ExecuteReader

        Dim userfound As Boolean = False
        While dr.Read
            userfound = True
        End While
        If userfound = True Then
            adm()
        End If
        conn.Close()

        conn.Open()
        Dim cmd2 As New OleDbCommand("Select * from tblclinpas where [User] = '" & TextBox3.Text & "'", conn)
        Dim dr2 As OleDbDataReader = cmd2.ExecuteReader

        Dim userfound2 As Boolean = False
        While dr2.Read
            userfound2 = True
        End While
        If userfound2 = True Then
            clin()
        End If
        conn.Close()

        conn.Open()
        Dim cmd3 As New OleDbCommand("Select * from tbllatecom where [User] = '" & TextBox3.Text & "'", conn)
        Dim dr3 As OleDbDataReader = cmd3.ExecuteReader

        Dim userfound3 As Boolean = False
        While dr3.Read
            userfound3 = True
        End While
        If userfound3 = True Then
            late()
        End If
        conn.Close()
    End Sub
    Private Sub AttendanceForIncomingLateStudentsForSeniorHighToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles late1.Click
        Me.Hide()
        AILSSH.Label1.Text = TextBox3.Text
        AILSSH.ref()
        AILSSH.populate()
        AILSSH.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextBox1.Text = Date.Today
        TextBox2.Text = TimeOfDay
    End Sub

    Private Sub AddNewStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewStudentToolStripMenuItem.Click
        Me.Enabled = False
        frmCreate.Show()
        frmCreate.enab()
    End Sub

    Private Sub ListOfLateCommersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles late2.Click
        frmlist.bilang()
        Me.Hide()
        frmlist.Show()
        frmlist.datashow()
    End Sub
    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click


    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        Me.Enabled = False
        f8program.Show()
    End Sub

    Private Sub AboutUsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem1.Click
        f7creqte.Show()
        Me.Enabled = False
    End Sub

    'Private Sub AdjustTimeAndDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdjustTimeAndDateToolStripMenuItem.Click
    '    Shell("runll32.exe shell32.dll, Control_RunDLL timedate.cpl")
    'End Sub

    Private Sub AdjustTimmeAndDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles time444.Click
        Shell("rundll32.exe shell32.dll, Control_RunDLL timedate.cpl")
    End Sub

    Private Sub StudentMonitoringToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles clini1.Click
        studentclinic.datashow()
        studentclinic.Show()
        studentclinic.hak()
        Me.Hide()
    End Sub

    Private Sub SHSOutTimeToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Form7.Show()
        Form7.datashow()
    End Sub

    Private Sub StudentFormFoClinicToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles visit.Click
        SHS.datashow()
        SHS.bilang()
        SHS.Show()
        Me.Hide()
    End Sub

    Private Sub ListOfVisitorLeaveToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Me.Hide()
        listofvisitor.bilang()
        listofvisitor.datashow()
        listofvisitor.Show()
    End Sub

    Private Sub PeopleBehindOurStudyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PeopleBehindOurStudyToolStripMenuItem.Click
        frmbehind.Show()
        Me.Enabled = False
    End Sub

    Private Sub LogoutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles su.Click
        user1.Show()
        user1.enub()
        Me.Enabled = False
    End Sub

    Private Sub ChangePasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles cp.Click
        jo()
        changepass.Show()
        changepass.datashow()
        changepass.datashow2()
        Me.Enabled = False
    End Sub
    Public Sub jo()
        changepass.TextBox5.Text = TextBox3.Text
    End Sub

    Private Sub LogOutToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem2.Click
        If MsgBox("Are you sure you want to log-out?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.Close()
            TextBox3.Text = ""
            LoginForm1.Show()
            LoginForm1.BringToFront()
        End If
    End Sub
End Class