<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.late1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.late2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.clini1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.visit = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.time444 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutUsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutUsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PeopleBehindOurStudyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cp = New System.Windows.Forms.ToolStripMenuItem()
        Me.su = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(19, 19)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormToolStripMenuItem, Me.AddNewStudentToolStripMenuItem, Me.time444, Me.AboutToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1233, 25)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FormToolStripMenuItem
        '
        Me.FormToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.late1, Me.late2, Me.clini1, Me.visit})
        Me.FormToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormToolStripMenuItem.Name = "FormToolStripMenuItem"
        Me.FormToolStripMenuItem.Size = New System.Drawing.Size(130, 21)
        Me.FormToolStripMenuItem.Text = "Monitoring System"
        '
        'late1
        '
        Me.late1.Name = "late1"
        Me.late1.Size = New System.Drawing.Size(246, 22)
        Me.late1.Text = "Student Information"
        '
        'late2
        '
        Me.late2.Name = "late2"
        Me.late2.Size = New System.Drawing.Size(246, 22)
        Me.late2.Text = "List of Latecomers"
        '
        'clini1
        '
        Me.clini1.Name = "clini1"
        Me.clini1.Size = New System.Drawing.Size(246, 22)
        Me.clini1.Text = "Student Information for Clinic"
        '
        'visit
        '
        Me.visit.Name = "visit"
        Me.visit.Size = New System.Drawing.Size(246, 22)
        Me.visit.Text = "List of Visitors In"
        '
        'AddNewStudentToolStripMenuItem
        '
        Me.AddNewStudentToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddNewStudentToolStripMenuItem.Name = "AddNewStudentToolStripMenuItem"
        Me.AddNewStudentToolStripMenuItem.Size = New System.Drawing.Size(122, 21)
        Me.AddNewStudentToolStripMenuItem.Text = "Add New Student"
        '
        'time444
        '
        Me.time444.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time444.Name = "time444"
        Me.time444.Size = New System.Drawing.Size(145, 21)
        Me.time444.Text = "Adjust Time and Date"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutUsToolStripMenuItem, Me.AboutUsToolStripMenuItem1, Me.PeopleBehindOurStudyToolStripMenuItem})
        Me.AboutToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(55, 21)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'AboutUsToolStripMenuItem
        '
        Me.AboutUsToolStripMenuItem.Name = "AboutUsToolStripMenuItem"
        Me.AboutUsToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.AboutUsToolStripMenuItem.Text = "About the program"
        '
        'AboutUsToolStripMenuItem1
        '
        Me.AboutUsToolStripMenuItem1.Name = "AboutUsToolStripMenuItem1"
        Me.AboutUsToolStripMenuItem1.Size = New System.Drawing.Size(219, 22)
        Me.AboutUsToolStripMenuItem1.Text = "About Creator"
        '
        'PeopleBehindOurStudyToolStripMenuItem
        '
        Me.PeopleBehindOurStudyToolStripMenuItem.Name = "PeopleBehindOurStudyToolStripMenuItem"
        Me.PeopleBehindOurStudyToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.PeopleBehindOurStudyToolStripMenuItem.Text = "People behind our study"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cp, Me.su, Me.LogOutToolStripMenuItem2})
        Me.LogOutToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(60, 21)
        Me.LogOutToolStripMenuItem.Text = "Setting"
        '
        'cp
        '
        Me.cp.Name = "cp"
        Me.cp.Size = New System.Drawing.Size(180, 22)
        Me.cp.Text = "Change Password"
        '
        'su
        '
        Me.su.Name = "su"
        Me.su.Size = New System.Drawing.Size(180, 22)
        Me.su.Text = "Sign up new User"
        '
        'LogOutToolStripMenuItem2
        '
        Me.LogOutToolStripMenuItem2.Name = "LogOutToolStripMenuItem2"
        Me.LogOutToolStripMenuItem2.Size = New System.Drawing.Size(180, 22)
        Me.LogOutToolStripMenuItem2.Text = "Log Out"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(13, 632)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(101, 26)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(120, 632)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(102, 26)
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(1097, 27)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(124, 31)
        Me.TextBox3.TabIndex = 6
        Me.TextBox3.Text = "Admin"
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(989, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 24)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Username:"
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1233, 670)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "main"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Form"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents late1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewStudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents time444 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutUsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutUsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents clini1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents late2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents visit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PeopleBehindOurStudyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents su As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
