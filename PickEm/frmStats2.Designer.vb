<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStats2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStats2))
        Dim IDLabel As System.Windows.Forms.Label
        Dim PickHigherLabel As System.Windows.Forms.Label
        Dim PickLowerLabel As System.Windows.Forms.Label
        Dim PickSameLabel As System.Windows.Forms.Label
        Dim ActualHigherLabel As System.Windows.Forms.Label
        Dim ActualLowerLabel As System.Windows.Forms.Label
        Dim ActualSameLabel As System.Windows.Forms.Label
        Dim DateCreatedLabel As System.Windows.Forms.Label
        Me.DsStats = New PickEm.dsStats()
        Me.TblStatsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblStatsTableAdapter = New PickEm.dsStatsTableAdapters.tblStatsTableAdapter()
        Me.TableAdapterManager = New PickEm.dsStatsTableAdapters.TableAdapterManager()
        Me.TblStatsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.TblStatsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.PickHigherTextBox = New System.Windows.Forms.TextBox()
        Me.PickLowerTextBox = New System.Windows.Forms.TextBox()
        Me.PickSameTextBox = New System.Windows.Forms.TextBox()
        Me.ActualHigherTextBox = New System.Windows.Forms.TextBox()
        Me.ActualLowerTextBox = New System.Windows.Forms.TextBox()
        Me.ActualSameTextBox = New System.Windows.Forms.TextBox()
        Me.DateCreatedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        IDLabel = New System.Windows.Forms.Label()
        PickHigherLabel = New System.Windows.Forms.Label()
        PickLowerLabel = New System.Windows.Forms.Label()
        PickSameLabel = New System.Windows.Forms.Label()
        ActualHigherLabel = New System.Windows.Forms.Label()
        ActualLowerLabel = New System.Windows.Forms.Label()
        ActualSameLabel = New System.Windows.Forms.Label()
        DateCreatedLabel = New System.Windows.Forms.Label()
        CType(Me.DsStats, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblStatsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblStatsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblStatsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'DsStats
        '
        Me.DsStats.DataSetName = "dsStats"
        Me.DsStats.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblStatsBindingSource
        '
        Me.TblStatsBindingSource.DataMember = "tblStats"
        Me.TblStatsBindingSource.DataSource = Me.DsStats
        '
        'TblStatsTableAdapter
        '
        Me.TblStatsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblScoresTableAdapter = Nothing
        Me.TableAdapterManager.tblStatsTableAdapter = Me.TblStatsTableAdapter
        Me.TableAdapterManager.tblUsersTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PickEm.dsStatsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblStatsBindingNavigator
        '
        Me.TblStatsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblStatsBindingNavigator.BindingSource = Me.TblStatsBindingSource
        Me.TblStatsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblStatsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblStatsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblStatsBindingNavigatorSaveItem})
        Me.TblStatsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblStatsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblStatsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblStatsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblStatsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblStatsBindingNavigator.Name = "TblStatsBindingNavigator"
        Me.TblStatsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblStatsBindingNavigator.Size = New System.Drawing.Size(558, 25)
        Me.TblStatsBindingNavigator.TabIndex = 0
        Me.TblStatsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 24)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(48, 18)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'TblStatsBindingNavigatorSaveItem
        '
        Me.TblStatsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblStatsBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblStatsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblStatsBindingNavigatorSaveItem.Name = "TblStatsBindingNavigatorSaveItem"
        Me.TblStatsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.TblStatsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Location = New System.Drawing.Point(78, 90)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(25, 17)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStatsBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(181, 87)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(200, 22)
        Me.IDTextBox.TabIndex = 2
        '
        'PickHigherLabel
        '
        PickHigherLabel.AutoSize = True
        PickHigherLabel.Location = New System.Drawing.Point(78, 118)
        PickHigherLabel.Name = "PickHigherLabel"
        PickHigherLabel.Size = New System.Drawing.Size(84, 17)
        PickHigherLabel.TabIndex = 3
        PickHigherLabel.Text = "Pick Higher:"
        '
        'PickHigherTextBox
        '
        Me.PickHigherTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStatsBindingSource, "PickHigher", True))
        Me.PickHigherTextBox.Location = New System.Drawing.Point(181, 115)
        Me.PickHigherTextBox.Name = "PickHigherTextBox"
        Me.PickHigherTextBox.Size = New System.Drawing.Size(200, 22)
        Me.PickHigherTextBox.TabIndex = 4
        '
        'PickLowerLabel
        '
        PickLowerLabel.AutoSize = True
        PickLowerLabel.Location = New System.Drawing.Point(78, 146)
        PickLowerLabel.Name = "PickLowerLabel"
        PickLowerLabel.Size = New System.Drawing.Size(80, 17)
        PickLowerLabel.TabIndex = 5
        PickLowerLabel.Text = "Pick Lower:"
        '
        'PickLowerTextBox
        '
        Me.PickLowerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStatsBindingSource, "PickLower", True))
        Me.PickLowerTextBox.Location = New System.Drawing.Point(181, 143)
        Me.PickLowerTextBox.Name = "PickLowerTextBox"
        Me.PickLowerTextBox.Size = New System.Drawing.Size(200, 22)
        Me.PickLowerTextBox.TabIndex = 6
        '
        'PickSameLabel
        '
        PickSameLabel.AutoSize = True
        PickSameLabel.Location = New System.Drawing.Point(78, 174)
        PickSameLabel.Name = "PickSameLabel"
        PickSameLabel.Size = New System.Drawing.Size(78, 17)
        PickSameLabel.TabIndex = 7
        PickSameLabel.Text = "Pick Same:"
        '
        'PickSameTextBox
        '
        Me.PickSameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStatsBindingSource, "PickSame", True))
        Me.PickSameTextBox.Location = New System.Drawing.Point(181, 171)
        Me.PickSameTextBox.Name = "PickSameTextBox"
        Me.PickSameTextBox.Size = New System.Drawing.Size(200, 22)
        Me.PickSameTextBox.TabIndex = 8
        '
        'ActualHigherLabel
        '
        ActualHigherLabel.AutoSize = True
        ActualHigherLabel.Location = New System.Drawing.Point(78, 202)
        ActualHigherLabel.Name = "ActualHigherLabel"
        ActualHigherLabel.Size = New System.Drawing.Size(97, 17)
        ActualHigherLabel.TabIndex = 9
        ActualHigherLabel.Text = "Actual Higher:"
        '
        'ActualHigherTextBox
        '
        Me.ActualHigherTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStatsBindingSource, "ActualHigher", True))
        Me.ActualHigherTextBox.Location = New System.Drawing.Point(181, 199)
        Me.ActualHigherTextBox.Name = "ActualHigherTextBox"
        Me.ActualHigherTextBox.Size = New System.Drawing.Size(200, 22)
        Me.ActualHigherTextBox.TabIndex = 10
        '
        'ActualLowerLabel
        '
        ActualLowerLabel.AutoSize = True
        ActualLowerLabel.Location = New System.Drawing.Point(78, 230)
        ActualLowerLabel.Name = "ActualLowerLabel"
        ActualLowerLabel.Size = New System.Drawing.Size(93, 17)
        ActualLowerLabel.TabIndex = 11
        ActualLowerLabel.Text = "Actual Lower:"
        '
        'ActualLowerTextBox
        '
        Me.ActualLowerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStatsBindingSource, "ActualLower", True))
        Me.ActualLowerTextBox.Location = New System.Drawing.Point(181, 227)
        Me.ActualLowerTextBox.Name = "ActualLowerTextBox"
        Me.ActualLowerTextBox.Size = New System.Drawing.Size(200, 22)
        Me.ActualLowerTextBox.TabIndex = 12
        '
        'ActualSameLabel
        '
        ActualSameLabel.AutoSize = True
        ActualSameLabel.Location = New System.Drawing.Point(78, 258)
        ActualSameLabel.Name = "ActualSameLabel"
        ActualSameLabel.Size = New System.Drawing.Size(91, 17)
        ActualSameLabel.TabIndex = 13
        ActualSameLabel.Text = "Actual Same:"
        '
        'ActualSameTextBox
        '
        Me.ActualSameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblStatsBindingSource, "ActualSame", True))
        Me.ActualSameTextBox.Location = New System.Drawing.Point(181, 255)
        Me.ActualSameTextBox.Name = "ActualSameTextBox"
        Me.ActualSameTextBox.Size = New System.Drawing.Size(200, 22)
        Me.ActualSameTextBox.TabIndex = 14
        '
        'DateCreatedLabel
        '
        DateCreatedLabel.AutoSize = True
        DateCreatedLabel.Location = New System.Drawing.Point(78, 287)
        DateCreatedLabel.Name = "DateCreatedLabel"
        DateCreatedLabel.Size = New System.Drawing.Size(96, 17)
        DateCreatedLabel.TabIndex = 15
        DateCreatedLabel.Text = "Date Created:"
        '
        'DateCreatedDateTimePicker
        '
        Me.DateCreatedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TblStatsBindingSource, "DateCreated", True))
        Me.DateCreatedDateTimePicker.Location = New System.Drawing.Point(181, 283)
        Me.DateCreatedDateTimePicker.Name = "DateCreatedDateTimePicker"
        Me.DateCreatedDateTimePicker.Size = New System.Drawing.Size(200, 22)
        Me.DateCreatedDateTimePicker.TabIndex = 16
        '
        'frmStats2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 448)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(PickHigherLabel)
        Me.Controls.Add(Me.PickHigherTextBox)
        Me.Controls.Add(PickLowerLabel)
        Me.Controls.Add(Me.PickLowerTextBox)
        Me.Controls.Add(PickSameLabel)
        Me.Controls.Add(Me.PickSameTextBox)
        Me.Controls.Add(ActualHigherLabel)
        Me.Controls.Add(Me.ActualHigherTextBox)
        Me.Controls.Add(ActualLowerLabel)
        Me.Controls.Add(Me.ActualLowerTextBox)
        Me.Controls.Add(ActualSameLabel)
        Me.Controls.Add(Me.ActualSameTextBox)
        Me.Controls.Add(DateCreatedLabel)
        Me.Controls.Add(Me.DateCreatedDateTimePicker)
        Me.Controls.Add(Me.TblStatsBindingNavigator)
        Me.Name = "frmStats2"
        Me.Text = "frmStats2"
        CType(Me.DsStats, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblStatsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblStatsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblStatsBindingNavigator.ResumeLayout(False)
        Me.TblStatsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsStats As PickEm.dsStats
    Friend WithEvents TblStatsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblStatsTableAdapter As PickEm.dsStatsTableAdapters.tblStatsTableAdapter
    Friend WithEvents TableAdapterManager As PickEm.dsStatsTableAdapters.TableAdapterManager
    Friend WithEvents TblStatsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TblStatsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PickHigherTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PickLowerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PickSameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ActualHigherTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ActualLowerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ActualSameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DateCreatedDateTimePicker As System.Windows.Forms.DateTimePicker
End Class
