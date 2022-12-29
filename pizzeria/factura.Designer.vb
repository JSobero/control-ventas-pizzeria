<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class factura
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ticketBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.pizzeriaDataSet = New pizzeria.pizzeriaDataSet()
        Me.TicketTableAdapter1 = New pizzeria.pizzeriaDataSetTableAdapters.ticketTableAdapter()
        Me.TicketTableAdapter2 = New pizzeria.pizzeriaDataSetTableAdapters.ticketTableAdapter()
        Me.ClientesTableAdapter1 = New pizzeria.pizzeriaDataSetTableAdapters.clientesTableAdapter()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ticketTableAdapter = New pizzeria.pizzeriaDataSetTableAdapters.ticketTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.ticketBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pizzeriaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ticketBindingSource
        '
        Me.ticketBindingSource.DataMember = "ticket"
        Me.ticketBindingSource.DataSource = Me.pizzeriaDataSet
        '
        'pizzeriaDataSet
        '
        Me.pizzeriaDataSet.DataSetName = "pizzeriaDataSet"
        Me.pizzeriaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TicketTableAdapter1
        '
        Me.TicketTableAdapter1.ClearBeforeFill = True
        '
        'TicketTableAdapter2
        '
        Me.TicketTableAdapter2.ClearBeforeFill = True
        '
        'ClientesTableAdapter1
        '
        Me.ClientesTableAdapter1.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.ticketBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "pizzeria.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1039, 575)
        Me.ReportViewer1.TabIndex = 0
        '
        'ticketTableAdapter
        '
        Me.ticketTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(12, 522)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 41)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "REGRESAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1039, 575)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "factura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FACTURA"
        CType(Me.ticketBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pizzeriaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TicketTableAdapter1 As pizzeriaDataSetTableAdapters.ticketTableAdapter
    Friend WithEvents TicketTableAdapter2 As pizzeriaDataSetTableAdapters.ticketTableAdapter
    Friend WithEvents ClientesTableAdapter1 As pizzeriaDataSetTableAdapters.clientesTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ticketBindingSource As BindingSource
    Friend WithEvents pizzeriaDataSet As pizzeriaDataSet
    Friend WithEvents ticketTableAdapter As pizzeriaDataSetTableAdapters.ticketTableAdapter
    Friend WithEvents Button1 As Button
End Class
