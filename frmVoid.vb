Public Class frmVoid

    Public mozvoidqty, bacvoidqty, chivoidqty, mushvoidqty, vegvoidqty, vervoidqty, stock As Integer
    Dim mmozvoidqty, mbacvoidqty, mchivoidqty, mmushvoidqty, mvegvoidqty, mvervoidqty As Integer
    Dim lmozvoidqty, lbacvoidqty, lchivoidqty, lmushvoidqty, lvegvoidqty, lvervoidqty As Integer
    Dim rolvoidqty, frevoidqty, whevoidqty, whivoidqty, banvoidqty, hotvoidqty As Integer
    Dim espvoidqty, dopvoidqty, amevoidqty, capvoidqty, latvoidqty, macvoidqty As Integer
    Dim mespvoidqty, mdopvoidqty, mamevoidqty, mcapvoidqty, mlatvoidqty, mmacvoidqty As Integer
    Dim lespvoidqty, ldopvoidqty, lamevoidqty, lcapvoidqty, llatvoidqty, lmacvoidqty As Integer
    Dim validInput1 As Boolean
    Dim stocks As Integer
    Dim newpoint As New System.Drawing.Point

    Dim x, y As Integer

    Function inputVoid(input As Integer)

        If input > mainform.dtSummary.SelectedRows.Item(0).Cells(4).Value Then
            Return False
        End If
        Return True
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        Me.Close()
        For Each row As DataGridViewRow In mainform.dtSummary.SelectedRows

            If MsgBox("All items will be void. Are you sure you want to remove it?", 1, "Confirmation message") = vbOK Then

                If mainform.dtSummary.SelectedRows.Count > 0 Then
                    For i As Integer = mainform.dtSummary.SelectedRows.Count - 1 To 0 Step -1
                        mainform.dtSummary.Rows.RemoveAt(mainform.dtSummary.SelectedRows(i).Index)
                        MsgBox("You have succesfully removed all the items.")

                    Next
                End If

                If row.Cells(0).Value = "Reg-P0102" Then

                    stocks = mainform.mozgrid
                    mainform.mozgrid = stocks - row.Cells(4).Value
                    stock = mainform.txtSRMoz.Text
                    mainform.txtSRMoz.Text = stock + row.Cells(4).Value

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
                    mainform.rbtnRegularMoz.Enabled = True
                    mainform.btnMozzarella.Enabled = True
                    mainform.picMoz.Hide()
                    mainform.compute()
                    Exit Sub

                ElseIf row.Cells(0).Value = "Med-P0102" Then

                    stocks = mainform.mmozgrid
                    mainform.mmozgrid = stocks - row.Cells(4).Value
                    stock = mainform.txtSMMoz.Text
                    mainform.txtSMMoz.Text = stock + row.Cells(4).Value
                    If mainform.txtSMMoz.Text > 5 And mainform.txtSMMoz.Text <= 10 Then
                        mainform.txtSMMoz.BackColor = Color.Yellow
                        mainform.txtSMMoz.ForeColor = Color.Black

                    ElseIf mainform.txtSMMoz.Text > 0 And mainform.txtSMMoz.Text <= 5 Then
                        mainform.txtSMMoz.BackColor = Color.Red
                        mainform.txtSMMoz.ForeColor = Color.White
                    Else
                        mainform.txtSMMoz.BackColor = SystemColors.Control
                        mainform.txtSMMoz.ForeColor = Color.Black
                    End If
                    mainform.rbtnMediumMoz.Enabled = True
                    mainform.btnMozzarella.Enabled = True
                    mainform.picMoz.Hide()
                    mainform.compute()
                    Exit Sub

                ElseIf row.Cells(0).Value = "Lar-P0102" Then

                    stocks = mainform.lmozgrid
                    mainform.lmozgrid = stocks - row.Cells(4).Value
                    stock = mainform.txtSLMoz.Text
                    mainform.txtSLMoz.Text = stock + row.Cells(4).Value

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
                    mainform.rbtnLargeMoz.Enabled = True
                    mainform.btnMozzarella.Enabled = True
                    mainform.picMoz.Hide()
                    mainform.compute()
                    Exit Sub

                ElseIf row.Cells(0).Value = "Reg-P0103" Then

                    stocks = mainform.bacgrid
                    mainform.bacgrid = stocks - row.Cells(4).Value
                    stock = mainform.txtSRBac.Text
                    mainform.txtSRBac.Text = stock + row.Cells(4).Value

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
                    mainform.rbtnRegularBac.Enabled = True
                    mainform.btnBacon.Enabled = True
                    mainform.picBac.Hide()
                    mainform.compute()
                    Exit Sub

                ElseIf row.Cells(0).Value = "Med-P0103" Then

                    stocks = mainform.mbacgrid
                    mainform.mbacgrid = stocks - row.Cells(4).Value
                    stock = mainform.txtSMBac.Text
                    mainform.txtSMBac.Text = stock + row.Cells(4).Value
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
                    mainform.rbtnMediumBac.Enabled = True
                    mainform.btnBacon.Enabled = True
                    mainform.picBac.Hide()
                    mainform.compute()
                    Exit Sub

                ElseIf row.Cells(0).Value = "Lar-P0103" Then

                    stocks = mainform.lbacgrid
                    mainform.lbacgrid = stocks - row.Cells(4).Value
                    stock = mainform.txtSLBac.Text
                    mainform.txtSLBac.Text = stock + row.Cells(4).Value

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
                    mainform.rbtnLargeBac.Enabled = True
                    mainform.btnBacon.Enabled = True
                    mainform.picBac.Hide()
                    mainform.compute()
                    Exit Sub

                ElseIf row.Cells(0).Value = "Reg-P0104" Then

                    stocks = mainform.chigrid
                    mainform.chigrid = stocks - row.Cells(4).Value
                    stock = mainform.txtSRChi.Text
                    mainform.txtSRChi.Text = stock + row.Cells(4).Value

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

                    mainform.rbtnRegularChi.Enabled = True
                    mainform.btnChili.Enabled = True
                    mainform.picChili.Hide()
                    mainform.compute()
                    Exit Sub

                ElseIf row.Cells(0).Value = "Med-P0104" Then

                    stocks = mainform.mchigrid
                    mainform.mchigrid = stocks - row.Cells(4).Value
                    stock = mainform.txtSMChi.Text
                    mainform.txtSMChi.Text = stock + row.Cells(4).Value

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
                    mainform.rbtnMediumChi.Enabled = True
                    mainform.btnChili.Enabled = True
                    mainform.picChili.Hide()
                    mainform.compute()
                    Exit Sub

                ElseIf row.Cells(0).Value = "Lar-P0104" Then

                    stocks = mainform.lchigrid
                    mainform.lchigrid = stocks - row.Cells(4).Value
                    stock = mainform.txtSLChi.Text
                    mainform.txtSLChi.Text = stock + row.Cells(4).Value

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
                    mainform.rbtnLargeChi.Enabled = True
                    mainform.btnChili.Enabled = True
                    mainform.picChili.Hide()
                    mainform.compute()
                    Exit Sub

                ElseIf row.Cells(0).Value = "Reg-P0105" Then

                    stocks = mainform.musgrid
                    mainform.musgrid = stocks - row.Cells(4).Value
                    stock = mainform.txtSRMus.Text
                    mainform.txtSRMus.Text = stock + row.Cells(4).Value

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
                    mainform.rbtnRegularMus.Enabled = True
                    mainform.btnMushroom.Enabled = True
                    mainform.picMush.Hide()
                    mainform.compute()
                    Exit Sub

                ElseIf row.Cells(0).Value = "Med-P0105" Then

                    stocks = mainform.mmusgrid
                    mainform.mmusgrid = stocks - row.Cells(4).Value
                    stock = mainform.txtSMMus.Text
                    mainform.txtSMMus.Text = stock + row.Cells(4).Value

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
                    mainform.rbtnMediumMus.Enabled = True
                    mainform.btnMushroom.Enabled = True
                    mainform.picMush.Hide()
                    mainform.compute()
                    Exit Sub

                ElseIf row.Cells(0).Value = "Lar-P0105" Then

                    stocks = mainform.lmusgrid
                    mainform.lmusgrid = stocks - row.Cells(4).Value
                    stock = mainform.txtSLMus.Text
                    mainform.txtSLMus.Text = stock + row.Cells(4).Value

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
                    mainform.rbtnLargeMus.Enabled = True
                    mainform.btnMushroom.Enabled = True
                    mainform.picMush.Hide()
                    mainform.compute()
                    Exit Sub

                ElseIf row.Cells(0).Value = "Reg-P0106" Then
                    stocks = mainform.veggrid
                    mainform.veggrid = stocks - row.Cells(4).Value
                    stock = mainform.txtSRVeg.Text
                    mainform.txtSRVeg.Text = stock + row.Cells(4).Value

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
                    mainform.compute()

                    Exit Sub

                ElseIf row.Cells(0).Value = "Med-P0106" Then
                    stocks = mainform.mveggrid
                    mainform.mveggrid = stocks - row.Cells(4).Value
                    stock = mainform.txtSMVeg.Text
                    mainform.txtSMVeg.Text = stock + row.Cells(4).Value
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

                    mainform.rbtnMediumVeg.Enabled = True
                    mainform.btnVegetarian.Enabled = True
                    mainform.picVege.Hide()
                    mainform.compute()

                    Exit Sub

                ElseIf row.Cells(0).Value = "Lar-P0106" Then

                    stocks = mainform.lveggrid
                    mainform.lveggrid = stocks - row.Cells(4).Value
                    stock = mainform.txtSLVeg.Text
                    mainform.txtSLVeg.Text = stock + row.Cells(4).Value

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

                    mainform.rbtnLargeVeg.Enabled = True
                    mainform.btnVegetarian.Enabled = True
                    mainform.picVege.Hide()
                    mainform.compute()

                    Exit Sub

                ElseIf row.Cells(0).Value = "Reg-P0107" Then

                    stocks = mainform.vergrid
                    mainform.vergrid = stocks - row.Cells(4).Value
                    stock = mainform.txtSRVer.Text
                    mainform.txtSRVer.Text = stock + row.Cells(4).Value

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

                    mainform.rbtnRegularVer.Enabled = True
                    mainform.btnVeronese.Enabled = True
                    mainform.picVero.Hide()
                    mainform.compute()

                    Exit Sub

                ElseIf row.Cells(0).Value = "Med-P0107" Then

                    stocks = mainform.mvergrid
                    mainform.mvergrid = stocks - row.Cells(4).Value
                    stock = mainform.txtSMVer.Text
                    mainform.txtSMVer.Text = stock + row.Cells(4).Value

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

                    mainform.rbtnMediumVer.Enabled = True
                    mainform.btnVeronese.Enabled = True
                    mainform.picVero.Hide()
                    mainform.compute()

                    Exit Sub

                ElseIf row.Cells(0).Value = "Lar-P0107" Then

                    stocks = mainform.lvergrid
                    mainform.lvergrid = stocks - row.Cells(4).Value
                    stock = mainform.txtSLVer.Text

                    mainform.txtSLVer.Text = stock + row.Cells(4).Value
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

                    mainform.rbtnLargeVer.Enabled = True
                    mainform.btnVeronese.Enabled = True
                    mainform.picVero.Hide()
                    mainform.compute()

                    Exit Sub

                ElseIf row.Cells(0).Value = "B0102" Then

                    stocks = mainform.rolgrid
                    mainform.rolgrid = stocks - row.Cells(4).Value
                    stock = mainform.txtSRolls.Text
                    mainform.txtSRolls.Text = stock + row.Cells(4).Value

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
                    mainform.compute()

                    Exit Sub

                ElseIf row.Cells(0).Value = "B0103" Then

                    stocks = mainform.fregrid
                    mainform.fregrid = stocks - row.Cells(4).Value
                    stock = mainform.txtSFrench.Text
                    mainform.txtSFrench.Text = stock + row.Cells(4).Value

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
                    mainform.compute()

                    Exit Sub

                ElseIf row.Cells(0).Value = "B0105" Then

                    stocks = mainform.whegrid
                    mainform.whegrid = stocks - row.Cells(4).Value
                    stock = mainform.txtSWhite.Text
                    mainform.txtSWhite.Text = stock + row.Cells(4).Value

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
                    mainform.compute()

                    Exit Sub

                ElseIf row.Cells(0).Value = "B0104" Then

                    stocks = mainform.whigrid
                    mainform.whigrid = stocks - row.Cells(4).Value
                    stock = mainform.txtSWheat.Text
                    mainform.txtSWheat.Text = stock + row.Cells(4).Value

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
                    mainform.compute()

                    Exit Sub

                ElseIf row.Cells(0).Value = "B0106" Then

                    stocks = mainform.bangrid
                    mainform.bangrid = stocks - row.Cells(4).Value
                    stock = mainform.txtSBanana.Text
                    mainform.txtSBanana.Text = stock + row.Cells(4).Value

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
                    mainform.compute()

                    Exit Sub

                ElseIf row.Cells(0).Value = "B0107" Then

                    stocks = mainform.hotgrid
                    mainform.hotgrid = stocks - row.Cells(4).Value
                    stock = mainform.txtSHotdog.Text
                    mainform.txtSHotdog.Text = stock + row.Cells(4).Value

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
                    mainform.compute()

                    Exit Sub

                ElseIf row.Cells(0).Value = "Reg-C0102" Then

                    stocks = mainform.espgrid
                    mainform.espgrid = stocks - row.Cells(4).Value
                    stock = mainform.txtSREsp.Text
                    mainform.txtSREsp.Text = stock + row.Cells(4).Value

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
                    mainform.rbtnRegularEsp.Enabled = True
                    mainform.btnEspresso.Enabled = True
                    mainform.picEsp.Hide()
                    mainform.compute()

                    Exit Sub

                ElseIf row.Cells(0).Value = "Med-C0102" Then
                    stocks = mainform.mespgrid
                    mainform.mespgrid = stocks - row.Cells(4).Value
                    stock = mainform.txtSMEsp.Text
                    mainform.txtSMEsp.Text = stock + row.Cells(4).Value

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
                    mainform.rbtnMediumEsp.Enabled = True
                    mainform.btnEspresso.Enabled = True
                    mainform.picEsp.Hide()
                    mainform.compute()

                    Exit Sub

                ElseIf row.Cells(0).Value = "Lar-C0102" Then

                    stocks = mainform.lespgrid
                    mainform.lespgrid = stocks - row.Cells(4).Value
                    stock = mainform.txtSLEsp.Text
                    mainform.txtSLEsp.Text = stock + row.Cells(4).Value

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
                    mainform.rbtnLargeEsp.Enabled = True
                    mainform.btnEspresso.Enabled = True
                    mainform.picEsp.Hide()
                    mainform.compute()

                    Exit Sub

                ElseIf row.Cells(0).Value = "Reg-C0103" Then
                    stocks = mainform.dopgrid
                    mainform.dopgrid = stocks - row.Cells(4).Value
                    stock = mainform.txtSRDop.Text
                    mainform.txtSRDop.Text = stock + row.Cells(4).Value
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
                    mainform.rbtnRegularDop.Enabled = True
                    mainform.btnDoppio.Enabled = True
                    mainform.picDop.Hide()
                    mainform.compute()

                    Exit Sub

                ElseIf row.Cells(0).Value = "Med-C0103" Then

                    stocks = mainform.mdopgrid
                    mainform.mdopgrid = stocks - row.Cells(4).Value
                    stock = mainform.txtSMDop.Text
                    mainform.txtSMDop.Text = stock + row.Cells(4).Value

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
                    mainform.rbtnMediumDop.Enabled = True
                    mainform.btnDoppio.Enabled = True
                    mainform.picDop.Hide()
                    mainform.compute()

                    Exit Sub

                ElseIf row.Cells(0).Value = "Lar-C0103" Then

                    stocks = mainform.ldopgrid
                    mainform.ldopgrid = stocks - row.Cells(4).Value
                    stock = mainform.txtSLDop.Text
                    mainform.txtSLDop.Text = stock + row.Cells(4).Value

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
                    mainform.rbtnLargeDop.Enabled = True
                    mainform.btnDoppio.Enabled = True
                    mainform.picDop.Hide()
                    mainform.compute()

                    Exit Sub

                ElseIf row.Cells(0).Value = "Reg-C0104" Then

                    stocks = mainform.amegrid
                    mainform.amegrid = stocks - row.Cells(4).Value
                    stock = mainform.txtSRAme.Text
                    mainform.txtSRAme.Text = stock + row.Cells(4).Value

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
                    mainform.rbtnRegularAme.Enabled = True
                    mainform.btnAmericano.Enabled = True
                    mainform.picAme.Hide()
                    mainform.compute()

                    Exit Sub

                ElseIf row.Cells(0).Value = "Med-C0104" Then

                    stocks = mainform.mamegrid
                    mainform.mamegrid = stocks - row.Cells(4).Value
                    stock = mainform.txtSMAme.Text
                    mainform.txtSMAme.Text = stock + row.Cells(4).Value

                    If mainform.txtSMAme.Text > 5 And mainform.txtSMAme.Text <= 10 Then
                        mainform.txtSMAme.BackColor = Color.Yellow
                        mainform.txtSMAme.ForeColor = Color.Black

                    ElseIf mainform.txtSRAme.Text > 0 And mainform.txtSMAme.Text <= 5 Then
                        mainform.txtSMAme.BackColor = Color.Red
                        mainform.txtSMAme.ForeColor = Color.White
                    Else
                        mainform.txtSMAme.BackColor = SystemColors.Control
                        mainform.txtSMAme.ForeColor = Color.Black

                    End If
                    mainform.rbtnMediumAme.Enabled = True
                    mainform.btnAmericano.Enabled = True
                    mainform.picAme.Hide()
                    mainform.compute()

                    Exit Sub

                ElseIf row.Cells(0).Value = "Lar-C0104" Then

                    stocks = mainform.lamegrid
                    mainform.lamegrid = stocks - row.Cells(4).Value
                    stock = mainform.txtSLAme.Text
                    mainform.txtSLAme.Text = stock + row.Cells(4).Value

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
                    mainform.rbtnLargeAme.Enabled = True
                    mainform.btnAmericano.Enabled = True
                    mainform.picAme.Hide()
                    mainform.compute()

                    Exit Sub

                ElseIf row.Cells(0).Value = "Reg-C0105" Then

                    stocks = mainform.capgrid
                    mainform.capgrid = stocks - row.Cells(4).Value
                    stock = mainform.txtSRCap.Text
                    mainform.txtSRCap.Text = stock + row.Cells(4).Value

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
                    mainform.rbtnRegularCap.Enabled = True
                    mainform.btnCappuccino.Enabled = True
                    mainform.picCap.Hide()
                    mainform.compute()

                    Exit Sub

                ElseIf row.Cells(0).Value = "Med-C0105" Then

                    stocks = mainform.mcapgrid
                    mainform.mcapgrid = stocks - row.Cells(4).Value
                    stock = mainform.txtSMCap.Text
                    mainform.txtSMCap.Text = stock + row.Cells(4).Value

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
                    mainform.rbtnMediumCap.Enabled = True
                    mainform.btnCappuccino.Enabled = True
                    mainform.picCap.Hide()
                    mainform.compute()

                    Exit Sub

                ElseIf row.Cells(0).Value = "Lar-C0105" Then

                    stocks = mainform.lcapgrid
                    mainform.lcapgrid = stocks - row.Cells(4).Value
                    stock = mainform.txtSLCap.Text
                    mainform.txtSLCap.Text = stock + row.Cells(4).Value

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
                    mainform.rbtnLargeCap.Enabled = True
                    mainform.btnCappuccino.Enabled = True
                    mainform.picCap.Hide()
                    mainform.compute()

                    Exit Sub

                ElseIf row.Cells(0).Value = "Reg-C0106" Then

                    stocks = mainform.latgrid
                    mainform.latgrid = stocks - row.Cells(4).Value
                    stock = mainform.txtSRLat.Text
                    mainform.txtSRLat.Text = stock + row.Cells(4).Value

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
                    mainform.rbtnRegularLat.Enabled = True
                    mainform.btnLatte.Enabled = True
                    mainform.picLat.Hide()
                    mainform.compute()

                    Exit Sub

                ElseIf row.Cells(0).Value = "Med-C0106" Then

                    stocks = mainform.mlatgrid
                    mainform.mlatgrid = stocks - row.Cells(4).Value
                    stock = mainform.txtSMLat.Text
                    mainform.txtSMLat.Text = stock + row.Cells(4).Value

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
                    mainform.rbtnMediumLat.Enabled = True
                    mainform.btnLatte.Enabled = True
                    mainform.picLat.Hide()
                    mainform.compute()

                    Exit Sub

                ElseIf row.Cells(0).Value = "Lar-C0106" Then

                    stocks = mainform.llatgrid
                    mainform.llatgrid = stocks - row.Cells(4).Value
                    stock = mainform.txtSLLat.Text
                    mainform.txtSLLat.Text = stock + row.Cells(4).Value

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
                    mainform.rbtnLargeLat.Enabled = True
                    mainform.btnLatte.Enabled = True
                    mainform.picLat.Hide()
                    mainform.compute()

                    Exit Sub

                ElseIf row.Cells(0).Value = "Reg-C0107" Then

                    stocks = mainform.macgrid
                    mainform.macgrid = stocks - row.Cells(4).Value
                    stock = mainform.txtSRMac.Text
                    mainform.txtSRMac.Text = stock + row.Cells(4).Value

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
                    mainform.rbtnRegularMac.Enabled = True
                    mainform.btnMacchiato.Enabled = True
                    mainform.picMac.Hide()
                    mainform.compute()

                    Exit Sub

                ElseIf row.Cells(0).Value = "Med-C0107" Then
                    stocks = mainform.mmacgrid
                    mainform.mmacgrid = stocks - row.Cells(4).Value
                    stock = mainform.txtSMMac.Text
                    mainform.txtSMMac.Text = stock + row.Cells(4).Value
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
                    mainform.rbtnMediumMac.Enabled = True
                    mainform.btnMacchiato.Enabled = True
                    mainform.picMac.Hide()
                    mainform.compute()

                    Exit Sub

                ElseIf row.Cells(0).Value = "Lar-C0107" Then

                    stocks = mainform.lmacgrid
                    mainform.lmacgrid = stocks - row.Cells(4).Value
                    stock = mainform.txtSLMac.Text
                    mainform.txtSLMac.Text = stock + row.Cells(4).Value
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
                    mainform.rbtnLargeMac.Enabled = True
                    mainform.btnMacchiato.Enabled = True
                    mainform.picMac.Hide()
                    mainform.compute()

                    Exit Sub
                End If

            Else
                MsgBox("Cancelled")
                Exit Sub

            End If
        Next

    End Sub

    Private Sub btnAskQty_Click(sender As Object, e As EventArgs) Handles btnAskQty.Click
        Me.Close()
        For Each row As DataGridViewRow In mainform.dtSummary.SelectedRows

            validInput1 = mainform.validInput

            Dim input = mainform.getUserInput()
            Dim input_valid As Boolean

            If row.Cells(0).Value = "Reg-P0102" Then

                mozvoidqty += input
                input_valid = inputVoid(mozvoidqty)

                While input_valid = False Or input < 0 Or validInput1 = False Or input = 0 Or input = row.Cells(4).Value

                    mozvoidqty -= input

                    If input = row.Cells(4).Value Then
                        MsgBox("If you'll remove all choose the void all. Try again!")
                        Exit Sub
                    ElseIf input > row.Cells(4).Value And input < 26 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                    ElseIf input > 25 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                        Exit Sub
                    ElseIf input < 0 Or validInput1 = False Or input = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    input = mainform.getUserInput()
                    mozvoidqty += input
                    input_valid = inputVoid(mozvoidqty)
                End While

                If MsgBox("Item(s) will be void. Are you sure you want to remove it?", 1, "Confirmation message") = vbOK Then
                    If row.Cells(0).Value = "Reg-P0102" Then
                        row.Cells(4).Value = row.Cells(4).Value - mozvoidqty
                        row.Cells(5).Value = row.Cells(4).Value * row.Cells(2).Value

                        stocks = mainform.mozgrid
                        mainform.mozgrid = stocks - mozvoidqty
                        stock = mainform.txtSRMoz.Text
                        mainform.txtSRMoz.Text = stock + mozvoidqty

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
                        mainform.rbtnRegularMoz.Enabled = True
                        mainform.picMoz.Hide()
                        mainform.compute()
                        Exit Sub
                    End If
                Else

                    MsgBox("Cancelled")
                    Exit Sub
                End If
            End If

            If row.Cells(0).Value = "Med-P0102" Then

                mmozvoidqty += input
                input_valid = inputVoid(mmozvoidqty)

                While input_valid = False Or input < 0 Or validInput1 = False Or input = 0 Or input = row.Cells(4).Value

                    mmozvoidqty -= input

                    If input = row.Cells(4).Value Then
                        MsgBox("If you'll remove all choose the void all. Try again!")
                        Exit Sub
                    ElseIf input > row.Cells(4).Value And input < 26 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                    ElseIf input > 25 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                        Exit Sub
                    ElseIf input < 0 Or validInput1 = False Or input = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    input = mainform.getUserInput()
                    mmozvoidqty += input
                    input_valid = inputVoid(mmozvoidqty)
                End While

                If MsgBox("Item(s) will be void. Are you sure you want to remove it?", 1, "Confirmation message") = vbOK Then
                    If row.Cells(0).Value = "Med-P0102" Then
                        row.Cells(4).Value = row.Cells(4).Value - mmozvoidqty
                        row.Cells(5).Value = row.Cells(4).Value * row.Cells(2).Value
                        stocks = mainform.mmozgrid
                        mainform.mmozgrid = stocks - mmozvoidqty
                        stock = mainform.txtSMMoz.Text
                        mainform.txtSMMoz.Text = stock + mmozvoidqty
                        If mainform.txtSMMoz.Text > 5 And mainform.txtSMMoz.Text <= 10 Then
                            mainform.txtSMMoz.BackColor = Color.Yellow
                            mainform.txtSMMoz.ForeColor = Color.Black

                        ElseIf mainform.txtSMMoz.Text > 0 And mainform.txtSMMoz.Text <= 5 Then
                            mainform.txtSMMoz.BackColor = Color.Red
                            mainform.txtSMMoz.ForeColor = Color.White
                        Else
                            mainform.txtSMMoz.BackColor = SystemColors.Control
                            mainform.txtSMMoz.ForeColor = Color.Black
                        End If
                        mainform.rbtnMediumMoz.Enabled = True
                        mainform.btnMozzarella.Enabled = True
                        mainform.picMoz.Hide()
                        mainform.compute()
                        Exit Sub
                    End If
                Else

                    MsgBox("Cancelled")
                    Exit Sub
                End If
            End If

            If row.Cells(0).Value = "Lar-P0102" Then

                lmozvoidqty += input
                input_valid = inputVoid(lmozvoidqty)

                While input_valid = False Or input < 0 Or validInput1 = False Or input = 0 Or input = row.Cells(4).Value

                    lmozvoidqty -= input

                    If input = row.Cells(4).Value Then
                        MsgBox("If you'll remove all choose the void all. Try again!")
                        Exit Sub
                    ElseIf input > row.Cells(4).Value And input < 26 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                    ElseIf input > 25 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                        Exit Sub
                    ElseIf input < 0 Or validInput1 = False Or input = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    input = mainform.getUserInput()
                    lmozvoidqty += input
                    input_valid = inputVoid(lmozvoidqty)
                End While

                If MsgBox("Item(s) will be void. Are you sure you want to remove it?", 1, "Confirmation message") = vbOK Then
                    If row.Cells(0).Value = "Lar-P0102" Then
                        row.Cells(4).Value = row.Cells(4).Value - lmozvoidqty
                        row.Cells(5).Value = row.Cells(4).Value * row.Cells(2).Value
                        stocks = mainform.lmozgrid
                        mainform.lmozgrid = stocks - lmozvoidqty
                        stock = mainform.txtSLMoz.Text
                        mainform.txtSLMoz.Text = stock + lmozvoidqty
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
                        mainform.rbtnLargeMoz.Enabled = True
                        mainform.btnMozzarella.Enabled = True
                        mainform.picMoz.Hide()
                        mainform.compute()
                        Exit Sub
                    End If
                Else

                    MsgBox("Cancelled")
                    Exit Sub
                End If
            End If

            If row.Cells(0).Value = "Reg-P0103" Then
                bacvoidqty += input
                input_valid = inputVoid(bacvoidqty)

                While input_valid = False Or input < 0 Or validInput1 = False Or input = 0 Or input = row.Cells(4).Value

                    bacvoidqty -= input

                    If input = row.Cells(4).Value Then
                        MsgBox("If you'll remove all choose the void all. Try again!")
                        Exit Sub
                    ElseIf input > row.Cells(4).Value And input < 26 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                    ElseIf input > 25 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                        Exit Sub
                    ElseIf input < 0 Or validInput1 = False Or input = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    input = mainform.getUserInput()
                    bacvoidqty += input
                    input_valid = inputVoid(bacvoidqty)
                End While

                If MsgBox("Item(s) will be void. Are you sure you want to remove it?", 1, "Confirmation message") = vbOK Then
                    If row.Cells(0).Value = "Reg-P0103" Then
                        row.Cells(4).Value = row.Cells(4).Value - bacvoidqty
                        row.Cells(5).Value = row.Cells(4).Value * row.Cells(2).Value
                        stocks = mainform.bacgrid
                        mainform.bacgrid = stocks - bacvoidqty
                        stock = mainform.txtSRBac.Text
                        mainform.txtSRBac.Text = stock + bacvoidqty
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
                        mainform.rbtnRegularBac.Enabled = True
                        mainform.btnBacon.Enabled = True
                        mainform.picBac.Hide()
                        mainform.compute()
                        Exit Sub
                    End If
                Else

                    MsgBox("Cancelled")
                    Exit Sub
                End If
            End If

            If row.Cells(0).Value = "Med-P0103" Then
                mbacvoidqty += input
                input_valid = inputVoid(mbacvoidqty)

                While input_valid = False Or input < 0 Or validInput1 = False Or input = 0 Or input = row.Cells(4).Value

                    mbacvoidqty -= input

                    If input = row.Cells(4).Value Then
                        MsgBox("If you'll remove all choose the void all. Try again!")
                        Exit Sub
                    ElseIf input > row.Cells(4).Value And input < 26 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                    ElseIf input > 25 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                        Exit Sub
                    ElseIf input < 0 Or validInput1 = False Or input = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    input = mainform.getUserInput()
                    mbacvoidqty += input
                    input_valid = inputVoid(mbacvoidqty)
                End While

                If MsgBox("Item(s) will be void. Are you sure you want to remove it?", 1, "Confirmation message") = vbOK Then
                    If row.Cells(0).Value = "Med-P0103" Then
                        row.Cells(4).Value = row.Cells(4).Value - mbacvoidqty
                        row.Cells(5).Value = row.Cells(4).Value * row.Cells(2).Value
                        stocks = mainform.mbacgrid
                        mainform.mbacgrid = stocks - mbacvoidqty
                        stock = mainform.txtSMBac.Text
                        mainform.txtSMBac.Text = stock + mbacvoidqty
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
                        mainform.rbtnMediumBac.Enabled = True
                        mainform.btnBacon.Enabled = True
                        mainform.picBac.Hide()
                        mainform.compute()
                        Exit Sub
                    End If
                Else

                    MsgBox("Cancelled")
                    Exit Sub
                End If
            End If

            If row.Cells(0).Value = "Lar-P0103" Then
                lbacvoidqty += input
                input_valid = inputVoid(lbacvoidqty)

                While input_valid = False Or input < 0 Or validInput1 = False Or input = 0 Or input = row.Cells(4).Value

                    lbacvoidqty -= input

                    If input = row.Cells(4).Value Then
                        MsgBox("If you'll remove all choose the void all. Try again!")
                        Exit Sub
                    ElseIf input > row.Cells(4).Value And input < 26 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                    ElseIf input > 25 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                        Exit Sub
                    ElseIf input < 0 Or validInput1 = False Or input = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    input = mainform.getUserInput()
                    lbacvoidqty += input
                    input_valid = inputVoid(lbacvoidqty)
                End While

                If MsgBox("Item(s) will be void. Are you sure you want to remove it?", 1, "Confirmation message") = vbOK Then
                    If row.Cells(0).Value = "Lar-P0103" Then
                        row.Cells(4).Value = row.Cells(4).Value - lbacvoidqty
                        row.Cells(5).Value = row.Cells(4).Value * row.Cells(2).Value
                        stocks = mainform.lbacgrid
                        mainform.lbacgrid = stocks - lbacvoidqty
                        stock = mainform.txtSLBac.Text
                        mainform.txtSLBac.Text = stock + lbacvoidqty

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

                        mainform.rbtnLargeBac.Enabled = True
                        mainform.btnBacon.Enabled = True
                        mainform.picBac.Hide()
                        mainform.compute()
                        Exit Sub
                    End If
                Else

                    MsgBox("Cancelled")
                    Exit Sub
                End If
            End If

            If row.Cells(0).Value = "Reg-P0104" Then
                chivoidqty += input
                input_valid = inputVoid(chivoidqty)

                While input_valid = False Or input < 0 Or validInput1 = False Or input = 0 Or input = row.Cells(4).Value

                    chivoidqty -= input

                    If input = row.Cells(4).Value Then
                        MsgBox("If you'll remove all choose the void all. Try again!")
                        Exit Sub
                    ElseIf input > row.Cells(4).Value And input < 26 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                    ElseIf input > 25 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                        Exit Sub
                    ElseIf input < 0 Or validInput1 = False Or input = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    input = mainform.getUserInput()
                    chivoidqty += input
                    input_valid = inputVoid(chivoidqty)
                End While

                If MsgBox("Item(s) will be void. Are you sure you want to remove it?", 1, "Confirmation message") = vbOK Then
                    If row.Cells(0).Value = "Reg-P0104" Then
                        row.Cells(4).Value = row.Cells(4).Value - chivoidqty
                        row.Cells(5).Value = row.Cells(4).Value * row.Cells(2).Value
                        stocks = mainform.chigrid
                        mainform.chigrid = stocks - chivoidqty
                        stock = mainform.txtSRChi.Text
                        mainform.txtSRChi.Text = stock + chivoidqty

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
                        mainform.rbtnRegularChi.Enabled = True
                        mainform.btnChili.Enabled = True
                        mainform.picChili.Hide()
                        mainform.compute()
                        Exit Sub
                    End If
                Else

                    MsgBox("Cancelled")
                    Exit Sub
                End If
            End If

            If row.Cells(0).Value = "Med-P0104" Then
                mchivoidqty += input
                input_valid = inputVoid(mchivoidqty)

                While input_valid = False Or input < 0 Or validInput1 = False Or input = 0 Or input = row.Cells(4).Value

                    mchivoidqty -= input

                    If input = row.Cells(4).Value Then
                        MsgBox("If you'll remove all choose the void all. Try again!")
                        Exit Sub
                    ElseIf input > row.Cells(4).Value And input < 26 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                    ElseIf input > 25 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                        Exit Sub
                    ElseIf input < 0 Or validInput1 = False Or input = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    input = mainform.getUserInput()
                    mchivoidqty += input
                    input_valid = inputVoid(mchivoidqty)
                End While

                If MsgBox("Item(s) will be void. Are you sure you want to remove it?", 1, "Confirmation message") = vbOK Then
                    If row.Cells(0).Value = "Med-P0104" Then
                        row.Cells(4).Value = row.Cells(4).Value - mchivoidqty
                        row.Cells(5).Value = row.Cells(4).Value * row.Cells(2).Value
                        stocks = mainform.mchigrid
                        mainform.mchigrid = stocks - mchivoidqty
                        stock = mainform.txtSMChi.Text
                        mainform.txtSMChi.Text = stock + mchivoidqty

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
                        mainform.rbtnMediumChi.Enabled = True
                        mainform.btnChili.Enabled = True
                        mainform.picChili.Hide()
                        mainform.compute()
                        Exit Sub
                    End If
                Else

                    MsgBox("Cancelled")
                    Exit Sub
                End If
            End If

            If row.Cells(0).Value = "Lar-P0104" Then
                lchivoidqty += input
                input_valid = inputVoid(lchivoidqty)

                While input_valid = False Or input < 0 Or validInput1 = False Or input = 0 Or input = row.Cells(4).Value

                    lchivoidqty -= input

                    If input = row.Cells(4).Value Then
                        MsgBox("If you'll remove all choose the void all. Try again!")
                        Exit Sub
                    ElseIf input > row.Cells(4).Value And input < 26 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                    ElseIf input > 25 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                        Exit Sub
                    ElseIf input < 0 Or validInput1 = False Or input = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    input = mainform.getUserInput()
                    lchivoidqty += input
                    input_valid = inputVoid(lchivoidqty)
                End While

                If MsgBox("Item(s) will be void. Are you sure you want to remove it?", 1, "Confirmation message") = vbOK Then
                    If row.Cells(0).Value = "Lar-P0104" Then
                        row.Cells(4).Value = row.Cells(4).Value - lchivoidqty
                        row.Cells(5).Value = row.Cells(4).Value * row.Cells(2).Value
                        stocks = mainform.lchigrid
                        mainform.lchigrid = stocks - lchivoidqty
                        stock = mainform.txtSLChi.Text
                        mainform.txtSLChi.Text = stock + lchivoidqty

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
                        mainform.rbtnLargeChi.Enabled = True
                        mainform.btnChili.Enabled = True
                        mainform.picChili.Hide()
                        mainform.compute()
                        Exit Sub
                    End If
                Else

                    MsgBox("Cancelled")
                    Exit Sub
                End If
            End If

            If row.Cells(0).Value = "Reg-P0105" Then
                mushvoidqty += input
                input_valid = inputVoid(mushvoidqty)

                While input_valid = False Or input < 0 Or validInput1 = False Or input = 0 Or input = row.Cells(4).Value

                    mushvoidqty -= input

                    If input = row.Cells(4).Value Then
                        MsgBox("If you'll remove all choose the void all. Try again!")
                        Exit Sub
                    ElseIf input > row.Cells(4).Value And input < 26 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                    ElseIf input > 25 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                        Exit Sub
                    ElseIf input < 0 Or validInput1 = False Or input = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    input = mainform.getUserInput()
                    mushvoidqty += input
                    input_valid = inputVoid(mushvoidqty)
                End While

                If MsgBox("Item(s) will be void. Are you sure you want to remove it?", 1, "Confirmation message") = vbOK Then
                    If row.Cells(0).Value = "Reg-P0105" Then
                        row.Cells(4).Value = row.Cells(4).Value - mushvoidqty
                        row.Cells(5).Value = row.Cells(4).Value * row.Cells(2).Value
                        stocks = mainform.musgrid
                        mainform.musgrid = stocks - mushvoidqty
                        stock = mainform.txtSRMus.Text
                        mainform.txtSRMus.Text = stock + mushvoidqty

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
                        mainform.rbtnRegularMus.Enabled = True
                        mainform.btnMushroom.Enabled = True
                        mainform.picMush.Hide()
                        mainform.compute()
                        Exit Sub
                    End If
                Else

                    MsgBox("Cancelled")
                    Exit Sub
                End If
            End If

            If row.Cells(0).Value = "Med-P0105" Then
                mmushvoidqty += input
                input_valid = inputVoid(mmushvoidqty)

                While input_valid = False Or input < 0 Or validInput1 = False Or input = 0 Or input = row.Cells(4).Value

                    mmushvoidqty -= input

                    If input = row.Cells(4).Value Then
                        MsgBox("If you'll remove all choose the void all. Try again!")
                        Exit Sub
                    ElseIf input > row.Cells(4).Value And input < 26 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                    ElseIf input > 25 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                        Exit Sub
                    ElseIf input < 0 Or validInput1 = False Or input = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    input = mainform.getUserInput()
                    mmushvoidqty += input
                    input_valid = inputVoid(mmushvoidqty)
                End While

                If MsgBox("Item(s) will be void. Are you sure you want to remove it?", 1, "Confirmation message") = vbOK Then
                    If row.Cells(0).Value = "Med-P0105" Then
                        row.Cells(4).Value = row.Cells(4).Value - mmushvoidqty
                        row.Cells(5).Value = row.Cells(4).Value * row.Cells(2).Value
                        stocks = mainform.mmusgrid
                        mainform.mmusgrid = stocks - mmushvoidqty
                        stock = mainform.txtSMMus.Text
                        mainform.txtSMMus.Text = stock + mmushvoidqty

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
                        mainform.rbtnMediumMus.Enabled = True
                        mainform.btnMushroom.Enabled = True
                        mainform.picMush.Hide()
                        mainform.compute()
                        Exit Sub
                    End If
                Else

                    MsgBox("Cancelled")
                    Exit Sub
                End If
            End If

            If row.Cells(0).Value = "Lar-P0105" Then
                lmushvoidqty += input
                input_valid = inputVoid(lmushvoidqty)

                While input_valid = False Or input < 0 Or validInput1 = False Or input = 0 Or input = row.Cells(4).Value

                    lmushvoidqty -= input

                    If input = row.Cells(4).Value Then
                        MsgBox("If you'll remove all choose the void all. Try again!")
                        Exit Sub
                    ElseIf input > row.Cells(4).Value And input < 26 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                    ElseIf input > 25 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                        Exit Sub
                    ElseIf input < 0 Or validInput1 = False Or input = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    input = mainform.getUserInput()
                    lmushvoidqty += input
                    input_valid = inputVoid(lmushvoidqty)
                End While

                If MsgBox("Item(s) will be void. Are you sure you want to remove it?", 1, "Confirmation message") = vbOK Then
                    If row.Cells(0).Value = "Lar-P0105" Then
                        row.Cells(4).Value = row.Cells(4).Value - lmushvoidqty
                        row.Cells(5).Value = row.Cells(4).Value * row.Cells(2).Value
                        stocks = mainform.lmusgrid
                        mainform.lmusgrid = stocks - lmushvoidqty
                        stock = mainform.txtSLMus.Text
                        mainform.txtSLMus.Text = stock + lmushvoidqty

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
                        mainform.rbtnLargeMus.Enabled = True
                        mainform.btnMushroom.Enabled = True
                        mainform.picMush.Hide()
                        mainform.compute()
                        Exit Sub
                    End If
                Else

                    MsgBox("Cancelled")
                    Exit Sub
                End If
            End If

            If row.Cells(0).Value = "Reg-P0106" Then
                vegvoidqty += input
                input_valid = inputVoid(vegvoidqty)

                While input_valid = False Or input < 0 Or validInput1 = False Or input = 0 Or input = row.Cells(4).Value

                    vegvoidqty -= input

                    If input = row.Cells(4).Value Then
                        MsgBox("If you'll remove all choose the void all. Try again!")
                        Exit Sub
                    ElseIf input > row.Cells(4).Value And input < 26 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                    ElseIf input > 25 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                        Exit Sub
                    ElseIf input < 0 Or validInput1 = False Or input = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    input = mainform.getUserInput()
                    vegvoidqty += input
                    input_valid = inputVoid(vegvoidqty)
                End While

                If MsgBox("Item(s) will be void. Are you sure you want to remove it?", 1, "Confirmation message") = vbOK Then
                    If row.Cells(0).Value = "Reg-P0106" Then
                        row.Cells(4).Value = row.Cells(4).Value - vegvoidqty
                        row.Cells(5).Value = row.Cells(4).Value * row.Cells(2).Value
                        stocks = mainform.veggrid
                        mainform.veggrid = stocks - vegvoidqty
                        stock = mainform.txtSRVeg.Text
                        mainform.txtSRVeg.Text = stock + vegvoidqty

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
                        mainform.rbtnRegularVeg.Enabled = True
                        mainform.btnVegetarian.Enabled = True
                        mainform.picVege.Hide()
                        mainform.compute()
                        Exit Sub
                    End If
                Else

                    MsgBox("Cancelled")
                    Exit Sub
                End If
            End If

            If row.Cells(0).Value = "Med-P0106" Then
                mvegvoidqty += input
                input_valid = inputVoid(mvegvoidqty)

                While input_valid = False Or input < 0 Or validInput1 = False Or input = 0 Or input = row.Cells(4).Value

                    mvegvoidqty -= input

                    If input = row.Cells(4).Value Then
                        MsgBox("If you'll remove all choose the void all. Try again!")
                        Exit Sub
                    ElseIf input > row.Cells(4).Value And input < 26 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                    ElseIf input > 25 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                        Exit Sub
                    ElseIf input < 0 Or validInput1 = False Or input = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    input = mainform.getUserInput()
                    mvegvoidqty += input
                    input_valid = inputVoid(mvegvoidqty)
                End While

                If MsgBox("Item(s) will be void. Are you sure you want to remove it?", 1, "Confirmation message") = vbOK Then
                    If row.Cells(0).Value = "Med-P0106" Then
                        row.Cells(4).Value = row.Cells(4).Value - mvegvoidqty
                        row.Cells(5).Value = row.Cells(4).Value * row.Cells(2).Value
                        stocks = mainform.mveggrid
                        mainform.mveggrid = stocks - mvegvoidqty
                        stock = mainform.txtSMVeg.Text
                        mainform.txtSMVeg.Text = stock + mvegvoidqty

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

                        mainform.rbtnMediumVeg.Enabled = True
                        mainform.btnVegetarian.Enabled = True
                        mainform.picVege.Hide()
                        mainform.compute()
                        Exit Sub
                    End If
                Else

                    MsgBox("Cancelled")
                    Exit Sub
                End If
            End If

            If row.Cells(0).Value = "Lar-P0106" Then
                lvegvoidqty += input
                input_valid = inputVoid(lvegvoidqty)

                While input_valid = False Or input < 0 Or validInput1 = False Or input = 0 Or input = row.Cells(4).Value

                    lvegvoidqty -= input

                    If input = row.Cells(4).Value Then
                        MsgBox("If you'll remove all choose the void all. Try again!")
                        Exit Sub
                    ElseIf input > row.Cells(4).Value And input < 26 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                    ElseIf input > 25 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                        Exit Sub
                    ElseIf input < 0 Or validInput1 = False Or input = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    input = mainform.getUserInput()
                    lvegvoidqty += input
                    input_valid = inputVoid(lvegvoidqty)
                End While

                If MsgBox("Item(s) will be void. Are you sure you want to remove it?", 1, "Confirmation message") = vbOK Then
                    If row.Cells(0).Value = "Lar-P0106" Then
                        row.Cells(4).Value = row.Cells(4).Value - lvegvoidqty
                        row.Cells(5).Value = row.Cells(4).Value * row.Cells(2).Value
                        stocks = mainform.lveggrid
                        mainform.lveggrid = stocks - lvegvoidqty
                        stock = mainform.txtSLVeg.Text
                        mainform.txtSLVeg.Text = stock + lvegvoidqty

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

                        mainform.rbtnLargeVeg.Enabled = True
                        mainform.btnVegetarian.Enabled = True
                        mainform.picVege.Hide()
                        mainform.compute()
                        Exit Sub
                    End If
                Else

                    MsgBox("Cancelled")
                    Exit Sub
                End If
            End If

            If row.Cells(0).Value = "Reg-P0107" Then
                vervoidqty += input
                input_valid = inputVoid(vervoidqty)

                While input_valid = False Or input < 0 Or validInput1 = False Or input = 0 Or input = row.Cells(4).Value

                    vervoidqty -= input

                    If input = row.Cells(4).Value Then
                        MsgBox("If you'll remove all choose the void all. Try again!")
                        Exit Sub
                    ElseIf input > row.Cells(4).Value And input < 26 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                    ElseIf input > 25 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                        Exit Sub
                    ElseIf input < 0 Or validInput1 = False Or input = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    input = mainform.getUserInput()
                    vervoidqty += input
                    input_valid = inputVoid(vervoidqty)
                End While

                If MsgBox("Item(s) will be void. Are you sure you want to remove it?", 1, "Confirmation message") = vbOK Then
                    If row.Cells(0).Value = "Reg-P0107" Then
                        row.Cells(4).Value = row.Cells(4).Value - vervoidqty
                        row.Cells(5).Value = row.Cells(4).Value * row.Cells(2).Value
                        stocks = mainform.vergrid
                        mainform.vergrid = stocks - vervoidqty
                        stock = mainform.txtSRVer.Text
                        mainform.txtSRVer.Text = stock + vervoidqty

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


                        mainform.rbtnRegularVer.Enabled = True
                        mainform.btnVeronese.Enabled = True
                        mainform.picVero.Hide()
                        mainform.compute()

                        Exit Sub
                    End If
                Else

                    MsgBox("Cancelled")
                    Exit Sub
                End If
            End If

            If row.Cells(0).Value = "Med-P0107" Then
                mvervoidqty += input
                input_valid = inputVoid(mvervoidqty)

                While input_valid = False Or input < 0 Or validInput1 = False Or input = 0 Or input = row.Cells(4).Value

                    mvervoidqty -= input

                    If input = row.Cells(4).Value Then
                        MsgBox("If you'll remove all choose the void all. Try again!")
                        Exit Sub
                    ElseIf input > row.Cells(4).Value And input < 26 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                    ElseIf input > 25 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                        Exit Sub
                    ElseIf input < 0 Or validInput1 = False Or input = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    input = mainform.getUserInput()
                    mvervoidqty += input
                    input_valid = inputVoid(mvervoidqty)
                End While

                If MsgBox("Item(s) will be void. Are you sure you want to remove it?", 1, "Confirmation message") = vbOK Then
                    If row.Cells(0).Value = "Med-P0107" Then
                        row.Cells(4).Value = row.Cells(4).Value - mvervoidqty
                        row.Cells(5).Value = row.Cells(4).Value * row.Cells(2).Value
                        stocks = mainform.mvergrid
                        mainform.mvergrid = stocks - mvervoidqty
                        stock = mainform.txtSMVer.Text
                        mainform.txtSMVer.Text = stock + mvervoidqty

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


                        mainform.rbtnMediumVer.Enabled = True
                        mainform.btnVeronese.Enabled = True
                        mainform.picVero.Hide()
                        mainform.compute()

                        Exit Sub
                    End If
                Else

                    MsgBox("Cancelled")
                    Exit Sub
                End If
            End If

            If row.Cells(0).Value = "Lar-P0107" Then
                lvervoidqty += input
                input_valid = inputVoid(lvervoidqty)

                While input_valid = False Or input < 0 Or validInput1 = False Or input = 0 Or input = row.Cells(4).Value

                    lvervoidqty -= input

                    If input = row.Cells(4).Value Then
                        MsgBox("If you'll remove all choose the void all. Try again!")
                        Exit Sub
                    ElseIf input > row.Cells(4).Value And input < 26 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                    ElseIf input > 25 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                        Exit Sub
                    ElseIf input < 0 Or validInput1 = False Or input = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    input = mainform.getUserInput()
                    lvervoidqty += input
                    input_valid = inputVoid(lvervoidqty)
                End While

                If MsgBox("Item(s) will be void. Are you sure you want to remove it?", 1, "Confirmation message") = vbOK Then
                    If row.Cells(0).Value = "Lar-P0107" Then
                        row.Cells(4).Value = row.Cells(4).Value - lvervoidqty
                        row.Cells(5).Value = row.Cells(4).Value * row.Cells(2).Value
                        stocks = mainform.lvergrid
                        mainform.lvergrid = stocks - lvervoidqty
                        stock = mainform.txtSLVer.Text
                        mainform.txtSLVer.Text = stock + lvervoidqty

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

                        mainform.rbtnLargeVer.Enabled = True
                        mainform.btnVeronese.Enabled = True
                        mainform.picVero.Hide()
                        mainform.compute()

                        Exit Sub
                    End If
                Else

                    MsgBox("Cancelled")
                    Exit Sub
                End If
            End If

            If row.Cells(1).Value = "Rolls" Then
                rolvoidqty += input
                input_valid = inputVoid(rolvoidqty)

                While input_valid = False Or input < 0 Or validInput1 = False Or input = 0 Or input = row.Cells(4).Value

                    rolvoidqty -= input

                    If input = row.Cells(4).Value Then
                        MsgBox("If you'll remove all choose the void all. Try again!")
                        Exit Sub
                    ElseIf input > row.Cells(4).Value And input < 26 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                    ElseIf input > 25 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                        Exit Sub
                    ElseIf input < 0 Or validInput1 = False Or input = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    input = mainform.getUserInput()
                    rolvoidqty += input
                    input_valid = inputVoid(rolvoidqty)
                End While

                If MsgBox("Item(s) will be void. Are you sure you want to remove it?", 1, "Confirmation message") = vbOK Then
                    If row.Cells(1).Value = "Rolls" Then
                        row.Cells(4).Value = row.Cells(4).Value - rolvoidqty
                        row.Cells(5).Value = row.Cells(4).Value * 90
                        stocks = mainform.rolgrid
                        mainform.rolgrid = stocks - rolvoidqty
                        stock = mainform.txtSRolls.Text
                        mainform.txtSRolls.Text = stock + rolvoidqty

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
                        mainform.compute()

                        Exit Sub
                    End If
                Else

                    MsgBox("Cancelled")
                    Exit Sub
                End If
            End If

            If row.Cells(1).Value = "French Bread" Then
                frevoidqty += input
                input_valid = inputVoid(frevoidqty)

                While input_valid = False Or input < 0 Or validInput1 = False Or input = 0 Or input = row.Cells(4).Value

                    frevoidqty -= input

                    If input = row.Cells(4).Value Then
                        MsgBox("If you'll remove all choose the void all. Try again!")
                        Exit Sub
                    ElseIf input > row.Cells(4).Value And input < 26 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                    ElseIf input > 25 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                        Exit Sub
                    ElseIf input < 0 Or validInput1 = False Or input = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    input = mainform.getUserInput()
                    frevoidqty += input
                    input_valid = inputVoid(frevoidqty)
                End While

                If MsgBox("Item(s) will be void. Are you sure you want to remove it?", 1, "Confirmation message") = vbOK Then
                    If row.Cells(1).Value = "French Bread" Then
                        row.Cells(4).Value = row.Cells(4).Value - frevoidqty
                        row.Cells(5).Value = row.Cells(4).Value * 105
                        stocks = mainform.fregrid
                        mainform.fregrid = stocks - frevoidqty
                        stock = mainform.txtSFrench.Text
                        mainform.txtSFrench.Text = stock + frevoidqty
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
                        mainform.compute()

                        Exit Sub
                    End If
                Else

                    MsgBox("Cancelled")
                    Exit Sub
                End If
            End If

            If row.Cells(1).Value = "Wheat Bread" Then
                whevoidqty += input
                input_valid = inputVoid(whevoidqty)

                While input_valid = False Or input < 0 Or validInput1 = False Or input = 0 Or input = row.Cells(4).Value

                    whevoidqty -= input

                    If input = row.Cells(4).Value Then
                        MsgBox("If you'll remove all choose the void all. Try again!")
                        Exit Sub
                    ElseIf input > row.Cells(4).Value And input < 26 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                    ElseIf input > 25 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                        Exit Sub
                    ElseIf input < 0 Or validInput1 = False Or input = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    input = mainform.getUserInput()
                    whevoidqty += input
                    input_valid = inputVoid(whevoidqty)
                End While

                If MsgBox("Item(s) will be void. Are you sure you want to remove it?", 1, "Confirmation message") = vbOK Then
                    If row.Cells(1).Value = "Wheat Bread" Then
                        row.Cells(4).Value = row.Cells(4).Value - whevoidqty
                        row.Cells(5).Value = row.Cells(4).Value * 130
                        stocks = mainform.whegrid
                        mainform.whegrid = stocks - whevoidqty
                        stock = mainform.txtSWheat.Text
                        mainform.txtSWheat.Text = stock + whevoidqty
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
                        mainform.compute()

                        Exit Sub
                    End If
                Else

                    MsgBox("Cancelled")
                    Exit Sub
                End If
            End If

            If row.Cells(1).Value = "White Bread" Then
                whivoidqty += input
                input_valid = inputVoid(whivoidqty)

                While input_valid = False Or input < 0 Or validInput1 = False Or input = 0 Or input = row.Cells(4).Value

                    whivoidqty -= input

                    If input = row.Cells(4).Value Then
                        MsgBox("If you'll remove all choose the void all. Try again!")
                        Exit Sub
                    ElseIf input > row.Cells(4).Value And input < 26 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                    ElseIf input > 25 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                        Exit Sub
                    ElseIf input < 0 Or validInput1 = False Or input = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    input = mainform.getUserInput()
                    whivoidqty += input
                    input_valid = inputVoid(whivoidqty)
                End While

                If MsgBox("Item(s) will be void. Are you sure you want to remove it?", 1, "Confirmation message") = vbOK Then
                    If row.Cells(1).Value = "White Bread" Then
                        row.Cells(4).Value = row.Cells(4).Value - whivoidqty
                        row.Cells(5).Value = row.Cells(4).Value * 150
                        stocks = mainform.whigrid
                        mainform.whigrid = stocks - whivoidqty
                        stock = mainform.txtSWhite.Text
                        mainform.txtSWhite.Text = stock + whivoidqty
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
                        mainform.compute()

                        Exit Sub
                    End If
                Else

                    MsgBox("Cancelled")
                    Exit Sub
                End If
            End If

            If row.Cells(1).Value = "Banana Bread" Then
                banvoidqty += input
                input_valid = inputVoid(banvoidqty)

                While input_valid = False Or input < 0 Or validInput1 = False Or input = 0 Or input = row.Cells(4).Value

                    banvoidqty -= input

                    If input = row.Cells(4).Value Then
                        MsgBox("If you'll remove all choose the void all. Try again!")
                        Exit Sub
                    ElseIf input > row.Cells(4).Value And input < 26 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                    ElseIf input > 25 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                        Exit Sub
                    ElseIf input < 0 Or validInput1 = False Or input = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    input = mainform.getUserInput()
                    banvoidqty += input
                    input_valid = inputVoid(banvoidqty)
                End While

                If MsgBox("Item(s) will be void. Are you sure you want to remove it?", 1, "Confirmation message") = vbOK Then
                    If row.Cells(1).Value = "Banana Bread" Then
                        row.Cells(4).Value = row.Cells(4).Value - banvoidqty
                        row.Cells(5).Value = row.Cells(4).Value * 185
                        stocks = mainform.bangrid
                        mainform.bangrid = stocks - banvoidqty
                        stock = mainform.txtSBanana.Text
                        mainform.txtSBanana.Text = stock + banvoidqty
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
                        mainform.compute()

                        Exit Sub
                    End If
                Else

                    MsgBox("Cancelled")
                    Exit Sub
                End If
            End If

            If row.Cells(1).Value = "Hotdog Bun" Then
                hotvoidqty += input
                input_valid = inputVoid(hotvoidqty)

                While input_valid = False Or input < 0 Or validInput1 = False Or input = 0 Or input = row.Cells(4).Value

                    hotvoidqty -= input

                    If input = row.Cells(4).Value Then
                        MsgBox("If you'll remove all choose the void all. Try again!")
                        Exit Sub
                    ElseIf input > row.Cells(4).Value And input < 26 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                    ElseIf input > 25 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                        Exit Sub
                    ElseIf input < 0 Or validInput1 = False Or input = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    input = mainform.getUserInput()
                    hotvoidqty += input
                    input_valid = inputVoid(hotvoidqty)
                End While

                If MsgBox("Item(s) will be void. Are you sure you want to remove it?", 1, "Confirmation message") = vbOK Then
                    If row.Cells(1).Value = "Hotdog Bun" Then
                        row.Cells(4).Value = row.Cells(4).Value - hotvoidqty
                        row.Cells(5).Value = row.Cells(4).Value * 125
                        stocks = mainform.hotgrid
                        mainform.hotgrid = stocks - hotvoidqty
                        stock = mainform.txtSHotdog.Text
                        mainform.txtSHotdog.Text = stock + hotvoidqty
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
                        mainform.compute()

                        Exit Sub
                    End If
                Else

                    MsgBox("Cancelled")
                    Exit Sub
                End If
            End If

            If row.Cells(0).Value = "Reg-C0102" Then
                espvoidqty += input
                input_valid = inputVoid(espvoidqty)

                While input_valid = False Or input < 0 Or validInput1 = False Or input = 0 Or input = row.Cells(4).Value

                    espvoidqty -= input

                    If input = row.Cells(4).Value Then
                        MsgBox("If you'll remove all choose the void all. Try again!")
                        Exit Sub
                    ElseIf input > row.Cells(4).Value And input < 26 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                    ElseIf input > 25 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                        Exit Sub
                    ElseIf input < 0 Or validInput1 = False Or input = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    input = mainform.getUserInput()
                    espvoidqty += input
                    input_valid = inputVoid(espvoidqty)
                End While

                If MsgBox("Item(s) will be void. Are you sure you want to remove it?", 1, "Confirmation message") = vbOK Then
                    If row.Cells(0).Value = "Reg-C0102" Then
                        row.Cells(4).Value = row.Cells(4).Value - espvoidqty
                        row.Cells(5).Value = row.Cells(4).Value * row.Cells(2).Value
                        stocks = mainform.espgrid
                        mainform.espgrid = stocks - espvoidqty
                        stock = mainform.txtSREsp.Text
                        mainform.txtSREsp.Text = stock + espvoidqty

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
                        mainform.rbtnRegularEsp.Enabled = True
                        mainform.btnEspresso.Enabled = True
                        mainform.picEsp.Hide()
                        mainform.compute()

                        Exit Sub
                    End If
                Else

                    MsgBox("Cancelled")
                    Exit Sub
                End If
            End If

            If row.Cells(0).Value = "Med-C0102" Then
                mespvoidqty += input
                input_valid = inputVoid(mespvoidqty)

                While input_valid = False Or input < 0 Or validInput1 = False Or input = 0 Or input = row.Cells(4).Value

                    mespvoidqty -= input

                    If input = row.Cells(4).Value Then
                        MsgBox("If you'll remove all choose the void all. Try again!")
                        Exit Sub
                    ElseIf input > row.Cells(4).Value And input < 26 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                    ElseIf input > 25 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                        Exit Sub
                    ElseIf input < 0 Or validInput1 = False Or input = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    input = mainform.getUserInput()
                    mespvoidqty += input
                    input_valid = inputVoid(espvoidqty)
                End While

                If MsgBox("Item(s) will be void. Are you sure you want to remove it?", 1, "Confirmation message") = vbOK Then
                    If row.Cells(0).Value = "Med-C0102" Then
                        row.Cells(4).Value = row.Cells(4).Value - mespvoidqty
                        row.Cells(5).Value = row.Cells(4).Value * row.Cells(2).Value
                        stocks = mainform.mespgrid
                        mainform.mespgrid = stocks - mespvoidqty
                        stock = mainform.txtSMEsp.Text
                        mainform.txtSMEsp.Text = stock + mespvoidqty

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

                        mainform.rbtnMediumEsp.Enabled = True
                        mainform.btnEspresso.Enabled = True
                        mainform.picEsp.Hide()
                        mainform.compute()

                        Exit Sub
                    End If
                Else

                    MsgBox("Cancelled")
                    Exit Sub
                End If
            End If

            If row.Cells(0).Value = "Lar-C0102" Then
                lespvoidqty += input
                input_valid = inputVoid(lespvoidqty)

                While input_valid = False Or input < 0 Or validInput1 = False Or input = 0 Or input = row.Cells(4).Value

                    lespvoidqty -= input

                    If input = row.Cells(4).Value Then
                        MsgBox("If you'll remove all choose the void all. Try again!")
                        Exit Sub
                    ElseIf input > row.Cells(4).Value And input < 26 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                    ElseIf input > 25 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                        Exit Sub
                    ElseIf input < 0 Or validInput1 = False Or input = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    input = mainform.getUserInput()
                    lespvoidqty += input
                    input_valid = inputVoid(lespvoidqty)
                End While

                If MsgBox("Item(s) will be void. Are you sure you want to remove it?", 1, "Confirmation message") = vbOK Then
                    If row.Cells(0).Value = "Lar-C0102" Then
                        row.Cells(4).Value = row.Cells(4).Value - lespvoidqty
                        row.Cells(5).Value = row.Cells(4).Value * row.Cells(2).Value
                        stocks = mainform.lespgrid
                        mainform.lespgrid = stocks - lespvoidqty
                        stock = mainform.txtSLEsp.Text
                        mainform.txtSLEsp.Text = stock + lespvoidqty

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

                        mainform.rbtnLargeEsp.Enabled = True
                        mainform.btnEspresso.Enabled = True
                        mainform.picEsp.Hide()
                        mainform.compute()

                        Exit Sub
                    End If
                Else

                    MsgBox("Cancelled")
                    Exit Sub
                End If
            End If

            If row.Cells(0).Value = "Reg-C0103" Then
                dopvoidqty += input
                input_valid = inputVoid(dopvoidqty)

                While input_valid = False Or input < 0 Or validInput1 = False Or input = 0 Or input = row.Cells(4).Value

                    dopvoidqty -= input

                    If input = row.Cells(4).Value Then
                        MsgBox("If you'll remove all choose the void all. Try again!")
                        Exit Sub
                    ElseIf input > row.Cells(4).Value And input < 26 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                    ElseIf input > 25 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                        Exit Sub
                    ElseIf input < 0 Or validInput1 = False Or input = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    input = mainform.getUserInput()
                    dopvoidqty += input
                    input_valid = inputVoid(dopvoidqty)
                End While

                If MsgBox("Item(s) will be void. Are you sure you want to remove it?", 1, "Confirmation message") = vbOK Then
                    If row.Cells(0).Value = "Reg-C0103" Then
                        row.Cells(4).Value = row.Cells(4).Value - dopvoidqty
                        row.Cells(5).Value = row.Cells(4).Value * row.Cells(2).Value
                        stocks = mainform.dopgrid
                        mainform.dopgrid = stocks - dopvoidqty
                        stock = mainform.txtSRDop.Text
                        mainform.txtSRDop.Text = stock + dopvoidqty

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
                        mainform.rbtnRegularDop.Enabled = True
                        mainform.btnDoppio.Enabled = True
                        mainform.picDop.Hide()
                        mainform.compute()

                        Exit Sub
                    End If
                Else

                    MsgBox("Cancelled")
                    Exit Sub
                End If
            End If

            If row.Cells(0).Value = "Med-C0103" Then
                mdopvoidqty += input
                input_valid = inputVoid(mdopvoidqty)

                While input_valid = False Or input < 0 Or validInput1 = False Or input = 0 Or input = row.Cells(4).Value

                    mdopvoidqty -= input

                    If input = row.Cells(4).Value Then
                        MsgBox("If you'll remove all choose the void all. Try again!")
                        Exit Sub
                    ElseIf input > row.Cells(4).Value And input < 26 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                    ElseIf input > 25 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                        Exit Sub
                    ElseIf input < 0 Or validInput1 = False Or input = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    input = mainform.getUserInput()
                    mdopvoidqty += input
                    input_valid = inputVoid(mdopvoidqty)
                End While

                If MsgBox("Item(s) will be void. Are you sure you want to remove it?", 1, "Confirmation message") = vbOK Then
                    If row.Cells(0).Value = "Med-C0103" Then
                        row.Cells(4).Value = row.Cells(4).Value - mdopvoidqty
                        row.Cells(5).Value = row.Cells(4).Value * row.Cells(2).Value
                        stocks = mainform.mdopgrid
                        mainform.mdopgrid = stocks - mdopvoidqty
                        stock = mainform.txtSMDop.Text
                        mainform.txtSMDop.Text = stock + mdopvoidqty

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

                        mainform.rbtnMediumDop.Enabled = True
                        mainform.btnDoppio.Enabled = True
                        mainform.picDop.Hide()
                        mainform.compute()

                        Exit Sub
                    End If
                Else

                    MsgBox("Cancelled")
                    Exit Sub
                End If
            End If

            If row.Cells(0).Value = "Lar-C0103" Then
                ldopvoidqty += input
                input_valid = inputVoid(ldopvoidqty)

                While input_valid = False Or input < 0 Or validInput1 = False Or input = 0 Or input = row.Cells(4).Value

                    ldopvoidqty -= input

                    If input = row.Cells(4).Value Then
                        MsgBox("If you'll remove all choose the void all. Try again!")
                        Exit Sub
                    ElseIf input > row.Cells(4).Value And input < 26 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                    ElseIf input > 25 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                        Exit Sub
                    ElseIf input < 0 Or validInput1 = False Or input = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    input = mainform.getUserInput()
                    ldopvoidqty += input
                    input_valid = inputVoid(ldopvoidqty)
                End While

                If MsgBox("Item(s) will be void. Are you sure you want to remove it?", 1, "Confirmation message") = vbOK Then
                    If row.Cells(0).Value = "Lar-C0103" Then
                        row.Cells(4).Value = row.Cells(4).Value - ldopvoidqty
                        row.Cells(5).Value = row.Cells(4).Value * row.Cells(2).Value
                        stocks = mainform.ldopgrid
                        mainform.ldopgrid = stocks - ldopvoidqty
                        stock = mainform.txtSLDop.Text
                        mainform.txtSLDop.Text = stock + ldopvoidqty

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

                        mainform.rbtnLargeDop.Enabled = True
                        mainform.btnDoppio.Enabled = True
                        mainform.picDop.Hide()
                        mainform.compute()

                        Exit Sub
                    End If
                Else

                    MsgBox("Cancelled")
                    Exit Sub
                End If
            End If

            If row.Cells(0).Value = "Reg-C0104" Then
                amevoidqty += input
                input_valid = inputVoid(amevoidqty)

                While input_valid = False Or input < 0 Or validInput1 = False Or input = 0 Or input = row.Cells(4).Value

                    amevoidqty -= input

                    If input = row.Cells(4).Value Then
                        MsgBox("If you'll remove all choose the void all. Try again!")
                        Exit Sub
                    ElseIf input > row.Cells(4).Value And input < 26 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                    ElseIf input > 25 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                        Exit Sub
                    ElseIf input < 0 Or validInput1 = False Or input = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    input = mainform.getUserInput()
                    amevoidqty += input
                    input_valid = inputVoid(amevoidqty)
                End While

                If MsgBox("Item(s) will be void. Are you sure you want to remove it?", 1, "Confirmation message") = vbOK Then
                    If row.Cells(0).Value = "Reg-C0104" Then
                        row.Cells(4).Value = row.Cells(4).Value - amevoidqty
                        row.Cells(5).Value = row.Cells(4).Value * row.Cells(2).Value
                        stocks = mainform.amegrid
                        mainform.amegrid = stocks - amevoidqty
                        stock = mainform.txtSRAme.Text
                        mainform.txtSRAme.Text = stock + amevoidqty

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
                        mainform.rbtnRegularAme.Enabled = True
                        mainform.btnAmericano.Enabled = True
                        mainform.picAme.Hide()
                        mainform.compute()

                        Exit Sub
                    End If
                Else

                    MsgBox("Cancelled")
                    Exit Sub
                End If
            End If

            If row.Cells(0).Value = "Med-C0104" Then
                mamevoidqty += input
                input_valid = inputVoid(mamevoidqty)

                While input_valid = False Or input < 0 Or validInput1 = False Or input = 0 Or input = row.Cells(4).Value

                    mamevoidqty -= input

                    If input = row.Cells(4).Value Then
                        MsgBox("If you'll remove all choose the void all. Try again!")
                        Exit Sub
                    ElseIf input > row.Cells(4).Value And input < 26 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                    ElseIf input > 25 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                        Exit Sub
                    ElseIf input < 0 Or validInput1 = False Or input = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    input = mainform.getUserInput()
                    mamevoidqty += input
                    input_valid = inputVoid(mamevoidqty)
                End While

                If MsgBox("Item(s) will be void. Are you sure you want to remove it?", 1, "Confirmation message") = vbOK Then
                    If row.Cells(0).Value = "Med-C0104" Then
                        row.Cells(4).Value = row.Cells(4).Value - mamevoidqty
                        row.Cells(5).Value = row.Cells(4).Value * row.Cells(2).Value
                        stocks = mainform.mamegrid
                        mainform.mamegrid = stocks - mamevoidqty
                        stock = mainform.txtSMAme.Text
                        mainform.txtSMAme.Text = stock + mamevoidqty

                        If mainform.txtSMAme.Text > 5 And mainform.txtSMAme.Text <= 10 Then
                            mainform.txtSMAme.BackColor = Color.Yellow
                            mainform.txtSMAme.ForeColor = Color.Black

                        ElseIf mainform.txtSRAme.Text > 0 And mainform.txtSMAme.Text <= 5 Then
                            mainform.txtSMAme.BackColor = Color.Red
                            mainform.txtSMAme.ForeColor = Color.White
                        Else
                            mainform.txtSMAme.BackColor = SystemColors.Control
                            mainform.txtSMAme.ForeColor = Color.Black

                        End If

                        mainform.rbtnMediumAme.Enabled = True
                        mainform.btnAmericano.Enabled = True
                        mainform.picAme.Hide()
                        mainform.compute()

                        Exit Sub
                    End If
                Else

                    MsgBox("Cancelled")
                    Exit Sub
                End If
            End If

            If row.Cells(0).Value = "Lar-C0104" Then
                lamevoidqty += input
                input_valid = inputVoid(lamevoidqty)

                While input_valid = False Or input < 0 Or validInput1 = False Or input = 0 Or input = row.Cells(4).Value

                    lamevoidqty -= input

                    If input = row.Cells(4).Value Then
                        MsgBox("If you'll remove all choose the void all. Try again!")
                        Exit Sub
                    ElseIf input > row.Cells(4).Value And input < 26 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                    ElseIf input > 25 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                        Exit Sub
                    ElseIf input < 0 Or validInput1 = False Or input = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    input = mainform.getUserInput()
                    lamevoidqty += input
                    input_valid = inputVoid(lamevoidqty)
                End While

                If MsgBox("Item(s) will be void. Are you sure you want to remove it?", 1, "Confirmation message") = vbOK Then
                    If row.Cells(0).Value = "Lar-C0104" Then
                        row.Cells(4).Value = row.Cells(4).Value - lamevoidqty
                        row.Cells(5).Value = row.Cells(4).Value * row.Cells(2).Value
                        stocks = mainform.lamegrid
                        mainform.lamegrid = stocks - lamevoidqty
                        stock = mainform.txtSLAme.Text
                        mainform.txtSLAme.Text = stock + lamevoidqty

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

                        mainform.rbtnLargeAme.Enabled = True
                        mainform.btnAmericano.Enabled = True
                        mainform.picAme.Hide()
                        mainform.compute()

                        Exit Sub
                    End If
                Else

                    MsgBox("Cancelled")
                    Exit Sub
                End If
            End If

            If row.Cells(0).Value = "Reg-C0105" Then
                capvoidqty += input
                input_valid = inputVoid(capvoidqty)

                While input_valid = False Or input < 0 Or validInput1 = False Or input = 0 Or input = row.Cells(4).Value

                    capvoidqty -= input

                    If input = row.Cells(4).Value Then
                        MsgBox("If you'll remove all choose the void all. Try again!")
                        Exit Sub
                    ElseIf input > row.Cells(4).Value And input < 26 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                    ElseIf input > 25 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                        Exit Sub
                    ElseIf input < 0 Or validInput1 = False Or input = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    input = mainform.getUserInput()
                    capvoidqty += input
                    input_valid = inputVoid(capvoidqty)
                End While

                If MsgBox("Item(s) will be void. Are you sure you want to remove it?", 1, "Confirmation message") = vbOK Then
                    If row.Cells(0).Value = "Reg-C0105" Then
                        row.Cells(4).Value = row.Cells(4).Value - capvoidqty
                        row.Cells(5).Value = row.Cells(4).Value * row.Cells(2).Value
                        stocks = mainform.capgrid
                        mainform.capgrid = stocks - capvoidqty
                        stock = mainform.txtSRCap.Text
                        mainform.txtSRCap.Text = stock + capvoidqty

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
                        mainform.rbtnRegularCap.Enabled = True
                        mainform.btnCappuccino.Enabled = True
                        mainform.picCap.Hide()
                        mainform.compute()

                        Exit Sub
                    End If
                Else

                    MsgBox("Cancelled")
                    Exit Sub
                End If
            End If

            If row.Cells(0).Value = "Med-C0105" Then
                mcapvoidqty += input
                input_valid = inputVoid(mcapvoidqty)

                While input_valid = False Or input < 0 Or validInput1 = False Or input = 0 Or input = row.Cells(4).Value

                    mcapvoidqty -= input

                    If input = row.Cells(4).Value Then
                        MsgBox("If you'll remove all choose the void all. Try again!")
                        Exit Sub
                    ElseIf input > row.Cells(4).Value And input < 26 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                    ElseIf input > 25 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                        Exit Sub
                    ElseIf input < 0 Or validInput1 = False Or input = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    input = mainform.getUserInput()
                    mcapvoidqty += input
                    input_valid = inputVoid(mcapvoidqty)
                End While

                If MsgBox("Item(s) will be void. Are you sure you want to remove it?", 1, "Confirmation message") = vbOK Then
                    If row.Cells(0).Value = "Med-C0105" Then
                        row.Cells(4).Value = row.Cells(4).Value - mcapvoidqty
                        row.Cells(5).Value = row.Cells(4).Value * row.Cells(2).Value
                        stocks = mainform.mcapgrid
                        mainform.mcapgrid = stocks - mcapvoidqty
                        stock = mainform.txtSMCap.Text
                        mainform.txtSMCap.Text = stock + mcapvoidqty

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

                        mainform.rbtnMediumCap.Enabled = True
                        mainform.btnCappuccino.Enabled = True
                        mainform.picCap.Hide()
                        mainform.compute()

                        Exit Sub
                    End If
                Else

                    MsgBox("Cancelled")
                    Exit Sub
                End If
            End If

            If row.Cells(0).Value = "Lar-C0105" Then
                lcapvoidqty += input
                input_valid = inputVoid(lcapvoidqty)

                While input_valid = False Or input < 0 Or validInput1 = False Or input = 0 Or input = row.Cells(4).Value

                    lcapvoidqty -= input

                    If input = row.Cells(4).Value Then
                        MsgBox("If you'll remove all choose the void all. Try again!")
                        Exit Sub
                    ElseIf input > row.Cells(4).Value And input < 26 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                    ElseIf input > 25 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                        Exit Sub
                    ElseIf input < 0 Or validInput1 = False Or input = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    input = mainform.getUserInput()
                    lcapvoidqty += input
                    input_valid = inputVoid(lcapvoidqty)
                End While

                If MsgBox("Item(s) will be void. Are you sure you want to remove it?", 1, "Confirmation message") = vbOK Then
                    If row.Cells(0).Value = "Lar-C0105" Then
                        row.Cells(4).Value = row.Cells(4).Value - lcapvoidqty
                        row.Cells(5).Value = row.Cells(4).Value * row.Cells(2).Value
                        stocks = mainform.lcapgrid
                        mainform.lcapgrid = stocks - lcapvoidqty
                        stock = mainform.txtSLCap.Text
                        mainform.txtSLCap.Text = stock + lcapvoidqty

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

                        mainform.rbtnLargeCap.Enabled = True
                        mainform.btnCappuccino.Enabled = True
                        mainform.picCap.Hide()
                        mainform.compute()

                        Exit Sub
                    End If
                Else

                    MsgBox("Cancelled")
                    Exit Sub
                End If
            End If

            If row.Cells(0).Value = "Reg-C0106" Then
                latvoidqty += input
                input_valid = inputVoid(latvoidqty)

                While input_valid = False Or input < 0 Or validInput1 = False Or input = 0 Or input = row.Cells(4).Value

                    latvoidqty -= input

                    If input = row.Cells(4).Value Then
                        MsgBox("If you'll remove all choose the void all. Try again!")
                        Exit Sub
                    ElseIf input > row.Cells(4).Value And input < 26 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                    ElseIf input > 25 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                        Exit Sub
                    ElseIf input < 0 Or validInput1 = False Or input = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    input = mainform.getUserInput()
                    latvoidqty += input
                    input_valid = inputVoid(latvoidqty)
                End While

                If MsgBox("Item(s) will be void. Are you sure you want to remove it?", 1, "Confirmation message") = vbOK Then
                    If row.Cells(0).Value = "Reg-C0106" Then
                        row.Cells(4).Value = row.Cells(4).Value - latvoidqty
                        row.Cells(5).Value = row.Cells(4).Value * row.Cells(2).Value
                        stocks = mainform.latgrid
                        mainform.latgrid = stocks - latvoidqty
                        stock = mainform.txtSRLat.Text
                        mainform.txtSRLat.Text = stock + latvoidqty

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
                        mainform.rbtnRegularLat.Enabled = True
                        mainform.btnLatte.Enabled = True
                        mainform.picLat.Hide()
                        mainform.compute()

                        Exit Sub
                    End If
                Else

                    MsgBox("Cancelled")
                    Exit Sub
                End If
            End If

            If row.Cells(0).Value = "Med-C0106" Then
                mlatvoidqty += input
                input_valid = inputVoid(mlatvoidqty)

                While input_valid = False Or input < 0 Or validInput1 = False Or input = 0 Or input = row.Cells(4).Value

                    mlatvoidqty -= input

                    If input = row.Cells(4).Value Then
                        MsgBox("If you'll remove all choose the void all. Try again!")
                        Exit Sub
                    ElseIf input > row.Cells(4).Value And input < 26 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                    ElseIf input > 25 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                        Exit Sub
                    ElseIf input < 0 Or validInput1 = False Or input = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    input = mainform.getUserInput()
                    mlatvoidqty += input
                    input_valid = inputVoid(mlatvoidqty)
                End While

                If MsgBox("Item(s) will be void. Are you sure you want to remove it?", 1, "Confirmation message") = vbOK Then
                    If row.Cells(0).Value = "Med-C0106" Then
                        row.Cells(4).Value = row.Cells(4).Value - mlatvoidqty
                        row.Cells(5).Value = row.Cells(4).Value * row.Cells(2).Value
                        stocks = mainform.mlatgrid
                        mainform.mlatgrid = stocks - mlatvoidqty
                        stock = mainform.txtSMLat.Text
                        mainform.txtSMLat.Text = stock + mlatvoidqty

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

                        mainform.rbtnMediumLat.Enabled = True
                        mainform.btnLatte.Enabled = True
                        mainform.picLat.Hide()
                        mainform.compute()

                        Exit Sub
                    End If
                Else

                    MsgBox("Cancelled")
                    Exit Sub
                End If
            End If

            If row.Cells(0).Value = "Lar-C0106" Then
                llatvoidqty += input
                input_valid = inputVoid(llatvoidqty)

                While input_valid = False Or input < 0 Or validInput1 = False Or input = 0 Or input = row.Cells(4).Value

                    llatvoidqty -= input

                    If input = row.Cells(4).Value Then
                        MsgBox("If you'll remove all choose the void all. Try again!")
                        Exit Sub
                    ElseIf input > row.Cells(4).Value And input < 26 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                    ElseIf input > 25 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                        Exit Sub
                    ElseIf input < 0 Or validInput1 = False Or input = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    input = mainform.getUserInput()
                    llatvoidqty += input
                    input_valid = inputVoid(llatvoidqty)
                End While

                If MsgBox("Item(s) will be void. Are you sure you want to remove it?", 1, "Confirmation message") = vbOK Then
                    If row.Cells(0).Value = "Lar-C0106" Then
                        row.Cells(4).Value = row.Cells(4).Value - llatvoidqty
                        row.Cells(5).Value = row.Cells(4).Value * row.Cells(2).Value
                        stocks = mainform.llatgrid
                        mainform.llatgrid = stocks - llatvoidqty
                        stock = mainform.txtSLLat.Text
                        mainform.txtSLLat.Text = stock + llatvoidqty
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

                        mainform.rbtnLargeLat.Enabled = True
                        mainform.btnLatte.Enabled = True
                        mainform.picLat.Hide()
                        mainform.compute()

                        Exit Sub
                    End If
                Else

                    MsgBox("Cancelled")
                    Exit Sub
                End If
            End If

            If row.Cells(0).Value = "Reg-C0107" Then
                macvoidqty += input
                input_valid = inputVoid(macvoidqty)

                While input_valid = False Or input < 0 Or validInput1 = False Or input = 0 Or input = row.Cells(4).Value

                    macvoidqty -= input

                    If input = row.Cells(4).Value Then
                        MsgBox("If you'll remove all choose the void all. Try again!")
                        Exit Sub
                    ElseIf input > row.Cells(4).Value And input < 26 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                    ElseIf input > 25 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                        Exit Sub
                    ElseIf input < 0 Or validInput1 = False Or input = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    input = mainform.getUserInput()
                    macvoidqty += input
                    input_valid = inputVoid(macvoidqty)
                End While

                If MsgBox("Item(s) will be void. Are you sure you want to remove it?", 1, "Confirmation message") = vbOK Then
                    If row.Cells(0).Value = "Reg-C0107" Then
                        row.Cells(4).Value = row.Cells(4).Value - macvoidqty
                        row.Cells(5).Value = row.Cells(4).Value * row.Cells(2).Value
                        stocks = mainform.macgrid
                        mainform.macgrid = stocks - macvoidqty
                        stock = mainform.txtSRMac.Text
                        mainform.txtSRMac.Text = stock + macvoidqty

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
                        mainform.rbtnRegularMac.Enabled = True
                        mainform.btnMacchiato.Enabled = True
                        mainform.picMac.Hide()
                        mainform.compute()

                        Exit Sub
                    End If
                Else

                    MsgBox("Cancelled")
                    Exit Sub
                End If
            End If

            If row.Cells(0).Value = "Med-C0107" Then
                mmacvoidqty += input
                input_valid = inputVoid(mmacvoidqty)

                While input_valid = False Or input < 0 Or validInput1 = False Or input = 0 Or input = row.Cells(4).Value

                    mmacvoidqty -= input

                    If input = row.Cells(4).Value Then
                        MsgBox("If you'll remove all choose the void all. Try again!")
                        Exit Sub
                    ElseIf input > row.Cells(4).Value And input < 26 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                    ElseIf input > 25 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                        Exit Sub
                    ElseIf input < 0 Or validInput1 = False Or input = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    input = mainform.getUserInput()
                    mmacvoidqty += input
                    input_valid = inputVoid(mmacvoidqty)
                End While

                If MsgBox("Item(s) will be void. Are you sure you want to remove it?", 1, "Confirmation message") = vbOK Then
                    If row.Cells(0).Value = "Med-C0107" Then
                        row.Cells(4).Value = row.Cells(4).Value - mmacvoidqty
                        row.Cells(5).Value = row.Cells(4).Value * row.Cells(2).Value
                        stocks = mainform.mmacgrid
                        mainform.mmacgrid = stocks - mmacvoidqty
                        stock = mainform.txtSMMac.Text
                        mainform.txtSMMac.Text = stock + mmacvoidqty

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

                        mainform.rbtnMediumMac.Enabled = True
                        mainform.btnMacchiato.Enabled = True
                        mainform.picMac.Hide()
                        mainform.compute()

                        Exit Sub
                    End If
                Else

                    MsgBox("Cancelled")
                    Exit Sub
                End If
            End If

            If row.Cells(0).Value = "Lar-C0107" Then
                lmacvoidqty += input
                input_valid = inputVoid(lmacvoidqty)

                While input_valid = False Or input < 0 Or validInput1 = False Or input = 0 Or input = row.Cells(4).Value

                    lmacvoidqty -= input

                    If input = row.Cells(4).Value Then
                        MsgBox("If you'll remove all choose the void all. Try again!")
                        Exit Sub
                    ElseIf input > row.Cells(4).Value And input < 26 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                    ElseIf input > 25 Then
                        MsgBox("Your input is greater than the quantity. Try again!")
                        Exit Sub
                    ElseIf input < 0 Or validInput1 = False Or input = 0 Then
                        MsgBox("Cannot be processed!", vbCritical, "Invalid Input")
                        Exit Sub
                    Else
                        MsgBox("Try again!")
                    End If

                    input = mainform.getUserInput()
                    lmacvoidqty += input
                    input_valid = inputVoid(lmacvoidqty)
                End While

                If MsgBox("Item(s) will be void. Are you sure you want to remove it?", 1, "Confirmation message") = vbOK Then
                    If row.Cells(0).Value = "Lar-C0107" Then
                        row.Cells(4).Value = row.Cells(4).Value - lmacvoidqty
                        row.Cells(5).Value = row.Cells(4).Value * row.Cells(2).Value
                        stocks = mainform.lmacgrid
                        mainform.lmacgrid = stocks - lmacvoidqty
                        stock = mainform.txtSLMac.Text
                        mainform.txtSLMac.Text = stock + lmacvoidqty

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

                        mainform.rbtnLargeMac.Enabled = True
                        mainform.btnMacchiato.Enabled = True
                        mainform.picMac.Hide()
                        mainform.compute()

                        Exit Sub
                    End If
                Else

                    MsgBox("Cancelled")
                    Exit Sub
                End If
            End If
        Next

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
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