<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Orders
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
        Me.BackPictureBox = New System.Windows.Forms.PictureBox()
        Me.HeaderLabel = New System.Windows.Forms.Label()
        Me.ExitPictureBox = New System.Windows.Forms.PictureBox()
        Me.OrdersGridView = New System.Windows.Forms.DataGridView()
        Me.DeleteColumn = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.CreateButton = New System.Windows.Forms.Button()
        Me.NoDataPanel = New System.Windows.Forms.Panel()
        Me.NoDataLabel = New System.Windows.Forms.Label()
        Me.ClearAllButton = New System.Windows.Forms.Button()
        CType(Me.BackPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExitPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NoDataPanel.SuspendLayout()
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
        Me.BackPictureBox.TabIndex = 19
        Me.BackPictureBox.TabStop = False
        '
        'HeaderLabel
        '
        Me.HeaderLabel.AutoSize = True
        Me.HeaderLabel.Font = New System.Drawing.Font("Trebuchet MS", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HeaderLabel.Location = New System.Drawing.Point(681, 18)
        Me.HeaderLabel.Name = "HeaderLabel"
        Me.HeaderLabel.Size = New System.Drawing.Size(163, 49)
        Me.HeaderLabel.TabIndex = 18
        Me.HeaderLabel.Text = "  Orders"
        '
        'ExitPictureBox
        '
        Me.ExitPictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExitPictureBox.Image = Global.StockOverflow_Inventory_Management_System.My.Resources.Resources._exit
        Me.ExitPictureBox.Location = New System.Drawing.Point(1433, 12)
        Me.ExitPictureBox.Name = "ExitPictureBox"
        Me.ExitPictureBox.Size = New System.Drawing.Size(59, 55)
        Me.ExitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ExitPictureBox.TabIndex = 17
        Me.ExitPictureBox.TabStop = False
        '
        'OrdersGridView
        '
        Me.OrdersGridView.AllowUserToAddRows = False
        Me.OrdersGridView.AllowUserToDeleteRows = False
        Me.OrdersGridView.AllowUserToOrderColumns = True
        Me.OrdersGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.OrdersGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.OrdersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.OrdersGridView.BackgroundColor = System.Drawing.Color.White
        Me.OrdersGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.OrdersGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.OrdersGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.OrdersGridView.ColumnHeadersHeight = 40
        Me.OrdersGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DeleteColumn})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.OrdersGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.OrdersGridView.EnableHeadersVisualStyles = False
        Me.OrdersGridView.Location = New System.Drawing.Point(77, 96)
        Me.OrdersGridView.Name = "OrdersGridView"
        Me.OrdersGridView.ReadOnly = True
        Me.OrdersGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.OrdersGridView.RowHeadersVisible = False
        Me.OrdersGridView.RowHeadersWidth = 51
        Me.OrdersGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.OrdersGridView.RowTemplate.Height = 40
        Me.OrdersGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.OrdersGridView.Size = New System.Drawing.Size(1350, 516)
        Me.OrdersGridView.TabIndex = 20
        Me.OrdersGridView.TabStop = False
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
        'CreateButton
        '
        Me.CreateButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CreateButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CreateButton.FlatAppearance.BorderSize = 0
        Me.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreateButton.Font = New System.Drawing.Font("Trebuchet MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreateButton.ForeColor = System.Drawing.Color.White
        Me.CreateButton.Location = New System.Drawing.Point(77, 637)
        Me.CreateButton.Name = "CreateButton"
        Me.CreateButton.Size = New System.Drawing.Size(1350, 50)
        Me.CreateButton.TabIndex = 0
        Me.CreateButton.Text = "Create New Order"
        Me.CreateButton.UseVisualStyleBackColor = False
        '
        'NoDataPanel
        '
        Me.NoDataPanel.BackColor = System.Drawing.Color.White
        Me.NoDataPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NoDataPanel.Controls.Add(Me.NoDataLabel)
        Me.NoDataPanel.Location = New System.Drawing.Point(77, 96)
        Me.NoDataPanel.Name = "NoDataPanel"
        Me.NoDataPanel.Size = New System.Drawing.Size(1350, 516)
        Me.NoDataPanel.TabIndex = 24
        '
        'NoDataLabel
        '
        Me.NoDataLabel.AutoSize = True
        Me.NoDataLabel.Font = New System.Drawing.Font("Trebuchet MS", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoDataLabel.ForeColor = System.Drawing.Color.Red
        Me.NoDataLabel.Location = New System.Drawing.Point(443, 214)
        Me.NoDataLabel.Name = "NoDataLabel"
        Me.NoDataLabel.Size = New System.Drawing.Size(587, 49)
        Me.NoDataLabel.TabIndex = 24
        Me.NoDataLabel.Text = "No Orders found at the moment"
        '
        'ClearAllButton
        '
        Me.ClearAllButton.BackColor = System.Drawing.Color.IndianRed
        Me.ClearAllButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClearAllButton.FlatAppearance.BorderSize = 0
        Me.ClearAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearAllButton.Font = New System.Drawing.Font("Trebuchet MS", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearAllButton.ForeColor = System.Drawing.Color.White
        Me.ClearAllButton.Location = New System.Drawing.Point(77, 706)
        Me.ClearAllButton.Name = "ClearAllButton"
        Me.ClearAllButton.Size = New System.Drawing.Size(1350, 50)
        Me.ClearAllButton.TabIndex = 1
        Me.ClearAllButton.Text = "Clear All"
        Me.ClearAllButton.UseVisualStyleBackColor = False
        '
        'Orders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1504, 778)
        Me.Controls.Add(Me.ClearAllButton)
        Me.Controls.Add(Me.NoDataPanel)
        Me.Controls.Add(Me.CreateButton)
        Me.Controls.Add(Me.OrdersGridView)
        Me.Controls.Add(Me.BackPictureBox)
        Me.Controls.Add(Me.HeaderLabel)
        Me.Controls.Add(Me.ExitPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Orders"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Orders"
        CType(Me.BackPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExitPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NoDataPanel.ResumeLayout(False)
        Me.NoDataPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackPictureBox As PictureBox
    Friend WithEvents HeaderLabel As Label
    Friend WithEvents ExitPictureBox As PictureBox
    Friend WithEvents OrdersGridView As DataGridView
    Friend WithEvents CreateButton As Button
    Friend WithEvents DeleteColumn As DataGridViewLinkColumn
    Friend WithEvents NoDataPanel As Panel
    Friend WithEvents NoDataLabel As Label
    Friend WithEvents ClearAllButton As Button
End Class
