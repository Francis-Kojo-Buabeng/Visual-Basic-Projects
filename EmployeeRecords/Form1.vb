Public Class Form1
    Private Sub DepartmentComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DepartmentComboBox.SelectedIndexChanged

    End Sub

    Private Sub AddDepartmentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddDepartmentToolStripMenuItem.Click
        If DepartmentComboBox.Text <> String.Empty Then
            DepartmentComboBox.Items.Add(DepartmentComboBox.Text)
            DepartmentComboBox.Text = ""
        Else
            MessageBox.Show("You must type a new department name.", "Name Missing Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DepartmentComboBox.Focus()
        End If
    End Sub

    Private Sub AddEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddEmployeeToolStripMenuItem.Click
        'Build the string to add
        Dim NewEmployeeString As String
        NewEmployeeString = EmployeeNameTextBox.Text & ", " &
            TitleComboBox.Text & ", " &
            DepartmentComboBox.Text & ", " &
            SalaryTextBox.Text

        'Add string to ListBox
        EmployeeListBox.Items.Add(NewEmployeeString)

        'Clear the form - ready to add another employee
        EmployeeNameTextBox.Clear()
        TitleComboBox.Text = ""
        TitleComboBox.SelectedIndex = -1
        DepartmentComboBox.SelectedIndex = -1
        SalaryTextBox.Text = ""
        EmployeeNameTextBox.Focus()
    End Sub
End Class
