<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transection
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transection))
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnSEARCH = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnEXIT = New System.Windows.Forms.Button
        Me.btnUPDATE = New System.Windows.Forms.Button
        Me.btnDELETE = New System.Windows.Forms.Button
        Me.btnINSERT = New System.Windows.Forms.Button
        Me.btnNEW = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtTotal_Milk = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtFat = New System.Windows.Forms.TextBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.cmbAccno = New System.Windows.Forms.ComboBox
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(106, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(512, 37)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "TRANSECTION_INFORMATION"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.cmbAccno)
        Me.Panel1.Controls.Add(Me.btnSEARCH)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtAmount)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtTotal_Milk)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtFat)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Location = New System.Drawing.Point(46, 77)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(619, 289)
        Me.Panel1.TabIndex = 34
        '
        'btnSEARCH
        '
        Me.btnSEARCH.BackgroundImage = Global.dairy.My.Resources.Resources.COW11
        Me.btnSEARCH.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSEARCH.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSEARCH.Location = New System.Drawing.Point(277, 20)
        Me.btnSEARCH.Name = "btnSEARCH"
        Me.btnSEARCH.Size = New System.Drawing.Size(85, 23)
        Me.btnSEARCH.TabIndex = 29
        Me.btnSEARCH.Text = "SEARCH"
        Me.btnSEARCH.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Coral
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.btnEXIT)
        Me.Panel2.Controls.Add(Me.btnUPDATE)
        Me.Panel2.Controls.Add(Me.btnDELETE)
        Me.Panel2.Controls.Add(Me.btnINSERT)
        Me.Panel2.Controls.Add(Me.btnNEW)
        Me.Panel2.Location = New System.Drawing.Point(65, 221)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(433, 40)
        Me.Panel2.TabIndex = 26
        '
        'btnEXIT
        '
        Me.btnEXIT.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEXIT.BackgroundImage = CType(resources.GetObject("btnEXIT.BackgroundImage"), System.Drawing.Image)
        Me.btnEXIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEXIT.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEXIT.Location = New System.Drawing.Point(344, 3)
        Me.btnEXIT.Name = "btnEXIT"
        Me.btnEXIT.Size = New System.Drawing.Size(75, 26)
        Me.btnEXIT.TabIndex = 4
        Me.btnEXIT.Text = "E&XIT"
        Me.btnEXIT.UseVisualStyleBackColor = False
        '
        'btnUPDATE
        '
        Me.btnUPDATE.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUPDATE.BackgroundImage = CType(resources.GetObject("btnUPDATE.BackgroundImage"), System.Drawing.Image)
        Me.btnUPDATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUPDATE.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUPDATE.Location = New System.Drawing.Point(255, 3)
        Me.btnUPDATE.Name = "btnUPDATE"
        Me.btnUPDATE.Size = New System.Drawing.Size(83, 26)
        Me.btnUPDATE.TabIndex = 3
        Me.btnUPDATE.Text = "UPDATE"
        Me.btnUPDATE.UseVisualStyleBackColor = False
        '
        'btnDELETE
        '
        Me.btnDELETE.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDELETE.BackgroundImage = CType(resources.GetObject("btnDELETE.BackgroundImage"), System.Drawing.Image)
        Me.btnDELETE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDELETE.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDELETE.Location = New System.Drawing.Point(174, 3)
        Me.btnDELETE.Name = "btnDELETE"
        Me.btnDELETE.Size = New System.Drawing.Size(75, 26)
        Me.btnDELETE.TabIndex = 2
        Me.btnDELETE.Text = "DELETE"
        Me.btnDELETE.UseVisualStyleBackColor = False
        '
        'btnINSERT
        '
        Me.btnINSERT.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnINSERT.BackgroundImage = CType(resources.GetObject("btnINSERT.BackgroundImage"), System.Drawing.Image)
        Me.btnINSERT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnINSERT.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnINSERT.Location = New System.Drawing.Point(93, 3)
        Me.btnINSERT.Name = "btnINSERT"
        Me.btnINSERT.Size = New System.Drawing.Size(75, 26)
        Me.btnINSERT.TabIndex = 1
        Me.btnINSERT.Text = "INSERT"
        Me.btnINSERT.UseVisualStyleBackColor = False
        '
        'btnNEW
        '
        Me.btnNEW.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnNEW.BackgroundImage = CType(resources.GetObject("btnNEW.BackgroundImage"), System.Drawing.Image)
        Me.btnNEW.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNEW.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnNEW.Location = New System.Drawing.Point(12, 3)
        Me.btnNEW.Name = "btnNEW"
        Me.btnNEW.Size = New System.Drawing.Size(75, 26)
        Me.btnNEW.TabIndex = 0
        Me.btnNEW.Text = "NEW"
        Me.btnNEW.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(50, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 16)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Total_Milk:-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Accno:-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Fat:-"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(145, 125)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtAmount.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(50, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 16)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Amount:-"
        '
        'txtTotal_Milk
        '
        Me.txtTotal_Milk.Location = New System.Drawing.Point(145, 90)
        Me.txtTotal_Milk.Name = "txtTotal_Milk"
        Me.txtTotal_Milk.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal_Milk.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(50, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 16)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "PayDate:-"
        '
        'txtFat
        '
        Me.txtFat.Location = New System.Drawing.Point(145, 52)
        Me.txtFat.Name = "txtFat"
        Me.txtFat.Size = New System.Drawing.Size(100, 20)
        Me.txtFat.TabIndex = 22
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(145, 160)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(100, 20)
        Me.DateTimePicker1.TabIndex = 20
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(46, 372)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(619, 84)
        Me.DataGridView1.TabIndex = 33
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'cmbAccno
        '
        Me.cmbAccno.FormattingEnabled = True
        Me.cmbAccno.Location = New System.Drawing.Point(145, 19)
        Me.cmbAccno.Name = "cmbAccno"
        Me.cmbAccno.Size = New System.Drawing.Size(100, 21)
        Me.cmbAccno.TabIndex = 30
        '
        'Transection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.dairy.My.Resources.Resources.COW1
        Me.ClientSize = New System.Drawing.Size(750, 489)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Transection"
        Me.Text = "Transection"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnSEARCH As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnEXIT As System.Windows.Forms.Button
    Friend WithEvents btnUPDATE As System.Windows.Forms.Button
    Friend WithEvents btnDELETE As System.Windows.Forms.Button
    Friend WithEvents btnINSERT As System.Windows.Forms.Button
    Friend WithEvents btnNEW As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTotal_Milk As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtFat As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmbAccno As System.Windows.Forms.ComboBox
End Class
