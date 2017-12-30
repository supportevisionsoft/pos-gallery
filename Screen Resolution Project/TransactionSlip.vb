Imports System.Drawing
Imports System.Text.RegularExpressions
Imports System.Drawing.Drawing2D
Imports System.Drawing.Printing
Imports System.Math
Imports PdfSharp.Pdf
Imports PdfSharp.Drawing
Imports System.Windows.Forms
Imports System.Data.Odbc
Imports System.IO
Imports System.Net
Imports System.Configuration

'jnovelty
Public Class TransactionSlip
    Inherits System.Windows.Forms.Form


    Private TXNNO As String
    Private TXNTYPE As String
    Private rptLocationName As String = ""
    Private rptLocationAddr As String = ""
    Private rptLocationPhone As String = ""
    Private rptLocationEmail As String = ""
    Private rptDate As String = ""
    Private rptCustomerName As String = ""
    Private rptSalesmanName As String = ""
    Private rptCustomerPhone As String = ""
    Private rptCustomerEmail As String = ""
    Private rptCustomerSONo As String = ""
    Private rptTotalDiscount As String = ""
    Private rptTotalTax As String = ""
    Private rptTRN As String = ""

    Private CurrentY As Integer
    Private CurrentX As Integer
    Private leftMargin As Integer
    Private rightMargin As Integer
    Private topMargin As Integer
    Private bottomMargin As Integer
    Private InvoiceWidth As Integer
    Private InvoiceHeight As Integer

    Private InvTitle As String
    Private InvSubTitle1 As String
    Private InvSubTitle2 As String
    Private InvSubTitle3 As String
    Private InvSubTitle4 As String

    Private InvTitleFont As Font = New Font("Arial", 12, FontStyle.Bold)
    ' Title Font height
    Private InvTitleHeight As Integer
    ' Item name font arabic
    Private InvItemArabicFont As Font = New Font("Comic Sans MS", 10, FontStyle.Regular)
    ' SubTitle Font
    Private InvSubTitleFont As Font = New Font("Arial", 10, FontStyle.Bold)
    'Transaction Type Font
    Private InvTranstype As Font = New Font("Courier New", 10, FontStyle.Bold)
    ' SubTitle Font height
    Private InvSubTitleHeight As Integer
    ' Invoice Font
    Private InvoiceFont As Font = New Font("Arial", 10, FontStyle.Regular)
    ' Invoice Font height
    Private InvoiceFontHeight As Integer

    Private ItemDetailsFont As Font = New Font("Arial", 8, FontStyle.Regular)
    Private ItemDetailsFontHeight As Integer

    ' Blue Color
    Private BlueBrush As SolidBrush = New SolidBrush(Color.Blue)
    ' Red Color
    Private RedBrush As SolidBrush = New SolidBrush(Color.Red)
    ' Black Color
    Private BlackBrush As SolidBrush = New SolidBrush(Color.Black)

    Public Property TXN_NO() As String
        Get
            Return TXNNO
        End Get
        Set(ByVal value As String)
            TXNNO = value
        End Set
    End Property

    Public Property TXN_TYPE() As String
        Get
            Return TXNTYPE
        End Get
        Set(ByVal value As String)
            TXNTYPE = value
        End Set
    End Property

    Dim db As New DBConnection
    Dim printds As DataSet


    Private pnlPages As New List(Of Panel)
    Private picReport As New List(Of PictureBox)
    Private lblLocnName As New List(Of Label)
    Private lblLocnAddr As New List(Of Label)
    Private lblLocnPhone As New List(Of Label)
    Private lblLocnEmail As New List(Of Label)
    Private pnlTxnTypeDecl As New List(Of Panel)
    Private lblTxnTypeDecl As New List(Of Label)
    Private pnlInvDetails As New List(Of Panel)
    Private pnlCustDetails As New List(Of Panel)
    Private pnlItemHeader As New List(Of Panel)
    Private pnlItemDetails As New List(Of Panel)
    Private pnlTotalDetails As New List(Of Panel)
    Private pnlGrandTotalDetails As New List(Of Panel)
    Private pnlDeclaration As New List(Of Panel)
    Private pnlAuthSign As New List(Of Panel)

    Private lblINVNo_KEY As New List(Of Label)
    Private lblINVNo_VALUE As New List(Of Label)
    Private lblINVDate_KEY As New List(Of Label)
    Private lblINVDate_VALUE As New List(Of Label)
    Private lblINVTime_KEY As New List(Of Label)
    Private lblINVTime_VALUE As New List(Of Label)
    Private lblINVSONo_KEY As New List(Of Label)
    Private lblINVSONo_VALUE As New List(Of Label)
    Private lblINVSMNo_KEY As New List(Of Label)
    Private lblINVSMNo_VALUE As New List(Of Label)
    Private lblINVCustName_KEY As New List(Of Label)
    Private lblINVCustName_VALUE As New List(Of Label)
    Private lblINVCustPhone_KEY As New List(Of Label)
    Private lblINVCustPhone_VALUE As New List(Of Label)
    Private lblINVCustEmail_KEY As New List(Of Label)
    Private lblINVCustEmail_VALUE As New List(Of Label)

    Private lblINVAdvPaid_KEY As New List(Of Label)
    Private lblINVAdvPaid_VALUE As New List(Of Label)
    Private lblINVBalance_KEY As New List(Of Label)
    Private lblINVBalance_VALUE As New List(Of Label)
    Private lblINVSubTotal_KEY As New List(Of Label)
    Private lblINVSubTotal_VALUE As New List(Of Label)
    Private lblINVExpTotal_KEY As New List(Of Label)
    Private lblINVExpTotal_VALUE As New List(Of Label)
    Private lblINVDisTotal_KEY As New List(Of Label)
    Private lblINVDisTotal_VALUE As New List(Of Label)
    Private lblINVTAX_KEY As New List(Of Label)
    Private lblINVTAX_VALUE As New List(Of Label)

    Private lblRptSNOHeader As New List(Of Label)
    Private lblRptItemCodeHeader As New List(Of Label)
    Private lblRptUOMHeader As New List(Of Label)
    Private lblRptRateHeader As New List(Of Label)
    Private lblRptQtyHeader As New List(Of Label)
    Private lblRptAmtHeader As New List(Of Label)

    Private pnlRows As New List(Of Panel)

    Private lblRptSNOValue As New List(Of Label)
    Private lblRptItemCodeValue As New List(Of Label)
    Public lblRptItemDescValue As New List(Of Label)
    Private lblRptUOMValue As New List(Of Label)
    Private lblRptRateValue As New List(Of Label)
    Private lblRptQtyValue As New List(Of Label)
    Private lblRptAmtValue As New List(Of Label)

    Private lblRptEEO As New List(Of Label)
    Private lblRptGrandTotal_KEY As New List(Of Label)
    Private lblRptGrandTotal_VALUE As New List(Of Label)

    Private lblDeclarationHeader As New List(Of Label)
    Private lblDeclaration As New List(Of Label)
    Private lblAuthSignature As New List(Of Label)

    Private pnlFooter As New List(Of Panel)
    Private lblFooterLine1 As New List(Of Label)
    Private lblFooterLine2 As New List(Of Label)
    Private lblFooterLine3 As New List(Of Label)

    Dim totalDiscountamt As Double = 0
    Dim totalExpenseamt As Double = 0
    Dim totalTaxAmount As Double = 0
    Dim subtotalamt As Double = 0
    Dim totheaddiscamtval As Double

    Private currentPage As String = ""
    Private currentItemPanel As String = ""
    Private currentPageNumber As String = ""

    Dim _page As Integer
    Dim bitmaps As New List(Of Bitmap)

    Private Sub TransactionSlip_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Me.Dock = DockStyle.Fill
            'pnlOuterContainer.Controls.Clear()
            Try
                If Not File.Exists(Application.StartupPath & "\LOGOS\" & locationLogo) Then
                    Dim Client As New WebClient
                    Dim apiURL As String = ConfigurationManager.AppSettings("POS_API_URL").ToString
                    If Not apiURL Is Nothing And Not apiURL.Equals("") Then
                        Client.DownloadFile(apiURL & locationLogo, Application.StartupPath & "\LOGOS\" & locationLogo)
                        Client.Dispose()
                    End If
                End If
            Catch ex As Exception
                errLog.WriteToErrorLog("Issue occured from webclient", "ERROR", "")
            End Try


            If File.Exists(Application.StartupPath & "\LOGOS\" & locationLogo) Then
                PictureBox1.Image = Image.FromFile(Application.StartupPath & "\LOGOS\" & locationLogo)
                PictureBox2.Image = Image.FromFile(Application.StartupPath & "\LOGOS\" & locationLogo)
            End If
            If TXN_TYPE = "Invoice" Then
                loadReportInvoice()
            ElseIf TXN_TYPE = "Sales Return" Then
                loadReportSalesReturn()
            End If
            btn_Print_Report.Select()
        Catch ex As Exception
            errLog.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")
        End Try
    End Sub

    'Private Sub loadReportSalesReturn()
    '    Try
    '        Dim stQuery As String = ""
    '        Dim ds As DataSet
    '        Dim row As System.Data.DataRow
    '        stQuery = stQuery + " select rownum,b.CSRH_NO ,to_char( b.CSRH_DT,'DD/MM/YYYY') as InvoiceDate, "
    '        stQuery = stQuery + " d.ADDR_LINE_1 as locn_name,"
    '        stQuery = stQuery + " d.ADDR_LINE_2|| ' ' || d.ADDR_LINE_3"
    '        stQuery = stQuery + " as Location_Address,"
    '        stQuery = stQuery + " d.addr_tel as Phone,d.addr_email as Email,"
    '        stQuery = stQuery + " (select cust_name from om_customer where cust_code = b.CSRH_CUST_CODE)"
    '        stQuery = stQuery + "  as CustName,"
    '        stQuery = stQuery + " b.CSRH_BILL_ADDR_LINE_1||' '||b.CSRH_BILL_ADDR_LINE_2||' '||b.CSRH_BILL_COUNTRY_CODE as billing_addr,"
    '        stQuery = stQuery + " b.CSRH_BILL_TEL as billing_phone, b.CSRH_BILL_EMAIL as billing_email,"
    '        stQuery = stQuery + " b.CSRH_SHIP_ADDR_LINE_1||' '||b.CSRH_SHIP_ADDR_LINE_2||' '||b.CSRH_SHIP_COUNTRY_CODE as shipping_addr,"
    '        stQuery = stQuery + " a.CSRI_ITEM_CODE as ItemCode"
    '        stQuery = stQuery + ",a.CSRI_ITEM_DESC as ItemDesc,"
    '        stQuery = stQuery + " a.CSRI_UOM_CODE as ItmUOM,"
    '        stQuery = stQuery + " a.CSRI_RATE as ItmPrice ,"
    '        stQuery = stQuery + " a.CSRI_QTY as ItmQty,"
    '        stQuery = stQuery + " a.CSRI_FC_VAL as ItmAmt,"
    '        stQuery = stQuery + " nvl((SELECT ITED_FC_AMT from OT_CUST_SALE_RET_ITEM_TED where ITED_I_SYS_ID= a.CSRI_SYS_ID and ITED_TED_HEAD_ITEM_NUM=2 and ITED_TED_TYPE_NUM=(select TED_TAX_DISC_EXP_NUM  from OM_TED_TYPE where TED_TYPE_CODE='TEDDIS')),0) as disamt,"
    '        stQuery = stQuery & " nvl((SELECT ITED_FC_AMT from OT_CUST_SALE_RET_ITEM_TED where ITED_I_SYS_ID= a.CSRI_SYS_ID and ITED_TED_HEAD_ITEM_NUM=2 and ITED_TED_TYPE_NUM=(select TED_TAX_DISC_EXP_NUM  from OM_TED_TYPE where TED_TYPE_CODE='TEDEXP')),0) as expamt,CSRH_SM_CODE as salesman,CSRH_FLEX_03 as pm_cust_no,"
    '        stQuery = stQuery + " nvl((SELECT ITED_FC_AMT from OT_CUST_SALE_RET_ITEM_TED where ITED_H_SYS_ID= b.CSRH_SYS_ID and ITED_TED_HEAD_ITEM_NUM=1 and ITED_TED_TYPE_NUM=(select TED_TAX_DISC_EXP_NUM  from OM_TED_TYPE where TED_TYPE_CODE='TEDDIS')),0) as totdisamt"
    '        stQuery = stQuery + " from "
    '        stQuery = stQuery + " OT_CUST_SALE_RET_HEAD b,OT_CUST_SALE_RET_ITEM a,om_location c,om_address d"
    '        stQuery = stQuery + " where b.CSRH_NO = " + TXN_NO.ToString + " and"
    '        stQuery = stQuery + " b.CSRH_SYS_ID = a.CSRI_CSRH_SYS_ID and"
    '        stQuery = stQuery + " b.CSRH_LOCN_CODE = c.locn_code and c.locn_addr_code = d.addr_code"
    '        errLog.WriteToErrorLog("Sales Return Report Query", stQuery, "")
    '        ds = db.SelectFromTableODBC(stQuery)
    '        printds = ds

    '        Dim rowcount As Integer = ds.Tables("Table").Rows.Count
    '        Dim i As Integer = 0

    '        rptDate = ds.Tables("Table").Rows.Item(0).Item(2).ToString
    '        rptLocationName = ds.Tables("Table").Rows.Item(0).Item(3).ToString
    '        rptLocationAddr = ds.Tables("Table").Rows.Item(0).Item(4).ToString
    '        rptLocationPhone = ds.Tables("Table").Rows.Item(0).Item(5).ToString
    '        rptLocationEmail = ds.Tables("Table").Rows.Item(0).Item(6).ToString
    '        Dim stSalesQuery As String = ""
    '        stSalesQuery = "Select SM_NAME from om_salesman where SM_CODE='" & ds.Tables("Table").Rows.Item(0).Item(20).ToString & "'"
    '        Dim dsSal As DataSet = db.SelectFromTableODBC(stSalesQuery)
    '        If dsSal.Tables("Table").Rows.Count > 0 Then
    '            rptSalesmanName = ds.Tables("Table").Rows.Item(0).Item(20).ToString & " - " & dsSal.Tables("Table").Rows.Item(0).Item(0).ToString
    '        End If

    '        If ds.Tables("Table").Rows.Item(0).Item(21).ToString = "" Then
    '            rptCustomerName = ds.Tables("Table").Rows.Item(0).Item(7).ToString
    '            rptCustomerPhone = ds.Tables("Table").Rows.Item(0).Item(9).ToString
    '            rptCustomerEmail = ds.Tables("Table").Rows.Item(0).Item(10).ToString
    '        Else
    '            Dim stQueryPatient As String
    '            stQueryPatient = "select PM_PATIENT_NAME as PatName,PM_ADDRESS_1||PM_ADDRESS_2||PM_ADDRESS_3||PM_ADDRESS_4||PM_ADDRESS_5||PM_CITY||PM_COUNTRY||PM_REGION||PM_ZIPCODE as ShipAddr,PM_TEL_MOB,PM_EMAIL,PM_ADDRESS_1||PM_ADDRESS_2||PM_ADDRESS_3||PM_ADDRESS_4||PM_ADDRESS_5||PM_CITY||PM_COUNTRY||PM_REGION||PM_ZIPCODE as BillAddr from om_patient_master where PM_CUST_NO = '" + ds.Tables("Table").Rows.Item(0).Item(21).ToString + "'"
    '            Dim dsP As DataSet = db.SelectFromTableODBC(stQueryPatient)
    '            If dsP.Tables("Table").Rows.Count > 0 Then
    '                rptCustomerName = dsP.Tables("Table").Rows.Item(0).Item(0).ToString
    '                rptCustomerPhone = dsP.Tables("Table").Rows.Item(0).Item(2).ToString
    '                rptCustomerEmail = dsP.Tables("Table").Rows.Item(0).Item(3).ToString
    '            End If
    '        End If
    '        Dim totheaddiscamtval As Double = Convert.ToDouble(ds.Tables("Table").Rows.Item(0).Item(22).ToString)
    '        CreatePage()
    '        Dim itemlines As Integer = 0
    '        While rowcount > 0
    '            If Not i = 1 Then
    '                If i Mod 8 = 1 Then
    '                    CreatePage()
    '                    itemlines = 0
    '                End If
    '            End If
    '            row = ds.Tables("Table").Rows.Item(i)

    '            Dim pnl As New Panel
    '            Dim n As Integer
    '            n = pnlRows.Count
    '            With pnl
    '                .Location = New Point(0, itemlines * 38)
    '                .Name = "pnlRows" & n.ToString
    '                .Size = New Size(519, 38)
    '                '.BorderStyle = BorderStyle.FixedSingle
    '            End With
    '            Me.pnlRows.Add(pnl)
    '            Me.Controls.Find(currentItemPanel, True)(0).Controls.Add(pnl)

    '            Dim lbl As Label
    '            lbl = New Label
    '            n = lblRptSNOValue.Count
    '            With lbl
    '                .Location = New Point(0, 11)
    '                .Name = "lblRptSNOValue" & n.ToString
    '                .Size = New Size(31, 15)
    '                .AutoSize = False
    '                .TextAlign = ContentAlignment.MiddleCenter
    '                .Text = (i + 1).ToString
    '                .Font = New Font("Arial Narrow", 8, FontStyle.Regular)
    '                '.BorderStyle = BorderStyle.FixedSingle
    '            End With
    '            Me.lblRptSNOValue.Add(lbl)
    '            Me.Controls.Find("pnlRows" & n.ToString, True)(0).Controls.Add(lbl)

    '            lbl = New Label
    '            n = lblRptItemCodeValue.Count
    '            With lbl
    '                .Location = New Point(32, 5)
    '                .Name = "lblRptItemCodeValue" & n.ToString
    '                .Size = New Size(247, 15)
    '                .AutoSize = False
    '                .TextAlign = ContentAlignment.MiddleCenter
    '                .Text = row.Item(12).ToString
    '                .Font = New Font("Arial Narrow", 8, FontStyle.Regular)
    '                '.BorderStyle = BorderStyle.FixedSingle
    '            End With
    '            Me.lblRptItemCodeValue.Add(lbl)
    '            Me.Controls.Find("pnlRows" & n.ToString, True)(0).Controls.Add(lbl)

    '            lbl = New Label
    '            n = lblRptItemDescValue.Count
    '            With lbl
    '                .Location = New Point(32, 19)
    '                .Name = "lblRptItemDescValue" & n.ToString
    '                .Size = New Size(247, 15)
    '                .AutoSize = False
    '                .TextAlign = ContentAlignment.MiddleCenter
    '                .Text = "(" & row.Item(13).ToString & ")"
    '                .Font = New Font("Arial Narrow", 8, FontStyle.Regular)
    '                '.BorderStyle = BorderStyle.FixedSingle
    '            End With
    '            Me.lblRptItemDescValue.Add(lbl)
    '            Me.Controls.Find("pnlRows" & n.ToString, True)(0).Controls.Add(lbl)

    '            lbl = New Label
    '            n = lblRptUOMValue.Count
    '            With lbl
    '                .Location = New Point(280, 11)
    '                .Name = "lblRptUOMValue" & n.ToString
    '                .Size = New Size(44, 15)
    '                .AutoSize = False
    '                .TextAlign = ContentAlignment.MiddleCenter
    '                .Text = row.Item(14).ToString
    '                .Font = New Font("Arial Narrow", 8, FontStyle.Regular)
    '                '.BorderStyle = BorderStyle.FixedSingle
    '            End With
    '            Me.lblRptUOMValue.Add(lbl)
    '            Me.Controls.Find("pnlRows" & n.ToString, True)(0).Controls.Add(lbl)

    '            lbl = New Label
    '            n = lblRptRateValue.Count
    '            With lbl
    '                .Location = New Point(325, 11)
    '                .Name = "lblRptRateValue" & n.ToString
    '                .Size = New Size(59, 15)
    '                .AutoSize = False
    '                .TextAlign = ContentAlignment.MiddleRight
    '                .Text = row.Item(15).ToString
    '                .Font = New Font("Arial Narrow", 8, FontStyle.Regular)
    '                '.BorderStyle = BorderStyle.FixedSingle
    '            End With
    '            Me.lblRptRateValue.Add(lbl)
    '            Me.Controls.Find("pnlRows" & n.ToString, True)(0).Controls.Add(lbl)

    '            lbl = New Label
    '            n = lblRptQtyValue.Count
    '            With lbl
    '                .Location = New Point(385, 11)
    '                .Name = "lblRptQtyValue" & n.ToString
    '                .Size = New Size(44, 15)
    '                .AutoSize = False
    '                .TextAlign = ContentAlignment.MiddleCenter
    '                .Text = row.Item(16).ToString
    '                .Font = New Font("Arial Narrow", 8, FontStyle.Regular)
    '                '.BorderStyle = BorderStyle.FixedSingle
    '            End With
    '            Me.lblRptQtyValue.Add(lbl)
    '            Me.Controls.Find("pnlRows" & n.ToString, True)(0).Controls.Add(lbl)

    '            lbl = New Label
    '            n = lblRptAmtValue.Count
    '            With lbl
    '                .Location = New Point(430, 11)
    '                .Name = "lblRptAmtValue" & n.ToString
    '                .Size = New Size(89, 15)
    '                .AutoSize = False
    '                .TextAlign = ContentAlignment.MiddleRight
    '                .Text = Convert.ToDouble(row.Item(17).ToString).ToString("0.000")
    '                .Font = New Font("Arial Narrow", 8, FontStyle.Regular)
    '                '.BorderStyle = BorderStyle.FixedSingle
    '            End With
    '            Me.lblRptAmtValue.Add(lbl)
    '            Me.Controls.Find("pnlRows" & n.ToString, True)(0).Controls.Add(lbl)

    '            totalDiscountamt = totalDiscountamt + Convert.ToDouble(row.Item(18).ToString)
    '            totalExpenseamt = totalExpenseamt + Convert.ToDouble(row.Item(19).ToString)
    '            subtotalamt = subtotalamt + Convert.ToDouble(row.Item(17).ToString)

    '            itemlines = itemlines + 1
    '            rowcount = rowcount - 1
    '            i = i + 1
    '        End While

    '        Me.Controls.Find("lblINVDisTotal_VALUE" & currentPageNumber, True)(0).Text = Round(totalDiscountamt + totheaddiscamtval, 3).ToString("0.000")
    '        Me.Controls.Find("lblINVExpTotal_VALUE" & currentPageNumber, True)(0).Text = Round(totalExpenseamt, 3).ToString("0.000")
    '        Me.Controls.Find("lblINVSubTotal_VALUE" & currentPageNumber, True)(0).Text = Round(subtotalamt, 3).ToString("0.000")
    '        Me.Controls.Find("lblRptGrandTotal_VALUE" & currentPageNumber, True)(0).Text = Round((subtotalamt + totalExpenseamt) - (totalDiscountamt + totheaddiscamtval), 3).ToString("0.000")

    '        CreationPageBottom()
    '    Catch ex As Exception
    '        errLog.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")
    '    End Try
    'End Sub

    Private Sub loadReportSalesReturn()
        Try
            Dim stQuery As String = ""


            Dim ds As DataSet

            Dim row As System.Data.DataRow
            stQuery = stQuery + " select rownum,b.CSRH_NO ,to_char( b.CSRH_CR_DT,'DD/MM/YYYY HH12:MI AM') as InvoiceDate, "
            stQuery = stQuery + " d.ADDR_LINE_1 as locn_name,"
            stQuery = stQuery + " d.ADDR_LINE_2|| ' ' || d.ADDR_LINE_3"
            stQuery = stQuery + " as Location_Address,"
            stQuery = stQuery + " d.addr_tel as Phone,d.addr_email as Email,"
            stQuery = stQuery + " (select cust_name from om_customer where cust_code = b.CSRH_CUST_CODE)"
            stQuery = stQuery + "  as CustName,"
            stQuery = stQuery + " b.CSRH_BILL_ADDR_LINE_1||' '||b.CSRH_BILL_ADDR_LINE_2||' '||b.CSRH_BILL_COUNTRY_CODE as billing_addr,"
            stQuery = stQuery + " b.CSRH_BILL_TEL as billing_phone, b.CSRH_BILL_EMAIL as billing_email,"
            stQuery = stQuery + " b.CSRH_SHIP_ADDR_LINE_1||' '||b.CSRH_SHIP_ADDR_LINE_2||' '||b.CSRH_SHIP_COUNTRY_CODE as shipping_addr,"
            stQuery = stQuery + " a.CSRI_ITEM_CODE as ItemCode"
            stQuery = stQuery + ",a.CSRI_ITEM_DESC as ItemDesc,"
            stQuery = stQuery + " a.CSRI_UOM_CODE as ItmUOM,"
            stQuery = stQuery + " a.CSRI_RATE as ItmPrice ,"
            stQuery = stQuery + " a.CSRI_QTY as ItmQty,"
            'stQuery = stQuery + " a.CSRI_FC_VAL as ItmAmt,"
            stQuery = stQuery & " a.CSRI_RATE * a.CSRI_QTY  as ItmAmt, "
            stQuery = stQuery + " nvl((SELECT ITED_FC_AMT from OT_CUST_SALE_RET_ITEM_TED where ITED_I_SYS_ID= a.CSRI_SYS_ID and ITED_TED_HEAD_ITEM_NUM=2 and ITED_TED_TYPE_NUM=(select TED_TAX_DISC_EXP_NUM  from OM_TED_TYPE where TED_TYPE_CODE='TEDDIS')),0) as disamt,"
            stQuery = stQuery & " nvl((SELECT ITED_FC_AMT from OT_CUST_SALE_RET_ITEM_TED where ITED_I_SYS_ID= a.CSRI_SYS_ID and ITED_TED_HEAD_ITEM_NUM=2 and ITED_TED_TYPE_NUM=(select TED_TAX_DISC_EXP_NUM  from OM_TED_TYPE where TED_TYPE_CODE='TEDEXP')),0) as expamt,CSRH_SM_CODE as salesman,CSRH_FLEX_03 as pm_cust_no,"
            stQuery = stQuery + " nvl((SELECT ITED_FC_AMT from OT_CUST_SALE_RET_ITEM_TED where ITED_H_SYS_ID= b.CSRH_SYS_ID and ITED_TED_HEAD_ITEM_NUM=1 and ITED_TED_TYPE_NUM=(select TED_TAX_DISC_EXP_NUM  from OM_TED_TYPE where TED_TYPE_CODE='TEDDIS')),0) as totdisamt, nvl( (select ITEM_BL_LONG_NAME_1 from om_item where ITEM_CODE = a.CSRI_ITEM_CODE), ' ') as arabicname, nvl(c.LOCN_BL_NAME, ' ') as locnArabicName, nvl(d.ADDR_LINE_4||' '||d.ADDR_LINE_5 , ' ') as locnArabicAddress, "
            stQuery = stQuery + " nvl((SELECT ITED_FC_AMT from OT_CUST_SALE_RET_ITEM_TED where ITED_I_SYS_ID= a.CSRI_SYS_ID and ITED_TED_TYPE_NUM=(select TED_TAX_DISC_EXP_NUM  from OM_TED_TYPE where TED_TYPE_CODE='TAX')),0) as taxamt, "
            stQuery = stQuery & " c.LOCN_FLEX_11 as taxTRN "
            stQuery = stQuery + " from "
            stQuery = stQuery + " OT_CUST_SALE_RET_HEAD b,OT_CUST_SALE_RET_ITEM a,om_location c,om_address d"
            stQuery = stQuery + " where b.CSRH_NO = " + TXN_NO.ToString + " and"
            stQuery = stQuery + " b.CSRH_SYS_ID = a.CSRI_CSRH_SYS_ID and"
            stQuery = stQuery + " b.CSRH_LOCN_CODE = c.locn_code and c.locn_addr_code = d.addr_code"
            errLog.WriteToErrorLog("Direct Invoice Report Query", stQuery, "")

            ds = db.SelectFromTableODBC(stQuery)

            Transactions.transtype = "Sales Return"
            Transactions.printdataset = ds
            printds = ds



            Dim rowcount As Integer = ds.Tables("Table").Rows.Count
            Dim i As Integer = 0

            rptDate = ds.Tables("Table").Rows.Item(0).Item(2).ToString
            rptLocationName = ds.Tables("Table").Rows.Item(0).Item(3).ToString
            rptLocationAddr = ds.Tables("Table").Rows.Item(0).Item(4).ToString
            rptLocationPhone = ds.Tables("Table").Rows.Item(0).Item(5).ToString
            rptLocationEmail = ds.Tables("Table").Rows.Item(0).Item(6).ToString
            rptTotalDiscount = ds.Tables("Table").Rows.Item(0).Item(22).ToString
            rptTRN = ds.Tables("Table").Rows.Item(0).Item(27).ToString

            Dim stSalesQuery As String = ""
            stSalesQuery = "Select SM_NAME from om_salesman where SM_CODE='" & ds.Tables("Table").Rows.Item(0).Item(20).ToString & "'"
            Dim dsSal As DataSet = db.SelectFromTableODBC(stSalesQuery)
            If dsSal.Tables("Table").Rows.Count > 0 Then
                rptSalesmanName = ds.Tables("Table").Rows.Item(0).Item(20).ToString & " - " & dsSal.Tables("Table").Rows.Item(0).Item(0).ToString
            End If
            'rptSalesmanName = ds.Tables("Table").Rows.Item(0).Item(20).ToString
            If ds.Tables("Table").Rows.Item(0).Item(21).ToString = "" Then
                rptCustomerName = ds.Tables("Table").Rows.Item(0).Item(7).ToString
                rptCustomerPhone = ds.Tables("Table").Rows.Item(0).Item(9).ToString
                rptCustomerEmail = ds.Tables("Table").Rows.Item(0).Item(10).ToString
            Else
                'Dim stQueryPatient As String
                'stQueryPatient = "select PM_PATIENT_NAME as PatName,PM_ADDRESS_1||PM_ADDRESS_2||PM_ADDRESS_3||PM_ADDRESS_4||PM_ADDRESS_5||PM_CITY||PM_COUNTRY||PM_REGION||PM_ZIPCODE as ShipAddr,PM_TEL_MOB,PM_EMAIL,PM_ADDRESS_1||PM_ADDRESS_2||PM_ADDRESS_3||PM_ADDRESS_4||PM_ADDRESS_5||PM_CITY||PM_COUNTRY||PM_REGION||PM_ZIPCODE as BillAddr from om_patient_master where PM_CUST_NO = '" + ds.Tables("Table").Rows.Item(0).Item(21).ToString + "'"
                'Dim dsP As DataSet = db.SelectFromTableODBC(stQueryPatient)
                'If dsP.Tables("Table").Rows.Count > 0 Then
                '    rptCustomerName = dsP.Tables("Table").Rows.Item(0).Item(0).ToString
                '    rptCustomerPhone = dsP.Tables("Table").Rows.Item(0).Item(2).ToString
                '    rptCustomerEmail = dsP.Tables("Table").Rows.Item(0).Item(3).ToString
                'End If
            End If
            totheaddiscamtval = Convert.ToDouble(ds.Tables("Table").Rows.Item(0).Item(22).ToString)
            Dim totTax As Double = 0

            'lblRptLocationName.Text = rptLocationName
            lblRptLocationAddress.Text = rptLocationAddr
            lblPhone.Text = "TEL: " & rptLocationPhone
            lblEmail.Text = "Email: " & rptLocationEmail
            lblRptINVSONO.Text = "SRTN.No:" & "  " & TXN_NO.ToString
            lblSalesmanName.Text = rptSalesmanName
            lblDate.Text = lblDate.Text & " " & rptDate.Split(" ")(0)
            lblTime.Text = lblTime.Text & " " & rptDate.Split(" ")(1) & " " & rptDate.Split(" ")(2)
            lblRptRptType.Text = "SALES RETURN"
            Dim itemlines As Integer = 0
            While rowcount > 0
                row = ds.Tables("Table").Rows.Item(i)

                Dim pnl As New Panel
                Dim n As Integer
                n = pnlRows.Count
                With pnl
                    .Location = New Point(0, itemlines * 26)
                    .Name = "pnlRows" & n.ToString
                    .Size = New Size(268, 26)
                    '.BorderStyle = BorderStyle.FixedSingle
                End With
                Me.pnlRows.Add(pnl)
                'Me.Controls.Find(currentItemPanel, True)(0).Controls.Add(pnl)
                pnlRptItemsHolder.Controls.Add(pnl)
                pnlRptItemsHolder.Height = pnlRptItemsHolder.Height + 26
                pnlRPTPANEL.Height = pnlRPTPANEL.Height + 26
                pnlFooterDetails.Location = New Point(pnlFooterDetails.Location.X, pnlFooterDetails.Location.Y + 26)

                Dim lbl As Label
                lbl = New Label
                'n = lblRptSNOValue.Count
                'With lbl
                '    .Location = New Point(0, 11)
                '    .Name = "lblRptSNOValue" & n.ToString
                '    .Size = New Size(31, 15)
                '    .AutoSize = False
                '    .TextAlign = ContentAlignment.MiddleCenter
                '    .Text = (i + 1).ToString
                '    .Font = New Font("Arial Narrow", 8, FontStyle.Regular)
                '    '.BorderStyle = BorderStyle.FixedSingle
                'End With
                'Me.lblRptSNOValue.Add(lbl)
                'Me.Controls.Find("pnlRows" & n.ToString, True)(0).Controls.Add(lbl)

                lbl = New Label
                n = lblRptItemCodeValue.Count
                With lbl
                    .Location = New Point(2, 1)
                    .Name = "lblRptItemCodeValue" & n.ToString
                    .Size = New Size(153, 14)
                    .AutoSize = False
                    .TextAlign = ContentAlignment.TopLeft
                    .Text = row.Item(12).ToString
                    .Font = New Font("Arial", 8, FontStyle.Bold)
                    '.BorderStyle = BorderStyle.FixedSingle
                End With
                Me.lblRptItemCodeValue.Add(lbl)
                Me.Controls.Find("pnlRows" & n.ToString, True)(0).Controls.Add(lbl)

                lbl = New Label
                n = lblRptItemDescValue.Count
                Dim arabicVal As String
                arabicVal = row.Item(23).ToString
                If row.Item(23).ToString.Equals("") Then
                    arabicVal = "هدية البند"
                End If
                With lbl
                    .Location = New Point(1, 13)
                    .Name = "lblRptItemDescValue" & n.ToString
                    .Size = New Size(153, 14)
                    .AutoSize = False
                    .TextAlign = ContentAlignment.TopLeft
                    .Text = arabicVal 'row.Item(23).ToString
                    .Font = New Font("Arial", 8, FontStyle.Regular)
                    '.BorderStyle = BorderStyle.FixedSingle
                End With
                Me.lblRptItemDescValue.Add(lbl)
                Me.Controls.Find("pnlRows" & n.ToString, True)(0).Controls.Add(lbl)

                'lbl = New Label
                'n = lblRptUOMValue.Count
                'With lbl
                '    .Location = New Point(280, 11)
                '    .Name = "lblRptUOMValue" & n.ToString
                '    .Size = New Size(44, 15)
                '    .AutoSize = False
                '    .TextAlign = ContentAlignment.MiddleCenter
                '    .Text = row.Item(14).ToString
                '    .Font = New Font("Arial Narrow", 8, FontStyle.Regular)
                '    '.BorderStyle = BorderStyle.FixedSingle
                'End With
                'Me.lblRptUOMValue.Add(lbl)
                'Me.Controls.Find("pnlRows" & n.ToString, True)(0).Controls.Add(lbl)

                'lbl = New Label
                'n = lblRptRateValue.Count
                'With lbl
                '    .Location = New Point(325, 11)
                '    .Name = "lblRptRateValue" & n.ToString
                '    .Size = New Size(59, 15)
                '    .AutoSize = False
                '    .TextAlign = ContentAlignment.MiddleRight
                '    .Text = row.Item(15).ToString
                '    .Font = New Font("Arial Narrow", 8, FontStyle.Regular)
                '    '.BorderStyle = BorderStyle.FixedSingle
                'End With
                'Me.lblRptRateValue.Add(lbl)
                'Me.Controls.Find("pnlRows" & n.ToString, True)(0).Controls.Add(lbl)

                lbl = New Label
                n = lblRptQtyValue.Count
                With lbl
                    .Location = New Point(156, 10)
                    .Name = "lblRptQtyValue" & n.ToString
                    .Size = New Size(40, 15)
                    .AutoSize = False
                    .TextAlign = ContentAlignment.MiddleCenter
                    .Text = row.Item(16).ToString
                    .Font = New Font("Arial", 8, FontStyle.Bold)
                    '.BorderStyle = BorderStyle.FixedSingle
                End With
                Me.lblRptQtyValue.Add(lbl)
                Me.Controls.Find("pnlRows" & n.ToString, True)(0).Controls.Add(lbl)

                lbl = New Label
                n = lblRptAmtValue.Count
                With lbl
                    .Location = New Point(198, 10)
                    .Name = "lblRptAmtValue" & n.ToString
                    .Size = New Size(62, 15)
                    .AutoSize = False
                    .TextAlign = ContentAlignment.MiddleRight
                    .Text = Convert.ToDouble(row.Item(17).ToString).ToString("0.00")
                    .Font = New Font("Arial", 8, FontStyle.Bold)
                    '.BorderStyle = BorderStyle.FixedSingle
                End With
                Me.lblRptAmtValue.Add(lbl)
                Me.Controls.Find("pnlRows" & n.ToString, True)(0).Controls.Add(lbl)

                totalDiscountamt = totalDiscountamt + Convert.ToDouble(row.Item(18).ToString)
                totalExpenseamt = totalExpenseamt + Convert.ToDouble(row.Item(19).ToString)
                subtotalamt = subtotalamt + Convert.ToDouble(row.Item(17).ToString)
                totTax = totTax + Convert.ToDouble(row.Item(26).ToString)

                itemlines = itemlines + 1
                rowcount = rowcount - 1
                i = i + 1
            End While
            rptTotalDiscount = rptTotalDiscount + totalDiscountamt
            If Not rptTotalDiscount = 0 Then
                lblDTamt.Text = Convert.ToDouble(rptTotalDiscount).ToString("0.00")
                lblTotalamt.Text = (subtotalamt - Convert.ToDouble(rptTotalDiscount)).ToString("0.00")
            Else
                lblTotalamt.Text = subtotalamt
                Label8.Visible = False
                lblDTamt.Visible = False
            End If
            lblTotalTaxAmt = totTax.ToString("0.00")
            'Me.Controls.Find("lblINVDisTotal_VALUE" & currentPageNumber, True)(0).Text = Round(totalDiscountamt + totheaddiscamtval, 3).ToString("0.000")
            'Me.Controls.Find("lblINVExpTotal_VALUE" & currentPageNumber, True)(0).Text = Round(totalExpenseamt, 3).ToString("0.000")
            'Me.Controls.Find("lblINVSubTotal_VALUE" & currentPageNumber, True)(0).Text = Round(subtotalamt, 3).ToString("0.000")
            'Me.Controls.Find("lblRptGrandTotal_VALUE" & currentPageNumber, True)(0).Text = Round((subtotalamt + totalExpenseamt) - (totalDiscountamt + totheaddiscamtval), 3).ToString("0.000")

            'CreationPageBottom()
        Catch ex As Exception
            errLog.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")
        End Try
    End Sub

    Private Sub loadReportInvoice()
        Try
            Dim stQuery As String = ""
            Dim ds As DataSet
            Dim row As System.Data.DataRow
            stQuery = stQuery + " select rownum,b.invh_no ,to_char( b.invh_cr_dt,'DD/MM/YYYY HH12:MI AM') as InvoiceDate, "
            stQuery = stQuery + " d.ADDR_LINE_1 as locn_name,"
            stQuery = stQuery + " d.ADDR_LINE_2|| ' ' || d.ADDR_LINE_3"
            stQuery = stQuery + " as Location_Address,"
            stQuery = stQuery + " d.addr_tel as Phone,d.addr_email as Email,"
            stQuery = stQuery + " (select cust_name from om_customer where cust_code = b.invh_cust_code) as CustName,"
            stQuery = stQuery + " b.invh_BILL_ADDR_LINE_1||' '||b.invh_BILL_ADDR_LINE_2||' '||b.invh_BILL_COUNTRY_CODE as billing_addr,"
            stQuery = stQuery + " b.INVH_BILL_TEL as billing_phone, b.invh_BILL_EMAIL as billing_email,"
            stQuery = stQuery + " b.invh_SHIP_ADDR_LINE_1||' '||b.invh_SHIP_ADDR_LINE_2||' '||b.invh_SHIP_COUNTRY_CODE as shipping_addr,"
            stQuery = stQuery + " a.INVI_ITEM_CODE as ItemCode"
            stQuery = stQuery + ",a.INVI_ITEM_DESC as ItemDesc,"
            stQuery = stQuery + " a.INVI_UOM_CODE as ItmUOM,"
            stQuery = stQuery + " a.INVI_PL_RATE as ItmPrice ,"
            stQuery = stQuery + " a.INVI_QTY as ItmQty,"
            'stQuery = stQuery + " a.INVI_FC_VAL as ItmAmt,"
            stQuery = stQuery & " a.INVI_PL_RATE * a.INVI_QTY as ItmAmt, "
            stQuery = stQuery + " nvl((select ITED_FC_AMT from OT_INVOICE_ITEM_TED where ITED_I_SYS_ID=INVI_SYS_ID and ITED_TED_HEAD_ITEM_NUM=2 and ITED_TED_TYPE_NUM=(select TED_TAX_DISC_EXP_NUM from OM_TED_TYPE where TED_TYPE_CODE='TEDDIS')),0) as disamt,"
            stQuery = stQuery + " nvl((select ITED_FC_AMT from OT_INVOICE_ITEM_TED where ITED_I_SYS_ID=INVI_SYS_ID and ITED_TED_HEAD_ITEM_NUM=2 and ITED_TED_TYPE_NUM=(select TED_TAX_DISC_EXP_NUM from OM_TED_TYPE where TED_TYPE_CODE='TEDEXP')),0) as expamt,INVH_SM_CODE as salesman,INVH_FLEX_03 as pmcustno,"
            stQuery = stQuery + " nvl((select ITED_FC_AMT from OT_INVOICE_ITEM_TED where ITED_H_SYS_ID=INVH_SYS_ID and ITED_TED_HEAD_ITEM_NUM=1 and ITED_TED_TYPE_NUM=(select TED_TAX_DISC_EXP_NUM from OM_TED_TYPE where TED_TYPE_CODE='TEDDIS')),0) as totdisamt, (select ITEM_BL_LONG_NAME_1 from om_item where ITEM_CODE = a.INVI_ITEM_CODE) as arabicname, c.LOCN_BL_NAME as locnArabicName, d.ADDR_LINE_4||' '||d.ADDR_LINE_5 as locnArabicAddress, "
            stQuery = stQuery + " nvl((select ITED_FC_AMT from OT_INVOICE_ITEM_TED where ITED_I_SYS_ID=INVI_SYS_ID and ITED_TED_HEAD_ITEM_NUM=2 and ITED_TED_TYPE_NUM=(select TED_TAX_DISC_EXP_NUM from OM_TED_TYPE where TED_TYPE_CODE='TAX')),0) as taxamt, "
            stQuery = stQuery & " c.LOCN_FLEX_11 as taxTRN "
            stQuery = stQuery + " from "
            stQuery = stQuery + " ot_invoice_head b,ot_invoice_item a,om_location c,om_address d"
            stQuery = stQuery + " where b.invh_no = " & TXN_NO & " and"
            stQuery = stQuery + " b.invh_sys_id = a.invi_invh_sys_id and"
            stQuery = stQuery + " b.invh_locn_code = c.locn_code and c.locn_addr_code = d.addr_code and  INVH_TXN_CODE='POSINV'"
            errLog.WriteToErrorLog("Direct Invoice Report Query", stQuery, "")
            ds = db.SelectFromTableODBC(stQuery)
            Transactions.transtype = "Direct Invoice"
            Transactions.printdataset = ds
            printds = ds
            'Exit Sub

            Dim rowcount As Integer = ds.Tables("Table").Rows.Count
            Dim i As Integer = 0

            rptDate = ds.Tables("Table").Rows.Item(0).Item(2).ToString
            rptLocationName = ds.Tables("Table").Rows.Item(0).Item(3).ToString
            rptLocationAddr = ds.Tables("Table").Rows.Item(0).Item(4).ToString
            rptLocationPhone = ds.Tables("Table").Rows.Item(0).Item(5).ToString
            rptLocationEmail = ds.Tables("Table").Rows.Item(0).Item(6).ToString
            rptTotalDiscount = ds.Tables("Table").Rows.Item(0).Item(22).ToString
            rptTRN = ds.Tables("Table").Rows.Item(0).Item(27).ToString

            Dim stSalesQuery As String = ""
            stSalesQuery = "Select SM_NAME from om_salesman where SM_CODE='" & ds.Tables("Table").Rows.Item(0).Item(20).ToString & "'"
            Dim dsSal As DataSet = db.SelectFromTableODBC(stSalesQuery)
            If dsSal.Tables("Table").Rows.Count > 0 Then
                rptSalesmanName = ds.Tables("Table").Rows.Item(0).Item(20).ToString & " - " & dsSal.Tables("Table").Rows.Item(0).Item(0).ToString
            End If
            'rptSalesmanName = ds.Tables("Table").Rows.Item(0).Item(20).ToString
            If ds.Tables("Table").Rows.Item(0).Item(21).ToString = "" Then
                rptCustomerName = ds.Tables("Table").Rows.Item(0).Item(7).ToString
                rptCustomerPhone = ds.Tables("Table").Rows.Item(0).Item(9).ToString
                rptCustomerEmail = ds.Tables("Table").Rows.Item(0).Item(10).ToString
            Else
                'Dim stQueryPatient As String
                'stQueryPatient = "select PM_PATIENT_NAME as PatName,PM_ADDRESS_1||PM_ADDRESS_2||PM_ADDRESS_3||PM_ADDRESS_4||PM_ADDRESS_5||PM_CITY||PM_COUNTRY||PM_REGION||PM_ZIPCODE as ShipAddr,PM_TEL_MOB,PM_EMAIL,PM_ADDRESS_1||PM_ADDRESS_2||PM_ADDRESS_3||PM_ADDRESS_4||PM_ADDRESS_5||PM_CITY||PM_COUNTRY||PM_REGION||PM_ZIPCODE as BillAddr from om_patient_master where PM_CUST_NO = '" + ds.Tables("Table").Rows.Item(0).Item(21).ToString + "'"
                'Dim dsP As DataSet = db.SelectFromTableODBC(stQueryPatient)
                'If dsP.Tables("Table").Rows.Count > 0 Then
                '    rptCustomerName = dsP.Tables("Table").Rows.Item(0).Item(0).ToString
                '    rptCustomerPhone = dsP.Tables("Table").Rows.Item(0).Item(2).ToString
                '    rptCustomerEmail = dsP.Tables("Table").Rows.Item(0).Item(3).ToString
                'End If
            End If
            totheaddiscamtval = Convert.ToDouble(ds.Tables("Table").Rows.Item(0).Item(22).ToString)

            lblRptLocationName.Text = rptLocationName
            lblRptLocationAddress.Text = rptLocationAddr
            lblPhone.Text = "TEL: " & rptLocationPhone
            lblEmail.Text = "Email/بريد: " & rptLocationEmail
            lblRptINVSONO.Text = lblRptINVSONO.Text & "  " & TXN_NO.ToString
            lblSalesmanName.Text = rptSalesmanName
            lblDate.Text = lblDate.Text & " " & rptDate.Split(" ")(0)
            lblTime.Text = lblTime.Text & " " & rptDate.Split(" ")(1) & " " & rptDate.Split(" ")(2)

            Dim itemlines As Integer = 0
            While rowcount > 0
                row = ds.Tables("Table").Rows.Item(i)

                Dim pnl As New Panel
                Dim n As Integer
                n = pnlRows.Count
                With pnl
                    .Location = New Point(0, itemlines * 26)
                    .Name = "pnlRows" & n.ToString
                    .Size = New Size(268, 26)
                    '.BorderStyle = BorderStyle.FixedSingle
                End With
                Me.pnlRows.Add(pnl)
                'Me.Controls.Find(currentItemPanel, True)(0).Controls.Add(pnl)
                pnlRptItemsHolder.Controls.Add(pnl)
                pnlRptItemsHolder.Height = pnlRptItemsHolder.Height + 26
                pnlRPTPANEL.Height = pnlRPTPANEL.Height + 26
                pnlFooterDetails.Location = New Point(pnlFooterDetails.Location.X, pnlFooterDetails.Location.Y + 26)

                Dim lbl As Label
                lbl = New Label
                'n = lblRptSNOValue.Count
                'With lbl
                '    .Location = New Point(0, 11)
                '    .Name = "lblRptSNOValue" & n.ToString
                '    .Size = New Size(31, 15)
                '    .AutoSize = False
                '    .TextAlign = ContentAlignment.MiddleCenter
                '    .Text = (i + 1).ToString
                '    .Font = New Font("Arial Narrow", 8, FontStyle.Regular)
                '    '.BorderStyle = BorderStyle.FixedSingle
                'End With
                'Me.lblRptSNOValue.Add(lbl)
                'Me.Controls.Find("pnlRows" & n.ToString, True)(0).Controls.Add(lbl)

                lbl = New Label
                n = lblRptItemCodeValue.Count
                With lbl
                    .Location = New Point(2, 1)
                    .Name = "lblRptItemCodeValue" & n.ToString
                    .Size = New Size(153, 14)
                    .AutoSize = False
                    .TextAlign = ContentAlignment.TopLeft
                    .Text = row.Item(12).ToString
                    .Font = New Font("Arial", 8, FontStyle.Bold)
                    '.BorderStyle = BorderStyle.FixedSingle
                End With
                Me.lblRptItemCodeValue.Add(lbl)
                Me.Controls.Find("pnlRows" & n.ToString, True)(0).Controls.Add(lbl)

                lbl = New Label
                n = lblRptItemDescValue.Count
                Dim arabicVal As String
                arabicVal = row.Item(23).ToString
                If row.Item(23).ToString.Equals("") Then
                    arabicVal = "هدية البند"
                End If
                With lbl
                    .Location = New Point(1, 13)
                    .Name = "lblRptItemDescValue" & n.ToString
                    .Size = New Size(153, 14)
                    .AutoSize = False
                    .TextAlign = ContentAlignment.TopLeft
                    .Text = arabicVal  'row.Item(23).ToString
                    .Font = New Font("Arial", 8, FontStyle.Regular)
                    '.BorderStyle = BorderStyle.FixedSingle
                End With
                Me.lblRptItemDescValue.Add(lbl)
                Me.Controls.Find("pnlRows" & n.ToString, True)(0).Controls.Add(lbl)

                'lbl = New Label
                'n = lblRptUOMValue.Count
                'With lbl
                '    .Location = New Point(280, 11)
                '    .Name = "lblRptUOMValue" & n.ToString
                '    .Size = New Size(44, 15)
                '    .AutoSize = False
                '    .TextAlign = ContentAlignment.MiddleCenter
                '    .Text = row.Item(14).ToString
                '    .Font = New Font("Arial Narrow", 8, FontStyle.Regular)
                '    '.BorderStyle = BorderStyle.FixedSingle
                'End With
                'Me.lblRptUOMValue.Add(lbl)
                'Me.Controls.Find("pnlRows" & n.ToString, True)(0).Controls.Add(lbl)

                'lbl = New Label
                'n = lblRptRateValue.Count
                'With lbl
                '    .Location = New Point(325, 11)
                '    .Name = "lblRptRateValue" & n.ToString
                '    .Size = New Size(59, 15)
                '    .AutoSize = False
                '    .TextAlign = ContentAlignment.MiddleRight
                '    .Text = row.Item(15).ToString
                '    .Font = New Font("Arial Narrow", 8, FontStyle.Regular)
                '    '.BorderStyle = BorderStyle.FixedSingle
                'End With
                'Me.lblRptRateValue.Add(lbl)
                'Me.Controls.Find("pnlRows" & n.ToString, True)(0).Controls.Add(lbl)

                lbl = New Label
                n = lblRptQtyValue.Count

                With lbl
                    .Location = New Point(156, 10)
                    .Name = "lblRptQtyValue" & n.ToString
                    .Size = New Size(40, 15)
                    .AutoSize = False
                    .TextAlign = ContentAlignment.MiddleCenter
                    .Text = Convert.ToDecimal(row.Item(16).ToString)

                    ''.Text = CDec(row.Item(16))
                    ''Dim totqtyval As Double
                    '' totqtyval = Transactions.txtTotalQty.Text
                    ''Text = Convert.ToDouble(totqtyval.ToString)

                    .Font = New Font("Arial", 8, FontStyle.Bold)
                    '.BorderStyle = BorderStyle.FixedSingle
                    '.BackColor = Color

                End With
                Me.lblRptQtyValue.Add(lbl)
                Me.Controls.Find("pnlRows" & n.ToString, True)(0).Controls.Add(lbl)

                lbl = New Label
                n = lblRptAmtValue.Count
                With lbl
                    .Location = New Point(198, 10)
                    .Name = "lblRptAmtValue" & n.ToString
                    .Size = New Size(62, 15)
                    .AutoSize = False
                    .TextAlign = ContentAlignment.MiddleRight
                    .Text = Convert.ToDouble(row.Item(17).ToString).ToString("0.00")
                    .Font = New Font("Arial", 8, FontStyle.Bold)
                    '.BorderStyle = BorderStyle.FixedSingle
                End With
                Me.lblRptAmtValue.Add(lbl)
                Me.Controls.Find("pnlRows" & n.ToString, True)(0).Controls.Add(lbl)

                totalDiscountamt = totalDiscountamt + Convert.ToDouble(row.Item(18).ToString)
                totalExpenseamt = totalExpenseamt + Convert.ToDouble(row.Item(19).ToString)
                subtotalamt = subtotalamt + Convert.ToDouble(row.Item(17).ToString)
                totalTaxAmount = totalTaxAmount + Convert.ToDouble(row.Item(26).ToString)

                itemlines = itemlines + 1
                rowcount = rowcount - 1
                i = i + 1
            End While
            rptTotalDiscount = rptTotalDiscount + totalDiscountamt
            If Not rptTotalDiscount = 0 Then
                lblDTamt.Text = Convert.ToDouble(rptTotalDiscount).ToString("0.00")
                lblTotalamt.Text = (subtotalamt - Convert.ToDouble(rptTotalDiscount)).ToString("0.00")
            Else
                Label8.Visible = False
                lblDTamt.Visible = False
                lblTotalamt.Text = (subtotalamt - Convert.ToDouble(rptTotalDiscount)).ToString("0.00")
            End If

            lblTotalTaxAmt.Text = totalTaxAmount.ToString("0.00")

            'Me.Controls.Find("lblINVDisTotal_VALUE" & currentPageNumber, True)(0).Text = Round(totalDiscountamt + totheaddiscamtval, 3).ToString("0.000")
            'Me.Controls.Find("lblINVExpTotal_VALUE" & currentPageNumber, True)(0).Text = Round(totalExpenseamt, 3).ToString("0.000")
            'Me.Controls.Find("lblINVSubTotal_VALUE" & currentPageNumber, True)(0).Text = Round(subtotalamt, 3).ToString("0.000")
            'Me.Controls.Find("lblRptGrandTotal_VALUE" & currentPageNumber, True)(0).Text = Round((subtotalamt + totalExpenseamt) - (totalDiscountamt + totheaddiscamtval), 3).ToString("0.000")

            'CreationPageBottom()
            Dim thankyou1 As String = ""
            Dim thankyou2 As String = ""
            Dim welcome1 As String = ""
            Dim welcome2 As String = ""
            If Setup_Values.ContainsKey("LINE_DISP_TL_1") Then
                thankyou1 = Setup_Values("LINE_DISP_TL_1")
            End If
            If Setup_Values.ContainsKey("LINE_DISP_TL_2") Then
                thankyou2 = Setup_Values("LINE_DISP_TL_2")
            End If
            If Setup_Values.ContainsKey("LINE_DISP_WL_1") Then
                welcome1 = Setup_Values("LINE_DISP_WL_1")
            End If
            If Setup_Values.ContainsKey("LINE_DISP_WL_2") Then
                welcome2 = Setup_Values("LINE_DISP_WL_2")
            End If
            If Not thankyou1 Is Nothing And thankyou1.ToString().Length > 0 Then
                Label12.Text = thankyou1
            End If
            If Not thankyou2 Is Nothing And thankyou2.ToString().Length > 0 Then
                Label10.Text = thankyou2
            End If
            If Not welcome1 Is Nothing And welcome1.ToString().Length > 0 Then
                Label13.Text = welcome1
            End If
            If Not welcome2 Is Nothing And welcome2.ToString().Length > 0 Then
                Label11.Text = welcome2
            End If
        Catch ex As Exception
            errLog.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")
        End Try
    End Sub

    Private Sub CreationPageBottom()
        pnlOuterContainer.AutoScrollPosition = New System.Drawing.Point(0, 0)

        Dim pnl As Panel
        Dim n As Integer
        n = pnlPages.Count
        pnl = New Panel

        With pnl
            .Location = New Point(5, (n * 864) + ((n + 1) * 5))
            .Name = "pnlPageBottom" & n.ToString
            'currentpage = "pnlReportPage" & n.ToString
            .Size = New Size(760, 5)
            .BorderStyle = BorderStyle.None
            '.BackColor = Color.White
        End With

        Me.pnlOuterContainer.Controls.Add(pnl)
    End Sub

    Private Sub CreatePage()

        pnlOuterContainer.AutoScrollPosition = New System.Drawing.Point(0, 0)

        Dim pnl As Panel
        Dim n As Integer
        n = pnlPages.Count
        pnl = New Panel

        With pnl
            If n = 0 Then
                .Location = New Point(5, (n * 864) + 5)
            Else
                .Location = New Point(5, (n * 864) + ((n + 1) * 5))
            End If
            .Name = "pnlPage" & n.ToString
            currentPage = "pnlPage" & n.ToString
            currentPageNumber = n.ToString
            .Size = New Size(760, 984)
            .BorderStyle = BorderStyle.FixedSingle
            .BackColor = Color.White
            .Cursor = Cursors.Hand
        End With
        Dim ttPage As New ToolTip()
        ttPage.SetToolTip(pnl, "Page " & (n + 1).ToString)
        Me.pnlPages.Add(pnl)
        Me.pnlOuterContainer.Controls.Add(pnl)

        Dim pic As New PictureBox
        n = picReport.Count
        With pic
            .Location = New Point(344, 0)
            .Name = "picReport" & n.ToString
            .Size = New Size(100, 57)
            .Image = My.Resources.clientlogoJPEG
            .SizeMode = PictureBoxSizeMode.StretchImage
        End With
        Me.picReport.Add(pic)
        Me.Controls.Find(currentPage, True)(0).Controls.Add(pic)

        Dim lbl As Label

        lbl = New Label
        n = lblLocnName.Count
        With lbl
            .Location = New Point(138, 58)
            .Name = "lblLocnName" & n.ToString
            .Size = New Size(504, 15)
            .AutoSize = False
            .TextAlign = ContentAlignment.MiddleCenter
            .Text = rptLocationName
            InvTitle = rptLocationName
            .Font = New Font("Arial", 9, FontStyle.Bold)
        End With
        Me.lblLocnName.Add(lbl)
        Me.Controls.Find(currentPage, True)(0).Controls.Add(lbl)

        lbl = New Label
        n = lblLocnAddr.Count
        With lbl
            .Location = New Point(138, 74)
            .Name = "lblLocnAddr" & n.ToString
            .Size = New Size(504, 15)
            .AutoSize = False
            .TextAlign = ContentAlignment.MiddleCenter
            .Text = rptLocationAddr
            InvSubTitle1 = rptLocationAddr
            .Font = New Font("Arial", 8, FontStyle.Bold)
        End With
        Me.lblLocnAddr.Add(lbl)
        Me.Controls.Find(currentPage, True)(0).Controls.Add(lbl)

        lbl = New Label
        n = lblLocnPhone.Count
        With lbl
            .Location = New Point(138, 90)
            .Name = "lblLocnPhone" & n.ToString
            .Size = New Size(504, 15)
            .AutoSize = False
            .TextAlign = ContentAlignment.MiddleCenter
            If Not rptLocationPhone = "" Then
                .Text = "Phone : " & rptLocationPhone
                InvSubTitle2 = "Phone : " & rptLocationPhone
            End If
        End With
        Me.lblLocnPhone.Add(lbl)
        Me.Controls.Find(currentPage, True)(0).Controls.Add(lbl)

        lbl = New Label
        n = lblLocnEmail.Count
        With lbl
            .Location = New Point(138, 106)
            .Name = "lblLocnEmail" & n.ToString
            .Size = New Size(504, 15)
            .AutoSize = False
            .TextAlign = ContentAlignment.MiddleCenter
            If Not rptLocationEmail = "" Then
                .Text = "Email : " & rptLocationEmail
                InvSubTitle3 = "Email : " & rptLocationEmail
            End If
        End With
        Me.lblLocnEmail.Add(lbl)
        Me.Controls.Find(currentPage, True)(0).Controls.Add(lbl)

        pnl = New Panel
        n = pnlTxnTypeDecl.Count
        With pnl
            .Location = New Point(130, 123)
            .Size = New Size(522, 18)
            .BorderStyle = BorderStyle.FixedSingle
            .BackColor = Color.Silver
            .Name = "pnlTxnTypeDecl" & n.ToString
        End With
        Me.pnlTxnTypeDecl.Add(pnl)
        Me.Controls.Find(currentPage, True)(0).Controls.Add(pnl)

        lbl = New Label
        n = lblTxnTypeDecl.Count
        With lbl
            .Location = New Point(205, 0)
            If TXN_TYPE = "Invoice" Then
                .Text = "Direct Invoice"
            ElseIf TXN_TYPE = "Sales Order" Then
                .Text = "Sales Order"
            ElseIf TXN_TYPE = "Sales Invoice" Then
                .Text = "Sales Invoice"
            ElseIf TXN_TYPE = "Sales Return" Then
                .Text = "Sales Return"
            End If
            .ForeColor = Color.White
            .Name = "lblTxnTypeDecl" & n.ToString
            .TextAlign = ContentAlignment.TopCenter
            .Font = New Font("Arial Narrow", 8, FontStyle.Bold)
            .Size = New Size(90, 15)
        End With
        Me.lblTxnTypeDecl.Add(lbl)
        Me.Controls.Find("pnlTxnTypeDecl" & n.ToString, True)(0).Controls.Add(lbl)

        pnl = New Panel
        n = pnlInvDetails.Count
        With pnl
            .Location = New Point(130, 143)
            .Size = New Size(522, 48)
            .BorderStyle = BorderStyle.FixedSingle
            .Name = "pnlInvDetails" & n.ToString
        End With
        Me.pnlInvDetails.Add(pnl)
        Me.Controls.Find(currentPage, True)(0).Controls.Add(pnl)

        lbl = New Label
        n = lblINVNo_KEY.Count
        With lbl
            .Location = New Point(13, 3)
            If TXN_TYPE = "Invoice" Or TXNTYPE = "Sales Invoice" Then
                .Text = "Invoice No.:"
            ElseIf TXN_TYPE = "Sales Order" Then
                .Text = "SO No.        :"
            ElseIf TXN_TYPE = "Sales Return" Then
                .Text = "SR No.        :"
            End If
            .Name = "lblINVNo_KEY" & n.ToString
            .TextAlign = ContentAlignment.MiddleLeft
            .Font = New Font("Arial", 8, FontStyle.Bold)
            .Size = New Size(75, 20)
        End With
        Me.lblINVNo_KEY.Add(lbl)
        Me.Controls.Find("pnlInvDetails" & n.ToString, True)(0).Controls.Add(lbl)

        lbl = New Label
        n = lblINVNo_VALUE.Count
        With lbl
            .Location = New Point(90, 3)
            .Text = TXN_NO
            .Name = "lblINVNo_VALUE" & n.ToString
            .TextAlign = ContentAlignment.MiddleLeft
            .Font = New Font("Arial", 8, FontStyle.Regular)
            .Size = New Size(75, 20)
        End With
        Me.lblINVNo_VALUE.Add(lbl)
        Me.Controls.Find("pnlInvDetails" & n.ToString, True)(0).Controls.Add(lbl)

        lbl = New Label
        n = lblINVSONo_KEY.Count
        With lbl
            .Location = New Point(260, 3)
            .Text = "SO. No.        :"
            .Name = "lblINVSONo_KEY" & n.ToString
            .TextAlign = ContentAlignment.MiddleLeft
            .Font = New Font("Arial", 8, FontStyle.Bold)
            .Size = New Size(75, 20)
            If TXNTYPE = "Sales Invoice" Then
                .Visible = True
            Else
                .Visible = False
            End If
        End With
        Me.lblINVSONo_KEY.Add(lbl)
        Me.Controls.Find("pnlInvDetails" & n.ToString, True)(0).Controls.Add(lbl)

        lbl = New Label
        n = lblINVSONo_VALUE.Count
        With lbl
            .Location = New Point(340, 3)
            .Text = rptCustomerSONo
            .Name = "lblINVSONo_VALUE" & n.ToString
            .TextAlign = ContentAlignment.MiddleLeft
            .Font = New Font("Arial", 8, FontStyle.Regular)
            .Size = New Size(180, 20)
            If TXNTYPE = "Sales Invoice" Then
                .Visible = True
            Else
                .Visible = False
            End If
        End With
        Me.lblINVSONo_VALUE.Add(lbl)
        Me.Controls.Find("pnlInvDetails" & n.ToString, True)(0).Controls.Add(lbl)

        lbl = New Label
        n = lblINVDate_KEY.Count
        With lbl
            .Location = New Point(13, 25)
            .Text = "Date            :"
            .Name = "lblINVDate_KEY" & n.ToString
            .TextAlign = ContentAlignment.MiddleLeft
            .Font = New Font("Arial", 8, FontStyle.Bold)
            .Size = New Size(75, 20)
        End With
        Me.lblINVDate_KEY.Add(lbl)
        Me.Controls.Find("pnlInvDetails" & n.ToString, True)(0).Controls.Add(lbl)

        lbl = New Label
        n = lblINVDate_VALUE.Count
        With lbl
            .Location = New Point(60, 25)
            .Text = rptDate.Split(" ")(0)
            .Name = "lblINVDate_VALUE" & n.ToString
            .TextAlign = ContentAlignment.MiddleLeft
            .Font = New Font("Arial", 8, FontStyle.Regular)
            .Size = New Size(75, 20)
        End With
        Me.lblINVDate_VALUE.Add(lbl)
        Me.Controls.Find("pnlInvDetails" & n.ToString, True)(0).Controls.Add(lbl)

        lbl = New Label
        n = lblINVSMNo_KEY.Count
        With lbl
            .Location = New Point(260, 25)
            .Text = "Salesman   :"
            .Name = "lblINVSMNo_KEY" & n.ToString
            .TextAlign = ContentAlignment.MiddleLeft
            .Font = New Font("Arial", 8, FontStyle.Bold)
            .Size = New Size(75, 20)
        End With
        Me.lblINVSMNo_KEY.Add(lbl)
        Me.Controls.Find("pnlInvDetails" & n.ToString, True)(0).Controls.Add(lbl)

        lbl = New Label
        n = lblINVSMNo_VALUE.Count
        With lbl
            .Location = New Point(340, 25)
            .Text = rptSalesmanName
            .Name = "lblINVSMNo_VALUE" & n.ToString
            .TextAlign = ContentAlignment.MiddleLeft
            .Font = New Font("Arial", 8, FontStyle.Regular)
            .Size = New Size(180, 20)
        End With
        Me.lblINVSMNo_VALUE.Add(lbl)
        Me.Controls.Find("pnlInvDetails" & n.ToString, True)(0).Controls.Add(lbl)

        pnl = New Panel
        n = pnlCustDetails.Count
        With pnl
            .Location = New Point(130, 190)
            .Size = New Size(522, 48)
            .BorderStyle = BorderStyle.FixedSingle
            .Name = "pnlCustDetails" & n.ToString
        End With
        Me.pnlCustDetails.Add(pnl)
        Me.Controls.Find(currentPage, True)(0).Controls.Add(pnl)

        lbl = New Label
        n = lblINVCustName_KEY.Count
        With lbl
            .Location = New Point(13, 3)
            .Text = "Customer :"
            .Name = "lblINVCustName_KEY" & n.ToString
            .TextAlign = ContentAlignment.MiddleLeft
            .Font = New Font("Arial", 8, FontStyle.Bold)
            .Size = New Size(75, 20)
        End With
        Me.lblINVCustName_KEY.Add(lbl)
        Me.Controls.Find("pnlCustDetails" & n.ToString, True)(0).Controls.Add(lbl)

        lbl = New Label
        n = lblINVCustName_VALUE.Count
        With lbl
            .Location = New Point(90, 3)
            .Text = rptCustomerName
            .Name = "lblINVCustName_VALUE" & n.ToString
            .TextAlign = ContentAlignment.MiddleLeft
            .Font = New Font("Arial", 8, FontStyle.Regular)
            .Size = New Size(425, 20)
        End With
        Me.lblINVCustName_VALUE.Add(lbl)
        Me.Controls.Find("pnlCustDetails" & n.ToString, True)(0).Controls.Add(lbl)

        lbl = New Label
        n = lblINVCustPhone_KEY.Count
        With lbl
            .Location = New Point(13, 25)
            .Text = "Phone        :"
            .Name = "lblINVCustPhone_KEY" & n.ToString
            .TextAlign = ContentAlignment.MiddleLeft
            .Font = New Font("Arial", 8, FontStyle.Bold)
            .Size = New Size(75, 20)
        End With
        Me.lblINVCustPhone_KEY.Add(lbl)
        Me.Controls.Find("pnlCustDetails" & n.ToString, True)(0).Controls.Add(lbl)

        lbl = New Label
        n = lblINVCustPhone_VALUE.Count
        With lbl
            .Location = New Point(90, 25)
            .Text = rptCustomerPhone
            .Name = "lblINVCustPhone_VALUE" & n.ToString
            .TextAlign = ContentAlignment.MiddleLeft
            .Font = New Font("Arial", 8, FontStyle.Regular)
            .Size = New Size(160, 20)
        End With
        Me.lblINVCustPhone_VALUE.Add(lbl)
        Me.Controls.Find("pnlCustDetails" & n.ToString, True)(0).Controls.Add(lbl)

        lbl = New Label
        n = lblINVCustEmail_KEY.Count
        With lbl
            .Location = New Point(260, 25)
            .Text = "Email           :"
            .Name = "lblINVCustEmail_KEY" & n.ToString
            .TextAlign = ContentAlignment.MiddleLeft
            .Font = New Font("Arial", 8, FontStyle.Bold)
            .Size = New Size(75, 20)
        End With
        Me.lblINVCustEmail_KEY.Add(lbl)
        Me.Controls.Find("pnlCustDetails" & n.ToString, True)(0).Controls.Add(lbl)

        lbl = New Label
        n = lblINVCustEmail_VALUE.Count
        With lbl
            .Location = New Point(340, 25)
            .Text = rptCustomerEmail
            .Name = "lblINVCustEmail_VALUE" & n.ToString
            .TextAlign = ContentAlignment.MiddleLeft
            .Font = New Font("Arial", 8, FontStyle.Regular)
            .Size = New Size(180, 20)
        End With
        Me.lblINVCustEmail_VALUE.Add(lbl)
        Me.Controls.Find("pnlCustDetails" & n.ToString, True)(0).Controls.Add(lbl)

        pnl = New Panel
        n = pnlItemHeader.Count
        With pnl
            .Location = New Point(130, 240)
            .Size = New Size(522, 30)
            .BorderStyle = BorderStyle.FixedSingle
            .Name = "pnlItemHeader" & n.ToString
        End With
        Me.pnlItemHeader.Add(pnl)
        Me.Controls.Find(currentPage, True)(0).Controls.Add(pnl)

        lbl = New Label
        n = lblRptSNOHeader.Count
        With lbl
            .BackColor = Color.MintCream
            .Location = New Point(0, 0)
            .Text = "SNo"
            .Name = "lblRptSNOHeader" & n.ToString
            .TextAlign = ContentAlignment.MiddleCenter
            .Font = New Font("Arial Narrow", 8, FontStyle.Bold)
            .Size = New Size(32, 29)
            .BorderStyle = BorderStyle.FixedSingle
        End With
        Me.lblRptSNOHeader.Add(lbl)
        Me.Controls.Find("pnlItemHeader" & n.ToString, True)(0).Controls.Add(lbl)

        lbl = New Label
        n = lblRptItemCodeHeader.Count
        With lbl
            .BackColor = Color.MintCream
            .Location = New Point(32, 0)
            .Text = "Item"
            .Name = "lblRptItemCodeHeader" & n.ToString
            .TextAlign = ContentAlignment.MiddleCenter
            .Font = New Font("Arial Narrow", 8, FontStyle.Bold)
            .Size = New Size(248, 29)
            .BorderStyle = BorderStyle.FixedSingle
        End With
        Me.lblRptItemCodeHeader.Add(lbl)
        Me.Controls.Find("pnlItemHeader" & n.ToString, True)(0).Controls.Add(lbl)

        lbl = New Label
        n = lblRptUOMHeader.Count
        With lbl
            .BackColor = Color.MintCream
            .Location = New Point(280, 0)
            .Text = "UOM"
            .Name = "lblRptUOMHeader" & n.ToString
            .TextAlign = ContentAlignment.MiddleCenter
            .Font = New Font("Arial Narrow", 8, FontStyle.Bold)
            .Size = New Size(45, 29)
            .BorderStyle = BorderStyle.FixedSingle
        End With
        Me.lblRptUOMHeader.Add(lbl)
        Me.Controls.Find("pnlItemHeader" & n.ToString, True)(0).Controls.Add(lbl)

        lbl = New Label
        n = lblRptRateHeader.Count
        With lbl
            .BackColor = Color.MintCream
            .Location = New Point(325, 0)
            .Text = "Rate"
            .Name = "lblRptRateHeader" & n.ToString
            .TextAlign = ContentAlignment.MiddleCenter
            .Font = New Font("Arial Narrow", 8, FontStyle.Bold)
            .Size = New Size(60, 29)
            .BorderStyle = BorderStyle.FixedSingle
        End With
        Me.lblRptRateHeader.Add(lbl)
        Me.Controls.Find("pnlItemHeader" & n.ToString, True)(0).Controls.Add(lbl)

        lbl = New Label
        n = lblRptQtyHeader.Count
        With lbl
            .BackColor = Color.MintCream
            .Location = New Point(385, 0)
            .Text = "Qty"
            .Name = "lblRptQtyHeader" & n.ToString
            .TextAlign = ContentAlignment.MiddleCenter
            .Font = New Font("Arial Narrow", 8, FontStyle.Bold)
            .Size = New Size(40, 29)
            .BorderStyle = BorderStyle.FixedSingle

        End With
        Me.lblRptQtyHeader.Add(lbl)
        Me.Controls.Find("pnlItemHeader" & n.ToString, True)(0).Controls.Add(lbl)

        lbl = New Label
        n = lblRptAmtHeader.Count
        With lbl
            .BackColor = Color.MintCream
            .Location = New Point(430, 0)
            .Text = "Amount"
            .Name = "lblRptAmtHeader" & n.ToString
            .TextAlign = ContentAlignment.MiddleCenter
            .Font = New Font("Arial Narrow", 8, FontStyle.Bold)
            .Size = New Size(90, 29)
            .BorderStyle = BorderStyle.FixedSingle
        End With
        Me.lblRptAmtHeader.Add(lbl)
        Me.Controls.Find("pnlItemHeader" & n.ToString, True)(0).Controls.Add(lbl)

        pnl = New Panel
        n = pnlItemDetails.Count
        With pnl
            .Location = New Point(130, 270)
            .Size = New Size(522, 350)
            .BorderStyle = BorderStyle.FixedSingle
            .Name = "pnlItemDetails" & n.ToString
            currentItemPanel = "pnlItemDetails" & n.ToString
        End With
        Me.pnlItemDetails.Add(pnl)
        Me.Controls.Find(currentPage, True)(0).Controls.Add(pnl)

        pnl = New Panel
        n = pnlTotalDetails.Count
        With pnl
            .Location = New Point(130, 619)
            .Size = New Size(522, 68)
            .BorderStyle = BorderStyle.FixedSingle
            .Name = "pnlTotalDetails" & n.ToString
        End With
        Me.pnlTotalDetails.Add(pnl)
        Me.Controls.Find(currentPage, True)(0).Controls.Add(pnl)

        lbl = New Label
        n = lblINVAdvPaid_KEY.Count
        With lbl
            .Location = New Point(21, 21)
            .Text = "Advance Paid :"
            .Name = "lblINVAdvPaid_KEY" & n.ToString
            .TextAlign = ContentAlignment.MiddleLeft
            .Font = New Font("Arial Narrow", 8, FontStyle.Bold)
            .Size = New Size(75, 16)
            .Visible = False
        End With
        Me.lblINVAdvPaid_KEY.Add(lbl)
        Me.Controls.Find("pnlTotalDetails" & n.ToString, True)(0).Controls.Add(lbl)

        lbl = New Label
        n = lblINVAdvPaid_VALUE.Count
        With lbl
            .Location = New Point(100, 21)
            .Text = "0"
            .Name = "lblINVAdvPaid_VALUE" & n.ToString
            .TextAlign = ContentAlignment.MiddleRight
            .Font = New Font("Arial Narrow", 8, FontStyle.Regular)
            .Size = New Size(80, 16)
            .Visible = False
        End With
        Me.lblINVAdvPaid_VALUE.Add(lbl)
        Me.Controls.Find("pnlTotalDetails" & n.ToString, True)(0).Controls.Add(lbl)

        lbl = New Label
        n = lblINVBalance_KEY.Count
        With lbl
            .Location = New Point(21, 41)
            If TXN_TYPE = "Sales Invoice" Then
                .Text = "Balance Paid  :"
            Else
                .Text = "Balance          :"
            End If

            .Name = "lblINVBalance_KEY" & n.ToString
            .TextAlign = ContentAlignment.MiddleLeft
            .Font = New Font("Arial Narrow", 8, FontStyle.Bold)
            .Size = New Size(75, 16)
            .Visible = False
        End With
        Me.lblINVBalance_KEY.Add(lbl)
        Me.Controls.Find("pnlTotalDetails" & n.ToString, True)(0).Controls.Add(lbl)

        lbl = New Label
        n = lblINVBalance_VALUE.Count
        With lbl
            .Location = New Point(100, 41)
            .Text = "0"
            .Name = "lblINVBalance_VALUE" & n.ToString
            .TextAlign = ContentAlignment.MiddleRight
            .Font = New Font("Arial Narrow", 8, FontStyle.Regular)
            .Size = New Size(80, 16)
            .Visible = False
        End With
        Me.lblINVBalance_VALUE.Add(lbl)
        Me.Controls.Find("pnlTotalDetails" & n.ToString, True)(0).Controls.Add(lbl)

        lbl = New Label
        n = lblINVSubTotal_KEY.Count
        With lbl
            .Location = New Point(329, 5)
            .Text = "Sub Total :"
            .Name = "lblINVSubTotal_KEY" & n.ToString
            .TextAlign = ContentAlignment.MiddleLeft
            .Font = New Font("Arial Narrow", 8, FontStyle.Bold)
            .Size = New Size(56, 16)
        End With
        Me.lblINVSubTotal_KEY.Add(lbl)
        Me.Controls.Find("pnlTotalDetails" & n.ToString, True)(0).Controls.Add(lbl)

        lbl = New Label
        n = lblINVSubTotal_VALUE.Count
        With lbl
            .Location = New Point(419, 5)
            .Text = ""
            .Name = "lblINVSubTotal_VALUE" & n.ToString
            .TextAlign = ContentAlignment.MiddleRight
            .Font = New Font("Arial Narrow", 8, FontStyle.Regular)
            .Size = New Size(96, 16)

        End With
        Me.lblINVSubTotal_VALUE.Add(lbl)
        Me.Controls.Find("pnlTotalDetails" & n.ToString, True)(0).Controls.Add(lbl)

        lbl = New Label
        n = lblINVDisTotal_KEY.Count
        With lbl
            .Location = New Point(329, 24)
            .Text = "Discount  :"
            .Name = "lblINVDisTotal_KEY" & n.ToString
            .TextAlign = ContentAlignment.MiddleLeft
            .Font = New Font("Arial Narrow", 8, FontStyle.Bold)
            .Size = New Size(60, 16)
        End With
        Me.lblINVDisTotal_KEY.Add(lbl)
        Me.Controls.Find("pnlTotalDetails" & n.ToString, True)(0).Controls.Add(lbl)

        lbl = New Label
        n = lblINVDisTotal_VALUE.Count
        With lbl
            .Location = New Point(419, 24)
            .Text = ""
            .Name = "lblINVDisTotal_VALUE" & n.ToString
            .TextAlign = ContentAlignment.MiddleRight
            .Font = New Font("Arial Narrow", 8, FontStyle.Regular)
            .Size = New Size(96, 16)

        End With
        Me.lblINVDisTotal_VALUE.Add(lbl)
        Me.Controls.Find("pnlTotalDetails" & n.ToString, True)(0).Controls.Add(lbl)

        lbl = New Label
        n = lblINVExpTotal_KEY.Count
        With lbl
            .Location = New Point(329, 42)
            .Text = "Expense   :"
            .Name = "lblINVExpTotal_KEY" & n.ToString
            .TextAlign = ContentAlignment.MiddleLeft
            .Font = New Font("Arial Narrow", 8, FontStyle.Bold)
            .Size = New Size(60, 16)
        End With
        Me.lblINVExpTotal_KEY.Add(lbl)
        Me.Controls.Find("pnlTotalDetails" & n.ToString, True)(0).Controls.Add(lbl)

        lbl = New Label
        n = lblINVExpTotal_VALUE.Count
        With lbl
            .Location = New Point(419, 42)
            .Text = ""
            .Name = "lblINVExpTotal_VALUE" & n.ToString
            .TextAlign = ContentAlignment.MiddleRight
            .Font = New Font("Arial Narrow", 8, FontStyle.Regular)
            .Size = New Size(96, 16)

        End With
        Me.lblINVExpTotal_VALUE.Add(lbl)
        Me.Controls.Find("pnlTotalDetails" & n.ToString, True)(0).Controls.Add(lbl)

        pnl = New Panel
        n = pnlGrandTotalDetails.Count
        With pnl
            .Location = New Point(130, 684)
            .Size = New Size(522, 29)
            .BorderStyle = BorderStyle.FixedSingle
            .Name = "pnlGrandTotalDetails" & n.ToString
        End With
        Me.pnlGrandTotalDetails.Add(pnl)
        Me.Controls.Find(currentPage, True)(0).Controls.Add(pnl)

        lbl = New Label
        n = lblRptEEO.Count
        With lbl
            .Location = New Point(3, 6)
            .Text = "E && OE."
            .Name = "lblRptEEO" & n.ToString
            .TextAlign = ContentAlignment.MiddleLeft
            .Font = New Font("Arial Narrow", 9, FontStyle.Bold)
            .Size = New Size(45, 16)
        End With
        Me.lblRptEEO.Add(lbl)
        Me.Controls.Find("pnlGrandTotalDetails" & n.ToString, True)(0).Controls.Add(lbl)


        lbl = New Label
        n = lblRptGrandTotal_KEY.Count
        With lbl
            .Location = New Point(329, 6)
            .Text = "Total       : "
            .Name = "lblRptGrandTotal_KEY" & n.ToString
            .TextAlign = ContentAlignment.MiddleLeft
            .Font = New Font("Arial", 9, FontStyle.Bold)
            .Size = New Size(60, 16)
        End With
        Me.lblRptGrandTotal_KEY.Add(lbl)
        Me.Controls.Find("pnlGrandTotalDetails" & n.ToString, True)(0).Controls.Add(lbl)

        lbl = New Label
        n = lblRptGrandTotal_VALUE.Count
        With lbl
            .Location = New Point(388, 7)
            .Text = ""
            .Name = "lblRptGrandTotal_VALUE" & n.ToString
            .TextAlign = ContentAlignment.MiddleRight
            .Font = New Font("Arial", 9, FontStyle.Bold)
            .Size = New Size(127, 16)
        End With
        Me.lblRptGrandTotal_VALUE.Add(lbl)
        Me.Controls.Find("pnlGrandTotalDetails" & n.ToString, True)(0).Controls.Add(lbl)


        pnl = New Panel
        n = pnlDeclaration.Count
        With pnl
            .Location = New Point(130, 712)
            .Size = New Size(311, 50)
            .BorderStyle = BorderStyle.FixedSingle
            .Name = "pnlDeclaration" & n.ToString
        End With
        Me.pnlDeclaration.Add(pnl)
        Me.Controls.Find(currentPage, True)(0).Controls.Add(pnl)

        lbl = New Label
        n = lblDeclarationHeader.Count
        With lbl
            .Location = New Point(3, 4)
            .Text = "Declaration"
            .Name = "lblDeclarationHeader" & n.ToString
            .TextAlign = ContentAlignment.MiddleLeft
            .Font = New Font("Arial Narrow", 8, FontStyle.Bold)
            .Size = New Size(60, 16)
        End With
        Me.lblDeclarationHeader.Add(lbl)
        Me.Controls.Find("pnlDeclaration" & n.ToString, True)(0).Controls.Add(lbl)

        lbl = New Label
        n = lblDeclaration.Count
        With lbl
            .Location = New Point(44, 30)
            .Text = "The above said information is true and correct."
            .Name = "lblDeclaration" & n.ToString
            .TextAlign = ContentAlignment.MiddleLeft
            .Font = New Font("Arial Narrow", 8, FontStyle.Regular)
            .Size = New Size(232, 14)
        End With
        Me.lblDeclaration.Add(lbl)
        Me.Controls.Find("pnlDeclaration" & n.ToString, True)(0).Controls.Add(lbl)


        pnl = New Panel
        n = pnlAuthSign.Count
        With pnl
            .Location = New Point(440, 712)
            .Size = New Size(212, 50)
            .BorderStyle = BorderStyle.FixedSingle
            .Name = "pnlAuthSign" & n.ToString
        End With
        Me.pnlAuthSign.Add(pnl)
        Me.Controls.Find(currentPage, True)(0).Controls.Add(pnl)

        lbl = New Label
        n = lblAuthSignature.Count
        With lbl
            .Location = New Point(5, 4)
            .Text = "Authorized Signature"
            .Name = "lblAuthSignature" & n.ToString
            .TextAlign = ContentAlignment.MiddleLeft
            .Font = New Font("Arial Narrow", 8, FontStyle.Bold)
            .Size = New Size(107, 16)
        End With
        Me.lblAuthSignature.Add(lbl)
        Me.Controls.Find("pnlAuthSign" & n.ToString, True)(0).Controls.Add(lbl)

        pnl = New Panel
        n = pnlFooter.Count
        With pnl
            .Location = New Point(120, 764)
            .Size = New Size(522, 50)
            .BorderStyle = BorderStyle.None
            .Name = "pnlFooter" & n.ToString
        End With
        Me.pnlFooter.Add(pnl)
        Me.Controls.Find(currentPage, True)(0).Controls.Add(pnl)

        lbl = New Label
        n = lblFooterLine1.Count
        With lbl
            .Location = New Point(5, 1)
            .Text = "THANK YOU VISITING ALJABER.  PLEASE VISIT AGAIN"
            .Name = "lblFooterLine1" & n.ToString
            .TextAlign = ContentAlignment.MiddleCenter
            .Font = New Font("Arial Narrow", 8, FontStyle.Bold)
            .Size = New Size(512, 14)
            .BorderStyle = BorderStyle.None
        End With
        Me.lblFooterLine1.Add(lbl)
        Me.Controls.Find("pnlFooter" & n.ToString, True)(0).Controls.Add(lbl)

        lbl = New Label
        n = lblFooterLine2.Count
        With lbl
            .Location = New Point(5, 16)
            .Text = "WARNING: Chocking Hazard; small parts, not suitable for children under(3) years old"
            .Name = "lblFooterLine2" & n.ToString
            .TextAlign = ContentAlignment.MiddleCenter
            .Font = New Font("Arial Narrow", 9, FontStyle.Regular)
            .Size = New Size(512, 14)
            .BorderStyle = BorderStyle.None
        End With
        Me.lblFooterLine2.Add(lbl)
        Me.Controls.Find("pnlFooter" & n.ToString, True)(0).Controls.Add(lbl)

    End Sub

    Private Sub btnExportPDF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExportPDF.Click
        'Try
        '    Dim doc As New PdfDocument()

        '    Dim bmplist As New List(Of Bitmap)
        '    Dim xgrlist As New List(Of XGraphics)
        '    For i = 0 To pnlPages.Count - 1
        '        pnlPages(i).BorderStyle = BorderStyle.None
        '        Dim bmpimg = New Bitmap(Me.Controls.Find(pnlPages(i).Name, True)(0).Width, Me.Controls.Find(pnlPages(i).Name, True)(0).Height)
        '        Me.Controls.Find(pnlPages(i).Name, True)(0).DrawToBitmap(bmpimg, Me.Controls.Find(pnlPages(i).Name, True)(0).ClientRectangle)
        '        doc.Pages.Add(New PdfPage())
        '        'doc.Pages(i).Size = PdfSharp.PageSize.A5
        '        Dim xgrGraph As XGraphics = XGraphics.FromPdfPage(doc.Pages(i))
        '        'bmpimg.RotateFlip(RotateFlipType.RotateNoneFlipXY)
        '        Dim imgX As XImage = XImage.FromGdiPlusImage(bmpimg)
        '        xgrGraph.DrawImage(imgX, 0, 0)
        '        pnlPages(i).BorderStyle = BorderStyle.FixedSingle
        '    Next

        '    SaveFileDialog1.Filter = "PDF Files (*.pdf*)|*.pdf"
        '    If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
        '        doc.Save(SaveFileDialog1.FileName)
        '        doc.Close()
        '        MsgBox("File has been saved successfully at '" + SaveFileDialog1.FileName + "'")
        '    End If
        'Catch ex As Exception
        '    errLog.WriteToErrorLog("Error", ex.ToString, ex.StackTrace)
        'End Try

        'Dim bmp = New Bitmap(pnl_EDRDetails.Width, pnl_EDRDetails.Height)

        'pnl_EDRDetails.DrawToBitmap(bmp, pnl_EDRDetails.ClientRectangle)

        ''bmp.Save("ImageName.png", System.Drawing.Imaging.ImageFormat.Png)

        'Dim doc As New PdfDocument()

        'doc.Pages.Add(New PdfPage())

        'Dim xgr As XGraphics = XGraphics.FromPdfPage(doc.Pages(0))

        'Dim img As XImage = XImage.FromGdiPlusImage(bmp)

        'xgr.DrawImage(img, 0, 0)

        'SaveFileDialog1.Filter = "PDF Files (*.pdf*)|*.pdf"

        'If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

        '    doc.Save(SaveFileDialog1.FileName)

        '    doc.Close()

        '    MsgBox("File has been saved successfully at '" + SaveFileDialog1.FileName + "'")

        'End If

        '//////////////////////////////////////////////////////////////////////////////////////////////

        Dim bmp = New Bitmap(pnlRPTPANEL.Width, pnlRPTPANEL.Height)

        lblRptItemCodeHead.BringToFront()
        lblRptQtyHead.BringToFront()
        lblRptAmtHead.BringToFront()

        pnlRPTPANEL.DrawToBitmap(bmp, pnlRPTPANEL.ClientRectangle)

        'bmp.Save("ImageName.png", System.Drawing.Imaging.ImageFormat.Png)

        Dim doc As New PdfDocument()

        doc.Pages.Add(New PdfPage())
        doc.Pages(0).Height = pnlRPTPANEL.Height - 125
        doc.Pages(0).Width = pnlRPTPANEL.Width - 80


        Dim xgr As XGraphics = XGraphics.FromPdfPage(doc.Pages(0))

        Dim img As XImage = XImage.FromGdiPlusImage(bmp)

        xgr.DrawImage(img, 0, 0)

        SaveFileDialog1.Filter = "PDF Files (*.pdf*)|*.pdf"

        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            doc.Save(SaveFileDialog1.FileName)

            doc.Close()

            MsgBox("File has been saved successfully at '" + SaveFileDialog1.FileName + "'")

        End If

    End Sub

    Private Sub btn_Print_Report_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Print_Report.Click
        'Try
        '    If Not pnlPages.Count > 0 Then
        '        Exit Sub
        '    End If
        '    PrintDialog1.Document = PrintDocument1
        '    PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        '    PrintDialog1.AllowSomePages = True
        '    PrintDialog1.AllowCurrentPage = True
        '    PrintDialog1.AllowSelection = True

        '    If PrintDialog1.ShowDialog = DialogResult.OK Then
        '        PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
        '        'totPages = pnlReportPages.Count
        '        'MsgBox(totPages)
        '        For i = 0 To pnlPages.Count - 1
        '            pnlPages(i).BorderStyle = BorderStyle.None
        '            Dim bmpimg = New Bitmap(Me.Controls.Find(pnlPages(i).Name, True)(0).Width, Me.Controls.Find(pnlPages(i).Name, True)(0).Height)
        '            Me.Controls.Find(pnlPages(i).Name, True)(0).DrawToBitmap(bmpimg, Me.Controls.Find(pnlPages(i).Name, True)(0).ClientRectangle)
        '            bitmaps.Add(bmpimg)
        '            pnlPages(i).BorderStyle = BorderStyle.FixedSingle
        '        Next
        '        'PrintDocument1.DefaultPageSettings.PaperSize = New PaperSize("Custom", 584, 827)
        '        PrintDocument1.Print()
        '        'Next
        '    End If

        'Catch ex As Exception
        '    errLog.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")
        'End Try

        '///////////////////////////////////////////////////////////////////////////////////////////////

        Try
            ' ''PrintDialog1.Document = PrintDocument1
            ' ''PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
            ' ''PrintDialog1.AllowSomePages = True

            ' ''If PrintDialog1.ShowDialog = DialogResult.OK Then
            ' ''    PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            ''PrintDocument1.Print()

            ' ''End If

            If printds.Tables("Table").Rows.Count < 28 Then
                PrintDocument1.Print()
            Else
                If TXN_TYPE = "Invoice" Then
                    Transactions.PrintDINVReport(TXNNO)
                Else
                    Transactions.PrintSRReport(TXNNO)
                End If
                'Transactions.TransactionSlipCallPrint()
            End If
            btnCloseReport_Click(sender, e)
        Catch ex As Exception
            errLog.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")
        End Try

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        leftMargin = Convert.ToInt32(e.MarginBounds.Left)
        rightMargin = Convert.ToInt32(e.MarginBounds.Right)
        topMargin = Convert.ToInt32(e.MarginBounds.Top - 100)
        bottomMargin = Convert.ToInt32(e.MarginBounds.Bottom)
        InvoiceWidth = Convert.ToInt32(e.MarginBounds.Width)
        InvoiceHeight = Convert.ToInt32(e.MarginBounds.Height)

        Transactions.Print(PrintDocument1.PrinterSettings.PrinterName, Transactions.GetDocumentImagePrint())

        Dim arabicval As String = ""
        CurrentY = topMargin
        CurrentX = leftMargin
        Dim ImageHeight As Integer = 0

        InvTitle = rptLocationName

        Dim InvTitleArabic As String
        InvTitleArabic = printds.Tables("Table").Rows.Item(0).Item(24).ToString.Trim

        InvSubTitle1 = rptLocationAddr
        InvSubTitle2 = "هاتف\Phone: " & rptLocationPhone
        InvSubTitle3 = "بريد الكتروني\Email: " & rptLocationEmail
        InvSubTitle4 = "INVOICE"

        InvTitleHeight = Convert.ToInt32(InvTitleFont.GetHeight(e.Graphics))
        Dim InvTitleArabicHeight As Integer
        InvTitleArabicHeight = Convert.ToInt32(InvTitleFont.GetHeight(e.Graphics))
        InvSubTitleHeight = Convert.ToInt32(InvSubTitleFont.GetHeight(e.Graphics))
        ' Get Titles Length:
        Dim lenInvTitle As Integer = Convert.ToInt32(e.Graphics.MeasureString(InvTitle, InvTitleFont).Width)
        Dim lenInvTitleArabic As Integer = Convert.ToInt32(e.Graphics.MeasureString(InvTitleArabic, InvTitleFont).Width)

        Dim lenInvSubTitle1 As Integer = Convert.ToInt32(e.Graphics.MeasureString(InvSubTitle1, InvSubTitleFont).Width)
        Dim lenInvSubTitle2 As Integer = Convert.ToInt32(e.Graphics.MeasureString(InvSubTitle2, InvSubTitleFont).Width)
        Dim lenInvSubTitle3 As Integer = Convert.ToInt32(e.Graphics.MeasureString(InvSubTitle3, InvSubTitleFont).Width)
        Dim lenInvSubTitle4 As Integer = Convert.ToInt32(e.Graphics.MeasureString(InvSubTitle4, InvSubTitleFont).Width)
        ' Set Titles Left:
        Dim xInvTitle As Integer = CurrentX + (InvoiceWidth - lenInvTitle) / 2
        Dim xInvTitleArabic As Integer = CurrentX + (InvoiceWidth - lenInvTitle) / 2

        Dim xInvSubTitle1 As Integer = CurrentX + (InvoiceWidth - lenInvSubTitle1) / 2
        Dim xInvSubTitle2 As Integer = CurrentX + (InvoiceWidth - lenInvSubTitle2) / 2
        Dim xInvSubTitle3 As Integer = CurrentX + (InvoiceWidth - lenInvSubTitle3) / 2
        Dim xInvSubTitle4 As Integer = CurrentX + (InvoiceWidth - lenInvSubTitle4) / 2



        Dim FieldValue As String = ""
        InvoiceFontHeight = Convert.ToInt32(InvoiceFont.GetHeight(e.Graphics))
        ItemDetailsFontHeight = Convert.ToInt32(ItemDetailsFont.GetHeight(e.Graphics))


        Dim xProductID As Integer = leftMargin - 100
        ' ''CurrentY = CurrentY + 3 '+ InvoiceFontHeight
        ' ''e.Graphics.DrawString("Product ID", ItemDetailsFont, BlueBrush, xProductID, CurrentY)

        Dim xProductName As Integer = xProductID + Convert.ToInt32(e.Graphics.MeasureString("Product ID", ItemDetailsFont).Width) + 15
        ' ''e.Graphics.DrawString("Product Name", ItemDetailsFont, BlueBrush, xProductName, CurrentY)

        Dim xQuantity As Integer = xProductName + Convert.ToInt32(e.Graphics.MeasureString("Product Name", ItemDetailsFont).Width) + 44
        ' ''e.Graphics.DrawString("Qty", ItemDetailsFont, BlueBrush, xQuantity, CurrentY)

        Dim AmountPosition As Integer
        AmountPosition = xQuantity + Convert.ToInt32(e.Graphics.MeasureString("Qty", ItemDetailsFont).Width) + 32
        ' ''e.Graphics.DrawString("Price", ItemDetailsFont, BlueBrush, AmountPosition, CurrentY)

        ' ''CurrentY = CurrentY + InvoiceFontHeight + 8
        ' ''e.Graphics.DrawLine(New Pen(Brushes.Black, 2), CurrentX, CurrentY, rightMargin + 100, CurrentY)

        CurrentY = CurrentY + ItemDetailsFontHeight
        Dim count As Integer = printds.Tables("Table").Rows.Count
        Dim i As Integer = 0
        Dim row As System.Data.DataRow
        totalDiscountamt = 0
        totalExpenseamt = 0
        subtotalamt = 0
        Dim totTax As Double = 0

        While count > 0
            row = printds.Tables("Table").Rows.Item(i)
            FieldValue = row.Item(12)
            If (FieldValue.Length > 10) Then
                FieldValue = FieldValue.Remove(10, FieldValue.Length - 10)
            End If
            e.Graphics.DrawString(FieldValue, ItemDetailsFont, BlackBrush, xProductID, CurrentY)
            FieldValue = row.Item(13)
            If (FieldValue.Length > 15) Then
                FieldValue = FieldValue.Remove(15, FieldValue.Length - 15)
            End If
            e.Graphics.DrawString(FieldValue, ItemDetailsFont, BlackBrush, xProductName, CurrentY)

            e.Graphics.DrawString(row.Item(16), ItemDetailsFont, BlackBrush, xQuantity + 5, CurrentY)
            FieldValue = String.Format("{0:0.00}", Convert.ToDecimal(row.Item(17)))
            Dim xAmount As Integer = AmountPosition + Convert.ToInt32(e.Graphics.MeasureString("Price", ItemDetailsFont).Width)
            xAmount = xAmount - Convert.ToInt32(e.Graphics.MeasureString(FieldValue, ItemDetailsFont).Width)
            e.Graphics.DrawString(FieldValue, ItemDetailsFont, BlackBrush, xAmount, CurrentY)

            'e.Graphics.DrawString(row.Item(17), InvoiceFont, BlackBrush, AmountPosition + 5, CurrentY)
            arabicval = row.Item(23).ToString
            If row.Item(23).ToString.Equals("") Then
                arabicval = "هدية البند"
            End If
            CurrentY = CurrentY + InvoiceFontHeight - 3
            e.Graphics.DrawString(arabicval, InvItemArabicFont, BlackBrush, xProductName, CurrentY)

            totalDiscountamt = totalDiscountamt + Convert.ToDouble(row.Item(18).ToString)
            totalExpenseamt = totalExpenseamt + Convert.ToDouble(row.Item(19).ToString)
            subtotalamt = subtotalamt + Convert.ToDouble(row.Item(17).ToString)
            totTax = totTax + Convert.ToDouble(row.Item(26).ToString)

            CurrentY = CurrentY + InvoiceFontHeight + 3
            count = count - 1
            i = i + 1
        End While

        CurrentY = CurrentY + InvoiceFontHeight + 3
        e.Graphics.DrawLine(New Pen(Brushes.Black, 2), CurrentX - 100, CurrentY, rightMargin + 105, CurrentY)


        Dim thankyou1 As String
        If Setup_Values.ContainsKey("LINE_DISP_TL_1") Then
            thankyou1 = Setup_Values("LINE_DISP_TL_1")
        Else
            thankyou1 = ""
        End If
        Dim thankyouArabic1 As String
        If Setup_Values.ContainsKey("LINE_DISP_TLA_1") Then
            thankyouArabic1 = Setup_Values("LINE_DISP_TLA_1")
        Else
            thankyouArabic1 = ""
        End If
        Dim thankyou2 As String
        If Setup_Values.ContainsKey("LINE_DISP_TL_2") Then
            thankyou2 = Setup_Values("LINE_DISP_TL_2")
        Else
            thankyou2 = ""
        End If
        Dim thankyouArabic2 As String
        If Setup_Values.ContainsKey("LINE_DISP_TLA_2") Then
            thankyouArabic2 = Setup_Values("LINE_DISP_TLA_2")
        Else
            thankyouArabic2 = ""
        End If
        Dim welcome1 As String
        If Setup_Values.ContainsKey("LINE_DISP_WL_1") Then
            welcome1 = Setup_Values("LINE_DISP_WL_1")
        Else
            welcome1 = ""
        End If
        Dim welcomeArabic1 As String
        If Setup_Values.ContainsKey("LINE_DISP_WLA_1") Then
            welcomeArabic1 = Setup_Values("LINE_DISP_WLA_1")
        Else
            welcomeArabic1 = ""
        End If
        Dim welcome2 As String
        If Setup_Values.ContainsKey("LINE_DISP_WL_2") Then
            welcome2 = Setup_Values("LINE_DISP_WL_2")
        Else
            welcome2 = ""
        End If
        Dim welcomeArabic2 As String
        If Setup_Values.ContainsKey("LINE_DISP_WLA_2") Then
            welcomeArabic2 = Setup_Values("LINE_DISP_WLA_2")
        Else
            welcomeArabic2 = ""
        End If


        Dim discAmount As Integer = AmountPosition + Convert.ToInt32(e.Graphics.MeasureString("Price", InvoiceFont).Width)
        discAmount = discAmount - Convert.ToInt32(e.Graphics.MeasureString(FieldValue, InvoiceFont).Width)


        CurrentX = leftMargin - 100
        CurrentY = CurrentY + InvoiceFontHeight + 3
        FieldValue = "المبلغ الإجمالي\Total Amount:"
        e.Graphics.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY)
        '()
        FieldValue = String.Format("{0:0.00}", Convert.ToDecimal(subtotalamt))
        discAmount = AmountPosition + Convert.ToInt32(e.Graphics.MeasureString("Price", InvoiceFont).Width)
        discAmount = discAmount - Convert.ToInt32(e.Graphics.MeasureString(FieldValue, InvoiceFont).Width)
        e.Graphics.DrawString(FieldValue, InvoiceFont, BlackBrush, discAmount, CurrentY)

        If Not totheaddiscamtval = 0 Then
            CurrentX = leftMargin - 100
            CurrentY = CurrentY + InvoiceFontHeight + 3
            FieldValue = "إجمالي الخصم\Total Discount:"
            e.Graphics.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY)

            FieldValue = String.Format("{0:0.00}", Convert.ToDecimal(rptTotalDiscount))
            e.Graphics.DrawString(FieldValue, InvoiceFont, BlackBrush, discAmount, CurrentY)
        End If

        CurrentX = leftMargin - 100
        CurrentY = CurrentY + InvoiceFontHeight + 3
        FieldValue = "مجموع الأجور\Net Pay: "
        e.Graphics.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY)
        '()
        If rptTotalDiscount.Trim.ToString.Equals("") Then
            rptTotalDiscount = "0"
        End If
        FieldValue = String.Format("{0:0.00}", Convert.ToDecimal(subtotalamt - Convert.ToDouble(rptTotalDiscount)))
        discAmount = AmountPosition + Convert.ToInt32(e.Graphics.MeasureString("Price", InvoiceFont).Width)
        discAmount = discAmount - Convert.ToInt32(e.Graphics.MeasureString(FieldValue, InvoiceFont).Width)
        e.Graphics.DrawString(FieldValue, InvoiceFont, BlackBrush, discAmount, CurrentY)

        CurrentX = leftMargin - 100
        CurrentY = CurrentY + InvoiceFontHeight + 23
        FieldValue = "ضريبة\Tax : "
        e.Graphics.DrawString(FieldValue, InvoiceFont, BlackBrush, CurrentX, CurrentY)

        FieldValue = String.Format("{0:0.00}", Convert.ToDecimal(totTax))
        discAmount = AmountPosition + Convert.ToInt32(e.Graphics.MeasureString("Price", InvoiceFont).Width)
        discAmount = discAmount - Convert.ToInt32(e.Graphics.MeasureString(FieldValue, InvoiceFont).Width)
        e.Graphics.DrawString(FieldValue, InvoiceFont, BlackBrush, discAmount, CurrentY)

        CurrentX = leftMargin
        InvSubTitle2 = thankyou1
        lenInvSubTitle2 = Convert.ToInt32(e.Graphics.MeasureString(InvSubTitle2, InvSubTitleFont).Width)
        xInvSubTitle2 = CurrentX + (InvoiceWidth - lenInvSubTitle2) / 2
        CurrentY = CurrentY + InvSubTitleHeight + 25
        e.Graphics.DrawString(InvSubTitle2, InvSubTitleFont, BlueBrush, xInvSubTitle2 - 10, CurrentY)

        InvSubTitle2 = thankyou2
        lenInvSubTitle2 = Convert.ToInt32(e.Graphics.MeasureString(InvSubTitle2, InvSubTitleFont).Width)
        xInvSubTitle2 = CurrentX + (InvoiceWidth - lenInvSubTitle2) / 2
        CurrentY = CurrentY + InvSubTitleHeight
        e.Graphics.DrawString(InvSubTitle2, InvSubTitleFont, BlueBrush, xInvSubTitle2 - 10, CurrentY)

        InvSubTitle4 = welcome1
        lenInvSubTitle4 = Convert.ToInt32(e.Graphics.MeasureString(InvSubTitle4, InvTranstype).Width)
        xInvSubTitle4 = CurrentX + (InvoiceWidth - lenInvSubTitle4) / 2
        CurrentY = CurrentY + InvSubTitleHeight
        e.Graphics.DrawString(InvSubTitle4, InvTranstype, BlueBrush, xInvSubTitle4 - 10, CurrentY)

        InvSubTitle4 = welcome2
        lenInvSubTitle4 = Convert.ToInt32(e.Graphics.MeasureString(InvSubTitle4, InvTranstype).Width)
        xInvSubTitle4 = CurrentX + (InvoiceWidth - lenInvSubTitle4) / 2
        CurrentY = CurrentY + InvSubTitleHeight
        e.Graphics.DrawString(InvSubTitle4, InvTranstype, BlueBrush, xInvSubTitle4 - 10, CurrentY)

        InvSubTitle4 = thankyouArabic1
        lenInvSubTitle4 = Convert.ToInt32(e.Graphics.MeasureString(InvSubTitle4, InvTranstype).Width)
        xInvSubTitle4 = CurrentX + (InvoiceWidth - lenInvSubTitle4) / 2
        CurrentY = CurrentY + InvSubTitleHeight + 3
        e.Graphics.DrawString(InvSubTitle4, InvTranstype, BlueBrush, xInvSubTitle4 - 10, CurrentY)

        InvSubTitle4 = thankyouArabic2
        lenInvSubTitle4 = Convert.ToInt32(e.Graphics.MeasureString(InvSubTitle4, InvTranstype).Width)
        xInvSubTitle4 = CurrentX + (InvoiceWidth - lenInvSubTitle4) / 2
        CurrentY = CurrentY + InvSubTitleHeight + 3
        e.Graphics.DrawString(InvSubTitle4, InvTranstype, BlueBrush, xInvSubTitle4 - 10, CurrentY)

        InvSubTitle4 = welcomeArabic1
        lenInvSubTitle4 = Convert.ToInt32(e.Graphics.MeasureString(InvSubTitle4, InvTranstype).Width)
        xInvSubTitle4 = CurrentX + (InvoiceWidth - lenInvSubTitle4) / 2
        CurrentY = CurrentY + InvSubTitleHeight
        e.Graphics.DrawString(InvSubTitle4, InvTranstype, BlueBrush, xInvSubTitle4 - 10, CurrentY)

        InvSubTitle4 = welcomeArabic2
        lenInvSubTitle4 = Convert.ToInt32(e.Graphics.MeasureString(InvSubTitle4, InvTranstype).Width)
        xInvSubTitle4 = CurrentX + (InvoiceWidth - lenInvSubTitle4) / 2
        CurrentY = CurrentY + InvSubTitleHeight
        e.Graphics.DrawString(InvSubTitle4, InvTranstype, BlueBrush, xInvSubTitle4 - 10, CurrentY)

        e.Graphics.Dispose()
    End Sub

    Private Sub btnCloseReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseReport.Click
        Try
            Me.Close()
            Transactions.MdiParent = Home
            Transactions.Show()
        Catch ex As Exception
            errLog.WriteToErrorLog("Error", ex.ToString, ex.StackTrace)
        End Try
    End Sub


    'Public Sub GiftReceipt()

    '    Try

    '        Dim displayString As String

    '        Dim ESC As String = Chr(&H1B)

    '        displayString = ESC + "!" + Chr(1) + ESC + "|cA" + "Store Name" + ESC + "|1lF"
    '        displayString += ESC + "|cA" + "Store Address" + ESC + "|1lF"
    '        displayString += ESC + "|2C" + ESC + "|cA" + ESC + "|bC" + "Gift Receipt" + ESC + "|1lF" + ESC + "|1lF"
    '        displayString += ESC + "|N" + ESC + "!" + Chr(1) + "  Transaction #:  " + vbTab.ToString() + "105" + ESC + "|1lF"

    '        displayString += "  Date:  " + Date.Today() + vbTab.ToString() + "Time: "

    '        displayString += DateAndTime.Now().ToLongTimeString() + ESC + "|1lF"

    '        displayString += "  Cashier:  " + CStr(_currSess.Cashier.Number) + vbTab.ToString() + "Register:  " + CStr(_currSess.Register.Number) + ESC + "|1lF" + ESC + "|1lF"

    '        displayString += ESC + "|2uC" + "  Item				 Description		   Quantity" + ESC + "|N" + ESC + "!" + Chr(1) + ESC + "|1lF" + ESC + "|1lF" + "  "

    '        'Iterate loop for each row of the Data Set.
    '        For k As Integer = 0 To TransactionSet1.TransactionEntry.Rows.Count - 1

    '            'Checking for each row which has selected in DataGrid item.
    '            If CType(dgTransactionList.Item(k, 0), System.String) = "True" Then

    '                'Get the Item value from selected row.
    '                Dim item As String = dgTransactionList.Item(k, 1).ToString()

    '                Dim itemValue As String = String.Empty
    '                If item.Length > 11 Then
    '                    'if Item length is greater then 11, then take substring of item 0 to 11.
    '                    item = item.Substring(0, 11)
    '                Else
    '                    'Adding " " in Item string until length 11.
    '                    While item.Length <= 11

    '                        item += " "

    '                    End While

    '                End If

    '                displayString += item + vbTab.ToString()
    '                Dim desc As String = dgTransactionList.Item(k, 2).ToString()
    '                Dim descValue As String = String.Empty

    '                If desc.Length > 20 Then

    '                    'If Description length is greater then 20, then take substring of item 0 to 20.
    '                    desc = desc.Substring(0, 20)

    '                Else
    '                    While desc.Length <= 20

    '                        'Adding " " in Description string until length 20.
    '                        desc += " "

    '                    End While

    '                End If

    '                displayString += desc + vbTab.ToString()
    '                Dim qnty As String = dgTransactionList.Item(k, 3).ToString()
    '                Dim qntyValue As String = String.Empty

    '                If qnty.Length > 3 Then

    '                    'If Quantity length is greater then 20, then take substring of quantity 0 to 3.
    '                    qnty = qnty.Substring(0, 3)

    '                Else

    '                    While qnty.Length <= 3

    '                        'Adding " " in Quantity string until length 20.
    '                        qntyValue += " "
    '                        qnty += " "

    '                    End While

    '                End If

    '                qntyValue += qnty.Trim()
    '                displayString += qntyValue
    '                displayString += ESC + "|1lF" + "  "

    '            End If

    '        Next k

    '        displayString += ESC + "|1lF"
    '        displayString += ESC + "|cA" + "Thank You for shopping" + ESC + "|1lF"
    '        displayString += ESC + "|cA" + _currSess.Configuration.StoreName + ESC + "|1lF"
    '        displayString += ESC + "|cA" + "We hope you'll come back soon!" + ESC + "|1lF" + ESC + "|1lF" + ESC + "|fP"
    '        _currSess.Register.SetActivePrinterNumber(0)

    '        Dim objRp As Object = _currSess.Register.ReceiptPrinter
    '        objRp.PrintNormal(2, displayString)

    '        objRp.Release()
    '        MsgBox("Gift Receipt printed Successfully.")

    '    Catch ex As Exception

    '        MsgBox(ex.ToString())

    '    End Try

    'End Sub



    Private Sub lblRptQtyHead_Click(sender As Object, e As EventArgs) Handles lblRptQtyHead.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class