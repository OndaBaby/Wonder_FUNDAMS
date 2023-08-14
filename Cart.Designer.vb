<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cart
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
        Me.CartCheckOut = New System.Windows.Forms.Button()
        Me.DGCart = New System.Windows.Forms.DataGridView()
        Me.ids = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.names = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.types = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pricess = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qtys = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tprices = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.receipt = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGCart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CartCheckOut
        '
        Me.CartCheckOut.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CartCheckOut.ForeColor = System.Drawing.Color.DarkMagenta
        Me.CartCheckOut.Location = New System.Drawing.Point(801, 375)
        Me.CartCheckOut.Name = "CartCheckOut"
        Me.CartCheckOut.Size = New System.Drawing.Size(213, 58)
        Me.CartCheckOut.TabIndex = 1
        Me.CartCheckOut.Text = "Place Order"
        Me.CartCheckOut.UseVisualStyleBackColor = True
        '
        'DGCart
        '
        Me.DGCart.AllowUserToAddRows = False
        Me.DGCart.AllowUserToDeleteRows = False
        Me.DGCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGCart.BackgroundColor = System.Drawing.Color.Thistle
        Me.DGCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGCart.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ids, Me.names, Me.types, Me.pricess, Me.qtys, Me.tax, Me.tprices})
        Me.DGCart.Location = New System.Drawing.Point(99, 49)
        Me.DGCart.Name = "DGCart"
        Me.DGCart.ReadOnly = True
        Me.DGCart.RowHeadersWidth = 51
        Me.DGCart.RowTemplate.Height = 24
        Me.DGCart.Size = New System.Drawing.Size(929, 301)
        Me.DGCart.TabIndex = 2
        '
        'ids
        '
        Me.ids.HeaderText = "Product ID"
        Me.ids.MinimumWidth = 6
        Me.ids.Name = "ids"
        Me.ids.ReadOnly = True
        '
        'names
        '
        Me.names.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.names.HeaderText = "Product Name"
        Me.names.MinimumWidth = 6
        Me.names.Name = "names"
        Me.names.ReadOnly = True
        '
        'types
        '
        Me.types.HeaderText = "Product Type"
        Me.types.MinimumWidth = 6
        Me.types.Name = "types"
        Me.types.ReadOnly = True
        '
        'pricess
        '
        Me.pricess.HeaderText = "Price"
        Me.pricess.MinimumWidth = 6
        Me.pricess.Name = "pricess"
        Me.pricess.ReadOnly = True
        '
        'qtys
        '
        Me.qtys.HeaderText = "Quantity"
        Me.qtys.MinimumWidth = 6
        Me.qtys.Name = "qtys"
        Me.qtys.ReadOnly = True
        '
        'tax
        '
        Me.tax.HeaderText = "Added Tax"
        Me.tax.MinimumWidth = 6
        Me.tax.Name = "tax"
        Me.tax.ReadOnly = True
        '
        'tprices
        '
        Me.tprices.HeaderText = "Total"
        Me.tprices.MinimumWidth = 6
        Me.tprices.Name = "tprices"
        Me.tprices.ReadOnly = True
        '
        'receipt
        '
        Me.receipt.Location = New System.Drawing.Point(99, 460)
        Me.receipt.Name = "receipt"
        Me.receipt.Size = New System.Drawing.Size(354, 469)
        Me.receipt.TabIndex = 3
        Me.receipt.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(95, 421)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(184, 22)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Here's Your Receipt:"
        '
        'Cart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(1111, 1039)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.receipt)
        Me.Controls.Add(Me.DGCart)
        Me.Controls.Add(Me.CartCheckOut)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Cart"
        Me.Text = "Form1"
        CType(Me.DGCart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CartCheckOut As Button
    Friend WithEvents DGCart As DataGridView
    Friend WithEvents ids As DataGridViewTextBoxColumn
    Friend WithEvents names As DataGridViewTextBoxColumn
    Friend WithEvents types As DataGridViewTextBoxColumn
    Friend WithEvents pricess As DataGridViewTextBoxColumn
    Friend WithEvents qtys As DataGridViewTextBoxColumn
    Friend WithEvents tax As DataGridViewTextBoxColumn
    Friend WithEvents tprices As DataGridViewTextBoxColumn
    Friend WithEvents receipt As RichTextBox
    Friend WithEvents Label1 As Label
End Class
