Public Class frmPayment

    Dim newpoint As New System.Drawing.Point

    Dim x, y As Integer

    Private Sub frmPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtCash.Select()
        txtTotal.Text = mainform.txtPAmount.Text

    End Sub

    Private Sub txtCash_TextChanged(sender As Object, e As EventArgs) Handles txtCash.TextChanged

        If txtCash.Text = "" Then
            txtChange.Text = "0.00"
        Else
            txtChange.Text= Format(Val(txtCash.Text) - Val(txtTotal.Text), "###,###0.00")
        End If

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim Rows As DataGridViewRowCollection = mainform.dtSummary.Rows


        'set Standard Width and Height
        Dim UnitWidth As Integer = 22
        Dim UnitHeight As Integer = 22

        Dim LeftMargin As Integer = 0
        Dim topMargin As Integer = 0


        ' Set the height of Bill Details part
        Dim ReciptDetailsHeight = Rows.Count * UnitHeight




        ' Standard Font
        Dim font As New Font("Consolas", 8)
        Dim fontB As New Font("Consolas", 10, FontStyle.Bold)

        Dim Fontbold As New Font("Consolas", 10, FontStyle.Bold)
        Dim FontboldHeader As New Font("Consolas", 16, FontStyle.Bold)


        'separate things for experiecne
        Dim TRecwidth As Integer = 283
        Dim Str As New StringFormat
        Str.Alignment = StringAlignment.Center
        Dim strLeft As New StringFormat
        strLeft.Alignment = StringAlignment.Near
        Dim strRight As New StringFormat
        strRight.Alignment = StringAlignment.Far

        'draw basic lines
        Dim YBillStart As Integer = 4 * UnitHeight

        'draw the headers
        Dim YHeaderStrat As Integer = YBillStart + (3 * UnitHeight)
        Dim YDetailsStart As Integer = YHeaderStrat + UnitHeight



        'Draw top rect
        Dim Rect As New Rectangle(LeftMargin + 0, topMargin + 0, TRecwidth, UnitHeight * 1 + 10)
        e.Graphics.DrawRectangle(Pens.White, Rect)
        Dim Rect1 As New Rectangle(LeftMargin + 0, topMargin + UnitHeight * 2, TRecwidth, UnitHeight)
        e.Graphics.DrawRectangle(Pens.White, Rect1)
        Dim Rect2 As New Rectangle(LeftMargin + 0, topMargin + UnitHeight * 3, TRecwidth, UnitHeight * 3)
        e.Graphics.DrawRectangle(Pens.White, Rect2)
        Dim Rect4 As New Rectangle(LeftMargin + 0, topMargin + UnitHeight * 5, TRecwidth, UnitHeight)
        Dim Rect5 As New Rectangle(LeftMargin + 0, topMargin + UnitHeight * 6.5, TRecwidth, UnitHeight)
        Dim Rect6 As New Rectangle(LeftMargin + 0, topMargin + UnitHeight * 7.5, TRecwidth, UnitHeight)

        Dim DtValue As String = Format(Now.Date, "MM/dd/yyyy")
        Dim TmValue As String = Format(Now, "  hh:mm:ss tt")

        'Write Recipt No. & Recipt Date & Company Name
        e.Graphics.DrawString("English Brunch", FontboldHeader, Brushes.Black, Rect, Str)
        e.Graphics.DrawString("Pasig, Metro Manila", Fontbold, Brushes.Black, Rect1, Str)
        e.Graphics.DrawString("09921210054", Fontbold, Brushes.Black, Rect2, Str)
        e.Graphics.DrawString(Space(3) & "Date Transaction: " & DtValue & TmValue, font, Brushes.Black, Rect4, strLeft)
        e.Graphics.DrawString("--------------------------------------------", font, Brushes.Black, Rect5, strLeft)
        e.Graphics.DrawString("--------------------------------------------", font, Brushes.Black, Rect6, strLeft)


        'Draw Black Line
        Dim Rect01 As New Rectangle(LeftMargin + UnitWidth * 0, topMargin + YHeaderStrat, UnitWidth * 2, UnitHeight)
        Dim Rect02 As New Rectangle(LeftMargin + UnitWidth * 3, topMargin + YHeaderStrat, UnitWidth * 6, UnitHeight)
        Dim Rect03 As New Rectangle(LeftMargin + UnitWidth * 7, topMargin + YHeaderStrat, UnitWidth * 2, UnitHeight)
        Dim Rect04 As New Rectangle(LeftMargin + UnitWidth * 9, topMargin + YHeaderStrat, UnitWidth * 2, UnitHeight)
        Dim Rect041 As New Rectangle(LeftMargin + UnitWidth * 11, topMargin + YHeaderStrat, UnitWidth * 3, UnitHeight)




        'Fill Headers with Texts

        e.Graphics.DrawString("ID", font, Brushes.Black, Rect01, Str)
        e.Graphics.DrawString("ITEM NAME", font, Brushes.Black, Rect02, strLeft)
        e.Graphics.DrawString("PRICE", font, Brushes.Black, Rect03, Str)
        e.Graphics.DrawString("QTY", font, Brushes.Black, Rect04, Str)
        e.Graphics.DrawString("TOTAL", font, Brushes.Black, Rect041, Str)

        'final part is to render the text into the image
        Dim I As Integer
        For I = 0 To Rows.Count - 1
            'find the Y
            Dim Yloc = UnitHeight * I + YDetailsStart


            Dim Rect1g As New Rectangle(LeftMargin + UnitWidth * 0, topMargin + Yloc, UnitWidth * 2, UnitHeight)
            Dim Rect2g As New Rectangle(LeftMargin + UnitWidth * 3, topMargin + Yloc, UnitWidth * 6, UnitHeight)
            Dim Rect3g As New Rectangle(LeftMargin + UnitWidth * 7, topMargin + Yloc, UnitWidth * 2, UnitHeight)
            Dim Rect4g As New Rectangle(LeftMargin + UnitWidth * 9, topMargin + Yloc, UnitWidth * 2, UnitHeight)
            Dim Rect5g As New Rectangle(LeftMargin + UnitWidth * 11, topMargin + Yloc, UnitWidth * 3, UnitHeight)



            'Serial Number
            e.Graphics.DrawString(Rows(I).Cells(0).Value, font, Brushes.Black, Rect1g, Str)
            'Item Name
            e.Graphics.DrawString(Rows(I).Cells(1).Value, font, Brushes.Black, Rect2g, strLeft)
            'Price
            e.Graphics.DrawString(Rows(I).Cells(2).Value, font, Brushes.Black, Rect3g, Str)
            'Qty
            e.Graphics.DrawString(Rows(I).Cells(4).Value, font, Brushes.Black, Rect4g, Str)
            'Sum
            e.Graphics.DrawString(Rows(I).Cells(5).Value, font, Brushes.Black, Rect5g, Str)

        Next


        'Render Total Items
        Dim Rect2x As New Rectangle(LeftMargin + 0, topMargin + ReciptDetailsHeight + YBillStart + 1 + (UnitHeight * 4), TRecwidth, UnitHeight)
        Dim Rect3x As New Rectangle(LeftMargin + 0, topMargin + ReciptDetailsHeight + YBillStart + 1 + (UnitHeight * 5), TRecwidth, UnitHeight)
        Dim Rect4x As New Rectangle(LeftMargin + 0, topMargin + ReciptDetailsHeight + YBillStart + 1 + (UnitHeight * 6), TRecwidth, UnitHeight)
        Dim Rect5x As New Rectangle(LeftMargin + 0, topMargin + ReciptDetailsHeight + YBillStart + 1 + (UnitHeight * 7), TRecwidth, UnitHeight)
        Dim Rec6x As New Rectangle(LeftMargin + 0, topMargin + ReciptDetailsHeight + YBillStart + 1 + (UnitHeight * 8), TRecwidth, UnitHeight)
        Dim Rec7x As New Rectangle(LeftMargin + 0, topMargin + ReciptDetailsHeight + YBillStart + 1 + (UnitHeight * 9), TRecwidth, UnitHeight)
        Dim Rec8x As New Rectangle(LeftMargin + 0, topMargin + ReciptDetailsHeight + YBillStart + 1 + (UnitHeight * 10), TRecwidth, UnitHeight)
        Dim Rec9x As New Rectangle(LeftMargin + 0, topMargin + ReciptDetailsHeight + YBillStart + 1 + (UnitHeight * 11), TRecwidth, UnitHeight)
        Dim Rect10x As New Rectangle(LeftMargin + 0, topMargin + ReciptDetailsHeight + YBillStart + 1 + (UnitHeight * 12), TRecwidth, UnitHeight)
        Dim Rec11x As New Rectangle(LeftMargin + 0, topMargin + ReciptDetailsHeight + YBillStart + 1 + (UnitHeight * 13), TRecwidth, UnitHeight)
        Dim Rec12x As New Rectangle(LeftMargin + 0, topMargin + ReciptDetailsHeight + YBillStart + 1 + (UnitHeight * 14), TRecwidth, UnitHeight)

        e.Graphics.DrawString("--------------------------------------------", font, Brushes.Black, Rect2x, strLeft)
        e.Graphics.DrawString("VAT(12%):  " & Space(20) & mainform.txtVAT.Text, font, Brushes.Black, Rect3x, strLeft)
        e.Graphics.DrawString("Discount:  " & Space(25) & mainform.txtDiscount.Text, font, Brushes.Black, Rect4x, strLeft)
        e.Graphics.DrawString("Sub Total: " & Space(25) & mainform.txtSTotal.Text, font, Brushes.Black, Rect5x, strLeft)
        e.Graphics.DrawString("Total:     " & Space(25) & mainform.txtPAmount.Text, font, Brushes.Black, Rec6x, strLeft)
        e.Graphics.DrawString("Cash:      " & Space(25) & txtCash.Text, font, Brushes.Black, Rec7x, strLeft)
        e.Graphics.DrawString(Space(22) & "----------------------", font, Brushes.Black, Rec8x, strLeft)
        e.Graphics.DrawString("Change:    " & Space(26) & txtChange.Text, font, Brushes.Black, Rec9x, strLeft)
        e.Graphics.DrawString("--------------------------------------------", font, Brushes.Black, Rect10x, strLeft)
        e.Graphics.DrawString("Name of Customer:  " & mainform.txtCName.Text, font, Brushes.Black, Rec11x, strLeft)
        e.Graphics.DrawString("--------THANK YOU! ENJOY YOUR MEAL!--------", font, Brushes.Black, Rec12x, strLeft)
    End Sub

    Public Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click

        Dim lsmoz, lsbac, lschi, lsmus As Integer
        Dim mlsmoz, mlsbac, mlschi, mlsmus As Integer
        Dim llsmoz, llsbac, llschi, llsmus As Integer
        Dim lsveg, lsver, lsrol, lsfre As Integer
        Dim mlsveg, mlsver As Integer
        Dim llsveg, llsver As Integer
        Dim lswhe, lswhi, lsban, lshot As Integer
        Dim lsesp, lsdop, lsame, lscap As Integer
        Dim mlsesp, mlsdop, mlsame, mlscap As Integer
        Dim llsesp, llsdop, llscap As Integer
        Dim llsame, lslat, lsmac As Integer
        Dim mlslat, mlsmac As Integer
        Dim llslat, llsmac As Integer
        Dim mozgr, bacgr, chigr, musgr, veggr, vergr As Integer
        Dim mmozgr, mbacgr, mchigr, mmusgr, mveggr, mvergr As Integer
        Dim lmozgr, lbacgr, lchigr, lmusgr, lveggr, lvergr As Integer
        Dim rolgr, fregr, whegr, whigr, bangr, hotgr As Integer
        Dim espgr, dopgr, amegr, capgr, latgr, macgr As Integer
        Dim mespgr, mdopgr, mamegr, mcapgr, mlatgr, mmacgr As Integer
        Dim lespgr, ldopgr, lamegr, lcapgr, llatgr, lmacgr As Integer

        If txtCash.Text = "" Then
            MsgBox("Please input the amount", vbCritical, "Invalid Transaction")
            txtCash.Focus()

        ElseIf Val(txtChange.Text) < 0 Then
            MsgBox("Cannot be processed!", vbCritical, "Invalid Transaction")
            txtCash.Clear()
            txtCash.Focus()
        Else
            If mainform.dtSummary.Rows.Count = 0 Then
                Exit Sub
            End If


            PrintPreviewDialog1.WindowState = FormWindowState.Normal
            PrintPreviewDialog1.StartPosition = FormStartPosition.CenterScreen
            PrintPreviewDialog1.PrintPreviewControl.Zoom = 1.3
            PrintPreviewDialog1.Document = PrintDocument1
            PrintPreviewDialog1.ShowDialog()
            historyy()
            Me.Close()
            mainform.btnHome_Click(Nothing, Nothing)


            For Each row As DataGridViewRow In mainform.dtSummary.Rows

                If mainform.dtSummary.Rows.Count > 0 Then
                    For i As Integer = mainform.dtSummary.Rows.Count - 1 To 0 Step -1
                        mainform.dtSummary.Rows.RemoveAt(mainform.dtSummary.Rows(i).Index)

                    Next
                End If


                If row.Cells(0).Value = "Reg-P0102" Or row.Cells(0).Value = "Med-P0102" Or row.Cells(0).Value = "Lar-P0102" Or
                    row.Cells(0).Value = "Reg-P0103" Or row.Cells(0).Value = "Med-P0103" Or row.Cells(0).Value = "Lar-P0103" Or
                    row.Cells(0).Value = "Reg-P0104" Or row.Cells(0).Value = "Med-P0104" Or row.Cells(0).Value = "Lar-P0104" Or
                    row.Cells(0).Value = "Reg-P0105" Or row.Cells(0).Value = "Med-P0105" Or row.Cells(0).Value = "Lar-P0105" Or
                    row.Cells(0).Value = "Reg-P0106" Or row.Cells(0).Value = "Med-P0106" Or row.Cells(0).Value = "Lar-P0106" Or
                    row.Cells(0).Value = "Reg-P0107" Or row.Cells(0).Value = "Med-P0107" Or row.Cells(0).Value = "Lar-P0107" Or
                    row.Cells(1).Value = "Rolls" Or row.Cells(1).Value = "French Bread" Or row.Cells(1).Value = "Wheat Bread" Or
                    row.Cells(1).Value = "White Bread" Or row.Cells(1).Value = "Banana Bread" Or row.Cells(1).Value = "Hotdog Bun" Or
                    row.Cells(0).Value = "Reg-C0102" Or row.Cells(0).Value = "Med-C0102" Or row.Cells(0).Value = "Lar-C0102" Or
                    row.Cells(0).Value = "Reg-C0103" Or row.Cells(0).Value = "Med-C0103" Or row.Cells(0).Value = "Lar-C0103" Or
                    row.Cells(0).Value = "Reg-C0104" Or row.Cells(0).Value = "Med-C0104" Or row.Cells(0).Value = "Lar-C0104" Or
                    row.Cells(0).Value = "Reg-C0105" Or row.Cells(0).Value = "Med-C0105" Or row.Cells(0).Value = "Lar-C0105" Or
                    row.Cells(0).Value = "Reg-C0106" Or row.Cells(0).Value = "Med-C0106" Or row.Cells(0).Value = "Lar-C0106" Or
                    row.Cells(0).Value = "Reg-C0107" Or row.Cells(0).Value = "Med-C0107" Or row.Cells(0).Value = "Lar-C0107" Then


                    mozgr = mainform.mozgrid
                    lsmoz = mainform.mozstock
                    mainform.mozstock = lsmoz - mozgr

                    mmozgr = mainform.mmozgrid
                    mlsmoz = mainform.mozmstock
                    mainform.mozmstock = mlsmoz - mmozgr

                    lmozgr = mainform.lmozgrid
                    llsmoz = mainform.mozlstock
                    mainform.mozlstock = llsmoz - lmozgr

                    bacgr = mainform.bacgrid
                    lsbac = mainform.bacstock
                    mainform.bacstock = lsbac - bacgr

                    mbacgr = mainform.mbacgrid
                    mlsbac = mainform.mbacstock
                    mainform.mbacstock = mlsbac - mbacgr

                    lbacgr = mainform.lbacgrid
                    llsbac = mainform.lbacstock
                    mainform.lbacstock = llsbac - lbacgr

                    chigr = mainform.chigrid
                    lschi = mainform.chistock
                    mainform.chistock = lschi - chigr

                    mchigr = mainform.mchigrid
                    mlschi = mainform.mchistock
                    mainform.mchistock = mlschi - mchigr

                    lchigr = mainform.lchigrid
                    llschi = mainform.lchistock
                    mainform.lchistock = llschi - lchigr

                    musgr = mainform.musgrid
                    lsmus = mainform.musstock
                    mainform.musstock = lsmus - musgr

                    mmusgr = mainform.mmusgrid
                    mlsmus = mainform.mmusstock
                    mainform.mmusstock = mlsmus - mmusgr

                    lmusgr = mainform.lmusgrid
                    llsmus = mainform.lmusstock
                    mainform.lmusstock = llsmus - lmusgr

                    veggr = mainform.veggrid
                    lsveg = mainform.vegstock
                    mainform.vegstock = lsveg - veggr

                    mveggr = mainform.mveggrid
                    mlsveg = mainform.mvegstock
                    mainform.mvegstock = mlsveg - mveggr

                    lveggr = mainform.lveggrid
                    llsveg = mainform.lvegstock
                    mainform.lvegstock = llsveg - lveggr

                    vergr = mainform.vergrid
                    lsver = mainform.verstock
                    mainform.verstock = lsver - vergr

                    mvergr = mainform.mvergrid
                    mlsver = mainform.mverstock
                    mainform.mverstock = mlsver - mvergr

                    lvergr = mainform.lvergrid
                    llsver = mainform.lverstock
                    mainform.lverstock = llsver - lvergr

                    rolgr = mainform.rolgrid
                    lsrol = mainform.rolstock
                    mainform.rolstock = lsrol - rolgr

                    fregr = mainform.fregrid
                    lsfre = mainform.frestock
                    mainform.frestock = lsfre - fregr

                    whegr = mainform.whegrid
                    lswhe = mainform.whestock
                    mainform.whestock = lswhe - whegr

                    whigr = mainform.whigrid
                    lswhi = mainform.whistock
                    mainform.whistock = lswhi - whigr

                    bangr = mainform.bangrid
                    lsban = mainform.banstock
                    mainform.banstock = lsban - bangr

                    hotgr = mainform.hotgrid
                    lshot = mainform.hotstock
                    mainform.hotstock = lshot - hotgr

                    espgr = mainform.espgrid
                    lsesp = mainform.espstock
                    mainform.espstock = lsesp - espgr

                    mespgr = mainform.mespgrid
                    mlsesp = mainform.mespstock
                    mainform.mespstock = mlsesp - mespgr

                    lespgr = mainform.lespgrid
                    llsesp = mainform.lespstock
                    mainform.lespstock = llsesp - lespgr

                    dopgr = mainform.dopgrid
                    lsdop = mainform.dopstock
                    mainform.dopstock = lsdop - dopgr

                    mdopgr = mainform.mdopgrid
                    mlsdop = mainform.mdopstock
                    mainform.mdopstock = mlsdop - mdopgr

                    ldopgr = mainform.ldopgrid
                    llsdop = mainform.ldopstock
                    mainform.ldopstock = llsdop - ldopgr

                    amegr = mainform.amegrid
                    lsame = mainform.amestock
                    mainform.amestock = lsame - amegr

                    mamegr = mainform.mamegrid
                    mlsame = mainform.mamestock
                    mainform.mamestock = mlsame - mamegr

                    lamegr = mainform.lamegrid
                    llsame = mainform.lamestock
                    mainform.lamestock = llsame - lamegr

                    capgr = mainform.capgrid
                    lscap = mainform.capstock
                    mainform.capstock = lscap - capgr

                    mcapgr = mainform.mcapgrid
                    mlscap = mainform.mcapstock
                    mainform.mcapstock = mlscap - mcapgr

                    lcapgr = mainform.lcapgrid
                    llscap = mainform.lcapstock
                    mainform.lcapstock = llscap - lcapgr

                    latgr = mainform.latgrid
                    lslat = mainform.latstock
                    mainform.latstock = lslat - latgr

                    mlatgr = mainform.mlatgrid
                    mlslat = mainform.mlatstock
                    mainform.mlatstock = mlslat - mlatgr

                    llatgr = mainform.llatgrid
                    llslat = mainform.llatstock
                    mainform.llatstock = llslat - llatgr

                    macgr = mainform.macgrid
                    lsmac = mainform.macstock
                    mainform.macstock = lsmac - macgr

                    mmacgr = mainform.mmacgrid
                    mlsmac = mainform.mmacstock
                    mainform.mmacstock = mlsmac - mmacgr

                    lmacgr = mainform.lmacgrid
                    llsmac = mainform.lmacstock
                    mainform.lmacstock = llsmac - lmacgr

                    mainform.txtVAT.Text = "0.00"
                    mainform.txtDiscount.Text = "0.00"
                    mainform.txtSTotal.Text = "0.00"
                    mainform.txtPAmount.Text = "0.00"
                    mainform.txtCName.Clear()
                    mainform.txtCName.Focus()
                    mainform.rbtnPWD.Checked = False
                    mainform.rbtnSenior.Checked = False
                    mainform.rbtnRegular.Checked = False
                    Exit Sub
                End If


            Next
        End If
    End Sub

    Public Sub historyy()



        Dim items1 As ListViewItem

        items1 = History.lstHistory.Items.Add(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"))

        Dim prods As String
        For i As Integer = 0 To mainform.dtSummary.Rows.Count - 1
            prods += mainform.dtSummary.Rows(i).Cells(0).Value.ToString & "," & vbLf
        Next


        Dim totalQ As Integer = 0
        For index As Integer = 0 To mainform.dtSummary.RowCount - 1
            totalQ += Val(mainform.dtSummary.Rows(index).Cells(4).Value)
        Next

        items1.SubItems.Add(mainform.custype & "-" & mainform.txtCName.Text)
        items1.SubItems.Add(prods)
        items1.SubItems.Add(totalQ)
        items1.SubItems.Add(txtTotal.Text)


    End Sub

    Private Sub txtCash_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCash.KeyPress

        If Char.IsControl(e.KeyChar) Then
        ElseIf Char.IsDigit(e.KeyChar) OrElse e.KeyChar = "."c Then


            If txtCash.TextLength = 7 And txtCash.Text.Contains(".") = False Then
                txtCash.AppendText(".")
            ElseIf e.KeyChar = "." And txtCash.Text.IndexOf(".") <> -1 Then
                e.Handled = True
            ElseIf Char.IsDigit(e.KeyChar) Then
                If txtCash.Text.IndexOf(".") <> -1 Then
                    If txtCash.Text.Length >= txtCash.Text.IndexOf(".") + 3 Then
                        e.Handled = True
                    End If
                End If
            End If

        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim Closing As DialogResult
        Closing = MessageBox.Show("Do you really want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If Closing = DialogResult.No Then
            Me.Show()
        Else
            Me.Close()
            txtCash.Clear()
            txtCash.Focus()
        End If
    End Sub

    Private Sub txtCash_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCash.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnPay_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If

        e.SuppressKeyPress = True
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