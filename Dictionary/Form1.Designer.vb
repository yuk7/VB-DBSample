<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.T_DICBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.T_DICBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.T_DICDataGridView = New System.Windows.Forms.DataGridView()
        Me.txtEN = New System.Windows.Forms.TextBox()
        Me.txtJP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.T_DICBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DicDataSet = New Dictionary.dicDataSet()
        Me.T_DICTableAdapter = New Dictionary.dicDataSetTableAdapters.T_DICTableAdapter()
        Me.TableAdapterManager = New Dictionary.dicDataSetTableAdapters.TableAdapterManager()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.T_DICBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.T_DICBindingNavigator.SuspendLayout()
        CType(Me.T_DICDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.T_DICBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DicDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'T_DICBindingNavigator
        '
        Me.T_DICBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.T_DICBindingNavigator.BindingSource = Me.T_DICBindingSource
        Me.T_DICBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.T_DICBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.T_DICBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.T_DICBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.T_DICBindingNavigatorSaveItem})
        Me.T_DICBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.T_DICBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.T_DICBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.T_DICBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.T_DICBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.T_DICBindingNavigator.Name = "T_DICBindingNavigator"
        Me.T_DICBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.T_DICBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.T_DICBindingNavigator.Size = New System.Drawing.Size(800, 31)
        Me.T_DICBindingNavigator.TabIndex = 0
        Me.T_DICBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorAddNewItem.Text = "新規追加"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(44, 28)
        Me.BindingNavigatorCountItem.Text = "/ {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "項目の総数"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorDeleteItem.Text = "削除"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "最初に移動"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "前に戻る"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "位置"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(51, 31)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "現在の場所"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveNextItem.Text = "次に移動"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(28, 28)
        Me.BindingNavigatorMoveLastItem.Text = "最後に移動"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'T_DICBindingNavigatorSaveItem
        '
        Me.T_DICBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.T_DICBindingNavigatorSaveItem.Image = CType(resources.GetObject("T_DICBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.T_DICBindingNavigatorSaveItem.Name = "T_DICBindingNavigatorSaveItem"
        Me.T_DICBindingNavigatorSaveItem.Size = New System.Drawing.Size(28, 28)
        Me.T_DICBindingNavigatorSaveItem.Text = "データの保存"
        '
        'T_DICDataGridView
        '
        Me.T_DICDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.T_DICDataGridView.AutoGenerateColumns = False
        Me.T_DICDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.T_DICDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.T_DICDataGridView.DataSource = Me.T_DICBindingSource
        Me.T_DICDataGridView.Location = New System.Drawing.Point(0, 36)
        Me.T_DICDataGridView.Name = "T_DICDataGridView"
        Me.T_DICDataGridView.RowTemplate.Height = 27
        Me.T_DICDataGridView.Size = New System.Drawing.Size(800, 365)
        Me.T_DICDataGridView.TabIndex = 1
        '
        'txtEN
        '
        Me.txtEN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtEN.Location = New System.Drawing.Point(92, 407)
        Me.txtEN.Name = "txtEN"
        Me.txtEN.Size = New System.Drawing.Size(454, 25)
        Me.txtEN.TabIndex = 2
        '
        'txtJP
        '
        Me.txtJP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtJP.Location = New System.Drawing.Point(92, 442)
        Me.txtJP.Multiline = True
        Me.txtJP.Name = "txtJP"
        Me.txtJP.Size = New System.Drawing.Size(454, 57)
        Me.txtJP.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 414)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 18)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "英語:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 445)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 18)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "日本語:"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(552, 407)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 51)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "追加"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(673, 408)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 50)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "修正"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "EN"
        Me.DataGridViewTextBoxColumn1.HeaderText = "EN"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "JP"
        Me.DataGridViewTextBoxColumn2.HeaderText = "JP"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'T_DICBindingSource
        '
        Me.T_DICBindingSource.DataMember = "T_DIC"
        Me.T_DICBindingSource.DataSource = Me.DicDataSet
        '
        'DicDataSet
        '
        Me.DicDataSet.DataSetName = "dicDataSet"
        Me.DicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'T_DICTableAdapter
        '
        Me.T_DICTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.T_DICTableAdapter = Me.T_DICTableAdapter
        Me.TableAdapterManager.UpdateOrder = Dictionary.dicDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(552, 456)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(115, 43)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "クリア"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 498)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtJP)
        Me.Controls.Add(Me.txtEN)
        Me.Controls.Add(Me.T_DICDataGridView)
        Me.Controls.Add(Me.T_DICBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "英和辞典"
        CType(Me.T_DICBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.T_DICBindingNavigator.ResumeLayout(False)
        Me.T_DICBindingNavigator.PerformLayout()
        CType(Me.T_DICDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.T_DICBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DicDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DicDataSet As dicDataSet
    Friend WithEvents T_DICBindingSource As BindingSource
    Friend WithEvents T_DICTableAdapter As dicDataSetTableAdapters.T_DICTableAdapter
    Friend WithEvents TableAdapterManager As dicDataSetTableAdapters.TableAdapterManager
    Friend WithEvents T_DICBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents T_DICBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents T_DICDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents txtEN As TextBox
    Friend WithEvents txtJP As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
