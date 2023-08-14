<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InvoiceManagement
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TallyReceipt = New System.Windows.Forms.RichTextBox()
        Me.DGInvoice = New System.Windows.Forms.DataGridView()
        Me.btnReceipts = New System.Windows.Forms.Button()
        Me.btnCrystal = New System.Windows.Forms.Button()
        CType(Me.DGInvoice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TallyReceipt
        '
        Me.TallyReceipt.BackColor = System.Drawing.Color.LavenderBlush
        Me.TallyReceipt.Location = New System.Drawing.Point(757, 38)
        Me.TallyReceipt.Name = "TallyReceipt"
        Me.TallyReceipt.Size = New System.Drawing.Size(283, 484)
        Me.TallyReceipt.TabIndex = 0
        Me.TallyReceipt.Text = ""
        '
        'DGInvoice
        '
        Me.DGInvoice.BackgroundColor = System.Drawing.Color.Thistle
        Me.DGInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGInvoice.Location = New System.Drawing.Point(45, 47)
        Me.DGInvoice.Name = "DGInvoice"
        Me.DGInvoice.RowHeadersWidth = 51
        Me.DGInvoice.RowTemplate.Height = 24
        Me.DGInvoice.Size = New System.Drawing.Size(650, 223)
        Me.DGInvoice.TabIndex = 1
        '
        'btnReceipts
        '
        Me.btnReceipts.BackColor = System.Drawing.Color.Thistle
        Me.btnReceipts.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReceipts.ForeColor = System.Drawing.Color.DarkMagenta
        Me.btnReceipts.Location = New System.Drawing.Point(552, 298)
        Me.btnReceipts.Name = "btnReceipts"
        Me.btnReceipts.Size = New System.Drawing.Size(143, 51)
        Me.btnReceipts.TabIndex = 11
        Me.btnReceipts.Text = "All Receipts"
        Me.btnReceipts.UseVisualStyleBackColor = False
        '
        'btnCrystal
        '
        Me.btnCrystal.BackColor = System.Drawing.Color.Thistle
        Me.btnCrystal.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrystal.ForeColor = System.Drawing.Color.DarkMagenta
        Me.btnCrystal.Location = New System.Drawing.Point(897, 546)
        Me.btnCrystal.Name = "btnCrystal"
        Me.btnCrystal.Size = New System.Drawing.Size(143, 51)
        Me.btnCrystal.TabIndex = 12
        Me.btnCrystal.Text = "Report"
        Me.btnCrystal.UseVisualStyleBackColor = False
        '
        'InvoiceManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(1093, 992)
        Me.Controls.Add(Me.btnCrystal)
        Me.Controls.Add(Me.btnReceipts)
        Me.Controls.Add(Me.DGInvoice)
        Me.Controls.Add(Me.TallyReceipt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InvoiceManagement"
        Me.Text = "Form1"
        CType(Me.DGInvoice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TallyReceipt As RichTextBox
    Friend WithEvents DGInvoice As DataGridView
    Friend WithEvents btnReceipts As Button
    Friend WithEvents btnCrystal As Button
End Class
