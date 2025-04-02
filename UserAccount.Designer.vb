<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserAccount
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
        Me.ContainerPanel = New System.Windows.Forms.Panel()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.EditButton = New System.Windows.Forms.Button()
        Me.PasswordPanelTwo = New System.Windows.Forms.Panel()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.NamePanelTwo = New System.Windows.Forms.Panel()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordPanelOne = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NamePanelOne = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.BackPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExitPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContainerPanel.SuspendLayout()
        Me.PasswordPanelTwo.SuspendLayout()
        Me.NamePanelTwo.SuspendLayout()
        Me.PasswordPanelOne.SuspendLayout()
        Me.NamePanelOne.SuspendLayout()
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
        Me.HeaderLabel.Location = New System.Drawing.Point(461, 18)
        Me.HeaderLabel.Name = "HeaderLabel"
        Me.HeaderLabel.Size = New System.Drawing.Size(265, 49)
        Me.HeaderLabel.TabIndex = 15
        Me.HeaderLabel.Text = " User Account"
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
        'ContainerPanel
        '
        Me.ContainerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ContainerPanel.Controls.Add(Me.DeleteButton)
        Me.ContainerPanel.Controls.Add(Me.EditButton)
        Me.ContainerPanel.Controls.Add(Me.PasswordPanelTwo)
        Me.ContainerPanel.Controls.Add(Me.NamePanelTwo)
        Me.ContainerPanel.Controls.Add(Me.PasswordPanelOne)
        Me.ContainerPanel.Controls.Add(Me.NamePanelOne)
        Me.ContainerPanel.Location = New System.Drawing.Point(70, 110)
        Me.ContainerPanel.Name = "ContainerPanel"
        Me.ContainerPanel.Size = New System.Drawing.Size(1052, 537)
        Me.ContainerPanel.TabIndex = 21
        '
        'DeleteButton
        '
        Me.DeleteButton.BackColor = System.Drawing.Color.IndianRed
        Me.DeleteButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DeleteButton.FlatAppearance.BorderSize = 0
        Me.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteButton.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteButton.ForeColor = System.Drawing.Color.White
        Me.DeleteButton.Location = New System.Drawing.Point(92, 431)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(868, 49)
        Me.DeleteButton.TabIndex = 22
        Me.DeleteButton.Text = "Delete Account"
        Me.DeleteButton.UseVisualStyleBackColor = False
        '
        'EditButton
        '
        Me.EditButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.EditButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EditButton.FlatAppearance.BorderSize = 0
        Me.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditButton.Font = New System.Drawing.Font("Trebuchet MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditButton.ForeColor = System.Drawing.Color.White
        Me.EditButton.Location = New System.Drawing.Point(92, 325)
        Me.EditButton.Name = "EditButton"
        Me.EditButton.Size = New System.Drawing.Size(868, 49)
        Me.EditButton.TabIndex = 21
        Me.EditButton.Text = "Edit Account"
        Me.EditButton.UseVisualStyleBackColor = False
        '
        'PasswordPanelTwo
        '
        Me.PasswordPanelTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PasswordPanelTwo.Controls.Add(Me.PasswordLabel)
        Me.PasswordPanelTwo.Location = New System.Drawing.Point(525, 193)
        Me.PasswordPanelTwo.Name = "PasswordPanelTwo"
        Me.PasswordPanelTwo.Size = New System.Drawing.Size(435, 73)
        Me.PasswordPanelTwo.TabIndex = 26
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Font = New System.Drawing.Font("Bahnschrift", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.ForeColor = System.Drawing.Color.Black
        Me.PasswordLabel.Location = New System.Drawing.Point(7, 17)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(149, 36)
        Me.PasswordLabel.TabIndex = 23
        Me.PasswordLabel.Text = "Password"
        '
        'NamePanelTwo
        '
        Me.NamePanelTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NamePanelTwo.Controls.Add(Me.UsernameLabel)
        Me.NamePanelTwo.Location = New System.Drawing.Point(525, 56)
        Me.NamePanelTwo.Name = "NamePanelTwo"
        Me.NamePanelTwo.Size = New System.Drawing.Size(435, 73)
        Me.NamePanelTwo.TabIndex = 24
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Font = New System.Drawing.Font("Bahnschrift", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.ForeColor = System.Drawing.Color.Black
        Me.UsernameLabel.Location = New System.Drawing.Point(7, 17)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(155, 36)
        Me.UsernameLabel.TabIndex = 22
        Me.UsernameLabel.Text = "Username"
        '
        'PasswordPanelOne
        '
        Me.PasswordPanelOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PasswordPanelOne.Controls.Add(Me.Label2)
        Me.PasswordPanelOne.Location = New System.Drawing.Point(92, 193)
        Me.PasswordPanelOne.Name = "PasswordPanelOne"
        Me.PasswordPanelOne.Size = New System.Drawing.Size(435, 73)
        Me.PasswordPanelOne.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(4, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 36)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Your Password:"
        '
        'NamePanelOne
        '
        Me.NamePanelOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NamePanelOne.Controls.Add(Me.Label1)
        Me.NamePanelOne.Location = New System.Drawing.Point(92, 56)
        Me.NamePanelOne.Name = "NamePanelOne"
        Me.NamePanelOne.Size = New System.Drawing.Size(435, 73)
        Me.NamePanelOne.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(4, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 36)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Your Username:"
        '
        'UserAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1200, 700)
        Me.Controls.Add(Me.ContainerPanel)
        Me.Controls.Add(Me.BackPictureBox)
        Me.Controls.Add(Me.HeaderLabel)
        Me.Controls.Add(Me.ExitPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UserAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserAccount"
        CType(Me.BackPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExitPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContainerPanel.ResumeLayout(False)
        Me.PasswordPanelTwo.ResumeLayout(False)
        Me.PasswordPanelTwo.PerformLayout()
        Me.NamePanelTwo.ResumeLayout(False)
        Me.NamePanelTwo.PerformLayout()
        Me.PasswordPanelOne.ResumeLayout(False)
        Me.PasswordPanelOne.PerformLayout()
        Me.NamePanelOne.ResumeLayout(False)
        Me.NamePanelOne.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackPictureBox As PictureBox
    Friend WithEvents HeaderLabel As Label
    Friend WithEvents ExitPictureBox As PictureBox
    Friend WithEvents ContainerPanel As Panel
    Friend WithEvents DeleteButton As Button
    Friend WithEvents EditButton As Button
    Friend WithEvents PasswordPanelTwo As Panel
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents NamePanelTwo As Panel
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents PasswordPanelOne As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents NamePanelOne As Panel
    Friend WithEvents Label1 As Label
End Class
