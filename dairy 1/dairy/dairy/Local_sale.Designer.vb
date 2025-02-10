<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Local_sale
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Local_sale))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtAMOUNT = New System.Windows.Forms.Label
        Me.txtBILLNO = New System.Windows.Forms.TextBox
        Me.txtQUALITY = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnEXIT = New System.Windows.Forms.Button
        Me.btnVIEW = New System.Windows.Forms.Button
        Me.btnNEW = New System.Windows.Forms.Button
        Me.btnINSERT = New System.Windows.Forms.Button
        Me.btnCLEAR = New System.Windows.Forms.Button
        Me.btnDELETE = New System.Windows.Forms.Button
        Me.btnUPDATE = New System.Windows.Forms.Button
        Me.btnFIRST = New System.Windows.Forms.Button
        Me.btnLAST = New System.Windows.Forms.Button
        Me.btnNEXT = New System.Windows.Forms.Button
        Me.btnPREVIOU = New System.Windows.Forms.Button
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.btnSEARCH = New System.Windows.Forms.Button
        Me.txtRATE = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(176, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(469, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LOCAL SALE INFORMATION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "BILL NO:-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CDATE:-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "QUANTITY:-"
        '
        'txtAMOUNT
        '
        Me.txtAMOUNT.AutoSize = True
        Me.txtAMOUNT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAMOUNT.Location = New System.Drawing.Point(23, 166)
        Me.txtAMOUNT.Name = "txtAMOUNT"
        Me.txtAMOUNT.Size = New System.Drawing.Size(82, 16)
        Me.txtAMOUNT.TabIndex = 4
        Me.txtAMOUNT.Text = "AMOUNT:-"
        '
        'txtBILLNO
        '
        Me.txtBILLNO.Location = New System.Drawing.Point(128, 17)
        Me.txtBILLNO.MaxLength = 5
        Me.txtBILLNO.Name = "txtBILLNO"
        Me.txtBILLNO.Size = New System.Drawing.Size(140, 20)
        Me.txtBILLNO.TabIndex = 5
        '
        'txtQUALITY
        '
        Me.txtQUALITY.Location = New System.Drawing.Point(128, 84)
        Me.txtQUALITY.Name = "txtQUALITY"
        Me.txtQUALITY.Size = New System.Drawing.Size(140, 20)
        Me.txtQUALITY.TabIndex = 7
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(126, 126)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(140, 20)
        Me.TextBox4.TabIndex = 8
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.TextBox5)
        Me.Panel1.Controls.Add(Me.btnSEARCH)
        Me.Panel1.Controls.Add(Me.txtRATE)
        Me.Panel1.Controls.Add(Me.txtBILLNO)
        Me.Panel1.Controls.Add(Me.txtAMOUNT)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtQUALITY)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(150, 77)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(540, 297)
        Me.Panel1.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Coral
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.btnEXIT)
        Me.Panel2.Controls.Add(Me.btnVIEW)
        Me.Panel2.Controls.Add(Me.btnNEW)
        Me.Panel2.Controls.Add(Me.btnINSERT)
        Me.Panel2.Controls.Add(Me.btnCLEAR)
        Me.Panel2.Controls.Add(Me.btnDELETE)
        Me.Panel2.Controls.Add(Me.btnUPDATE)
        Me.Panel2.Controls.Add(Me.btnFIRST)
        Me.Panel2.Controls.Add(Me.btnLAST)
        Me.Panel2.Controls.Add(Me.btnNEXT)
        Me.Panel2.Controls.Add(Me.btnPREVIOU)
        Me.Panel2.Location = New System.Drawing.Point(26, 210)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(493, 61)
        Me.Panel2.TabIndex = 21
        '
        'btnEXIT
        '
        Me.btnEXIT.BackgroundImage = CType(resources.GetObject("btnEXIT.BackgroundImage"), System.Drawing.Image)
        Me.btnEXIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEXIT.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEXIT.Location = New System.Drawing.Point(408, 15)
        Me.btnEXIT.Name = "btnEXIT"
        Me.btnEXIT.Size = New System.Drawing.Size(75, 23)
        Me.btnEXIT.TabIndex = 22
        Me.btnEXIT.Text = "EXIT"
        Me.btnEXIT.UseVisualStyleBackColor = True
        '
        'btnVIEW
        '
        Me.btnVIEW.BackgroundImage = CType(resources.GetObject("btnVIEW.BackgroundImage"), System.Drawing.Image)
        Me.btnVIEW.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVIEW.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnVIEW.Location = New System.Drawing.Point(327, 32)
        Me.btnVIEW.Name = "btnVIEW"
        Me.btnVIEW.Size = New System.Drawing.Size(75, 23)
        Me.btnVIEW.TabIndex = 23
        Me.btnVIEW.Text = "VIEW"
        Me.btnVIEW.UseVisualStyleBackColor = True
        '
        'btnNEW
        '
        Me.btnNEW.BackgroundImage = CType(resources.GetObject("btnNEW.BackgroundImage"), System.Drawing.Image)
        Me.btnNEW.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNEW.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnNEW.Location = New System.Drawing.Point(3, 3)
        Me.btnNEW.Name = "btnNEW"
        Me.btnNEW.Size = New System.Drawing.Size(75, 23)
        Me.btnNEW.TabIndex = 11
        Me.btnNEW.Text = "NEW"
        Me.btnNEW.UseVisualStyleBackColor = True
        '
        'btnINSERT
        '
        Me.btnINSERT.BackgroundImage = CType(resources.GetObject("btnINSERT.BackgroundImage"), System.Drawing.Image)
        Me.btnINSERT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnINSERT.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnINSERT.Location = New System.Drawing.Point(84, 3)
        Me.btnINSERT.Name = "btnINSERT"
        Me.btnINSERT.Size = New System.Drawing.Size(75, 23)
        Me.btnINSERT.TabIndex = 12
        Me.btnINSERT.Text = "INSERT"
        Me.btnINSERT.UseVisualStyleBackColor = True
        '
        'btnCLEAR
        '
        Me.btnCLEAR.BackgroundImage = CType(resources.GetObject("btnCLEAR.BackgroundImage"), System.Drawing.Image)
        Me.btnCLEAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCLEAR.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnCLEAR.Location = New System.Drawing.Point(327, 3)
        Me.btnCLEAR.Name = "btnCLEAR"
        Me.btnCLEAR.Size = New System.Drawing.Size(75, 23)
        Me.btnCLEAR.TabIndex = 15
        Me.btnCLEAR.Text = "CLEAR"
        Me.btnCLEAR.UseVisualStyleBackColor = True
        '
        'btnDELETE
        '
        Me.btnDELETE.BackgroundImage = CType(resources.GetObject("btnDELETE.BackgroundImage"), System.Drawing.Image)
        Me.btnDELETE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDELETE.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnDELETE.Location = New System.Drawing.Point(165, 3)
        Me.btnDELETE.Name = "btnDELETE"
        Me.btnDELETE.Size = New System.Drawing.Size(75, 23)
        Me.btnDELETE.TabIndex = 13
        Me.btnDELETE.Text = "DELETE"
        Me.btnDELETE.UseVisualStyleBackColor = True
        '
        'btnUPDATE
        '
        Me.btnUPDATE.BackgroundImage = CType(resources.GetObject("btnUPDATE.BackgroundImage"), System.Drawing.Image)
        Me.btnUPDATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUPDATE.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnUPDATE.Location = New System.Drawing.Point(246, 3)
        Me.btnUPDATE.Name = "btnUPDATE"
        Me.btnUPDATE.Size = New System.Drawing.Size(75, 23)
        Me.btnUPDATE.TabIndex = 14
        Me.btnUPDATE.Text = "UPDATE"
        Me.btnUPDATE.UseVisualStyleBackColor = True
        '
        'btnFIRST
        '
        Me.btnFIRST.BackgroundImage = CType(resources.GetObject("btnFIRST.BackgroundImage"), System.Drawing.Image)
        Me.btnFIRST.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFIRST.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnFIRST.Location = New System.Drawing.Point(3, 32)
        Me.btnFIRST.Name = "btnFIRST"
        Me.btnFIRST.Size = New System.Drawing.Size(75, 23)
        Me.btnFIRST.TabIndex = 16
        Me.btnFIRST.Text = "FIRST"
        Me.btnFIRST.UseVisualStyleBackColor = True
        '
        'btnLAST
        '
        Me.btnLAST.BackgroundImage = CType(resources.GetObject("btnLAST.BackgroundImage"), System.Drawing.Image)
        Me.btnLAST.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLAST.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLAST.Location = New System.Drawing.Point(84, 32)
        Me.btnLAST.Name = "btnLAST"
        Me.btnLAST.Size = New System.Drawing.Size(75, 23)
        Me.btnLAST.TabIndex = 19
        Me.btnLAST.Text = "LAST"
        Me.btnLAST.UseVisualStyleBackColor = True
        '
        'btnNEXT
        '
        Me.btnNEXT.BackgroundImage = CType(resources.GetObject("btnNEXT.BackgroundImage"), System.Drawing.Image)
        Me.btnNEXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNEXT.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnNEXT.Location = New System.Drawing.Point(165, 32)
        Me.btnNEXT.Name = "btnNEXT"
        Me.btnNEXT.Size = New System.Drawing.Size(75, 23)
        Me.btnNEXT.TabIndex = 17
        Me.btnNEXT.Text = "NEXT"
        Me.btnNEXT.UseVisualStyleBackColor = True
        '
        'btnPREVIOU
        '
        Me.btnPREVIOU.BackgroundImage = CType(resources.GetObject("btnPREVIOU.BackgroundImage"), System.Drawing.Image)
        Me.btnPREVIOU.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPREVIOU.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnPREVIOU.Location = New System.Drawing.Point(246, 32)
        Me.btnPREVIOU.Name = "btnPREVIOU"
        Me.btnPREVIOU.Size = New System.Drawing.Size(75, 23)
        Me.btnPREVIOU.TabIndex = 18
        Me.btnPREVIOU.Text = "PREVIOUS"
        Me.btnPREVIOU.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(126, 51)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(141, 21)
        Me.DateTimePicker1.TabIndex = 26
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(126, 169)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(140, 20)
        Me.TextBox5.TabIndex = 25
        '
        'btnSEARCH
        '
        Me.btnSEARCH.BackgroundImage = Global.dairy.My.Resources.Resources.COW1
        Me.btnSEARCH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSEARCH.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnSEARCH.Location = New System.Drawing.Point(313, 17)
        Me.btnSEARCH.Name = "btnSEARCH"
        Me.btnSEARCH.Size = New System.Drawing.Size(75, 23)
        Me.btnSEARCH.TabIndex = 20
        Me.btnSEARCH.Text = "SEARCH"
        Me.btnSEARCH.UseVisualStyleBackColor = True
        '
        'txtRATE
        '
        Me.txtRATE.AutoSize = True
        Me.txtRATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRATE.Location = New System.Drawing.Point(23, 129)
        Me.txtRATE.Name = "txtRATE"
        Me.txtRATE.Size = New System.Drawing.Size(58, 16)
        Me.txtRATE.TabIndex = 23
        Me.txtRATE.Text = "RATE:-"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(150, 390)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(540, 88)
        Me.DataGridView1.TabIndex = 10
        '
        'Local_sale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.dairy.My.Resources.Resources.COW1
        Me.ClientSize = New System.Drawing.Size(947, 566)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Local_sale"
        Me.Text = "Local_sale"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAMOUNT As System.Windows.Forms.Label
    Friend WithEvents txtBILLNO As System.Windows.Forms.TextBox
    Friend WithEvents txtQUALITY As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnNEW As System.Windows.Forms.Button
    Friend WithEvents btnINSERT As System.Windows.Forms.Button
    Friend WithEvents btnDELETE As System.Windows.Forms.Button
    Friend WithEvents btnUPDATE As System.Windows.Forms.Button
    Friend WithEvents btnCLEAR As System.Windows.Forms.Button
    Friend WithEvents btnFIRST As System.Windows.Forms.Button
    Friend WithEvents btnNEXT As System.Windows.Forms.Button
    Friend WithEvents btnPREVIOU As System.Windows.Forms.Button
    Friend WithEvents btnLAST As System.Windows.Forms.Button
    Friend WithEvents btnSEARCH As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnEXIT As System.Windows.Forms.Button
    Friend WithEvents btnVIEW As System.Windows.Forms.Button
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents txtRATE As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class
