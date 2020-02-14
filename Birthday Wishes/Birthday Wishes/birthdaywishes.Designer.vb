<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class birthdaywishes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(birthdaywishes))
        Me.lstOut = New System.Windows.Forms.ListBox()
        Me.btnClick = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblhappybirthday = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstOut
        '
        Me.lstOut.FormattingEnabled = True
        Me.lstOut.ItemHeight = 24
        Me.lstOut.Location = New System.Drawing.Point(103, 431)
        Me.lstOut.Name = "lstOut"
        Me.lstOut.Size = New System.Drawing.Size(403, 196)
        Me.lstOut.TabIndex = 0
        '
        'btnClick
        '
        Me.btnClick.BackColor = System.Drawing.Color.Plum
        Me.btnClick.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClick.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnClick.Location = New System.Drawing.Point(103, 311)
        Me.btnClick.Name = "btnClick"
        Me.btnClick.Size = New System.Drawing.Size(247, 79)
        Me.btnClick.TabIndex = 1
        Me.btnClick.Text = "Click Me!"
        Me.btnClick.UseVisualStyleBackColor = False
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(103, 262)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(247, 30)
        Me.txtName.TabIndex = 2
        '
        'lblhappybirthday
        '
        Me.lblhappybirthday.AutoSize = True
        Me.lblhappybirthday.Font = New System.Drawing.Font("Lucida Calligraphy", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhappybirthday.ForeColor = System.Drawing.Color.DodgerBlue
        Me.lblhappybirthday.Location = New System.Drawing.Point(74, 162)
        Me.lblhappybirthday.Name = "lblhappybirthday"
        Me.lblhappybirthday.Size = New System.Drawing.Size(482, 62)
        Me.lblhappybirthday.TabIndex = 3
        Me.lblhappybirthday.Text = "Happy Birthday!"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Plum
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Location = New System.Drawing.Point(121, 662)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(154, 58)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Plum
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Location = New System.Drawing.Point(388, 662)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(150, 58)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(673, 136)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(515, 537)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'birthdaywishes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Pink
        Me.ClientSize = New System.Drawing.Size(1630, 947)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblhappybirthday)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnClick)
        Me.Controls.Add(Me.lstOut)
        Me.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "birthdaywishes"
        Me.Text = "Birthday Wishes"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstOut As ListBox
    Friend WithEvents btnClick As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblhappybirthday As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
