<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Me.HeaderLabel = New System.Windows.Forms.Label()
        Me.CustomersLabel = New System.Windows.Forms.Label()
        Me.SellersLabel = New System.Windows.Forms.Label()
        Me.OrdersLabel = New System.Windows.Forms.Label()
        Me.ProductsLabel = New System.Windows.Forms.Label()
        Me.LogoutLabel = New System.Windows.Forms.Label()
        Me.AccountLabel = New System.Windows.Forms.Label()
        Me.AccountPictureBox = New System.Windows.Forms.PictureBox()
        Me.LogoutPictureBox = New System.Windows.Forms.PictureBox()
        Me.ExitPictureBox = New System.Windows.Forms.PictureBox()
        Me.OrdersPictureBox = New System.Windows.Forms.PictureBox()
        Me.ProductsPictureBox = New System.Windows.Forms.PictureBox()
        Me.SellersPictureBox = New System.Windows.Forms.PictureBox()
        Me.CustomersPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.AccountPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoutPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExitPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SellersPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HeaderLabel
        '
        Me.HeaderLabel.AutoSize = True
        Me.HeaderLabel.Font = New System.Drawing.Font("Trebuchet MS", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HeaderLabel.Location = New System.Drawing.Point(489, 22)
        Me.HeaderLabel.Name = "HeaderLabel"
        Me.HeaderLabel.Size = New System.Drawing.Size(218, 49)
        Me.HeaderLabel.TabIndex = 4
        Me.HeaderLabel.Text = " Dashboard"
        '
        'CustomersLabel
        '
        Me.CustomersLabel.AutoSize = True
        Me.CustomersLabel.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomersLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CustomersLabel.Location = New System.Drawing.Point(152, 316)
        Me.CustomersLabel.Name = "CustomersLabel"
        Me.CustomersLabel.Size = New System.Drawing.Size(210, 29)
        Me.CustomersLabel.TabIndex = 5
        Me.CustomersLabel.Text = "Total Customers: "
        '
        'SellersLabel
        '
        Me.SellersLabel.AutoSize = True
        Me.SellersLabel.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SellersLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SellersLabel.Location = New System.Drawing.Point(845, 316)
        Me.SellersLabel.Name = "SellersLabel"
        Me.SellersLabel.Size = New System.Drawing.Size(166, 29)
        Me.SellersLabel.TabIndex = 6
        Me.SellersLabel.Text = "Total Sellers: "
        '
        'OrdersLabel
        '
        Me.OrdersLabel.AutoSize = True
        Me.OrdersLabel.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrdersLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.OrdersLabel.Location = New System.Drawing.Point(506, 316)
        Me.OrdersLabel.Name = "OrdersLabel"
        Me.OrdersLabel.Size = New System.Drawing.Size(167, 29)
        Me.OrdersLabel.TabIndex = 7
        Me.OrdersLabel.Text = "Total Orders: "
        '
        'ProductsLabel
        '
        Me.ProductsLabel.AutoSize = True
        Me.ProductsLabel.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductsLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ProductsLabel.Location = New System.Drawing.Point(159, 613)
        Me.ProductsLabel.Name = "ProductsLabel"
        Me.ProductsLabel.Size = New System.Drawing.Size(190, 29)
        Me.ProductsLabel.TabIndex = 8
        Me.ProductsLabel.Text = "Total Products: "
        '
        'LogoutLabel
        '
        Me.LogoutLabel.AutoSize = True
        Me.LogoutLabel.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutLabel.ForeColor = System.Drawing.Color.Red
        Me.LogoutLabel.Location = New System.Drawing.Point(899, 617)
        Me.LogoutLabel.Name = "LogoutLabel"
        Me.LogoutLabel.Size = New System.Drawing.Size(90, 29)
        Me.LogoutLabel.TabIndex = 18
        Me.LogoutLabel.Text = "Logout"
        '
        'AccountLabel
        '
        Me.AccountLabel.AutoSize = True
        Me.AccountLabel.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AccountLabel.Location = New System.Drawing.Point(524, 613)
        Me.AccountLabel.Name = "AccountLabel"
        Me.AccountLabel.Size = New System.Drawing.Size(161, 29)
        Me.AccountLabel.TabIndex = 20
        Me.AccountLabel.Text = "Your Account"
        '
        'AccountPictureBox
        '
        Me.AccountPictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AccountPictureBox.Image = Global.StockOverflow_Inventory_Management_System.My.Resources.Resources.user
        Me.AccountPictureBox.Location = New System.Drawing.Point(511, 424)
        Me.AccountPictureBox.Name = "AccountPictureBox"
        Me.AccountPictureBox.Size = New System.Drawing.Size(185, 181)
        Me.AccountPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AccountPictureBox.TabIndex = 19
        Me.AccountPictureBox.TabStop = False
        '
        'LogoutPictureBox
        '
        Me.LogoutPictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LogoutPictureBox.Image = Global.StockOverflow_Inventory_Management_System.My.Resources.Resources.user_logout
        Me.LogoutPictureBox.Location = New System.Drawing.Point(850, 424)
        Me.LogoutPictureBox.Name = "LogoutPictureBox"
        Me.LogoutPictureBox.Size = New System.Drawing.Size(185, 181)
        Me.LogoutPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoutPictureBox.TabIndex = 16
        Me.LogoutPictureBox.TabStop = False
        '
        'ExitPictureBox
        '
        Me.ExitPictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExitPictureBox.Image = Global.StockOverflow_Inventory_Management_System.My.Resources.Resources._exit
        Me.ExitPictureBox.Location = New System.Drawing.Point(1129, 12)
        Me.ExitPictureBox.Name = "ExitPictureBox"
        Me.ExitPictureBox.Size = New System.Drawing.Size(59, 55)
        Me.ExitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ExitPictureBox.TabIndex = 9
        Me.ExitPictureBox.TabStop = False
        '
        'OrdersPictureBox
        '
        Me.OrdersPictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.OrdersPictureBox.Image = Global.StockOverflow_Inventory_Management_System.My.Resources.Resources.orders
        Me.OrdersPictureBox.Location = New System.Drawing.Point(511, 127)
        Me.OrdersPictureBox.Name = "OrdersPictureBox"
        Me.OrdersPictureBox.Size = New System.Drawing.Size(185, 181)
        Me.OrdersPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.OrdersPictureBox.TabIndex = 3
        Me.OrdersPictureBox.TabStop = False
        '
        'ProductsPictureBox
        '
        Me.ProductsPictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ProductsPictureBox.Image = Global.StockOverflow_Inventory_Management_System.My.Resources.Resources.products
        Me.ProductsPictureBox.Location = New System.Drawing.Point(164, 424)
        Me.ProductsPictureBox.Name = "ProductsPictureBox"
        Me.ProductsPictureBox.Size = New System.Drawing.Size(185, 181)
        Me.ProductsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProductsPictureBox.TabIndex = 2
        Me.ProductsPictureBox.TabStop = False
        '
        'SellersPictureBox
        '
        Me.SellersPictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SellersPictureBox.Image = Global.StockOverflow_Inventory_Management_System.My.Resources.Resources.seller
        Me.SellersPictureBox.Location = New System.Drawing.Point(850, 127)
        Me.SellersPictureBox.Name = "SellersPictureBox"
        Me.SellersPictureBox.Size = New System.Drawing.Size(185, 181)
        Me.SellersPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SellersPictureBox.TabIndex = 1
        Me.SellersPictureBox.TabStop = False
        '
        'CustomersPictureBox
        '
        Me.CustomersPictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CustomersPictureBox.Image = Global.StockOverflow_Inventory_Management_System.My.Resources.Resources.customer
        Me.CustomersPictureBox.Location = New System.Drawing.Point(164, 127)
        Me.CustomersPictureBox.Name = "CustomersPictureBox"
        Me.CustomersPictureBox.Size = New System.Drawing.Size(185, 181)
        Me.CustomersPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CustomersPictureBox.TabIndex = 0
        Me.CustomersPictureBox.TabStop = False
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1200, 700)
        Me.Controls.Add(Me.AccountLabel)
        Me.Controls.Add(Me.AccountPictureBox)
        Me.Controls.Add(Me.LogoutLabel)
        Me.Controls.Add(Me.LogoutPictureBox)
        Me.Controls.Add(Me.ExitPictureBox)
        Me.Controls.Add(Me.ProductsLabel)
        Me.Controls.Add(Me.OrdersLabel)
        Me.Controls.Add(Me.SellersLabel)
        Me.Controls.Add(Me.CustomersLabel)
        Me.Controls.Add(Me.HeaderLabel)
        Me.Controls.Add(Me.OrdersPictureBox)
        Me.Controls.Add(Me.ProductsPictureBox)
        Me.Controls.Add(Me.SellersPictureBox)
        Me.Controls.Add(Me.CustomersPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        CType(Me.AccountPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoutPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExitPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SellersPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CustomersPictureBox As PictureBox
    Friend WithEvents SellersPictureBox As PictureBox
    Friend WithEvents ProductsPictureBox As PictureBox
    Friend WithEvents OrdersPictureBox As PictureBox
    Friend WithEvents HeaderLabel As Label
    Friend WithEvents CustomersLabel As Label
    Friend WithEvents SellersLabel As Label
    Friend WithEvents OrdersLabel As Label
    Friend WithEvents ProductsLabel As Label
    Friend WithEvents ExitPictureBox As PictureBox
    Friend WithEvents LogoutPictureBox As PictureBox
    Friend WithEvents LogoutLabel As Label
    Friend WithEvents AccountLabel As Label
    Friend WithEvents AccountPictureBox As PictureBox
End Class
