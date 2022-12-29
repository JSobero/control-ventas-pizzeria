Public Class factura
    Private Sub factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'pizzeriaDataSet.ticket' Puede moverla o quitarla según sea necesario.
        Me.ticketTableAdapter.Fill(Me.pizzeriaDataSet.ticket)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        boleta.Show()
    End Sub
End Class