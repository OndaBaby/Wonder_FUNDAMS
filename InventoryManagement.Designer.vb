<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InventoryManagement
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
        Me.DGInventoryManagement = New System.Windows.Forms.DataGridView()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtinventoryid = New System.Windows.Forms.TextBox()
        Me.txtstock = New System.Windows.Forms.TextBox()
        Me.txtproductid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DGPname = New System.Windows.Forms.DataGridView()
        Me.btnShow = New System.Windows.Forms.Button()
        CType(Me.DGInventoryManagement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGPname, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGInventoryManagement
        '
        Me.DGInventoryManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGInventoryManagement.BackgroundColor = System.Drawing.Color.Thistle
        Me.DGInventoryManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGInventoryManagement.Location = New System.Drawing.Point(44, 42)
        Me.DGInventoryManagement.Name = "DGInventoryManagement"
        Me.DGInventoryManagement.RowHeadersWidth = 51
        Me.DGInventoryManagement.RowTemplate.Height = 24
        Me.DGInventoryManagement.Size = New System.Drawing.Size(567, 283)
        Me.DGInventoryManagement.TabIndex = 0
        '
        'btnRead
        '
        Me.btnRead.BackColor = System.Drawing.Color.Thistle
        Me.btnRead.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRead.ForeColor = System.Drawing.Color.DarkMagenta
        Me.btnRead.Location = New System.Drawing.Point(545, 391)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(143, 51)
        Me.btnRead.TabIndex = 9
        Me.btnRead.Text = "Read"
        Me.btnRead.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.Thistle
        Me.btnUpdate.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.DarkMagenta
        Me.btnUpdate.Location = New System.Drawing.Point(545, 515)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(143, 51)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Thistle
        Me.Button1.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Button1.Location = New System.Drawing.Point(545, 453)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 51)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Select"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtinventoryid
        '
        Me.txtinventoryid.Location = New System.Drawing.Point(290, 394)
        Me.txtinventoryid.Name = "txtinventoryid"
        Me.txtinventoryid.Size = New System.Drawing.Size(204, 22)
        Me.txtinventoryid.TabIndex = 12
        '
        'txtstock
        '
        Me.txtstock.Location = New System.Drawing.Point(290, 453)
        Me.txtstock.Name = "txtstock"
        Me.txtstock.Size = New System.Drawing.Size(204, 22)
        Me.txtstock.TabIndex = 13
        '
        'txtproductid
        '
        Me.txtproductid.Location = New System.Drawing.Point(290, 521)
        Me.txtproductid.Name = "txtproductid"
        Me.txtproductid.Size = New System.Drawing.Size(204, 22)
        Me.txtproductid.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Thistle
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label1.Location = New System.Drawing.Point(74, 391)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 23)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Inventory ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Thistle
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label2.Location = New System.Drawing.Point(74, 450)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 23)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Stock"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Thistle
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label3.Location = New System.Drawing.Point(74, 515)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 23)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Product ID"
        '
        'DGPname
        '
        Me.DGPname.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGPname.BackgroundColor = System.Drawing.Color.Thistle
        Me.DGPname.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGPname.Location = New System.Drawing.Point(631, 42)
        Me.DGPname.Name = "DGPname"
        Me.DGPname.RowHeadersWidth = 51
        Me.DGPname.RowTemplate.Height = 24
        Me.DGPname.Size = New System.Drawing.Size(451, 283)
        Me.DGPname.TabIndex = 18
        '
        'btnShow
        '
        Me.btnShow.BackColor = System.Drawing.Color.Thistle
        Me.btnShow.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShow.ForeColor = System.Drawing.Color.DarkMagenta
        Me.btnShow.Location = New System.Drawing.Point(835, 340)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(247, 51)
        Me.btnShow.TabIndex = 19
        Me.btnShow.Text = "Show Product Name"
        Me.btnShow.UseVisualStyleBackColor = False
        '
        'InventoryManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(1111, 1039)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.DGPname)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtproductid)
        Me.Controls.Add(Me.txtstock)
        Me.Controls.Add(Me.txtinventoryid)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.DGInventoryManagement)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InventoryManagement"
        Me.Text = "Inventory Management"
        CType(Me.DGInventoryManagement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGPname, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGInventoryManagement As DataGridView
    Friend WithEvents btnRead As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents txtinventoryid As TextBox
    Friend WithEvents txtstock As TextBox
    Friend WithEvents txtproductid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DGPname As DataGridView
    Friend WithEvents btnShow As Button
End Class
