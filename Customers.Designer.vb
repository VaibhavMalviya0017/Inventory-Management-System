<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customers
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
        Me.HeaderLabel = New System.Windows.Forms.Label()
        Me.CustomersGridView = New System.Windows.Forms.DataGridView()
        Me.DeleteColumn = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.UpdateColumn = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.BackPictureBox = New System.Windows.Forms.PictureBox()
        Me.ExitPictureBox = New System.Windows.Forms.PictureBox()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumberBox = New System.Windows.Forms.TextBox()
        Me.EmailBox = New System.Windows.Forms.TextBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.PhoneNumberLabel = New System.Windows.Forms.Label()
        Me.EmailLabel = New System.Windows.Forms.Label()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.SearchLabel = New System.Windows.Forms.Label()
        Me.ClearAllRecordsButton = New System.Windows.Forms.Button()
        Me.NoDataPanel = New System.Windows.Forms.Panel()
        Me.NoDataLabel = New System.Windows.Forms.Label()
        CType(Me.CustomersGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExitPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NoDataPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'HeaderLabel
        '
        Me.HeaderLabel.AutoSize = True
        Me.HeaderLabel.Font = New System.Drawing.Font("Trebuchet MS", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeaderLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.HeaderLabel.Location = New System.Drawing.Point(485, 18)
        Me.HeaderLabel.Name = "HeaderLabel"
        Me.HeaderLabel.Size = New System.Drawing.Size(218, 49)
        Me.HeaderLabel.TabIndex = 11
        Me.HeaderLabel.Text = " Customers"
        '
        'CustomersGridView
        '
        Me.CustomersGridView.AllowUserToAddRows = False
        Me.CustomersGridView.AllowUserToDeleteRows = False
        Me.CustomersGridView.AllowUserToOrderColumns = True
        Me.CustomersGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.CustomersGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.CustomersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.CustomersGridView.BackgroundColor = System.Drawing.Color.White
        Me.CustomersGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.CustomersGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CustomersGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.CustomersGridView.ColumnHeadersHeight = 40
        Me.CustomersGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DeleteColumn, Me.UpdateColumn})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Trebuchet MS", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CustomersGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.CustomersGridView.EnableHeadersVisualStyles = False
        Me.CustomersGridView.Location = New System.Drawing.Point(85, 319)
        Me.CustomersGridView.Name = "CustomersGridView"
        Me.CustomersGridView.ReadOnly = True
        Me.CustomersGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.CustomersGridView.RowHeadersVisible = False
        Me.CustomersGridView.RowHeadersWidth = 51
        Me.CustomersGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.CustomersGridView.RowTemplate.Height = 40
        Me.CustomersGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CustomersGridView.Size = New System.Drawing.Size(1028, 314)
        Me.CustomersGridView.TabIndex = 12
        Me.CustomersGridView.TabStop = False
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
        'UpdateColumn
        '
        Me.UpdateColumn.HeaderText = "Change"
        Me.UpdateColumn.MinimumWidth = 6
        Me.UpdateColumn.Name = "UpdateColumn"
        Me.UpdateColumn.ReadOnly = True
        Me.UpdateColumn.Text = "Update"
        Me.UpdateColumn.UseColumnTextForLinkValue = True
        '
        'BackPictureBox
        '
        Me.BackPictureBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BackPictureBox.Image = Global.StockOverflow_Inventory_Management_System.My.Resources.Resources.back
        Me.BackPictureBox.Location = New System.Drawing.Point(12, 12)
        Me.BackPictureBox.Name = "BackPictureBox"
        Me.BackPictureBox.Size = New System.Drawing.Size(59, 55)
        Me.BackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BackPictureBox.TabIndex = 13
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
        Me.ExitPictureBox.TabIndex = 10
        Me.ExitPictureBox.TabStop = False
        '
        'NameBox
        '
        Me.NameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NameBox.Font = New System.Drawing.Font("Bahnschrift SemiLight", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameBox.Location = New System.Drawing.Point(85, 147)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(257, 35)
        Me.NameBox.TabIndex = 0
        '
        'PhoneNumberBox
        '
        Me.PhoneNumberBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PhoneNumberBox.Font = New System.Drawing.Font("Bahnschrift SemiLight", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneNumberBox.Location = New System.Drawing.Point(641, 147)
        Me.PhoneNumberBox.Name = "PhoneNumberBox"
        Me.PhoneNumberBox.Size = New System.Drawing.Size(257, 35)
        Me.PhoneNumberBox.TabIndex = 2
        '
        'EmailBox
        '
        Me.EmailBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmailBox.Font = New System.Drawing.Font("Bahnschrift SemiLight", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailBox.Location = New System.Drawing.Point(363, 147)
        Me.EmailBox.Name = "EmailBox"
        Me.EmailBox.Size = New System.Drawing.Size(257, 35)
        Me.EmailBox.TabIndex = 1
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.NameLabel.Location = New System.Drawing.Point(80, 118)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(71, 26)
        Me.NameLabel.TabIndex = 17
        Me.NameLabel.Text = "Name:"
        '
        'PhoneNumberLabel
        '
        Me.PhoneNumberLabel.AutoSize = True
        Me.PhoneNumberLabel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneNumberLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PhoneNumberLabel.Location = New System.Drawing.Point(636, 118)
        Me.PhoneNumberLabel.Name = "PhoneNumberLabel"
        Me.PhoneNumberLabel.Size = New System.Drawing.Size(150, 26)
        Me.PhoneNumberLabel.TabIndex = 18
        Me.PhoneNumberLabel.Text = "Phone Number:"
        '
        'EmailLabel
        '
        Me.EmailLabel.AutoSize = True
        Me.EmailLabel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EmailLabel.Location = New System.Drawing.Point(358, 118)
        Me.EmailLabel.Name = "EmailLabel"
        Me.EmailLabel.Size = New System.Drawing.Size(144, 26)
        Me.EmailLabel.TabIndex = 19
        Me.EmailLabel.Text = "Email Address:"
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
        Me.AddButton.TabIndex = 3
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = False
        '
        'SearchBox
        '
        Me.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SearchBox.Font = New System.Drawing.Font("Bahnschrift SemiLight", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBox.Location = New System.Drawing.Point(85, 242)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(813, 35)
        Me.SearchBox.TabIndex = 4
        '
        'SearchLabel
        '
        Me.SearchLabel.AutoSize = True
        Me.SearchLabel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SearchLabel.Location = New System.Drawing.Point(80, 213)
        Me.SearchLabel.Name = "SearchLabel"
        Me.SearchLabel.Size = New System.Drawing.Size(295, 26)
        Me.SearchLabel.TabIndex = 22
        Me.SearchLabel.Text = "Search Customer by Username:"
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
        Me.ClearAllRecordsButton.TabIndex = 5
        Me.ClearAllRecordsButton.Text = "Clear All Records"
        Me.ClearAllRecordsButton.UseVisualStyleBackColor = False
        '
        'NoDataPanel
        '
        Me.NoDataPanel.BackColor = System.Drawing.Color.White
        Me.NoDataPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NoDataPanel.Controls.Add(Me.NoDataLabel)
        Me.NoDataPanel.Location = New System.Drawing.Point(85, 319)
        Me.NoDataPanel.Name = "NoDataPanel"
        Me.NoDataPanel.Size = New System.Drawing.Size(1028, 314)
        Me.NoDataPanel.TabIndex = 23
        '
        'NoDataLabel
        '
        Me.NoDataLabel.AutoSize = True
        Me.NoDataLabel.Font = New System.Drawing.Font("Trebuchet MS", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoDataLabel.ForeColor = System.Drawing.Color.Red
        Me.NoDataLabel.Location = New System.Drawing.Point(143, 122)
        Me.NoDataLabel.Name = "NoDataLabel"
        Me.NoDataLabel.Size = New System.Drawing.Size(788, 49)
        Me.NoDataLabel.TabIndex = 24
        Me.NoDataLabel.Text = "No Customer Records found at the moment"
        '
        'Customers
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
        Me.Controls.Add(Me.EmailLabel)
        Me.Controls.Add(Me.PhoneNumberLabel)
        Me.Controls.Add(Me.NameLabel)
        Me.Controls.Add(Me.EmailBox)
        Me.Controls.Add(Me.PhoneNumberBox)
        Me.Controls.Add(Me.NameBox)
        Me.Controls.Add(Me.BackPictureBox)
        Me.Controls.Add(Me.CustomersGridView)
        Me.Controls.Add(Me.HeaderLabel)
        Me.Controls.Add(Me.ExitPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Customers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customers"
        CType(Me.CustomersGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExitPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NoDataPanel.ResumeLayout(False)
        Me.NoDataPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitPictureBox As PictureBox
    Friend WithEvents HeaderLabel As Label
    Friend WithEvents CustomersGridView As DataGridView
    Friend WithEvents BackPictureBox As PictureBox
    Friend WithEvents NameBox As TextBox
    Friend WithEvents PhoneNumberBox As TextBox
    Friend WithEvents EmailBox As TextBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents PhoneNumberLabel As Label
    Friend WithEvents EmailLabel As Label
    Friend WithEvents AddButton As Button
    Friend WithEvents SearchBox As TextBox
    Friend WithEvents SearchLabel As Label
    Friend WithEvents ClearAllRecordsButton As Button
    Friend WithEvents DeleteColumn As DataGridViewLinkColumn
    Friend WithEvents UpdateColumn As DataGridViewLinkColumn
    Friend WithEvents NoDataPanel As Panel
    Friend WithEvents NoDataLabel As Label
End Class
