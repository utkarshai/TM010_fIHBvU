Public Class Form4
    Private Sub Table1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Table1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Table1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FavDataSet)

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FavDataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.FavDataSet.Table1)

    End Sub
End Class