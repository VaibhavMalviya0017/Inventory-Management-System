<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateOrder
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
        Me.BackPictureBox = New System.Windows.Forms.PictureBox()
        Me.HeaderLabel = New System.Windows.Forms.Label()
        Me.ExitPictureBox = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CustomerErrorLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CustomerIdBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CustomerPhoneLabel = New System.Windows.Forms.Label()
        Me.CustomerEmailLabel = New System.Windows.Forms.Label()
        Me.CustomerNameLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ProductQtyLabel = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ProductPriceLabel = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ProductNameLabel = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ProductErrorLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ProductIdBox = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.QuantityErrorLabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.QuantityBox = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.OrderDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.CreateButton = New System.Windows.Forms.Button()
        CType(Me.BackPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExitPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'BackPictureBox
        '
        Me.BackPictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BackPictureBox.Image = Global.StockOverflow_Inventory_Management_System.My.Resources.Resources.back
        Me.BackPictureBox.Location = New System.Drawing.Point(12, 12)
        Me.BackPictureBox.Name = "BackPictureBox"
        Me.BackPictureBox.Size = New System.Drawing.Size(59, 55)
        Me.BackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BackPictureBox.TabIndex = 16
        Me.BackPictureBox.TabStop = False
        '
        'HeaderLabel
        '
        Me.HeaderLabel.AutoSize = True
        Me.HeaderLabel.Font = New System.Drawing.Font("Trebuchet MS", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HeaderLabel.Location = New System.Drawing.Point(476, 18)
        Me.HeaderLabel.Name = "HeaderLabel"
        Me.HeaderLabel.Size = New System.Drawing.Size(265, 49)
        Me.HeaderLabel.TabIndex = 15
        Me.HeaderLabel.Text = " Create Order"
        '
        'ExitPictureBox
        '
        Me.ExitPictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExitPictureBox.Image = Global.StockOverflow_Inventory_Management_System.My.Resources.Resources._exit
        Me.ExitPictureBox.Location = New System.Drawing.Point(1129, 12)
        Me.ExitPictureBox.Name = "ExitPictureBox"
        Me.ExitPictureBox.Size = New System.Drawing.Size(59, 55)
        Me.ExitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ExitPictureBox.TabIndex = 14
        Me.ExitPictureBox.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CustomerErrorLabel)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CustomerIdBox)
        Me.Panel1.Location = New System.Drawing.Point(77, 124)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(519, 124)
        Me.Panel1.TabIndex = 11
        '
        'CustomerErrorLabel
        '
        Me.CustomerErrorLabel.AutoSize = True
        Me.CustomerErrorLabel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerErrorLabel.ForeColor = System.Drawing.Color.Red
        Me.CustomerErrorLabel.Location = New System.Drawing.Point(392, 92)
        Me.CustomerErrorLabel.Name = "CustomerErrorLabel"
        Me.CustomerErrorLabel.Size = New System.Drawing.Size(97, 26)
        Me.CustomerErrorLabel.TabIndex = 20
        Me.CustomerErrorLabel.Text = "Invalid Id"
        Me.CustomerErrorLabel.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(22, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 26)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Customer Id:"
        '
        'CustomerIdBox
        '
        Me.CustomerIdBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CustomerIdBox.Font = New System.Drawing.Font("Bahnschrift SemiLight", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerIdBox.Location = New System.Drawing.Point(27, 54)
        Me.CustomerIdBox.Name = "CustomerIdBox"
        Me.CustomerIdBox.Size = New System.Drawing.Size(462, 35)
        Me.CustomerIdBox.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.CustomerPhoneLabel)
        Me.Panel2.Controls.Add(Me.CustomerEmailLabel)
        Me.Panel2.Controls.Add(Me.CustomerNameLabel)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Location = New System.Drawing.Point(595, 124)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(519, 124)
        Me.Panel2.TabIndex = 18
        '
        'CustomerPhoneLabel
        '
        Me.CustomerPhoneLabel.AutoSize = True
        Me.CustomerPhoneLabel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerPhoneLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CustomerPhoneLabel.Location = New System.Drawing.Point(97, 81)
        Me.CustomerPhoneLabel.Name = "CustomerPhoneLabel"
        Me.CustomerPhoneLabel.Size = New System.Drawing.Size(84, 26)
        Me.CustomerPhoneLabel.TabIndex = 25
        Me.CustomerPhoneLabel.Text = "No Data"
        '
        'CustomerEmailLabel
        '
        Me.CustomerEmailLabel.AutoSize = True
        Me.CustomerEmailLabel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerEmailLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CustomerEmailLabel.Location = New System.Drawing.Point(97, 46)
        Me.CustomerEmailLabel.Name = "CustomerEmailLabel"
        Me.CustomerEmailLabel.Size = New System.Drawing.Size(84, 26)
        Me.CustomerEmailLabel.TabIndex = 24
        Me.CustomerEmailLabel.Text = "No Data"
        '
        'CustomerNameLabel
        '
        Me.CustomerNameLabel.AutoSize = True
        Me.CustomerNameLabel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CustomerNameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CustomerNameLabel.Location = New System.Drawing.Point(97, 13)
        Me.CustomerNameLabel.Name = "CustomerNameLabel"
        Me.CustomerNameLabel.Size = New System.Drawing.Size(84, 26)
        Me.CustomerNameLabel.TabIndex = 23
        Me.CustomerNameLabel.Text = "No Data"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(21, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 26)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Email:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(20, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 26)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Phone:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(20, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 26)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Name:"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.ProductQtyLabel)
        Me.Panel4.Controls.Add(Me.Label13)
        Me.Panel4.Controls.Add(Me.ProductPriceLabel)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.ProductNameLabel)
        Me.Panel4.Controls.Add(Me.Label11)
        Me.Panel4.Location = New System.Drawing.Point(595, 247)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(519, 124)
        Me.Panel4.TabIndex = 20
        '
        'ProductQtyLabel
        '
        Me.ProductQtyLabel.AutoSize = True
        Me.ProductQtyLabel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductQtyLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ProductQtyLabel.Location = New System.Drawing.Point(98, 82)
        Me.ProductQtyLabel.Name = "ProductQtyLabel"
        Me.ProductQtyLabel.Size = New System.Drawing.Size(84, 26)
        Me.ProductQtyLabel.TabIndex = 31
        Me.ProductQtyLabel.Text = "No Data"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(21, 14)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 26)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Name:"
        '
        'ProductPriceLabel
        '
        Me.ProductPriceLabel.AutoSize = True
        Me.ProductPriceLabel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductPriceLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ProductPriceLabel.Location = New System.Drawing.Point(98, 47)
        Me.ProductPriceLabel.Name = "ProductPriceLabel"
        Me.ProductPriceLabel.Size = New System.Drawing.Size(84, 26)
        Me.ProductPriceLabel.TabIndex = 30
        Me.ProductPriceLabel.Text = "No Data"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(21, 82)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(54, 26)
        Me.Label12.TabIndex = 27
        Me.Label12.Text = "QTY:"
        '
        'ProductNameLabel
        '
        Me.ProductNameLabel.AutoSize = True
        Me.ProductNameLabel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductNameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ProductNameLabel.Location = New System.Drawing.Point(98, 14)
        Me.ProductNameLabel.Name = "ProductNameLabel"
        Me.ProductNameLabel.Size = New System.Drawing.Size(84, 26)
        Me.ProductNameLabel.TabIndex = 29
        Me.ProductNameLabel.Text = "No Data"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(22, 47)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 26)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Price:"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.ProductErrorLabel)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.ProductIdBox)
        Me.Panel3.Location = New System.Drawing.Point(77, 247)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(519, 124)
        Me.Panel3.TabIndex = 12
        '
        'ProductErrorLabel
        '
        Me.ProductErrorLabel.AutoSize = True
        Me.ProductErrorLabel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductErrorLabel.ForeColor = System.Drawing.Color.Red
        Me.ProductErrorLabel.Location = New System.Drawing.Point(392, 91)
        Me.ProductErrorLabel.Name = "ProductErrorLabel"
        Me.ProductErrorLabel.Size = New System.Drawing.Size(97, 26)
        Me.ProductErrorLabel.TabIndex = 21
        Me.ProductErrorLabel.Text = "Invalid Id"
        Me.ProductErrorLabel.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(22, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 26)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Product Id:"
        '
        'ProductIdBox
        '
        Me.ProductIdBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductIdBox.Font = New System.Drawing.Font("Bahnschrift SemiLight", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductIdBox.Location = New System.Drawing.Point(27, 53)
        Me.ProductIdBox.Name = "ProductIdBox"
        Me.ProductIdBox.Size = New System.Drawing.Size(462, 35)
        Me.ProductIdBox.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.QuantityErrorLabel)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.QuantityBox)
        Me.Panel6.Location = New System.Drawing.Point(595, 370)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(519, 124)
        Me.Panel6.TabIndex = 14
        '
        'QuantityErrorLabel
        '
        Me.QuantityErrorLabel.AutoSize = True
        Me.QuantityErrorLabel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityErrorLabel.ForeColor = System.Drawing.Color.Red
        Me.QuantityErrorLabel.Location = New System.Drawing.Point(374, 92)
        Me.QuantityErrorLabel.Name = "QuantityErrorLabel"
        Me.QuantityErrorLabel.Size = New System.Drawing.Size(117, 26)
        Me.QuantityErrorLabel.TabIndex = 22
        Me.QuantityErrorLabel.Text = "Invalid QTY"
        Me.QuantityErrorLabel.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(21, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 26)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Quantity:"
        '
        'QuantityBox
        '
        Me.QuantityBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.QuantityBox.Font = New System.Drawing.Font("Bahnschrift SemiLight", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityBox.Location = New System.Drawing.Point(25, 54)
        Me.QuantityBox.Name = "QuantityBox"
        Me.QuantityBox.Size = New System.Drawing.Size(465, 35)
        Me.QuantityBox.TabIndex = 3
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.OrderDatePicker)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Location = New System.Drawing.Point(77, 370)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(519, 124)
        Me.Panel5.TabIndex = 13
        '
        'OrderDatePicker
        '
        Me.OrderDatePicker.Font = New System.Drawing.Font("Bahnschrift SemiLight", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderDatePicker.Location = New System.Drawing.Point(27, 54)
        Me.OrderDatePicker.Name = "OrderDatePicker"
        Me.OrderDatePicker.Size = New System.Drawing.Size(462, 35)
        Me.OrderDatePicker.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(22, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 26)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Order Date:"
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.CreateButton)
        Me.Panel7.Location = New System.Drawing.Point(77, 493)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1037, 124)
        Me.Panel7.TabIndex = 15
        '
        'CreateButton
        '
        Me.CreateButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CreateButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CreateButton.FlatAppearance.BorderSize = 0
        Me.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreateButton.Font = New System.Drawing.Font("Trebuchet MS", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateButton.ForeColor = System.Drawing.Color.White
        Me.CreateButton.Location = New System.Drawing.Point(27, 38)
        Me.CreateButton.Name = "CreateButton"
        Me.CreateButton.Size = New System.Drawing.Size(982, 52)
        Me.CreateButton.TabIndex = 4
        Me.CreateButton.Text = "Create Order"
        Me.CreateButton.UseVisualStyleBackColor = False
        '
        'CreateOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1200, 700)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BackPictureBox)
        Me.Controls.Add(Me.HeaderLabel)
        Me.Controls.Add(Me.ExitPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CreateOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Orders"
        CType(Me.BackPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExitPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackPictureBox As PictureBox
    Friend WithEvents HeaderLabel As Label
    Friend WithEvents ExitPictureBox As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents CustomerIdBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ProductIdBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents OrderDatePicker As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents QuantityBox As TextBox
    Friend WithEvents CreateButton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CustomerNameLabel As Label
    Friend WithEvents CustomerEmailLabel As Label
    Friend WithEvents CustomerPhoneLabel As Label
    Friend WithEvents ProductQtyLabel As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ProductPriceLabel As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents ProductNameLabel As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents CustomerErrorLabel As Label
    Friend WithEvents ProductErrorLabel As Label
    Friend WithEvents QuantityErrorLabel As Label
End Class
