<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransactionSlip
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TransactionSlip))
        Me.pnlOuterContainer = New System.Windows.Forms.Panel()
        Me.pnlRPTPANEL = New System.Windows.Forms.Panel()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblRptAmtHead = New System.Windows.Forms.Label()
        Me.lblRptQtyHead = New System.Windows.Forms.Label()
        Me.lblRptItemCodeHead = New System.Windows.Forms.Label()
        Me.pnlFooterDetails = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblTotalTaxAmt = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblTotalamt = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblDTamt = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblSalesmanName = New System.Windows.Forms.Label()
        Me.lblRptRptType = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.pnlRptItemsHolder = New System.Windows.Forms.Panel()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblRptINVSONO = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblRptLocationAddress = New System.Windows.Forms.Label()
        Me.lblRptLocationName = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.pnlReportHead = New System.Windows.Forms.Panel()
        Me.lblusernam = New System.Windows.Forms.Label()
        Me.lblusername = New System.Windows.Forms.Label()
        Me.lblhead = New System.Windows.Forms.Label()
        Me.picHead = New System.Windows.Forms.PictureBox()
        Me.btnCloseReport = New System.Windows.Forms.Button()
        Me.btn_Print_Report = New System.Windows.Forms.Button()
        Me.btnExportPDF = New System.Windows.Forms.Button()
        Me.lblArabicName = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblHeaders4 = New System.Windows.Forms.Label()
        Me.lblHeaders3 = New System.Windows.Forms.Label()
        Me.lblHeaders2 = New System.Windows.Forms.Label()
        Me.lblHeaders1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblHeaders7 = New System.Windows.Forms.Label()
        Me.lblHeaders6 = New System.Windows.Forms.Label()
        Me.lblHeaders5 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblItemHeaders = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.pnlOuterContainer.SuspendLayout()
        Me.pnlRPTPANEL.SuspendLayout()
        Me.pnlFooterDetails.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.pnlReportHead.SuspendLayout()
        CType(Me.picHead, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlOuterContainer
        '
        Me.pnlOuterContainer.AutoScroll = True
        Me.pnlOuterContainer.BackColor = System.Drawing.Color.Gainsboro
        Me.pnlOuterContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlOuterContainer.Controls.Add(Me.pnlRPTPANEL)
        Me.pnlOuterContainer.Location = New System.Drawing.Point(309, 156)
        Me.pnlOuterContainer.Name = "pnlOuterContainer"
        Me.pnlOuterContainer.Size = New System.Drawing.Size(339, 480)
        Me.pnlOuterContainer.TabIndex = 0
        '
        'pnlRPTPANEL
        '
        Me.pnlRPTPANEL.BackColor = System.Drawing.Color.White
        Me.pnlRPTPANEL.Controls.Add(Me.lblTime)
        Me.pnlRPTPANEL.Controls.Add(Me.lblRptAmtHead)
        Me.pnlRPTPANEL.Controls.Add(Me.lblRptQtyHead)
        Me.pnlRPTPANEL.Controls.Add(Me.lblRptItemCodeHead)
        Me.pnlRPTPANEL.Controls.Add(Me.pnlFooterDetails)
        Me.pnlRPTPANEL.Controls.Add(Me.Label1)
        Me.pnlRPTPANEL.Controls.Add(Me.lblSalesmanName)
        Me.pnlRPTPANEL.Controls.Add(Me.lblRptRptType)
        Me.pnlRPTPANEL.Controls.Add(Me.Label19)
        Me.pnlRPTPANEL.Controls.Add(Me.pnlRptItemsHolder)
        Me.pnlRPTPANEL.Controls.Add(Me.lblDate)
        Me.pnlRPTPANEL.Controls.Add(Me.lblRptINVSONO)
        Me.pnlRPTPANEL.Controls.Add(Me.lblEmail)
        Me.pnlRPTPANEL.Controls.Add(Me.lblPhone)
        Me.pnlRPTPANEL.Controls.Add(Me.lblRptLocationAddress)
        Me.pnlRPTPANEL.Controls.Add(Me.lblRptLocationName)
        Me.pnlRPTPANEL.Controls.Add(Me.PictureBox1)
        Me.pnlRPTPANEL.Controls.Add(Me.Label2)
        Me.pnlRPTPANEL.Location = New System.Drawing.Point(23, 16)
        Me.pnlRPTPANEL.Name = "pnlRPTPANEL"
        Me.pnlRPTPANEL.Size = New System.Drawing.Size(290, 448)
        Me.pnlRPTPANEL.TabIndex = 0
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(169, 161)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(44, 14)
        Me.lblTime.TabIndex = 32
        Me.lblTime.Text = "Time  :"
        '
        'lblRptAmtHead
        '
        Me.lblRptAmtHead.BackColor = System.Drawing.Color.Transparent
        Me.lblRptAmtHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRptAmtHead.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblRptAmtHead.Location = New System.Drawing.Point(210, 191)
        Me.lblRptAmtHead.Name = "lblRptAmtHead"
        Me.lblRptAmtHead.Size = New System.Drawing.Size(65, 16)
        Me.lblRptAmtHead.TabIndex = 14
        Me.lblRptAmtHead.Text = "Amount"
        Me.lblRptAmtHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRptQtyHead
        '
        Me.lblRptQtyHead.BackColor = System.Drawing.Color.Transparent
        Me.lblRptQtyHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRptQtyHead.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblRptQtyHead.Location = New System.Drawing.Point(166, 191)
        Me.lblRptQtyHead.Name = "lblRptQtyHead"
        Me.lblRptQtyHead.Size = New System.Drawing.Size(43, 16)
        Me.lblRptQtyHead.TabIndex = 13
        Me.lblRptQtyHead.Text = "Qty"
        Me.lblRptQtyHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRptItemCodeHead
        '
        Me.lblRptItemCodeHead.BackColor = System.Drawing.Color.Transparent
        Me.lblRptItemCodeHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRptItemCodeHead.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblRptItemCodeHead.Location = New System.Drawing.Point(13, 191)
        Me.lblRptItemCodeHead.Name = "lblRptItemCodeHead"
        Me.lblRptItemCodeHead.Size = New System.Drawing.Size(153, 16)
        Me.lblRptItemCodeHead.TabIndex = 9
        Me.lblRptItemCodeHead.Text = "Item"
        Me.lblRptItemCodeHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pnlFooterDetails
        '
        Me.pnlFooterDetails.Controls.Add(Me.Label14)
        Me.pnlFooterDetails.Controls.Add(Me.lblTotalTaxAmt)
        Me.pnlFooterDetails.Controls.Add(Me.Label11)
        Me.pnlFooterDetails.Controls.Add(Me.Label10)
        Me.pnlFooterDetails.Controls.Add(Me.Label7)
        Me.pnlFooterDetails.Controls.Add(Me.Label13)
        Me.pnlFooterDetails.Controls.Add(Me.lblTotalamt)
        Me.pnlFooterDetails.Controls.Add(Me.Label12)
        Me.pnlFooterDetails.Controls.Add(Me.lblDTamt)
        Me.pnlFooterDetails.Controls.Add(Me.Label8)
        Me.pnlFooterDetails.Controls.Add(Me.Label9)
        Me.pnlFooterDetails.Location = New System.Drawing.Point(9, 224)
        Me.pnlFooterDetails.Name = "pnlFooterDetails"
        Me.pnlFooterDetails.Size = New System.Drawing.Size(270, 163)
        Me.pnlFooterDetails.TabIndex = 31
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(5, 31)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 14)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Tax Amount"
        '
        'lblTotalTaxAmt
        '
        Me.lblTotalTaxAmt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTaxAmt.Location = New System.Drawing.Point(188, 30)
        Me.lblTotalTaxAmt.Name = "lblTotalTaxAmt"
        Me.lblTotalTaxAmt.Size = New System.Drawing.Size(78, 15)
        Me.lblTotalTaxAmt.TabIndex = 34
        Me.lblTotalTaxAmt.Text = "-"
        Me.lblTotalTaxAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(7, 136)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(257, 14)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Warning: Choking Hazard: small parts, not suitable for children under(3) years ol" & _
    "d"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 109)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(264, 11)
        Me.Label10.TabIndex = 32
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(3, -8)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(268, 15)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "---------------------------------------------------------------------------------" & _
    "-----------------------------------------"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(7, 122)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(257, 14)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Warning: Choking Hazard: small parts, not suitable for children under(3) years ol" & _
    "d"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalamt
        '
        Me.lblTotalamt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalamt.Location = New System.Drawing.Point(186, 68)
        Me.lblTotalamt.Name = "lblTotalamt"
        Me.lblTotalamt.Size = New System.Drawing.Size(78, 15)
        Me.lblTotalamt.TabIndex = 30
        Me.lblTotalamt.Text = "-"
        Me.lblTotalamt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 97)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(264, 11)
        Me.Label12.TabIndex = 17
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDTamt
        '
        Me.lblDTamt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDTamt.Location = New System.Drawing.Point(188, 10)
        Me.lblDTamt.Name = "lblDTamt"
        Me.lblDTamt.Size = New System.Drawing.Size(78, 15)
        Me.lblDTamt.TabIndex = 29
        Me.lblDTamt.Text = "-"
        Me.lblDTamt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 11)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 14)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Discount Total"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 14)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Total Amount"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(11, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 15)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "---------------------------------------------------------------------------------" & _
    "-----------------------------------------"
        '
        'lblSalesmanName
        '
        Me.lblSalesmanName.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesmanName.Location = New System.Drawing.Point(75, 162)
        Me.lblSalesmanName.Name = "lblSalesmanName"
        Me.lblSalesmanName.Size = New System.Drawing.Size(95, 14)
        Me.lblSalesmanName.TabIndex = 5
        Me.lblSalesmanName.Text = " 2011 - JAYESH PATEL"
        '
        'lblRptRptType
        '
        Me.lblRptRptType.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRptRptType.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblRptRptType.Location = New System.Drawing.Point(32, 119)
        Me.lblRptRptType.Name = "lblRptRptType"
        Me.lblRptRptType.Size = New System.Drawing.Size(225, 18)
        Me.lblRptRptType.TabIndex = 0
        Me.lblRptRptType.Text = "TAX INVOICE"
        Me.lblRptRptType.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(11, 161)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(67, 14)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "Salesman :"
        '
        'pnlRptItemsHolder
        '
        Me.pnlRptItemsHolder.Location = New System.Drawing.Point(14, 222)
        Me.pnlRptItemsHolder.Name = "pnlRptItemsHolder"
        Me.pnlRptItemsHolder.Size = New System.Drawing.Size(263, 2)
        Me.pnlRptItemsHolder.TabIndex = 23
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(169, 141)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(40, 14)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "Date  :"
        '
        'lblRptINVSONO
        '
        Me.lblRptINVSONO.AutoSize = True
        Me.lblRptINVSONO.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRptINVSONO.Location = New System.Drawing.Point(11, 141)
        Me.lblRptINVSONO.Name = "lblRptINVSONO"
        Me.lblRptINVSONO.Size = New System.Drawing.Size(66, 14)
        Me.lblRptINVSONO.TabIndex = 0
        Me.lblRptINVSONO.Text = "Inv. No.      :"
        '
        'lblEmail
        '
        Me.lblEmail.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(6, 101)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(277, 18)
        Me.lblEmail.TabIndex = 19
        Me.lblEmail.Text = "Email:-  info@aljaber.ae"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPhone
        '
        Me.lblPhone.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.Location = New System.Drawing.Point(28, 88)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(229, 15)
        Me.lblPhone.TabIndex = 18
        Me.lblPhone.Text = "TEL:- 04-2940204"
        Me.lblPhone.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblRptLocationAddress
        '
        Me.lblRptLocationAddress.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRptLocationAddress.Location = New System.Drawing.Point(11, 73)
        Me.lblRptLocationAddress.Name = "lblRptLocationAddress"
        Me.lblRptLocationAddress.Size = New System.Drawing.Size(262, 15)
        Me.lblRptLocationAddress.TabIndex = 16
        Me.lblRptLocationAddress.Text = "DUBAI"
        Me.lblRptLocationAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRptLocationName
        '
        Me.lblRptLocationName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRptLocationName.Location = New System.Drawing.Point(11, 57)
        Me.lblRptLocationName.Name = "lblRptLocationName"
        Me.lblRptLocationName.Size = New System.Drawing.Size(262, 15)
        Me.lblRptLocationName.TabIndex = 15
        Me.lblRptLocationName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(97, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(92, 52)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(11, 205)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(268, 15)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "---------------------------------------------------------------------------------" & _
    "-----------------------------------------"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(17, 339)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(286, 36)
        Me.Panel1.TabIndex = 26
        Me.Panel1.Visible = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(222, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 15)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "123456789"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(177, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 15)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "1"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(169, 14)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "(MC KEY CHAIN ILU TLG-0037)"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(2, 4)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 14)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "MC-19-3551"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'pnlReportHead
        '
        Me.pnlReportHead.BackColor = System.Drawing.Color.Peru
        Me.pnlReportHead.Controls.Add(Me.lblusernam)
        Me.pnlReportHead.Controls.Add(Me.lblusername)
        Me.pnlReportHead.Controls.Add(Me.lblhead)
        Me.pnlReportHead.Controls.Add(Me.picHead)
        Me.pnlReportHead.Location = New System.Drawing.Point(1, 0)
        Me.pnlReportHead.Name = "pnlReportHead"
        Me.pnlReportHead.Size = New System.Drawing.Size(1226, 45)
        Me.pnlReportHead.TabIndex = 95
        '
        'lblusernam
        '
        Me.lblusernam.AutoSize = True
        Me.lblusernam.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusernam.Location = New System.Drawing.Point(720, 15)
        Me.lblusernam.Name = "lblusernam"
        Me.lblusernam.Size = New System.Drawing.Size(0, 15)
        Me.lblusernam.TabIndex = 14
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblusername.Location = New System.Drawing.Point(800, 15)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(0, 15)
        Me.lblusername.TabIndex = 13
        '
        'lblhead
        '
        Me.lblhead.AutoSize = True
        Me.lblhead.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhead.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblhead.Location = New System.Drawing.Point(53, 16)
        Me.lblhead.Name = "lblhead"
        Me.lblhead.Size = New System.Drawing.Size(161, 22)
        Me.lblhead.TabIndex = 8
        Me.lblhead.Text = "Transaction Slip"
        '
        'picHead
        '
        Me.picHead.Image = CType(resources.GetObject("picHead.Image"), System.Drawing.Image)
        Me.picHead.Location = New System.Drawing.Point(-2, -1)
        Me.picHead.Name = "picHead"
        Me.picHead.Size = New System.Drawing.Size(41, 43)
        Me.picHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHead.TabIndex = 7
        Me.picHead.TabStop = False
        '
        'btnCloseReport
        '
        Me.btnCloseReport.BackColor = System.Drawing.Color.BurlyWood
        Me.btnCloseReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCloseReport.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloseReport.Image = Global.POS.My.Resources.Resources.File_Delete_icon
        Me.btnCloseReport.Location = New System.Drawing.Point(210, 77)
        Me.btnCloseReport.Name = "btnCloseReport"
        Me.btnCloseReport.Size = New System.Drawing.Size(72, 72)
        Me.btnCloseReport.TabIndex = 18
        Me.btnCloseReport.Text = "Close"
        Me.btnCloseReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnCloseReport.UseVisualStyleBackColor = False
        '
        'btn_Print_Report
        '
        Me.btn_Print_Report.BackColor = System.Drawing.Color.BurlyWood
        Me.btn_Print_Report.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Print_Report.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Print_Report.Image = Global.POS.My.Resources.Resources.Printer_icon
        Me.btn_Print_Report.Location = New System.Drawing.Point(132, 77)
        Me.btn_Print_Report.Name = "btn_Print_Report"
        Me.btn_Print_Report.Size = New System.Drawing.Size(72, 72)
        Me.btn_Print_Report.TabIndex = 17
        Me.btn_Print_Report.Text = "Print"
        Me.btn_Print_Report.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_Print_Report.UseVisualStyleBackColor = False
        '
        'btnExportPDF
        '
        Me.btnExportPDF.BackColor = System.Drawing.Color.BurlyWood
        Me.btnExportPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportPDF.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportPDF.Image = Global.POS.My.Resources.Resources.Export_To_File_icon
        Me.btnExportPDF.Location = New System.Drawing.Point(54, 77)
        Me.btnExportPDF.Name = "btnExportPDF"
        Me.btnExportPDF.Size = New System.Drawing.Size(72, 72)
        Me.btnExportPDF.TabIndex = 13
        Me.btnExportPDF.Text = "Export"
        Me.btnExportPDF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnExportPDF.UseVisualStyleBackColor = False
        '
        'lblArabicName
        '
        Me.lblArabicName.BackColor = System.Drawing.Color.Transparent
        Me.lblArabicName.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArabicName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblArabicName.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblArabicName.Location = New System.Drawing.Point(505, 68)
        Me.lblArabicName.Margin = New System.Windows.Forms.Padding(0)
        Me.lblArabicName.Name = "lblArabicName"
        Me.lblArabicName.Size = New System.Drawing.Size(251, 34)
        Me.lblArabicName.TabIndex = 96
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblHeaders4)
        Me.Panel2.Controls.Add(Me.lblHeaders3)
        Me.Panel2.Controls.Add(Me.lblHeaders2)
        Me.Panel2.Controls.Add(Me.lblHeaders1)
        Me.Panel2.Location = New System.Drawing.Point(654, 238)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(513, 152)
        Me.Panel2.TabIndex = 98
        '
        'lblHeaders4
        '
        Me.lblHeaders4.BackColor = System.Drawing.Color.Transparent
        Me.lblHeaders4.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaders4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHeaders4.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblHeaders4.Location = New System.Drawing.Point(3, 113)
        Me.lblHeaders4.Margin = New System.Windows.Forms.Padding(0)
        Me.lblHeaders4.Name = "lblHeaders4"
        Me.lblHeaders4.Size = New System.Drawing.Size(506, 32)
        Me.lblHeaders4.TabIndex = 101
        Me.lblHeaders4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblHeaders3
        '
        Me.lblHeaders3.BackColor = System.Drawing.Color.Transparent
        Me.lblHeaders3.Font = New System.Drawing.Font("Comic Sans MS", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaders3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHeaders3.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblHeaders3.Location = New System.Drawing.Point(3, 78)
        Me.lblHeaders3.Margin = New System.Windows.Forms.Padding(0)
        Me.lblHeaders3.Name = "lblHeaders3"
        Me.lblHeaders3.Size = New System.Drawing.Size(506, 32)
        Me.lblHeaders3.TabIndex = 100
        Me.lblHeaders3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblHeaders2
        '
        Me.lblHeaders2.BackColor = System.Drawing.Color.Transparent
        Me.lblHeaders2.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaders2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHeaders2.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblHeaders2.Location = New System.Drawing.Point(3, 41)
        Me.lblHeaders2.Margin = New System.Windows.Forms.Padding(0)
        Me.lblHeaders2.Name = "lblHeaders2"
        Me.lblHeaders2.Size = New System.Drawing.Size(506, 34)
        Me.lblHeaders2.TabIndex = 99
        Me.lblHeaders2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblHeaders1
        '
        Me.lblHeaders1.BackColor = System.Drawing.Color.Transparent
        Me.lblHeaders1.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaders1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHeaders1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblHeaders1.Location = New System.Drawing.Point(3, 4)
        Me.lblHeaders1.Margin = New System.Windows.Forms.Padding(0)
        Me.lblHeaders1.Name = "lblHeaders1"
        Me.lblHeaders1.Size = New System.Drawing.Size(506, 34)
        Me.lblHeaders1.TabIndex = 98
        Me.lblHeaders1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lblHeaders7)
        Me.Panel3.Controls.Add(Me.lblHeaders6)
        Me.Panel3.Controls.Add(Me.lblHeaders5)
        Me.Panel3.Location = New System.Drawing.Point(654, 396)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(566, 113)
        Me.Panel3.TabIndex = 99
        '
        'lblHeaders7
        '
        Me.lblHeaders7.BackColor = System.Drawing.Color.Transparent
        Me.lblHeaders7.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaders7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHeaders7.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblHeaders7.Location = New System.Drawing.Point(3, 77)
        Me.lblHeaders7.Margin = New System.Windows.Forms.Padding(0)
        Me.lblHeaders7.Name = "lblHeaders7"
        Me.lblHeaders7.Size = New System.Drawing.Size(561, 33)
        Me.lblHeaders7.TabIndex = 100
        Me.lblHeaders7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblHeaders6
        '
        Me.lblHeaders6.BackColor = System.Drawing.Color.Transparent
        Me.lblHeaders6.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaders6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHeaders6.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblHeaders6.Location = New System.Drawing.Point(3, 40)
        Me.lblHeaders6.Margin = New System.Windows.Forms.Padding(0)
        Me.lblHeaders6.Name = "lblHeaders6"
        Me.lblHeaders6.Size = New System.Drawing.Size(561, 34)
        Me.lblHeaders6.TabIndex = 99
        Me.lblHeaders6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblHeaders5
        '
        Me.lblHeaders5.BackColor = System.Drawing.Color.Transparent
        Me.lblHeaders5.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeaders5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHeaders5.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblHeaders5.Location = New System.Drawing.Point(3, 3)
        Me.lblHeaders5.Margin = New System.Windows.Forms.Padding(0)
        Me.lblHeaders5.Name = "lblHeaders5"
        Me.lblHeaders5.Size = New System.Drawing.Size(561, 34)
        Me.lblHeaders5.TabIndex = 98
        Me.lblHeaders5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.lblItemHeaders)
        Me.Panel4.Location = New System.Drawing.Point(654, 517)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(566, 41)
        Me.Panel4.TabIndex = 100
        '
        'lblItemHeaders
        '
        Me.lblItemHeaders.BackColor = System.Drawing.Color.Transparent
        Me.lblItemHeaders.Font = New System.Drawing.Font("Comic Sans MS", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemHeaders.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblItemHeaders.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.lblItemHeaders.Location = New System.Drawing.Point(2, 3)
        Me.lblItemHeaders.Margin = New System.Windows.Forms.Padding(0)
        Me.lblItemHeaders.Name = "lblItemHeaders"
        Me.lblItemHeaders.Size = New System.Drawing.Size(561, 34)
        Me.lblItemHeaders.TabIndex = 98
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.Location = New System.Drawing.Point(813, 123)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(131, 54)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 101
        Me.PictureBox2.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.Location = New System.Drawing.Point(654, 68)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(573, 541)
        Me.Panel5.TabIndex = 102
        '
        'TransactionSlip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.ClientSize = New System.Drawing.Size(1232, 768)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblArabicName)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlReportHead)
        Me.Controls.Add(Me.btnCloseReport)
        Me.Controls.Add(Me.btn_Print_Report)
        Me.Controls.Add(Me.btnExportPDF)
        Me.Controls.Add(Me.pnlOuterContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "TransactionSlip"
        Me.Text = "Transaction Slip"
        Me.pnlOuterContainer.ResumeLayout(False)
        Me.pnlRPTPANEL.ResumeLayout(False)
        Me.pnlRPTPANEL.PerformLayout()
        Me.pnlFooterDetails.ResumeLayout(False)
        Me.pnlFooterDetails.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.pnlReportHead.ResumeLayout(False)
        Me.pnlReportHead.PerformLayout()
        CType(Me.picHead, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlOuterContainer As System.Windows.Forms.Panel
    Friend WithEvents pnlRPTPANEL As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblRptLocationName As System.Windows.Forms.Label
    Friend WithEvents lblRptLocationAddress As System.Windows.Forms.Label
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblRptRptType As System.Windows.Forms.Label
    Friend WithEvents lblSalesmanName As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents lblRptINVSONO As System.Windows.Forms.Label
    Friend WithEvents pnlRptItemsHolder As System.Windows.Forms.Panel
    Friend WithEvents lblRptAmtHead As System.Windows.Forms.Label
    Friend WithEvents lblRptQtyHead As System.Windows.Forms.Label
    Friend WithEvents lblRptItemCodeHead As System.Windows.Forms.Label
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btn_Print_Report As System.Windows.Forms.Button
    Friend WithEvents btnCloseReport As System.Windows.Forms.Button
    Friend WithEvents btnExportPDF As System.Windows.Forms.Button
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents pnlReportHead As System.Windows.Forms.Panel
    Friend WithEvents lblusernam As System.Windows.Forms.Label
    Friend WithEvents lblusername As System.Windows.Forms.Label
    Friend WithEvents lblhead As System.Windows.Forms.Label
    Friend WithEvents picHead As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents pnlFooterDetails As System.Windows.Forms.Panel
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblTotalamt As System.Windows.Forms.Label
    Friend WithEvents lblDTamt As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblTime As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblArabicName As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblHeaders1 As System.Windows.Forms.Label
    Friend WithEvents lblHeaders3 As System.Windows.Forms.Label
    Friend WithEvents lblHeaders2 As System.Windows.Forms.Label
    Friend WithEvents lblHeaders4 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lblHeaders7 As System.Windows.Forms.Label
    Friend WithEvents lblHeaders6 As System.Windows.Forms.Label
    Friend WithEvents lblHeaders5 As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lblItemHeaders As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents lblTotalTaxAmt As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
