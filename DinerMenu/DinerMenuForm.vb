'Jake Burrell
'RCET0265
'Spring 2020
'Diner Menu Program
'https://github.com/burrjake/JDB-VS-S20

Public Class DinerMenuForm
    'The cancel button is the Exit button which is also connected to x
    'The accept button is the Soup button

    'The Exit button if clicked closes the program
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    'When the Soup, Salad, or Fish button is pushed the specified text appears
    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        SpecialNameLabel.Text = "~Soup of the Day~"
        DisplaySpecialLabel.Text = "La soupe da jour"
    End Sub

    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        SpecialNameLabel.Text = "~Special Foster's Salad~"
        DisplaySpecialLabel.Text = "We begin with a sping of the finest Australian parsley hand selecteded by our head chef's sister-in-law. Premium parsley is plated on a bed of grilled to order T-bone steak and finally garnished with an ice cold can of Foster's."
    End Sub

    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        SpecialNameLabel.Text = "~Fresh, Fresher, Freshest Fish~"
        DisplaySpecialLabel.Text = "Do you like fresh fish? It's just fine at Finney's diner. Finney also has some fresher fish that's fresher and much finer but his best fish is his freshest fish and Finney says with pride, " & Chr(34) & "The finest fish at FInney's is my freshest fish, french-fried! SO... don't order the fresh fish or the fresher fish at Finney's if your wise, you'll say, fetch me the finest french-fried freshest fish that Finney fries!" & Chr(34)
    End Sub

End Class
