<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form15
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form15))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btndlt = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnback = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(921, 635)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 16)
        Me.Label2.TabIndex = 164
        Me.Label2.Text = "Customer ID:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(873, 590)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(166, 33)
        Me.TextBox2.TabIndex = 162
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(624, 635)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 16)
        Me.Label4.TabIndex = 161
        Me.Label4.Text = "Fine ID:"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(565, 590)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(166, 33)
        Me.TextBox4.TabIndex = 160
        '
        'btnnext
        '
        Me.btnnext.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnnext.BackgroundImage = CType(resources.GetObject("btnnext.BackgroundImage"), System.Drawing.Image)
        Me.btnnext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnnext.FlatAppearance.BorderSize = 0
        Me.btnnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnext.Location = New System.Drawing.Point(1186, 699)
        Me.btnnext.Margin = New System.Windows.Forms.Padding(2)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(68, 59)
        Me.btnnext.TabIndex = 159
        Me.btnnext.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(850, 710)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(100, 35)
        Me.btnsave.TabIndex = 158
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btndlt
        '
        Me.btndlt.Location = New System.Drawing.Point(688, 710)
        Me.btndlt.Margin = New System.Windows.Forms.Padding(2)
        Me.btndlt.Name = "btndlt"
        Me.btndlt.Size = New System.Drawing.Size(100, 35)
        Me.btndlt.TabIndex = 157
        Me.btndlt.Text = "DELETE"
        Me.btndlt.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(519, 710)
        Me.btnedit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(100, 35)
        Me.btnedit.TabIndex = 156
        Me.btnedit.Text = "EDIT"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(359, 710)
        Me.btnadd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(100, 35)
        Me.btnadd.TabIndex = 155
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(284, 635)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 154
        Me.Label1.Text = "Customer Fine ID:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(266, 590)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(166, 33)
        Me.TextBox1.TabIndex = 153
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(43, 220)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 72
        Me.DataGridView1.RowTemplate.Height = 31
        Me.DataGridView1.Size = New System.Drawing.Size(1179, 336)
        Me.DataGridView1.TabIndex = 152
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.MistyRose
        Me.Label5.Font = New System.Drawing.Font("Showcard Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(414, 54)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(519, 74)
        Me.Label5.TabIndex = 151
        Me.Label5.Text = "CUSTOMER FINES"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MistyRose
        Me.Button1.BackgroundImage = Global.IDDURUT__MALLO__BERNABE_GUI.My.Resources.Resources._3bbdf999912fa2e0b9d439375d77806b
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.CausesValidation = False
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(9, 2)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(235, 169)
        Me.Button1.TabIndex = 150
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.MistyRose
        Me.PictureBox1.Location = New System.Drawing.Point(-7, 2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1276, 185)
        Me.PictureBox1.TabIndex = 149
        Me.PictureBox1.TabStop = False
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnback.BackgroundImage = Global.IDDURUT__MALLO__BERNABE_GUI.My.Resources.Resources.backak
        Me.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnback.FlatAppearance.BorderSize = 0
        Me.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnback.Location = New System.Drawing.Point(11, 699)
        Me.btnback.Margin = New System.Windows.Forms.Padding(2)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(61, 57)
        Me.btnback.TabIndex = 165
        Me.btnback.UseVisualStyleBackColor = False
        '
        'Form15
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1265, 771)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btndlt)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form15"
        Me.Text = "Form15"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents btnnext As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents btndlt As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnback As Button
End Class
