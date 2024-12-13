<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        txtNomor = New TextBox()
        dgvItems = New DataGridView()
        itemName = New DataGridViewTextBoxColumn()
        quantity = New DataGridViewTextBoxColumn()
        price = New DataGridViewTextBoxColumn()
        total = New DataGridViewTextBoxColumn()
        btnAddItem = New Button()
        btnGeneratePDF = New Button()
        btnReset = New Button()
        txtNama = New TextBox()
        ContextMenuStrip1 = New ContextMenuStrip(components)
        Label2 = New Label()
        Label3 = New Label()
        txtItemName = New TextBox()
        txtQuantity = New TextBox()
        txtPrice = New TextBox()
        lblGrandTotal = New TextBox()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        GroupBox1 = New GroupBox()
        PictureBox1 = New PictureBox()
        CType(dgvItems, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(167, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(162, 21)
        Label1.TabIndex = 0
        Label1.Text = "Pemrograman Visual"
        ' 
        ' txtNomor
        ' 
        txtNomor.Location = New Point(284, 24)
        txtNomor.Name = "txtNomor"
        txtNomor.Size = New Size(172, 23)
        txtNomor.TabIndex = 1
        ' 
        ' dgvItems
        ' 
        dgvItems.AllowUserToAddRows = False
        dgvItems.BackgroundColor = SystemColors.ButtonHighlight
        dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvItems.Columns.AddRange(New DataGridViewColumn() {itemName, quantity, price, total})
        dgvItems.Location = New Point(15, 225)
        dgvItems.Name = "dgvItems"
        dgvItems.ReadOnly = True
        dgvItems.Size = New Size(441, 205)
        dgvItems.TabIndex = 2
        ' 
        ' itemName
        ' 
        itemName.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        itemName.HeaderText = "Item Name"
        itemName.Name = "itemName"
        itemName.ReadOnly = True
        ' 
        ' quantity
        ' 
        quantity.HeaderText = "Quantity"
        quantity.Name = "quantity"
        quantity.ReadOnly = True
        ' 
        ' price
        ' 
        price.HeaderText = "Price"
        price.Name = "price"
        price.ReadOnly = True
        ' 
        ' total
        ' 
        total.HeaderText = "Total"
        total.Name = "total"
        total.ReadOnly = True
        ' 
        ' btnAddItem
        ' 
        btnAddItem.BackColor = Color.Silver
        btnAddItem.Location = New Point(284, 179)
        btnAddItem.Name = "btnAddItem"
        btnAddItem.Size = New Size(172, 23)
        btnAddItem.TabIndex = 3
        btnAddItem.Text = "Add Item"
        btnAddItem.UseVisualStyleBackColor = False
        ' 
        ' btnGeneratePDF
        ' 
        btnGeneratePDF.BackColor = Color.Silver
        btnGeneratePDF.Location = New Point(15, 439)
        btnGeneratePDF.Name = "btnGeneratePDF"
        btnGeneratePDF.Size = New Size(90, 23)
        btnGeneratePDF.TabIndex = 4
        btnGeneratePDF.Text = "Generate PDF"
        btnGeneratePDF.UseVisualStyleBackColor = False
        ' 
        ' btnReset
        ' 
        btnReset.BackColor = Color.Silver
        btnReset.Location = New Point(112, 439)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(90, 23)
        btnReset.TabIndex = 5
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = False
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(284, 53)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(172, 23)
        txtNama.TabIndex = 6
        ' 
        ' ContextMenuStrip1
        ' 
        ContextMenuStrip1.Name = "ContextMenuStrip1"
        ContextMenuStrip1.Size = New Size(61, 4)
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(230, 28)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 7
        Label2.Text = "Nomor :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(177, 57)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 15)
        Label3.TabIndex = 8
        Label3.Text = "Nama Pelanggan :"
        ' 
        ' txtItemName
        ' 
        txtItemName.Location = New Point(284, 92)
        txtItemName.Name = "txtItemName"
        txtItemName.Size = New Size(172, 23)
        txtItemName.TabIndex = 9
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(284, 121)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(172, 23)
        txtQuantity.TabIndex = 10
        txtQuantity.TextAlign = HorizontalAlignment.Right
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(284, 150)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(172, 23)
        txtPrice.TabIndex = 11
        txtPrice.TextAlign = HorizontalAlignment.Right
        ' 
        ' lblGrandTotal
        ' 
        lblGrandTotal.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        lblGrandTotal.Location = New Point(208, 439)
        lblGrandTotal.Name = "lblGrandTotal"
        lblGrandTotal.Size = New Size(248, 23)
        lblGrandTotal.TabIndex = 12
        lblGrandTotal.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(209, 95)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 15)
        Label4.TabIndex = 13
        Label4.Text = "Item Name :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(222, 124)
        Label5.Name = "Label5"
        Label5.Size = New Size(59, 15)
        Label5.TabIndex = 14
        Label5.Text = "Quantity :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(242, 153)
        Label6.Name = "Label6"
        Label6.Size = New Size(39, 15)
        Label6.TabIndex = 15
        Label6.Text = "Price :"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Controls.Add(btnReset)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(btnGeneratePDF)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(lblGrandTotal)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(dgvItems)
        GroupBox1.Controls.Add(txtPrice)
        GroupBox1.Controls.Add(txtNomor)
        GroupBox1.Controls.Add(txtQuantity)
        GroupBox1.Controls.Add(btnAddItem)
        GroupBox1.Controls.Add(txtItemName)
        GroupBox1.Controls.Add(txtNama)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(12, 30)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(472, 484)
        GroupBox1.TabIndex = 16
        GroupBox1.TabStop = False
        GroupBox1.Text = "Digital Invoice"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(6, 24)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(165, 178)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 16
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        ClientSize = New Size(494, 526)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        CType(dgvItems, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNomor As TextBox
    Friend WithEvents dgvItems As DataGridView
    Friend WithEvents btnAddItem As Button
    Friend WithEvents btnGeneratePDF As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents txtNama As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lblGrandTotal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents itemName As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox

End Class
