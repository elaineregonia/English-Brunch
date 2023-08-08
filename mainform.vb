Public Class mainform

    Dim counter As Integer = 0
    Dim senior, pwd As Decimal
    Public espqty, dopqty, ameqty, capqty, latqty, macqty As Integer
    Public mespqty, mdopqty, mameqty, mcapqty, mlatqty, mmacqty As Integer
    Public lespqty, ldopqty, lameqty, lcapqty, llatqty, lmacqty As Integer
    Public validInput As Boolean
    Public mozstock As Integer = 25
    Public mozmstock As Integer = 25
    Public mozlstock As Integer = 25
    Public bacstock As Integer = 25
    Public mbacstock As Integer = 25
    Public lbacstock As Integer = 25
    Public chistock As Integer = 25
    Public mchistock As Integer = 25
    Public lchistock As Integer = 25
    Public musstock As Integer = 25
    Public mmusstock As Integer = 25
    Public lmusstock As Integer = 25
    Public vegstock As Integer = 25
    Public mvegstock As Integer = 25
    Public lvegstock As Integer = 25
    Public verstock As Integer = 25
    Public mverstock As Integer = 25
    Public lverstock As Integer = 25
    Public rolstock As Integer = 25
    Public frestock As Integer = 25
    Public whestock As Integer = 25
    Public whistock As Integer = 25
    Public banstock As Integer = 25
    Public hotstock As Integer = 25
    Public espstock As Integer = 25
    Public mespstock As Integer = 25
    Public lespstock As Integer = 25
    Public dopstock As Integer = 25
    Public mdopstock As Integer = 25
    Public ldopstock As Integer = 25
    Public amestock As Integer = 25
    Public mamestock As Integer = 25
    Public lamestock As Integer = 25
    Public capstock As Integer = 25
    Public mcapstock As Integer = 25
    Public lcapstock As Integer = 25
    Public latstock As Integer = 25
    Public mlatstock As Integer = 25
    Public llatstock As Integer = 25
    Public macstock As Integer = 25
    Public mmacstock As Integer = 25
    Public lmacstock As Integer = 25
    Public mozprice As Decimal = 450
    Public bacprice As Decimal = 480
    Public chiprice As Decimal = 400
    Public musprice As Decimal = 550
    Public vegprice As Decimal = 500
    Public verprice As Decimal = 650
    Public rolprice As Decimal = 90
    Public freprice As Decimal = 105
    Public wheprice As Decimal = 130
    Public whiprice As Decimal = 150
    Public esprice As Decimal = 180
    Public dopprice As Decimal = 198
    Public ameprice As Decimal = 175
    Public capprice As Decimal = 220
    Public latprice As Decimal = 185
    Public macprice As Decimal = 250
    Public mozgrid, bacgrid, chigrid, musgrid, veggrid, vergrid As Integer
    Public mmozgrid, mbacgrid, mchigrid, mmusgrid, mveggrid, mvergrid As Integer
    Public lmozgrid, lbacgrid, lchigrid, lmusgrid, lveggrid, lvergrid As Integer
    Public rolgrid, fregrid, whegrid, whigrid, bangrid, hotgrid As Integer
    Public espgrid, dopgrid, amegrid, capgrid, latgrid, macgrid As Integer
    Public mespgrid, mdopgrid, mamegrid, mcapgrid, mlatgrid, mmacgrid As Integer
    Public lespgrid, ldopgrid, lamegrid, lcapgrid, llatgrid, lmacgrid As Integer
    Public custype
    Dim SAPI
    Dim mozs, mmozs, lmozs, bacs, mbacs, lbacs, chis, mchis, lchis, muss, mmuss, lmuss, vegs, mvegs, lvegs, vers, mvers, lvers As Integer
    Dim rols, fres, whes, whis, bans, hots As Integer
    Dim esps, mesps, lesps, dops, mdops, ldops, ames, mames, lames, caps, mcaps, lcaps, lats, mlats, llats, macs, mmacs, lmacs As Integer
    Dim mozgr, mmozgr, lmozgr, bacgr, mbacgr, lbacgr, chigr, mchigr, lchigr, musgr, mmusgr, lmusgr, veggr, mveggr, lveggr, vergr, mvergr, lvergr As Integer
    Dim rolgr, fregr, whegr, whigr, bangr, hotgr As Integer
    Dim espgr, mespgr, lespgr, dopgr, mdopgr, ldopgr, amegr, mamegr, lamegr, capgr, mcapgr, lcapgr, latgr, mlatgr, llatgr, macgr, mmacgr, lmacgr As Integer
    Dim newpoint As New System.Drawing.Point
    Dim x, y As Integer
    Dim menu0(17) As PictureBox

    Private Sub mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For Each txt In {txtSRMoz, txtSMMoz, txtSLMoz, txtSRBac, txtSMBac, txtSLBac, txtSRChi, txtSMChi,
                            txtSLChi, txtSRMus, txtSMMus, txtSLMus, txtSRVeg, txtSMVeg, txtSLVeg, txtSRVer, txtSMVer, txtSLVer,
                             txtSRolls, txtSFrench, txtSWheat, txtSWhite, txtSBanana, txtSHotdog, txtSREsp, txtSMEsp, txtSLEsp,
                             txtSRDop, txtSMDop, txtSLDop, txtSRAme, txtSMAme, txtSLAme, txtSRCap, txtSMCap, txtSLCap,
                             txtSRLat, txtSMLat, txtSLLat, txtSRMac, txtSMMac, txtSLMac, txtVAT, txtSTotal, txtDiscount, txtPAmount}
            txt.ReadOnly = True
        Next

        btnHome_click(Nothing, Nothing)
        'SAPI = CreateObject("SAPI.spvoice")
        'SAPI.speak("Welcome to Emglish Brunch!")

        txtCName.Select()
        Timer1.Enabled = True


        menu0(0) = picPiz1
        menu0(1) = picPiz2
        menu0(2) = picPiz3
        menu0(3) = picPiz4
        menu0(4) = picPiz5
        menu0(5) = picPiz6
        menu0(6) = picCof1
        menu0(7) = picCof2
        menu0(8) = picCof3
        menu0(9) = picCof4
        menu0(10) = picCof5
        menu0(11) = picCof6
        menu0(12) = picBre1
        menu0(13) = picBre2
        menu0(14) = picBre3
        menu0(15) = picBre4
        menu0(16) = picBre5
        menu0(17) = picBre6

    End Sub

    Sub compute()
        Dim vat As Decimal = Total() * 0.12
        Dim totalpay As Decimal
        Dim discounts As Decimal
        Dim iTotal As Decimal
        Dim iDiscount As Decimal
        Dim bFlag

        bFlag = Decimal.TryParse(txtDiscount.Text.Trim(), iDiscount)
        bFlag = Decimal.TryParse(Total, iTotal)

        If dtSummary.Rows.Count > 0 Then

            txtVAT.Text = vat
            txtDiscount.Text = "0.00"
            txtSTotal.Text = Total().ToString("0.00")
            totalpay = Total() + vat
            txtPAmount.Text = totalpay.ToString("0.00")

            If rbtnSenior.Checked = True Then

                discounts = iTotal * 0.2
                txtVAT.Text = "VAT Exemption"
                txtDiscount.Text = discounts.ToString("0.00")
                senior = iTotal - discounts
                txtPAmount.Text = senior.ToString("0.00")
                custype = "Senior"

            ElseIf rbtnPWD.Checked = True Then

                discounts = iTotal * 0.2
                txtVAT.Text = "VAT Exemption"
                txtDiscount.Text = discounts.ToString("0.00")
                pwd = iTotal - discounts
                txtPAmount.Text = pwd.ToString("0.00")
                custype = "PWD"

            Else

                txtDiscount.Text = "0.00"
                txtVAT.Text = vat.ToString("0.00")
                totalpay = Total() + vat
                txtPAmount.Text = totalpay.ToString("0.00")
                custype = "Regular"

            End If

        Else
            txtVAT.Text = "0.00"
            txtDiscount.Text = "0.00"
            txtSTotal.Text = Total().ToString("0.00")
            txtPAmount.Text = totalpay.ToString("0.00")
            custype = "Regular"
        End If

    End Sub

    Private Function Total() As Double
        Dim tot As Double = 0
        Dim i As Integer = 0

        For i = 0 To dtSummary.Rows.Count - 1
            tot += Convert.ToDouble(dtSummary.Rows(i).Cells(5).Value)
        Next i
        Return tot


    End Function

    Function inputValidMoz(input As Integer)

        If input > mozstock Then

            Return False

        End If

        Return True
    End Function

    Function inputValidMMoz(input As Integer)

        If input > mozmstock Then

            Return False

        End If

        Return True
    End Function

    Function inputValidLMoz(input As Integer)

        If input > mozlstock Then

            Return False

        End If

        Return True
    End Function

    Function inputValidBac(input As Integer)

        If input > bacstock Then

            Return False

        End If

        Return True
    End Function

    Function inputValidMBac(input As Integer)

        If input > mbacstock Then

            Return False

        End If

        Return True
    End Function

    Function inputValidLBac(input As Integer)

        If input > lbacstock Then

            Return False

        End If

        Return True
    End Function

    Function inputValidChi(input As Integer)

        If input > chistock Then

            Return False

        End If

        Return True
    End Function

    Function inputValidMChi(input As Integer)

        If input > mchistock Then

            Return False

        End If

        Return True
    End Function

    Function inputValidLChi(input As Integer)

        If input > lchistock Then

            Return False

        End If

        Return True
    End Function

    Function inputValidMus(input As Integer)

        If input > musstock Then

            Return False

        End If

        Return True
    End Function

    Function inputValidMMus(input As Integer)

        If input > mmusstock Then

            Return False

        End If

        Return True
    End Function

    Function inputValidLMus(input As Integer)

        If input > lmusstock Then

            Return False

        End If

        Return True
    End Function

    Function inputValidVeg(input As Integer)

        If input > vegstock Then

            Return False

        End If

        Return True
    End Function

    Function inputValidMVeg(input As Integer)

        If input > mvegstock Then

            Return False

        End If

        Return True
    End Function

    Function inputValidLVeg(input As Integer)

        If input > lvegstock Then

            Return False

        End If

        Return True
    End Function

    Function inputValidVer(input As Integer)

        If input > verstock Then

            Return False

        End If

        Return True
    End Function

    Function inputValidMVer(input As Integer)

        If input > mverstock Then

            Return False

        End If

        Return True
    End Function

    Function inputValidLVer(input As Integer)

        If input > lverstock Then

            Return False

        End If

        Return True
    End Function

    Function inputValidRol(input As Integer)

        If input > rolstock Then

            Return False

        End If

        Return True
    End Function

    Function inputValidFre(input As Integer)

        If input > frestock Then

            Return False

        End If

        Return True
    End Function

    Function inputValidWhe(input As Integer)

        If input > whestock Then

            Return False

        End If

        Return True
    End Function

    Function inputValidWhi(input As Integer)

        If input > whistock Then

            Return False

        End If

        Return True
    End Function

    Function inputValidBan(input As Integer)

        If input > banstock Then

            Return False

        End If

        Return True
    End Function

    Function inputValidHot(input As Integer)

        If input > hotstock Then

            Return False

        End If

        Return True
    End Function

    Function inputValidEsp(input As Integer)

        If input > espstock Then

            Return False

        End If

        Return True
    End Function

    Function inputValidMEsp(input As Integer)

        If input > mespstock Then

            Return False

        End If

        Return True
    End Function

    Function inputValidLEsp(input As Integer)

        If input > lespstock Then

            Return False

        End If

        Return True
    End Function

    Function inputValidDop(input As Integer)

        If input > dopstock Then

            Return False

        End If

        Return True
    End Function

    Function inputValidMDop(input As Integer)

        If input > mdopstock Then

            Return False

        End If

        Return True
    End Function

    Function inputValidLDop(input As Integer)

        If input > ldopstock Then

            Return False

        End If

        Return True
    End Function

    Function inputValidAme(input As Integer)

        If input > amestock Then

            Return False

        End If

        Return True
    End Function

    Function inputValidMAme(input As Integer)

        If input > mamestock Then

            Return False

        End If

        Return True
    End Function

    Function inputValidLAme(input As Integer)

        If input > lamestock Then

            Return False

        End If

        Return True
    End Function

    Function inputValidCap(input As Integer)

        If input > capstock Then

            Return False

        End If

        Return True
    End Function

    Function inputValidMCap(input As Integer)

        If input > mcapstock Then

            Return False

        End If

        Return True
    End Function

    Function inputValidLCap(input As Integer)

        If input > lcapstock Then

            Return False

        End If

        Return True
    End Function

    Function inputValidLat(input As Integer)

        If input > latstock Then

            Return False

        End If

        Return True
    End Function

    Function inputValidMLat(input As Integer)

        If input > mlatstock Then

            Return False

        End If

        Return True
    End Function

    Function inputValidLLat(input As Integer)

        If input > llatstock Then

            Return False

        End If

        Return True
    End Function

    Function inputValidMac(input As Integer)

        If input > macstock Then

            Return False

        End If

        Return True
    End Function

    Function inputValidMMac(input As Integer)

        If input > mmacstock Then

            Return False

        End If

        Return True
    End Function

    Function inputValidLMac(input As Integer)

        If input > lmacstock Then

            Return False

        End If

        Return True
    End Function

    Function getUserInput()
        Dim input As Integer
        Dim userinput = InputBox("Enter Quantity ", "Quantity")
        validInput = Integer.TryParse(userinput, input)


        Return input
    End Function

    Sub rdbtns()
        rbtnRegularMoz.Checked = False
        rbtnMediumMoz.Checked = False
        rbtnLargeMoz.Checked = False
        rbtnRegularBac.Checked = False
        rbtnMediumBac.Checked = False
        rbtnLargeBac.Checked = False
        rbtnRegularChi.Checked = False
        rbtnMediumChi.Checked = False
        rbtnLargeChi.Checked = False
        rbtnRegularMus.Checked = False
        rbtnMediumMus.Checked = False
        rbtnLargeMus.Checked = False
        rbtnRegularVeg.Checked = False
        rbtnMediumVeg.Checked = False
        rbtnLargeVeg.Checked = False
        rbtnRegularVer.Checked = False
        rbtnMediumVer.Checked = False
        rbtnLargeVer.Checked = False
        rbtnRegularEsp.Checked = False
        rbtnMediumEsp.Checked = False
        rbtnLargeEsp.Checked = False
        rbtnRegularDop.Checked = False
        rbtnMediumDop.Checked = False
        rbtnLargeDop.Checked = False
        rbtnRegularAme.Checked = False
        rbtnMediumAme.Checked = False
        rbtnLargeAme.Checked = False
        rbtnRegularCap.Checked = False
        rbtnMediumCap.Checked = False
        rbtnLargeCap.Checked = False
        rbtnRegularLat.Checked = False
        rbtnMediumLat.Checked = False
        rbtnLargeLat.Checked = False
        rbtnRegularMac.Checked = False
        rbtnMediumMac.Checked = False
        rbtnLargeMac.Checked = False

        'lblMozPrice.Text = mozprice.ToString("0.00")
        'lblBaconPrice.Text = bacprice.ToString("0.00")
        'lblChiliPrice.Text = chiprice.ToString("0.00")
        'lblMushroomPrice.Text = musprice.ToString("0.00")
        'lblVegePrice.Text = vegprice.ToString("0.00")
        'lblVerPrice.Text = verprice.ToString("0.00")
        'lblEspPrice.Text = esprice.ToString("0.00")
        'lblDopPri.Text = dopprice.ToString("0.00")
        'lblAmePri.Text = ameprice.ToString("0.00")
        'lblCapPrice.Text = capprice.ToString("0.00")
        'lblLatPrice.Text = latprice.ToString("0.00")
        'lblMacPrice.Text = macprice.ToString("0.00")

    End Sub

    Private Sub dtSummary_CellValueChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dtSummary.CellValueChanged
        compute()
    End Sub

    Private Sub btnMozzarella_Click(sender As Object, e As EventArgs) Handles btnMozzarella.Click
        Dim Price_Mozzarella As Integer = Val(lblMozPrice.Text)

        If rbtnRegularMoz.Checked = True Then

            Dim mozqty = getUserInput()


            Dim is_valid As Boolean
            is_valid = inputValidMoz(mozqty)

            If validInput = False Then
                MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                rdbtns()
            Else

                While is_valid = False Or mozqty < 0 Or validInput = False Or mozqty = 0 Or mozqty > txtSRMoz.Text

                    If mozqty > txtSRMoz.Text And mozqty < 26 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                    ElseIf mozqty > 25 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        Exit Sub
                    ElseIf mozqty < 0 Or validInput = False Or mozqty = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                        Exit Sub
                    End If

                    mozqty = getUserInput()
                    is_valid = inputValidMoz(mozqty)

                End While
                If MsgBox("Are you sure to process this order?", vbQuestion + vbYesNo, "Process Order") = vbYes Then
                    While counter <= 23
                        rdbtns()

                        For Each row As DataGridViewRow In dtSummary.Rows
                            If row.Cells(0).Value = "Reg-P0102" Then
                                mozgr = row.Cells(4).Value
                                mozgrid = mozgr + mozqty
                                row.Cells(4).Value = mozgrid
                                row.Cells(5).Value = Integer.Parse(row.Cells(4).Value) * Price_Mozzarella

                                mozs = mozstock
                                txtSRMoz.Text = mozs - mozgrid


                                Exit Sub
                            End If

                        Next

                        dtSummary.Rows.Add("Reg-P0102", "Mozzarella", lblMozPrice.Text, "Pizza", "0", Price_Mozzarella)
                        compute()

                    End While
                Else
                    'mozqty -= input
                    rdbtns()
                    Exit Sub
                End If
                rdbtns()
            End If

        ElseIf rbtnMediumMoz.Checked = True Then

            Dim mmozqty = getUserInput()

            Dim is_valid As Boolean
            is_valid = inputValidMMoz(mmozqty)

            If validInput = False Then
                MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                rdbtns()
            Else

                While is_valid = False Or mmozqty < 0 Or validInput = False Or mmozqty = 0 Or mmozqty > txtSMMoz.Text

                    'mmozqty -= input

                    If mmozqty > txtSMMoz.Text And mmozqty < 26 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                    ElseIf mmozqty > 25 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                        Exit Sub
                    ElseIf mmozqty < 0 Or validInput = False Or mmozqty = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        rdbtns()
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                        Exit Sub
                    End If

                    mmozqty = getUserInput()
                    is_valid = inputValidMMoz(mmozqty)

                End While
                If MsgBox("Are you sure to process this order?", vbQuestion + vbYesNo, "Process Order") = vbYes Then
                    While counter <= 23

                        rdbtns()

                        For Each row As DataGridViewRow In dtSummary.Rows
                            If row.Cells(0).Value = "Med-P0102" Then

                                mmozgr = row.Cells(4).Value
                                mmozgrid = mmozgr + mmozqty
                                row.Cells(4).Value = mmozgrid
                                row.Cells(5).Value = Integer.Parse(row.Cells(4).Value) * Price_Mozzarella


                                mmozs = mozmstock
                                txtSMMoz.Text = mmozs - mmozgrid

                                Exit Sub
                            End If

                        Next

                        dtSummary.Rows.Add("Med-P0102", "Mozzarella", lblMozPrice.Text, "Pizza", "0", Price_Mozzarella)
                        compute()

                    End While
                Else

                    rdbtns()
                    Exit Sub
                End If
            End If
        ElseIf rbtnLargeMoz.Checked = True Then

            Dim lmozqty = getUserInput()

            Dim is_valid As Boolean
            is_valid = inputValidLMoz(lmozqty)

            If validInput = False Then
                MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                rdbtns()
            Else

                While is_valid = False Or lmozqty < 0 Or validInput = False Or lmozqty = 0 Or lmozqty > txtSLMoz.Text

                    'lmozqty -= input


                    If lmozqty > txtSLMoz.Text And lmozqty < 26 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                    ElseIf lmozqty > 25 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                        Exit Sub
                    ElseIf lmozqty < 0 Or validInput = False Or lmozqty = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        rdbtns()
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                        Exit Sub
                    End If

                    lmozqty = getUserInput()
                    is_valid = inputValidLMoz(lmozqty)

                End While
                If MsgBox("Are you sure to process this order?", vbQuestion + vbYesNo, "Process Order") = vbYes Then
                    While counter <= 23

                        rdbtns()

                        For Each row As DataGridViewRow In dtSummary.Rows
                            If row.Cells(0).Value = "Lar-P0102" Then

                                lmozgr = row.Cells(4).Value
                                lmozgrid = lmozgr + lmozqty
                                row.Cells(4).Value = lmozgrid
                                row.Cells(5).Value = Integer.Parse(row.Cells(4).Value) * Price_Mozzarella

                                lmozs = mozlstock
                                txtSLMoz.Text = lmozs - lmozgrid

                                Exit Sub
                            End If

                        Next

                        dtSummary.Rows.Add("Lar-P0102", "Mozzarella", lblMozPrice.Text, "Pizza", "0", Price_Mozzarella)
                        compute()

                    End While
                Else
                    'lmozqty -= input
                    rdbtns()
                    Exit Sub
                End If

            End If
        Else
            MsgBox("Please choose a variation")
            SAPI = CreateObject("SAPI.spvoice")
            SAPI.speak("Please choose a variation.")
        End If

    End Sub

    Private Sub txtSRMoz_TextChanged(sender As Object, e As EventArgs) Handles txtSRMoz.TextChanged

        If txtSRMoz.Text <= 0 Then

            txtSRMoz.BackColor = Color.DarkRed
            txtSRMoz.ForeColor = Color.White
            MsgBox("Out of Stock", 48, "Out of Stock")
            'SAPI = CreateObject("SAPI.spvoice")
            'SAPI.speak("Out of Stock! Let the admin know immediately.")
            rbtnRegularMoz.Enabled = False

        ElseIf txtSRMoz.Text > 5 And txtSRMoz.Text <= 10 Then

            txtSRMoz.BackColor = Color.Yellow
            txtSRMoz.ForeColor = Color.Black
            MsgBox("Your current stock number is " + txtSRMoz.Text + "!", 48, "Warning")
            'SAPI = CreateObject("SAPI.spvoice")
            'SAPI.speak("Your current stock number is " + txtSRMoz.Text + "! Let the admin know immediately.")

        ElseIf txtSRMoz.Text > 0 And txtSRMoz.Text <= 5 Then

            txtSRMoz.BackColor = Color.Red
            txtSRMoz.ForeColor = Color.White
            MsgBox("Low on stock!", 48, "Critical")
            'SAPI = CreateObject("SAPI.spvoice")
            'SAPI.speak("Low on stock! Let the admin know immediately.")


        Else
            picMoz.Hide()
            btnMozzarella.Enabled = True
            rbtnRegularMoz.Enabled = True
        End If

    End Sub

    Private Sub txtMRMoz_TextChanged(sender As Object, e As EventArgs) Handles txtSMMoz.TextChanged

        If txtSMMoz.Text <= 0 Then

            txtSMMoz.BackColor = Color.DarkRed
            txtSMMoz.ForeColor = Color.White
            MsgBox("Out of Stock", 48, "Out of Stock")
            'SAPI = CreateObject("SAPI.spvoice")
            'SAPI.speak("Out of Stock! Let the admin know immediately.")

            rbtnMediumMoz.Enabled = False

        ElseIf txtSMMoz.Text > 5 And txtSMMoz.Text <= 10 Then

            txtSMMoz.BackColor = Color.Yellow
            txtSMMoz.ForeColor = Color.Black
            MsgBox("Your current stock number is " + txtSMMoz.Text + "!", 48, "Warning")
            'SAPI = CreateObject("SAPI.spvoice")
            'SAPI.speak("Your current stock number is " + txtSMMoz.Text + "! Let the admin know immediately.")


        ElseIf txtSMMoz.Text > 0 And txtSMMoz.Text <= 5 Then

            txtSMMoz.BackColor = Color.Red
            txtSMMoz.ForeColor = Color.White
            MsgBox("Low on stock!", 48, "Critical")
            'SAPI = CreateObject("SAPI.spvoice")
            'SAPI.speak("Low on stock! Let the admin know immediately.")

        Else
            picMoz.Hide()
            btnMozzarella.Enabled = True
            rbtnMediumMoz.Enabled = True
        End If

    End Sub

    Private Sub txtSLMoz_TextChanged(sender As Object, e As EventArgs) Handles txtSLMoz.TextChanged

        If txtSLMoz.Text <= 0 Then

            txtSLMoz.BackColor = Color.DarkRed
            txtSLMoz.ForeColor = Color.White
            MsgBox("Out of Stock", 48, "Out of Stock")
            'SAPI = CreateObject("SAPI.spvoice")
            'SAPI.speak("Out of Stock! Let the admin know immediately.")
            rbtnLargeMoz.Enabled = False

        ElseIf txtSLMoz.Text > 5 And txtSLMoz.Text <= 10 Then

            txtSLMoz.BackColor = Color.Yellow
            txtSLMoz.ForeColor = Color.Black
            MsgBox("Your current stock number is " + txtSLMoz.Text + "!", 48, "Warning")
            'SAPI = CreateObject("SAPI.spvoice")
            'SAPI.speak("Your current stock number is " + txtSLMoz.Text + "! Let the admin know immediately.")


        ElseIf txtSLMoz.Text > 0 And txtSLMoz.Text <= 5 Then

            txtSLMoz.BackColor = Color.Red
            txtSLMoz.ForeColor = Color.White
            MsgBox("Low on stock!", 48, "Critical")
            'SAPI = CreateObject("SAPI.spvoice")
            'SAPI.speak("Low on stock! Let the admin know immediately.")

        Else
            picMoz.Hide()
            btnMozzarella.Enabled = True
            rbtnLargeMoz.Enabled = True
        End If

    End Sub

    Private Sub MozzaStocks(sender As Object, e As EventArgs) Handles txtSRMoz.TextChanged, txtSMMoz.TextChanged, txtSLMoz.TextChanged

        Dim reg As Integer
        Dim med As Integer
        Dim lar As Integer
        Dim bFlag

        bFlag = Integer.TryParse(txtSRMoz.Text.Trim(), reg)
        bFlag = Integer.TryParse(txtSMMoz.Text.Trim, med)
        bFlag = Integer.TryParse(txtSLMoz.Text.Trim, lar)


        If reg <= 0 And med <= 0 And lar <= 0 Then
            picMoz.Show()
            rdbtns()
            MsgBox("Out of Stock", 48, "Out of Stock")
            SAPI = CreateObject("SAPI.spvoice")
            SAPI.speak("Out of Stock! Let the admin know immediately.")

        Else
            picMoz.Hide()
        End If
    End Sub

    Private Sub rbtnRegularMoz_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnRegularMoz.CheckedChanged
        lblMozPrice.Text = mozprice.ToString("0.00")
    End Sub

    Private Sub rbtnMediumMoz_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnMediumMoz.CheckedChanged
        lblMozPrice.Text = mozprice.ToString("0.00") + 50 & ".00"
    End Sub

    Private Sub rbtnLargeMoz_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnLargeMoz.CheckedChanged
        lblMozPrice.Text = mozprice.ToString("0.00") + 100 & ".00"
    End Sub

    Private Sub btnBacon_Click(sender As Object, e As EventArgs) Handles btnBacon.Click
        Dim Price_Bacon As Integer = Val(lblBaconPrice.Text)

        If rbtnRegularBac.Checked = True Then
            Dim bacqty = getUserInput()

            Dim is_valid As Boolean
            is_valid = inputValidBac(bacqty)

            If validInput = False Then
                MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                rdbtns()

            Else
                While is_valid = False Or bacqty < 0 Or validInput = False Or bacqty = 0 Or bacqty > txtSRBac.Text

                    'bacqty -= input
                    If bacqty > txtSRBac.Text And bacqty < 26 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                    ElseIf bacqty > 25 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                        Exit Sub
                    ElseIf bacqty < 0 Or validInput = False Or bacqty = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        rdbtns()
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    bacqty = getUserInput()
                    is_valid = inputValidBac(bacqty)
                End While
                If MsgBox("Are you sure to process this order?", vbQuestion + vbYesNo, "Process Order") = vbYes Then
                    While counter <= 23

                        rdbtns()

                        For Each row As DataGridViewRow In dtSummary.Rows
                            If row.Cells(0).Value = "Reg-P0103" Then

                                bacgr = row.Cells(4).Value
                                bacgrid = bacgr + bacqty
                                row.Cells(4).Value = bacgrid
                                row.Cells(5).Value = Integer.Parse(row.Cells(4).Value) * Price_Bacon

                                bacs = bacstock
                                txtSRBac.Text = bacs - bacgrid

                                Exit Sub
                            End If

                        Next

                        dtSummary.Rows.Add("Reg-P0103", "Bacon", lblBaconPrice.Text, "Pizza", "0", Price_Bacon)
                        compute()

                    End While
                Else
                    rdbtns()
                    'bacqty -= input
                    Exit Sub
                End If
            End If

        ElseIf rbtnMediumBac.Checked = True Then

            Dim mbacqty = getUserInput()

            Dim is_valid As Boolean
            is_valid = inputValidMBac(mbacqty)

            If validInput = False Then
                MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                rdbtns()
            Else
                While is_valid = False Or mbacqty < 0 Or validInput = False Or mbacqty = 0 Or mbacqty > txtSMBac.Text

                    'mbacqty -= input
                    If mbacqty > txtSMBac.Text And mbacqty < 26 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                    ElseIf mbacqty > 25 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                        Exit Sub
                    ElseIf mbacqty < 0 Or validInput = False Or mbacqty = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        rdbtns()
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    mbacqty = getUserInput()
                    is_valid = inputValidMBac(mbacqty)
                End While
                If MsgBox("Are you sure to process this order?", vbQuestion + vbYesNo, "Process Order") = vbYes Then
                    While counter <= 23
                        rdbtns()
                        For Each row As DataGridViewRow In dtSummary.Rows
                            If row.Cells(0).Value = "Med-P0103" Then

                                mbacgr = row.Cells(4).Value
                                mbacgrid = mbacgr + mbacqty
                                row.Cells(4).Value = mbacgrid
                                row.Cells(5).Value = Integer.Parse(row.Cells(4).Value) * Price_Bacon

                                mbacs = mbacstock
                                txtSMBac.Text = mbacs - mbacgrid

                                Exit Sub
                            End If

                        Next

                        dtSummary.Rows.Add("Med-P0103", "Bacon", lblBaconPrice.Text, "Pizza", "0", Price_Bacon)
                        compute()

                    End While
                Else
                    rdbtns()
                    'mbacqty -= input
                    Exit Sub
                End If
            End If

        ElseIf rbtnLargeBac.Checked = True Then

            Dim lbacqty = getUserInput()

            Dim is_valid As Boolean
            is_valid = inputValidLBac(lbacqty)

            If validInput = False Then
                MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                rdbtns()
            Else
                While is_valid = False Or lbacqty < 0 Or validInput = False Or lbacqty = 0 Or lbacqty > txtSLBac.Text

                    'lbacqty -= input
                    If lbacqty > txtSLBac.Text And lbacqty < 26 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                    ElseIf lbacqty > 25 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                        Exit Sub
                    ElseIf lbacqty < 0 Or validInput = False Or lbacqty = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        rdbtns()
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    lbacqty = getUserInput()
                    is_valid = inputValidLBac(lbacqty)
                End While
                If MsgBox("Are you sure to process this order?", vbQuestion + vbYesNo, "Process Order") = vbYes Then
                    While counter <= 23
                        rdbtns()
                        For Each row As DataGridViewRow In dtSummary.Rows
                            If row.Cells(0).Value = "Lar-P0103" Then

                                lbacgr = row.Cells(4).Value
                                lbacgrid = lbacgr + lbacqty
                                row.Cells(4).Value = lbacgrid
                                row.Cells(5).Value = Integer.Parse(row.Cells(4).Value) * Price_Bacon

                                lbacs = lbacstock
                                txtSLBac.Text = lbacs - lbacgrid

                                Exit Sub
                            End If

                        Next

                        dtSummary.Rows.Add("Lar-P0103", "Bacon", lblBaconPrice.Text, "Pizza", "0", Price_Bacon)
                        compute()

                    End While
                Else
                    rdbtns()
                    Exit Sub
                End If
            End If

        Else
            MsgBox("Please choose a variation.")
            SAPI = CreateObject("SAPI.spvoice")
            SAPI.speak("Please choose a variation.")

        End If


    End Sub

    Private Sub txtSRBac_TextChanged(sender As Object, e As EventArgs) Handles txtSRBac.TextChanged

        If txtSRBac.Text <= 0 Then

            txtSRBac.BackColor = Color.DarkRed
            txtSRBac.ForeColor = Color.White
            MsgBox("Out of Stock", 48, "Out of Stock")
            rbtnRegularBac.Enabled = False

        ElseIf txtSRBac.Text > 5 And txtSRBac.Text <= 10 Then

            txtSRBac.BackColor = Color.Yellow
            txtSRBac.ForeColor = Color.Black
            MsgBox("Your current stock number is " + txtSRBac.Text + "!", 48, "Warning")

        ElseIf txtSRBac.Text > 0 And txtSRBac.Text <= 5 Then

            txtSRBac.BackColor = Color.Red
            txtSRBac.ForeColor = Color.White
            MsgBox("Low on stock!", 48, "Critical")


        Else
            picBac.Hide()
            btnBacon.Enabled = True
            rbtnRegularBac.Enabled = True
        End If

    End Sub

    Private Sub txtMRBac_TextChanged(sender As Object, e As EventArgs) Handles txtSMBac.TextChanged

        If txtSMBac.Text <= 0 Then

            txtSMBac.BackColor = Color.DarkRed
            txtSMBac.ForeColor = Color.White
            MsgBox("Out of Stock", 48, "Out of Stock")
            rbtnMediumBac.Enabled = False

        ElseIf txtSMBac.Text > 5 And txtSMBac.Text <= 10 Then

            txtSMBac.BackColor = Color.Yellow
            txtSMBac.ForeColor = Color.Black
            MsgBox("Your current stock number is " + txtSMBac.Text + "!", 48, "Warning")

        ElseIf txtSMBac.Text > 0 And txtSMBac.Text <= 5 Then

            txtSMBac.BackColor = Color.Red
            txtSMBac.ForeColor = Color.White
            MsgBox("Low on stock!", 48, "Critical")


        Else
            picBac.Hide()
            btnBacon.Enabled = True
            rbtnMediumBac.Enabled = True
        End If

    End Sub

    Private Sub txtSLBac_TextChanged(sender As Object, e As EventArgs) Handles txtSLBac.TextChanged

        If txtSLBac.Text <= 0 Then

            txtSLBac.BackColor = Color.DarkRed
            txtSLBac.ForeColor = Color.White
            MsgBox("Out of Stock", 48, "Out of Stock")
            rbtnLargeBac.Enabled = False

        ElseIf txtSLBac.Text > 5 And txtSLBac.Text <= 10 Then

            txtSLBac.BackColor = Color.Yellow
            txtSLBac.ForeColor = Color.Black
            MsgBox("Your current stock number is " + txtSLBac.Text + "!", 48, "Warning")

        ElseIf txtSLBac.Text > 0 And txtSLBac.Text <= 5 Then

            txtSLBac.BackColor = Color.Red
            txtSLBac.ForeColor = Color.White
            MsgBox("Low on stock!", 48, "Critical")


        Else
            picBac.Hide()
            btnBacon.Enabled = True
            rbtnLargeBac.Enabled = True
        End If

    End Sub

    Private Sub BaconStocks(sender As Object, e As EventArgs) Handles txtSRBac.TextChanged, txtSMBac.TextChanged, txtSLBac.TextChanged

        Dim reg As Integer
        Dim med As Integer
        Dim lar As Integer
        Dim bFlag

        bFlag = Integer.TryParse(txtSRBac.Text.Trim(), reg)
        bFlag = Integer.TryParse(txtSMBac.Text.Trim, med)
        bFlag = Integer.TryParse(txtSLBac.Text.Trim, lar)


        If reg <= 0 And med <= 0 And lar <= 0 Then
            picBac.Show()
            rdbtns()
            MsgBox("Out of Stock", 48, "Out of Stock")
        Else
            picBac.Hide()
        End If
    End Sub

    Private Sub rbtnRegularBac_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnRegularBac.CheckedChanged
        lblBaconPrice.Text = bacprice.ToString("0.00")
    End Sub

    Private Sub rbtnMediumBac_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnMediumBac.CheckedChanged
        lblBaconPrice.Text = bacprice.ToString("0.00") + 50 & ".00"
    End Sub

    Private Sub rbtnLargeBac_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnLargeBac.CheckedChanged
        lblBaconPrice.Text = bacprice.ToString("0.00") + 100 & ".00"
    End Sub

    Private Sub btnChili_Click(sender As Object, e As EventArgs) Handles btnChili.Click
        Dim Price_Chili As Integer = Val(lblChiliPrice.Text)

        If rbtnRegularChi.Checked = True Then

            Dim chiliqty = getUserInput()

            Dim is_valid As Boolean
            is_valid = inputValidChi(chiliqty)

            If validInput = False Then
                MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                rdbtns()
            Else

                While is_valid = False Or chiliqty < 0 Or validInput = False Or chiliqty = 0 Or chiliqty > txtSRChi.Text

                    If chiliqty > txtSRChi.Text And chiliqty < 26 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                    ElseIf chiliqty > 25 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                        Exit Sub
                    ElseIf chiliqty < 0 Or validInput = False Or chiliqty = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        rdbtns()
                        Exit Sub
                        MsgBox("Try again!")
                    End If

                    chiliqty = getUserInput()
                    is_valid = inputValidChi(chiliqty)
                End While

                If MsgBox("Are you sure to process this order?", vbQuestion + vbYesNo, "Process Order") = vbYes Then
                    While counter <= 23

                        rdbtns()

                        For Each row As DataGridViewRow In dtSummary.Rows
                            If row.Cells(0).Value = "Reg-P0104" Then

                                chigr = row.Cells(4).Value
                                chigrid = chigr + chiliqty
                                row.Cells(4).Value = chigrid
                                row.Cells(5).Value = Integer.Parse(row.Cells(4).Value) * Price_Chili

                                chis = chistock
                                txtSRChi.Text = chis - chigrid

                                Exit Sub
                            End If

                        Next

                        dtSummary.Rows.Add("Reg-P0104", "Chili Pepper", lblChiliPrice.Text, "Pizza", "0", Price_Chili)
                        compute()


                    End While
                Else
                    rdbtns()
                    Exit Sub
                End If

            End If

        ElseIf rbtnMediumChi.Checked = True Then

            Dim mchiliqty = getUserInput()

            Dim is_valid As Boolean
            is_valid = inputValidMChi(mchiliqty)

            If validInput = False Then
                MsgBox("Cannot be processed!", vbCritical, "Invalid Input")

            Else

                While is_valid = False Or mchiliqty < 0 Or validInput = False Or mchiliqty = 0 Or mchiliqty > txtSMChi.Text

                    If mchiliqty > txtSMChi.Text And mchiliqty < 26 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                    ElseIf mchiliqty > 25 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                        Exit Sub
                    ElseIf mchiliqty < 0 Or validInput = False Or mchiliqty = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        rdbtns()
                        Exit Sub
                        MsgBox("Try again!")
                    End If

                    mchiliqty = getUserInput()
                    is_valid = inputValidMChi(mchiliqty)
                End While

                If MsgBox("Are you sure to process this order?", vbQuestion + vbYesNo, "Process Order") = vbYes Then
                    While counter <= 23

                        rdbtns()

                        For Each row As DataGridViewRow In dtSummary.Rows
                            If row.Cells(0).Value = "Med-P0104" Then

                                mchigr = row.Cells(4).Value
                                mchigrid = mchigr + mchiliqty
                                row.Cells(4).Value = mchigrid
                                row.Cells(5).Value = Integer.Parse(row.Cells(4).Value) * Price_Chili

                                mchis = mchistock
                                txtSMChi.Text = mchis - mchigrid

                                Exit Sub
                            End If

                        Next

                        dtSummary.Rows.Add("Med-P0104", "Chili Pepper", lblChiliPrice.Text, "Pizza", "0", Price_Chili)
                        compute()


                    End While
                Else
                    rdbtns()
                    Exit Sub
                End If

            End If

        ElseIf rbtnLargeChi.Checked = True Then

            Dim lchiliqty = getUserInput()

            Dim is_valid As Boolean
            is_valid = inputValidLChi(lchiliqty)

            If validInput = False Then
                MsgBox("Cannot be processed!", vbCritical, "Invalid Input")

            Else

                While is_valid = False Or lchiliqty < 0 Or validInput = False Or lchiliqty = 0 Or lchiliqty > txtSLChi.Text

                    If lchiliqty > txtSLChi.Text And lchiliqty < 26 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                    ElseIf lchiliqty > 25 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                        Exit Sub
                    ElseIf lchiliqty < 0 Or validInput = False Or lchiliqty = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        rdbtns()
                        Exit Sub
                        MsgBox("Try again!")
                    End If

                    lchiliqty = getUserInput()
                    is_valid = inputValidLChi(lchiliqty)
                End While

                If MsgBox("Are you sure to process this order?", vbQuestion + vbYesNo, "Process Order") = vbYes Then
                    While counter <= 23

                        rdbtns()

                        For Each row As DataGridViewRow In dtSummary.Rows
                            If row.Cells(0).Value = "Lar-P0104" Then

                                lchigr = row.Cells(4).Value
                                lchigrid = lchigr + lchiliqty
                                row.Cells(4).Value = lchigrid
                                row.Cells(5).Value = Integer.Parse(row.Cells(4).Value) * Price_Chili

                                lchis = lchistock
                                txtSLChi.Text = lchis - lchigrid

                                Exit Sub
                            End If

                        Next

                        dtSummary.Rows.Add("Lar-P0104", "Chili Pepper", lblChiliPrice.Text, "Pizza", "0", Price_Chili)
                        compute()


                    End While
                Else
                    rdbtns()

                    Exit Sub
                End If

            End If
        Else
            MsgBox("Please choose a variation.")
            SAPI = CreateObject("SAPI.spvoice")
            SAPI.speak("Please choose a variation.")
        End If
    End Sub

    Private Sub txtSRChi_TextChanged(sender As Object, e As EventArgs) Handles txtSRChi.TextChanged

        If txtSRChi.Text <= 0 Then

            txtSRChi.BackColor = Color.DarkRed
            txtSRChi.ForeColor = Color.White
            MsgBox("Out of Stock", 48, "Out of Stock")
            rbtnRegularChi.Enabled = False

        ElseIf txtSRChi.Text > 5 And txtSRChi.Text <= 10 Then

            txtSRChi.BackColor = Color.Yellow
            txtSRChi.ForeColor = Color.Black
            MsgBox("Your current stock number is " + txtSRChi.Text + "!", 48, "Warning")

        ElseIf txtSRChi.Text > 0 And txtSRChi.Text <= 5 Then

            txtSRChi.BackColor = Color.Red
            txtSRChi.ForeColor = Color.White
            MsgBox("Low on stock!", 48, "Critical")


        Else
            picChili.Hide()
            btnChili.Enabled = True
            rbtnRegularChi.Enabled = True
        End If

    End Sub

    Private Sub txtMRChi_TextChanged(sender As Object, e As EventArgs) Handles txtSMChi.TextChanged

        If txtSMChi.Text <= 0 Then

            txtSMChi.BackColor = Color.DarkRed
            txtSMChi.ForeColor = Color.White
            MsgBox("Out of Stock", 48, "Out of Stock")
            rbtnMediumChi.Enabled = False

        ElseIf txtSMChi.Text > 5 And txtSMChi.Text <= 10 Then

            txtSMChi.BackColor = Color.Yellow
            txtSMChi.ForeColor = Color.Black
            MsgBox("Your current stock number is " + txtSMChi.Text + "!", 48, "Warning")

        ElseIf txtSMChi.Text > 0 And txtSMChi.Text <= 5 Then

            txtSMChi.BackColor = Color.Red
            txtSMChi.ForeColor = Color.White
            MsgBox("Low on stock!", 48, "Critical")


        Else
            picChili.Hide()
            btnChili.Enabled = True
            rbtnMediumChi.Enabled = True
        End If

    End Sub

    Private Sub txtSLChi_TextChanged(sender As Object, e As EventArgs) Handles txtSLChi.TextChanged

        If txtSLChi.Text <= 0 Then

            txtSLChi.BackColor = Color.DarkRed
            txtSLChi.ForeColor = Color.White
            MsgBox("Out of Stock", 48, "Out of Stock")
            rbtnLargeChi.Enabled = False

        ElseIf txtSLChi.Text > 5 And txtSLChi.Text <= 10 Then

            txtSLChi.BackColor = Color.Yellow
            txtSLChi.ForeColor = Color.Black
            MsgBox("Your current stock number is " + txtSLChi.Text + "!", 48, "Warning")

        ElseIf txtSLChi.Text > 0 And txtSLChi.Text <= 5 Then

            txtSLChi.BackColor = Color.Red
            txtSLChi.ForeColor = Color.White
            MsgBox("Low on stock!", 48, "Critical")


        Else
            picChili.Hide()
            btnChili.Enabled = True
            rbtnLargeChi.Enabled = True
        End If

    End Sub

    Private Sub ChiStocks(sender As Object, e As EventArgs) Handles txtSRChi.TextChanged, txtSMChi.TextChanged, txtSLChi.TextChanged

        Dim reg As Integer
        Dim med As Integer
        Dim lar As Integer
        Dim bFlag

        bFlag = Integer.TryParse(txtSRChi.Text.Trim(), reg)
        bFlag = Integer.TryParse(txtSMChi.Text.Trim, med)
        bFlag = Integer.TryParse(txtSLChi.Text.Trim, lar)


        If reg <= 0 And med <= 0 And lar <= 0 Then
            picChili.Show()
            rdbtns()
            MsgBox("Out of Stock", 48, "Out of Stock")
        Else
            picChili.Hide()
        End If
    End Sub

    Private Sub rbtnRegularChi_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnRegularChi.CheckedChanged
        lblChiliPrice.Text = chiprice.ToString("0.00")
    End Sub

    Private Sub rbtnMediumChi_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnMediumChi.CheckedChanged
        lblChiliPrice.Text = chiprice.ToString("0.00") + 50 & ".00"
    End Sub

    Private Sub rbtnLargeChi_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnLargeChi.CheckedChanged
        lblChiliPrice.Text = chiprice.ToString("0.00") + 100 & ".00"
    End Sub

    Private Sub btnMushroom_Click(sender As Object, e As EventArgs) Handles btnMushroom.Click
        Dim Price_Mushroom As Integer = Val(lblMushroomPrice.Text)

        If rbtnRegularMus.Checked = True Then

            Dim mushqty = getUserInput()

            Dim is_valid As Boolean
            is_valid = inputValidMus(mushqty)

            If validInput = False Then
                MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                rdbtns()
            Else

                While is_valid = False Or mushqty < 0 Or validInput = False Or mushqty = 0 Or mushqty > txtSRMus.Text

                    If mushqty > txtSRMus.Text And mushqty < 26 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                    ElseIf mushqty > 25 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                        Exit Sub
                    ElseIf mushqty < 0 Or validInput = False Or mushqty = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        rdbtns()
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    mushqty = getUserInput()
                    is_valid = inputValidMus(mushqty)
                End While

                If MsgBox("Are you sure to process this order?", vbQuestion + vbYesNo, "Process Order") = vbYes Then
                    While counter <= 23

                        rdbtns()

                        For Each row As DataGridViewRow In dtSummary.Rows
                            If row.Cells(0).Value = "Reg-P0105" Then

                                musgr = row.Cells(4).Value
                                musgrid = musgr + mushqty
                                row.Cells(4).Value = musgrid
                                row.Cells(5).Value = Integer.Parse(row.Cells(4).Value) * Price_Mushroom

                                muss = musstock
                                txtSRMus.Text = muss - musgrid

                                Exit Sub
                            End If

                        Next

                        dtSummary.Rows.Add("Reg-P0105", "Mushroom", lblMushroomPrice.Text, "Pizza", "0", Price_Mushroom)
                        compute()


                    End While
                Else
                    rdbtns()
                    Exit Sub
                End If
            End If

        ElseIf rbtnMediumMus.Checked = True Then

            Dim mmushqty = getUserInput()

            Dim is_valid As Boolean
            is_valid = inputValidMMus(mmushqty)

            If validInput = False Then
                MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                rdbtns()
            Else

                While is_valid = False Or mmushqty < 0 Or validInput = False Or mmushqty = 0 Or mmushqty > txtSMMus.Text

                    If mmushqty > txtSMMus.Text And mmushqty < 26 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                    ElseIf mmushqty > 25 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                        Exit Sub
                    ElseIf mmushqty < 0 Or validInput = False Or mmushqty = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        rdbtns()
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    mmushqty = getUserInput()
                    is_valid = inputValidMMus(mmushqty)
                End While

                If MsgBox("Are you sure to process this order?", vbQuestion + vbYesNo, "Process Order") = vbYes Then
                    While counter <= 23

                        rdbtns()

                        For Each row As DataGridViewRow In dtSummary.Rows
                            If row.Cells(0).Value = "Med-P0105" Then


                                mmusgr = row.Cells(4).Value
                                mmusgrid = mmusgr + mmushqty
                                row.Cells(4).Value = mmusgrid
                                row.Cells(5).Value = Integer.Parse(row.Cells(4).Value) * Price_Mushroom

                                mmuss = mmusstock
                                txtSMMus.Text = mmuss - mmusgrid

                                Exit Sub
                            End If

                        Next

                        dtSummary.Rows.Add("Med-P0105", "Mushroom", lblMushroomPrice.Text, "Pizza", "0", Price_Mushroom)
                        compute()


                    End While
                Else
                    rdbtns()
                    Exit Sub
                End If
            End If

        ElseIf rbtnLargeMus.Checked = True Then

            Dim lmushqty = getUserInput()

            Dim is_valid As Boolean
            is_valid = inputValidLMus(lmushqty)

            If validInput = False Then
                MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                rdbtns()
            Else

                While is_valid = False Or lmushqty < 0 Or validInput = False Or lmushqty = 0 Or lmushqty > txtSLMus.Text

                    If lmushqty > txtSLMus.Text And lmushqty < 26 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                    ElseIf lmushqty > 25 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        Exit Sub
                        rdbtns()
                    ElseIf lmushqty < 0 Or validInput = False Or lmushqty = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        rdbtns()
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    lmushqty = getUserInput()
                    is_valid = inputValidLMus(lmushqty)
                End While

                If MsgBox("Are you sure to process this order?", vbQuestion + vbYesNo, "Process Order") = vbYes Then
                    While counter <= 23

                        rdbtns()

                        For Each row As DataGridViewRow In dtSummary.Rows
                            If row.Cells(0).Value = "Lar-P0105" Then

                                lmusgr = row.Cells(4).Value
                                lmusgrid = lmusgr + lmushqty
                                row.Cells(4).Value = lmusgrid
                                row.Cells(5).Value = Integer.Parse(row.Cells(4).Value) * Price_Mushroom

                                lmuss = lmusstock
                                txtSLMus.Text = lmuss - lmusgrid

                                Exit Sub
                            End If

                        Next

                        dtSummary.Rows.Add("Lar-P0105", "Mushroom", lblMushroomPrice.Text, "Pizza", "0", Price_Mushroom)
                        compute()


                    End While
                Else
                    rdbtns()
                    Exit Sub
                End If
            End If
            MsgBox("Please choose a variation")
            SAPI = CreateObject("SAPI.spvoice")
            SAPI.speak("Please choose a variation.")
        End If

    End Sub

    Private Sub txtSRMus_TextChanged(sender As Object, e As EventArgs) Handles txtSRMus.TextChanged

        If txtSRMus.Text <= 0 Then

            txtSRMus.BackColor = Color.DarkRed
            txtSRMus.ForeColor = Color.White
            MsgBox("Out of Stock", 48, "Out of Stock")
            rbtnRegularMus.Enabled = False

        ElseIf txtSRMus.Text > 5 And txtSRMus.Text <= 10 Then

            txtSRMus.BackColor = Color.Yellow
            txtSRMus.ForeColor = Color.Black
            MsgBox("Your current stock number is " + txtSRMus.Text + "!", 48, "Warning")

        ElseIf txtSRMus.Text > 0 And txtSRMus.Text <= 5 Then

            txtSRMus.BackColor = Color.Red
            txtSRMus.ForeColor = Color.White
            MsgBox("Low on stock!", 48, "Critical")


        Else
            picMush.Hide()
            btnMushroom.Enabled = True
            rbtnRegularMus.Enabled = True
        End If

    End Sub

    Private Sub txtSMMus_TextChanged(sender As Object, e As EventArgs) Handles txtSMMus.TextChanged

        If txtSMMus.Text <= 0 Then

            txtSMMus.BackColor = Color.DarkRed
            txtSMMus.ForeColor = Color.White
            MsgBox("Out of Stock", 48, "Out of Stock")
            rbtnMediumMus.Enabled = False

        ElseIf txtSMMus.Text > 5 And txtSMMus.Text <= 10 Then

            txtSMMus.BackColor = Color.Yellow
            txtSMMus.ForeColor = Color.Black
            MsgBox("Your current stock number is " + txtSMMus.Text + "!", 48, "Warning")

        ElseIf txtSMMus.Text > 0 And txtSMMus.Text <= 5 Then

            txtSMMus.BackColor = Color.Red
            txtSMMus.ForeColor = Color.White
            MsgBox("Low on stock!", 48, "Critical")


        Else
            picMush.Hide()
            btnMushroom.Enabled = True
            rbtnMediumMus.Enabled = True
        End If

    End Sub

    Private Sub txtSLMus_TextChanged(sender As Object, e As EventArgs) Handles txtSLMus.TextChanged

        If txtSLMus.Text <= 0 Then

            txtSLMus.BackColor = Color.DarkRed
            txtSLMus.ForeColor = Color.White
            MsgBox("Out of Stock", 48, "Out of Stock")
            rbtnLargeMus.Enabled = False

        ElseIf txtSLMus.Text > 5 And txtSLMus.Text <= 10 Then

            txtSLMus.BackColor = Color.Yellow
            txtSLMus.ForeColor = Color.Black
            MsgBox("Your current stock number is " + txtSLMus.Text + "!", 48, "Warning")

        ElseIf txtSLMus.Text > 0 And txtSLMus.Text <= 5 Then

            txtSLMus.BackColor = Color.Red
            txtSLMus.ForeColor = Color.White
            MsgBox("Low on stock!", 48, "Critical")


        Else
            picMush.Hide()
            btnMushroom.Enabled = True
            rbtnLargeMus.Enabled = True
        End If

    End Sub

    Private Sub MusStocks(sender As Object, e As EventArgs) Handles txtSRMus.TextChanged, txtSMMus.TextChanged, txtSLMus.TextChanged

        Dim reg As Integer
        Dim med As Integer
        Dim lar As Integer
        Dim bFlag

        bFlag = Integer.TryParse(txtSRMus.Text.Trim(), reg)
        bFlag = Integer.TryParse(txtSMMus.Text.Trim, med)
        bFlag = Integer.TryParse(txtSLMus.Text.Trim, lar)


        If reg <= 0 And med <= 0 And lar <= 0 Then
            picMush.Show()
            MsgBox("Out of Stock", 48, "Out of Stock")
            btnMushroom.Enabled = False
        Else
            picMush.Hide()
        End If
    End Sub

    Private Sub rbtnRegularMus_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnRegularMus.CheckedChanged
        lblMushroomPrice.Text = musprice.ToString("0.00")
    End Sub

    Private Sub rbtnMediumMus_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnMediumMus.CheckedChanged
        lblMushroomPrice.Text = musprice.ToString("0.00") + 50 & ".00"
    End Sub

    Private Sub rbtnLargeMus_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnLargeMus.CheckedChanged
        lblMushroomPrice.Text = musprice.ToString("0.00") + 100 & ".00"
    End Sub

    Private Sub btnVegetarian_Click(sender As Object, e As EventArgs) Handles btnVegetarian.Click
        Dim Price_Vegetarian As Integer = Val(lblVegePrice.Text)

        If rbtnRegularVeg.Checked = True Then

            Dim vegqty = getUserInput()

            Dim is_valid As Boolean
            is_valid = inputValidVeg(vegqty)

            If validInput = False Then
                MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                rdbtns()
            Else

                While is_valid = False Or vegqty < 0 Or False Or vegqty = 0 Or vegqty > txtSRVeg.Text

                    If vegqty > txtSRVeg.Text And vegqty < 26 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                    ElseIf vegqty > 25 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                        Exit Sub
                    ElseIf vegqty < 0 Or validInput = False Or vegqty = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        rdbtns()
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    vegqty = getUserInput()
                    is_valid = inputValidVeg(vegqty)
                End While

                If MsgBox("Are you sure to process this order?", vbQuestion + vbYesNo, "Process Order") = vbYes Then
                    While counter <= 23
                        rdbtns()

                        For Each row As DataGridViewRow In dtSummary.Rows
                            If row.Cells(0).Value = "Reg-P0106" Then
                                row.Cells(3).Value = "Pizza"
                                row.Cells(4).Value = row.Cells(4).Value + vegqty
                                row.Cells(5).Value = Integer.Parse(row.Cells(4).Value) * Price_Vegetarian

                                veggrid = row.Cells(4).Value
                                vegs = vegstock
                                txtSRVeg.Text = vegs - veggrid

                                Exit Sub
                            End If

                        Next

                        dtSummary.Rows.Add("Reg-P0106", "Vegetarian", lblVegePrice.Text, "Pizza", "0", Price_Vegetarian)
                        compute()


                    End While
                Else
                    rdbtns()
                    Exit Sub
                End If
            End If

        ElseIf rbtnMediumVeg.Checked = True Then

            Dim mvegqty = getUserInput()

            Dim is_valid As Boolean
            is_valid = inputValidMVeg(mvegqty)

            If validInput = False Then
                MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                rdbtns()
            Else

                While is_valid = False Or mvegqty < 0 Or False Or mvegqty = 0 Or mvegqty > txtSMVeg.Text

                    If mvegqty > txtSMVeg.Text And mvegqty < 26 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                    ElseIf mvegqty > 25 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                        Exit Sub
                    ElseIf mvegqty < 0 Or validInput = False Or mvegqty = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        rdbtns()
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    mvegqty = getUserInput()
                    is_valid = inputValidMVeg(mvegqty)
                End While
                If MsgBox("Are you sure to process this order?", vbQuestion + vbYesNo, "Process Order") = vbYes Then
                    While counter <= 23
                        rdbtns()

                        For Each row As DataGridViewRow In dtSummary.Rows
                            If row.Cells(0).Value = "Med-P0106" Then
                                row.Cells(3).Value = "Pizza"
                                row.Cells(4).Value = row.Cells(4).Value + mvegqty
                                row.Cells(5).Value = Integer.Parse(row.Cells(4).Value) * Price_Vegetarian

                                mveggrid = row.Cells(4).Value
                                mvegs = mvegstock
                                txtSMVeg.Text = mvegs - mveggrid

                                Exit Sub
                            End If

                        Next

                        dtSummary.Rows.Add("Med-P0106", "Vegetarian", lblVegePrice.Text, "Pizza", "0", Price_Vegetarian)
                        compute()


                    End While
                Else
                    rdbtns()
                    Exit Sub
                End If
            End If

        ElseIf rbtnLargeVeg.Checked = True Then

            Dim lvegqty = getUserInput()

            Dim is_valid As Boolean
            is_valid = inputValidLVeg(lvegqty)

            If validInput = False Then
                MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                rdbtns()
            Else

                While is_valid = False Or lvegqty < 0 Or False Or lvegqty = 0 Or lvegqty > txtSLVeg.Text

                    If lvegqty > txtSLVeg.Text And lvegqty < 26 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                    ElseIf lvegqty > 25 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                        Exit Sub
                    ElseIf lvegqty < 0 Or validInput = False Or lvegqty = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        rdbtns()
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    lvegqty = getUserInput()
                    is_valid = inputValidLVeg(lvegqty)
                End While

                If MsgBox("Are you sure to process this order?", vbQuestion + vbYesNo, "Process Order") = vbYes Then
                    While counter <= 23
                        rdbtns()

                        For Each row As DataGridViewRow In dtSummary.Rows
                            If row.Cells(0).Value = "Lar-P0106" Then
                                row.Cells(3).Value = "Pizza"
                                row.Cells(4).Value = row.Cells(4).Value + lvegqty
                                row.Cells(5).Value = Integer.Parse(row.Cells(4).Value) * Price_Vegetarian

                                lveggrid = row.Cells(4).Value
                                lvegs = lvegstock
                                txtSLVeg.Text = lvegs - lveggrid

                                Exit Sub
                            End If

                        Next

                        dtSummary.Rows.Add("Lar-P0106", "Vegetarian", lblVegePrice.Text, "Pizza", "0", Price_Vegetarian)
                        compute()


                    End While
                Else
                    rdbtns()
                    Exit Sub
                End If
            End If
        Else

            MsgBox("Please choose a variation")
            SAPI = CreateObject("SAPI.spvoice")
            SAPI.speak("Please choose a variation.")
        End If
    End Sub

    Private Sub txtSRVeg_TextChanged(sender As Object, e As EventArgs) Handles txtSRVeg.TextChanged

        If txtSRVeg.Text <= 0 Then

            txtSRVeg.BackColor = Color.DarkRed
            txtSRVeg.ForeColor = Color.White
            MsgBox("Out of Stock", 48, "Out of Stock")
            rbtnRegularVeg.Enabled = False

        ElseIf txtSRVeg.Text > 5 And txtSRVeg.Text <= 10 Then

            txtSRVeg.BackColor = Color.Yellow
            txtSRVeg.ForeColor = Color.Black
            MsgBox("Your current stock number is " + txtSRVeg.Text + "!", 48, "Warning")

        ElseIf txtSRVeg.Text > 0 And txtSRVeg.Text <= 5 Then

            txtSRVeg.BackColor = Color.Red
            txtSRVeg.ForeColor = Color.White
            MsgBox("Low on stock!", 48, "Critical")


        Else
            picVege.Hide()
            btnVegetarian.Enabled = True
            rbtnRegularVeg.Enabled = True
        End If

    End Sub

    Private Sub txtSMVeg_TextChanged(sender As Object, e As EventArgs) Handles txtSMVeg.TextChanged

        If txtSMVeg.Text <= 0 Then

            txtSMVeg.BackColor = Color.DarkRed
            txtSMVeg.ForeColor = Color.White
            MsgBox("Out of Stock", 48, "Out of Stock")
            rbtnMediumVeg.Enabled = False

        ElseIf txtSMVeg.Text > 5 And txtSMVeg.Text <= 10 Then

            txtSMVeg.BackColor = Color.Yellow
            txtSMVeg.ForeColor = Color.Black
            MsgBox("Your current stock number is " + txtSMVeg.Text + "!", 48, "Warning")

        ElseIf txtSMVeg.Text > 0 And txtSMVeg.Text <= 5 Then

            txtSMVeg.BackColor = Color.Red
            txtSMVeg.ForeColor = Color.White
            MsgBox("Low on stock!", 48, "Critical")


        Else
            picVege.Hide()
            btnVegetarian.Enabled = True
            rbtnMediumVeg.Enabled = True
        End If

    End Sub

    Private Sub txtSLVeg_TextChanged(sender As Object, e As EventArgs) Handles txtSLVeg.TextChanged

        If txtSLVeg.Text <= 0 Then

            txtSLVeg.BackColor = Color.DarkRed
            txtSLVeg.ForeColor = Color.White
            MsgBox("Out of Stock", 48, "Out of Stock")
            rbtnLargeVeg.Enabled = False

        ElseIf txtSLVeg.Text > 5 And txtSLVeg.Text <= 10 Then

            txtSLVeg.BackColor = Color.Yellow
            txtSLVeg.ForeColor = Color.Black
            MsgBox("Your current stock number is " + txtSLVeg.Text + "!", 48, "Warning")

        ElseIf txtSLVeg.Text > 0 And txtSLVeg.Text <= 5 Then

            txtSLVeg.BackColor = Color.Red
            txtSLVeg.ForeColor = Color.White
            MsgBox("Low on stock!", 48, "Critical")


        Else
            picVege.Hide()
            btnVegetarian.Enabled = True
            rbtnLargeVeg.Enabled = True
        End If

    End Sub

    Private Sub VegStocks(sender As Object, e As EventArgs) Handles txtSRVeg.TextChanged, txtSMVeg.TextChanged, txtSLVeg.TextChanged

        Dim reg As Integer
        Dim med As Integer
        Dim lar As Integer
        Dim bFlag

        bFlag = Integer.TryParse(txtSRVeg.Text.Trim(), reg)
        bFlag = Integer.TryParse(txtSMVeg.Text.Trim, med)
        bFlag = Integer.TryParse(txtSLVeg.Text.Trim, lar)


        If reg <= 0 And med <= 0 And lar <= 0 Then
            picVege.Show()
            btnVegetarian.Enabled = False
            MsgBox("Out of Stock", 48, "Out of Stock")
        Else
            picVege.Hide()
        End If
    End Sub

    Private Sub rbtnRegularVeg_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnRegularVeg.CheckedChanged
        lblVegePrice.Text = vegprice.ToString("0.00")
    End Sub

    Private Sub rbtnMediumVeg_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnMediumVeg.CheckedChanged
        lblVegePrice.Text = vegprice.ToString("0.00") + 50 & ".00"
    End Sub

    Private Sub rbtnLargVeg_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnLargeVeg.CheckedChanged
        lblVegePrice.Text = vegprice.ToString("0.00") + 100 & ".00"
    End Sub

    Private Sub btnVeronese_Click(sender As Object, e As EventArgs) Handles btnVeronese.Click

        Dim Price_Veronese As Integer = Val(lblVerPrice.Text)

        If rbtnRegularVer.Checked = True Then

            Dim verqty = getUserInput()

            Dim is_valid As Boolean
            is_valid = inputValidVer(verqty)

            If validInput = False Then
                MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                rdbtns()

            Else

                While is_valid = False Or verqty < 0 Or validInput = False Or verqty = 0 Or verqty > txtSRVer.Text

                    If verqty > txtSRVer.Text And verqty < 26 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                    ElseIf verqty > 25 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                        Exit Sub
                    ElseIf verqty < 0 Or validInput = False Or verqty = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        rdbtns()
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                        rdbtns()
                    End If

                    verqty = getUserInput()
                    is_valid = inputValidVer(verqty)
                End While

                If MsgBox("Are you sure to process this order?", vbQuestion + vbYesNo, "Process Order") = vbYes Then
                    While counter <= 23
                        rdbtns()

                        For Each row As DataGridViewRow In dtSummary.Rows
                            If row.Cells(0).Value = "Reg-P0107" Then
                                vergr = row.Cells(4).Value
                                vergrid = vergr + verqty
                                row.Cells(4).Value = vergrid
                                row.Cells(5).Value = Integer.Parse(row.Cells(4).Value) * Price_Veronese

                                vers = verstock
                                txtSRVer.Text = vers - vergrid

                                Exit Sub
                            End If

                        Next

                        dtSummary.Rows.Add("Reg-P0107", "Veronese", lblVerPrice.Text, "Pizza", "0", Price_Veronese)
                        compute()


                    End While
                Else
                    rdbtns()
                    Exit Sub
                End If
            End If

        ElseIf rbtnMediumVer.Checked = True Then

            Dim mverqty = getUserInput()

            Dim is_valid As Boolean
            is_valid = inputValidMVer(mverqty)

            If validInput = False Then
                MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                rdbtns()

            Else

                While is_valid = False Or mverqty < 0 Or validInput = False Or mverqty = 0 Or mverqty > txtSMVer.Text

                    If mverqty > txtSMVer.Text And mverqty < 26 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                    ElseIf mverqty > 25 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                        Exit Sub
                    ElseIf mverqty < 0 Or validInput = False Or mverqty = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        rdbtns()
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                        rdbtns()
                    End If

                    mverqty = getUserInput()
                    is_valid = inputValidMVer(mverqty)
                End While

                If MsgBox("Are you sure to process this order?", vbQuestion + vbYesNo, "Process Order") = vbYes Then
                    While counter <= 23
                        rdbtns()

                        For Each row As DataGridViewRow In dtSummary.Rows
                            If row.Cells(0).Value = "Med-P0107" Then

                                mvergr = row.Cells(4).Value
                                mvergrid = mvergr + mverqty
                                row.Cells(4).Value = mvergrid
                                row.Cells(5).Value = Integer.Parse(row.Cells(4).Value) * Price_Veronese

                                mvers = mverstock
                                txtSMVer.Text = mvers - mvergrid

                                Exit Sub
                            End If

                        Next

                        dtSummary.Rows.Add("Med-P0107", "Veronese", lblVerPrice.Text, "Pizza", "0", Price_Veronese)
                        compute()


                    End While
                Else
                    rdbtns()
                    Exit Sub
                End If
            End If

        ElseIf rbtnLargeVer.Checked = True Then

            Dim lverqty = getUserInput()

            Dim is_valid As Boolean
            is_valid = inputValidLVer(lverqty)

            If validInput = False Then
                MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                rdbtns()

            Else

                While is_valid = False Or lverqty < 0 Or validInput = False Or lverqty = 0 Or lverqty > txtSLVer.Text

                    If lverqty > txtSLVer.Text And lverqty < 26 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                    ElseIf lverqty > 25 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                        Exit Sub
                    ElseIf lverqty < 0 Or validInput = False Or lverqty = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        rdbtns()
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                        rdbtns()
                    End If

                    lverqty = getUserInput()
                    is_valid = inputValidLVer(lverqty)
                End While

                If MsgBox("Are you sure to process this order?", vbQuestion + vbYesNo, "Process Order") = vbYes Then
                    While counter <= 23
                        rdbtns()

                        For Each row As DataGridViewRow In dtSummary.Rows
                            If row.Cells(0).Value = "Lar-P0107" Then
                                lvergr = row.Cells(4).Value
                                lvergrid = lvergr + lverqty
                                row.Cells(4).Value = lvergrid
                                row.Cells(5).Value = Integer.Parse(row.Cells(4).Value) * Price_Veronese

                                lvers = lverstock
                                txtSLVer.Text = lvers - lvergrid

                                Exit Sub
                            End If

                        Next

                        dtSummary.Rows.Add("Lar-P0107", "Veronese", lblVerPrice.Text, "Pizza", "0", Price_Veronese)
                        compute()


                    End While
                Else
                    rdbtns()
                    Exit Sub
                End If
            End If
        Else
            MsgBox("Please choose a variation")
            SAPI = CreateObject("SAPI.spvoice")
            SAPI.speak("Please choose a variation.")
        End If
    End Sub

    Private Sub txtSRVer_TextChanged(sender As Object, e As EventArgs) Handles txtSRVer.TextChanged

        If txtSRVer.Text <= 0 Then

            txtSRVer.BackColor = Color.DarkRed
            txtSRVer.ForeColor = Color.White
            MsgBox("Out of Stock", 48, "Out of Stock")
            rbtnRegularVer.Enabled = False

        ElseIf txtSRVer.Text > 5 And txtSRVer.Text <= 10 Then

            txtSRVer.BackColor = Color.Yellow
            txtSRVer.ForeColor = Color.Black
            MsgBox("Your current stock number is " + txtSRVer.Text + "!", 48, "Warning")

        ElseIf txtSRVer.Text > 0 And txtSRVer.Text <= 5 Then

            txtSRVer.BackColor = Color.Red
            txtSRVer.ForeColor = Color.White
            MsgBox("Low on stock!", 48, "Critical")


        Else
            picVero.Hide()
            btnVeronese.Enabled = True
            rbtnRegularVer.Enabled = True
        End If

    End Sub

    Private Sub txtSMVer_TextChanged(sender As Object, e As EventArgs) Handles txtSMVer.TextChanged

        If txtSMVer.Text <= 0 Then

            txtSMVer.BackColor = Color.DarkRed
            txtSMVer.ForeColor = Color.White
            MsgBox("Out of Stock", 48, "Out of Stock")
            rbtnMediumVer.Enabled = False

        ElseIf txtSMVer.Text > 5 And txtSMVer.Text <= 10 Then

            txtSMVer.BackColor = Color.Yellow
            txtSMVer.ForeColor = Color.Black
            MsgBox("Your current stock number is " + txtSMVer.Text + "!", 48, "Warning")

        ElseIf txtSMVer.Text > 0 And txtSMVer.Text <= 5 Then

            txtSMVer.BackColor = Color.Red
            txtSMVer.ForeColor = Color.White
            MsgBox("Low on stock!", 48, "Critical")


        Else
            picVero.Hide()
            btnVeronese.Enabled = True
            rbtnMediumVer.Enabled = True
        End If

    End Sub

    Private Sub txtSLVer_TextChanged(sender As Object, e As EventArgs) Handles txtSLVer.TextChanged

        If txtSLVer.Text <= 0 Then

            txtSLVer.BackColor = Color.DarkRed
            txtSLVer.ForeColor = Color.White
            MsgBox("Out of Stock", 48, "Out of Stock")
            rbtnLargeVer.Enabled = False

        ElseIf txtSLVer.Text > 5 And txtSLVer.Text <= 10 Then

            txtSLVer.BackColor = Color.Yellow
            txtSLVer.ForeColor = Color.Black
            MsgBox("Your current stock number is " + txtSLVer.Text + "!", 48, "Warning")

        ElseIf txtSLVer.Text > 0 And txtSLVer.Text <= 5 Then

            txtSLVer.BackColor = Color.Red
            txtSLVer.ForeColor = Color.White
            MsgBox("Low on stock!", 48, "Critical")


        Else
            picVero.Hide()
            btnVeronese.Enabled = True
            rbtnLargeVer.Enabled = True
        End If

    End Sub

    Private Sub VerStocks(sender As Object, e As EventArgs) Handles txtSRVer.TextChanged, txtSMVer.TextChanged, txtSLVer.TextChanged

        Dim reg As Integer
        Dim med As Integer
        Dim lar As Integer
        Dim bFlag

        bFlag = Integer.TryParse(txtSRVer.Text.Trim(), reg)
        bFlag = Integer.TryParse(txtSMVer.Text.Trim, med)
        bFlag = Integer.TryParse(txtSLVer.Text.Trim, lar)


        If reg <= 0 And med <= 0 And lar <= 0 Then
            picVero.Show()
            btnVeronese.Enabled = False
            MsgBox("Out of Stock", 48, "Out of Stock")
        Else
            picVero.Hide()
        End If
    End Sub

    Private Sub rbtnRegulaVer_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnRegularVer.CheckedChanged
        lblVerPrice.Text = verprice.ToString("0.00")
    End Sub

    Private Sub rbtnMediumVer_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnMediumVer.CheckedChanged
        lblVerPrice.Text = verprice.ToString("0.00") + 50 & ".00"
    End Sub

    Private Sub rbtnLargeVer_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnLargeVer.CheckedChanged
        lblVerPrice.Text = verprice.ToString("0.00") + 100 & ".00"
    End Sub

    Private Sub btnRolls_Click(sender As Object, e As EventArgs) Handles btnRolls.Click

        Dim Price_Rolls As Integer = Val(lblPriceRol.Text)

        Dim rolqty = getUserInput()

        Dim is_valid As Boolean
        is_valid = inputValidRol(rolqty)

        If validInput = False Then
            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")


        Else
            While is_valid = False Or rolqty < 0 Or validInput = False Or rolqty = 0 Or rolqty > txtSRolls.Text

                If rolqty > txtSRolls.Text And rolqty < 26 Then
                    MsgBox("Sorry, there is not enough stock for this item. Try again!")
                ElseIf rolqty > 25 Then
                    MsgBox("Sorry, there is not enough stock for this item. Try again!")
                    Exit Sub
                ElseIf rolqty < 0 Or validInput = False Or rolqty = 0 Then
                    MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                    Exit Sub
                Else
                    MsgBox("Try again!")
                    End If

                rolqty = getUserInput()
                is_valid = inputValidRol(rolqty)
                End While

            If MsgBox("Are you sure to process this order?", vbQuestion + vbYesNo, "Process Order") = vbYes Then
                While counter <= 23

                    For Each row As DataGridViewRow In dtSummary.Rows
                        If row.Cells(1).Value = "Rolls" Then
                            row.Cells(4).Value = row.Cells(4).Value + rolqty
                            row.Cells(5).Value = Integer.Parse(row.Cells(4).Value) * Price_Rolls

                            rolgrid = row.Cells(4).Value
                            rols = rolstock
                            txtSRolls.Text = rols - rolgrid

                            Exit Sub
                        End If

                    Next

                    dtSummary.Rows.Add("B0102", "Rolls", lblPriceRol.Text, "Bread", "0", Price_Rolls)
                    compute()


                End While
                Exit Sub

            End If
        End If
    End Sub

    Private Sub txtSRolls_TextChanged(sender As Object, e As EventArgs) Handles txtSRolls.TextChanged
        If txtSRolls.Text <= 0 Then
            picRolls.Show()
            MsgBox("Out of Stock", 48, "Warning")
            txtSRolls.BackColor = Color.DarkRed
            txtSRolls.ForeColor = Color.White
            btnRolls.Enabled = False

        ElseIf txtSRolls.Text > 5 And txtSRolls.Text <= 10 Then
            MsgBox("Your current stock number is " + txtSRolls.Text + "!", 48, "Warning")
            txtSRolls.BackColor = Color.Yellow
            txtSRolls.ForeColor = Color.Black

        ElseIf txtSRolls.Text > 0 And txtSRolls.Text <= 5 Then
            MsgBox("Low on stock!", 48, "Warning")
            txtSRolls.BackColor = Color.Red
            txtSRolls.ForeColor = Color.White
        Else
            picRolls.Hide()
            btnRolls.Enabled = True
        End If
    End Sub

    Private Sub btnFrench_Click(sender As Object, e As EventArgs) Handles btnFrench.Click

        Dim Price_French As Integer = lblPriceFre.Text

        Dim freqty = getUserInput()

        Dim is_valid As Boolean
        is_valid = inputValidFre(freqty)

        If validInput = False Then
            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")


        Else

            While is_valid = False Or freqty < 0 Or validInput = False Or freqty = 0 Or freqty > txtSFrench.Text

                If freqty > txtSFrench.Text And freqty < 26 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                    ElseIf freqty > 25 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        Exit Sub
                    ElseIf freqty < 0 Or validInput = False Or freqty = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    freqty = getUserInput()
                    is_valid = inputValidFre(freqty)
                End While

                If MsgBox("Are you sure to process this order?", vbQuestion + vbYesNo, "Process Order") = vbYes Then
                    While counter <= 23

                        For Each row As DataGridViewRow In dtSummary.Rows
                        If row.Cells(1).Value = "French Bread" Then
                            fregr = row.Cells(4).Value
                            fregrid = fregr + freqty
                            row.Cells(4).Value = fregrid
                            row.Cells(5).Value = Integer.Parse(row.Cells(4).Value) * Price_French

                            fres = frestock
                            txtSFrench.Text = fres - fregrid

                            Exit Sub
                        End If

                    Next

                        dtSummary.Rows.Add("B0103", "French Bread", lblPriceFre.Text, "Bread", "0", Price_French)
                        compute()


                    End While

                End If
            End If
    End Sub

    Private Sub txtSFrench_TextChanged(sender As Object, e As EventArgs) Handles txtSFrench.TextChanged
        If txtSFrench.Text <= 0 Then
            picFrench.Show()
            MsgBox("Out of Stock", 48, "Warning")
            txtSFrench.BackColor = Color.DarkRed
            txtSFrench.ForeColor = Color.White
            btnFrench.Enabled = False

        ElseIf txtSFrench.Text > 5 And txtSFrench.Text <= 10 Then
            MsgBox("Your current stock number is " + txtSFrench.Text + "!", 48, "Warning")
            txtSFrench.BackColor = Color.Yellow
            txtSFrench.ForeColor = Color.Black

        ElseIf txtSFrench.Text > 0 And txtSFrench.Text <= 5 Then
            MsgBox("Low on stock!", 48, "Warning")
            txtSFrench.BackColor = Color.Red
            txtSFrench.ForeColor = Color.White

        Else
            picFrench.Hide()
            btnFrench.Enabled = True
        End If
    End Sub

    Private Sub btnWheat_Click(sender As Object, e As EventArgs) Handles btnWheat.Click
        Dim Price_Wheat As Integer = lblPriceWhe.Text

        Dim wheqty = getUserInput()

        Dim is_valid As Boolean
        is_valid = inputValidWhe(wheqty)

        If validInput = False Then
            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")


        Else

            While is_valid = False Or wheqty < 0 Or validInput = False Or wheqty = 0 Or wheqty > txtSWheat.Text

                If wheqty > txtSWheat.Text And wheqty < 26 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                    ElseIf wheqty > 25 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        Exit Sub
                    ElseIf wheqty < 0 Or validInput = False Or wheqty = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    ElseIf wheqty > txtSWheat.Text = 0 Then
                        MsgBox("Out of Stock")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    wheqty = getUserInput()
                    is_valid = inputValidWhe(wheqty)
                End While

                If MsgBox("Are you sure to process this order?", vbQuestion + vbYesNo, "Process Order") = vbYes Then
                    While counter <= 23

                        For Each row As DataGridViewRow In dtSummary.Rows
                        If row.Cells(1).Value = "Wheat Bread" Then

                            whegr = row.Cells(4).Value
                            whegrid = whegr + wheqty
                            row.Cells(4).Value = whegrid
                            row.Cells(5).Value = Integer.Parse(row.Cells(4).Value) * Price_Wheat

                            whes = whestock
                            txtSWheat.Text = whes - whegrid

                            Exit Sub
                        End If

                    Next

                        dtSummary.Rows.Add("B0104", "Wheat Bread", lblPriceWhe.Text, "Bread", "0", Price_Wheat)
                        compute()


                    End While

                End If


            End If
    End Sub

    Private Sub txtSWheat_TextChanged(sender As Object, e As EventArgs) Handles txtSWheat.TextChanged
        If txtSWheat.Text <= 0 Then
            picWheat.Show()
            MsgBox("Out of Stock", 48, "Warning")
            txtSWheat.BackColor = Color.DarkRed
            txtSWheat.ForeColor = Color.White
            btnWheat.Enabled = False

        ElseIf txtSWheat.Text > 5 And txtSWheat.Text <= 10 Then
            MsgBox("Your current stock number is " + txtSWheat.Text + "!", 48, "Warning")
            txtSWheat.BackColor = Color.Yellow
            txtSWheat.ForeColor = Color.Black

        ElseIf txtSWheat.Text > 0 And txtSWheat.Text <= 5 Then
            MsgBox("Low on stock!", 48, "Warning")
            txtSWheat.BackColor = Color.Red
            txtSWheat.ForeColor = Color.White

        Else
            picWheat.Hide()
            btnWheat.Enabled = True
        End If
    End Sub

    Private Sub btnWhite_Click(sender As Object, e As EventArgs) Handles btnWhite.Click
        Dim Price_White As Integer = lblPriceWhi.Text

        Dim whiqty = getUserInput()

        Dim is_valid As Boolean
        is_valid = inputValidWhi(whiqty)

        If validInput = False Then
            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")


        Else

            While is_valid = False Or whiqty < 0 Or validInput = False Or whiqty = 0 Or whiqty > txtSWhite.Text

                If whiqty > txtSWhite.Text And whiqty < 26 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")

                    ElseIf whiqty > 25 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        Exit Sub
                    ElseIf whiqty < 0 Or validInput = False Or whiqty = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    whiqty = getUserInput()
                    is_valid = inputValidWhi(whiqty)
                End While

                If MsgBox("Are you sure to process this order?", vbQuestion + vbYesNo, "Process Order") = vbYes Then
                    While counter <= 23


                        For Each row As DataGridViewRow In dtSummary.Rows
                        If row.Cells(1).Value = "White Bread" Then

                            whigr = row.Cells(4).Value
                            whigrid = whigr + whiqty
                            row.Cells(4).Value = whigrid
                            row.Cells(5).Value = Integer.Parse(row.Cells(4).Value) * Price_White

                            whis = whistock
                            txtSWhite.Text = whis - whigrid

                            Exit Sub
                        End If

                    Next

                        dtSummary.Rows.Add("B0105", "White Bread", lblPriceWhi.Text, "Bread", "0", Price_White)
                        compute()

                    End While

            End If
        End If
    End Sub

    Private Sub txtSWhite_TextChanged(sender As Object, e As EventArgs) Handles txtSWhite.TextChanged
        If txtSWhite.Text <= 0 Then
            picWhite.Show()
            MsgBox("Out of Stock", 48, "Warning")
            txtSWhite.BackColor = Color.DarkRed
            txtSWhite.ForeColor = Color.White
            btnWhite.Enabled = False

        ElseIf txtSWhite.Text > 5 And txtSWhite.Text <= 10 Then
            MsgBox("Your current stock number is " + txtSWhite.Text + "!", 48, "Warning")
            txtSWhite.BackColor = Color.Yellow
            txtSWhite.ForeColor = Color.Black

        ElseIf txtSWhite.Text > 0 And txtSWhite.Text <= 5 Then
            MsgBox("Low on stock!", 48, "Warning")
            txtSWhite.BackColor = Color.Red
            txtSWhite.ForeColor = Color.White

        Else
            picWhite.Hide()
            btnWhite.Enabled = True
        End If
    End Sub

    Private Sub btnBanana_Click(sender As Object, e As EventArgs) Handles btnBanana.Click
        Dim Price_Banana As Integer = lblPriceBan.Text

        Dim banqty = getUserInput()

        Dim is_valid As Boolean
        is_valid = inputValidBan(banqty)

        If validInput = False Then
            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")


        Else

            While is_valid = False Or banqty < 0 Or validInput = False Or banqty = 0 Or banqty > txtSBanana.Text

                If banqty > txtSBanana.Text And banqty < 26 Then
                    MsgBox("Sorry, there is not enough stock for this item. Try again!")
                ElseIf banqty > 25 Then
                    MsgBox("Sorry, there is not enough stock for this item. Try again!")
                    Exit Sub
                ElseIf banqty < 0 Or validInput = False Or banqty = 0 Then
                    MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                    Exit Sub
                Else
                    MsgBox("Try again!")
                    End If

                banqty = getUserInput()
                is_valid = inputValidBan(banqty)
                End While

                If MsgBox("Are you sure to process this order?", vbQuestion + vbYesNo, "Process Order") = vbYes Then
                    While counter <= 23


                        For Each row As DataGridViewRow In dtSummary.Rows
                            If row.Cells(1).Value = "Banana Bread" Then
                            bangr = row.Cells(4).Value
                            bangrid = bangr + banqty
                            row.Cells(4).Value = bangrid
                            row.Cells(5).Value = Integer.Parse(row.Cells(4).Value) * Price_Banana

                            bans = banstock
                            txtSBanana.Text = bans - bangrid

                            Exit Sub
                            End If

                        Next

                        dtSummary.Rows.Add("B0106", "Banana Bread", lblPriceBan.Text, "Bread", "0", Price_Banana)
                        compute()


                End While
            End If
        End If
    End Sub

    Private Sub txtSBanana_TextChanged(sender As Object, e As EventArgs) Handles txtSBanana.TextChanged
        If txtSBanana.Text <= 0 Then
            picBanana.Show()
            MsgBox("Out of Stock", 48, "Warning")
            txtSBanana.BackColor = Color.DarkRed
            txtSBanana.ForeColor = Color.White
            btnBanana.Enabled = False

        ElseIf txtSBanana.Text > 5 And txtSBanana.Text <= 10 Then
            MsgBox("Your current stock number is " + txtSBanana.Text + "!", 48, "Warning")
            txtSBanana.BackColor = Color.Yellow
            txtSBanana.ForeColor = Color.Black

        ElseIf txtSBanana.Text > 0 And txtSBanana.Text <= 5 Then
            MsgBox("Low on stock!", 48, "Warning")
            txtSBanana.BackColor = Color.Red
            txtSBanana.ForeColor = Color.White

        Else
            picBanana.Hide()
            btnBanana.Enabled = True
        End If
    End Sub

    Private Sub btnHotdog_Click(sender As Object, e As EventArgs) Handles btnHotdog.Click
        Dim Price_Hotdog As Integer = lblPriceHot.Text

        Dim hotqty = getUserInput()

        Dim is_valid As Boolean
        is_valid = inputValidHot(hotqty)

        If validInput = False Then
            MsgBox("Cannot be processed!", vbCritical, "Invalid Input")


        Else

            While is_valid = False Or hotqty < 0 Or validInput = False Or hotqty = 0 Or hotqty > txtSHotdog.Text

                If hotqty > txtSHotdog.Text And hotqty < 26 Then
                    MsgBox("Sorry, there is not enough stock for this item. Try again!")
                ElseIf hotqty > 25 Then
                    MsgBox("Sorry, there is not enough stock for this item. Try again!")
                    Exit Sub
                ElseIf hotqty < 0 Or validInput = False Or hotqty = 0 Then
                    MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                    Exit Sub
                Else
                    MsgBox("Try again!")
                    End If

                hotqty = getUserInput()
                is_valid = inputValidHot(hotqty)
                End While

                If MsgBox("Are you sure to process this order?", vbQuestion + vbYesNo, "Process Order") = vbYes Then
                    While counter <= 23


                        For Each row As DataGridViewRow In dtSummary.Rows
                        If row.Cells(1).Value = "Hotdog Bun" Then
                            hotgr = row.Cells(4).Value
                            hotgrid = hotgr + hotqty
                            row.Cells(4).Value = hotgrid
                            row.Cells(5).Value = Integer.Parse(row.Cells(4).Value) * Price_Hotdog

                            hots = hotstock
                            txtSHotdog.Text = hots - hotgrid

                            Exit Sub
                        End If

                    Next

                        dtSummary.Rows.Add("B0107", "Hotdog Bun", lblPriceHot.Text, "Bread", "0", Price_Hotdog)
                        compute()

                    End While

            End If
        End If

    End Sub

    Private Sub txtSHotdog_TextChanged(sender As Object, e As EventArgs) Handles txtSHotdog.TextChanged
        If txtSHotdog.Text <= 0 Then
            picHotdog.Show()
            MsgBox("Out of Stock", 48, "Warning")
            txtSHotdog.BackColor = Color.DarkRed
            txtSHotdog.ForeColor = Color.White
            btnHotdog.Enabled = False

        ElseIf txtSHotdog.Text > 5 And txtSHotdog.Text <= 10 Then
            MsgBox("Your current stock number is " + txtSHotdog.Text + "!", 48, "Warning")
            txtSHotdog.BackColor = Color.Yellow
            txtSHotdog.ForeColor = Color.Black

        ElseIf txtSHotdog.Text > 0 And txtSHotdog.Text <= 5 Then
            MsgBox("Low on stock!", 48, "Warning")
            txtSHotdog.BackColor = Color.Red
            txtSHotdog.ForeColor = Color.White

        Else
            picHotdog.Hide()
            btnHotdog.Enabled = True
        End If
    End Sub

    Private Sub btnEspresso_Click(sender As Object, e As EventArgs) Handles btnEspresso.Click
        Dim Price_Espresso As Integer = Val(lblEspPrice.text)

        If rbtnRegularEsp.Checked = True Then

            Dim espqty = getUserInput()

            Dim is_valid As Boolean
            is_valid = inputValidEsp(espqty)

            If validInput = False Then
                MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                rdbtns()

            Else

                While is_valid = False Or espqty < 0 Or validInput = False Or espqty = 0 Or espqty > txtSREsp.Text

                    If espqty > txtSREsp.Text And espqty < 26 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                    ElseIf espqty > 25 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                        Exit Sub
                    ElseIf espqty < 0 Or validInput = False Or espqty = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        rdbtns()
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    espqty = getUserInput()
                    is_valid = inputValidEsp(espqty)
                End While

                If MsgBox("Are you sure to process this order?", vbQuestion + vbYesNo, "Process Order") = vbYes Then
                    While counter <= 23
                        rdbtns()

                        For Each row As DataGridViewRow In dtSummary.Rows
                            If row.Cells(0).Value = "Reg-C0102" Then
                                espgr = row.Cells(4).Value
                                espgrid = espgr + espqty
                                row.Cells(4).Value = espgrid
                                row.Cells(5).Value = Integer.Parse(row.Cells(4).Value) * Price_Espresso

                                esps = espstock
                                txtSREsp.Text = esps - espgrid

                                Exit Sub
                            End If

                        Next

                        dtSummary.Rows.Add("Reg-C0102", "Espresso", lblEspPrice.Text, "Coffee", "0", Price_Espresso)
                        compute()

                    End While
                Else
                    rdbtns()
                    Exit Sub
                End If
            End If

        ElseIf rbtnMediumEsp.Checked = True Then

            Dim mespqty = getUserInput()

            Dim is_valid As Boolean
            is_valid = inputValidMEsp(mespqty)

            If validInput = False Then
                MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                rdbtns()

            Else

                While is_valid = False Or mespqty < 0 Or validInput = False Or mespqty = 0 Or mespqty > txtSMEsp.Text

                    If mespqty > txtSMEsp.Text And mespqty < 26 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                    ElseIf mespqty > 25 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                        Exit Sub
                    ElseIf mespqty < 0 Or validInput = False Or mespqty = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        rdbtns()
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    mespqty = getUserInput()
                    is_valid = inputValidMEsp(mespqty)
                End While

                If MsgBox("Are you sure to process this order?", vbQuestion + vbYesNo, "Process Order") = vbYes Then
                    While counter <= 23
                        rdbtns()

                        For Each row As DataGridViewRow In dtSummary.Rows
                            If row.Cells(0).Value = "Med-C0102" Then
                                mespgr = row.Cells(4).Value
                                mespgrid = mespgr + mespqty
                                row.Cells(4).Value = mespgrid
                                row.Cells(5).Value = Integer.Parse(row.Cells(4).Value) * Price_Espresso

                                mesps = mespstock
                                txtSMEsp.Text = mesps - mespgrid

                                Exit Sub
                            End If

                        Next

                        dtSummary.Rows.Add("Med-C0102", "Espresso", lblEspPrice.Text, "Coffee", "0", Price_Espresso)
                        compute()

                    End While
                Else
                    rdbtns()
                    Exit Sub
                End If
            End If

        ElseIf rbtnLargeEsp.Checked = True Then

            Dim lespqty = getUserInput()

            Dim is_valid As Boolean
            is_valid = inputValidLEsp(lespqty)

            If validInput = False Then
                MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                rdbtns()

            Else

                While is_valid = False Or lespqty < 0 Or validInput = False Or lespqty = 0 Or lespqty > txtSLEsp.Text

                    If lespqty > txtSLEsp.Text And lespqty < 26 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                    ElseIf lespqty > 25 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                        Exit Sub
                    ElseIf lespqty < 0 Or validInput = False Or lespqty = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        rdbtns()
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    lespqty = getUserInput()
                    is_valid = inputValidLEsp(espqty)
                End While

                If MsgBox("Are you sure to process this order?", vbQuestion + vbYesNo, "Process Order") = vbYes Then
                    While counter <= 23
                        rdbtns()

                        For Each row As DataGridViewRow In dtSummary.Rows
                            If row.Cells(0).Value = "Lar-C0102" Then
                                lespgr = row.Cells(4).Value
                                lespgrid = lespgr + lespqty
                                row.Cells(4).Value = lespgrid
                                row.Cells(5).Value = Integer.Parse(row.Cells(4).Value) * Price_Espresso

                                lesps = lespstock
                                txtSLEsp.Text = lesps - lespgrid

                                Exit Sub
                            End If

                        Next

                        dtSummary.Rows.Add("Lar-C0102", "Espresso", lblEspPrice.Text, "Coffee", "0", Price_Espresso)
                        compute()

                    End While
                Else
                    rdbtns()
                    Exit Sub
                End If
            End If
        Else
            MsgBox("Please choose a variation.")
        End If
    End Sub

    Private Sub txtSREsp_TextChanged(sender As Object, e As EventArgs) Handles txtSREsp.TextChanged

        If txtSREsp.Text <= 0 Then

            txtSREsp.BackColor = Color.DarkRed
            txtSREsp.ForeColor = Color.White
            MsgBox("Out of Stock", 48, "Out of Stock")
            rbtnRegularEsp.Enabled = False

        ElseIf txtSREsp.Text > 5 And txtSREsp.Text <= 10 Then

            txtSREsp.BackColor = Color.Yellow
            txtSREsp.ForeColor = Color.Black
            MsgBox("Your current stock number is " + txtSREsp.Text + "!", 48, "Warning")

        ElseIf txtSREsp.Text > 0 And txtSREsp.Text <= 5 Then

            txtSREsp.BackColor = Color.Red
            txtSREsp.ForeColor = Color.White
            MsgBox("Low on stock!", 48, "Critical")


        Else
            picEsp.Hide()
            btnEspresso.Enabled = True
            rbtnRegularEsp.Enabled = True
        End If

    End Sub

    Private Sub txtSMEsp_TextChanged(sender As Object, e As EventArgs) Handles txtSMEsp.TextChanged

        If txtSMEsp.Text <= 0 Then

            txtSMEsp.BackColor = Color.DarkRed
            txtSMEsp.ForeColor = Color.White
            MsgBox("Out of Stock", 48, "Out of Stock")
            rbtnMediumEsp.Enabled = False

        ElseIf txtSMEsp.Text > 5 And txtSMEsp.Text <= 10 Then

            txtSMEsp.BackColor = Color.Yellow
            txtSMEsp.ForeColor = Color.Black
            MsgBox("Your current stock number is " + txtSMEsp.Text + "!", 48, "Warning")

        ElseIf txtSMEsp.Text > 0 And txtSMEsp.Text <= 5 Then

            txtSMEsp.BackColor = Color.Red
            txtSMEsp.ForeColor = Color.White
            MsgBox("Low on stock!", 48, "Critical")


        Else
            picEsp.Hide()
            btnEspresso.Enabled = True
            rbtnMediumEsp.Enabled = True
        End If

    End Sub

    Private Sub txtSLEsp_TextChanged(sender As Object, e As EventArgs) Handles txtSLEsp.TextChanged

        If txtSLEsp.Text <= 0 Then

            txtSLEsp.BackColor = Color.DarkRed
            txtSLEsp.ForeColor = Color.White
            MsgBox("Out of Stock", 48, "Out of Stock")
            rbtnLargeEsp.Enabled = False

        ElseIf txtSLEsp.Text > 5 And txtSLEsp.Text <= 10 Then

            txtSLEsp.BackColor = Color.Yellow
            txtSLEsp.ForeColor = Color.Black
            MsgBox("Your current stock number is " + txtSLEsp.Text + "!", 48, "Warning")

        ElseIf txtSLEsp.Text > 0 And txtSLEsp.Text <= 5 Then

            txtSLEsp.BackColor = Color.Red
            txtSLEsp.ForeColor = Color.White
            MsgBox("Low on stock!", 48, "Critical")


        Else
            picEsp.Hide()
            btnEspresso.Enabled = True
            rbtnLargeEsp.Enabled = True
        End If

    End Sub

    Private Sub EspStocks(sender As Object, e As EventArgs) Handles txtSREsp.TextChanged, txtSMEsp.TextChanged, txtSLEsp.TextChanged

        Dim reg As Integer
        Dim med As Integer
        Dim lar As Integer
        Dim bFlag

        bFlag = Integer.TryParse(txtSREsp.Text.Trim(), reg)
        bFlag = Integer.TryParse(txtSMEsp.Text.Trim, med)
        bFlag = Integer.TryParse(txtSLEsp.Text.Trim, lar)


        If reg <= 0 And med <= 0 And lar <= 0 Then
            picEsp.Show()
            btnEspresso.Enabled = False
            MsgBox("Out of Stock", 48, "Out of Stock")
        Else
            picEsp.Hide()
        End If
    End Sub

    Private Sub rbtnRegularEsp_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnRegularEsp.CheckedChanged
        lblEspPrice.Text = esprice.ToString("0.00")
    End Sub

    Private Sub rbtnMediumEsp_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnMediumEsp.CheckedChanged
        lblEspPrice.Text = esprice.ToString("0.00") + 50 & ".00"
    End Sub

    Private Sub rbtnLargeEsp_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnLargeEsp.CheckedChanged
        lblEspPrice.Text = esprice.ToString("0.00") + 100 & ".00"
    End Sub

    Private Sub btnDoppio_Click(sender As Object, e As EventArgs) Handles btnDoppio.Click
        Dim Price_Doppio As Integer = lblDopPri.Text

        If rbtnRegularDop.Checked = True Then

            Dim dopqty = getUserInput()

            Dim is_valid As Boolean
            is_valid = inputValidDop(dopqty)

            If validInput = False Then
                MsgBox("Cannot be processed!", vbCritical, "Invalid Input")

                rdbtns()
            Else

                While is_valid = False Or dopqty < 0 Or validInput = False Or dopqty = 0 Or dopqty > txtSRDop.Text

                    If dopqty > txtSRDop.Text And dopqty < 26 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                    ElseIf dopqty > 25 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                        Exit Sub
                    ElseIf dopqty < 0 Or validInput = False Or dopqty = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        rdbtns()
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    dopqty = getUserInput()
                    is_valid = inputValidDop(dopqty)
                End While
                If MsgBox("Are you sure to process this order?", vbQuestion + vbYesNo, "Process Order") = vbYes Then
                    While counter <= 23
                        rdbtns()

                        For Each row As DataGridViewRow In dtSummary.Rows
                            If row.Cells(0).Value = "Reg-C0103" Then
                                dopgr = row.Cells(4).Value
                                dopgrid = dopgr + dopqty
                                row.Cells(4).Value = dopgrid
                                row.Cells(5).Value = Integer.Parse(row.Cells(4).Value) * Price_Doppio

                                dops = dopstock
                                txtSRDop.Text = dops - dopgrid

                                Exit Sub
                            End If

                        Next

                        dtSummary.Rows.Add("Reg-C0103", "Doppio", lblDopPri.Text, "Coffee", "0", Price_Doppio)
                        compute()


                    End While
                Else
                    rdbtns()
                    Exit Sub
                End If
            End If

        ElseIf rbtnMediumDop.Checked = True Then

            Dim mdopqty = getUserInput()

            Dim is_valid As Boolean
            is_valid = inputValidMDop(mdopqty)

            If validInput = False Then
                MsgBox("Cannot be processed!", vbCritical, "Invalid Input")

                rdbtns()
            Else

                While is_valid = False Or mdopqty < 0 Or validInput = False Or mdopqty = 0 Or mdopqty > txtSMDop.Text

                    If mdopqty > txtSMDop.Text And mdopqty < 26 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                    ElseIf mdopqty > 25 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                        Exit Sub
                    ElseIf mdopqty < 0 Or validInput = False Or mdopqty = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        rdbtns()
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    mdopqty = getUserInput()
                    is_valid = inputValidMDop(mdopqty)
                End While
                If MsgBox("Are you sure to process this order?", vbQuestion + vbYesNo, "Process Order") = vbYes Then
                    While counter <= 23
                        rdbtns()

                        For Each row As DataGridViewRow In dtSummary.Rows
                            If row.Cells(0).Value = "Med-C0103" Then
                                mdopgr = row.Cells(4).Value
                                mdopgrid = mdopgr + mdopqty
                                row.Cells(4).Value = mdopgrid
                                row.Cells(5).Value = Integer.Parse(row.Cells(4).Value) * Price_Doppio

                                mdops = mdopstock
                                txtSMDop.Text = mdops - mdopgrid

                                Exit Sub
                            End If

                        Next

                        dtSummary.Rows.Add("Med-C0103", "Doppio", lblDopPri.Text, "Coffee", "0", Price_Doppio)
                        compute()


                    End While
                Else
                    rdbtns()
                    Exit Sub
                End If
            End If

        ElseIf rbtnLargeDop.Checked = True Then

            Dim ldopqty = getUserInput()

            Dim is_valid As Boolean
            is_valid = inputValidLDop(ldopqty)

            If validInput = False Then
                MsgBox("Cannot be processed!", vbCritical, "Invalid Input")

                rdbtns()
            Else

                While is_valid = False Or ldopqty < 0 Or validInput = False Or ldopqty = 0 Or ldopqty > txtSLDop.Text

                    If ldopqty > txtSLDop.Text And ldopqty < 26 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                    ElseIf ldopqty > 25 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                        Exit Sub
                    ElseIf ldopqty < 0 Or validInput = False Or ldopqty = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        rdbtns()
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    ldopqty = getUserInput()
                    is_valid = inputValidDop(dopqty)
                End While
                If MsgBox("Are you sure to process this order?", vbQuestion + vbYesNo, "Process Order") = vbYes Then
                    While counter <= 23
                        rdbtns()

                        For Each row As DataGridViewRow In dtSummary.Rows
                            If row.Cells(0).Value = "Lar-C0103" Then
                                ldopgr = row.Cells(4).Value
                                ldopgrid = ldopgr + ldopqty
                                row.Cells(4).Value = ldopgrid
                                row.Cells(5).Value = Integer.Parse(row.Cells(4).Value) * Price_Doppio

                                ldops = ldopstock
                                txtSLDop.Text = ldops - ldopgrid

                                Exit Sub
                            End If

                        Next

                        dtSummary.Rows.Add("Lar-C0103", "Doppio", lblDopPri.Text, "Coffee", "0", Price_Doppio)
                        compute()


                    End While
                Else
                    rdbtns()
                    Exit Sub
                End If
            End If
        Else
            MsgBox("Please choose a variation")
            SAPI = CreateObject("SAPI.spvoice")
            SAPI.speak("Please choose a variation.")
        End If
    End Sub

    Private Sub txtSRDop_TextChanged(sender As Object, e As EventArgs) Handles txtSRDop.TextChanged

        If txtSRDop.Text <= 0 Then

            txtSRDop.BackColor = Color.DarkRed
            txtSRDop.ForeColor = Color.White
            MsgBox("Out of Stock", 48, "Out of Stock")
            rbtnRegularDop.Enabled = False

        ElseIf txtSRDop.Text > 5 And txtSRDop.Text <= 10 Then

            txtSRDop.BackColor = Color.Yellow
            txtSRDop.ForeColor = Color.Black
            MsgBox("Your current stock number is " + txtSRDop.Text + "!", 48, "Warning")

        ElseIf txtSRDop.Text > 0 And txtSRDop.Text <= 5 Then

            txtSRDop.BackColor = Color.Red
            txtSRDop.ForeColor = Color.White
            MsgBox("Low on stock!", 48, "Critical")


        Else
            picDop.Hide()
            btnDoppio.Enabled = True
            rbtnRegularDop.Enabled = True
        End If

    End Sub

    Private Sub txtSMDop_TextChanged(sender As Object, e As EventArgs) Handles txtSMDop.TextChanged

        If txtSMDop.Text <= 0 Then

            txtSMDop.BackColor = Color.DarkRed
            txtSMDop.ForeColor = Color.White
            MsgBox("Out of Stock", 48, "Out of Stock")
            rbtnMediumDop.Enabled = False

        ElseIf txtSMDop.Text > 5 And txtSMDop.Text <= 10 Then

            txtSMDop.BackColor = Color.Yellow
            txtSMDop.ForeColor = Color.Black
            MsgBox("Your current stock number is " + txtSMDop.Text + "!", 48, "Warning")

        ElseIf txtSMDop.Text > 0 And txtSMDop.Text <= 5 Then

            txtSMDop.BackColor = Color.Red
            txtSMDop.ForeColor = Color.White
            MsgBox("Low on stock!", 48, "Critical")


        Else
            picDop.Hide()
            btnDoppio.Enabled = True
            rbtnMediumDop.Enabled = True
        End If

    End Sub

    Private Sub txtSLDop_TextChanged(sender As Object, e As EventArgs) Handles txtSLDop.TextChanged

        If txtSLDop.Text <= 0 Then

            txtSLDop.BackColor = Color.DarkRed
            txtSLDop.ForeColor = Color.White
            MsgBox("Out of Stock", 48, "Out of Stock")
            rbtnLargeDop.Enabled = False

        ElseIf txtSLDop.Text > 5 And txtSLDop.Text <= 10 Then

            txtSLDop.BackColor = Color.Yellow
            txtSLDop.ForeColor = Color.Black
            MsgBox("Your current stock number is " + txtSLDop.Text + "!", 48, "Warning")

        ElseIf txtSLDop.Text > 0 And txtSLDop.Text <= 5 Then

            txtSLDop.BackColor = Color.Red
            txtSLDop.ForeColor = Color.White
            MsgBox("Low on stock!", 48, "Critical")


        Else
            picDop.Hide()
            btnDoppio.Enabled = True
            rbtnLargeDop.Enabled = True
        End If

    End Sub

    Private Sub DopStocks(sender As Object, e As EventArgs) Handles txtSRDop.TextChanged, txtSMDop.TextChanged, txtSLDop.TextChanged

        Dim reg As Integer
        Dim med As Integer
        Dim lar As Integer
        Dim bFlag

        bFlag = Integer.TryParse(txtSRDop.Text.Trim(), reg)
        bFlag = Integer.TryParse(txtSMDop.Text.Trim, med)
        bFlag = Integer.TryParse(txtSLDop.Text.Trim, lar)


        If reg <= 0 And med <= 0 And lar <= 0 Then
            picDop.Show()
            btnDoppio.Enabled = False
            MsgBox("Out of Stock", 48, "Out of Stock")
        Else
            picDop.Hide()
        End If
    End Sub

    Private Sub rbtnRegularDop_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnRegularDop.CheckedChanged
        lblDopPri.Text = dopprice.ToString("0.00")
    End Sub

    Private Sub rbtnMediumDop_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnMediumDop.CheckedChanged
        lblDopPri.Text = dopprice.ToString("0.00") + 50 & ".00"
    End Sub

    Private Sub rbtnLargeDop_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnLargeDop.CheckedChanged
        lblDopPri.Text = dopprice.ToString("0.00") + 100 & ".00"
    End Sub

    Private Sub btnAmericano_Click(sender As Object, e As EventArgs) Handles btnAmericano.Click
        Dim Price_Americano As Integer = lblAmePri.Text

        If rbtnRegularAme.Checked = True Then

            Dim ameqty = getUserInput()

            Dim is_valid As Boolean
            is_valid = inputValidAme(ameqty)

            If validInput = False Then
                MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                rdbtns()

            Else

                While is_valid = False Or ameqty < 0 Or validInput = False Or ameqty = 0 Or ameqty > txtSRAme.Text

                    If ameqty > txtSRAme.Text And ameqty < 26 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                    ElseIf ameqty > 25 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                        Exit Sub
                    ElseIf ameqty < 0 Or validInput = False Or ameqty = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")

                        rdbtns()
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    ameqty = getUserInput()
                    is_valid = inputValidAme(ameqty)
                End While

                If MsgBox("Are you sure to process this order?", vbQuestion + vbYesNo, "Process Order") = vbYes Then
                    While counter <= 23

                        rdbtns()
                        For Each row As DataGridViewRow In dtSummary.Rows
                            If row.Cells(0).Value = "Reg-C0104" Then
                                amegr = row.Cells(4).Value
                                amegrid = amegr + ameqty
                                row.Cells(4).Value = amegrid
                                row.Cells(5).Value = Integer.Parse(row.Cells(4).Value) * Price_Americano

                                ames = amestock
                                txtSRAme.Text = ames - amegrid

                                Exit Sub
                            End If

                        Next

                        dtSummary.Rows.Add("Reg-C0104", "Americano", lblAmePri.Text, "Coffee", "0", Price_Americano)
                        compute()


                    End While
                Else
                    rdbtns()
                    Exit Sub
                End If
            End If

        ElseIf rbtnMediumAme.Checked = True Then

            Dim mameqty = getUserInput()

            Dim is_valid As Boolean
            is_valid = inputValidMAme(mameqty)

            If validInput = False Then
                MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                rdbtns()

            Else

                While is_valid = False Or mameqty < 0 Or validInput = False Or mameqty = 0 Or mameqty > txtSMAme.Text

                    If mameqty > txtSMAme.Text And mameqty < 26 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                    ElseIf mameqty > 25 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                        Exit Sub
                    ElseIf mameqty < 0 Or validInput = False Or mameqty = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")

                        rdbtns()
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    mameqty = getUserInput()
                    is_valid = inputValidMAme(mameqty)
                End While

                If MsgBox("Are you sure to process this order?", vbQuestion + vbYesNo, "Process Order") = vbYes Then
                    While counter <= 23

                        rdbtns()
                        For Each row As DataGridViewRow In dtSummary.Rows
                            If row.Cells(0).Value = "Med-C0104" Then
                                mamegr = row.Cells(4).Value
                                mamegrid = mamegr + mameqty
                                row.Cells(4).Value = mamegrid
                                row.Cells(5).Value = Integer.Parse(row.Cells(4).Value) * Price_Americano

                                mames = mamestock
                                txtSMAme.Text = mames - mamegrid

                                Exit Sub
                            End If

                        Next

                        dtSummary.Rows.Add("Med-C0104", "Americano", lblAmePri.Text, "Coffee", "0", Price_Americano)
                        compute()


                    End While
                Else
                    rdbtns()
                    Exit Sub
                End If
            End If

        ElseIf rbtnLargeAme.Checked = True Then

            Dim lameqty = getUserInput()

            Dim is_valid As Boolean
            is_valid = inputValidLAme(lameqty)

            If validInput = False Then
                MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                rdbtns()

            Else

                While is_valid = False Or lameqty < 0 Or validInput = False Or lameqty = 0 Or lameqty > txtSLAme.Text

                    If lameqty > txtSLAme.Text And lameqty < 26 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                    ElseIf lameqty > 25 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                        Exit Sub
                    ElseIf lameqty < 0 Or validInput = False Or lameqty = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")

                        rdbtns()
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    lameqty = getUserInput()
                    is_valid = inputValidLAme(lameqty)
                End While

                If MsgBox("Are you sure to process this order?", vbQuestion + vbYesNo, "Process Order") = vbYes Then
                    While counter <= 23

                        rdbtns()
                        For Each row As DataGridViewRow In dtSummary.Rows
                            If row.Cells(0).Value = "Lar-C0104" Then
                                lamegr = row.Cells(4).Value
                                lamegrid = lamegr + lameqty
                                row.Cells(4).Value = lamegrid
                                row.Cells(5).Value = Integer.Parse(row.Cells(4).Value) * Price_Americano

                                lames = lamestock
                                txtSLAme.Text = lames - lamegrid

                                Exit Sub
                            End If

                        Next

                        dtSummary.Rows.Add("Lar-C0104", "Americano", lblAmePri.Text, "Coffee", "0", Price_Americano)
                        compute()


                    End While
                Else
                    rdbtns()
                    Exit Sub
                End If
            End If
        Else
            MsgBox("Please choose a variation")
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak("Please choose a variation.")
        End If
    End Sub

    Private Sub txtSRAme_TextChanged(sender As Object, e As EventArgs) Handles txtSRAme.TextChanged

        If txtSRAme.Text <= 0 Then

            txtSRAme.BackColor = Color.DarkRed
            txtSRAme.ForeColor = Color.White
            MsgBox("Out of Stock", 48, "Out of Stock")
            rbtnRegularAme.Enabled = False

        ElseIf txtSRAme.Text > 5 And txtSRAme.Text <= 10 Then

            txtSRAme.BackColor = Color.Yellow
            txtSRAme.ForeColor = Color.Black
            MsgBox("Your current stock number is " + txtSRAme.Text + "!", 48, "Warning")

        ElseIf txtSRAme.Text > 0 And txtSRAme.Text <= 5 Then

            txtSRAme.BackColor = Color.Red
            txtSRAme.ForeColor = Color.White
            MsgBox("Low on stock!", 48, "Critical")


        Else
            picAme.Hide()
            btnAmericano.Enabled = True
            rbtnRegular.Enabled = True
        End If

    End Sub

    Private Sub txtSMAme_TextChanged(sender As Object, e As EventArgs) Handles txtSMAme.TextChanged

        If txtSMAme.Text <= 0 Then

            txtSMAme.BackColor = Color.DarkRed
            txtSMAme.ForeColor = Color.White
            MsgBox("Out of Stock", 48, "Out of Stock")
            rbtnMediumAme.Enabled = False

        ElseIf txtSMAme.Text > 5 And txtSMAme.Text <= 10 Then

            txtSMAme.BackColor = Color.Yellow
            txtSMAme.ForeColor = Color.Black
            MsgBox("Your current stock number is " + txtSMAme.Text + "!", 48, "Warning")

        ElseIf txtSMAme.Text > 0 And txtSMAme.Text <= 5 Then

            txtSMAme.BackColor = Color.Red
            txtSMAme.ForeColor = Color.White
            MsgBox("Low on stock!", 48, "Critical")


        Else
            picAme.Hide()
            btnAmericano.Enabled = True
            rbtnMediumAme.Enabled = True
        End If

    End Sub

    Private Sub txtSLAme_TextChanged(sender As Object, e As EventArgs) Handles txtSLAme.TextChanged

        If txtSLAme.Text <= 0 Then

            txtSLAme.BackColor = Color.DarkRed
            txtSLAme.ForeColor = Color.White
            MsgBox("Out of Stock", 48, "Out of Stock")
            rbtnLargeAme.Enabled = False

        ElseIf txtSLAme.Text > 5 And txtSLAme.Text <= 10 Then

            txtSLAme.BackColor = Color.Yellow
            txtSLAme.ForeColor = Color.Black
            MsgBox("Your current stock number is " + txtSLAme.Text + "!", 48, "Warning")

        ElseIf txtSLAme.Text > 0 And txtSLAme.Text <= 5 Then

            txtSLAme.BackColor = Color.Red
            txtSLAme.ForeColor = Color.White
            MsgBox("Low on stock!", 48, "Critical")


        Else
            picAme.Hide()
            btnAmericano.Enabled = True
            rbtnLargeAme.Enabled = True
        End If

    End Sub

    Private Sub AmeStocks(sender As Object, e As EventArgs) Handles txtSRAme.TextChanged, txtSMAme.TextChanged, txtSLAme.TextChanged

        Dim reg As Integer
        Dim med As Integer
        Dim lar As Integer
        Dim bFlag

        bFlag = Integer.TryParse(txtSRAme.Text.Trim(), reg)
        bFlag = Integer.TryParse(txtSMAme.Text.Trim, med)
        bFlag = Integer.TryParse(txtSLAme.Text.Trim, lar)


        If reg <= 0 And med <= 0 And lar <= 0 Then
            picAme.Show()
            btnAmericano.Enabled = False
            MsgBox("Out of Stock", 48, "Out of Stock")
        Else
            picAme.Hide()
        End If
    End Sub

    Private Sub rbtnRegularAme_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnRegularAme.CheckedChanged
        lblAmePri.Text = ameprice.ToString("0.00")
    End Sub

    Private Sub rbtnMediumAme_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnMediumAme.CheckedChanged
        lblAmePri.Text = ameprice.ToString("0.00") + 50 & ".00"
    End Sub

    Private Sub rbtnLargeAme_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnLargeAme.CheckedChanged
        lblAmePri.Text = ameprice.ToString("0.00") + 100 & ".00"

    End Sub

    Private Sub btnCappuccino_Click(sender As Object, e As EventArgs) Handles btnCappuccino.Click
        Dim Price_Cappuccino As Integer = lblCapPrice.Text

        If rbtnRegularCap.Checked = True Then

            Dim capqty = getUserInput()

            Dim is_valid As Boolean
            is_valid = inputValidCap(capqty)

            If validInput = False Then
                MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                rdbtns()

            Else

                While is_valid = False Or capqty < 0 Or validInput = False Or capqty = 0 Or capqty > txtSRCap.Text

                    If capqty > txtSRCap.Text And capqty < 26 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                    ElseIf capqty > 25 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                        Exit Sub
                    ElseIf capqty < 0 Or validInput = False Or capqty = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    capqty = getUserInput()
                    is_valid = inputValidCap(capqty)
                End While

                If MsgBox("Are you sure to process this order?", vbQuestion + vbYesNo, "Process Order") = vbYes Then
                    While counter <= 23
                        rdbtns()

                        For Each row As DataGridViewRow In dtSummary.Rows
                            If row.Cells(0).Value = "Reg-C0105" Then
                                capgr = row.Cells(4).Value
                                capgrid = capgr + capqty
                                row.Cells(4).Value = capgrid
                                row.Cells(5).Value = Integer.Parse(row.Cells(4).Value) * Price_Cappuccino

                                caps = capstock
                                txtSRCap.Text = caps - capgrid

                                Exit Sub
                            End If

                        Next

                        dtSummary.Rows.Add("Reg-C0105", "Cappuccino", lblCapPrice.Text, "Coffee", "0", Price_Cappuccino)
                        compute()


                    End While
                Else
                    rdbtns()
                    Exit Sub
                End If
            End If

        ElseIf rbtnMediumCap.Checked = True Then

            Dim mcapqty = getUserInput()

            Dim is_valid As Boolean
            is_valid = inputValidMCap(mcapqty)

            If validInput = False Then
                MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                rdbtns()

            Else

                While is_valid = False Or mcapqty < 0 Or validInput = False Or mcapqty = 0 Or mcapqty > txtSMCap.Text

                    If mcapqty > txtSMCap.Text And mcapqty < 26 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                    ElseIf mcapqty > 25 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                        Exit Sub
                    ElseIf mcapqty < 0 Or validInput = False Or mcapqty = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    mcapqty = getUserInput()
                    is_valid = inputValidMCap(mcapqty)
                End While

                If MsgBox("Are you sure to process this order?", vbQuestion + vbYesNo, "Process Order") = vbYes Then
                    While counter <= 23
                        rdbtns()

                        For Each row As DataGridViewRow In dtSummary.Rows
                            If row.Cells(0).Value = "Med-C0105" Then
                                mcapgr = row.Cells(4).Value
                                mcapgrid = mcapgr + mcapqty
                                row.Cells(4).Value = mcapgrid
                                row.Cells(5).Value = Integer.Parse(row.Cells(4).Value) * Price_Cappuccino

                                mcaps = mcapstock
                                txtSMCap.Text = mcaps - mcapgrid

                                Exit Sub
                            End If

                        Next

                        dtSummary.Rows.Add("Med-C0105", "Cappuccino", lblCapPrice.Text, "Coffee", "0", Price_Cappuccino)
                        compute()


                    End While
                Else
                    rdbtns()
                    Exit Sub
                End If
            End If

        ElseIf rbtnLargeCap.Checked = True Then

            Dim lcapqty = getUserInput()

            Dim is_valid As Boolean
            is_valid = inputValidLCap(lcapqty)

            If validInput = False Then
                MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                rdbtns()

            Else

                While is_valid = False Or lcapqty < 0 Or validInput = False Or lcapqty = 0 Or lcapqty > txtSLCap.Text

                    If lcapqty > txtSLCap.Text And lcapqty < 26 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                    ElseIf lcapqty > 25 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                        Exit Sub
                    ElseIf lcapqty < 0 Or validInput = False Or lcapqty = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    lcapqty = getUserInput()
                    is_valid = inputValidLCap(lcapqty)
                End While

                If MsgBox("Are you sure to process this order?", vbQuestion + vbYesNo, "Process Order") = vbYes Then
                    While counter <= 23
                        rdbtns()

                        For Each row As DataGridViewRow In dtSummary.Rows
                            If row.Cells(0).Value = "Lar-C0105" Then
                                lcapgr = row.Cells(4).Value
                                lcapgrid = lcapgr + lcapqty
                                row.Cells(4).Value = lcapgrid
                                row.Cells(5).Value = Integer.Parse(row.Cells(4).Value) * Price_Cappuccino

                                lcaps = lcapstock
                                txtSLCap.Text = lcaps - lcapgrid

                                Exit Sub
                            End If

                        Next

                        dtSummary.Rows.Add("Lar-C0105", "Cappuccino", lblCapPrice.Text, "Coffee", "0", Price_Cappuccino)
                        compute()


                    End While
                Else
                    rdbtns()
                    Exit Sub
                End If
            End If
        Else
            MsgBox("Please choose a variation")
            SAPI = CreateObject("SAPI.spvoice")
            SAPI.speak("Please choose a variation.")
        End If

    End Sub

    Private Sub txtSRCap_TextChanged(sender As Object, e As EventArgs) Handles txtSRCap.TextChanged

        If txtSRCap.Text <= 0 Then

            txtSRCap.BackColor = Color.DarkRed
            txtSRCap.ForeColor = Color.White
            MsgBox("Out of Stock", 48, "Out of Stock")
            rbtnRegularCap.Enabled = False

        ElseIf txtSRCap.Text > 5 And txtSRCap.Text <= 10 Then

            txtSRCap.BackColor = Color.Yellow
            txtSRCap.ForeColor = Color.Black
            MsgBox("Your current stock number is " + txtSRCap.Text + "!", 48, "Warning")

        ElseIf txtSRCap.Text > 0 And txtSRCap.Text <= 5 Then

            txtSRCap.BackColor = Color.Red
            txtSRCap.ForeColor = Color.White
            MsgBox("Low on stock!", 48, "Critical")


        Else
            picCap.Hide()
            btnCappuccino.Enabled = True
            rbtnRegularCap.Enabled = True
        End If

    End Sub

    Private Sub txtSMCap_TextChanged(sender As Object, e As EventArgs) Handles txtSMCap.TextChanged

        If txtSMCap.Text <= 0 Then

            txtSMCap.BackColor = Color.DarkRed
            txtSMCap.ForeColor = Color.White
            MsgBox("Out of Stock", 48, "Out of Stock")
            rbtnMediumCap.Enabled = False

        ElseIf txtSMCap.Text > 5 And txtSMCap.Text <= 10 Then

            txtSMCap.BackColor = Color.Yellow
            txtSMCap.ForeColor = Color.Black
            MsgBox("Your current stock number is " + txtSMCap.Text + "!", 48, "Warning")

        ElseIf txtSMCap.Text > 0 And txtSMCap.Text <= 5 Then

            txtSMCap.BackColor = Color.Red
            txtSMCap.ForeColor = Color.White
            MsgBox("Low on stock!", 48, "Critical")


        Else
            picCap.Hide()
            btnCappuccino.Enabled = True
            rbtnMediumCap.Enabled = True
        End If

    End Sub

    Private Sub txtSLCap_TextChanged(sender As Object, e As EventArgs) Handles txtSLCap.TextChanged

        If txtSLCap.Text <= 0 Then

            txtSLCap.BackColor = Color.DarkRed
            txtSLCap.ForeColor = Color.White
            MsgBox("Out of Stock", 48, "Out of Stock")
            rbtnLargeCap.Enabled = False

        ElseIf txtSLCap.Text > 5 And txtSLCap.Text <= 10 Then

            txtSLCap.BackColor = Color.Yellow
            txtSLCap.ForeColor = Color.Black
            MsgBox("Your current stock number is " + txtSLCap.Text + "!", 48, "Warning")

        ElseIf txtSLCap.Text > 0 And txtSLCap.Text <= 5 Then

            txtSLCap.BackColor = Color.Red
            txtSLCap.ForeColor = Color.White
            MsgBox("Low on stock!", 48, "Critical")


        Else
            picCap.Hide()
            btnCappuccino.Enabled = True
            rbtnLargeCap.Enabled = True
        End If

    End Sub

    Private Sub CapStocks(sender As Object, e As EventArgs) Handles txtSRCap.TextChanged, txtSMCap.TextChanged, txtSLCap.TextChanged

        Dim reg As Integer
        Dim med As Integer
        Dim lar As Integer
        Dim bFlag

        bFlag = Integer.TryParse(txtSRCap.Text.Trim(), reg)
        bFlag = Integer.TryParse(txtSMCap.Text.Trim, med)
        bFlag = Integer.TryParse(txtSLCap.Text.Trim, lar)


        If reg <= 0 And med <= 0 And lar <= 0 Then
            picCap.Show()
            btnCappuccino.Enabled = False
            MsgBox("Out of Stock", 48, "Out of Stock")
        Else
            picCap.Hide()
        End If
    End Sub

    Private Sub rbtnRegularCap_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnRegularCap.CheckedChanged
        lblCapPrice.Text = capprice.ToString("0.00")
    End Sub

    Private Sub rbtnMediumCap_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnMediumCap.CheckedChanged
        lblCapPrice.Text = capprice.ToString("0.00") + 50 & ".00"
    End Sub

    Private Sub rbtnLargeCap_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnLargeCap.CheckedChanged
        lblCapPrice.Text = capprice.ToString("0.00") + 100 & ".00"
    End Sub

    Private Sub btnLatte_Click(sender As Object, e As EventArgs) Handles btnLatte.Click
        Dim Price_Latte As Integer = lblLatPrice.Text

        If rbtnRegularLat.Checked = True Then

            Dim latqty = getUserInput()

            Dim is_valid As Boolean
            is_valid = inputValidLat(latqty)

            If validInput = False Then
                MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                rdbtns()

            Else

                While is_valid = False Or latqty < 0 Or validInput = False Or latqty = 0 Or latqty > txtSRLat.Text

                    If latqty > txtSRLat.Text And latqty < 26 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                    ElseIf latqty > 25 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                        Exit Sub
                    ElseIf latqty < 0 Or validInput = False Or latqty = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        rdbtns()
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    latqty = getUserInput()
                    is_valid = inputValidLat(latqty)
                End While

                If MsgBox("Are you sure to process this order?", vbQuestion + vbYesNo, "Process Order") = vbYes Then
                    While counter <= 23
                        rdbtns()

                        For Each row As DataGridViewRow In dtSummary.Rows
                            If row.Cells(0).Value = "Reg-C0106" Then
                                latgr = row.Cells(4).Value
                                latgrid = latgr + latqty
                                row.Cells(4).Value = latgrid
                                row.Cells(5).Value = Integer.Parse(row.Cells(4).Value) * Price_Latte

                                lats = latstock
                                txtSRLat.Text = lats - latgrid

                                Exit Sub
                            End If

                        Next

                        dtSummary.Rows.Add("Reg-C0106", "Latte", lblLatPrice.Text, "Coffee", "0", Price_Latte)
                        compute()

                    End While
                Else
                    rdbtns()
                    Exit Sub
                End If
            End If

        ElseIf rbtnMediumLat.Checked = True Then

            Dim mlatqty = getUserInput()

            Dim is_valid As Boolean
            is_valid = inputValidMLat(mlatqty)

            If validInput = False Then
                MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                rdbtns()

            Else

                While is_valid = False Or mlatqty < 0 Or validInput = False Or mlatqty = 0 Or mlatqty > txtSMLat.Text

                    If mlatqty > txtSMLat.Text And mlatqty < 26 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                    ElseIf mlatqty > 25 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                        Exit Sub
                    ElseIf mlatqty < 0 Or validInput = False Or mlatqty = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        rdbtns()
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    mlatqty = getUserInput()
                    is_valid = inputValidMLat(mlatqty)
                End While

                If MsgBox("Are you sure to process this order?", vbQuestion + vbYesNo, "Process Order") = vbYes Then
                    While counter <= 23
                        rdbtns()

                        For Each row As DataGridViewRow In dtSummary.Rows
                            If row.Cells(0).Value = "Med-C0106" Then
                                mlatgr = row.Cells(4).Value
                                mlatgrid = mlatgr + mlatqty
                                row.Cells(4).Value = mlatgrid
                                row.Cells(5).Value = Integer.Parse(row.Cells(4).Value) * Price_Latte

                                mlats = mlatstock
                                txtSMLat.Text = mlats - mlatgrid

                                Exit Sub
                            End If

                        Next

                        dtSummary.Rows.Add("Med-C0106", "Latte", lblLatPrice.Text, "Coffee", "0", Price_Latte)
                        compute()

                    End While
                Else
                    rdbtns()
                    Exit Sub
                End If
            End If

        ElseIf rbtnLargeLat.Checked = True Then

            Dim llatqty = getUserInput()

            Dim is_valid As Boolean
            is_valid = inputValidLLat(llatqty)

            If validInput = False Then
                MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                rdbtns()

            Else

                While is_valid = False Or llatqty < 0 Or validInput = False Or llatqty = 0 Or llatqty > txtSLLat.Text

                    If llatqty > txtSLLat.Text And llatqty < 26 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                    ElseIf llatqty > 25 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                        Exit Sub
                    ElseIf llatqty < 0 Or validInput = False Or llatqty = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        rdbtns()
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    llatqty = getUserInput()
                    is_valid = inputValidLLat(llatqty)
                End While

                If MsgBox("Are you sure to process this order?", vbQuestion + vbYesNo, "Process Order") = vbYes Then
                    While counter <= 23
                        rdbtns()

                        For Each row As DataGridViewRow In dtSummary.Rows
                            If row.Cells(0).Value = "Lar-C0106" Then
                                llatgr = row.Cells(4).Value
                                llatgrid = llatgr + llatqty
                                row.Cells(4).Value = llatgrid
                                row.Cells(5).Value = Integer.Parse(row.Cells(4).Value) * Price_Latte

                                llats = llatstock
                                txtSLLat.Text = llats - llatgrid

                                Exit Sub
                            End If

                        Next

                        dtSummary.Rows.Add("Lar-C0106", "Latte", lblLatPrice.Text, "Coffee", "0", Price_Latte)
                        compute()

                    End While
                Else
                    rdbtns()
                    Exit Sub
                End If
            End If
        Else
            MsgBox("Please choose a variation")
            SAPI = CreateObject("SAPI.spvoice")
            SAPI.speak("Please choose a variation.")
        End If

    End Sub

    Private Sub txtSRLat_TextChanged(sender As Object, e As EventArgs) Handles txtSRLat.TextChanged

        If txtSRLat.Text <= 0 Then

            txtSRLat.BackColor = Color.DarkRed
            txtSRLat.ForeColor = Color.White
            MsgBox("Out of Stock", 48, "Out of Stock")
            rbtnRegularLat.Enabled = False

        ElseIf txtSRLat.Text > 5 And txtSRLat.Text <= 10 Then

            txtSRLat.BackColor = Color.Yellow
            txtSRLat.ForeColor = Color.Black
            MsgBox("Your current stock number is " + txtSRLat.Text + "!", 48, "Warning")

        ElseIf txtSRLat.Text > 0 And txtSRLat.Text <= 5 Then

            txtSRLat.BackColor = Color.Red
            txtSRLat.ForeColor = Color.White
            MsgBox("Low on stock!", 48, "Critical")


        Else
            picLat.Hide()
            btnLatte.Enabled = True
            rbtnRegularLat.Enabled = True
        End If

    End Sub

    Private Sub txtSMLat_TextChanged(sender As Object, e As EventArgs) Handles txtSMLat.TextChanged

        If txtSMLat.Text <= 0 Then

            txtSMLat.BackColor = Color.DarkRed
            txtSMLat.ForeColor = Color.White
            MsgBox("Out of Stock", 48, "Out of Stock")
            rbtnMediumLat.Enabled = False

        ElseIf txtSMLat.Text > 5 And txtSMLat.Text <= 10 Then

            txtSMLat.BackColor = Color.Yellow
            txtSMLat.ForeColor = Color.Black
            MsgBox("Your current stock number is " + txtSMLat.Text + "!", 48, "Warning")

        ElseIf txtSMLat.Text > 0 And txtSMLat.Text <= 5 Then

            txtSMLat.BackColor = Color.Red
            txtSMLat.ForeColor = Color.White
            MsgBox("Low on stock!", 48, "Critical")


        Else
            picLat.Hide()
            btnLatte.Enabled = True
            rbtnMediumLat.Enabled = True
        End If

    End Sub

    Private Sub txtSLLat_TextChanged(sender As Object, e As EventArgs) Handles txtSLLat.TextChanged

        If txtSLLat.Text <= 0 Then

            txtSLLat.BackColor = Color.DarkRed
            txtSLLat.ForeColor = Color.White
            MsgBox("Out of Stock", 48, "Out of Stock")
            rbtnLargeLat.Enabled = False

        ElseIf txtSLLat.Text > 5 And txtSLLat.Text <= 10 Then

            txtSLLat.BackColor = Color.Yellow
            txtSLLat.ForeColor = Color.Black
            MsgBox("Your current stock number is " + txtSLLat.Text + "!", 48, "Warning")

        ElseIf txtSLLat.Text > 0 And txtSLLat.Text <= 5 Then

            txtSLLat.BackColor = Color.Red
            txtSLLat.ForeColor = Color.White
            MsgBox("Low on stock!", 48, "Critical")


        Else
            picLat.Hide()
            btnLatte.Enabled = True
            rbtnLargeLat.Enabled = True
        End If

    End Sub

    Private Sub LatStocks(sender As Object, e As EventArgs) Handles txtSRLat.TextChanged, txtSMLat.TextChanged, txtSLLat.TextChanged

        Dim reg As Integer
        Dim med As Integer
        Dim lar As Integer
        Dim bFlag

        bFlag = Integer.TryParse(txtSRLat.Text.Trim(), reg)
        bFlag = Integer.TryParse(txtSMLat.Text.Trim, med)
        bFlag = Integer.TryParse(txtSLLat.Text.Trim, lar)


        If reg <= 0 And med <= 0 And lar <= 0 Then
            picLat.Show()
            btnLatte.Enabled = False
            MsgBox("Out of Stock", 48, "Out of Stock")
        Else
            picLat.Hide()
        End If
    End Sub

    Private Sub rbtnRegularLat_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnRegularLat.CheckedChanged
        lblLatPrice.Text = latprice.ToString("0.00")
    End Sub

    Private Sub rbtnMediumLat_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnMediumLat.CheckedChanged
        lblLatPrice.Text = latprice.ToString("0.00") + 50 & ".00"
    End Sub

    Private Sub rbtnLargeLat_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnLargeLat.CheckedChanged
        lblLatPrice.Text = latprice.ToString("0.00") + 100 & ".00"
    End Sub

    Private Sub btnMacchiato_Click(sender As Object, e As EventArgs) Handles btnMacchiato.Click
        Dim Price_Macchiato As Integer = lblMacPrice.Text

        If rbtnRegularMac.Checked = True Then

            Dim macqty = getUserInput()

            Dim is_valid As Boolean
            is_valid = inputValidMac(macqty)

            If validInput = False Then
                MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                rdbtns()

            Else

                While is_valid = False Or macqty < 0 Or validInput = False Or macqty = 0 Or macqty > txtSRMac.Text

                    If macqty > txtSRMac.Text And macqty < 26 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                    ElseIf macqty > 25 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                        Exit Sub
                    ElseIf macqty < 0 Or validInput = False Or macqty = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        rdbtns()
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    macqty = getUserInput()
                    is_valid = inputValidMac(macqty)
                End While

                If MsgBox("Are you sure to process this order?", vbQuestion + vbYesNo, "Process Order") = vbYes Then
                    While counter <= 23
                        rdbtns()
                        For Each row As DataGridViewRow In dtSummary.Rows
                            If row.Cells(0).Value = "Reg-C0107" Then
                                macgr = row.Cells(4).Value
                                macgrid = macgr + macqty
                                row.Cells(4).Value = macgrid
                                row.Cells(5).Value = Integer.Parse(row.Cells(4).Value) * Price_Macchiato

                                macs = macstock
                                txtSRMac.Text = macs - macgrid

                                Exit Sub
                            End If

                        Next

                        dtSummary.Rows.Add("Reg-C0107", "Macchiato", lblMacPrice.Text, "Coffee", "0", Price_Macchiato)
                        compute()


                    End While
                Else
                    rdbtns()
                    Exit Sub
                End If
            End If

        ElseIf rbtnMediumMac.Checked = True Then

            Dim mmacqty = getUserInput()

            Dim is_valid As Boolean
            is_valid = inputValidmMac(mmacqty)

            If validInput = False Then
                MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                rdbtns()

            Else

                While is_valid = False Or mmacqty < 0 Or validInput = False Or mmacqty = 0 Or mmacqty > txtSMMac.Text

                    If mmacqty > txtSMMac.Text And mmacqty < 26 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                    ElseIf mmacqty > 25 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                        Exit Sub
                    ElseIf mmacqty < 0 Or validInput = False Or mmacqty = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        rdbtns()
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    mmacqty = getUserInput()
                    is_valid = inputValidmMac(mmacqty)
                End While
                If MsgBox("Are you sure to process this order?", vbQuestion + vbYesNo, "Process Order") = vbYes Then
                    While counter <= 23
                        rdbtns()
                        For Each row As DataGridViewRow In dtSummary.Rows
                            If row.Cells(0).Value = "Med-C0107" Then
                                mmacgr = row.Cells(4).Value
                                mmacgrid = mmacgr + mmacqty
                                row.Cells(4).Value = mmacgrid
                                row.Cells(5).Value = Integer.Parse(row.Cells(4).Value) * Price_Macchiato

                                mmacs = mmacstock
                                txtSMMac.Text = mmacs - mmacgrid

                                Exit Sub
                            End If

                        Next

                        dtSummary.Rows.Add("Med-C0107", "Macchiato", lblMacPrice.Text, "Coffee", "0", Price_Macchiato)
                        compute()


                    End While
                Else
                    rdbtns()
                    Exit Sub
                End If
            End If

        ElseIf rbtnLargeMac.Checked = True Then

            Dim lmacqty = getUserInput()

            Dim is_valid As Boolean
            is_valid = inputValidLMac(lmacqty)

            If validInput = False Then
                MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                rdbtns()

            Else

                While is_valid = False Or lmacqty < 0 Or validInput = False Or lmacqty = 0 Or lmacqty > txtSLMac.Text

                    If lmacqty > txtSLMac.Text And lmacqty < 26 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                    ElseIf lmacqty > 25 Then
                        MsgBox("Sorry, there is not enough stock for this item. Try again!")
                        rdbtns()
                        Exit Sub
                    ElseIf lmacqty < 0 Or validInput = False Or lmacqty = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        rdbtns()
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    lmacqty = getUserInput()
                    is_valid = inputValidLMac(lmacqty)
                End While

                If MsgBox("Are you sure to process this order?", vbQuestion + vbYesNo, "Process Order") = vbYes Then
                    While counter <= 23
                        rdbtns()
                        For Each row As DataGridViewRow In dtSummary.Rows
                            If row.Cells(0).Value = "Lar-C0107" Then
                                lmacgr = row.Cells(4).Value
                                lmacgrid = lmacgr + lmacqty
                                row.Cells(4).Value = lmacgrid
                                row.Cells(5).Value = Integer.Parse(row.Cells(4).Value) * Price_Macchiato

                                lmacs = lmacstock
                                txtSLMac.Text = lmacs - lmacgrid

                                Exit Sub
                            End If

                        Next

                        dtSummary.Rows.Add("Lar-C0107", "Macchiato", lblMacPrice.Text, "Coffee", "0", Price_Macchiato)
                        compute()


                    End While
                Else
                    rdbtns()
                    Exit Sub
                End If
            End If
        Else
            MsgBox("Please choose a variation")
            SAPI = CreateObject("SAPI.spvoice")
            SAPI.speak("Please choose a variation.")
        End If

    End Sub

    Private Sub txtSRMac_TextChanged(sender As Object, e As EventArgs) Handles txtSRMac.TextChanged

        If txtSRMac.Text <= 0 Then

            txtSRMac.BackColor = Color.DarkRed
            txtSRMac.ForeColor = Color.White
            MsgBox("Out of Stock", 48, "Out of Stock")
            rbtnRegularMac.Enabled = False

        ElseIf txtSRMac.Text > 5 And txtSRMac.Text <= 10 Then

            txtSRMac.BackColor = Color.Yellow
            txtSRMac.ForeColor = Color.Black
            MsgBox("Your current stock number is " + txtSRMac.Text + "!", 48, "Warning")

        ElseIf txtSRMac.Text > 0 And txtSRMac.Text <= 5 Then

            txtSRMac.BackColor = Color.Red
            txtSRMac.ForeColor = Color.White
            MsgBox("Low on stock!", 48, "Critical")


        Else
            picMac.Hide()
            btnMacchiato.Enabled = True
            rbtnRegularMac.Enabled = True
        End If

    End Sub

    Private Sub txtSMMac_TextChanged(sender As Object, e As EventArgs) Handles txtSMMac.TextChanged

        If txtSMMac.Text <= 0 Then

            txtSMMac.BackColor = Color.DarkRed
            txtSMMac.ForeColor = Color.White
            MsgBox("Out of Stock", 48, "Out of Stock")
            rbtnMediumMac.Enabled = False

        ElseIf txtSMMac.Text > 5 And txtSMMac.Text <= 10 Then

            txtSMMac.BackColor = Color.Yellow
            txtSMMac.ForeColor = Color.Black
            MsgBox("Your current stock number is " + txtSMMac.Text + "!", 48, "Warning")

        ElseIf txtSMMac.Text > 0 And txtSMMac.Text <= 5 Then

            txtSMMac.BackColor = Color.Red
            txtSMMac.ForeColor = Color.White
            MsgBox("Low on stock!", 48, "Critical")


        Else
            picMac.Hide()
            btnMacchiato.Enabled = True
            rbtnMediumMac.Enabled = True
        End If

    End Sub

    Private Sub txtSLMac_TextChanged(sender As Object, e As EventArgs) Handles txtSLMac.TextChanged

        If txtSLMac.Text <= 0 Then

            txtSLMac.BackColor = Color.DarkRed
            txtSLMac.ForeColor = Color.White
            MsgBox("Out of Stock", 48, "Out of Stock")
            rbtnLargeMac.Enabled = False

        ElseIf txtSLMac.Text > 5 And txtSLMac.Text <= 10 Then

            txtSLMac.BackColor = Color.Yellow
            txtSLMac.ForeColor = Color.Black
            MsgBox("Your current stock number is " + txtSLMac.Text + "!", 48, "Warning")

        ElseIf txtSLMac.Text > 0 And txtSLMac.Text <= 5 Then

            txtSLMac.BackColor = Color.Red
            txtSLMac.ForeColor = Color.White
            MsgBox("Low on stock!", 48, "Critical")


        Else
            picMac.Hide()
            btnMacchiato.Enabled = True
            rbtnLargeMac.Enabled = True
        End If

    End Sub

    Private Sub MacStocks(sender As Object, e As EventArgs) Handles txtSRMac.TextChanged, txtSMMac.TextChanged, txtSLMac.TextChanged

        Dim reg As Integer
        Dim med As Integer
        Dim lar As Integer
        Dim bFlag

        bFlag = Integer.TryParse(txtSRMac.Text.Trim(), reg)
        bFlag = Integer.TryParse(txtSMMac.Text.Trim, med)
        bFlag = Integer.TryParse(txtSLMac.Text.Trim, lar)


        If reg <= 0 And med <= 0 And lar <= 0 Then
            picMac.Show()
            btnMacchiato.Enabled = False
            MsgBox("Out of Stock", 48, "Out of Stock")
        Else
            picMac.Hide()
        End If
    End Sub

    Private Sub rbtnRegularMac_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnRegularMac.CheckedChanged
        lblMacPrice.Text = macprice.ToString("0.00")
    End Sub

    Private Sub rbtnMediumMac_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnMediumMac.CheckedChanged
        lblMacPrice.Text = macprice.ToString("0.00") + 50 & ".00"
    End Sub

    Private Sub rbtnLargeMac_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnLargeMac.CheckedChanged
        lblMacPrice.Text = macprice.ToString("0.00") + 100 & ".00"
    End Sub

    Private Sub btnVoid_Click(sender As Object, e As EventArgs) Handles btnVoid.Click

        If dtSummary.SelectedRows.Count > 0 Then

            frmLogin.Show()

        Else
            MessageBox.Show("No rows has been selected ")
            Exit Sub
        End If
    End Sub

    Private Sub btnPizza_Click(sender As Object, e As EventArgs) Handles btnPizza.Click

        tabMenu.SelectedTab = tabPizza
        pnlBtn.Height = btnPizza.Height
        pnlBtn.Top = btnPizza.Top
        gifMenu.Hide()
        gifPizza.Show()
        gifBread.Hide()
        gifCoffee.Hide()
        tmHome.Stop()

    End Sub

    Private Sub btnBread_Click(sender As Object, e As EventArgs) Handles btnBread.Click

        tabMenu.SelectedTab = tabBread
        pnlBtn.Height = btnBread.Height
        pnlBtn.Top = btnBread.Top
        gifMenu.Hide()
        gifPizza.Hide()
        gifBread.Show()
        gifCoffee.Hide()
        tmHome.Stop()

    End Sub

    Private Sub btnCoffee_Click(sender As Object, e As EventArgs) Handles btnCoffee.Click

        tabMenu.SelectedTab = tabCoffee
        pnlBtn.Height = btnCoffee.Height
        pnlBtn.Top = btnCoffee.Top
        gifMenu.Hide()
        gifPizza.Hide()
        gifBread.Hide()
        gifCoffee.Show()
        tmHome.Stop()
    End Sub

    Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click

        tabMenu.SelectedTab = tbhome
        pnlBtn.Height = btnHome.Height
        pnlBtn.Top = btnHome.Top
        gifMenu.Show()
        gifPizza.Hide()
        gifBread.Hide()
        gifCoffee.Hide()
        tmHome.Start()
    End Sub

    Private Sub rbtnSenior_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnSenior.CheckedChanged

        Dim vat As Decimal = Total() * 0.12
        Dim discounts As Decimal
        Dim iTotal As Decimal
        Dim iDiscount As Decimal
        Dim bFlag

        bFlag = Decimal.TryParse(txtDiscount.Text.Trim(), iDiscount)
        bFlag = Decimal.TryParse(Total, iTotal)

        If rbtnSenior.Checked = True Then

            discounts = iTotal * 0.2
            txtVAT.Text = "VAT Exemption"
            txtDiscount.Text = discounts.ToString("0.00")
            senior = iTotal - discounts
            txtPAmount.Text = senior.ToString("0.00")
            MsgBox("You chose Senior Citizen, enjoy the 20% off!")
            custype = "Senior"

        End If
    End Sub

    Private Sub rbtnPWD_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnPWD.CheckedChanged

        Dim vat As Decimal = Total() * 0.12
        Dim discounts As Decimal
        Dim iTotal As Decimal
        Dim iDiscount As Decimal
        Dim bFlag

        bFlag = Decimal.TryParse(txtDiscount.Text.Trim(), iDiscount)
        bFlag = Decimal.TryParse(Total, iTotal)

        If rbtnPWD.Checked = True Then

            discounts = iTotal * 0.2
            txtVAT.Text = "VAT Exemption"
            txtDiscount.Text = discounts.ToString("0.00")
            pwd = iTotal - discounts
            txtPAmount.Text = pwd.ToString("0.00")
            MsgBox("You chose PWD, enjoy the 20% off!")
            custype = "PWD"

        End If
    End Sub

    Private Sub rbtnRegular_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnRegular.CheckedChanged
        Dim vat As Decimal = Total() * 0.12
        Dim totalpay As Decimal

        If rbtnRegular.Checked = True Then

            txtDiscount.Text = "0.00"
            txtVAT.Text = vat.ToString("0.00")
            totalpay = Total() + vat
            txtPAmount.Text = totalpay.ToString("0.00")
            MsgBox("You chose Regular, there's no discount!")
            custype = "Regular"

        End If
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click

        If txtPAmount.Text = "0.00" Then
            MsgBox("Order first!")

        ElseIf txtCName.Text = String.Empty Then
            MsgBox("Fill the customers name first.")
            txtCName.Focus()
        ElseIf dtSummary.Rows.Count < 0 Then
            MsgBox("Order first!")
        Else
            frmPayment.Show()
        End If

    End Sub

    Private Sub txtCName_KeyPress(sender As Object, e As KeyPressEventArgs)

        'If e.KeyChar.IsLetter(e.KeyChar) = False And e.KeyChar.IsControl(e.KeyChar) = False And e.KeyChar.IsSeparator(e.KeyChar) = False Then
        '    e.Handled = True
        'End If

        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyz"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        Dim closing As DialogResult

        If dtSummary.Rows.Count > 0 Then

            closing = MessageBox.Show("There's still product(s) on the cart, Are you sure you want to logout?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

            If closing = DialogResult.No Then
                Me.Show()
            Else
                frmLogin.Show()
                Me.Hide()
                frmLoad.Close()
            End If
        Else

            frmLogin.Show()
            Me.Hide()
            frmLoad.Close()
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim closing As DialogResult
        closing = MessageBox.Show("Do you really want to close the app?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If closing = DialogResult.No Then
            Me.Show()
        Else
            Application.ExitThread()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub lbldate_TextChanged(sender As Object, e As EventArgs) Handles lblDate.TextChanged
        Dim DtValue As String = Format(Now.Date, "MM/dd/yyyy")

        lblDate.Text = DtValue
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

    Private Sub tmHome_Tick(sender As Object, e As EventArgs) Handles tmHome.Tick

        For x As Integer = 0 To 17
            menu0(x).Top += 2

            If menu0(x).Top >= pnlHome.Height Then
                menu0(x).Top = -menu0(x).Height
            End If
        Next

    End Sub


End Class