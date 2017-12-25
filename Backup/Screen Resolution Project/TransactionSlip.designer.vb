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
        Me.pnlOuterContainer = New System.Windows.Forms.Panel
        Me.pnlRPTPANEL = New System.Windows.Forms.Panel
        Me.lblRptAmtHead = New System.Windows.Forms.Label
        Me.lblRptQtyHead = New System.Windows.Forms.Label
        Me.lblRptItemCodeHead = New System.Windows.Forms.Label
        Me.pnlFooterDetails = New System.Windows.Forms.Panel
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.lblTotalamt = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.lblDTamt = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lblSalesmanName = New System.Windows.Forms.Label
        Me.lblRptRptType = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.pnlRptItemsHolder = New System.Windows.Forms.Panel
        Me.lblDate = New System.Windows.Forms.Label
        Me.lblRptINVSONO = New System.Windows.Forms.Label
        Me.lblEmail = New System.Windows.Forms.Label
        Me.lblPhone = New System.Windows.Forms.Label
        Me.lblRptLocationAddress = New System.Windows.Forms.Label
        Me.lblRptLocationName = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.pnlReportHead = New System.Windows.Forms.Panel
        Me.lblusernam = New System.Windows.Forms.Label
        Me.lblusername = New System.Windows.Forms.Label
        Me.lblhead = New System.Windows.Forms.Label
        Me.picHead = New System.Windows.Forms.PictureBox
        Me.btnCloseReport = New System.Windows.Forms.Button
        Me.btn_Print_Report = New System.Windows.Forms.Button
        Me.btnExportPDF = New System.Windows.Forms.Button
        Me.pnlOuterContainer.SuspendLayout()
        Me.pnlRPTPANEL.SuspendLayout()
        Me.pnlFooterDetails.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.pnlReportHead.SuspendLayout()
        CType(Me.picHead, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.pnlRPTPANEL.Location = New System.Drawing.Point(23, 27)
        Me.pnlRPTPANEL.Name = "pnlRPTPANEL"
        Me.pnlRPTPANEL.Size = New System.Drawing.Size(290, 419)
        Me.pnlRPTPANEL.TabIndex = 0
        '
        'lblRptAmtHead
        '
        Me.lblRptAmtHead.BackColor = System.Drawing.Color.Transparent
        Me.lblRptAmtHead.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.lblRptQtyHead.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.lblRptItemCodeHead.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 109)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(264, 11)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "PLEASE VISIT AGAIN"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.Label13.Size = New System.Drawing.Size(257, 32)
        Me.Label13.TabIndex = 18
        Me.Label13.Text = "Warning: Choking Hazard: small parts, not suitable for children under(3) years ol" & _
            "d"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalamt
        '
        Me.lblTotalamt.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalamt.Location = New System.Drawing.Point(188, 30)
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
        Me.Label12.Text = "THANK YOU VISITING ALJABER"
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
        Me.Label8.Size = New System.Drawing.Size(85, 14)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Discount Total"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(5, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 14)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Total Amount"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.lblSalesmanName.Location = New System.Drawing.Point(83, 162)
        Me.lblSalesmanName.Name = "lblSalesmanName"
        Me.lblSalesmanName.Size = New System.Drawing.Size(190, 14)
        Me.lblSalesmanName.TabIndex = 5
        Me.lblSalesmanName.Text = " 2011 - JAYESH PATEL"
        '
        'lblRptRptType
        '
        Me.lblRptRptType.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRptRptType.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblRptRptType.Location = New System.Drawing.Point(32, 114)
        Me.lblRptRptType.Name = "lblRptRptType"
        Me.lblRptRptType.Size = New System.Drawing.Size(225, 18)
        Me.lblRptRptType.TabIndex = 0
        Me.lblRptRptType.Text = "INVOICE"
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
        Me.lblDate.Location = New System.Drawing.Point(181, 141)
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
        Me.lblRptINVSONO.Size = New System.Drawing.Size(67, 14)
        Me.lblRptINVSONO.TabIndex = 0
        Me.lblRptINVSONO.Text = "Inv. No.      :"
        '
        'lblEmail
        '
        Me.lblEmail.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(29, 91)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(229, 15)
        Me.lblEmail.TabIndex = 19
        Me.lblEmail.Text = "Email:-  info@aljaber.ae"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPhone
        '
        Me.lblPhone.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.Location = New System.Drawing.Point(28, 79)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(229, 15)
        Me.lblPhone.TabIndex = 18
        Me.lblPhone.Text = "TEL:- 04-2940204"
        Me.lblPhone.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblRptLocationAddress
        '
        Me.lblRptLocationAddress.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRptLocationAddress.Location = New System.Drawing.Point(11, 64)
        Me.lblRptLocationAddress.Name = "lblRptLocationAddress"
        Me.lblRptLocationAddress.Size = New System.Drawing.Size(262, 15)
        Me.lblRptLocationAddress.TabIndex = 16
        Me.lblRptLocationAddress.Text = "DUBAI"
        Me.lblRptLocationAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRptLocationName
        '
        Me.lblRptLocationName.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRptLocationName.Location = New System.Drawing.Point(11, 49)
        Me.lblRptLocationName.Name = "lblRptLocationName"
        Me.lblRptLocationName.Size = New System.Drawing.Size(262, 15)
        Me.lblRptLocationName.TabIndex = 15
        Me.lblRptLocationName.Text = "CITY CTR"
        Me.lblRptLocationName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.POS.My.Resources.Resources.clientlogoJPEG
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Image = Global.POS.My.Resources.Resources.clientbilllogo
        Me.PictureBox1.Location = New System.Drawing.Point(102, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(76, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.pnlReportHead.Size = New System.Drawing.Size(1027, 45)
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
        Me.lblhead.Size = New System.Drawing.Size(162, 22)
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
        'TransactionSlip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.ControlBox = False
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
        Me.ResumeLayout(False)

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
End Class
