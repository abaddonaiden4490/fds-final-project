<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form10))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btndlt = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnback = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.MistyRose
        Me.PictureBox1.Location = New System.Drawing.Point(-9, 1)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1301, 185)
        Me.PictureBox1.TabIndex = 76
        Me.PictureBox1.TabStop = False
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
        Me.Button1.Location = New System.Drawing.Point(11, 11)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(235, 169)
        Me.Button1.TabIndex = 77
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.MistyRose
        Me.Label5.Font = New System.Drawing.Font("Showcard Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(499, 62)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(367, 74)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "PUBLISHER"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(55, 201)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 72
        Me.DataGridView1.RowTemplate.Height = 31
        Me.DataGridView1.Size = New System.Drawing.Size(1179, 336)
        Me.DataGridView1.TabIndex = 79
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(121, 681)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 16)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Publisher Name:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(252, 678)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(166, 33)
        Me.TextBox2.TabIndex = 88
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(988, 631)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(100, 35)
        Me.btnsave.TabIndex = 96
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btndlt
        '
        Me.btndlt.Location = New System.Drawing.Point(822, 631)
        Me.btndlt.Margin = New System.Windows.Forms.Padding(2)
        Me.btndlt.Name = "btndlt"
        Me.btndlt.Size = New System.Drawing.Size(100, 35)
        Me.btndlt.TabIndex = 95
        Me.btndlt.Text = "DELETE"
        Me.btndlt.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(662, 631)
        Me.btnedit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(100, 35)
        Me.btnedit.TabIndex = 94
        Me.btnedit.Text = "EDIT"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(490, 631)
        Me.btnadd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(100, 35)
        Me.btnadd.TabIndex = 93
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnnext
        '
        Me.btnnext.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnnext.BackgroundImage = CType(resources.GetObject("btnnext.BackgroundImage"), System.Drawing.Image)
        Me.btnnext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnnext.FlatAppearance.BorderSize = 0
        Me.btnnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnext.Location = New System.Drawing.Point(1194, 701)
        Me.btnnext.Margin = New System.Windows.Forms.Padding(2)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(68, 59)
        Me.btnnext.TabIndex = 97
        Me.btnnext.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(252, 602)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(166, 33)
        Me.TextBox1.TabIndex = 98
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(145, 619)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 16)
        Me.Label1.TabIndex = 99
        Me.Label1.Text = "Publisher ID:"
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnback.BackgroundImage = Global.IDDURUT__MALLO__BERNABE_GUI.My.Resources.Resources.backak
        Me.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnback.FlatAppearance.BorderSize = 0
        Me.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnback.Location = New System.Drawing.Point(11, 703)
        Me.btnback.Margin = New System.Windows.Forms.Padding(2)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(61, 57)
        Me.btnback.TabIndex = 100
        Me.btnback.UseVisualStyleBackColor = False
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1289, 771)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btndlt)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form10"
        Me.Text = "Form10"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnsave As Button
    Friend WithEvents btndlt As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents btnnext As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnback As Button
End Class
