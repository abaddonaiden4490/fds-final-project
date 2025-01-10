<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form17
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form17))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
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
        Me.btnnext = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(771, 632)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 16)
        Me.Label3.TabIndex = 200
        Me.Label3.Text = "Amount:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(712, 587)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(166, 33)
        Me.TextBox3.TabIndex = 199
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(568, 632)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 16)
        Me.Label2.TabIndex = 198
        Me.Label2.Text = "Staff ID:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(517, 587)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(166, 33)
        Me.TextBox2.TabIndex = 197
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(815, 711)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(100, 35)
        Me.btnsave.TabIndex = 195
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btndlt
        '
        Me.btndlt.Location = New System.Drawing.Point(653, 711)
        Me.btndlt.Margin = New System.Windows.Forms.Padding(2)
        Me.btndlt.Name = "btndlt"
        Me.btndlt.Size = New System.Drawing.Size(100, 35)
        Me.btndlt.TabIndex = 194
        Me.btndlt.Text = "DELETE"
        Me.btndlt.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(484, 711)
        Me.btnedit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(100, 35)
        Me.btnedit.TabIndex = 193
        Me.btnedit.Text = "EDIT"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(324, 711)
        Me.btnadd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(100, 35)
        Me.btnadd.TabIndex = 192
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(368, 632)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 16)
        Me.Label1.TabIndex = 191
        Me.Label1.Text = "Salary ID:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(321, 587)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(166, 33)
        Me.TextBox1.TabIndex = 190
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(64, 202)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 72
        Me.DataGridView1.RowTemplate.Height = 31
        Me.DataGridView1.Size = New System.Drawing.Size(1179, 336)
        Me.DataGridView1.TabIndex = 189
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.MistyRose
        Me.Label5.Font = New System.Drawing.Font("Showcard Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(472, 55)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(257, 74)
        Me.Label5.TabIndex = 188
        Me.Label5.Text = "SALARY"
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
        Me.Button1.Location = New System.Drawing.Point(10, -4)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(235, 169)
        Me.Button1.TabIndex = 187
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.MistyRose
        Me.PictureBox1.Location = New System.Drawing.Point(-6, -4)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1276, 185)
        Me.PictureBox1.TabIndex = 186
        Me.PictureBox1.TabStop = False
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnback.BackgroundImage = Global.IDDURUT__MALLO__BERNABE_GUI.My.Resources.Resources.backak
        Me.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnback.FlatAppearance.BorderSize = 0
        Me.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnback.Location = New System.Drawing.Point(23, 700)
        Me.btnback.Margin = New System.Windows.Forms.Padding(2)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(61, 57)
        Me.btnback.TabIndex = 201
        Me.btnback.UseVisualStyleBackColor = False
        '
        'btnnext
        '
        Me.btnnext.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnnext.BackgroundImage = CType(resources.GetObject("btnnext.BackgroundImage"), System.Drawing.Image)
        Me.btnnext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnnext.FlatAppearance.BorderSize = 0
        Me.btnnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnext.Location = New System.Drawing.Point(1175, 698)
        Me.btnnext.Margin = New System.Windows.Forms.Padding(2)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(68, 59)
        Me.btnnext.TabIndex = 202
        Me.btnnext.UseVisualStyleBackColor = False
        '
        'Form17
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1264, 771)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
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
        Me.Name = "Form17"
        Me.Text = "Form17"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
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
    Friend WithEvents btnnext As Button
End Class
