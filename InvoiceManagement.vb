Public Class InvoiceManagement
    Private Sub btnReceipts_Click(sender As Object, e As EventArgs) Handles btnReceipts.Click
        Read_InvoiceManagement()
        For Each row As DataGridViewRow In DGInvoice.Rows
            If Not row.IsNewRow Then
                For Each cell As DataGridViewCell In row.Cells
                    TallyReceipt.AppendText(cell.Value.ToString() & vbCrLf)
                Next
                TallyReceipt.AppendText(vbCrLf)
            End If
        Next
    End Sub
End Class