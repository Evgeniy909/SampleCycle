Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Dict As New Dictionary(Of String, Integer)
        Dim multiply As Integer = 1

        For Each TheCLB As CheckedListBox In Me.Controls.OfType(Of CheckedListBox)
            If TheCLB.CheckedItems.Count > 0 Then
                multiply *= TheCLB.CheckedItems.Count
                Dict.Add(TheCLB.Name, TheCLB.CheckedItems.Count)
            End If
        Next

        Dim Dt As New DataTable

        If Dict.Count <> 0 Then
            'Подготовка столбцов
            Dt.Columns.Add("0", GetType(Integer))
            Dt.Columns.Add("1", GetType(Integer))
            Dt.Columns.Add("2", GetType(Integer))
            Dt.Columns.Add("3", GetType(Integer))
            '________

            'создадим необходимое количество строк в таблице
            Dim nRow As DataRow
            For i = 0 To multiply - 1
                nRow = Dt.NewRow()
                Dt.Rows.Add(nRow)
            Next

            Dim nrR As Integer = 0
            Dim nrC As Integer = 0

            For Each i As Integer In Dict.Values

                Dim x As Integer = multiply / i
                Dim _x As Integer = x - 1

                For v As Integer = 0 To _x
                    For c As Integer = 0 To i - 1
                        Dt.Rows.Item(nrR).Item(nrC) = Dict.Values.ElementAt(c)
                        nrR += 1
                    Next c
                Next v
                nrC += 1
                nrR = 0
            Next
        End If

    End Sub
End Class
