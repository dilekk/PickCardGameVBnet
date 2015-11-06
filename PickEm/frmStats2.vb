Public Class frmStats2

    Private Sub TblStatsBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles TblStatsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblStatsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsStats)

    End Sub

    Private Sub frmStats2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsStats.tblStats' table. You can move, or remove it, as needed.
        Me.TblStatsTableAdapter.Fill(Me.DsStats.tblStats)

    End Sub

    Private Sub PickLowerTextBox_TextChanged(sender As System.Object, e As System.EventArgs) Handles PickLowerTextBox.TextChanged

    End Sub
End Class