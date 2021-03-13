<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.macnumrev_lbl = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.yes_btn = New System.Windows.Forms.Button()
        Me.no_btn = New System.Windows.Forms.Button()
        Me.macnum_lbl = New System.Windows.Forms.Label()
        Me.technician_lbl = New System.Windows.Forms.Label()
        Me.reason_lbl = New System.Windows.Forms.Label()
        Me.reason_rtb = New System.Windows.Forms.RichTextBox()
        Me.macnum_txt = New System.Windows.Forms.TextBox()
        Me.technician_txt = New System.Windows.Forms.TextBox()
        Me.Proceed_btn = New System.Windows.Forms.Button()
        Me.partition_lbl = New System.Windows.Forms.Label()
        Me.partition_cb = New System.Windows.Forms.ComboBox()
        Me.refresh_btn = New System.Windows.Forms.Button()
        Me.date_dtp = New System.Windows.Forms.DateTimePicker()
        Me.folder_btn = New System.Windows.Forms.Button()
        Me.location_txt = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.browse_lbl = New System.Windows.Forms.Label()
        Me.partition_btn = New System.Windows.Forms.Button()
        Me.browse_btn = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(168, 26)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(419, 91)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(147, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(381, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Welcome to Walter Ewag Backup Tool"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(277, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label2"
        '
        'macnumrev_lbl
        '
        Me.macnumrev_lbl.AutoSize = True
        Me.macnumrev_lbl.Location = New System.Drawing.Point(149, 175)
        Me.macnumrev_lbl.Name = "macnumrev_lbl"
        Me.macnumrev_lbl.Size = New System.Drawing.Size(123, 17)
        Me.macnumrev_lbl.TabIndex = 3
        Me.macnumrev_lbl.Text = "Machine Number: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(149, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(162, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Would you like to use it?"
        '
        'yes_btn
        '
        Me.yes_btn.Location = New System.Drawing.Point(389, 202)
        Me.yes_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.yes_btn.Name = "yes_btn"
        Me.yes_btn.Size = New System.Drawing.Size(75, 23)
        Me.yes_btn.TabIndex = 5
        Me.yes_btn.Text = "Yes"
        Me.yes_btn.UseVisualStyleBackColor = True
        '
        'no_btn
        '
        Me.no_btn.Location = New System.Drawing.Point(483, 202)
        Me.no_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.no_btn.Name = "no_btn"
        Me.no_btn.Size = New System.Drawing.Size(75, 23)
        Me.no_btn.TabIndex = 6
        Me.no_btn.Text = "No"
        Me.no_btn.UseVisualStyleBackColor = True
        '
        'macnum_lbl
        '
        Me.macnum_lbl.AutoSize = True
        Me.macnum_lbl.Location = New System.Drawing.Point(149, 238)
        Me.macnum_lbl.Name = "macnum_lbl"
        Me.macnum_lbl.Size = New System.Drawing.Size(153, 17)
        Me.macnum_lbl.TabIndex = 7
        Me.macnum_lbl.Text = "Type machine number:"
        '
        'technician_lbl
        '
        Me.technician_lbl.AutoSize = True
        Me.technician_lbl.Location = New System.Drawing.Point(149, 268)
        Me.technician_lbl.Name = "technician_lbl"
        Me.technician_lbl.Size = New System.Drawing.Size(227, 17)
        Me.technician_lbl.TabIndex = 8
        Me.technician_lbl.Text = "Type your name (surname, name):"
        '
        'reason_lbl
        '
        Me.reason_lbl.AutoSize = True
        Me.reason_lbl.Location = New System.Drawing.Point(149, 377)
        Me.reason_lbl.Name = "reason_lbl"
        Me.reason_lbl.Size = New System.Drawing.Size(143, 17)
        Me.reason_lbl.TabIndex = 9
        Me.reason_lbl.Text = "Write backup reason:"
        '
        'reason_rtb
        '
        Me.reason_rtb.Location = New System.Drawing.Point(152, 406)
        Me.reason_rtb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.reason_rtb.Name = "reason_rtb"
        Me.reason_rtb.Size = New System.Drawing.Size(385, 85)
        Me.reason_rtb.TabIndex = 10
        Me.reason_rtb.Text = ""
        '
        'macnum_txt
        '
        Me.macnum_txt.Enabled = False
        Me.macnum_txt.Location = New System.Drawing.Point(389, 234)
        Me.macnum_txt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.macnum_txt.Name = "macnum_txt"
        Me.macnum_txt.Size = New System.Drawing.Size(160, 22)
        Me.macnum_txt.TabIndex = 11
        '
        'technician_txt
        '
        Me.technician_txt.Location = New System.Drawing.Point(389, 265)
        Me.technician_txt.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.technician_txt.Name = "technician_txt"
        Me.technician_txt.Size = New System.Drawing.Size(160, 22)
        Me.technician_txt.TabIndex = 12
        '
        'Proceed_btn
        '
        Me.Proceed_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Proceed_btn.Location = New System.Drawing.Point(208, 511)
        Me.Proceed_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Proceed_btn.Name = "Proceed_btn"
        Me.Proceed_btn.Size = New System.Drawing.Size(277, 57)
        Me.Proceed_btn.TabIndex = 13
        Me.Proceed_btn.Text = "Proceed"
        Me.Proceed_btn.UseVisualStyleBackColor = True
        '
        'partition_lbl
        '
        Me.partition_lbl.AutoSize = True
        Me.partition_lbl.Enabled = False
        Me.partition_lbl.Location = New System.Drawing.Point(149, 300)
        Me.partition_lbl.Name = "partition_lbl"
        Me.partition_lbl.Size = New System.Drawing.Size(156, 17)
        Me.partition_lbl.TabIndex = 14
        Me.partition_lbl.Text = "Select backup partition:"
        '
        'partition_cb
        '
        Me.partition_cb.Enabled = False
        Me.partition_cb.FormattingEnabled = True
        Me.partition_cb.Location = New System.Drawing.Point(309, 297)
        Me.partition_cb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.partition_cb.Name = "partition_cb"
        Me.partition_cb.Size = New System.Drawing.Size(63, 24)
        Me.partition_cb.TabIndex = 15
        '
        'refresh_btn
        '
        Me.refresh_btn.Enabled = False
        Me.refresh_btn.Location = New System.Drawing.Point(389, 297)
        Me.refresh_btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.refresh_btn.Name = "refresh_btn"
        Me.refresh_btn.Size = New System.Drawing.Size(75, 23)
        Me.refresh_btn.TabIndex = 16
        Me.refresh_btn.Text = "Refresh"
        Me.refresh_btn.UseVisualStyleBackColor = True
        '
        'date_dtp
        '
        Me.date_dtp.CustomFormat = ""
        Me.date_dtp.Enabled = False
        Me.date_dtp.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_dtp.Location = New System.Drawing.Point(449, 167)
        Me.date_dtp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.date_dtp.Name = "date_dtp"
        Me.date_dtp.Size = New System.Drawing.Size(107, 22)
        Me.date_dtp.TabIndex = 17
        Me.date_dtp.Visible = False
        '
        'folder_btn
        '
        Me.folder_btn.Enabled = False
        Me.folder_btn.Location = New System.Drawing.Point(385, 346)
        Me.folder_btn.Margin = New System.Windows.Forms.Padding(4)
        Me.folder_btn.Name = "folder_btn"
        Me.folder_btn.Size = New System.Drawing.Size(32, 28)
        Me.folder_btn.TabIndex = 18
        Me.folder_btn.Text = "..."
        Me.folder_btn.UseVisualStyleBackColor = True
        '
        'location_txt
        '
        Me.location_txt.Enabled = False
        Me.location_txt.Location = New System.Drawing.Point(152, 348)
        Me.location_txt.Margin = New System.Windows.Forms.Padding(4)
        Me.location_txt.Name = "location_txt"
        Me.location_txt.Size = New System.Drawing.Size(227, 22)
        Me.location_txt.TabIndex = 19
        '
        'browse_lbl
        '
        Me.browse_lbl.AutoSize = True
        Me.browse_lbl.Enabled = False
        Me.browse_lbl.Location = New System.Drawing.Point(148, 329)
        Me.browse_lbl.Name = "browse_lbl"
        Me.browse_lbl.Size = New System.Drawing.Size(172, 17)
        Me.browse_lbl.TabIndex = 20
        Me.browse_lbl.Text = "Or browser for a location: "
        '
        'partition_btn
        '
        Me.partition_btn.Location = New System.Drawing.Point(116, 297)
        Me.partition_btn.Name = "partition_btn"
        Me.partition_btn.Size = New System.Drawing.Size(27, 23)
        Me.partition_btn.TabIndex = 21
        Me.partition_btn.Text = "1"
        Me.partition_btn.UseVisualStyleBackColor = True
        '
        'browse_btn
        '
        Me.browse_btn.Location = New System.Drawing.Point(116, 326)
        Me.browse_btn.Name = "browse_btn"
        Me.browse_btn.Size = New System.Drawing.Size(27, 23)
        Me.browse_btn.TabIndex = 22
        Me.browse_btn.Text = "2"
        Me.browse_btn.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(512, 346)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 17)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Label10"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 614)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.browse_btn)
        Me.Controls.Add(Me.partition_btn)
        Me.Controls.Add(Me.browse_lbl)
        Me.Controls.Add(Me.location_txt)
        Me.Controls.Add(Me.folder_btn)
        Me.Controls.Add(Me.date_dtp)
        Me.Controls.Add(Me.refresh_btn)
        Me.Controls.Add(Me.partition_cb)
        Me.Controls.Add(Me.partition_lbl)
        Me.Controls.Add(Me.Proceed_btn)
        Me.Controls.Add(Me.technician_txt)
        Me.Controls.Add(Me.macnum_txt)
        Me.Controls.Add(Me.reason_rtb)
        Me.Controls.Add(Me.reason_lbl)
        Me.Controls.Add(Me.technician_lbl)
        Me.Controls.Add(Me.macnum_lbl)
        Me.Controls.Add(Me.no_btn)
        Me.Controls.Add(Me.yes_btn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.macnumrev_lbl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Backup Walter Ewag by Rodrigo Osorio      Version 2.1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents macnumrev_lbl As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents yes_btn As Button
    Friend WithEvents no_btn As Button
    Friend WithEvents macnum_lbl As Label
    Friend WithEvents technician_lbl As Label
    Friend WithEvents reason_lbl As Label
    Friend WithEvents reason_rtb As RichTextBox
    Friend WithEvents macnum_txt As TextBox
    Friend WithEvents technician_txt As TextBox
    Friend WithEvents Proceed_btn As Button
    Friend WithEvents partition_lbl As Label
    Friend WithEvents partition_cb As ComboBox
    Friend WithEvents refresh_btn As Button
    Friend WithEvents date_dtp As DateTimePicker
    Friend WithEvents folder_btn As Button
    Friend WithEvents location_txt As TextBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents browse_lbl As Label
    Friend WithEvents partition_btn As Button
    Friend WithEvents browse_btn As Button
    Friend WithEvents Label10 As Label
End Class
