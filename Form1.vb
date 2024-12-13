
Imports PdfSharp.Pdf
Imports PdfSharp.Drawing

Public Class Form1
    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Try

            ' Dapatkan input dari TextBox
            Dim itemName As String = txtItemName.Text
            Dim quantity As Integer = Integer.Parse(txtQuantity.Text)
            Dim price As Decimal = Decimal.Parse(txtPrice.Text)
            Dim total As Decimal = quantity * price

            ' Tambahkan baris ke DataGridView
            dgvItems.Rows.Add(itemName, quantity, String.Format(AppConstants.CurrencyFormat, price), String.Format(AppConstants.CurrencyFormat, total))

            ' Reset input
            txtItemName.Clear()
            txtQuantity.Clear()
            txtPrice.Clear()

            ' Hitung total keseluruhan
            CalculateTotal()

        Catch ex As Exception
            MessageBox.Show("Input tidak valid. Pastikan Anda memasukkan angka yang benar.")
        End Try

    End Sub
    Public Class AppConstants
        Public Const CurrencyFormat As String = "Rp {0:N}"

    End Class

    Private Sub CalculateTotal()
        ' Variabel untuk menampung total keseluruhan
        Dim grandTotal As Decimal = 0

        ' Loop melalui setiap baris di DataGridView dan jumlahkan total
        For Each row As DataGridViewRow In dgvItems.Rows
            If Not row.IsNewRow Then
                Dim totalString As String = row.Cells(3).Value.ToString()
                ' Ambil nilai total dari kolom ke-4 (index 3)
                'grandTotal += Convert.ToDecimal(row.Cells(3).Value)
                Dim totalDecimal As Decimal = Decimal.Parse(totalString.Replace("Rp. ", ""), Globalization.NumberStyles.Currency, New Globalization.CultureInfo("id-ID"))
                grandTotal += totalDecimal
            End If
        Next

        ' Tampilkan grandTotal di Label atau TextBox
        lblGrandTotal.Text = "Grand Total : " & grandTotal.ToString("C")
    End Sub

    Private Sub btnGeneratePDF_Click(sender As Object, e As EventArgs) Handles btnGeneratePDF.Click
        Try
            ' Buat dokumen PDF baru
            Dim pdfDoc As New PdfDocument()
            pdfDoc.Info.Title = "Digital Invoice"

            ' Tambahkan halaman ke dokumen PDF
            Dim pdfPage As PdfPage = pdfDoc.AddPage()
            Dim gfx As XGraphics = XGraphics.FromPdfPage(pdfPage)
            Dim fontTitle As New XFont("Arial", 16)
            Dim fontNormal As New XFont("Arial", 12)
            Dim fontSmall As New XFont("Arial", 10)

            ' Header - Digital Invoice
            gfx.DrawString("Digital Invoice", fontTitle, XBrushes.Black, New XRect(0, 20, pdfPage.Width, 40), XStringFormats.TopCenter)

            ' Nomor dan Nama Pelanggan
            Dim startY As Integer = 60
            gfx.DrawString($"Nomor : {txtNomor.Text}", fontNormal, XBrushes.Black, 20, startY)
            gfx.DrawString($"Nama Pelanggan : {txtNama.Text}", fontNormal, XBrushes.Black, 20, startY + 20)

            ' DataGridView Header
            startY += 60
            gfx.DrawString("Item Name", fontSmall, XBrushes.Black, 20, startY)
            gfx.DrawString("Quantity", fontSmall, XBrushes.Black, 150, startY)
            gfx.DrawString("Price", fontSmall, XBrushes.Black, 250, startY)
            gfx.DrawString("Total", fontSmall, XBrushes.Black, 350, startY)

            ' DataGridView Rows
            startY += 20
            For Each row As DataGridViewRow In dgvItems.Rows
                If Not row.IsNewRow Then
                    gfx.DrawString(row.Cells("ItemName").Value.ToString(), fontSmall, XBrushes.Black, 20, startY)
                    gfx.DrawString(row.Cells("Quantity").Value.ToString(), fontSmall, XBrushes.Black, 150, startY)
                    gfx.DrawString(row.Cells("Price").Value.ToString(), fontSmall, XBrushes.Black, 250, startY)
                    gfx.DrawString(row.Cells("Total").Value.ToString(), fontSmall, XBrushes.Black, 350, startY)
                    startY += 20
                End If
            Next

            ' Grand Total
            startY += 20
            gfx.DrawString($"{lblGrandTotal.Text}", fontNormal, XBrushes.Black, 20, startY)

            ' Save PDF File
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "PDF Files|*.pdf"
            saveFileDialog.Title = "Save PDF File"
            saveFileDialog.FileName = "Nota .pdf"
            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                pdfDoc.Save(saveFileDialog.FileName)
                MessageBox.Show("PDF generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show($"Error generating PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        Dim confirmDialog As New frmConfirmDialog()
        If confirmDialog.ShowDialog() = DialogResult.OK Then
            dgvItems.Rows.Clear()
            txtNomor.Clear()
            txtNama.Clear()
            dgvItems.Rows.Clear()
            lblGrandTotal.Clear()
        End If

    End Sub

    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        ' Memastikan hanya angka dan titik desimal yang bisa dimasukkan
        If Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' Mengabaikan input selain angka dan titik
        End If

    End Sub

    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        ' Memastikan hanya angka dan titik desimal yang bisa dimasukkan
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ChrW(8) AndAlso e.KeyChar <> "." Then
            e.Handled = True ' Mengabaikan input selain angka dan titik
        End If

        ' Memastikan hanya satu titik desimal yang dapat dimasukkan
        If e.KeyChar = "." AndAlso txtPrice.Text.Contains(".") Then
            e.Handled = True ' Mengabaikan input titik kedua
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = ""
    End Sub
End Class
