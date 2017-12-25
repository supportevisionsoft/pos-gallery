Imports System.Drawing
Imports System.Drawing.Drawing2D

Public Class SettingsLocationMaster
    Inherits System.Windows.Forms.Form
    Dim db As New DBConnection
    Dim settingsType As String = ""
    Dim Location_Codes As New List(Of String)
    Dim MySource_LocationCodes As New AutoCompleteStringCollection()

    Private Sub loadLocationType(ByVal cmbCtl As ComboBox)
        Try
            Dim ds As DataSet
            Dim stQuery As String
            Dim count As Integer
            Dim i As Integer
            cmbCtl.Items.Clear()
            stQuery = "SELECT LT_CODE || '  -  ' || LT_DESC FROM OM_LOCN_TYPE WHERE NVL(LT_FRZ_FLAG_NUM, 2) = '2'"
            ds = db.SelectFromTableODBC(stQuery)
            count = ds.Tables("Table").Rows.Count
            i = 0
            While count > 0
                cmbCtl.Items.Add(ds.Tables("Table").Rows.Item(i).Item(0).ToString)
                count = count - 1
                i = i + 1
            End While
        Catch ex As Exception
            errLog.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")
        End Try
    End Sub

    Private Sub loadLocationStockGrp(ByVal cmbCtl As ComboBox)
        Try
            Dim ds As DataSet
            Dim stQuery As String
            Dim count As Integer
            Dim i As Integer
            cmbCtl.Items.Clear()
            stQuery = "SELECT LGD_CODE || '  -  ' || LGD_NAME FROM OM_LOCN_GROUP_DEFN WHERE NVL(LGD_FRZ_FLAG_NUM,2) <> 1 AND (LGD_TYPE_NUM = DECODE(NVL(1, 0), 0, LGD_TYPE_NUM, 1 ))"
            ds = db.SelectFromTableODBC(stQuery)
            count = ds.Tables("Table").Rows.Count
            i = 0
            While count > 0
                cmbCtl.Items.Add(ds.Tables("Table").Rows.Item(i).Item(0).ToString)
                count = count - 1
                i = i + 1
            End While
        Catch ex As Exception
            errLog.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")
        End Try
    End Sub

    Private Sub loadLocationCostingGrp(ByVal cmbCtl As ComboBox)
        Try
            Dim ds As DataSet
            Dim stQuery As String
            Dim count As Integer
            Dim i As Integer
            cmbCtl.Items.Clear()
            stQuery = "SELECT LGD_CODE || '  -  ' || LGD_NAME FROM OM_LOCN_GROUP_DEFN WHERE NVL(LGD_FRZ_FLAG_NUM,2) <> 1 AND (LGD_TYPE_NUM = DECODE(NVL(2, 0), 0, LGD_TYPE_NUM, 2 ))"
            ds = db.SelectFromTableODBC(stQuery)
            count = ds.Tables("Table").Rows.Count
            i = 0
            While count > 0
                cmbCtl.Items.Add(ds.Tables("Table").Rows.Item(i).Item(0).ToString)
                count = count - 1
                i = i + 1
            End While
        Catch ex As Exception
            errLog.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")
        End Try
    End Sub

    Private Sub loadLocationClosingGrp(ByVal cmbCtl As ComboBox)
        Try
            Dim ds As DataSet
            Dim stQuery As String
            Dim count As Integer
            Dim i As Integer
            cmbCtl.Items.Clear()
            stQuery = "SELECT LGD_CODE || '  -  ' || LGD_NAME FROM OM_LOCN_GROUP_DEFN WHERE NVL(LGD_FRZ_FLAG_NUM,2) <> 1 AND (LGD_TYPE_NUM = DECODE(NVL(3, 0), 0, LGD_TYPE_NUM, 3 ))"
            ds = db.SelectFromTableODBC(stQuery)
            count = ds.Tables("Table").Rows.Count
            i = 0
            While count > 0
                cmbCtl.Items.Add(ds.Tables("Table").Rows.Item(i).Item(0).ToString)
                count = count - 1
                i = i + 1
            End While
        Catch ex As Exception
            errLog.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")
        End Try
    End Sub

    Private Sub loadAddrCodes(ByVal cmbCtl As ComboBox)
        Try
            Dim ds As DataSet
            Dim stQuery As String
            Dim count As Integer
            Dim i As Integer
            cmbCtl.Items.Clear()
            stQuery = "SELECT ADDR_CODE || '  -  ' || ADDR_NAME FROM OM_ADDRESS WHERE ADDR_FRZ_FLAG_NUM =2 order by ADDR_CODE"
            ds = db.SelectFromTableODBC(stQuery)
            count = ds.Tables("Table").Rows.Count
            i = 0
            While count > 0
                cmbCtl.Items.Add(ds.Tables("Table").Rows.Item(i).Item(0).ToString)
                count = count - 1
                i = i + 1
            End While
        Catch ex As Exception
            errLog.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")
        End Try
    End Sub


    Private Sub load_AllLocationDetails()
        Try
            lstviewShiftMaster.Items.Clear()
            Dim ds As DataSet
            Dim stQuery As String
            stQuery = "select LOCN_CODE,LOCN_NAME,LT_DESC,ADDR_NAME || ',' || ADDR_LINE_1 || ','|| ADDR_LINE_2 || ',' || ADDR_CITY_CODE  from om_location, om_address,OM_LOCN_TYPE where locn_addr_code=addr_code and LOCN_TYPE=LT_CODE and LOCN_FRZ_FLAG_NUM=2"
            ds = db.SelectFromTableODBC(stQuery)
            Dim count As Integer
            count = ds.Tables("Table").Rows.Count
            Dim i As Integer = 0
            Dim row As System.Data.DataRow
            While count > 0
                row = ds.Tables("Table").Rows.Item(i)
                lstviewShiftMaster.Items.Add(i + 1)
                lstviewShiftMaster.Items(i).SubItems.Add(row.Item(0).ToString)
                lstviewShiftMaster.Items(i).SubItems.Add(row.Item(1).ToString)
                lstviewShiftMaster.Items(i).SubItems.Add(row.Item(2).ToString)
                lstviewShiftMaster.Items(i).SubItems.Add(row.Item(3).ToString)
                i = i + 1
                count = count - 1
            End While
            'lstviewShiftMaster.Refresh()
        Catch ex As Exception
            errLog.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")
        End Try
    End Sub

    Private Sub SetResolution()
        Try

            ' set resolution sub checks all the controls on the screen. Containers (tabcontrol, panel, ‘groupbox, tablelayoutpanel) do not resize on general control search for the form – so ‘they have to be done separate by name

            Dim perX, perY As Double, prvheight, prvWidth As Int32
            Dim shoAdd As Short

            Dim desktopSize As Size = Windows.Forms.SystemInformation.PrimaryMonitorSize
            prvheight = desktopSize.Height
            prvWidth = desktopSize.Width
            Dim p_shoWhatSize As Double
            ' in Windows 7, in the display section of the control panel, a user can ‘be set to see their screen larger – the settings are 100%, 125%, and ‘150%. In my programs preferences, I allow my software user to select ‘if they are using the 125% or the 150% settings. I set the global ‘p_shoWhatSize (short) varible to 1 for 125% and 2 for 150% screen. ‘This section ajusts for this

            If p_shoWhatSize = 1 Then
                prvheight = prvheight * 0.8
                prvWidth = prvWidth * 0.8
            End If
            If p_shoWhatSize = 2 Then
                prvheight = prvheight * 0.6666
                prvWidth = prvWidth * 0.6666
            End If

            ' the development resolution for my project is 1024 x 768 – change this ‘to your development resolution
            ' get new 'ratio' for screen
            perX = prvWidth / 1024
            perY = prvheight / 768

            ' listboxes don’t resize vertically correctly for all resolutions due ‘to the font size. shoAdd is used to ‘tweek’ the size of the list ‘boxes to help adjust for this – requires some testing on your screens ‘in different resolutions. I have some set at 10 and some as high as ‘14.
            If prvheight > 768 Then shoAdd = Int((prvheight - 768) / 12)

            Dim shoFont As Short

            ' if res is 1024 x 768 then perX and PerY will equal 1
            If perX <> 1 Or perY <> 1 Then

                For Each ctl As Control In Me.Controls

                    ' if you change the fonts of panels or groupbox containers, it messes
                    ' with the controls in those containers. Therefore, I skip the font 
                    ' resize for these
                    If UCase(ctl.GetType.ToString) <> "SYSTEM.WINDOWS.FORMS.PANEL" _
                    And UCase(ctl.GetType.ToString) <> "SYSTEM.WINDOWS.FORMS.GROUPBOX" Then
                        shoFont = ctl.Font.Size * perY
                        ctl.Font = New Font(ctl.Font.FontFamily, shoFont, ctl.Font.Style)
                    End If

                    'get new location
                    ctl.Location = New Point(ctl.Location.X * perX, ctl.Location.Y * perY)

                    If UCase(ctl.GetType.ToString) = "SYSTEM.WINDOWS.FORMS.LISTBOX" Then
                        ctl.Height = ctl.Size.Height * perY + shoAdd
                        ctl.Width = ctl.Size.Width * perX
                    Else
                        ' get new height & width
                        ctl.Height = ctl.Size.Height * perY
                        ctl.Width = ctl.Size.Width * perX
                    End If

                    Application.DoEvents()
                Next ctl


                For Each ctl As Control In pnlBottomHolder.Controls
                    If UCase(ctl.GetType.ToString) <> "SYSTEM.WINDOWS.FORMS.PANEL" _
                    And UCase(ctl.GetType.ToString) <> "SYSTEM.WINDOWS.FORMS.GROUPBOX" Then
                        shoFont = ctl.Font.Size * perY
                        ctl.Font = New Font(ctl.Font.FontFamily, shoFont, ctl.Font.Style)
                    End If

                    'get new location
                    ctl.Location = New Point(ctl.Location.X * perX, ctl.Location.Y * perY)

                    If UCase(ctl.GetType.ToString) = "SYSTEM.WINDOWS.FORMS.LISTBOX" Then
                        ctl.Height = ctl.Size.Height * perY + shoAdd
                        ctl.Width = ctl.Size.Width * perX
                    Else
                        ' get new height & width
                        ctl.Height = ctl.Size.Height * perY
                        ctl.Width = ctl.Size.Width * perX
                    End If

                    Application.DoEvents()
                Next

                For Each ctl As Control In pnlShiftMaster.Controls
                    If UCase(ctl.GetType.ToString) <> "SYSTEM.WINDOWS.FORMS.PANEL" _
                    And UCase(ctl.GetType.ToString) <> "SYSTEM.WINDOWS.FORMS.GROUPBOX" Then
                        shoFont = ctl.Font.Size * perY
                        ctl.Font = New Font(ctl.Font.FontFamily, shoFont, ctl.Font.Style)
                    End If

                    'get new location
                    ctl.Location = New Point(ctl.Location.X * perX, ctl.Location.Y * perY)

                    If UCase(ctl.GetType.ToString) = "SYSTEM.WINDOWS.FORMS.LISTBOX" Then
                        ctl.Height = ctl.Size.Height * perY + shoAdd
                        ctl.Width = ctl.Size.Width * perX
                    Else
                        ' get new height & width
                        ctl.Height = ctl.Size.Height * perY
                        ctl.Width = ctl.Size.Width * perX
                    End If

                    Application.DoEvents()
                Next

                lstviewShiftMaster.Columns.Add("SNo", lblShiftSNo.Width - 3, HorizontalAlignment.Left)
                lstviewShiftMaster.Columns.Add("Location code", lblshift_Scode.Width, HorizontalAlignment.Left)
                lstviewShiftMaster.Columns.Add("Location Description ", lblshift_SDesc.Width, HorizontalAlignment.Left)
                lstviewShiftMaster.Columns.Add("Location Type", lblShift_loc.Width, HorizontalAlignment.Left)
                lstviewShiftMaster.Columns.Add("Location Address", lblshift_fromtime.Width, HorizontalAlignment.Left)
                lstviewShiftMaster.View = View.Details
                lstviewShiftMaster.GridLines = True
                lstviewShiftMaster.FullRowSelect = True

                load_AllLocationDetails()
                lstviewShiftMaster.Refresh()
                settingsType = "Location Master"

                For Each ctl As Control In pnlButtonHolder.Controls
                    If UCase(ctl.GetType.ToString) <> "SYSTEM.WINDOWS.FORMS.PANEL" _
                    And UCase(ctl.GetType.ToString) <> "SYSTEM.WINDOWS.FORMS.GROUPBOX" Then
                        shoFont = ctl.Font.Size * perY
                        ctl.Font = New Font(ctl.Font.FontFamily, shoFont, ctl.Font.Style)
                    End If

                    'get new location
                    ctl.Location = New Point(ctl.Location.X * perX, ctl.Location.Y * perY)

                    If UCase(ctl.GetType.ToString) = "SYSTEM.WINDOWS.FORMS.LISTBOX" Then
                        ctl.Height = ctl.Size.Height * perY + shoAdd
                        ctl.Width = ctl.Size.Width * perX
                    Else
                        ' get new height & width
                        ctl.Height = ctl.Size.Height * perY
                        ctl.Width = ctl.Size.Width * perX
                    End If

                    Application.DoEvents()
                Next

                For Each ctl As Control In pnlSet_shift.Controls
                    If UCase(ctl.GetType.ToString) <> "SYSTEM.WINDOWS.FORMS.PANEL" _
                    And UCase(ctl.GetType.ToString) <> "SYSTEM.WINDOWS.FORMS.GROUPBOX" Then
                        shoFont = ctl.Font.Size * perY
                        ctl.Font = New Font(ctl.Font.FontFamily, shoFont, ctl.Font.Style)
                    End If

                    'get new location
                    ctl.Location = New Point(ctl.Location.X * perX, ctl.Location.Y * perY)

                    If UCase(ctl.GetType.ToString) = "SYSTEM.WINDOWS.FORMS.LISTBOX" Then
                        ctl.Height = ctl.Size.Height * perY + shoAdd
                        ctl.Width = ctl.Size.Width * perX
                    Else
                        ' get new height & width
                        ctl.Height = ctl.Size.Height * perY
                        ctl.Width = ctl.Size.Width * perX
                    End If

                    Application.DoEvents()
                Next

                For Each ctl As Control In pnl_counter.Controls
                    If UCase(ctl.GetType.ToString) <> "SYSTEM.WINDOWS.FORMS.PANEL" _
                    And UCase(ctl.GetType.ToString) <> "SYSTEM.WINDOWS.FORMS.GROUPBOX" Then
                        shoFont = ctl.Font.Size * perY
                        ctl.Font = New Font(ctl.Font.FontFamily, shoFont, ctl.Font.Style)
                    End If

                    'get new location
                    ctl.Location = New Point(ctl.Location.X * perX, ctl.Location.Y * perY)

                    If UCase(ctl.GetType.ToString) = "SYSTEM.WINDOWS.FORMS.LISTBOX" Then
                        ctl.Height = ctl.Size.Height * perY + shoAdd
                        ctl.Width = ctl.Size.Width * perX
                    Else
                        ' get new height & width
                        ctl.Height = ctl.Size.Height * perY
                        ctl.Width = ctl.Size.Width * perX
                    End If

                    Application.DoEvents()
                Next

                For Each ctl As Control In pnl_salesmanmaster.Controls
                    If UCase(ctl.GetType.ToString) <> "SYSTEM.WINDOWS.FORMS.PANEL" _
                    And UCase(ctl.GetType.ToString) <> "SYSTEM.WINDOWS.FORMS.GROUPBOX" Then
                        shoFont = ctl.Font.Size * perY
                        ctl.Font = New Font(ctl.Font.FontFamily, shoFont, ctl.Font.Style)
                    End If

                    'get new location
                    ctl.Location = New Point(ctl.Location.X * perX, ctl.Location.Y * perY)

                    If UCase(ctl.GetType.ToString) = "SYSTEM.WINDOWS.FORMS.LISTBOX" Then
                        ctl.Height = ctl.Size.Height * perY + shoAdd
                        ctl.Width = ctl.Size.Width * perX
                    Else
                        ' get new height & width
                        ctl.Height = ctl.Size.Height * perY
                        ctl.Width = ctl.Size.Width * perX
                    End If

                    Application.DoEvents()
                Next

                For Each ctl As Control In pnl_denominationmaster.Controls
                    If UCase(ctl.GetType.ToString) <> "SYSTEM.WINDOWS.FORMS.PANEL" _
                    And UCase(ctl.GetType.ToString) <> "SYSTEM.WINDOWS.FORMS.GROUPBOX" Then
                        shoFont = ctl.Font.Size * perY
                        ctl.Font = New Font(ctl.Font.FontFamily, shoFont, ctl.Font.Style)
                    End If

                    'get new location
                    ctl.Location = New Point(ctl.Location.X * perX, ctl.Location.Y * perY)

                    If UCase(ctl.GetType.ToString) = "SYSTEM.WINDOWS.FORMS.LISTBOX" Then
                        ctl.Height = ctl.Size.Height * perY + shoAdd
                        ctl.Width = ctl.Size.Width * perX
                    Else
                        ' get new height & width
                        ctl.Height = ctl.Size.Height * perY
                        ctl.Width = ctl.Size.Width * perX
                    End If

                    Application.DoEvents()
                Next
                For Each ctl As Control In pnl_paymentmaster.Controls
                    If UCase(ctl.GetType.ToString) <> "SYSTEM.WINDOWS.FORMS.PANEL" _
                    And UCase(ctl.GetType.ToString) <> "SYSTEM.WINDOWS.FORMS.GROUPBOX" Then
                        shoFont = ctl.Font.Size * perY
                        ctl.Font = New Font(ctl.Font.FontFamily, shoFont, ctl.Font.Style)
                    End If

                    'get new location
                    ctl.Location = New Point(ctl.Location.X * perX, ctl.Location.Y * perY)

                    If UCase(ctl.GetType.ToString) = "SYSTEM.WINDOWS.FORMS.LISTBOX" Then
                        ctl.Height = ctl.Size.Height * perY + shoAdd
                        ctl.Width = ctl.Size.Width * perX
                    Else
                        ' get new height & width
                        ctl.Height = ctl.Size.Height * perY
                        ctl.Width = ctl.Size.Width * perX
                    End If

                    Application.DoEvents()
                Next

                For Each ctl As Control In pnlShiftAdd.Controls
                    If UCase(ctl.GetType.ToString) <> "SYSTEM.WINDOWS.FORMS.PANEL" _
                    And UCase(ctl.GetType.ToString) <> "SYSTEM.WINDOWS.FORMS.GROUPBOX" Then
                        shoFont = ctl.Font.Size * perY
                        ctl.Font = New Font(ctl.Font.FontFamily, shoFont, ctl.Font.Style)
                    End If

                    'get new location
                    ctl.Location = New Point(ctl.Location.X * perX, ctl.Location.Y * perY)

                    If UCase(ctl.GetType.ToString) = "SYSTEM.WINDOWS.FORMS.LISTBOX" Then
                        ctl.Height = ctl.Size.Height * perY + shoAdd
                        ctl.Width = ctl.Size.Width * perX
                    Else
                        ' get new height & width
                        ctl.Height = ctl.Size.Height * perY
                        ctl.Width = ctl.Size.Width * perX
                    End If

                    Application.DoEvents()
                Next

                For Each ctl As Control In pnlShiftEdit.Controls
                    If UCase(ctl.GetType.ToString) <> "SYSTEM.WINDOWS.FORMS.PANEL" _
                    And UCase(ctl.GetType.ToString) <> "SYSTEM.WINDOWS.FORMS.GROUPBOX" Then
                        shoFont = ctl.Font.Size * perY
                        ctl.Font = New Font(ctl.Font.FontFamily, shoFont, ctl.Font.Style)
                    End If

                    'get new location
                    ctl.Location = New Point(ctl.Location.X * perX, ctl.Location.Y * perY)

                    If UCase(ctl.GetType.ToString) = "SYSTEM.WINDOWS.FORMS.LISTBOX" Then
                        ctl.Height = ctl.Size.Height * perY + shoAdd
                        ctl.Width = ctl.Size.Width * perX
                    Else
                        ' get new height & width
                        ctl.Height = ctl.Size.Height * perY
                        ctl.Width = ctl.Size.Width * perX
                    End If

                    Application.DoEvents()
                Next

                ' if you are not maximizing your screen afterwards, then include this code
                Me.Top = (prvheight / 2) - (Me.Height / 2)
                Me.Left = (prvWidth / 2) - (Me.Width / 2)
            Else
                lstviewShiftMaster.Columns.Add("SNo", lblShiftSNo.Width - 3, HorizontalAlignment.Left)
                lstviewShiftMaster.Columns.Add("Location code", lblshift_Scode.Width, HorizontalAlignment.Left)
                lstviewShiftMaster.Columns.Add("Location Description ", lblshift_SDesc.Width, HorizontalAlignment.Left)
                lstviewShiftMaster.Columns.Add("Location Type", lblShift_loc.Width, HorizontalAlignment.Left)
                lstviewShiftMaster.Columns.Add("Location Address", lblshift_fromtime.Width - 18, HorizontalAlignment.Left)
                lstviewShiftMaster.View = View.Details
                lstviewShiftMaster.GridLines = True
                lstviewShiftMaster.FullRowSelect = True

                load_AllLocationDetails()
                settingsType = "Location Master"
            End If
        Catch ex As Exception
            errLog.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")
        End Try
    End Sub

   
    Private Sub btnSettingsHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSettingsHome.Click
        Try
            If settingsType = "Location Master" Then
                pnlShiftAdd.Hide()
                pnlShiftEdit.Hide()
                pnlShiftAdd.SendToBack()
                pnlShiftEdit.SendToBack()
                load_AllLocationDetails()
            End If
        Catch ex As Exception
            errLog.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")
        End Try
    End Sub

    

   

   
    Private Sub btnSettingsEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSettingsEdit.Click

        Try
            If pnlShiftAdd.Visible Then
                'btnShiftAddCancel_Click(sender, e)
            End If
            If Not lstviewShiftMaster.SelectedItems.Count > 0 Then
                MsgBox("Select a row!")
                Exit Sub
            Else
                lstviewShiftMaster_DoubleClick(sender, e)
            End If
        Catch ex As Exception
            errLog.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")
        End Try

    End Sub
  

    

    Private Sub btnShiftEditCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim i As Integer = pnlShiftEdit.Height
            While i > 0
                pnlShiftEdit.Height = pnlShiftEdit.Height - 1
                pnlShiftEdit.Location = New Point(lblShiftSNo.Location.X, pnlShiftEdit.Location.Y + 1)
                i = i - 1
                Threading.Thread.Sleep(0.5)
            End While

            pnlShiftEdit.Visible = False
            pnlShiftEdit.SendToBack()
        Catch ex As Exception
            errLog.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")
        End Try
    End Sub
   
    Private Sub btnCounterMaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCounterMaster.Click
        Try
            For Each child As Form In Home.MdiChildren
                child.Close()
                child.Dispose()
            Next child
            SettingsCounterMaster.MdiParent = Home
            SettingsCounterMaster.Show()
        Catch ex As Exception
            errLog.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")
        End Try
    End Sub
   
    Private Sub btnSalesmanMaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalesmanMaster.Click
        Try
            For Each child As Form In Home.MdiChildren
                child.Close()
                child.Dispose()
            Next child
            SettingsSalesmanMaster.MdiParent = Home
            SettingsSalesmanMaster.Show()
        Catch ex As Exception
            errLog.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")
        End Try
    End Sub
    Private Sub btnDenominationMaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDenominationMaster.Click
        Try
            For Each child As Form In Home.MdiChildren
                child.Close()
                child.Dispose()
            Next child
            SettingsDenominationMaster.MdiParent = Home
            SettingsDenominationMaster.Show()
        Catch ex As Exception
            errLog.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")
        End Try
    End Sub
    Private Sub btnPaymentMaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPaymentMaster.Click
        Try
            For Each child As Form In Home.MdiChildren
                child.Close()
                child.Dispose()
            Next child
            SettingsPaymentMaster.MdiParent = Home
            SettingsPaymentMaster.Show()
        Catch ex As Exception
            errLog.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")
        End Try
    End Sub


  

    Private Sub btnSettingsAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSettingsAdd.Click

        Try
            If settingsType = "Location Master" Then
                If Not pnlShiftAdd.Visible Then
                    pnlShiftAdd.BringToFront()
                    pnlShiftAdd.Height = lblShiftSNo.Height + lstviewShiftMaster.Height + 1

                    Dim i As Integer = pnlShiftAdd.Height
                    While i >= lblShiftSNo.Location.Y
                        pnlShiftAdd.Location = New Point(lblShiftSNo.Location.X, i)
                        pnlShiftAdd.Show()
                        Threading.Thread.Sleep(0.5)
                        i = (i - 1)
                    End While
                    pnlShiftEdit.Visible = False

                    txtLocnCodeAdd.Text = ""
                    txtLocnDescAdd.Text = ""
                    txtLocnShortDescAdd.Text = ""
                    txtLocnShortCodeAdd.Text = ""
                    txtLocnNameAdd.Text = ""
                    cmbAddressCodeAdd.Text = ""
                    chkboxLocnFreezeAdd.CheckState = CheckState.Unchecked
                    chkboxLocnDocSrcAdd.CheckState = CheckState.Unchecked
                    chkboxLocnSaleAdd.CheckState = CheckState.Unchecked
                    chkboxLocnStockAdd.CheckState = CheckState.Unchecked
                    txtLocnAddr1Add.Text = ""
                    txtLocnAddr2Add.Text = ""
                    txtLocnAddr3Add.Text = ""
                    txtLocnAddr4Add.Text = ""
                    txtLocnAddr5Add.Text = ""
                    txtLocnEmailAdd.Text = ""
                    txtLocnMobileAdd.Text = ""
                    txtLocnContactPersonAdd.Text = ""
                    txtLocnCityAdd.Text = ""
                    txtLocnCountyAdd.Text = ""
                    txtLocnStateAdd.Text = ""
                    txtLocnZipAdd.Text = ""
                    txtLocnProvinceAdd.Text = ""
                    txtLocnCountryAdd.Text = ""
                    txtLocnFaxAdd.Text = ""
                    txtLocnTelephoneAdd.Text = ""

                    loadLocationType(cmbLocationTypeAdd)
                    loadLocationStockGrp(cmbStockLocGrpAdd)
                    loadLocationCostingGrp(cmbCostLocGrpAdd)
                    loadLocationClosingGrp(cmbCloseLocGrpAdd)
                    loadAddrCodes(cmbAddressCodeAdd)
                End If
            End If
        Catch ex As Exception
            errLog.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")
        End Try
    End Sub

    Private Sub SettingsLocationMaster_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Dock = DockStyle.Fill
        SetResolution()

        settingsType = "Location Master"

        If Not mastersarray.Contains("Counter Master") Then
            btnCounterMaster.Enabled = False
        End If
        If Not mastersarray.Contains("Shift Master") Then
            btnShift_SalesOrders.Enabled = False
        End If
        If Not mastersarray.Contains("Denomination Master") Then
            btnDenominationMaster.Enabled = False
        End If
        If Not mastersarray.Contains("Payment Master") Then
            btnPaymentMaster.Enabled = False
        End If
        If Not mastersarray.Contains("Salesman Master") Then
            btnSalesmanMaster.Enabled = False
        End If

    End Sub

    Private Sub cmbAddressCodeAdd_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAddressCodeAdd.SelectedValueChanged
        Try
            Dim stQuery As String
            Dim ds As DataSet
            Dim count As Integer
            Dim i As Integer = 0
            Dim row As System.Data.DataRow
            Dim addrcodeval As String = DirectCast(sender, ComboBox).Text.Split("  -  ")(0)
            stQuery = "select ADDR_LINE_1,ADDR_LINE_2,ADDR_LINE_3,ADDR_LINE_4,ADDR_LINE_5,ADDR_EMAIL,ADDR_MOBILE,ADDR_CONTACT,ADDR_CITY_CODE,ADDR_COUNTY_CODE,ADDR_STATE_CODE,ADDR_ZIP_POSTAL_CODE,ADDR_PROVINCE_CODE,ADDR_COUNTRY_CODE,ADDR_FAX,ADDR_TEL from OM_ADDRESS where ADDR_CODE='" & addrcodeval & "'"
            errLog.WriteToErrorLog("Address Details Query", stQuery, "")
            ds = db.SelectFromTableODBC(stQuery)
            count = ds.Tables("Table").Rows.Count
            If count > 0 Then
                row = ds.Tables("Table").Rows.Item(0)
                txtLocnAddr1Add.Text = row.Item(0).ToString
                txtLocnAddr2Add.Text = row.Item(1).ToString
                txtLocnAddr3Add.Text = row.Item(2).ToString
                txtLocnAddr4Add.Text = row.Item(3).ToString
                txtLocnAddr5Add.Text = row.Item(4).ToString
                txtLocnEmailAdd.Text = row.Item(5).ToString
                txtLocnMobileAdd.Text = row.Item(6).ToString
                txtLocnContactPersonAdd.Text = row.Item(7).ToString
                txtLocnCityAdd.Text = row.Item(8).ToString
                txtLocnCountyAdd.Text = row.Item(9).ToString
                txtLocnStateAdd.Text = row.Item(10).ToString
                txtLocnZipAdd.Text = row.Item(11).ToString
                txtLocnProvinceAdd.Text = row.Item(12).ToString
                txtLocnCountryAdd.Text = row.Item(13).ToString
                txtLocnFaxAdd.Text = row.Item(14).ToString
                txtLocnTelephoneAdd.Text = row.Item(15).ToString
            Else
            End If
        Catch ex As Exception
            errLog.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")
        End Try
    End Sub

    Private Sub btnShiftAddSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShiftAddSave.Click
        Try
            Dim stQuery As String
            Dim ds As DataSet
            'Dim count As Integer
            Dim i As Integer = 0
            If txtLocnCodeAdd.Text = "" Then
                MsgBox("Please enter Location Code!")
                Exit Sub
            End If
            stQuery = "SELECT 'X' FROM OM_LOCATION WHERE LOCN_CODE = '" & txtLocnCodeAdd.Text.Replace("'", "''").ToString & "'"
            ds = db.SelectFromTableODBC(stQuery)
            If ds.Tables("Table").Rows.Count > 0 Then
                MsgBox("Location Code already exists!")
                Exit Sub
            End If
            If cmbLocationTypeAdd.Text = "" Then
                MsgBox("Please select Location Type!")
                Exit Sub
            ElseIf cmbStockLocGrpAdd.Text = "" Then
                MsgBox("Please select Stocking Location Group!")
                Exit Sub
            ElseIf cmbCostLocGrpAdd.Text = "" Then
                MsgBox("Please select Costing Location Group!")
                Exit Sub
            ElseIf cmbCloseLocGrpAdd.Text = "" Then
                MsgBox("Please select Closing Location Group!")
                Exit Sub
            ElseIf cmbAddressCodeAdd.Text = "" Then
                MsgBox("Please select Address Code!")
                Exit Sub
            ElseIf txtLocnShortCodeAdd.Text = "" Then
                MsgBox("Location Short Code cannot be empty!")
                Exit Sub
            ElseIf txtLocnNameAdd.Text = "" Then
                MsgBox("Location name cannot be empty!")
                Exit Sub
            End If

            stQuery = "select 'X' from OM_ADDRESS where ADDR_CODE='" & cmbAddressCodeAdd.Text.Split("  -  ")(0) & "'"
            ds = db.SelectFromTableODBC(stQuery)
            If Not ds.Tables("Table").Rows.Count > 0 Then
                MsgBox("Invalid Address Code!")
                Exit Sub
            End If

            Dim stockyn As String = "N"
            Dim saleyn As String = "N"
            Dim docsrcyn As String = "N"
            Dim freeze As String = "1"

            If chkboxLocnStockAdd.CheckState = CheckState.Checked Then
                stockyn = "Y"
            Else
                stockyn = "N"
            End If

            If chkboxLocnSaleAdd.CheckState = CheckState.Checked Then
                saleyn = "Y"
            Else
                saleyn = "N"
            End If

            If chkboxLocnDocSrcAdd.CheckState = CheckState.Checked Then
                docsrcyn = "Y"
            Else
                docsrcyn = "N"
            End If

            If chkboxLocnFreezeAdd.CheckState = CheckState.Checked Then
                freeze = "1"
            Else
                freeze = "2"
            End If

            stQuery = "insert into om_location(LOCN_CODE,LOCN_TYPE,LOCN_NAME,LOCN_SHORT_NAME,LOCN_STOCK_YN,LOCN_SALE_YN,LOCN_DOC_SOURCE_YN,LOCN_GROUP_CODE,LOCN_COSTING_GROUP,LOCN_CLOSING_GROUP,LOCN_ADDR_CODE,LOCN_FRZ_FLAG_NUM,LOCN_FLEX_01,LOCN_FLEX_02,LOCN_CR_UID,LOCN_CR_DT)values("
            stQuery = stQuery & "'" & txtLocnCodeAdd.Text & "','" & cmbLocationTypeAdd.Text.Split("  -  ")(0) & "','" & txtLocnDescAdd.Text & "','" & txtLocnShortDescAdd.Text & "','" & stockyn & "','" & saleyn & "','" & docsrcyn & "','" & cmbStockLocGrpAdd.Text.Split("  -  ")(0) & "','" & cmbCostLocGrpAdd.Text.Split("  -  ")(0) & "','" & cmbStockLocGrpAdd.Text.Split("  -  ")(0) & "','" & cmbAddressCodeAdd.Text.Split("  -  ")(0) & "'," & freeze & ",'" & txtLocnShortCodeAdd.Text & "','" & txtLocnNameAdd.Text & "','" & LogonUser & "',sysdate)"
            errLog.WriteToErrorLog("OM_LOCATION insert Query", stQuery, "")
            db.SaveToTableODBC(stQuery)

            'stQuery = "SELECT 'X' FROM OM_PROPERTY_HEAD WHERE PH_APP_LEVEL_NUM = 2 AND PH_APP_CODE_NUM = 2"
            'ds = db.SelectFromTableODBC(stQuery)
            'If Not ds.Tables("Tables").Rows.Count > 0 Then
            '    stQuery = "SELECT 'X' FROM OM_LOCN_PROPERTY_HEAD WHERE LPH_LOCN_CODE ='" & txtLocnCodeAdd.Text & "' AND LPH_APP_CODE_NUM =2"
            '    ds = db.SelectFromTableODBC(stQuery)
            '    If Not ds.Tables("Table").Rows.Count > 0 Then
            '        stQuery = "INSERT INTO OM_LOCN_PROPERTY_HEAD ( LPH_LOCN_CODE,LPH_APP_CODE_NUM,LPH_PC_CODE,LPH_CR_UID,LPH_CR_DT ) VALUES ("
            '        stQuery = stQuery & "'" & txtLocnCodeAdd.Text & "',2,'','" & LogonUser & "',sysdate)"
            '        db.SaveToTableODBC(stQuery)
            '    End If
            'End If

            'stQuery = "SELECT 'X' FROM OM_LOCN_PROPERTY_DETAIL WHERE LPD_LPH_LOCN_CODE = '" & txtLocnCodeAdd.Text & "' AND LPD_LPH_APP_CODE_NUM = 2"
            'ds = db.SelectFromTableODBC(stQuery)
            'If Not ds.Tables("Table").Rows.Count > 0 Then
            '    stQuery = ""
            'End If

            MsgBox("Location Saved Successfully!")
            btnSettingsHome_Click(sender, e)
        Catch ex As Exception
            errLog.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")
        End Try
    End Sub

    Private Sub cmbAddressCodeAdd_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAddressCodeAdd.TextChanged
        If cmbAddressCodeAdd.Text = "" Then
            txtLocnAddr1Add.Text = ""
            txtLocnAddr2Add.Text = ""
            txtLocnAddr3Add.Text = ""
            txtLocnAddr4Add.Text = ""
            txtLocnAddr5Add.Text = ""
            txtLocnEmailAdd.Text = ""
            txtLocnMobileAdd.Text = ""
            txtLocnContactPersonAdd.Text = ""
            txtLocnCityAdd.Text = ""
            txtLocnCountyAdd.Text = ""
            txtLocnStateAdd.Text = ""
            txtLocnZipAdd.Text = ""
            txtLocnProvinceAdd.Text = ""
            txtLocnCountryAdd.Text = ""
            txtLocnFaxAdd.Text = ""
            txtLocnTelephoneAdd.Text = ""
        End If
    End Sub

    Private Sub btnShiftAddCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShiftAddCancel.Click
        Try
            Dim i As Integer = pnlShiftAdd.Height
            While i > 0
                pnlShiftAdd.Height = pnlShiftAdd.Height - 1
                pnlShiftAdd.Location = New Point(lblShiftSNo.Location.X, pnlShiftAdd.Location.Y + 1)
                i = i - 1
                Threading.Thread.Sleep(0.5)
            End While

            pnlShiftAdd.Visible = False
            pnlShiftAdd.SendToBack()
        Catch ex As Exception
            errLog.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")
        End Try
    End Sub

    Private Sub lstviewShiftMaster_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstviewShiftMaster.DoubleClick
        Try
            If Not lstviewShiftMaster.SelectedItems.Count > 0 Then
                MsgBox("Select a row!")
                Exit Sub
            End If

            Dim locncode As String = lstviewShiftMaster.SelectedItems.Item(0).SubItems(1).Text

            Dim stQuery As String
            Dim ds As DataSet
            Dim row As System.Data.DataRow
            stQuery = "select LOCN_CODE,LT_CODE || '  -  ' || LT_DESC,LOCN_NAME,LOCN_SHORT_NAME,LOCN_STOCK_YN,LOCN_SALE_YN,LOCN_DOC_SOURCE_YN,(SELECT LGD_CODE || '  -  ' || LGD_NAME FROM OM_LOCN_GROUP_DEFN where LGD_CODE=LOCN_GROUP_CODE) as LOCNGRPCODE,(SELECT LGD_CODE || '  -  ' || LGD_NAME FROM OM_LOCN_GROUP_DEFN where LGD_CODE=LOCN_COSTING_GROUP) as LOCNCOSTGRPCODE,(SELECT LGD_CODE || '  -  ' || LGD_NAME FROM OM_LOCN_GROUP_DEFN where LGD_CODE=LOCN_CLOSING_GROUP) as LOCNCLOSEGRPCODE,ADDR_CODE || '  -  ' || ADDR_NAME,LOCN_FRZ_FLAG_NUM,LOCN_FLEX_01,LOCN_FLEX_02, LOCN_BL_NAME from om_location,om_locn_type,om_address where LOCN_CODE='" & locncode & "' and LOCN_TYPE=LT_CODE and LOCN_ADDR_CODE=ADDR_CODE"
            'stQuery = "select LOCN_CODE,LT_CODE || '  -  ' || LT_DESC,LOCN_NAME,LOCN_SHORT_NAME,LOCN_STOCK_YN,LOCN_SALE_YN,LOCN_DOC_SOURCE_YN,(SELECT LGD_CODE || '  -  ' || LGD_NAME FROM OM_LOCN_GROUP_DEFN where LGD_CODE=LOCN_GROUP_CODE) as LOCNGRPCODE,(SELECT LGD_CODE || '  -  ' || LGD_NAME FROM OM_LOCN_GROUP_DEFN where LGD_CODE=LOCN_COSTING_GROUP) as LOCNCOSTGRPCODE,(SELECT LGD_CODE || '  -  ' || LGD_NAME FROM OM_LOCN_GROUP_DEFN where LGD_CODE=LOCN_CLOSING_GROUP) as LOCNCLOSEGRPCODE,LOCN_ADDR_CODE,LOCN_FRZ_FLAG_NUM,LOCN_FLEX_01,LOCN_FLEX_02 from om_location,om_locn_type where LOCN_CODE='" & locncode & "' and LOCN_TYPE=LT_CODE"
            ds = db.SelectFromTableODBC(stQuery)
            errLog.WriteToErrorLog("Query", stQuery, "")
            If ds.Tables("Table").Rows.Count > 0 Then

                If Not pnlShiftEdit.Visible Then
                    pnlShiftEdit.Height = lblShiftSNo.Height + lstviewShiftMaster.Height + 1
                    pnlShiftEdit.BringToFront()
                    Dim i As Integer = pnlShiftEdit.Height
                    While i >= lblShiftSNo.Location.Y
                        pnlShiftEdit.Location = New Point(lblShiftSNo.Location.X, i)
                        pnlShiftEdit.Show()
                        Threading.Thread.Sleep(0.5)
                        i = (i - 1)
                    End While
                    pnlShiftAdd.Visible = False

                End If
                loadLocationType(cmbLocnTypeEdit)
                loadLocationStockGrp(cmbLocnStkGrpEdit)
                loadLocationCostingGrp(cmbLocnCostGrpEdit)
                loadLocationClosingGrp(cmbLocnCloseGrpEdit)
                loadAddrCodes(cmbLocnAddrEdit)
                row = ds.Tables("Table").Rows.Item(0)
                txtLocnCodeEdit.Text = row.Item(0).ToString
                cmbLocnTypeEdit.Text = row.Item(1).ToString
                txtLocnDescEdit.Text = row.Item(2).ToString
                txtLocnShortDescEdit.Text = row.Item(3).ToString
                If row.Item(4).ToString = "Y" Then
                    chkboxLocnStkEdit.CheckState = CheckState.Checked
                Else
                    chkboxLocnStkEdit.CheckState = CheckState.Unchecked
                End If
                If row.Item(5).ToString = "Y" Then
                    chkboxLocnSaleEdit.CheckState = CheckState.Checked
                Else
                    chkboxLocnSaleEdit.CheckState = CheckState.Unchecked
                End If
                If row.Item(6).ToString = "Y" Then
                    chkboxDocSrcEdit.CheckState = CheckState.Checked
                Else
                    chkboxDocSrcEdit.CheckState = CheckState.Unchecked
                End If
                cmbLocnStkGrpEdit.Text = row.Item(7).ToString
                cmbLocnCostGrpEdit.Text = row.Item(8).ToString
                cmbLocnCloseGrpEdit.Text = row.Item(9).ToString
                cmbLocnAddrEdit.Text = row.Item(10).ToString
                cmbLocnAddrEdit_SelectedValueChanged(sender, e)
                If row.Item(11).ToString = "1" Then
                    chkboxLocnFreezeEdit.CheckState = CheckState.Checked
                ElseIf row.Item(11).ToString = "2" Then
                    chkboxLocnFreezeEdit.CheckState = CheckState.Unchecked
                End If
                txtLocnShortCodeEdit.Text = row.Item(12).ToString
                txtLocnNameEdit.Text = row.Item(13).ToString
                txtLocnArabicDescEdit.Text = row.Item(14).ToString
                lstviewShiftMaster.SelectedItems.Clear()
            Else
                MsgBox("Not available for edit")
                lstviewShiftMaster.SelectedItems.Clear()
            End If
        Catch ex As Exception
            errLog.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")
        End Try
    End Sub


    Private Sub cmbLocnAddrEdit_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbLocnAddrEdit.SelectedValueChanged
        Try
            Dim stQuery As String
            Dim ds As DataSet
            Dim count As Integer
            Dim i As Integer = 0
            Dim row As System.Data.DataRow
            Dim addrcodeval As String = DirectCast(sender, ComboBox).Text.Split("  -  ")(0)
            stQuery = "select ADDR_LINE_1,ADDR_LINE_2,ADDR_LINE_3,ADDR_LINE_4,ADDR_LINE_5,ADDR_EMAIL,ADDR_MOBILE,ADDR_CONTACT,ADDR_CITY_CODE,ADDR_COUNTY_CODE,ADDR_STATE_CODE,ADDR_ZIP_POSTAL_CODE,ADDR_PROVINCE_CODE,ADDR_COUNTRY_CODE,ADDR_FAX,ADDR_TEL from OM_ADDRESS where ADDR_CODE='" & addrcodeval & "'"
            errLog.WriteToErrorLog("Address Details Query", stQuery, "")
            ds = db.SelectFromTableODBC(stQuery)
            count = ds.Tables("Table").Rows.Count
            If count > 0 Then
                row = ds.Tables("Table").Rows.Item(0)
                txtlocnAddr1Edit.Text = row.Item(0).ToString
                txtlocnAddr2Edit.Text = row.Item(1).ToString
                txtlocnAddr3Edit.Text = row.Item(2).ToString
                txtlocnAddr4Edit.Text = row.Item(3).ToString
                txtlocnAddr5Edit.Text = row.Item(4).ToString
                txtlocnEmailEdit.Text = row.Item(5).ToString
                txtlocnMobileEdit.Text = row.Item(6).ToString
                txtlocnContPersonEdit.Text = row.Item(7).ToString
                txtlocnCityEdit.Text = row.Item(8).ToString
                txtlocnCountyEdit.Text = row.Item(9).ToString
                txtlocnStateEdit.Text = row.Item(10).ToString
                txtlocnZipEdit.Text = row.Item(11).ToString
                txtlocnProvinceEdit.Text = row.Item(12).ToString
                txtlocnCountryEdit.Text = row.Item(13).ToString
                txtlocnFaxEdit.Text = row.Item(14).ToString
                txtlocnTelephoneEdit.Text = row.Item(15).ToString
            Else
            End If
        Catch ex As Exception
            errLog.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")
        End Try
    End Sub

    Private Sub cmbLocnAddrEdit_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbLocnAddrEdit.TextChanged
        If cmbLocnAddrEdit.Text = "" Then
            txtlocnAddr1Edit.Text = ""
            txtlocnAddr2Edit.Text = ""
            txtlocnAddr3Edit.Text = ""
            txtlocnAddr4Edit.Text = ""
            txtlocnAddr5Edit.Text = ""
            txtlocnEmailEdit.Text = ""
            txtlocnMobileEdit.Text = ""
            txtlocnContPersonEdit.Text = ""
            txtlocnCityEdit.Text = ""
            txtlocnCountyEdit.Text = ""
            txtlocnStateEdit.Text = ""
            txtlocnZipEdit.Text = ""
            txtlocnProvinceEdit.Text = ""
            txtlocnCountryEdit.Text = ""
            txtlocnFaxEdit.Text = ""
            txtlocnTelephoneEdit.Text = ""
        End If
    End Sub

    Private Sub btnCounterAddCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCounterAddCancel.Click
        Try
            Dim i As Integer = pnlShiftEdit.Height
            While i > 0
                pnlShiftEdit.Height = pnlShiftEdit.Height - 1
                pnlShiftEdit.Location = New Point(lblShiftSNo.Location.X, pnlShiftEdit.Location.Y + 1)
                i = i - 1
                Threading.Thread.Sleep(0.5)
            End While

            pnlShiftEdit.Visible = False
            pnlShiftEdit.SendToBack()
        Catch ex As Exception
            errLog.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")
        End Try
    End Sub

    Private Sub btnLocationEditSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLocationEditSave.Click
        Try
            Dim stQuery As String
            Dim ds As DataSet

            If cmbLocnTypeEdit.Text = "" Then
                MsgBox("Please select Location Type!")
                Exit Sub
            ElseIf cmbLocnStkGrpEdit.Text = "" Then
                MsgBox("Please select Stocking Location Group!")
                Exit Sub
            ElseIf cmbLocnCostGrpEdit.Text = "" Then
                MsgBox("Please select Costing Location Group!")
                Exit Sub
            ElseIf cmbLocnCloseGrpEdit.Text = "" Then
                'MsgBox("Please select Closing Location Group!")
                'Exit Sub
            ElseIf cmbLocnAddrEdit.Text = "" Then
                MsgBox("Please select Address Code!")
                Exit Sub
            ElseIf txtLocnShortCodeEdit.Text = "" Then
                MsgBox("Location Short Code cannot be empty!")
                Exit Sub
            End If

            stQuery = "select 'X' from OM_ADDRESS where ADDR_CODE='" & cmbLocnAddrEdit.Text.Split("  -  ")(0) & "'"
            ds = db.SelectFromTableODBC(stQuery)
            If Not ds.Tables("Table").Rows.Count > 0 Then
                MsgBox("Invalid Address Code!")
                Exit Sub
            End If

            Dim stockyn As String = "N"
            Dim saleyn As String = "N"
            Dim docsrcyn As String = "N"
            Dim freeze As String = "1"

            If chkboxLocnStkEdit.CheckState = CheckState.Checked Then
                stockyn = "Y"
            Else
                stockyn = "N"
            End If

            If chkboxLocnSaleEdit.CheckState = CheckState.Checked Then
                saleyn = "Y"
            Else
                saleyn = "N"
            End If

            If chkboxDocSrcEdit.CheckState = CheckState.Checked Then
                docsrcyn = "Y"
            Else
                docsrcyn = "N"
            End If

            If chkboxLocnFreezeEdit.CheckState = CheckState.Checked Then
                freeze = "1"
            Else
                freeze = "2"
            End If

            stQuery = "update om_location set LOCN_NAME='" & txtLocnDescEdit.Text & "',LOCN_SHORT_NAME='" & txtLocnShortDescEdit.Text & "',LOCN_GROUP_CODE='" & cmbLocnStkGrpEdit.Text.Split("  -  ")(0).ToString & "',LOCN_STOCK_YN='" & stockyn & "',LOCN_SALE_YN='" & saleyn & "',LOCN_DOC_SOURCE_YN='" & docsrcyn & "',LOCN_ADDR_CODE='" & cmbLocnAddrEdit.Text.Split("  -  ")(0).ToString & "',LOCN_FRZ_FLAG_NUM=" & freeze & ",LOCN_COSTING_GROUP='" & cmbLocnCostGrpEdit.Text.Split("  -  ")(0).ToString & "',LOCN_CLOSING_GROUP='" & cmbLocnCostGrpEdit.Text.Split("  -  ")(0).ToString & "',LOCN_TYPE='" & cmbLocnTypeEdit.Text.Split("  -  ")(0).ToString & "',LOCN_FLEX_01='" & txtLocnShortCodeEdit.Text & "',LOCN_FLEX_02='" & txtLocnNameEdit.Text & "',LOCN_UPD_UID='" & LogonUser & "',LOCN_UPD_DT=sysdate, LOCN_BL_NAME='" & txtLocnArabicDescEdit.Text.Replace("'", "''") & "' where LOCN_CODE='" & txtLocnCodeEdit.Text & "'"
            errLog.WriteToErrorLog("Update OM_LOCATION", stQuery, "")
            db.SaveToTableODBC(stQuery)
            MsgBox("Location Updated Successfully!")
            btnCounterAddCancel_Click(sender, e)
        Catch ex As Exception
            errLog.WriteToErrorLog(ex.Message, ex.StackTrace, "Error")
        End Try
    End Sub

   
End Class