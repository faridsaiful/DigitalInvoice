<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfirmDialog
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
        OK = New Button()
        cancel = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' OK
        ' 
        OK.Location = New Point(12, 27)
        OK.Name = "OK"
        OK.Size = New Size(75, 23)
        OK.TabIndex = 2
        OK.Text = "OK"
        OK.UseVisualStyleBackColor = True
        ' 
        ' cancel
        ' 
        cancel.Location = New Point(93, 27)
        cancel.Name = "cancel"
        cancel.Size = New Size(75, 23)
        cancel.TabIndex = 3
        cancel.Text = "Cancel"
        cancel.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(34, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(110, 15)
        Label1.TabIndex = 4
        Label1.Text = "Apakah anda yakin "
        ' 
        ' frmConfirmDialog
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(182, 65)
        Controls.Add(Label1)
        Controls.Add(cancel)
        Controls.Add(OK)
        Name = "frmConfirmDialog"
        StartPosition = FormStartPosition.CenterScreen
        Text = "frmConfirmDialog"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents OK As Button
    Friend WithEvents cancel As Button
    Friend WithEvents Label1 As Label

    Private Sub OK_Click(sender As Object, e As EventArgs) Handles OK.Click
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles cancel.Click
        ' Tambahkan kode tambahan jika diperlukan (misalnya, log aktivitas)
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmConfirmDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = ""
    End Sub
End Class
