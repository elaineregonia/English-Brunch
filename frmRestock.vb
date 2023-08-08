Public Class frmRestock

    Private validInput, stock As Integer
    Dim mozadd, bacadd, chiadd, musadd, vegadd, veradd As Integer
    Dim mmozadd, mbacadd, mchiadd, mmusadd, mvegadd, mveradd As Integer
    Dim lmozadd, lbacadd, lchiadd, lmusadd, lvegadd, lveradd As Integer
    Dim roladd, freadd, wheadd, whiadd, banadd, hotadd As Integer
    Dim espadd, dopadd, ameadd, capadd, latadd, macadd As Integer
    Dim mespadd, mdopadd, mameadd, mcapadd, mlatadd, mmacadd As Integer
    Dim lespadd, ldopadd, lameadd, lcapadd, llatadd, lmacadd As Integer
    Dim current As String
    Dim dt As New DataTable("Restock")
    Dim mozv, mmozv, lmozv, bacv, mbacv, lbacv, musv, mmusv, lmusv, chiv, mchiv, lchiv, vegv, mvegv, lvegv, verv, mverv, lverv As Integer
    Dim rolv, frev, whev, whiv, banv, hotv As Integer
    Dim espv, mespv, lespv, dopv, mdopv, ldopv, amev, mamev, lamev, capv, mcapv, lcapv, latv, mlatv, llatav, macv, mmacv, lmacv As Integer
    Dim newpoint As New System.Drawing.Point
    Dim drag As Boolean

    Dim x, y As Integer

    Private Sub frmRestock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtSearch.Select()

        With txtSearch

            .SelectionStart = .TextLength
            .SelectionLength = 0
            .SelectionStart = 0
            .ScrollToCaret()

        End With

        dt.Columns.Add("Product ID", Type.GetType("System.String"))
        dt.Columns.Add("ProductName", Type.GetType("System.String"))
        dt.Columns.Add("Category", Type.GetType("System.String"))
        dt.Columns.Add("Quantity", Type.GetType("System.Int32"))
        dt.Columns.Add("Status", Type.GetType("System.String"))

        dt.Rows.Add("Reg-P0102", "Mozzarella", "Pizza", mainform.txtSRMoz.Text)
        dt.Rows.Add("Med-P0102", "Mozzarella", "Pizza", mainform.txtSMMoz.Text)
        dt.Rows.Add("Lar-P0102", "Mozzarella", "Pizza", mainform.txtSLMoz.Text)
        dt.Rows.Add("Reg-P0103", "Bacon", "Pizza", mainform.txtSRBac.Text)
        dt.Rows.Add("Med-P0103", "Bacon", "Pizza", mainform.txtSMBac.Text)
        dt.Rows.Add("Lar-P0103", "Bacon", "Pizza", mainform.txtSLBac.Text)
        dt.Rows.Add("Reg-P0104", "Chili Pepper", "Pizza", mainform.txtSRChi.Text)
        dt.Rows.Add("Med-P0104", "Chili Pepper", "Pizza", mainform.txtSMChi.Text)
        dt.Rows.Add("Lar-P0104", "Chili Pepper", "Pizza", mainform.txtSLChi.Text)
        dt.Rows.Add("Reg-P0105", "Mushroom", "Pizza", mainform.txtSRMus.Text)
        dt.Rows.Add("Med-P0105", "Mushroom", "Pizza", mainform.txtSMMus.Text)
        dt.Rows.Add("Lar-P0105", "Mushroom", "Pizza", mainform.txtSLMus.Text)
        dt.Rows.Add("Reg-P0106", "Vegetarian", "Pizza", mainform.txtSRVeg.Text)
        dt.Rows.Add("Med-P0106", "Vegetarian", "Pizza", mainform.txtSMVeg.Text)
        dt.Rows.Add("Lar-P0106", "Vegetarian", "Pizza", mainform.txtSLVeg.Text)
        dt.Rows.Add("Reg-P0107", "Veronese", "Pizza", mainform.txtSRVer.Text)
        dt.Rows.Add("Med-P0107", "Veronese", "Pizza", mainform.txtSMVer.Text)
        dt.Rows.Add("Lar-P0107", "Veronese", "Pizza", mainform.txtSLVer.Text)
        dt.Rows.Add("B0102", "Rolls", "Bread", mainform.txtSRolls.Text)
        dt.Rows.Add("B0103", "French Bread", "Bread", mainform.txtSFrench.Text)
        dt.Rows.Add("B0104", "Wheat Bread", "Bread", mainform.txtSWheat.Text)
        dt.Rows.Add("B0105", "White Bread", "Bread", mainform.txtSWhite.Text)
        dt.Rows.Add("B0106", "Banana Bread", "Bread", mainform.txtSBanana.Text)
        dt.Rows.Add("B0107", "Hotdog Bun", "Bread", mainform.txtSHotdog.Text)
        dt.Rows.Add("Reg-C0102", "Espresso", "Coffee", mainform.txtSREsp.Text)
        dt.Rows.Add("Med-C0102", "Espresso", "Coffee", mainform.txtSMEsp.Text)
        dt.Rows.Add("Lar-C0102", "Espresso", "Coffee", mainform.txtSLEsp.Text)
        dt.Rows.Add("Reg-C0103", "Doppio", "Coffee", mainform.txtSRDop.Text)
        dt.Rows.Add("Med-C0103", "Doppio", "Coffee", mainform.txtSMDop.Text)
        dt.Rows.Add("Lar-C0103", "Doppio", "Coffee", mainform.txtSLDop.Text)
        dt.Rows.Add("Reg-C0104", "Americano", "Coffee", mainform.txtSRAme.Text)
        dt.Rows.Add("Med-C0104", "Americano", "Coffee", mainform.txtSMAme.Text)
        dt.Rows.Add("Lar-C0104", "Americano", "Coffee", mainform.txtSLAme.Text)
        dt.Rows.Add("Reg-C0105", "Cappuccino", "Coffee", mainform.txtSRCap.Text)
        dt.Rows.Add("Med-C0105", "Cappuccino", "Coffee", mainform.txtSMCap.Text)
        dt.Rows.Add("Lar-C0105", "Cappuccino", "Coffee", mainform.txtSLCap.Text)
        dt.Rows.Add("Reg-C0106", "Latte", "Coffee", mainform.txtSRLat.Text)
        dt.Rows.Add("Med-C0106", "Latte", "Coffee", mainform.txtSMLat.Text)
        dt.Rows.Add("Lar-C0106", "Latte", "Coffee", mainform.txtSLLat.Text)
        dt.Rows.Add("Reg-C0107", "Macchiato", "Coffee", mainform.txtSRMac.Text)
        dt.Rows.Add("Med-C0107", "Macchiato", "Coffee", mainform.txtSMMac.Text)
        dt.Rows.Add("Lar-C0107", "Macchiato", "Coffee", mainform.txtSLMac.Text)

        dtRestock.DataSource = dt

        Status()

    End Sub

    Function getUserInput()

        Dim input As Integer
        Dim userinput = InputBox("Enter Quantity ", "Restock")
        validInput = Integer.TryParse(userinput, input)


        Return input
    End Function

    Sub Status()

        For Index As Integer = 0 To dtRestock.Rows.Count - 1

            current = dtRestock.Rows(Index).Cells(3).Value

            If current = 0 Then

                dtRestock.Rows(Index).Cells(4).Value = "Out of Stock"
                dtRestock.Rows(Index).DefaultCellStyle.ForeColor = Color.White
                dtRestock.Rows(Index).DefaultCellStyle.BackColor = Color.DarkRed

            ElseIf current > 5 And current <= 10 Then

                dtRestock.Rows(Index).Cells(4).Value = "Warning"
                dtRestock.Rows(Index).DefaultCellStyle.ForeColor = Color.Black
                dtRestock.Rows(Index).DefaultCellStyle.BackColor = Color.Yellow

            ElseIf current > 0 And current <= 5 Then

                dtRestock.Rows(Index).Cells(4).Value = "Low on Stock"
                dtRestock.Rows(Index).DefaultCellStyle.ForeColor = Color.White
                dtRestock.Rows(Index).DefaultCellStyle.BackColor = Color.Red

            Else

                dtRestock.Rows(Index).Cells(4).Value = "Sufficient"
                dtRestock.Rows(Index).DefaultCellStyle.ForeColor = Color.Black
                dtRestock.Rows(Index).DefaultCellStyle.BackColor = Color.White

            End If

        Next

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If dtRestock.Rows.Count > 0 Then

            For Each row As DataGridViewRow In dtRestock.SelectedRows

                If row.Cells(0).Value = "Reg-P0102" Then
                    Dim mozaup = getUserInput()

                    While mozaup < 0 Or validInput = False Or mozaup = 0

                        If mozaup < 0 Or validInput = False Or mozaup = 0 Then
                            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                            Exit Sub
                        Else
                            MsgBox("Try again!")
                        End If

                        mozaup = getUserInput()

                    End While

                    If MessageBox.Show("Are you sure you want to add stock(s)?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        If row.Cells(0).Value = "Reg-P0102" Then
                            row.Cells(3).Value = row.Cells(3).Value + mozaup
                            mozadd = mainform.mozstock
                            mainform.mozstock = mozadd + mozaup
                            mozv = mainform.mozgrid
                            mainform.mozgrid = mozv + mozaup
                            stock = mainform.txtSRMoz.Text
                            mainform.txtSRMoz.Text = stock + mozaup

                            current = row.Cells(3).Value
                            If current > 5 And current <= 10 Then
                                row.Cells(4).Value = "Warning"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.Yellow
                            ElseIf current > 0 And current <= 5 Then
                                row.Cells(4).Value = "Low On Stock"
                                row.DefaultCellStyle.ForeColor = Color.White
                                row.DefaultCellStyle.BackColor = Color.Red
                            Else
                                row.Cells(4).Value = "Sufficient"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.White
                            End If

                            If mainform.txtSRMoz.Text > 5 And mainform.txtSRMoz.Text <= 10 Then
                                mainform.txtSRMoz.BackColor = Color.Yellow
                                mainform.txtSRMoz.ForeColor = Color.Black

                            ElseIf mainform.txtSRMoz.Text > 0 And mainform.txtSRMoz.Text <= 5 Then
                                mainform.txtSRMoz.BackColor = Color.Red
                                mainform.txtSRMoz.ForeColor = Color.White
                            Else
                                mainform.txtSRMoz.BackColor = SystemColors.Control
                                mainform.txtSRMoz.ForeColor = Color.Black
                            End If
                            mainform.btnMozzarella.Enabled = True
                            mainform.picMoz.Hide()

                            MsgBox("Added Succesfully")
                            Exit Sub
                        End If

                    Else

                        MsgBox("Cancelled")
                        Exit Sub
                    End If
                End If

                If row.Cells(0).Value = "Med-P0102" Then
                    Dim mmozaup = getUserInput()

                    While mmozaup < 0 Or validInput = False Or mmozaup = 0

                        If mmozaup < 0 Or validInput = False Or mmozaup = 0 Then
                            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                            Exit Sub
                        Else
                            MsgBox("Try again!")
                        End If

                        mmozaup = getUserInput()

                    End While

                    If MessageBox.Show("Are you sure you want to add stock(s)?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        If row.Cells(0).Value = "Med-P0102" Then
                            row.Cells(3).Value = row.Cells(3).Value + mmozaup
                            mmozadd = mainform.mozmstock
                            mainform.mozmstock = mmozadd + mmozaup
                            mmozv = mainform.mmozgrid
                            mainform.mmozgrid = mmozv + mmozaup
                            stock = mainform.txtSMMoz.Text
                            mainform.txtSMMoz.Text = stock + mmozaup

                            current = row.Cells(3).Value
                            If current > 5 And current <= 10 Then
                                row.Cells(4).Value = "Warning"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.Yellow
                            ElseIf current > 0 And current <= 5 Then
                                row.Cells(4).Value = "Low On Stock"
                                row.DefaultCellStyle.ForeColor = Color.White
                                row.DefaultCellStyle.BackColor = Color.Red
                            Else
                                row.Cells(4).Value = "Sufficient"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.White
                            End If

                            If mainform.txtSMMoz.Text > 5 And mainform.txtSMMoz.Text <= 10 Then
                                mainform.txtSRMoz.BackColor = Color.Yellow
                                mainform.txtSRMoz.ForeColor = Color.Black

                            ElseIf mainform.txtSMMoz.Text > 0 And mainform.txtSMMoz.Text <= 5 Then
                                mainform.txtSMMoz.BackColor = Color.Red
                                mainform.txtSMMoz.ForeColor = Color.White
                            Else
                                mainform.txtSMMoz.BackColor = SystemColors.Control
                                mainform.txtSMMoz.ForeColor = Color.Black
                            End If
                            mainform.btnMozzarella.Enabled = True
                            mainform.picMoz.Hide()

                            MsgBox("Added Succesfully")
                            Exit Sub
                        End If

                    Else

                        MsgBox("Cancelled")
                        Exit Sub
                    End If
                End If

                If row.Cells(0).Value = "Lar-P0102" Then
                    Dim lmozaup = getUserInput()

                    While lmozaup < 0 Or validInput = False Or lmozaup = 0

                        If lmozaup < 0 Or validInput = False Or lmozaup = 0 Then
                            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                            Exit Sub
                        Else
                            MsgBox("Try again!")
                        End If

                        lmozaup = getUserInput()

                    End While

                    If MessageBox.Show("Are you sure you want to add stock(s)?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        If row.Cells(0).Value = "Lar-P0102" Then
                            row.Cells(3).Value = row.Cells(3).Value + lmozaup
                            lmozadd = mainform.mozlstock
                            mainform.mozlstock = lmozadd + lmozaup
                            lmozv = mainform.lmozgrid
                            mainform.lmozgrid = lmozv + lmozaup
                            stock = mainform.txtSLMoz.Text
                            mainform.txtSLMoz.Text = stock + lmozaup

                            current = row.Cells(3).Value
                            If current > 5 And current <= 10 Then
                                row.Cells(4).Value = "Warning"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.Yellow
                            ElseIf current > 0 And current <= 5 Then
                                row.Cells(4).Value = "Low On Stock"
                                row.DefaultCellStyle.ForeColor = Color.White
                                row.DefaultCellStyle.BackColor = Color.Red
                            Else
                                row.Cells(4).Value = "Sufficient"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.White
                            End If

                            If mainform.txtSLMoz.Text > 5 And mainform.txtSLMoz.Text <= 10 Then
                                mainform.txtSLMoz.BackColor = Color.Yellow
                                mainform.txtSLMoz.ForeColor = Color.Black

                            ElseIf mainform.txtSLMoz.Text > 0 And mainform.txtSLMoz.Text <= 5 Then
                                mainform.txtSLMoz.BackColor = Color.Red
                                mainform.txtSLMoz.ForeColor = Color.White
                            Else
                                mainform.txtSLMoz.BackColor = SystemColors.Control
                                mainform.txtSLMoz.ForeColor = Color.Black
                            End If
                            mainform.btnMozzarella.Enabled = True
                            mainform.picMoz.Hide()

                            MsgBox("Added Succesfully")
                            Exit Sub
                        End If

                    Else

                        MsgBox("Cancelled")
                        Exit Sub
                    End If
                End If

                If row.Cells(0).Value = "Reg-P0103" Then
                    Dim bacup = getUserInput()

                    While bacup < 0 Or validInput = False Or bacup = 0

                        If bacup < 0 Or validInput = False Or bacup = 0 Then
                            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                            Exit Sub
                        Else
                            MsgBox("Try again!")
                        End If

                        bacup = getUserInput()

                    End While

                    If MessageBox.Show("Are you sure you want to add stock(s)?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        If row.Cells(0).Value = "Reg-P0103" Then
                            row.Cells(3).Value = row.Cells(3).Value + bacup
                            bacadd = mainform.bacstock
                            mainform.bacstock = bacadd + bacup
                            bacv = mainform.bacgrid
                            mainform.bacgrid = bacv + bacup
                            stock = mainform.txtSRBac.Text
                            mainform.txtSRBac.Text = stock + bacup

                            current = row.Cells(3).Value
                            If current > 5 And current <= 10 Then
                                row.Cells(4).Value = "Warning"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.Yellow
                            ElseIf current > 0 And current <= 5 Then
                                row.Cells(4).Value = "Low On Stock"
                                row.DefaultCellStyle.ForeColor = Color.White
                                row.DefaultCellStyle.BackColor = Color.Red
                            Else
                                row.Cells(4).Value = "Sufficient"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.White
                            End If

                            If mainform.txtSRBac.Text > 5 And mainform.txtSRBac.Text <= 10 Then
                                mainform.txtSRBac.BackColor = Color.Yellow
                                mainform.txtSRBac.ForeColor = Color.Black

                            ElseIf mainform.txtSRBac.Text > 0 And mainform.txtSRBac.Text <= 5 Then
                                mainform.txtSRBac.BackColor = Color.Red
                                mainform.txtSRBac.ForeColor = Color.White
                            Else
                                mainform.txtSRBac.BackColor = SystemColors.Control
                                mainform.txtSRBac.ForeColor = Color.Black
                            End If
                            mainform.btnBacon.Enabled = True
                            mainform.picBac.Hide()
                            'mainform.compute()

                            MsgBox("Added Succesfully")
                            Exit Sub
                        End If

                    Else

                        MsgBox("Cancelled")
                        Exit Sub
                    End If
                End If

                If row.Cells(0).Value = "Med-P0103" Then
                    Dim mbacup = getUserInput()

                    While mbacup < 0 Or validInput = False Or mbacup = 0

                        If mbacup < 0 Or validInput = False Or mbacup = 0 Then
                            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                            Exit Sub
                        Else
                            MsgBox("Try again!")
                        End If

                        mbacup = getUserInput()

                    End While

                    If MessageBox.Show("Are you sure you want to add stock(s)?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        If row.Cells(0).Value = "Med-P0103" Then
                            row.Cells(3).Value = row.Cells(3).Value + mbacup
                            mbacadd = mainform.mbacstock
                            mainform.mbacstock = mbacadd + mbacup
                            mbacv = mainform.mbacgrid
                            mainform.mbacgrid = mbacv + mbacup
                            stock = mainform.txtSMBac.Text
                            mainform.txtSMBac.Text = stock + mbacup

                            current = row.Cells(3).Value
                            If current > 5 And current <= 10 Then
                                row.Cells(4).Value = "Warning"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.Yellow
                            ElseIf current > 0 And current <= 5 Then
                                row.Cells(4).Value = "Low On Stock"
                                row.DefaultCellStyle.ForeColor = Color.White
                                row.DefaultCellStyle.BackColor = Color.Red
                            Else
                                row.Cells(4).Value = "Sufficient"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.White
                            End If

                            If mainform.txtSMBac.Text > 5 And mainform.txtSMBac.Text <= 10 Then
                                mainform.txtSMBac.BackColor = Color.Yellow
                                mainform.txtSMBac.ForeColor = Color.Black

                            ElseIf mainform.txtSMBac.Text > 0 And mainform.txtSMBac.Text <= 5 Then
                                mainform.txtSMBac.BackColor = Color.Red
                                mainform.txtSMBac.ForeColor = Color.White
                            Else
                                mainform.txtSMBac.BackColor = SystemColors.Control
                                mainform.txtSMBac.ForeColor = Color.Black
                            End If
                            mainform.btnBacon.Enabled = True
                            mainform.picBac.Hide()
                            'mainform.compute()

                            MsgBox("Added Succesfully")
                            Exit Sub
                        End If

                    Else

                        MsgBox("Cancelled")
                        Exit Sub
                    End If
                End If

                If row.Cells(0).Value = "Lar-P0103" Then
                    Dim lbacup = getUserInput()

                    While lbacup < 0 Or validInput = False Or lbacup = 0

                        If lbacup < 0 Or validInput = False Or lbacup = 0 Then
                            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                            Exit Sub
                        Else
                            MsgBox("Try again!")
                        End If

                        lbacup = getUserInput()

                    End While

                    If MessageBox.Show("Are you sure you want to add stock(s)?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        If row.Cells(0).Value = "Lar-P0103" Then
                            row.Cells(3).Value = row.Cells(3).Value + lbacup
                            lbacadd = mainform.lbacstock
                            mainform.lbacstock = lbacadd + lbacup
                            lbacv = mainform.lbacgrid
                            mainform.lbacgrid = lbacv + lbacup
                            stock = mainform.txtSLBac.Text
                            mainform.txtSLBac.Text = stock + lbacup

                            current = row.Cells(3).Value
                            If current > 5 And current <= 10 Then
                                row.Cells(4).Value = "Warning"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.Yellow
                            ElseIf current > 0 And current <= 5 Then
                                row.Cells(4).Value = "Low On Stock"
                                row.DefaultCellStyle.ForeColor = Color.White
                                row.DefaultCellStyle.BackColor = Color.Red
                            Else
                                row.Cells(4).Value = "Sufficient"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.White
                            End If

                            If mainform.txtSLBac.Text > 5 And mainform.txtSLBac.Text <= 10 Then
                                mainform.txtSLBac.BackColor = Color.Yellow
                                mainform.txtSLBac.ForeColor = Color.Black

                            ElseIf mainform.txtSLBac.Text > 0 And mainform.txtSLBac.Text <= 5 Then
                                mainform.txtSLBac.BackColor = Color.Red
                                mainform.txtSLBac.ForeColor = Color.White
                            Else
                                mainform.txtSLBac.BackColor = SystemColors.Control
                                mainform.txtSLBac.ForeColor = Color.Black
                            End If
                            mainform.btnBacon.Enabled = True
                            mainform.picBac.Hide()
                            'mainform.compute()

                            MsgBox("Added Succesfully")
                            Exit Sub
                        End If

                    Else

                        MsgBox("Cancelled")
                        Exit Sub
                    End If
                End If

                If row.Cells(0).Value = "Reg-P0104" Then
                    Dim chiup = getUserInput()

                    While chiup < 0 Or validInput = False Or chiup = 0

                        If chiup < 0 Or validInput = False Or chiup = 0 Then
                            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                            Exit Sub
                        Else
                            MsgBox("Try again!")
                        End If

                        chiup = getUserInput()

                    End While

                    If MessageBox.Show("Are you sure you want to add stock(s)?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        If row.Cells(0).Value = "Reg-P0104" Then
                            row.Cells(3).Value = row.Cells(3).Value + chiup
                            chiadd = mainform.chistock
                            mainform.chistock = chiadd + chiup
                            chiv = mainform.chigrid
                            mainform.chigrid = chiv + chiup
                            stock = mainform.txtSRChi.Text
                            mainform.txtSRChi.Text = stock + chiup

                            current = row.Cells(3).Value
                            If current > 5 And current <= 10 Then
                                row.Cells(4).Value = "Warning"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.Yellow
                            ElseIf current > 0 And current <= 5 Then
                                row.Cells(4).Value = "Low On Stock"
                                row.DefaultCellStyle.ForeColor = Color.White
                                row.DefaultCellStyle.BackColor = Color.Red
                            Else
                                row.Cells(4).Value = "Sufficient"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.White
                            End If

                            If mainform.txtSRChi.Text > 5 And mainform.txtSRChi.Text <= 10 Then
                                mainform.txtSRChi.BackColor = Color.Yellow
                                mainform.txtSRChi.ForeColor = Color.Black

                            ElseIf mainform.txtSRChi.Text > 0 And mainform.txtSRChi.Text <= 5 Then
                                mainform.txtSRChi.BackColor = Color.Red
                                mainform.txtSRChi.ForeColor = Color.White
                            Else
                                mainform.txtSRChi.BackColor = SystemColors.Control
                                mainform.txtSRChi.ForeColor = Color.Black
                            End If
                            mainform.btnChili.Enabled = True
                            mainform.picChili.Hide()

                            MsgBox("Added Succesfully")
                            Exit Sub
                        End If

                    Else

                        MsgBox("Cancelled")
                        Exit Sub
                    End If
                End If

                If row.Cells(0).Value = "Med-P0104" Then
                    Dim mchiup = getUserInput()

                    While mchiup < 0 Or validInput = False Or mchiup = 0

                        If mchiup < 0 Or validInput = False Or mchiup = 0 Then
                            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                            Exit Sub
                        Else
                            MsgBox("Try again!")
                        End If

                        mchiup = getUserInput()

                    End While

                    If MessageBox.Show("Are you sure you want to add stock(s)?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        If row.Cells(0).Value = "Med-P0104" Then
                            row.Cells(3).Value = row.Cells(3).Value + mchiup
                            mchiadd = mainform.mchistock
                            mainform.mchistock = mchiadd + mchiup
                            mchiv = mainform.mchigrid
                            mainform.mchigrid = mchiv + mchiup
                            stock = mainform.txtSMChi.Text
                            mainform.txtSMChi.Text = stock + mchiup

                            current = row.Cells(3).Value
                            If current > 5 And current <= 10 Then
                                row.Cells(4).Value = "Warning"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.Yellow
                            ElseIf current > 0 And current <= 5 Then
                                row.Cells(4).Value = "Low On Stock"
                                row.DefaultCellStyle.ForeColor = Color.White
                                row.DefaultCellStyle.BackColor = Color.Red
                            Else
                                row.Cells(4).Value = "Sufficient"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.White
                            End If

                            If mainform.txtSMChi.Text > 5 And mainform.txtSMChi.Text <= 10 Then
                                mainform.txtSMChi.BackColor = Color.Yellow
                                mainform.txtSMChi.ForeColor = Color.Black

                            ElseIf mainform.txtSMChi.Text > 0 And mainform.txtSMChi.Text <= 5 Then
                                mainform.txtSMChi.BackColor = Color.Red
                                mainform.txtSMChi.ForeColor = Color.White
                            Else
                                mainform.txtSMChi.BackColor = SystemColors.Control
                                mainform.txtSMChi.ForeColor = Color.Black
                            End If
                            mainform.btnChili.Enabled = True
                            mainform.picChili.Hide()

                            MsgBox("Added Succesfully")
                            Exit Sub
                        End If

                    Else

                        MsgBox("Cancelled")
                        Exit Sub
                    End If
                End If

                If row.Cells(0).Value = "Lar-P0104" Then
                    Dim lchiup = getUserInput()

                    While lchiup < 0 Or validInput = False Or lchiup = 0

                        If lchiup < 0 Or validInput = False Or lchiup = 0 Then
                            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                            Exit Sub
                        Else
                            MsgBox("Try again!")
                        End If

                        lchiup = getUserInput()

                    End While

                    If MessageBox.Show("Are you sure you want to add stock(s)?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        If row.Cells(0).Value = "Lar-P0104" Then
                            row.Cells(3).Value = row.Cells(3).Value + lchiup
                            lchiadd = mainform.lchistock
                            mainform.lchistock = lchiadd + lchiup
                            lchiv = mainform.lchigrid
                            mainform.lchigrid = lchiv + lchiup
                            stock = mainform.txtSLChi.Text
                            mainform.txtSLChi.Text = stock + lchiup

                            current = row.Cells(3).Value
                            If current > 5 And current <= 10 Then
                                row.Cells(4).Value = "Warning"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.Yellow
                            ElseIf current > 0 And current <= 5 Then
                                row.Cells(4).Value = "Low On Stock"
                                row.DefaultCellStyle.ForeColor = Color.White
                                row.DefaultCellStyle.BackColor = Color.Red
                            Else
                                row.Cells(4).Value = "Sufficient"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.White
                            End If

                            If mainform.txtSLChi.Text > 5 And mainform.txtSLChi.Text <= 10 Then
                                mainform.txtSLChi.BackColor = Color.Yellow
                                mainform.txtSLChi.ForeColor = Color.Black

                            ElseIf mainform.txtSLChi.Text > 0 And mainform.txtSLChi.Text <= 5 Then
                                mainform.txtSLChi.BackColor = Color.Red
                                mainform.txtSLChi.ForeColor = Color.White
                            Else
                                mainform.txtSLChi.BackColor = SystemColors.Control
                                mainform.txtSLChi.ForeColor = Color.Black
                            End If
                            mainform.btnChili.Enabled = True
                            mainform.picChili.Hide()

                            MsgBox("Added Succesfully")
                            Exit Sub
                        End If

                    Else

                        MsgBox("Cancelled")
                        Exit Sub
                    End If
                End If

                If row.Cells(0).Value = "Reg-P0105" Then
                    Dim musup = getUserInput()

                    While musup < 0 Or validInput = False Or musup = 0

                        If musup < 0 Or validInput = False Or musup = 0 Then
                            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                            Exit Sub
                        Else
                            MsgBox("Try again!")
                        End If

                        musup = getUserInput()

                    End While

                    If MessageBox.Show("Are you sure you want to add stock(s)?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        If row.Cells(0).Value = "Reg-P0105" Then
                            row.Cells(3).Value = row.Cells(3).Value + musup
                            musadd = mainform.musstock
                            mainform.musstock = musadd + musup
                            musv = mainform.musgrid
                            mainform.musgrid = musv + musup
                            stock = mainform.txtSRMus.Text
                            mainform.txtSRMus.Text = stock + musup

                            current = row.Cells(3).Value
                            If current > 5 And current <= 10 Then
                                row.Cells(4).Value = "Warning"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.Yellow
                            ElseIf current > 0 And current <= 5 Then
                                row.Cells(4).Value = "Low On Stock"
                                row.DefaultCellStyle.ForeColor = Color.White
                                row.DefaultCellStyle.BackColor = Color.Red
                            Else
                                row.Cells(4).Value = "Sufficient"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.White
                            End If

                            If mainform.txtSRMus.Text > 5 And mainform.txtSRMus.Text <= 10 Then
                                mainform.txtSRMus.BackColor = Color.Yellow
                                mainform.txtSRMus.ForeColor = Color.Black

                            ElseIf mainform.txtSRMus.Text > 0 And mainform.txtSRMus.Text <= 5 Then
                                mainform.txtSRMus.BackColor = Color.Red
                                mainform.txtSRMus.ForeColor = Color.White
                            Else
                                mainform.txtSRMus.BackColor = SystemColors.Control
                                mainform.txtSRMus.ForeColor = Color.Black
                            End If
                            mainform.btnMushroom.Enabled = True
                            mainform.picMush.Hide()

                            MsgBox("Added Succesfully")
                            Exit Sub
                        End If

                    Else

                        MsgBox("Cancelled")
                        Exit Sub
                    End If
                End If

                If row.Cells(0).Value = "Med-P0105" Then
                    Dim mmusup = getUserInput()

                    While mmusup < 0 Or validInput = False Or mmusup = 0

                        If mmusup < 0 Or validInput = False Or mmusup = 0 Then
                            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                            Exit Sub
                        Else
                            MsgBox("Try again!")
                        End If

                        mmusup = getUserInput()

                    End While

                    If MessageBox.Show("Are you sure you want to add stock(s)?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        If row.Cells(0).Value = "Med-P0105" Then
                            row.Cells(3).Value = row.Cells(3).Value + mmusup
                            mmusadd = mainform.mmusstock
                            mainform.mmusstock = mmusadd + mmusup
                            mmusv = mainform.mmusgrid
                            mainform.mmusgrid = mmusv + mmusup
                            stock = mainform.txtSMMus.Text
                            mainform.txtSMMus.Text = stock + mmusup

                            current = row.Cells(3).Value
                            If current > 5 And current <= 10 Then
                                row.Cells(4).Value = "Warning"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.Yellow
                            ElseIf current > 0 And current <= 5 Then
                                row.Cells(4).Value = "Low On Stock"
                                row.DefaultCellStyle.ForeColor = Color.White
                                row.DefaultCellStyle.BackColor = Color.Red
                            Else
                                row.Cells(4).Value = "Sufficient"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.White
                            End If

                            If mainform.txtSMMus.Text > 5 And mainform.txtSMMus.Text <= 10 Then
                                mainform.txtSMMus.BackColor = Color.Yellow
                                mainform.txtSMMus.ForeColor = Color.Black

                            ElseIf mainform.txtSMMus.Text > 0 And mainform.txtSMMus.Text <= 5 Then
                                mainform.txtSMMus.BackColor = Color.Red
                                mainform.txtSMMus.ForeColor = Color.White
                            Else
                                mainform.txtSMMus.BackColor = SystemColors.Control
                                mainform.txtSMMus.ForeColor = Color.Black
                            End If

                            mainform.btnMushroom.Enabled = True
                            mainform.picMush.Hide()

                            MsgBox("Added Succesfully")
                            Exit Sub
                        End If

                    Else

                        MsgBox("Cancelled")
                        Exit Sub
                    End If
                End If

                If row.Cells(0).Value = "Lar-P0105" Then
                    Dim lmusup = getUserInput()

                    While lmusup < 0 Or validInput = False Or lmusup = 0

                        If lmusup < 0 Or validInput = False Or lmusup = 0 Then
                            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                            Exit Sub
                        Else
                            MsgBox("Try again!")
                        End If

                        lmusup = getUserInput()

                    End While

                    If MessageBox.Show("Are you sure you want to add stock(s)?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        If row.Cells(0).Value = "Lar-P0105" Then
                            row.Cells(3).Value = row.Cells(3).Value + lmusup
                            lmusadd = mainform.lmusstock
                            mainform.lmusstock = lmusadd + lmusup
                            lmusv = mainform.lmusgrid
                            mainform.lmusgrid = lmusv + lmusup
                            stock = mainform.txtSLMus.Text
                            mainform.txtSLMus.Text = stock + lmusup

                            current = row.Cells(3).Value
                            If current > 5 And current <= 10 Then
                                row.Cells(4).Value = "Warning"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.Yellow
                            ElseIf current > 0 And current <= 5 Then
                                row.Cells(4).Value = "Low On Stock"
                                row.DefaultCellStyle.ForeColor = Color.White
                                row.DefaultCellStyle.BackColor = Color.Red
                            Else
                                row.Cells(4).Value = "Sufficient"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.White
                            End If

                            If mainform.txtSLMus.Text > 5 And mainform.txtSLMus.Text <= 10 Then
                                mainform.txtSLMus.BackColor = Color.Yellow
                                mainform.txtSLMus.ForeColor = Color.Black

                            ElseIf mainform.txtSLMus.Text > 0 And mainform.txtSLMus.Text <= 5 Then
                                mainform.txtSLMus.BackColor = Color.Red
                                mainform.txtSLMus.ForeColor = Color.White
                            Else
                                mainform.txtSLMus.BackColor = SystemColors.Control
                                mainform.txtSLMus.ForeColor = Color.Black
                            End If
                            mainform.btnMushroom.Enabled = True
                            mainform.picMush.Hide()

                            MsgBox("Added Succesfully")
                            Exit Sub
                        End If

                    Else

                        MsgBox("Cancelled")
                        Exit Sub
                    End If
                End If

                If row.Cells(0).Value = "Reg-P0106" Then
                    Dim vegup = getUserInput()

                    While vegup < 0 Or validInput = False Or vegup = 0

                        If vegup < 0 Or validInput = False Or vegup = 0 Then
                            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                            Exit Sub
                        Else
                            MsgBox("Try again!")
                        End If

                        vegup = getUserInput()

                    End While

                    If MessageBox.Show("Are you sure you want to add stock(s)?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        If row.Cells(0).Value = "Reg-P0106" Then
                            row.Cells(3).Value = row.Cells(3).Value + vegup
                            vegadd = mainform.vegstock
                            mainform.vegstock = vegadd + vegup
                            vegv = mainform.veggrid
                            mainform.veggrid = vegv + vegup
                            stock = mainform.txtSRVeg.Text
                            mainform.txtSRVeg.Text = stock + vegup

                            current = row.Cells(3).Value
                            If current > 5 And current <= 10 Then
                                row.Cells(4).Value = "Warning"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.Yellow
                            ElseIf current > 0 And current <= 5 Then
                                row.Cells(4).Value = "Low On Stock"
                                row.DefaultCellStyle.ForeColor = Color.White
                                row.DefaultCellStyle.BackColor = Color.Red
                            Else
                                row.Cells(4).Value = "Sufficient"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.White
                            End If

                            If mainform.txtSRVeg.Text > 5 And mainform.txtSRVeg.Text <= 10 Then
                                mainform.txtSRVeg.BackColor = Color.Yellow
                                mainform.txtSRVeg.ForeColor = Color.Black

                            ElseIf mainform.txtSRVeg.Text > 0 And mainform.txtSRVeg.Text <= 5 Then
                                mainform.txtSRVeg.BackColor = Color.Red
                                mainform.txtSRVeg.ForeColor = Color.White
                            Else
                                mainform.txtSRVeg.BackColor = SystemColors.Control
                                mainform.txtSRVeg.ForeColor = Color.Black
                            End If

                            mainform.rbtnRegularVeg.Enabled = True
                            mainform.btnVegetarian.Enabled = True
                            mainform.picVege.Hide()

                            MsgBox("Added Succesfully")
                            Exit Sub
                        End If
                    End If
                End If

                If row.Cells(0).Value = "Med-P0106" Then
                    Dim mvegup = getUserInput()

                    While mvegup < 0 Or validInput = False Or mvegup = 0

                        If mvegup < 0 Or validInput = False Or mvegup = 0 Then
                            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                            Exit Sub
                        Else
                            MsgBox("Try again!")
                        End If

                        mvegup = getUserInput()

                    End While

                    If MessageBox.Show("Are you sure you want to add stock(s)?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        If row.Cells(0).Value = "Med-P0106" Then
                            row.Cells(3).Value = row.Cells(3).Value + mvegup
                            mvegadd = mainform.mvegstock
                            mainform.mvegstock = mvegadd + mvegup
                            mvegv = mainform.mveggrid
                            mainform.mveggrid = mvegv + mvegup
                            stock = mainform.txtSMVeg.Text
                            mainform.txtSMVeg.Text = stock + mvegup

                            current = row.Cells(3).Value
                            If current > 5 And current <= 10 Then
                                row.Cells(4).Value = "Warning"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.Yellow
                            ElseIf current > 0 And current <= 5 Then
                                row.Cells(4).Value = "Low On Stock"
                                row.DefaultCellStyle.ForeColor = Color.White
                                row.DefaultCellStyle.BackColor = Color.Red
                            Else
                                row.Cells(4).Value = "Sufficient"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.White
                            End If

                            If mainform.txtSMVeg.Text > 5 And mainform.txtSMVeg.Text <= 10 Then
                                mainform.txtSMVeg.BackColor = Color.Yellow
                                mainform.txtSMVeg.ForeColor = Color.Black

                            ElseIf mainform.txtSMVeg.Text > 0 And mainform.txtSMVeg.Text <= 5 Then
                                mainform.txtSMVeg.BackColor = Color.Red
                                mainform.txtSMVeg.ForeColor = Color.White
                            Else
                                mainform.txtSMVeg.BackColor = SystemColors.Control
                                mainform.txtSMVeg.ForeColor = Color.Black
                            End If
                            mainform.btnVegetarian.Enabled = True
                            mainform.picVege.Hide()

                            MsgBox("Added Succesfully")
                            Exit Sub
                        End If
                    End If
                End If

                If row.Cells(0).Value = "Lar-P0106" Then
                    Dim lvegup = getUserInput()

                    While lvegup < 0 Or validInput = False Or lvegup = 0

                        If lvegup < 0 Or validInput = False Or lvegup = 0 Then
                            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                            Exit Sub
                        Else
                            MsgBox("Try again!")
                        End If

                        lvegup = getUserInput()

                    End While

                    If MessageBox.Show("Are you sure you want to add stock(s)?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        If row.Cells(0).Value = "Lar-P0106" Then
                            row.Cells(3).Value = row.Cells(3).Value + lvegup
                            lvegadd = mainform.lvegstock
                            mainform.lvegstock = lvegadd + lvegup
                            lvegv = mainform.lveggrid
                            mainform.lveggrid = lvegv + lvegup
                            stock = mainform.txtSLVeg.Text
                            mainform.txtSLVeg.Text = stock + lvegup

                            current = row.Cells(3).Value
                            If current > 5 And current <= 10 Then
                                row.Cells(4).Value = "Warning"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.Yellow
                            ElseIf current > 0 And current <= 5 Then
                                row.Cells(4).Value = "Low On Stock"
                                row.DefaultCellStyle.ForeColor = Color.White
                                row.DefaultCellStyle.BackColor = Color.Red
                            Else
                                row.Cells(4).Value = "Sufficient"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.White
                            End If

                            If mainform.txtSLVeg.Text > 5 And mainform.txtSLVeg.Text <= 10 Then
                                mainform.txtSLVeg.BackColor = Color.Yellow
                                mainform.txtSLVeg.ForeColor = Color.Black

                            ElseIf mainform.txtSLVeg.Text > 0 And mainform.txtSLVeg.Text <= 5 Then
                                mainform.txtSLVeg.BackColor = Color.Red
                                mainform.txtSLVeg.ForeColor = Color.White
                            Else
                                mainform.txtSLVeg.BackColor = SystemColors.Control
                                mainform.txtSLVeg.ForeColor = Color.Black
                            End If
                            mainform.btnVegetarian.Enabled = True
                            mainform.picVege.Hide()

                            MsgBox("Added Succesfully")
                            Exit Sub
                        End If
                    End If
                End If

                If row.Cells(0).Value = "Reg-P0107" Then
                    Dim verup = getUserInput()

                    While verup < 0 Or validInput = False Or verup = 0

                        If verup < 0 Or validInput = False Or verup = 0 Then
                            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                            Exit Sub
                        Else
                            MsgBox("Try again!")
                        End If

                        verup = getUserInput()

                    End While

                    If MessageBox.Show("Are you sure you want to add stock(s)?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        If row.Cells(0).Value = "Reg-P0107" Then
                            row.Cells(3).Value = row.Cells(3).Value + verup
                            veradd = mainform.verstock
                            mainform.verstock = veradd + verup
                            verv = mainform.vergrid
                            mainform.vergrid = verv + verup
                            stock = mainform.txtSRVer.Text
                            mainform.txtSRVer.Text = stock + verup

                            current = row.Cells(3).Value
                            If current > 5 And current <= 10 Then
                                row.Cells(4).Value = "Warning"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.Yellow
                            ElseIf current > 0 And current <= 5 Then
                                row.Cells(4).Value = "Low On Stock"
                                row.DefaultCellStyle.ForeColor = Color.White
                                row.DefaultCellStyle.BackColor = Color.Red
                            Else
                                row.Cells(4).Value = "Sufficient"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.White
                            End If


                            If mainform.txtSRVer.Text > 5 And mainform.txtSRVer.Text <= 10 Then
                                mainform.txtSRVer.BackColor = Color.Yellow
                                mainform.txtSRVer.ForeColor = Color.Black

                            ElseIf mainform.txtSRVer.Text > 0 And mainform.txtSRVer.Text <= 5 Then
                                mainform.txtSRVer.BackColor = Color.Red
                                mainform.txtSRVer.ForeColor = Color.White
                            Else
                                mainform.txtSRVer.BackColor = SystemColors.Control
                                mainform.txtSRVer.ForeColor = Color.Black
                            End If
                            mainform.btnVeronese.Enabled = True
                            mainform.picVero.Hide()

                            MsgBox("Added Succesfully")
                            Exit Sub
                        End If
                    End If
                End If

                If row.Cells(0).Value = "Med-P0107" Then
                    Dim mverup = getUserInput()

                    While mverup < 0 Or validInput = False Or mverup = 0

                        If mverup < 0 Or validInput = False Or mverup = 0 Then
                            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                            Exit Sub
                        Else
                            MsgBox("Try again!")
                        End If

                        mverup = getUserInput()

                    End While

                    If MessageBox.Show("Are you sure you want to add stock(s)?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        If row.Cells(0).Value = "Med-P0107" Then
                            row.Cells(3).Value = row.Cells(3).Value + mverup
                            mveradd = mainform.mverstock
                            mainform.mverstock = mveradd + mverup
                            mverv = mainform.mvergrid
                            mainform.mvergrid = mverv + mverup
                            stock = mainform.txtSMVer.Text
                            mainform.txtSMVer.Text = stock + mverup

                            current = row.Cells(3).Value
                            If current > 5 And current <= 10 Then
                                row.Cells(4).Value = "Warning"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.Yellow
                            ElseIf current > 0 And current <= 5 Then
                                row.Cells(4).Value = "Low On Stock"
                                row.DefaultCellStyle.ForeColor = Color.White
                                row.DefaultCellStyle.BackColor = Color.Red
                            Else
                                row.Cells(4).Value = "Sufficient"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.White
                            End If


                            If mainform.txtSMVer.Text > 5 And mainform.txtSMVer.Text <= 10 Then
                                mainform.txtSMVer.BackColor = Color.Yellow
                                mainform.txtSMVer.ForeColor = Color.Black

                            ElseIf mainform.txtSMVer.Text > 0 And mainform.txtSMVer.Text <= 5 Then
                                mainform.txtSMVer.BackColor = Color.Red
                                mainform.txtSMVer.ForeColor = Color.White
                            Else
                                mainform.txtSMVer.BackColor = SystemColors.Control
                                mainform.txtSMVer.ForeColor = Color.Black
                            End If
                            mainform.btnVeronese.Enabled = True
                            mainform.picVero.Hide()

                            MsgBox("Added Succesfully")
                            Exit Sub
                        End If
                    End If
                End If

                If row.Cells(0).Value = "Lar-P0107" Then
                    Dim lverup = getUserInput()

                    While lverup < 0 Or validInput = False Or lverup = 0

                        If lverup < 0 Or validInput = False Or lverup = 0 Then
                            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                            Exit Sub
                        Else
                            MsgBox("Try again!")
                        End If

                        lverup = getUserInput()

                    End While

                    If MessageBox.Show("Are you sure you want to add stock(s)?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        If row.Cells(0).Value = "Lar-P0107" Then
                            row.Cells(3).Value = row.Cells(3).Value + lverup
                            lveradd = mainform.lverstock
                            mainform.lverstock = lveradd + lverup
                            lverv = mainform.lvergrid
                            mainform.lvergrid = lverv + lverup
                            stock = mainform.txtSLVer.Text
                            mainform.txtSLVer.Text = stock + lverup

                            current = row.Cells(3).Value
                            If current > 5 And current <= 10 Then
                                row.Cells(4).Value = "Warning"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.Yellow
                            ElseIf current > 0 And current <= 5 Then
                                row.Cells(4).Value = "Low On Stock"
                                row.DefaultCellStyle.ForeColor = Color.White
                                row.DefaultCellStyle.BackColor = Color.Red
                            Else
                                row.Cells(4).Value = "Sufficient"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.White
                            End If


                            If mainform.txtSLVer.Text > 5 And mainform.txtSLVer.Text <= 10 Then
                                mainform.txtSLVer.BackColor = Color.Yellow
                                mainform.txtSLVer.ForeColor = Color.Black

                            ElseIf mainform.txtSLVer.Text > 0 And mainform.txtSLVer.Text <= 5 Then
                                mainform.txtSLVer.BackColor = Color.Red
                                mainform.txtSLVer.ForeColor = Color.White
                            Else
                                mainform.txtSLVer.BackColor = SystemColors.Control
                                mainform.txtSLVer.ForeColor = Color.Black
                            End If

                            mainform.btnVeronese.Enabled = True
                            mainform.picVero.Hide()

                            MsgBox("Added Succesfully")
                            Exit Sub
                        End If
                    End If
                End If

                If row.Cells(1).Value = "Rolls" Then
                    Dim rolup = getUserInput()

                    While rolup < 0 Or validInput = False Or rolup = 0

                        If rolup < 0 Or validInput = False Or rolup = 0 Then
                            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                            Exit Sub
                        Else
                            MsgBox("Try again!")
                        End If

                        rolup = getUserInput()

                    End While

                    If MessageBox.Show("Are you sure you want to add stock(s)?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        If row.Cells(1).Value = "Rolls" Then
                            row.Cells(3).Value = row.Cells(3).Value + rolup
                            roladd = mainform.rolstock
                            mainform.rolstock = roladd + rolup
                            rolv = mainform.rolgrid
                            mainform.rolgrid = rolv + rolup
                            stock = mainform.txtSRolls.Text
                            mainform.txtSRolls.Text = stock + rolup

                            current = row.Cells(3).Value
                            If current > 5 And current <= 10 Then
                                row.Cells(4).Value = "Warning"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.Yellow
                            ElseIf current > 0 And current <= 5 Then
                                row.Cells(4).Value = "Low On Stock"
                                row.DefaultCellStyle.ForeColor = Color.White
                                row.DefaultCellStyle.BackColor = Color.Red
                            Else
                                row.Cells(4).Value = "Sufficient"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.White
                            End If


                            If mainform.txtSRolls.Text > 5 And mainform.txtSRolls.Text <= 10 Then
                                mainform.txtSRolls.BackColor = Color.Yellow
                                mainform.txtSRolls.ForeColor = Color.Black

                            ElseIf mainform.txtSRolls.Text > 0 And mainform.txtSRolls.Text <= 5 Then
                                mainform.txtSRolls.BackColor = Color.Red
                                mainform.txtSRolls.ForeColor = Color.White
                            Else
                                mainform.txtSRolls.BackColor = SystemColors.Control
                                mainform.txtSRolls.ForeColor = Color.Black
                            End If
                            mainform.btnRolls.Enabled = True
                            mainform.picRolls.Hide()

                            MsgBox("Added Succesfully")
                            Exit Sub
                        End If
                    End If
                End If

                If row.Cells(1).Value = "French Bread" Then
                    Dim freup = getUserInput()

                    While freup < 0 Or validInput = False Or freup = 0

                        If freup < 0 Or validInput = False Or freup = 0 Then
                            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                            Exit Sub
                        Else
                            MsgBox("Try again!")
                        End If

                        freup = getUserInput()

                    End While

                    If MessageBox.Show("Are you sure you want to add stock(s)?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        If row.Cells(1).Value = "French Bread" Then
                            row.Cells(3).Value = row.Cells(3).Value + freup
                            freadd = mainform.frestock
                            mainform.frestock = freadd + freup
                            frev = mainform.fregrid
                            mainform.fregrid = frev + freup
                            stock = mainform.txtSFrench.Text
                            mainform.txtSFrench.Text = stock + freup

                            current = row.Cells(3).Value
                            If current > 5 And current <= 10 Then
                                row.Cells(4).Value = "Warning"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.Yellow
                            ElseIf current > 0 And current <= 5 Then
                                row.Cells(4).Value = "Low On Stock"
                                row.DefaultCellStyle.ForeColor = Color.White
                                row.DefaultCellStyle.BackColor = Color.Red
                            Else
                                row.Cells(4).Value = "Sufficient"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.White
                            End If

                            If mainform.txtSFrench.Text > 5 And mainform.txtSFrench.Text <= 10 Then
                                mainform.txtSFrench.BackColor = Color.Yellow
                                mainform.txtSFrench.ForeColor = Color.Black

                            ElseIf mainform.txtSFrench.Text > 0 And mainform.txtSFrench.Text <= 5 Then
                                mainform.txtSFrench.BackColor = Color.Red
                                mainform.txtSFrench.ForeColor = Color.White
                            Else
                                mainform.txtSFrench.BackColor = SystemColors.Control
                                mainform.txtSFrench.ForeColor = Color.Black
                            End If
                            mainform.btnFrench.Enabled = True
                            mainform.picFrench.Hide()

                            MsgBox("Added Succesfully")
                            Exit Sub
                        End If
                    End If
                End If

                If row.Cells(1).Value = "Wheat Bread" Then
                    Dim wheup = getUserInput()

                    While wheup < 0 Or validInput = False Or wheup = 0

                        If wheup < 0 Or validInput = False Or wheup = 0 Then
                            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                            Exit Sub
                        Else
                            MsgBox("Try again!")
                        End If

                        wheup = getUserInput()

                    End While

                    If MessageBox.Show("Are you sure you want to add stock(s)?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        If row.Cells(1).Value = "Wheat Bread" Then
                            row.Cells(3).Value = row.Cells(3).Value + wheup
                            wheadd = mainform.whestock
                            mainform.whestock = wheadd + wheup
                            whev = mainform.whegrid
                            mainform.whegrid = whev + wheup
                            stock = mainform.txtSWheat.Text
                            mainform.txtSWheat.Text = stock + wheup

                            current = row.Cells(3).Value
                            If current > 5 And current <= 10 Then
                                row.Cells(4).Value = "Warning"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.Yellow
                            ElseIf current > 0 And current <= 5 Then
                                row.Cells(4).Value = "Low On Stock"
                                row.DefaultCellStyle.ForeColor = Color.White
                                row.DefaultCellStyle.BackColor = Color.Red
                            Else
                                row.Cells(4).Value = "Sufficient"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.White
                            End If

                            If mainform.txtSWheat.Text > 5 And mainform.txtSWheat.Text <= 10 Then
                                mainform.txtSWheat.BackColor = Color.Yellow
                                mainform.txtSWheat.ForeColor = Color.Black

                            ElseIf mainform.txtSWheat.Text > 0 And mainform.txtSWheat.Text <= 5 Then
                                mainform.txtSWheat.BackColor = Color.Red
                                mainform.txtSWheat.ForeColor = Color.White
                            Else
                                mainform.txtSWheat.BackColor = SystemColors.Control
                                mainform.txtSWheat.ForeColor = Color.Black
                            End If
                            mainform.btnWheat.Enabled = True
                            mainform.picWheat.Hide()

                            MsgBox("Added Succesfully")
                            Exit Sub
                        End If
                    End If
                End If

                If row.Cells(1).Value = "White Bread" Then
                    Dim whiup = getUserInput()

                    While whiup < 0 Or validInput = False Or whiup = 0

                        If whiup < 0 Or validInput = False Or whiup = 0 Then
                            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                            Exit Sub
                        Else
                            MsgBox("Try again!")
                        End If

                        whiup = getUserInput()

                    End While

                    If MessageBox.Show("Are you sure you want to add stock(s)?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        If row.Cells(1).Value = "White Bread" Then
                            row.Cells(3).Value = row.Cells(3).Value + whiup
                            whiadd = mainform.whistock
                            mainform.whistock = whiadd + whiup
                            whiv = mainform.whigrid
                            mainform.whigrid = whiv + whiup
                            stock = mainform.txtSWhite.Text
                            mainform.txtSWhite.Text = stock + whiup

                            current = row.Cells(3).Value
                            If current > 5 And current <= 10 Then
                                row.Cells(4).Value = "Warning"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.Yellow
                            ElseIf current > 0 And current <= 5 Then
                                row.Cells(4).Value = "Low On Stock"
                                row.DefaultCellStyle.ForeColor = Color.White
                                row.DefaultCellStyle.BackColor = Color.Red
                            Else
                                row.Cells(4).Value = "Sufficient"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.White
                            End If

                            If mainform.txtSWhite.Text > 5 And mainform.txtSWhite.Text <= 10 Then
                                mainform.txtSWhite.BackColor = Color.Yellow
                                mainform.txtSWhite.ForeColor = Color.Black

                            ElseIf mainform.txtSWhite.Text > 0 And mainform.txtSWhite.Text <= 5 Then
                                mainform.txtSWhite.BackColor = Color.Red
                                mainform.txtSWhite.ForeColor = Color.White
                            Else
                                mainform.txtSWhite.BackColor = SystemColors.Control
                                mainform.txtSWhite.ForeColor = Color.Black
                            End If
                            mainform.btnWhite.Enabled = True
                            mainform.picWhite.Hide()

                            MsgBox("Added Succesfully")
                            Exit Sub
                        End If
                    End If
                End If

                If row.Cells(1).Value = "Banana Bread" Then
                    Dim banup = getUserInput()

                    While banup < 0 Or validInput = False Or banup = 0

                        If banup < 0 Or validInput = False Or banup = 0 Then
                            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                            Exit Sub
                        Else
                            MsgBox("Try again!")
                        End If

                        banup = getUserInput()

                    End While

                    If MessageBox.Show("Are you sure you want to add stock(s)?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        If row.Cells(1).Value = "Banana Bread" Then
                            row.Cells(3).Value = row.Cells(3).Value + banup
                            banadd = mainform.banstock
                            mainform.banstock = banadd + banup
                            banv = mainform.bangrid
                            mainform.bangrid = banv + banup
                            stock = mainform.txtSBanana.Text
                            mainform.txtSBanana.Text = stock + banup

                            current = row.Cells(3).Value
                            If current > 5 And current <= 10 Then
                                row.Cells(4).Value = "Warning"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.Yellow
                            ElseIf current > 0 And current <= 5 Then
                                row.Cells(4).Value = "Low On Stock"
                                row.DefaultCellStyle.ForeColor = Color.White
                                row.DefaultCellStyle.BackColor = Color.Red
                            Else
                                row.Cells(4).Value = "Sufficient"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.White
                            End If

                            If mainform.txtSBanana.Text > 5 And mainform.txtSBanana.Text <= 10 Then
                                mainform.txtSBanana.BackColor = Color.Yellow
                                mainform.txtSBanana.ForeColor = Color.Black

                            ElseIf mainform.txtSBanana.Text > 0 And mainform.txtSBanana.Text <= 5 Then
                                mainform.txtSBanana.BackColor = Color.Red
                                mainform.txtSBanana.ForeColor = Color.White
                            Else
                                mainform.txtSBanana.BackColor = SystemColors.Control
                                mainform.txtSBanana.ForeColor = Color.Black
                            End If
                            mainform.btnBanana.Enabled = True
                            mainform.picBanana.Hide()

                            MsgBox("Added Succesfully")
                            Exit Sub
                        End If
                    End If
                End If

                If row.Cells(1).Value = "Hotdog Bun" Then
                    Dim hotup = getUserInput()

                    While hotup < 0 Or validInput = False Or hotup = 0

                        If hotup < 0 Or validInput = False Or hotup = 0 Then
                            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                            Exit Sub
                        Else
                            MsgBox("Try again!")
                        End If

                        hotup = getUserInput()

                    End While

                    If MessageBox.Show("Are you sure you want to add stock(s)?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        If row.Cells(1).Value = "Hotdog Bun" Then
                            row.Cells(3).Value = row.Cells(3).Value + hotup
                            hotadd = mainform.hotstock
                            mainform.hotstock = hotadd + hotup
                            hotv = mainform.hotgrid
                            mainform.hotgrid = hotv + hotup
                            stock = mainform.txtSHotdog.Text
                            mainform.txtSHotdog.Text = stock + hotup

                            current = row.Cells(3).Value
                            If current > 5 And current <= 10 Then
                                row.Cells(4).Value = "Warning"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.Yellow
                            ElseIf current > 0 And current <= 5 Then
                                row.Cells(4).Value = "Low On Stock"
                                row.DefaultCellStyle.ForeColor = Color.White
                                row.DefaultCellStyle.BackColor = Color.Red
                            Else
                                row.Cells(4).Value = "Sufficient"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.White
                            End If

                            If mainform.txtSHotdog.Text > 5 And mainform.txtSHotdog.Text <= 10 Then
                                mainform.txtSHotdog.BackColor = Color.Yellow
                                mainform.txtSHotdog.ForeColor = Color.Black

                            ElseIf mainform.txtSHotdog.Text > 0 And mainform.txtSHotdog.Text <= 5 Then
                                mainform.txtSHotdog.BackColor = Color.Red
                                mainform.txtSHotdog.ForeColor = Color.White
                            Else
                                mainform.txtSHotdog.BackColor = SystemColors.Control
                                mainform.txtSHotdog.ForeColor = Color.Black
                            End If
                            mainform.btnHotdog.Enabled = True
                            mainform.picHotdog.Hide()

                            MsgBox("Added Succesfully")
                            Exit Sub
                        End If
                    End If
                End If

                If row.Cells(0).Value = "Reg-C0102" Then
                    Dim espup = getUserInput()

                    While espup < 0 Or validInput = False Or espup = 0

                        If espup < 0 Or validInput = False Or espup = 0 Then
                            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                            Exit Sub
                        Else
                            MsgBox("Try again!")
                        End If

                        espup = getUserInput()

                    End While

                    If MessageBox.Show("Are you sure you want to add stock(s)?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        If row.Cells(0).Value = "Reg-C0102" Then
                            row.Cells(3).Value = row.Cells(3).Value + espup
                            espadd = mainform.espstock
                            mainform.espstock = espadd + espup
                            espv = mainform.espgrid
                            mainform.espgrid = espv + espup
                            stock = mainform.txtSREsp.Text
                            mainform.txtSREsp.Text = stock + espup

                            current = row.Cells(3).Value
                            If current > 5 And current <= 10 Then
                                row.Cells(4).Value = "Warning"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.Yellow
                            ElseIf current > 0 And current <= 5 Then
                                row.Cells(4).Value = "Low On Stock"
                                row.DefaultCellStyle.ForeColor = Color.White
                                row.DefaultCellStyle.BackColor = Color.Red
                            Else
                                row.Cells(4).Value = "Sufficient"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.White
                            End If

                            If mainform.txtSREsp.Text > 5 And mainform.txtSREsp.Text <= 10 Then
                                mainform.txtSREsp.BackColor = Color.Yellow
                                mainform.txtSREsp.ForeColor = Color.Black

                            ElseIf mainform.txtSREsp.Text > 0 And mainform.txtSREsp.Text <= 5 Then
                                mainform.txtSREsp.BackColor = Color.Red
                                mainform.txtSREsp.ForeColor = Color.White
                            Else
                                mainform.txtSREsp.BackColor = SystemColors.Control
                                mainform.txtSREsp.ForeColor = Color.Black
                            End If
                            mainform.btnEspresso.Enabled = True
                            mainform.picEsp.Hide()

                            MsgBox("Added Succesfully")
                            Exit Sub
                        End If
                    End If
                End If

                If row.Cells(0).Value = "Med-C0102" Then
                    Dim mespup = getUserInput()

                    While mespup < 0 Or validInput = False Or mespup = 0

                        If mespup < 0 Or validInput = False Or mespup = 0 Then
                            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                            Exit Sub
                        Else
                            MsgBox("Try again!")
                        End If

                        mespup = getUserInput()

                    End While

                    If MessageBox.Show("Are you sure you want to add stock(s)?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        If row.Cells(0).Value = "Med-C0102" Then
                            row.Cells(3).Value = row.Cells(3).Value + mespup
                            mespadd = mainform.mespstock
                            mainform.mespstock = mespadd + mespup
                            mespv = mainform.mespgrid
                            mainform.mespgrid = mespv + mespup
                            stock = mainform.txtSMEsp.Text
                            mainform.txtSMEsp.Text = stock + mespup

                            current = row.Cells(3).Value
                            If current > 5 And current <= 10 Then
                                row.Cells(4).Value = "Warning"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.Yellow
                            ElseIf current > 0 And current <= 5 Then
                                row.Cells(4).Value = "Low On Stock"
                                row.DefaultCellStyle.ForeColor = Color.White
                                row.DefaultCellStyle.BackColor = Color.Red
                            Else
                                row.Cells(4).Value = "Sufficient"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.White
                            End If

                            If mainform.txtSMEsp.Text > 5 And mainform.txtSMEsp.Text <= 10 Then
                                mainform.txtSMEsp.BackColor = Color.Yellow
                                mainform.txtSMEsp.ForeColor = Color.Black

                            ElseIf mainform.txtSMEsp.Text > 0 And mainform.txtSMEsp.Text <= 5 Then
                                mainform.txtSMEsp.BackColor = Color.Red
                                mainform.txtSMEsp.ForeColor = Color.White
                            Else
                                mainform.txtSMEsp.BackColor = SystemColors.Control
                                mainform.txtSMEsp.ForeColor = Color.Black
                            End If
                            mainform.btnEspresso.Enabled = True
                            mainform.picEsp.Hide()

                            MsgBox("Added Succesfully")
                            Exit Sub
                        End If
                    End If
                End If

                If row.Cells(0).Value = "Lar-C0102" Then
                    Dim lespup = getUserInput()

                    While lespup < 0 Or validInput = False Or lespup = 0

                        If lespup < 0 Or validInput = False Or lespup = 0 Then
                            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                            Exit Sub
                        Else
                            MsgBox("Try again!")
                        End If

                        lespup = getUserInput()

                    End While

                    If MessageBox.Show("Are you sure you want to add stock(s)?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        If row.Cells(0).Value = "Lar-C0102" Then
                            row.Cells(3).Value = row.Cells(3).Value + lespup
                            lespadd = mainform.lespstock
                            mainform.lespstock = lespadd + lespup
                            lespv = mainform.lespgrid
                            mainform.lespgrid = lespv + lespup
                            stock = mainform.txtSLEsp.Text
                            mainform.txtSLEsp.Text = stock + lespup

                            current = row.Cells(3).Value
                            If current > 5 And current <= 10 Then
                                row.Cells(4).Value = "Warning"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.Yellow
                            ElseIf current > 0 And current <= 5 Then
                                row.Cells(4).Value = "Low On Stock"
                                row.DefaultCellStyle.ForeColor = Color.White
                                row.DefaultCellStyle.BackColor = Color.Red
                            Else
                                row.Cells(4).Value = "Sufficient"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.White
                            End If

                            If mainform.txtSLEsp.Text > 5 And mainform.txtSLEsp.Text <= 10 Then
                                mainform.txtSLEsp.BackColor = Color.Yellow
                                mainform.txtSLEsp.ForeColor = Color.Black

                            ElseIf mainform.txtSLEsp.Text > 0 And mainform.txtSLEsp.Text <= 5 Then
                                mainform.txtSLEsp.BackColor = Color.Red
                                mainform.txtSLEsp.ForeColor = Color.White
                            Else
                                mainform.txtSLEsp.BackColor = SystemColors.Control
                                mainform.txtSLEsp.ForeColor = Color.Black
                            End If
                            mainform.btnEspresso.Enabled = True
                            mainform.picEsp.Hide()

                            MsgBox("Added Succesfully")
                            Exit Sub
                        End If
                    End If
                End If

                If row.Cells(0).Value = "Reg-C0103" Then
                    Dim dopup = getUserInput()

                    While dopup < 0 Or validInput = False Or dopup = 0

                        If dopup < 0 Or validInput = False Or dopup = 0 Then
                            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                            Exit Sub
                        Else
                            MsgBox("Try again!")
                        End If

                        dopup = getUserInput()

                    End While

                    If MessageBox.Show("Are you sure you want to add stock(s)?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        If row.Cells(0).Value = "Reg-C0103" Then
                            row.Cells(3).Value = row.Cells(3).Value + dopup
                            dopadd = mainform.dopstock
                            mainform.dopstock = dopadd + dopup
                            dopv = mainform.dopgrid
                            mainform.dopgrid = dopv + dopup
                            stock = mainform.txtSRDop.Text
                            mainform.txtSRDop.Text = stock + dopup

                            current = row.Cells(3).Value
                            If current > 5 And current <= 10 Then
                                row.Cells(4).Value = "Warning"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.Yellow
                            ElseIf current > 0 And current <= 5 Then
                                row.Cells(4).Value = "Low On Stock"
                                row.DefaultCellStyle.ForeColor = Color.White
                                row.DefaultCellStyle.BackColor = Color.Red
                            Else
                                row.Cells(4).Value = "Sufficient"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.White
                            End If

                            If mainform.txtSRDop.Text > 5 And mainform.txtSRDop.Text <= 10 Then
                                mainform.txtSRDop.BackColor = Color.Yellow
                                mainform.txtSRDop.ForeColor = Color.Black

                            ElseIf mainform.txtSRDop.Text > 0 And mainform.txtSRDop.Text <= 5 Then
                                mainform.txtSRDop.BackColor = Color.Red
                                mainform.txtSRDop.ForeColor = Color.White
                            Else
                                mainform.txtSRDop.BackColor = SystemColors.Control
                                mainform.txtSRDop.ForeColor = Color.Black
                            End If
                            mainform.btnDoppio.Enabled = True
                            mainform.picDop.Hide()

                            MsgBox("Added Succesfully")
                            Exit Sub
                        End If
                    End If
                End If

                If row.Cells(0).Value = "Med-C0103" Then
                    Dim mdopup = getUserInput()

                    While mdopup < 0 Or validInput = False Or mdopup = 0

                        If mdopup < 0 Or validInput = False Or mdopup = 0 Then
                            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                            Exit Sub
                        Else
                            MsgBox("Try again!")
                        End If

                        mdopup = getUserInput()

                    End While

                    If MessageBox.Show("Are you sure you want to add stock(s)?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        If row.Cells(0).Value = "Med-C0103" Then
                            row.Cells(3).Value = row.Cells(3).Value + mdopup
                            mdopadd = mainform.mdopstock
                            mainform.mdopstock = mdopadd + mdopup
                            mdopv = mainform.mdopgrid
                            mainform.mdopgrid = mdopv + mdopup
                            stock = mainform.txtSMDop.Text
                            mainform.txtSMDop.Text = stock + mdopup

                            current = row.Cells(3).Value
                            If current > 5 And current <= 10 Then
                                row.Cells(4).Value = "Warning"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.Yellow
                            ElseIf current > 0 And current <= 5 Then
                                row.Cells(4).Value = "Low On Stock"
                                row.DefaultCellStyle.ForeColor = Color.White
                                row.DefaultCellStyle.BackColor = Color.Red
                            Else
                                row.Cells(4).Value = "Sufficient"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.White
                            End If

                            If mainform.txtSMDop.Text > 5 And mainform.txtSMDop.Text <= 10 Then
                                mainform.txtSMDop.BackColor = Color.Yellow
                                mainform.txtSMDop.ForeColor = Color.Black

                            ElseIf mainform.txtSMDop.Text > 0 And mainform.txtSMDop.Text <= 5 Then
                                mainform.txtSMDop.BackColor = Color.Red
                                mainform.txtSMDop.ForeColor = Color.White
                            Else
                                mainform.txtSMDop.BackColor = SystemColors.Control
                                mainform.txtSMDop.ForeColor = Color.Black
                            End If
                            mainform.btnDoppio.Enabled = True
                            mainform.picDop.Hide()

                            MsgBox("Added Succesfully")
                            Exit Sub
                        End If
                    End If
                End If

                If row.Cells(0).Value = "Lar-C0103" Then
                    Dim ldopup = getUserInput()

                    While ldopup < 0 Or validInput = False Or ldopup = 0

                        If ldopup < 0 Or validInput = False Or ldopup = 0 Then
                            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                            Exit Sub
                        Else
                            MsgBox("Try again!")
                        End If

                        ldopup = getUserInput()

                    End While

                    If MessageBox.Show("Are you sure you want to add stock(s)?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        If row.Cells(0).Value = "Lar-C0103" Then
                            row.Cells(3).Value = row.Cells(3).Value + ldopup
                            ldopadd = mainform.ldopstock
                            mainform.ldopstock = ldopadd + ldopup
                            ldopv = mainform.ldopgrid
                            mainform.ldopgrid = ldopv + ldopup
                            stock = mainform.txtSLDop.Text
                            mainform.txtSLDop.Text = stock + ldopup

                            current = row.Cells(3).Value
                            If current > 5 And current <= 10 Then
                                row.Cells(4).Value = "Warning"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.Yellow
                            ElseIf current > 0 And current <= 5 Then
                                row.Cells(4).Value = "Low On Stock"
                                row.DefaultCellStyle.ForeColor = Color.White
                                row.DefaultCellStyle.BackColor = Color.Red
                            Else
                                row.Cells(4).Value = "Sufficient"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.White
                            End If

                            If mainform.txtSLDop.Text > 5 And mainform.txtSLDop.Text <= 10 Then
                                mainform.txtSLDop.BackColor = Color.Yellow
                                mainform.txtSLDop.ForeColor = Color.Black

                            ElseIf mainform.txtSLDop.Text > 0 And mainform.txtSLDop.Text <= 5 Then
                                mainform.txtSLDop.BackColor = Color.Red
                                mainform.txtSLDop.ForeColor = Color.White
                            Else
                                mainform.txtSLDop.BackColor = SystemColors.Control
                                mainform.txtSLDop.ForeColor = Color.Black
                            End If
                            mainform.btnDoppio.Enabled = True
                            mainform.picDop.Hide()

                            MsgBox("Added Succesfully")
                            Exit Sub
                        End If
                    End If
                End If

                If row.Cells(0).Value = "Reg-C0104" Then
                    Dim ameup = getUserInput()

                    While ameup < 0 Or validInput = False Or ameup = 0

                        If ameup < 0 Or validInput = False Or ameup = 0 Then
                            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                            Exit Sub
                        Else
                            MsgBox("Try again!")
                        End If

                        ameup = getUserInput()

                    End While

                    If MessageBox.Show("Are you sure you want to add stock(s)?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        If row.Cells(0).Value = "Reg-C0104" Then
                            row.Cells(3).Value = row.Cells(3).Value + ameup
                            ameadd = mainform.amestock
                            mainform.amestock = ameadd + ameup
                            amev = mainform.amegrid
                            mainform.amegrid = amev + ameup
                            stock = mainform.txtSRAme.Text
                            mainform.txtSRAme.Text = stock + ameup

                            current = row.Cells(3).Value
                            If current > 5 And current <= 10 Then
                                row.Cells(4).Value = "Warning"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.Yellow
                            ElseIf current > 0 And current <= 5 Then
                                row.Cells(4).Value = "Low On Stock"
                                row.DefaultCellStyle.ForeColor = Color.White
                                row.DefaultCellStyle.BackColor = Color.Red
                            Else
                                row.Cells(4).Value = "Sufficient"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.White
                            End If

                            If mainform.txtSRAme.Text > 5 And mainform.txtSRAme.Text <= 10 Then
                                mainform.txtSRAme.BackColor = Color.Yellow
                                mainform.txtSRAme.ForeColor = Color.Black

                            ElseIf mainform.txtSRAme.Text > 0 And mainform.txtSRAme.Text <= 5 Then
                                mainform.txtSRAme.BackColor = Color.Red
                                mainform.txtSRAme.ForeColor = Color.White
                            Else
                                mainform.txtSRAme.BackColor = SystemColors.Control
                                mainform.txtSRAme.ForeColor = Color.Black
                            End If
                            mainform.btnAmericano.Enabled = True
                            mainform.picAme.Hide()

                            MsgBox("Added Succesfully")
                            Exit Sub
                        End If
                    End If
                End If

                If row.Cells(0).Value = "Med-C0104" Then
                    Dim mameup = getUserInput()

                    While mameup < 0 Or validInput = False Or mameup = 0

                        If mameup < 0 Or validInput = False Or mameup = 0 Then
                            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                            Exit Sub
                        Else
                            MsgBox("Try again!")
                        End If

                        mameup = getUserInput()

                    End While

                    If MessageBox.Show("Are you sure you want to add stock(s)?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        If row.Cells(0).Value = "Med-C0104" Then
                            row.Cells(3).Value = row.Cells(3).Value + mameup
                            mameadd = mainform.mamestock
                            mainform.mamestock = mameadd + mameup
                            mamev = mainform.mamegrid
                            mainform.mamegrid = mamev + mameup
                            stock = mainform.txtSMAme.Text
                            mainform.txtSMAme.Text = stock + mameup
                            current = row.Cells(3).Value
                            If current > 5 And current <= 10 Then
                                row.Cells(4).Value = "Warning"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.Yellow
                            ElseIf current > 0 And current <= 5 Then
                                row.Cells(4).Value = "Low On Stock"
                                row.DefaultCellStyle.ForeColor = Color.White
                                row.DefaultCellStyle.BackColor = Color.Red
                            Else
                                row.Cells(4).Value = "Sufficient"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.White
                            End If

                            If mainform.txtSMAme.Text > 5 And mainform.txtSMAme.Text <= 10 Then
                                mainform.txtSMAme.BackColor = Color.Yellow
                                mainform.txtSMAme.ForeColor = Color.Black

                            ElseIf mainform.txtSMAme.Text > 0 And mainform.txtSMAme.Text <= 5 Then
                                mainform.txtSMAme.BackColor = Color.Red
                                mainform.txtSMAme.ForeColor = Color.White
                            Else
                                mainform.txtSMAme.BackColor = SystemColors.Control
                                mainform.txtSMAme.ForeColor = Color.Black
                            End If
                            mainform.btnAmericano.Enabled = True
                            mainform.picAme.Hide()

                            MsgBox("Added Succesfully")
                            Exit Sub
                        End If
                    End If
                End If

                If row.Cells(0).Value = "Lar-C0104" Then
                    Dim lameup = getUserInput()

                    While lameup < 0 Or validInput = False Or lameup = 0

                        If lameup < 0 Or validInput = False Or lameup = 0 Then
                            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                            Exit Sub
                        Else
                            MsgBox("Try again!")
                        End If

                        lameup = getUserInput()

                    End While

                    If MessageBox.Show("Are you sure you want to add stock(s)?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        If row.Cells(0).Value = "Lar-C0104" Then
                            row.Cells(3).Value = row.Cells(3).Value + lameup
                            lameadd = mainform.lamestock
                            mainform.lamestock = lameadd + lameup
                            lamev = mainform.lamegrid
                            mainform.lamegrid = lamev + lameup
                            stock = mainform.txtSLAme.Text
                            mainform.txtSLAme.Text = stock + lameup

                            current = row.Cells(3).Value
                            If current > 5 And current <= 10 Then
                                row.Cells(4).Value = "Warning"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.Yellow
                            ElseIf current > 0 And current <= 5 Then
                                row.Cells(4).Value = "Low On Stock"
                                row.DefaultCellStyle.ForeColor = Color.White
                                row.DefaultCellStyle.BackColor = Color.Red
                            Else
                                row.Cells(4).Value = "Sufficient"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.White
                            End If

                            If mainform.txtSLAme.Text > 5 And mainform.txtSLAme.Text <= 10 Then
                                mainform.txtSLAme.BackColor = Color.Yellow
                                mainform.txtSLAme.ForeColor = Color.Black

                            ElseIf mainform.txtSLAme.Text > 0 And mainform.txtSLAme.Text <= 5 Then
                                mainform.txtSLAme.BackColor = Color.Red
                                mainform.txtSLAme.ForeColor = Color.White
                            Else
                                mainform.txtSLAme.BackColor = SystemColors.Control
                                mainform.txtSLAme.ForeColor = Color.Black
                            End If
                            mainform.btnAmericano.Enabled = True
                            mainform.picAme.Hide()

                            MsgBox("Added Succesfully")
                            Exit Sub
                        End If
                    End If
                End If

                If row.Cells(0).Value = "Reg-C0105" Then
                    Dim capup = getUserInput()

                    While capup < 0 Or validInput = False Or capup = 0

                        If capup < 0 Or validInput = False Or capup = 0 Then
                            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                            Exit Sub
                        Else
                            MsgBox("Try again!")
                        End If

                        capup = getUserInput()

                    End While

                    If MessageBox.Show("Are you sure you want to add stock(s)?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        If row.Cells(0).Value = "Reg-C0105" Then
                            row.Cells(3).Value = row.Cells(3).Value + capup
                            capadd = mainform.capstock
                            mainform.capstock = capadd + capup
                            capv = mainform.capgrid
                            mainform.capgrid = capv + capup
                            stock = mainform.txtSRCap.Text
                            mainform.txtSRCap.Text = stock + capup

                            current = row.Cells(3).Value
                            If current > 5 And current <= 10 Then
                                row.Cells(4).Value = "Warning"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.Yellow
                            ElseIf current > 0 And current <= 5 Then
                                row.Cells(4).Value = "Low On Stock"
                                row.DefaultCellStyle.ForeColor = Color.White
                                row.DefaultCellStyle.BackColor = Color.Red
                            Else
                                row.Cells(4).Value = "Sufficient"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.White
                            End If

                            If mainform.txtSRCap.Text > 5 And mainform.txtSRCap.Text <= 10 Then
                                mainform.txtSRCap.BackColor = Color.Yellow
                                mainform.txtSRCap.ForeColor = Color.Black

                            ElseIf mainform.txtSRCap.Text > 0 And mainform.txtSRCap.Text <= 5 Then
                                mainform.txtSRCap.BackColor = Color.Red
                                mainform.txtSRCap.ForeColor = Color.White
                            Else
                                mainform.txtSRCap.BackColor = SystemColors.Control
                                mainform.txtSRCap.ForeColor = Color.Black
                            End If
                            mainform.btnCappuccino.Enabled = True
                            mainform.picCap.Hide()

                            MsgBox("Added Succesfully")
                            Exit Sub
                        End If
                    End If
                End If

                If row.Cells(0).Value = "Med-C0105" Then
                    Dim mcapup = getUserInput()

                    While mcapup < 0 Or validInput = False Or mcapup = 0

                        If mcapup < 0 Or validInput = False Or mcapup = 0 Then
                            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                            Exit Sub
                        Else
                            MsgBox("Try again!")
                        End If

                        mcapup = getUserInput()

                    End While

                    If MessageBox.Show("Are you sure you want to add stock(s)?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        If row.Cells(0).Value = "Med-C0105" Then
                            row.Cells(3).Value = row.Cells(3).Value + mcapup
                            mcapadd = mainform.mcapstock
                            mainform.mcapstock = mcapadd + mcapup
                            mcapv = mainform.mcapgrid
                            mainform.mcapgrid = mcapv + mcapup
                            stock = mainform.txtSMCap.Text
                            mainform.txtSMCap.Text = stock + mcapup

                            current = row.Cells(3).Value
                            If current > 5 And current <= 10 Then
                                row.Cells(4).Value = "Warning"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.Yellow
                            ElseIf current > 0 And current <= 5 Then
                                row.Cells(4).Value = "Low On Stock"
                                row.DefaultCellStyle.ForeColor = Color.White
                                row.DefaultCellStyle.BackColor = Color.Red
                            Else
                                row.Cells(4).Value = "Sufficient"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.White
                            End If

                            If mainform.txtSMCap.Text > 5 And mainform.txtSMCap.Text <= 10 Then
                                mainform.txtSMCap.BackColor = Color.Yellow
                                mainform.txtSMCap.ForeColor = Color.Black

                            ElseIf mainform.txtSMCap.Text > 0 And mainform.txtSMCap.Text <= 5 Then
                                mainform.txtSMCap.BackColor = Color.Red
                                mainform.txtSMCap.ForeColor = Color.White
                            Else
                                mainform.txtSMCap.BackColor = SystemColors.Control
                                mainform.txtSMCap.ForeColor = Color.Black
                            End If
                            mainform.btnCappuccino.Enabled = True
                            mainform.picCap.Hide()

                            MsgBox("Added Succesfully")
                            Exit Sub
                        End If
                    End If
                End If

                If row.Cells(0).Value = "Lar-C0105" Then
                    Dim lcapup = getUserInput()

                    While lcapup < 0 Or validInput = False Or lcapup = 0

                        If lcapup < 0 Or validInput = False Or lcapup = 0 Then
                            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                            Exit Sub
                        Else
                            MsgBox("Try again!")
                        End If

                        lcapup = getUserInput()

                    End While

                    If MessageBox.Show("Are you sure you want to add stock(s)?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        If row.Cells(0).Value = "Lar-C0105" Then
                            row.Cells(3).Value = row.Cells(3).Value + lcapup
                            lcapadd = mainform.lcapstock
                            mainform.lcapstock = lcapadd + lcapup
                            lcapv = mainform.lcapgrid
                            mainform.lcapgrid = lcapv + lcapup
                            stock = mainform.txtSLCap.Text
                            mainform.txtSLCap.Text = stock + lcapup

                            current = row.Cells(3).Value
                            If current > 5 And current <= 10 Then
                                row.Cells(4).Value = "Warning"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.Yellow
                            ElseIf current > 0 And current <= 5 Then
                                row.Cells(4).Value = "Low On Stock"
                                row.DefaultCellStyle.ForeColor = Color.White
                                row.DefaultCellStyle.BackColor = Color.Red
                            Else
                                row.Cells(4).Value = "Sufficient"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.White
                            End If

                            If mainform.txtSLCap.Text > 5 And mainform.txtSLCap.Text <= 10 Then
                                mainform.txtSLCap.BackColor = Color.Yellow
                                mainform.txtSLCap.ForeColor = Color.Black

                            ElseIf mainform.txtSLCap.Text > 0 And mainform.txtSLCap.Text <= 5 Then
                                mainform.txtSLCap.BackColor = Color.Red
                                mainform.txtSLCap.ForeColor = Color.White
                            Else
                                mainform.txtSLCap.BackColor = SystemColors.Control
                                mainform.txtSLCap.ForeColor = Color.Black
                            End If
                            mainform.btnCappuccino.Enabled = True
                            mainform.picCap.Hide()

                            MsgBox("Added Succesfully")
                            Exit Sub
                        End If
                    End If
                End If

                If row.Cells(0).Value = "Reg-C0106" Then
                    Dim latup = getUserInput()

                    While latup < 0 Or validInput = False Or latup = 0

                        If latup < 0 Or validInput = False Or latup = 0 Then
                            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                            Exit Sub
                        Else
                            MsgBox("Try again!")
                        End If

                        latup = getUserInput()

                    End While

                    If MessageBox.Show("Are you sure you want to add stock(s)?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        If row.Cells(0).Value = "Reg-C0106" Then
                            row.Cells(3).Value = row.Cells(3).Value + latup
                            latadd = mainform.latstock
                            mainform.latstock = latadd + latup
                            latv = mainform.latgrid
                            mainform.latgrid = latv + latup
                            stock = mainform.txtSRLat.Text
                            mainform.txtSRLat.Text = stock + latup

                            current = row.Cells(3).Value
                            If current > 5 And current <= 10 Then
                                row.Cells(4).Value = "Warning"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.Yellow
                            ElseIf current > 0 And current <= 5 Then
                                row.Cells(4).Value = "Low On Stock"
                                row.DefaultCellStyle.ForeColor = Color.White
                                row.DefaultCellStyle.BackColor = Color.Red
                            Else
                                row.Cells(4).Value = "Sufficient"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.White
                            End If

                            If mainform.txtSRLat.Text > 5 And mainform.txtSRLat.Text <= 10 Then
                                mainform.txtSRLat.BackColor = Color.Yellow
                                mainform.txtSRLat.ForeColor = Color.Black

                            ElseIf mainform.txtSRLat.Text > 0 And mainform.txtSRLat.Text <= 5 Then
                                mainform.txtSRLat.BackColor = Color.Red
                                mainform.txtSRLat.ForeColor = Color.White
                            Else
                                mainform.txtSRLat.BackColor = SystemColors.Control
                                mainform.txtSRLat.ForeColor = Color.Black
                            End If
                            mainform.btnLatte.Enabled = True
                            mainform.picLat.Hide()

                            MsgBox("Added Succesfully")
                            Exit Sub
                        End If
                    End If
                End If

                If row.Cells(0).Value = "Med-C0106" Then
                    Dim mlatup = getUserInput()

                    While mlatup < 0 Or validInput = False Or mlatup = 0

                        If mlatup < 0 Or validInput = False Or mlatup = 0 Then
                            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                            Exit Sub
                        Else
                            MsgBox("Try again!")
                        End If

                        mlatup = getUserInput()

                    End While

                    If MessageBox.Show("Are you sure you want to add stock(s)?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        If row.Cells(0).Value = "Med-C0106" Then
                            row.Cells(3).Value = row.Cells(3).Value + mlatup
                            mlatadd = mainform.mlatstock
                            mainform.mlatstock = mlatadd + mlatup
                            mlatv = mainform.mlatgrid
                            mainform.mlatgrid = mlatv + mlatup
                            stock = mainform.txtSMLat.Text
                            mainform.txtSMLat.Text = stock + mlatup

                            current = row.Cells(3).Value
                            If current > 5 And current <= 10 Then
                                row.Cells(4).Value = "Warning"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.Yellow
                            ElseIf current > 0 And current <= 5 Then
                                row.Cells(4).Value = "Low On Stock"
                                row.DefaultCellStyle.ForeColor = Color.White
                                row.DefaultCellStyle.BackColor = Color.Red
                            Else
                                row.Cells(4).Value = "Sufficient"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.White
                            End If

                            If mainform.txtSMLat.Text > 5 And mainform.txtSMLat.Text <= 10 Then
                                mainform.txtSMLat.BackColor = Color.Yellow
                                mainform.txtSMLat.ForeColor = Color.Black

                            ElseIf mainform.txtSMLat.Text > 0 And mainform.txtSMLat.Text <= 5 Then
                                mainform.txtSMLat.BackColor = Color.Red
                                mainform.txtSMLat.ForeColor = Color.White
                            Else
                                mainform.txtSMLat.BackColor = SystemColors.Control
                                mainform.txtSMLat.ForeColor = Color.Black
                            End If
                            mainform.btnLatte.Enabled = True
                            mainform.picLat.Hide()

                            MsgBox("Added Succesfully")
                            Exit Sub
                        End If
                    End If
                End If

                If row.Cells(0).Value = "Lar-C0106" Then
                    Dim llatup = getUserInput()

                    While llatup < 0 Or validInput = False Or llatup = 0

                        If llatup < 0 Or validInput = False Or llatup = 0 Then
                            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                            Exit Sub
                        Else
                            MsgBox("Try again!")
                        End If

                        llatup = getUserInput()

                    End While

                    If MessageBox.Show("Are you sure you want to add stock(s)?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        If row.Cells(0).Value = "Lar-C0106" Then
                            row.Cells(3).Value = row.Cells(3).Value + llatup
                            llatadd = mainform.llatstock
                            mainform.llatstock = llatadd + llatup
                            llatav = mainform.llatgrid
                            mainform.llatgrid = llatav + llatup
                            stock = mainform.txtSLLat.Text
                            mainform.txtSLLat.Text = stock + llatup

                            current = row.Cells(3).Value
                            If current > 5 And current <= 10 Then
                                row.Cells(4).Value = "Warning"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.Yellow
                            ElseIf current > 0 And current <= 5 Then
                                row.Cells(4).Value = "Low On Stock"
                                row.DefaultCellStyle.ForeColor = Color.White
                                row.DefaultCellStyle.BackColor = Color.Red
                            Else
                                row.Cells(4).Value = "Sufficient"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.White
                            End If

                            If mainform.txtSLLat.Text > 5 And mainform.txtSLLat.Text <= 10 Then
                                mainform.txtSLLat.BackColor = Color.Yellow
                                mainform.txtSLLat.ForeColor = Color.Black

                            ElseIf mainform.txtSLLat.Text > 0 And mainform.txtSLLat.Text <= 5 Then
                                mainform.txtSLLat.BackColor = Color.Red
                                mainform.txtSLLat.ForeColor = Color.White
                            Else
                                mainform.txtSLLat.BackColor = SystemColors.Control
                                mainform.txtSLLat.ForeColor = Color.Black
                            End If
                            mainform.btnLatte.Enabled = True
                            mainform.picLat.Hide()

                            MsgBox("Added Succesfully")
                            Exit Sub
                        End If
                    End If
                End If

                If row.Cells(0).Value = "Reg-C0107" Then
                    Dim macup = getUserInput()

                    While macup < 0 Or validInput = False Or macup = 0

                        If macup < 0 Or validInput = False Or macup = 0 Then
                            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                            Exit Sub
                        Else
                            MsgBox("Try again!")
                        End If

                        macup = getUserInput()

                    End While

                    If MessageBox.Show("Are you sure you want to add stock(s)?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        If row.Cells(0).Value = "Reg-C0107" Then
                            row.Cells(3).Value = row.Cells(3).Value + macup
                            macadd = mainform.macstock
                            mainform.macstock = macadd + macup
                            macv = mainform.macgrid
                            mainform.macgrid = macv + macup
                            stock = mainform.txtSRMac.Text
                            mainform.txtSRMac.Text = stock + macup

                            current = row.Cells(3).Value
                            If current > 5 And current <= 10 Then
                                row.Cells(4).Value = "Warning"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.Yellow
                            ElseIf current > 0 And current <= 5 Then
                                row.Cells(4).Value = "Low On Stock"
                                row.DefaultCellStyle.ForeColor = Color.White
                                row.DefaultCellStyle.BackColor = Color.Red
                            Else
                                row.Cells(4).Value = "Sufficient"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.White
                            End If

                            If mainform.txtSRMac.Text > 5 And mainform.txtSRMac.Text <= 10 Then
                                mainform.txtSRMac.BackColor = Color.Yellow
                                mainform.txtSRMac.ForeColor = Color.Black

                            ElseIf mainform.txtSRMac.Text > 0 And mainform.txtSRMac.Text <= 5 Then
                                mainform.txtSRMac.BackColor = Color.Red
                                mainform.txtSRMac.ForeColor = Color.White
                            Else
                                mainform.txtSRMac.BackColor = SystemColors.Control
                                mainform.txtSRMac.ForeColor = Color.Black
                            End If
                            mainform.btnMacchiato.Enabled = True
                            mainform.picMac.Hide()

                            MsgBox("Added Succesfully")
                            Exit Sub
                        End If
                    End If
                End If

                If row.Cells(0).Value = "Med-C0107" Then
                    Dim mmacup = getUserInput()

                    While mmacup < 0 Or validInput = False Or mmacup = 0

                        If mmacup < 0 Or validInput = False Or mmacup = 0 Then
                            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                            Exit Sub
                        Else
                            MsgBox("Try again!")
                        End If

                        mmacup = getUserInput()

                    End While

                    If MessageBox.Show("Are you sure you want to add stock(s)?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        If row.Cells(0).Value = "Med-C0107" Then
                            row.Cells(3).Value = row.Cells(3).Value + mmacup
                            mmacadd = mainform.mmacstock
                            mainform.mmacstock = mmacadd + mmacup
                            mmacv = mainform.mmacgrid
                            mainform.mmacgrid = mmacv + mmacup
                            stock = mainform.txtSMMac.Text
                            mainform.txtSMMac.Text = stock + mmacup

                            current = row.Cells(3).Value
                            If current > 5 And current <= 10 Then
                                row.Cells(4).Value = "Warning"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.Yellow
                            ElseIf current > 0 And current <= 5 Then
                                row.Cells(4).Value = "Low On Stock"
                                row.DefaultCellStyle.ForeColor = Color.White
                                row.DefaultCellStyle.BackColor = Color.Red
                            Else
                                row.Cells(4).Value = "Sufficient"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.White
                            End If

                            If mainform.txtSMMac.Text > 5 And mainform.txtSMMac.Text <= 10 Then
                                mainform.txtSMMac.BackColor = Color.Yellow
                                mainform.txtSMMac.ForeColor = Color.Black

                            ElseIf mainform.txtSMMac.Text > 0 And mainform.txtSMMac.Text <= 5 Then
                                mainform.txtSMMac.BackColor = Color.Red
                                mainform.txtSMMac.ForeColor = Color.White
                            Else
                                mainform.txtSMMac.BackColor = SystemColors.Control
                                mainform.txtSMMac.ForeColor = Color.Black
                            End If
                            mainform.btnMacchiato.Enabled = True
                            mainform.picMac.Hide()

                            MsgBox("Added Succesfully")
                            Exit Sub
                        End If
                    End If
                End If

                If row.Cells(0).Value = "Lar-C0107" Then
                    Dim lmacup = getUserInput()

                    While lmacup < 0 Or validInput = False Or lmacup = 0

                        If lmacup < 0 Or validInput = False Or lmacup = 0 Then
                            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                            Exit Sub
                        Else
                            MsgBox("Try again!")
                        End If

                        lmacup = getUserInput()

                    End While

                    If MessageBox.Show("Are you sure you want to add stock(s)?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                        If row.Cells(0).Value = "Lar-C0107" Then
                            row.Cells(3).Value = row.Cells(3).Value + lmacup
                            lmacadd = mainform.lmacstock
                            mainform.lmacstock = lmacadd + lmacup
                            lmacv = mainform.lmacgrid
                            mainform.lmacgrid = lmacv + lmacup
                            stock = mainform.txtSLMac.Text
                            mainform.txtSLMac.Text = stock + lmacup

                            current = row.Cells(3).Value
                            If current > 5 And current <= 10 Then
                                row.Cells(4).Value = "Warning"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.Yellow
                            ElseIf current > 0 And current <= 5 Then
                                row.Cells(4).Value = "Low On Stock"
                                row.DefaultCellStyle.ForeColor = Color.White
                                row.DefaultCellStyle.BackColor = Color.Red
                            Else
                                row.Cells(4).Value = "Sufficient"
                                row.DefaultCellStyle.ForeColor = Color.Black
                                row.DefaultCellStyle.BackColor = Color.White
                            End If

                            If mainform.txtSLMac.Text > 5 And mainform.txtSLMac.Text <= 10 Then
                                mainform.txtSLMac.BackColor = Color.Yellow
                                mainform.txtSLMac.ForeColor = Color.Black

                            ElseIf mainform.txtSLMac.Text > 0 And mainform.txtSLMac.Text <= 5 Then
                                mainform.txtSLMac.BackColor = Color.Red
                                mainform.txtSLMac.ForeColor = Color.White
                            Else
                                mainform.txtSLMac.BackColor = SystemColors.Control
                                mainform.txtSLMac.ForeColor = Color.Black
                            End If
                            mainform.btnMacchiato.Enabled = True
                            mainform.picMac.Hide()

                            MsgBox("Added Succesfully")
                            Exit Sub
                        End If
                    End If
                End If

            Next
        Else
            MsgBox("No row has been selected!")
        End If

    End Sub

    Private Sub cmbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategory.SelectedIndexChanged

        If cmbCategory.SelectedItem.Equals("Pizza") Then
            dt.DefaultView.RowFilter = "Category Like '%" & cmbCategory.SelectedItem & "%'"
            txtSearch.Clear()
            Status()
            pnlB.BackColor = Color.DarkRed
            txtSearch.Enabled = False

            For Each row As DataGridViewRow In dtRestock.Rows

                If row.Cells(2).Value = "Bread" Then
                    row.DefaultCellStyle.BackColor = Color.White
                    row.DefaultCellStyle.ForeColor = Color.White

                ElseIf row.Cells(2).Value = "Coffee" Then

                    row.DefaultCellStyle.BackColor = Color.White
                    row.DefaultCellStyle.ForeColor = Color.White

                Else
                    row.DefaultCellStyle.ForeColor = Color.Black
                End If
            Next

        ElseIf cmbCategory.SelectedItem.ToString = "Bread" Then

            dt.DefaultView.RowFilter = "Category Like '%" & cmbCategory.SelectedItem & "%'"
            Status()
            txtSearch.Clear()
            pnlB.BackColor = Color.DarkRed
            txtSearch.Enabled = False

            For Each row As DataGridViewRow In dtRestock.Rows

                If row.Cells(2).Value = "Pizza" Then
                    row.DefaultCellStyle.BackColor = Color.White
                    row.DefaultCellStyle.ForeColor = Color.White

                ElseIf row.Cells(2).Value = "Coffee" Then

                    row.DefaultCellStyle.BackColor = Color.White
                    row.DefaultCellStyle.ForeColor = Color.White

                Else
                    row.DefaultCellStyle.ForeColor = Color.Black
                End If
            Next

        ElseIf cmbCategory.SelectedItem.Equals("Coffee") Then

            dt.DefaultView.RowFilter = "Category Like '%" & cmbCategory.SelectedItem & "%'"
            Status()
            txtSearch.Clear()
            pnlB.BackColor = Color.DarkRed
            txtSearch.Enabled = False

            For Each row As DataGridViewRow In dtRestock.Rows

                If row.Cells(2).Value = "Pizza" Then
                    row.DefaultCellStyle.BackColor = Color.White
                    row.DefaultCellStyle.ForeColor = Color.White

                ElseIf row.Cells(2).Value = "Bread" Then

                    row.DefaultCellStyle.BackColor = Color.White
                    row.DefaultCellStyle.ForeColor = Color.White

                Else
                    row.DefaultCellStyle.ForeColor = Color.Black
                End If
            Next
        Else
            dt.DefaultView.RowFilter = "Category Like '%" & cmbCategory.SelectedItem & "%'"

            Status()
            txtSearch.Clear()
            txtSearch.Select()
            pnlB.BackColor = Color.DarkOrange
            txtSearch.Enabled = True
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        dt.DefaultView.RowFilter = "ProductName Like '%" & txtSearch.Text & "%'"
        Status()

    End Sub

    Private Sub cmbCategory_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmbCategory.KeyPress
        e.Handled = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        frmAdmin.Show()
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        x = Control.MousePosition.X - Me.Location.X
        y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            newpoint = Control.MousePosition
            newpoint.X -= (x)
            newpoint.Y -= (y)
            Me.Location = newpoint

        End If
    End Sub

End Class