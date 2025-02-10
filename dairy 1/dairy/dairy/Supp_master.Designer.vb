<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Supp_master
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Supp_master))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.txtSPINCODE = New System.Windows.Forms.TextBox
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnCLEAR = New System.Windows.Forms.Button
        Me.btnNEW = New System.Windows.Forms.Button
        Me.btnINSERT = New System.Windows.Forms.Button
        Me.btnVIEW = New System.Windows.Forms.Button
        Me.btnDELETE = New System.Windows.Forms.Button
        Me.btnEXIT = New System.Windows.Forms.Button
        Me.btnUPDATE = New System.Windows.Forms.Button
        Me.btnFIRST = New System.Windows.Forms.Button
        Me.btnLAST = New System.Windows.Forms.Button
        Me.btnNEXT = New System.Windows.Forms.Button
        Me.btnPREVIOU = New System.Windows.Forms.Button
        Me.btnSEARCH = New System.Windows.Forms.Button
        Me.txtSCITY = New System.Windows.Forms.TextBox
        Me.txtSADD = New System.Windows.Forms.TextBox
        Me.txtSNAME = New System.Windows.Forms.TextBox
        Me.txtSNO = New System.Windows.Forms.TextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(161, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(389, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SUPPLIER INFORMATION"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(28, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "SNO:-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(28, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "SNAME:-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "SADD:-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(244, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "SCITY:-"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(244, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "SPINCODE:-"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.txtSPINCODE)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnSEARCH)
        Me.Panel1.Controls.Add(Me.txtSCITY)
        Me.Panel1.Controls.Add(Me.txtSADD)
        Me.Panel1.Controls.Add(Me.txtSNAME)
        Me.Panel1.Controls.Add(Me.txtSNO)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(113, 78)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(491, 264)
        Me.Panel1.TabIndex = 6
        '
        'txtSPINCODE
        '
        Me.txtSPINCODE.Location = New System.Drawing.Point(344, 116)
        Me.txtSPINCODE.MaxLength = 6
        Me.txtSPINCODE.Name = "txtSPINCODE"
        Me.txtSPINCODE.Size = New System.Drawing.Size(100, 20)
        Me.txtSPINCODE.TabIndex = 10
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Coral
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.btnCLEAR)
        Me.Panel2.Controls.Add(Me.btnNEW)
        Me.Panel2.Controls.Add(Me.btnINSERT)
        Me.Panel2.Controls.Add(Me.btnVIEW)
        Me.Panel2.Controls.Add(Me.btnDELETE)
        Me.Panel2.Controls.Add(Me.btnEXIT)
        Me.Panel2.Controls.Add(Me.btnUPDATE)
        Me.Panel2.Controls.Add(Me.btnFIRST)
        Me.Panel2.Controls.Add(Me.btnLAST)
        Me.Panel2.Controls.Add(Me.btnNEXT)
        Me.Panel2.Controls.Add(Me.btnPREVIOU)
        Me.Panel2.Location = New System.Drawing.Point(3, 163)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(473, 75)
        Me.Panel2.TabIndex = 17
        '
        'btnCLEAR
        '
        Me.btnCLEAR.BackgroundImage = CType(resources.GetObject("btnCLEAR.BackgroundImage"), System.Drawing.Image)
        Me.btnCLEAR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCLEAR.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnCLEAR.Location = New System.Drawing.Point(326, 3)
        Me.btnCLEAR.Name = "btnCLEAR"
        Me.btnCLEAR.Size = New System.Drawing.Size(75, 23)
        Me.btnCLEAR.TabIndex = 19
        Me.btnCLEAR.Text = "CLEAR"
        Me.btnCLEAR.UseVisualStyleBackColor = True
        '
        'btnNEW
        '
        Me.btnNEW.BackgroundImage = Global.dairy.My.Resources.Resources.COW1
        Me.btnNEW.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNEW.ForeColor = System.Drawing.Color.White
        Me.btnNEW.Location = New System.Drawing.Point(0, 3)
        Me.btnNEW.Name = "btnNEW"
        Me.btnNEW.Size = New System.Drawing.Size(75, 23)
        Me.btnNEW.TabIndex = 7
        Me.btnNEW.Text = "NEW"
        Me.btnNEW.UseVisualStyleBackColor = True
        '
        'btnINSERT
        '
        Me.btnINSERT.BackgroundImage = CType(resources.GetObject("btnINSERT.BackgroundImage"), System.Drawing.Image)
        Me.btnINSERT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnINSERT.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnINSERT.Location = New System.Drawing.Point(81, 3)
        Me.btnINSERT.Name = "btnINSERT"
        Me.btnINSERT.Size = New System.Drawing.Size(75, 23)
        Me.btnINSERT.TabIndex = 8
        Me.btnINSERT.Text = "INSERT"
        Me.btnINSERT.UseVisualStyleBackColor = True
        '
        'btnVIEW
        '
        Me.btnVIEW.BackgroundImage = CType(resources.GetObject("btnVIEW.BackgroundImage"), System.Drawing.Image)
        Me.btnVIEW.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVIEW.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnVIEW.Location = New System.Drawing.Point(326, 37)
        Me.btnVIEW.Name = "btnVIEW"
        Me.btnVIEW.Size = New System.Drawing.Size(75, 23)
        Me.btnVIEW.TabIndex = 20
        Me.btnVIEW.Text = "VIEW"
        Me.btnVIEW.UseVisualStyleBackColor = True
        '
        'btnDELETE
        '
        Me.btnDELETE.BackgroundImage = CType(resources.GetObject("btnDELETE.BackgroundImage"), System.Drawing.Image)
        Me.btnDELETE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDELETE.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnDELETE.Location = New System.Drawing.Point(164, 3)
        Me.btnDELETE.Name = "btnDELETE"
        Me.btnDELETE.Size = New System.Drawing.Size(75, 23)
        Me.btnDELETE.TabIndex = 9
        Me.btnDELETE.Text = "DELETE"
        Me.btnDELETE.UseVisualStyleBackColor = True
        '
        'btnEXIT
        '
        Me.btnEXIT.BackgroundImage = CType(resources.GetObject("btnEXIT.BackgroundImage"), System.Drawing.Image)
        Me.btnEXIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEXIT.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnEXIT.Location = New System.Drawing.Point(407, 20)
        Me.btnEXIT.Name = "btnEXIT"
        Me.btnEXIT.Size = New System.Drawing.Size(57, 23)
        Me.btnEXIT.TabIndex = 11
        Me.btnEXIT.Text = "EXIT"
        Me.btnEXIT.UseVisualStyleBackColor = True
        '
        'btnUPDATE
        '
        Me.btnUPDATE.BackgroundImage = CType(resources.GetObject("btnUPDATE.BackgroundImage"), System.Drawing.Image)
        Me.btnUPDATE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUPDATE.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnUPDATE.Location = New System.Drawing.Point(245, 3)
        Me.btnUPDATE.Name = "btnUPDATE"
        Me.btnUPDATE.Size = New System.Drawing.Size(75, 23)
        Me.btnUPDATE.TabIndex = 10
        Me.btnUPDATE.Text = "UPDATE"
        Me.btnUPDATE.UseVisualStyleBackColor = True
        '
        'btnFIRST
        '
        Me.btnFIRST.BackgroundImage = Global.dairy.My.Resources.Resources.COW1
        Me.btnFIRST.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFIRST.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnFIRST.Location = New System.Drawing.Point(3, 37)
        Me.btnFIRST.Name = "btnFIRST"
        Me.btnFIRST.Size = New System.Drawing.Size(72, 23)
        Me.btnFIRST.TabIndex = 12
        Me.btnFIRST.Text = "FIRST"
        Me.btnFIRST.UseVisualStyleBackColor = True
        '
        'btnLAST
        '
        Me.btnLAST.BackgroundImage = CType(resources.GetObject("btnLAST.BackgroundImage"), System.Drawing.Image)
        Me.btnLAST.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLAST.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnLAST.Location = New System.Drawing.Point(81, 37)
        Me.btnLAST.Name = "btnLAST"
        Me.btnLAST.Size = New System.Drawing.Size(75, 23)
        Me.btnLAST.TabIndex = 15
        Me.btnLAST.Text = "LAST"
        Me.btnLAST.UseVisualStyleBackColor = True
        '
        'btnNEXT
        '
        Me.btnNEXT.BackgroundImage = CType(resources.GetObject("btnNEXT.BackgroundImage"), System.Drawing.Image)
        Me.btnNEXT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNEXT.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnNEXT.Location = New System.Drawing.Point(164, 40)
        Me.btnNEXT.Name = "btnNEXT"
        Me.btnNEXT.Size = New System.Drawing.Size(75, 23)
        Me.btnNEXT.TabIndex = 13
        Me.btnNEXT.Text = "NEXT"
        Me.btnNEXT.UseVisualStyleBackColor = True
        '
        'btnPREVIOU
        '
        Me.btnPREVIOU.BackgroundImage = CType(resources.GetObject("btnPREVIOU.BackgroundImage"), System.Drawing.Image)
        Me.btnPREVIOU.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPREVIOU.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnPREVIOU.Location = New System.Drawing.Point(245, 40)
        Me.btnPREVIOU.Name = "btnPREVIOU"
        Me.btnPREVIOU.Size = New System.Drawing.Size(75, 23)
        Me.btnPREVIOU.TabIndex = 14
        Me.btnPREVIOU.Text = "PREVIOUS"
        Me.btnPREVIOU.UseVisualStyleBackColor = True
        '
        'btnSEARCH
        '
        Me.btnSEARCH.BackgroundImage = Global.dairy.My.Resources.Resources.COW1
        Me.btnSEARCH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSEARCH.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnSEARCH.Location = New System.Drawing.Point(247, 28)
        Me.btnSEARCH.Name = "btnSEARCH"
        Me.btnSEARCH.Size = New System.Drawing.Size(75, 23)
        Me.btnSEARCH.TabIndex = 16
        Me.btnSEARCH.Text = "SEARCH"
        Me.btnSEARCH.UseVisualStyleBackColor = True
        '
        'txtSCITY
        '
        Me.txtSCITY.Location = New System.Drawing.Point(344, 74)
        Me.txtSCITY.Name = "txtSCITY"
        Me.txtSCITY.Size = New System.Drawing.Size(100, 20)
        Me.txtSCITY.TabIndex = 9
        '
        'txtSADD
        '
        Me.txtSADD.Location = New System.Drawing.Point(114, 113)
        Me.txtSADD.Name = "txtSADD"
        Me.txtSADD.Size = New System.Drawing.Size(100, 20)
        Me.txtSADD.TabIndex = 8
        '
        'txtSNAME
        '
        Me.txtSNAME.Location = New System.Drawing.Point(114, 70)
        Me.txtSNAME.Name = "txtSNAME"
        Me.txtSNAME.Size = New System.Drawing.Size(100, 20)
        Me.txtSNAME.TabIndex = 7
        '
        'txtSNO
        '
        Me.txtSNO.Location = New System.Drawing.Point(114, 31)
        Me.txtSNO.MaxLength = 5
        Me.txtSNO.Name = "txtSNO"
        Me.txtSNO.Size = New System.Drawing.Size(100, 20)
        Me.txtSNO.TabIndex = 6
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(113, 348)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(491, 99)
        Me.DataGridView1.TabIndex = 18
        '
        'Supp_master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.dairy.My.Resources.Resources.COW1
        Me.ClientSize = New System.Drawing.Size(822, 601)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Supp_master"
        Me.Text = "Supp_master"
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtSPINCODE As System.Windows.Forms.TextBox
    Friend WithEvents txtSCITY As System.Windows.Forms.TextBox
    Friend WithEvents txtSADD As System.Windows.Forms.TextBox
    Friend WithEvents txtSNAME As System.Windows.Forms.TextBox
    Friend WithEvents txtSNO As System.Windows.Forms.TextBox
    Friend WithEvents btnNEW As System.Windows.Forms.Button
    Friend WithEvents btnINSERT As System.Windows.Forms.Button
    Friend WithEvents btnDELETE As System.Windows.Forms.Button
    Friend WithEvents btnUPDATE As System.Windows.Forms.Button
    Friend WithEvents btnEXIT As System.Windows.Forms.Button
    Friend WithEvents btnFIRST As System.Windows.Forms.Button
    Friend WithEvents btnNEXT As System.Windows.Forms.Button
    Friend WithEvents btnPREVIOU As System.Windows.Forms.Button
    Friend WithEvents btnLAST As System.Windows.Forms.Button
    Friend WithEvents btnSEARCH As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnCLEAR As System.Windows.Forms.Button
    Friend WithEvents btnVIEW As System.Windows.Forms.Button
End Class
