<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Products
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.NoDataLabel = New System.Windows.Forms.Label()
        Me.NoDataPanel = New System.Windows.Forms.Panel()
        Me.ClearAllRecordsButton = New System.Windows.Forms.Button()
        Me.SearchLabel = New System.Windows.Forms.Label()
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.PriceLabel = New System.Windows.Forms.Label()
        Me.QuantityLabel = New System.Windows.Forms.Label()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.PriceBox = New System.Windows.Forms.TextBox()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.BackPictureBox = New System.Windows.Forms.PictureBox()
        Me.ExitPictureBox = New System.Windows.Forms.PictureBox()
        Me.UpdateColumn = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.DeleteColumn = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.QuantityBox = New System.Windows.Forms.TextBox()
        Me.ProductsGridView = New System.Windows.Forms.DataGridView()
        Me.HeaderLabel = New System.Windows.Forms.Label()
        Me.NoDataPanel.SuspendLayout()
        CType(Me.BackPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExitPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductsGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NoDataLabel
        '
        Me.NoDataLabel.AutoSize = True
        Me.NoDataLabel.Font = New System.Drawing.Font("Trebuchet MS", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoDataLabel.ForeColor = System.Drawing.Color.Red
        Me.NoDataLabel.Location = New System.Drawing.Point(151, 122)
        Me.NoDataLabel.Name = "NoDataLabel"
        Me.NoDataLabel.Size = New System.Drawing.Size(757, 49)
        Me.NoDataLabel.TabIndex = 24
        Me.NoDataLabel.Text = "No Product Records found at the moment"
        '
        'NoDataPanel
        '
        Me.NoDataPanel.BackColor = System.Drawing.Color.White
        Me.NoDataPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NoDataPanel.Controls.Add(Me.NoDataLabel)
        Me.NoDataPanel.Location = New System.Drawing.Point(85, 319)
        Me.NoDataPanel.Name = "NoDataPanel"
        Me.NoDataPanel.Size = New System.Drawing.Size(1028, 314)
        Me.NoDataPanel.TabIndex = 38
        '
        'ClearAllRecordsButton
        '
        Me.ClearAllRecordsButton.BackColor = System.Drawing.Color.IndianRed
        Me.ClearAllRecordsButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClearAllRecordsButton.FlatAppearance.BorderSize = 0
        Me.ClearAllRecordsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearAllRecordsButton.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearAllRecordsButton.ForeColor = System.Drawing.Color.White
        Me.ClearAllRecordsButton.Location = New System.Drawing.Point(915, 242)
        Me.ClearAllRecordsButton.Name = "ClearAllRecordsButton"
        Me.ClearAllRecordsButton.Size = New System.Drawing.Size(198, 35)
        Me.ClearAllRecordsButton.TabIndex = 29
        Me.ClearAllRecordsButton.Text = "Clear All Records"
        Me.ClearAllRecordsButton.UseVisualStyleBackColor = False
        '
        'SearchLabel
        '
        Me.SearchLabel.AutoSize = True
        Me.SearchLabel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SearchLabel.Location = New System.Drawing.Point(80, 213)
        Me.SearchLabel.Name = "SearchLabel"
        Me.SearchLabel.Size = New System.Drawing.Size(278, 26)
        Me.SearchLabel.TabIndex = 37
        Me.SearchLabel.Text = "Search Product by Username:"
        '
        'SearchBox
        '
        Me.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SearchBox.Font = New System.Drawing.Font("Bahnschrift SemiLight", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBox.Location = New System.Drawing.Point(85, 242)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(813, 35)
        Me.SearchBox.TabIndex = 28
        '
        'AddButton
        '
        Me.AddButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AddButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddButton.FlatAppearance.BorderSize = 0
        Me.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddButton.Font = New System.Drawing.Font("Trebuchet MS", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddButton.ForeColor = System.Drawing.Color.White
        Me.AddButton.Location = New System.Drawing.Point(915, 147)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(198, 35)
        Me.AddButton.TabIndex = 27
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'PriceLabel
        '
        Me.PriceLabel.AutoSize = True
        Me.PriceLabel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PriceLabel.Location = New System.Drawing.Point(358, 118)
        Me.PriceLabel.Name = "PriceLabel"
        Me.PriceLabel.Size = New System.Drawing.Size(64, 26)
        Me.PriceLabel.TabIndex = 36
        Me.PriceLabel.Text = "Price:"
        '
        'QuantityLabel
        '
        Me.QuantityLabel.AutoSize = True
        Me.QuantityLabel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.QuantityLabel.Location = New System.Drawing.Point(636, 118)
        Me.QuantityLabel.Name = "QuantityLabel"
        Me.QuantityLabel.Size = New System.Drawing.Size(98, 26)
        Me.QuantityLabel.TabIndex = 35
        Me.QuantityLabel.Text = "Quantity:"
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.NameLabel.Location = New System.Drawing.Point(80, 118)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(71, 26)
        Me.NameLabel.TabIndex = 34
        Me.NameLabel.Text = "Name:"
        '
        'PriceBox
        '
        Me.PriceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PriceBox.Font = New System.Drawing.Font("Bahnschrift SemiLight", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceBox.Location = New System.Drawing.Point(363, 147)
        Me.PriceBox.Name = "PriceBox"
        Me.PriceBox.Size = New System.Drawing.Size(257, 35)
        Me.PriceBox.TabIndex = 25
        '
        'NameBox
        '
        Me.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NameBox.Font = New System.Drawing.Font("Bahnschrift SemiLight", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameBox.Location = New System.Drawing.Point(85, 147)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(257, 35)
        Me.NameBox.TabIndex = 24
        '
        'BackPictureBox
        '
        Me.BackPictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BackPictureBox.Image = Global.StockOverflow_Inventory_Management_System.My.Resources.Resources.back
        Me.BackPictureBox.Location = New System.Drawing.Point(12, 12)
        Me.BackPictureBox.Name = "BackPictureBox"
        Me.BackPictureBox.Size = New System.Drawing.Size(59, 55)
        Me.BackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BackPictureBox.TabIndex = 33
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
        'UpdateColumn
        '
        Me.UpdateColumn.HeaderText = "Change"
        Me.UpdateColumn.MinimumWidth = 6
        Me.UpdateColumn.Name = "UpdateColumn"
        Me.UpdateColumn.ReadOnly = True
        Me.UpdateColumn.Text = "Update"
        Me.UpdateColumn.UseColumnTextForLinkValue = True
        '
        'DeleteColumn
        '
        Me.DeleteColumn.HeaderText = "Remove"
        Me.DeleteColumn.MinimumWidth = 6
        Me.DeleteColumn.Name = "DeleteColumn"
        Me.DeleteColumn.ReadOnly = True
        Me.DeleteColumn.Text = "Delete"
        Me.DeleteColumn.UseColumnTextForLinkValue = True
        '
        'QuantityBox
        '
        Me.QuantityBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.QuantityBox.Font = New System.Drawing.Font("Bahnschrift SemiLight", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityBox.Location = New System.Drawing.Point(641, 147)
        Me.QuantityBox.Name = "QuantityBox"
        Me.QuantityBox.Size = New System.Drawing.Size(257, 35)
        Me.QuantityBox.TabIndex = 26
        '
        'ProductsGridView
        '
        Me.ProductsGridView.AllowUserToAddRows = False
        Me.ProductsGridView.AllowUserToDeleteRows = False
        Me.ProductsGridView.AllowUserToOrderColumns = True
        Me.ProductsGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.ProductsGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ProductsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ProductsGridView.BackgroundColor = System.Drawing.Color.White
        Me.ProductsGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.ProductsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ProductsGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.ProductsGridView.ColumnHeadersHeight = 40
        Me.ProductsGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DeleteColumn, Me.UpdateColumn})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ProductsGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.ProductsGridView.EnableHeadersVisualStyles = False
        Me.ProductsGridView.Location = New System.Drawing.Point(85, 319)
        Me.ProductsGridView.Name = "ProductsGridView"
        Me.ProductsGridView.ReadOnly = True
        Me.ProductsGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.ProductsGridView.RowHeadersVisible = False
        Me.ProductsGridView.RowHeadersWidth = 51
        Me.ProductsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.ProductsGridView.RowTemplate.Height = 40
        Me.ProductsGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ProductsGridView.Size = New System.Drawing.Size(1028, 314)
        Me.ProductsGridView.TabIndex = 32
        Me.ProductsGridView.TabStop = False
        '
        'HeaderLabel
        '
        Me.HeaderLabel.AutoSize = True
        Me.HeaderLabel.Font = New System.Drawing.Font("Trebuchet MS", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HeaderLabel.Location = New System.Drawing.Point(505, 18)
        Me.HeaderLabel.Name = "HeaderLabel"
        Me.HeaderLabel.Size = New System.Drawing.Size(187, 49)
        Me.HeaderLabel.TabIndex = 31
        Me.HeaderLabel.Text = " Products" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Products
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1200, 700)
        Me.Controls.Add(Me.NoDataPanel)
        Me.Controls.Add(Me.ClearAllRecordsButton)
        Me.Controls.Add(Me.SearchLabel)
        Me.Controls.Add(Me.SearchBox)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.PriceLabel)
        Me.Controls.Add(Me.QuantityLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.PriceBox)
        Me.Controls.Add(Me.NameBox)
        Me.Controls.Add(Me.BackPictureBox)
        Me.Controls.Add(Me.ExitPictureBox)
        Me.Controls.Add(Me.QuantityBox)
        Me.Controls.Add(Me.ProductsGridView)
        Me.Controls.Add(Me.HeaderLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Products"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Products"
        Me.NoDataPanel.ResumeLayout(False)
        Me.NoDataPanel.PerformLayout()
        CType(Me.BackPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExitPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductsGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NoDataLabel As Label
    Friend WithEvents NoDataPanel As Panel
    Friend WithEvents ClearAllRecordsButton As Button
    Friend WithEvents SearchLabel As Label
    Friend WithEvents SearchBox As TextBox
    Friend WithEvents AddButton As Button
    Friend WithEvents PriceLabel As Label
    Friend WithEvents QuantityLabel As Label
    Friend WithEvents NameLabel As Label
    Friend WithEvents PriceBox As TextBox
    Friend WithEvents NameBox As TextBox
    Friend WithEvents BackPictureBox As PictureBox
    Friend WithEvents ExitPictureBox As PictureBox
    Friend WithEvents UpdateColumn As DataGridViewLinkColumn
    Friend WithEvents DeleteColumn As DataGridViewLinkColumn
    Friend WithEvents QuantityBox As TextBox
    Friend WithEvents ProductsGridView As DataGridView
    Friend WithEvents HeaderLabel As Label
End Class
