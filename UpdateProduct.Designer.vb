<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateProduct
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.QuantityBox = New System.Windows.Forms.TextBox()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.PriceBox = New System.Windows.Forms.TextBox()
        Me.PriceLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.QuantityLabel = New System.Windows.Forms.Label()
        Me.UpdatePictureBox = New System.Windows.Forms.PictureBox()
        Me.FormPanel = New System.Windows.Forms.Panel()
        Me.HeaderLabel = New System.Windows.Forms.Label()
        Me.BackPictureBox = New System.Windows.Forms.PictureBox()
        Me.ExitPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.UpdatePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FormPanel.SuspendLayout()
        CType(Me.BackPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExitPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'QuantityBox
        '
        Me.QuantityBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.QuantityBox.Font = New System.Drawing.Font("Bahnschrift SemiLight", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityBox.Location = New System.Drawing.Point(49, 248)
        Me.QuantityBox.Name = "QuantityBox"
        Me.QuantityBox.Size = New System.Drawing.Size(257, 35)
        Me.QuantityBox.TabIndex = 2
        '
        'NameBox
        '
        Me.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NameBox.Font = New System.Drawing.Font("Bahnschrift SemiLight", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameBox.Location = New System.Drawing.Point(49, 62)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(257, 35)
        Me.NameBox.TabIndex = 0
        '
        'UpdateButton
        '
        Me.UpdateButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UpdateButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UpdateButton.FlatAppearance.BorderSize = 0
        Me.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateButton.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateButton.ForeColor = System.Drawing.Color.White
        Me.UpdateButton.Location = New System.Drawing.Point(49, 324)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(257, 35)
        Me.UpdateButton.TabIndex = 3
        Me.UpdateButton.Text = "Update Data"
        Me.UpdateButton.UseVisualStyleBackColor = False
        '
        'PriceBox
        '
        Me.PriceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PriceBox.Font = New System.Drawing.Font("Bahnschrift SemiLight", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceBox.Location = New System.Drawing.Point(49, 154)
        Me.PriceBox.Name = "PriceBox"
        Me.PriceBox.Size = New System.Drawing.Size(257, 35)
        Me.PriceBox.TabIndex = 1
        '
        'PriceLabel
        '
        Me.PriceLabel.AutoSize = True
        Me.PriceLabel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PriceLabel.Location = New System.Drawing.Point(44, 125)
        Me.PriceLabel.Name = "PriceLabel"
        Me.PriceLabel.Size = New System.Drawing.Size(64, 26)
        Me.PriceLabel.TabIndex = 26
        Me.PriceLabel.Text = "Price:"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.NameLabel.Location = New System.Drawing.Point(44, 33)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(71, 26)
        Me.NameLabel.TabIndex = 24
        Me.NameLabel.Text = "Name:"
        '
        'QuantityLabel
        '
        Me.QuantityLabel.AutoSize = True
        Me.QuantityLabel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.QuantityLabel.Location = New System.Drawing.Point(44, 219)
        Me.QuantityLabel.Name = "QuantityLabel"
        Me.QuantityLabel.Size = New System.Drawing.Size(98, 26)
        Me.QuantityLabel.TabIndex = 25
        Me.QuantityLabel.Text = "Quantity:"
        '
        'UpdatePictureBox
        '
        Me.UpdatePictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.UpdatePictureBox.Image = Global.StockOverflow_Inventory_Management_System.My.Resources.Resources.update
        Me.UpdatePictureBox.Location = New System.Drawing.Point(148, 176)
        Me.UpdatePictureBox.Name = "UpdatePictureBox"
        Me.UpdatePictureBox.Size = New System.Drawing.Size(399, 409)
        Me.UpdatePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.UpdatePictureBox.TabIndex = 34
        Me.UpdatePictureBox.TabStop = False
        '
        'FormPanel
        '
        Me.FormPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.FormPanel.Controls.Add(Me.QuantityBox)
        Me.FormPanel.Controls.Add(Me.NameBox)
        Me.FormPanel.Controls.Add(Me.UpdateButton)
        Me.FormPanel.Controls.Add(Me.PriceBox)
        Me.FormPanel.Controls.Add(Me.PriceLabel)
        Me.FormPanel.Controls.Add(Me.NameLabel)
        Me.FormPanel.Controls.Add(Me.QuantityLabel)
        Me.FormPanel.Location = New System.Drawing.Point(692, 176)
        Me.FormPanel.Name = "FormPanel"
        Me.FormPanel.Size = New System.Drawing.Size(351, 409)
        Me.FormPanel.TabIndex = 33
        '
        'HeaderLabel
        '
        Me.HeaderLabel.AutoSize = True
        Me.HeaderLabel.Font = New System.Drawing.Font("Trebuchet MS", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HeaderLabel.Location = New System.Drawing.Point(461, 18)
        Me.HeaderLabel.Name = "HeaderLabel"
        Me.HeaderLabel.Size = New System.Drawing.Size(309, 49)
        Me.HeaderLabel.TabIndex = 32
        Me.HeaderLabel.Text = " Update Product"
        '
        'BackPictureBox
        '
        Me.BackPictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BackPictureBox.Image = Global.StockOverflow_Inventory_Management_System.My.Resources.Resources.back
        Me.BackPictureBox.Location = New System.Drawing.Point(12, 12)
        Me.BackPictureBox.Name = "BackPictureBox"
        Me.BackPictureBox.Size = New System.Drawing.Size(59, 55)
        Me.BackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BackPictureBox.TabIndex = 31
        Me.BackPictureBox.TabStop = False
        '
        'ExitPictureBox
        '
        Me.ExitPictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExitPictureBox.Image = Global.StockOverflow_Inventory_Management_System.My.Resources.Resources._exit
        Me.ExitPictureBox.Location = New System.Drawing.Point(1129, 12)
        Me.ExitPictureBox.Name = "ExitPictureBox"
        Me.ExitPictureBox.Size = New System.Drawing.Size(59, 55)
        Me.ExitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ExitPictureBox.TabIndex = 30
        Me.ExitPictureBox.TabStop = False
        '
        'UpdateProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1200, 700)
        Me.Controls.Add(Me.UpdatePictureBox)
        Me.Controls.Add(Me.FormPanel)
        Me.Controls.Add(Me.HeaderLabel)
        Me.Controls.Add(Me.BackPictureBox)
        Me.Controls.Add(Me.ExitPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UpdateProduct"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UpdateProduct"
        CType(Me.UpdatePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FormPanel.ResumeLayout(False)
        Me.FormPanel.PerformLayout()
        CType(Me.BackPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExitPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents QuantityBox As TextBox
    Friend WithEvents NameBox As TextBox
    Friend WithEvents UpdateButton As Button
    Friend WithEvents PriceBox As TextBox
    Friend WithEvents PriceLabel As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents QuantityLabel As Label
    Friend WithEvents UpdatePictureBox As PictureBox
    Friend WithEvents FormPanel As Panel
    Friend WithEvents HeaderLabel As Label
    Friend WithEvents BackPictureBox As PictureBox
    Friend WithEvents ExitPictureBox As PictureBox
End Class
