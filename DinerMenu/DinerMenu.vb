'Elliot Heiner
'RCET 0265
'Fall 2021
'Diner Menu Program
'https://github.com/heinelli/DinerMenu.git

Public Class DinerMenu
    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        DisplaySpecialLabel.Text = "Salada de Polvo"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        DisplaySpecialLabel.Text = "Caldo Verde"
    End Sub

    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        DisplaySpecialLabel.Text = "Bacalhau a Brás"
    End Sub
End Class

