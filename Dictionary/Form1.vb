Public Class Form1
    Private Sub T_DICBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles T_DICBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.T_DICBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DicDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: このコード行はデータを 'DicDataSet.T_DIC' テーブルに読み込みます。必要に応じて移動、または削除をしてください。
        Me.T_DICTableAdapter.Fill(Me.DicDataSet.T_DIC)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sEN, sJP As String
        sEN = txtEN.Text
        sJP = txtJP.Text
        Try
            '英単語をテーブルに追加
            Me.T_DICTableAdapter.Insert(sEN, sJP)
        Catch ex As Exception
            MsgBox("エラー: " + Environment.NewLine + "ヒント:英単語が重複している可能性があります。")
        End Try

        Me.T_DICTableAdapter.Fill(Me.DicDataSet.T_DIC)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'データ修正
        Dim nRow As Integer = Me.T_DICDataGridView.CurrentRow.Index
        Dim sEN, sJP As String
        sEN = txtEN.Text
        sJP = txtJP.Text

        Dim orgEN As String
        orgEN = Me.T_DICDataGridView.Rows(nRow).Cells(0).Value
        Me.T_DICTableAdapter.UpdateQuery(sEN, sJP, orgEN)

        Me.T_DICTableAdapter.Fill(Me.DicDataSet.T_DIC)
    End Sub

    Private Sub T_DICDataGridView_CurrentCellChanged(sender As Object, e As EventArgs) Handles T_DICDataGridView.CurrentCellChanged
        '選択されているセルが変更された場合、txtENとtxtJPを更新
        Try
            If Not IsNothing(Me.T_DICDataGridView.CurrentRow) Then
                Dim nRow As Integer = Me.T_DICDataGridView.CurrentRow.Index

                txtEN.Text = Me.T_DICDataGridView.Rows(nRow).Cells(0).Value
                txtJP.Text = Me.T_DICDataGridView.Rows(nRow).Cells(1).Value
            End If
        Catch ex As Exception
            txtEN.Text = ""
            txtJP.Text = ""
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '入力をクリア
        txtEN.Text = ""
        txtJP.Text = ""
    End Sub

    Private Sub txtEN_TextChanged(sender As Object, e As EventArgs) Handles txtEN.TextChanged
        '英単語のテキストボックスが変更されたら検索し、一致するものを選択する
        Dim sEN As String = txtEN.Text
        If Not sEN = "" Then
            Dim Index As Integer = 0
            Dim Found As Boolean = False
            '検索ループ
            For i As Integer = 0 To T_DICDataGridView.RowCount - 1
                Dim inputString As String = T_DICDataGridView.Rows(i).Cells(0).Value
                If sEN = inputString Then
                    Found = True
                    Index = i
                End If
            Next

            '該当のセルを選択
            If Found = True Then
                Me.T_DICDataGridView.CurrentCell = Me.T_DICDataGridView.Rows(Index).Cells(0)
            End If
        End If
    End Sub
End Class

