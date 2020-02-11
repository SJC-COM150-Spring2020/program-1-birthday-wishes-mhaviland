Public Class birthdaywishes

    Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click

        'Print Happy Birthday to listbox
        lstOut.Items.Add("Happy Birthday to you!")
        lstOut.Items.Add("Happy Birthday to you!")
        lstOut.Items.Add("Happy Birthday!")
        lstOut.Items.Add("Happy Birthday!")
        lstOut.Items.Add("Happy Birthday to you!")
        lstOut.Items.Add("Happy Birthday " & txtName.Text)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear txtName value
        txtName.Clear()
        lstOut.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'when user exits the program
        Beep()
        Application.Exit()

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'when user enters the program

    End Sub
End Class
