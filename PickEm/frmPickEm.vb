﻿Public Class frmPickEm
    Private deck(51) As Integer
    Private currentIdx As Integer = 0
    '#Region "My local subs"
    'put all sub routines here, if you want to collapse
    '#End Region
    Private Sub Label7_Click(sender As System.Object, e As System.EventArgs) Handles lblSame.Click

    End Sub

    Private Sub btnStart_Click(sender As System.Object, e As System.EventArgs) Handles btnStart.Click
        btnStart.Enabled = False 'disables at the begining
        prepareDeck() 'calling the subroutine
        'btnDeck.Enabled = True ----do this after the pick
        grpPick.Enabled = True
        initializeStats()


    End Sub

    'Private Sub btnDeck_Click(sender As System.Object, e As System.EventArgs) Handles btnDeck.Click
    Private Sub prepareDeck()

        'Variables declared here----------

        Dim idx As Integer
        Dim cardValue As Integer
        Dim newIdx As Integer
        Dim rnd As Random = New Random() 'using VB library, creating a new object type Random


        For idx = 0 To 51 'this swaps the numbers in the deck
            cardValue = deck(idx)
            newIdx = rnd.Next(52) 'creating a new object. it is a method, and gives 0 to 51 number
            deck(idx) = deck(newIdx) 'swaping number with new number
            deck(newIdx) = cardValue ' put the new number to the old place
        Next
        '#If DEBUG Then
        ' MessageBox.Show(deck(0) & "-" & deck(27) & "-" & deck(51))
        '#End If

        lblFaceCard.Text = deck(0) 'initialize the first card from the deck to the display area on start
        currentIdx = 1 'ready to start second card
    End Sub

    Private Sub lblFaceCard_Click(sender As System.Object, e As System.EventArgs) Handles lblFaceCard.Click

    End Sub

    Private Sub btnDeck_Click(sender As System.Object, e As System.EventArgs) Handles btnDeck.Click

        'in the comparison we are comparing these two
        Dim previousCard As Integer = deck(currentIdx - 1) Mod 13 'this is where the previous index 
        Dim currentCard As Integer = deck(currentIdx) Mod 13

        lblFaceCard.Text = currentCard ' deck(currentIdx)

        'Increment your pick---this could be a Sub Routine
        'these following steps adding results and putting the statistics
        If radHigher.Checked = True Then 'we dont really need true cause .checked gives us the value true
            txtPickHigher.Text = CInt(txtPickHigher.Text) + 1 'converts the expression to string so you can increment by 1
        ElseIf radLower.Checked Then
            txtPickLower.Text = CInt(txtPickLower.Text) + 1
        Else
            txtPickSame.Text = CInt(txtPickSame.Text) + 1

        End If

        'determine next vs previous (actual)
        'add message box here....
        MessageBox.Show(previousCard & "-" & currentCard)
        If previousCard < currentCard Then
            txtActualHigher.Text = CInt(txtActualHigher.Text) + 1
        ElseIf previousCard > currentCard Then
            txtActualLower.Text = CInt(txtActualLower.Text) + 1
        Else
            txtActualSame.Text = CInt(txtActualSame.Text) + 1
        End If

        currentIdx += 1
        'first card wont show here...
        If currentIdx > 3 Then '51 Then............TO DO RESET WHEN STARTS WORKING........
            'ran out of cards...so GAME OVER
            btnDeck.Enabled = False
            grpPick.Enabled = False
            btnStart.Enabled = True 'user only can click on Start but disable everything else
            MessageBox.Show(" Game over! Thanks for playing", "PickEm", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub frmPickEm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'loop that will create 0 to 51 
        Dim idx As Integer

        For idx = 0 To 51
            deck(idx) = idx 'this adds 0 to 51 to deck in a loop
        Next
        ' MessageBox.Show(deck(0) & "-" & deck(27) & "-" & deck(51))
    End Sub

    Private Sub initializeStats()
        'Throw New NotImplementedException 'this is a procedure does nothing you need to fix this. Generated by Microsoft
        txtActualHigher.Text = "0"
        txtActualLower.Text = "0"
        txtActualSame.Text = "0"
        txtPickHigher.Text = "0"
        txtPickLower.Text = "0"
        txtPickSame.Text = "0"
    End Sub

    Private Sub radHigher_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radHigher.CheckedChanged
        grpPick.Tag = 1 'arbitrarily decided to use this so we can keep track of what is picked
        btnDeck.Enabled = True
    End Sub

    Private Sub radLower_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radLower.CheckedChanged
        grpPick.Tag = -1
        btnDeck.Enabled = True
    End Sub

    Private Sub radSame_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles radSame.CheckedChanged
        grpPick.Tag = 0
        btnDeck.Enabled = True
    End Sub
End Class