<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dairy_milk
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dairy_milk))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtSNO = New System.Windows.Forms.TextBox
        Me.txtTotal_Milk = New System.Windows.Forms.TextBox
        Me.txtFAT = New System.Windows.Forms.TextBox
        Me.txtAMOUNT = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Cmb_Billno = New System.Windows.Forms.ComboBox
        Me.Cmb_Accno = New System.Windows.Forms.ComboBox
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnEXIT = New System.Windows.Forms.Button
        Me.btnNEW = New System.Windows.Forms.Button
        Me.btnSEARCH = New System.Windows.Forms.Button
        Me.btnINSERT = New System.Windows.Forms.Button
        Me.btnVIEW = New System.Windows.Forms.Button
        Me.btnPREVIOU = New System.Windows.Forms.Button
        Me.btnDELETE = New System.Windows.Forms.Button
        Me.btnLAST = New System.Windows.Forms.Button
        Me.btnCLEAR = New System.Windows.Forms.Button
        Me.btnUPDATE = New System.Windows.Forms.Button
        Me.btnFIRST = New System.Windows.Forms.Button
        Me.btnNEXT = New System.Windows.Forms.Button
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(198, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(429, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DAIRY_MILK_INFORMATION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "SNO:-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(55, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CDATE:-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(55, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "ACCNO:-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(55, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "BILLNO:-"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(320, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Total_Milk:-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(320, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "FAT:-"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(320, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 16)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "AMOUNT:-"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(320, 160)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 16)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "PAYDATE:-"
        '
        'txtSNO
        '
        Me.txtSNO.Location = New System.Drawing.Point(134, 30)
        Me.txtSNO.MaxLength = 5
        Me.txtSNO.Name = "txtSNO"
        Me.txtSNO.Size = New System.Drawing.Size(82, 20)
        Me.txtSNO.TabIndex = 10
        '
        'txtTotal_Milk
        '
        Me.txtTotal_Milk.Location = New System.Drawing.Point(426, 26)
        Me.txtTotal_Milk.Name = "txtTotal_Milk"
        Me.txtTotal_Milk.Size = New System.Drawing.Size(82, 20)
        Me.txtTotal_Milk.TabIndex = 14
        '
        'txtFAT
        '
        Me.txtFAT.Location = New System.Drawing.Point(426, 70)
        Me.txtFAT.Name = "txtFAT"
        Me.txtFAT.Size = New System.Drawing.Size(82, 20)
        Me.txtFAT.TabIndex = 15
        '
        'txtAMOUNT
        '
        Me.txtAMOUNT.Location = New System.Drawing.Point(426, 116)
        Me.txtAMOUNT.Name = "txtAMOUNT"
        Me.txtAMOUNT.Size = New System.Drawing.Size(82, 20)
        Me.txtAMOUNT.TabIndex = 17
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(103, 356)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(594, 69)
        Me.DataGridView1.TabIndex = 19
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Cmb_Billno)
        Me.Panel1.Controls.Add(Me.Cmb_Accno)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.txtSNO)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtAMOUNT)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtFAT)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtTotal_Milk)
        Me.Panel1.Location = New System.Drawing.Point(103, 47)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(594, 303)
        Me.Panel1.TabIndex = 20
        '
        'Cmb_Billno
        '
        Me.Cmb_Billno.FormattingEnabled = True
        Me.Cmb_Billno.Location = New System.Drawing.Point(134, 155)
        Me.Cmb_Billno.Name = "Cmb_Billno"
        Me.Cmb_Billno.Size = New System.Drawing.Size(111, 21)
        Me.Cmb_Billno.TabIndex = 30
        '
        'Cmb_Accno
        '
        Me.Cmb_Accno.FormattingEnabled = True
        Me.Cmb_Accno.Location = New System.Drawing.Point(134, 115)
        Me.Cmb_Accno.Name = "Cmb_Accno"
        Me.Cmb_Accno.Size = New System.Drawing.Size(111, 21)
        Me.Cmb_Accno.TabIndex = 29
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CalendarFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(426, 155)
        Me.DateTimePicker2.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(109, 21)
        Me.DateTimePicker2.TabIndex = 28
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(134, 70)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(111, 21)
        Me.DateTimePicker1.TabIndex = 27
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Coral
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.btnEXIT)
        Me.Panel2.Controls.Add(Me.btnNEW)
        Me.Panel2.Controls.Add(Me.btnSEARCH)
        Me.Panel2.Controls.Add(Me.btnINSERT)
        Me.Panel2.Controls.Add(Me.btnVIEW)
        Me.Panel2.Controls.Add(Me.btnPREVIOU)
        Me.Panel2.Controls.Add(Me.btnDELETE)
        Me.Panel2.Controls.Add(Me.btnLAST)
        Me.Panel2.Controls.Add(Me.btnCLEAR)
        Me.Panel2.Controls.Add(Me.btnUPDATE)
        Me.Panel2.Controls.Add(Me.btnFIRST)
        Me.Panel2.Controls.Add(Me.btnNEXT)
        Me.Panel2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(48, 210)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(502, 62)
        Me.Panel2.TabIndex = 21
        '
        'btnEXIT
        '
        Me.btnEXIT.BackgroundImage = CType(resources.GetObject("btnEXIT.BackgroundImage"), System.Drawing.Image)
        Me.btnEXIT.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEXIT.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEXIT.Location = New System.Drawing.Point(408, 32)
        Me.btnEXIT.Name = "btnEXIT"
        Me.btnEXIT.Size = New System.Drawing.Size(75, 23)
        Me.btnEXIT.TabIndex = 11
        Me.btnEXIT.Text = "EXIT"
        Me.btnEXIT.UseVisualStyleBackColor = True
        '
        'btnNEW
        '
        Me.btnNEW.BackgroundImage = CType(resources.GetObject("btnNEW.BackgroundImage"), System.Drawing.Image)
        Me.btnNEW.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNEW.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnNEW.Location = New System.Drawing.Point(3, 3)
        Me.btnNEW.Name = "btnNEW"
        Me.btnNEW.Size = New System.Drawing.Size(75, 23)
        Me.btnNEW.TabIndex = 0
        Me.btnNEW.Text = "NEW"
        Me.btnNEW.UseVisualStyleBackColor = True
        '
        'btnSEARCH
        '
        Me.btnSEARCH.BackgroundImage = Global.dairy.My.Resources.Resources.COW1
        Me.btnSEARCH.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSEARCH.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSEARCH.Location = New System.Drawing.Point(408, 3)
        Me.btnSEARCH.Name = "btnSEARCH"
        Me.btnSEARCH.Size = New System.Drawing.Size(75, 23)
        Me.btnSEARCH.TabIndex = 10
        Me.btnSEARCH.Text = "SEARCH"
        Me.btnSEARCH.UseVisualStyleBackColor = True
        '
        'btnINSERT
        '
        Me.btnINSERT.BackgroundImage = CType(resources.GetObject("btnINSERT.BackgroundImage"), System.Drawing.Image)
        Me.btnINSERT.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnINSERT.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnINSERT.Location = New System.Drawing.Point(84, 3)
        Me.btnINSERT.Name = "btnINSERT"
        Me.btnINSERT.Size = New System.Drawing.Size(75, 23)
        Me.btnINSERT.TabIndex = 1
        Me.btnINSERT.Text = "INSERT"
        Me.btnINSERT.UseVisualStyleBackColor = True
        '
        'btnVIEW
        '
        Me.btnVIEW.BackgroundImage = CType(resources.GetObject("btnVIEW.BackgroundImage"), System.Drawing.Image)
        Me.btnVIEW.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVIEW.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnVIEW.Location = New System.Drawing.Point(327, 32)
        Me.btnVIEW.Name = "btnVIEW"
        Me.btnVIEW.Size = New System.Drawing.Size(75, 23)
        Me.btnVIEW.TabIndex = 5
        Me.btnVIEW.Text = "VIEW"
        Me.btnVIEW.UseVisualStyleBackColor = True
        '
        'btnPREVIOU
        '
        Me.btnPREVIOU.BackgroundImage = CType(resources.GetObject("btnPREVIOU.BackgroundImage"), System.Drawing.Image)
        Me.btnPREVIOU.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPREVIOU.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnPREVIOU.Location = New System.Drawing.Point(246, 32)
        Me.btnPREVIOU.Name = "btnPREVIOU"
        Me.btnPREVIOU.Size = New System.Drawing.Size(75, 23)
        Me.btnPREVIOU.TabIndex = 8
        Me.btnPREVIOU.Text = "PREVIOUS"
        Me.btnPREVIOU.UseVisualStyleBackColor = True
        '
        'btnDELETE
        '
        Me.btnDELETE.BackgroundImage = CType(resources.GetObject("btnDELETE.BackgroundImage"), System.Drawing.Image)
        Me.btnDELETE.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDELETE.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDELETE.Location = New System.Drawing.Point(165, 3)
        Me.btnDELETE.Name = "btnDELETE"
        Me.btnDELETE.Size = New System.Drawing.Size(75, 23)
        Me.btnDELETE.TabIndex = 2
        Me.btnDELETE.Text = "DELETE"
        Me.btnDELETE.UseVisualStyleBackColor = True
        '
        'btnLAST
        '
        Me.btnLAST.BackgroundImage = CType(resources.GetObject("btnLAST.BackgroundImage"), System.Drawing.Image)
        Me.btnLAST.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLAST.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLAST.Location = New System.Drawing.Point(84, 32)
        Me.btnLAST.Name = "btnLAST"
        Me.btnLAST.Size = New System.Drawing.Size(75, 23)
        Me.btnLAST.TabIndex = 9
        Me.btnLAST.Text = "LAST"
        Me.btnLAST.UseVisualStyleBackColor = True
        '
        'btnCLEAR
        '
        Me.btnCLEAR.BackgroundImage = CType(resources.GetObject("btnCLEAR.BackgroundImage"), System.Drawing.Image)
        Me.btnCLEAR.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCLEAR.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCLEAR.Location = New System.Drawing.Point(327, 3)
        Me.btnCLEAR.Name = "btnCLEAR"
        Me.btnCLEAR.Size = New System.Drawing.Size(75, 23)
        Me.btnCLEAR.TabIndex = 4
        Me.btnCLEAR.Text = "CLEAR"
        Me.btnCLEAR.UseVisualStyleBackColor = True
        '
        'btnUPDATE
        '
        Me.btnUPDATE.BackgroundImage = CType(resources.GetObject("btnUPDATE.BackgroundImage"), System.Drawing.Image)
        Me.btnUPDATE.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUPDATE.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUPDATE.Location = New System.Drawing.Point(246, 3)
        Me.btnUPDATE.Name = "btnUPDATE"
        Me.btnUPDATE.Size = New System.Drawing.Size(75, 23)
        Me.btnUPDATE.TabIndex = 3
        Me.btnUPDATE.Text = "UPDATE"
        Me.btnUPDATE.UseVisualStyleBackColor = True
        '
        'btnFIRST
        '
        Me.btnFIRST.BackgroundImage = CType(resources.GetObject("btnFIRST.BackgroundImage"), System.Drawing.Image)
        Me.btnFIRST.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFIRST.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnFIRST.Location = New System.Drawing.Point(3, 32)
        Me.btnFIRST.Name = "btnFIRST"
        Me.btnFIRST.Size = New System.Drawing.Size(75, 23)
        Me.btnFIRST.TabIndex = 6
        Me.btnFIRST.Text = "FIRST"
        Me.btnFIRST.UseVisualStyleBackColor = True
        '
        'btnNEXT
        '
        Me.btnNEXT.BackgroundImage = CType(resources.GetObject("btnNEXT.BackgroundImage"), System.Drawing.Image)
        Me.btnNEXT.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNEXT.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnNEXT.Location = New System.Drawing.Point(165, 32)
        Me.btnNEXT.Name = "btnNEXT"
        Me.btnNEXT.Size = New System.Drawing.Size(75, 23)
        Me.btnNEXT.TabIndex = 7
        Me.btnNEXT.Text = "NEXT"
        Me.btnNEXT.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Dairy_milk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.dairy.My.Resources.Resources.COW1
        Me.ClientSize = New System.Drawing.Size(880, 459)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Dairy_milk"
        Me.Text = "Dairy_milk"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtSNO As System.Windows.Forms.TextBox
    Friend WithEvents txtTotal_Milk As System.Windows.Forms.TextBox
    Friend WithEvents txtFAT As System.Windows.Forms.TextBox
    Friend WithEvents txtAMOUNT As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnEXIT As System.Windows.Forms.Button
    Friend WithEvents btnSEARCH As System.Windows.Forms.Button
    Friend WithEvents btnLAST As System.Windows.Forms.Button
    Friend WithEvents btnPREVIOU As System.Windows.Forms.Button
    Friend WithEvents btnNEXT As System.Windows.Forms.Button
    Friend WithEvents btnFIRST As System.Windows.Forms.Button
    Friend WithEvents btnVIEW As System.Windows.Forms.Button
    Friend WithEvents btnCLEAR As System.Windows.Forms.Button
    Friend WithEvents btnUPDATE As System.Windows.Forms.Button
    Friend WithEvents btnDELETE As System.Windows.Forms.Button
    Friend WithEvents btnINSERT As System.Windows.Forms.Button
    Friend WithEvents btnNEW As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Cmb_Accno As System.Windows.Forms.ComboBox
    Friend WithEvents Cmb_Billno As System.Windows.Forms.ComboBox
End Class
