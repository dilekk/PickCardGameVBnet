Public Class frmStats

    Private Sub TblStatsBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs) Handles TblStatsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblStatsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsStats)

    End Sub

    Private Sub frmStats_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsStats.tblStats' table. You can move, or remove it, as needed.
        Me.TblStatsTableAdapter.Fill(Me.DsStats.tblStats)

    End Sub

    Private Sub TblStatsDataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TblStatsDataGridView.CellContentClick

    End Sub
End Class