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
        CType(Me.DGCart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CartCheckOut
        '
        Me.CartCheckOut.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CartCheckOut.ForeColor = System.Drawing.Color.DarkMagenta
        Me.CartCheckOut.Location = New System.Drawing.Point(851, 362)
        Me.CartCheckOut.Name = "CartCheckOut"
        Me.CartCheckOut.Size = New System.Drawing.Size(213, 58)
        Me.CartCheckOut.TabIndex = 1
        Me.CartCheckOut.Text = "Place Order"
        Me.CartCheckOut.UseVisualStyleBackColor = True
        '
        'DGCart
        '
        Me.DGCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGCart.BackgroundColor = System.Drawing.Color.Thistle
        Me.DGCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGCart.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ids, Me.names, Me.types, Me.pricess, Me.qtys, Me.tax, Me.tprices})
        Me.DGCart.Location = New System.Drawing.Point(109, 51)
        Me.DGCart.Name = "DGCart"
        Me.DGCart.RowHeadersWidth = 51
        Me.DGCart.RowTemplate.Height = 24
        Me.DGCart.Size = New System.Drawing.Size(929, 256)
        Me.DGCart.TabIndex = 2
        '
        'ids
        '
        Me.ids.HeaderText = "Product ID"
        Me.ids.MinimumWidth = 6
        Me.ids.Name = "ids"
        '
        'names
        '
        Me.names.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.names.HeaderText = "Product Name"
        Me.names.MinimumWidth = 6
        Me.names.Name = "names"
        '
        'types
        '
        Me.types.HeaderText = "Product Type"
        Me.types.MinimumWidth = 6
        Me.types.Name = "types"
        '
        'pricess
        '
        Me.pricess.HeaderText = "Price"
        Me.pricess.MinimumWidth = 6
        Me.pricess.Name = "pricess"
        '
        'qtys
        '
        Me.qtys.HeaderText = "Quantity"
        Me.qtys.MinimumWidth = 6
        Me.qtys.Name = "qtys"
        '
        'tax
        '
        Me.tax.HeaderText = "Added Tax"
        Me.tax.MinimumWidth = 6
        Me.tax.Name = "tax"
        '
        'tprices
        '
        Me.tprices.HeaderText = "Total"
        Me.tprices.MinimumWidth = 6
        Me.tprices.Name = "tprices"
        '
        'Cart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(1111, 1039)
        Me.Controls.Add(Me.DGCart)
        Me.Controls.Add(Me.CartCheckOut)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Cart"
        Me.Text = "Form1"
        CType(Me.DGCart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
End Class
