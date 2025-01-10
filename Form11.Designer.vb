<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form11
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form11))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btndlt = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnback = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.MistyRose
        Me.PictureBox1.Location = New System.Drawing.Point(-5, -3)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1276, 185)
        Me.PictureBox1.TabIndex = 77
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
        Me.Button1.Location = New System.Drawing.Point(11, -3)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(235, 169)
        Me.Button1.TabIndex = 78
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.MistyRose
        Me.Label5.Font = New System.Drawing.Font("Showcard Gothic", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(449, 61)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(531, 74)
        Me.Label5.TabIndex = 79
        Me.Label5.Text = "BOOK CATEGORY"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(45, 215)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 72
        Me.DataGridView1.RowTemplate.Height = 31
        Me.DataGridView1.Size = New System.Drawing.Size(1179, 336)
        Me.DataGridView1.TabIndex = 80
        '
        'btnnext
        '
        Me.btnnext.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnnext.BackgroundImage = CType(resources.GetObject("btnnext.BackgroundImage"), System.Drawing.Image)
        Me.btnnext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnnext.FlatAppearance.BorderSize = 0
        Me.btnnext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnnext.Location = New System.Drawing.Point(1180, 686)
        Me.btnnext.Margin = New System.Windows.Forms.Padding(2)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(68, 59)
        Me.btnnext.TabIndex = 106
        Me.btnnext.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(919, 698)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(100, 35)
        Me.btnsave.TabIndex = 105
        Me.btnsave.Text = "SAVE"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btndlt
        '
        Me.btndlt.Location = New System.Drawing.Point(701, 698)
        Me.btndlt.Margin = New System.Windows.Forms.Padding(2)
        Me.btndlt.Name = "btndlt"
        Me.btndlt.Size = New System.Drawing.Size(100, 35)
        Me.btndlt.TabIndex = 104
        Me.btndlt.Text = "DELETE"
        Me.btndlt.UseVisualStyleBackColor = True
        '
        'btnedit
        '
        Me.btnedit.Location = New System.Drawing.Point(461, 698)
        Me.btnedit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(100, 35)
        Me.btnedit.TabIndex = 103
        Me.btnedit.Text = "EDIT"
        Me.btnedit.UseVisualStyleBackColor = True
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(234, 698)
        Me.btnadd.Margin = New System.Windows.Forms.Padding(2)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(100, 35)
        Me.btnadd.TabIndex = 102
        Me.btnadd.Text = "ADD"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(476, 635)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 16)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "Book:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(126, 635)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 16)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "BookCategory ID:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(416, 590)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(166, 33)
        Me.TextBox2.TabIndex = 99
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(91, 590)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(166, 33)
        Me.TextBox1.TabIndex = 98
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(740, 590)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(166, 33)
        Me.TextBox3.TabIndex = 107
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(1023, 590)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox4.Multiline = True
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(166, 33)
        Me.TextBox4.TabIndex = 108
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(784, 635)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 16)
        Me.Label3.TabIndex = 109
        Me.Label3.Text = "Publisher:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1070, 635)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 16)
        Me.Label4.TabIndex = 110
        Me.Label4.Text = "Category:"
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnback.BackgroundImage = Global.IDDURUT__MALLO__BERNABE_GUI.My.Resources.Resources.backak
        Me.btnback.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnback.FlatAppearance.BorderSize = 0
        Me.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnback.Location = New System.Drawing.Point(11, 686)
        Me.btnback.Margin = New System.Windows.Forms.Padding(2)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(61, 57)
        Me.btnback.TabIndex = 111
        Me.btnback.UseVisualStyleBackColor = False
        '
        'Form11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(1269, 767)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btndlt)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form11"
        Me.Text = "Form11"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnnext As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents btndlt As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnback As Button
End Class
