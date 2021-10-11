'Elliot Heiner
'RCET 0265
'Fall 2021
'Diner Menu Program
'https://github.com/heinelli/DinerMenu.git

Option Explicit On
Option Strict On

'Each button displays the appropriate text when clicked.
Public Class DinerMenuForm
    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        DisplaySpecialLabel.Text = "*Salada de Polvo*
Octopus salad."
    End Sub

    'generated stubs won't auto update Sub name - TJR
    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        DisplaySpecialLabel.Text = "*Caldo Verde*
Creamy Portuguese soup made of potatoes, green collards, and chorizo."
    End Sub

    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        DisplaySpecialLabel.Text = "*Bacalhau a Brás*
Shards of salted cod mixed with scrambled eggs and fried potatoes."
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class

