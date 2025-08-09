<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        CountToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        EmployeeToolStripMenuItem = New ToolStripMenuItem()
        AddEmployeeToolStripMenuItem = New ToolStripMenuItem()
        ResetToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        ClearToolStripMenuItem = New ToolStripMenuItem()
        SelectedEmployeeToolStripMenuItem = New ToolStripMenuItem()
        DepartmentToolStripMenuItem = New ToolStripMenuItem()
        AddDepartmentToolStripMenuItem = New ToolStripMenuItem()
        CountDepartmentsToolStripMenuItem = New ToolStripMenuItem()
        RemoveDepartmentToolStripMenuItem = New ToolStripMenuItem()
        RemoveAtDepartmentToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        NewEmployeeInGroupBox = New GroupBox()
        DepartmentComboBox = New ComboBox()
        TitleComboBox = New ComboBox()
        SalaryTextBox = New TextBox()
        EmployeeNameTextBox = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        SelectedEmployeeGroupBox = New GroupBox()
        EmployeeListBox = New ListBox()
        MenuStrip1.SuspendLayout()
        NewEmployeeInGroupBox.SuspendLayout()
        SelectedEmployeeGroupBox.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.ActiveCaption
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, EmployeeToolStripMenuItem, DepartmentToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(595, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CountToolStripMenuItem, ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(46, 24)
        FileToolStripMenuItem.Text = "&File"
        ' 
        ' CountToolStripMenuItem
        ' 
        CountToolStripMenuItem.Name = "CountToolStripMenuItem"
        CountToolStripMenuItem.Size = New Size(131, 26)
        CountToolStripMenuItem.Text = "&Count"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(131, 26)
        ExitToolStripMenuItem.Text = "E&xit"
        ' 
        ' EmployeeToolStripMenuItem
        ' 
        EmployeeToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AddEmployeeToolStripMenuItem, ResetToolStripMenuItem, ToolStripSeparator1, ClearToolStripMenuItem, SelectedEmployeeToolStripMenuItem})
        EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        EmployeeToolStripMenuItem.Size = New Size(89, 24)
        EmployeeToolStripMenuItem.Text = "&Employee"
        ' 
        ' AddEmployeeToolStripMenuItem
        ' 
        AddEmployeeToolStripMenuItem.Name = "AddEmployeeToolStripMenuItem"
        AddEmployeeToolStripMenuItem.Size = New Size(275, 26)
        AddEmployeeToolStripMenuItem.Text = "&Add Employee"
        ' 
        ' ResetToolStripMenuItem
        ' 
        ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        ResetToolStripMenuItem.Size = New Size(275, 26)
        ResetToolStripMenuItem.Text = "&Reset Employee"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(272, 6)
        ' 
        ' ClearToolStripMenuItem
        ' 
        ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        ClearToolStripMenuItem.Size = New Size(275, 26)
        ClearToolStripMenuItem.Text = "&Clear Employee List Display"
        ' 
        ' SelectedEmployeeToolStripMenuItem
        ' 
        SelectedEmployeeToolStripMenuItem.Name = "SelectedEmployeeToolStripMenuItem"
        SelectedEmployeeToolStripMenuItem.Size = New Size(275, 26)
        SelectedEmployeeToolStripMenuItem.Text = "&Selected Employee"
        ' 
        ' DepartmentToolStripMenuItem
        ' 
        DepartmentToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AddDepartmentToolStripMenuItem, CountDepartmentsToolStripMenuItem, RemoveDepartmentToolStripMenuItem, RemoveAtDepartmentToolStripMenuItem})
        DepartmentToolStripMenuItem.Name = "DepartmentToolStripMenuItem"
        DepartmentToolStripMenuItem.Size = New Size(103, 24)
        DepartmentToolStripMenuItem.Text = "&Department"
        ' 
        ' AddDepartmentToolStripMenuItem
        ' 
        AddDepartmentToolStripMenuItem.Name = "AddDepartmentToolStripMenuItem"
        AddDepartmentToolStripMenuItem.Size = New Size(249, 26)
        AddDepartmentToolStripMenuItem.Text = "&Add Department"
        ' 
        ' CountDepartmentsToolStripMenuItem
        ' 
        CountDepartmentsToolStripMenuItem.Name = "CountDepartmentsToolStripMenuItem"
        CountDepartmentsToolStripMenuItem.Size = New Size(249, 26)
        CountDepartmentsToolStripMenuItem.Text = "&Count Departments"
        ' 
        ' RemoveDepartmentToolStripMenuItem
        ' 
        RemoveDepartmentToolStripMenuItem.Name = "RemoveDepartmentToolStripMenuItem"
        RemoveDepartmentToolStripMenuItem.Size = New Size(249, 26)
        RemoveDepartmentToolStripMenuItem.Text = "&Remove Department"
        ' 
        ' RemoveAtDepartmentToolStripMenuItem
        ' 
        RemoveAtDepartmentToolStripMenuItem.Name = "RemoveAtDepartmentToolStripMenuItem"
        RemoveAtDepartmentToolStripMenuItem.Size = New Size(249, 26)
        RemoveAtDepartmentToolStripMenuItem.Text = "Remove &At Department"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AboutToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(55, 24)
        HelpToolStripMenuItem.Text = "&Help"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(133, 26)
        AboutToolStripMenuItem.Text = "&About"
        ' 
        ' NewEmployeeInGroupBox
        ' 
        NewEmployeeInGroupBox.Controls.Add(DepartmentComboBox)
        NewEmployeeInGroupBox.Controls.Add(TitleComboBox)
        NewEmployeeInGroupBox.Controls.Add(SalaryTextBox)
        NewEmployeeInGroupBox.Controls.Add(EmployeeNameTextBox)
        NewEmployeeInGroupBox.Controls.Add(Label4)
        NewEmployeeInGroupBox.Controls.Add(Label3)
        NewEmployeeInGroupBox.Controls.Add(Label2)
        NewEmployeeInGroupBox.Controls.Add(Label1)
        NewEmployeeInGroupBox.ForeColor = Color.Blue
        NewEmployeeInGroupBox.Location = New Point(12, 31)
        NewEmployeeInGroupBox.Name = "NewEmployeeInGroupBox"
        NewEmployeeInGroupBox.Size = New Size(565, 222)
        NewEmployeeInGroupBox.TabIndex = 1
        NewEmployeeInGroupBox.TabStop = False
        NewEmployeeInGroupBox.Text = "New Employee Information"
        ' 
        ' DepartmentComboBox
        ' 
        DepartmentComboBox.FormattingEnabled = True
        DepartmentComboBox.Items.AddRange(New Object() {"Accounting", "CMIS", "Economics & Finance", "Management & Marketing"})
        DepartmentComboBox.Location = New Point(134, 136)
        DepartmentComboBox.Name = "DepartmentComboBox"
        DepartmentComboBox.Size = New Size(408, 28)
        DepartmentComboBox.Sorted = True
        DepartmentComboBox.TabIndex = 12
        ' 
        ' TitleComboBox
        ' 
        TitleComboBox.FormattingEnabled = True
        TitleComboBox.Items.AddRange(New Object() {"Assistant Professor", "Associate Professor", "Lecturer", "Professor"})
        TitleComboBox.Location = New Point(134, 85)
        TitleComboBox.Name = "TitleComboBox"
        TitleComboBox.Size = New Size(408, 28)
        TitleComboBox.Sorted = True
        TitleComboBox.TabIndex = 11
        ' 
        ' SalaryTextBox
        ' 
        SalaryTextBox.Location = New Point(134, 186)
        SalaryTextBox.Name = "SalaryTextBox"
        SalaryTextBox.Size = New Size(214, 27)
        SalaryTextBox.TabIndex = 10
        ' 
        ' EmployeeNameTextBox
        ' 
        EmployeeNameTextBox.Location = New Point(134, 33)
        EmployeeNameTextBox.Name = "EmployeeNameTextBox"
        EmployeeNameTextBox.Size = New Size(408, 27)
        EmployeeNameTextBox.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.Black
        Label4.Location = New Point(6, 189)
        Label4.Name = "Label4"
        Label4.Size = New Size(102, 20)
        Label4.TabIndex = 6
        Label4.Text = "Annual Salary:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.Black
        Label3.Location = New Point(6, 136)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 20)
        Label3.TabIndex = 5
        Label3.Text = "Department:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.Black
        Label2.Location = New Point(6, 88)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 20)
        Label2.TabIndex = 4
        Label2.Text = "Title:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(6, 36)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 20)
        Label1.TabIndex = 3
        Label1.Text = "Employee Name:"
        ' 
        ' SelectedEmployeeGroupBox
        ' 
        SelectedEmployeeGroupBox.Controls.Add(EmployeeListBox)
        SelectedEmployeeGroupBox.ForeColor = Color.Blue
        SelectedEmployeeGroupBox.Location = New Point(12, 272)
        SelectedEmployeeGroupBox.Name = "SelectedEmployeeGroupBox"
        SelectedEmployeeGroupBox.Size = New Size(565, 129)
        SelectedEmployeeGroupBox.TabIndex = 2
        SelectedEmployeeGroupBox.TabStop = False
        SelectedEmployeeGroupBox.Text = "Selected Employee"
        ' 
        ' EmployeeListBox
        ' 
        EmployeeListBox.FormattingEnabled = True
        EmployeeListBox.Location = New Point(6, 19)
        EmployeeListBox.Name = "EmployeeListBox"
        EmployeeListBox.Size = New Size(553, 104)
        EmployeeListBox.Sorted = True
        EmployeeListBox.TabIndex = 13
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(595, 413)
        Controls.Add(SelectedEmployeeGroupBox)
        Controls.Add(NewEmployeeInGroupBox)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Form1"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        NewEmployeeInGroupBox.ResumeLayout(False)
        NewEmployeeInGroupBox.PerformLayout()
        SelectedEmployeeGroupBox.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DepartmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewEmployeeInGroupBox As GroupBox
    Friend WithEvents SelectedEmployeeGroupBox As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SalaryTextBox As TextBox
    Friend WithEvents EmployeeNameTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DepartmentComboBox As ComboBox
    Friend WithEvents TitleComboBox As ComboBox
    Friend WithEvents EmployeeListBox As ListBox
    Friend WithEvents CountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectedEmployeeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddDepartmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CountDepartmentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveDepartmentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveAtDepartmentToolStripMenuItem As ToolStripMenuItem

End Class
