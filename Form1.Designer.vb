<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lvBlockchain = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lvSelectedBlock = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.C1Owner = New System.Windows.Forms.TextBox()
        Me.C2Owner = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ctId = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ctToken = New System.Windows.Forms.TextBox()
        Me.ctReceiver = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ctSender = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lvTransactions = New System.Windows.Forms.ListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnNext = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.body = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.header = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvBlockchain
        '
        Me.lvBlockchain.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvBlockchain.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader7, Me.ColumnHeader12})
        Me.lvBlockchain.FullRowSelect = True
        Me.lvBlockchain.HideSelection = False
        Me.lvBlockchain.Location = New System.Drawing.Point(29, 241)
        Me.lvBlockchain.Name = "lvBlockchain"
        Me.lvBlockchain.Size = New System.Drawing.Size(813, 149)
        Me.lvBlockchain.TabIndex = 0
        Me.lvBlockchain.UseCompatibleStateImageBehavior = False
        Me.lvBlockchain.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Block"
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Header (hash)"
        Me.ColumnHeader7.Width = 229
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Body (json)"
        Me.ColumnHeader12.Width = 647
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 222)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Blockchain:"
        '
        'lvSelectedBlock
        '
        Me.lvSelectedBlock.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11})
        Me.lvSelectedBlock.HideSelection = False
        Me.lvSelectedBlock.Location = New System.Drawing.Point(14, 35)
        Me.lvSelectedBlock.Name = "lvSelectedBlock"
        Me.lvSelectedBlock.Size = New System.Drawing.Size(394, 246)
        Me.lvSelectedBlock.TabIndex = 2
        Me.lvSelectedBlock.UseCompatibleStateImageBehavior = False
        Me.lvSelectedBlock.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Block"
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Transaction_ID"
        Me.ColumnHeader8.Width = 106
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Sender"
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Receiver"
        Me.ColumnHeader10.Width = 80
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "Token"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "C1"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Owner:"
        '
        'C1Owner
        '
        Me.C1Owner.Location = New System.Drawing.Point(91, 39)
        Me.C1Owner.Name = "C1Owner"
        Me.C1Owner.ReadOnly = True
        Me.C1Owner.Size = New System.Drawing.Size(119, 22)
        Me.C1Owner.TabIndex = 7
        '
        'C2Owner
        '
        Me.C2Owner.Location = New System.Drawing.Point(91, 75)
        Me.C2Owner.Name = "C2Owner"
        Me.C2Owner.ReadOnly = True
        Me.C2Owner.Size = New System.Drawing.Size(119, 22)
        Me.C2Owner.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(37, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Owner:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 16)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "C2"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.C2Owner)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.C1Owner)
        Me.GroupBox1.Location = New System.Drawing.Point(28, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(223, 115)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ativos/Tokens:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.ctId)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.ctToken)
        Me.GroupBox2.Controls.Add(Me.ctReceiver)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.ctSender)
        Me.GroupBox2.Location = New System.Drawing.Point(257, 23)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(229, 163)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Transação atual:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(14, 39)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(23, 16)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "ID:"
        '
        'ctId
        '
        Me.ctId.Location = New System.Drawing.Point(91, 36)
        Me.ctId.Name = "ctId"
        Me.ctId.ReadOnly = True
        Me.ctId.Size = New System.Drawing.Size(119, 22)
        Me.ctId.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Token:"
        '
        'ctToken
        '
        Me.ctToken.Location = New System.Drawing.Point(91, 65)
        Me.ctToken.Name = "ctToken"
        Me.ctToken.ReadOnly = True
        Me.ctToken.Size = New System.Drawing.Size(119, 22)
        Me.ctToken.TabIndex = 12
        '
        'ctReceiver
        '
        Me.ctReceiver.Location = New System.Drawing.Point(91, 123)
        Me.ctReceiver.Name = "ctReceiver"
        Me.ctReceiver.ReadOnly = True
        Me.ctReceiver.Size = New System.Drawing.Size(119, 22)
        Me.ctReceiver.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 127)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 16)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Receiver:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(14, 97)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 16)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Sender:"
        '
        'ctSender
        '
        Me.ctSender.Location = New System.Drawing.Point(91, 94)
        Me.ctSender.Name = "ctSender"
        Me.ctSender.ReadOnly = True
        Me.ctSender.Size = New System.Drawing.Size(119, 22)
        Me.ctSender.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(495, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 16)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Fila de transações:"
        '
        'lvTransactions
        '
        Me.lvTransactions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvTransactions.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lvTransactions.FullRowSelect = True
        Me.lvTransactions.HideSelection = False
        Me.lvTransactions.Location = New System.Drawing.Point(492, 42)
        Me.lvTransactions.Name = "lvTransactions"
        Me.lvTransactions.Size = New System.Drawing.Size(350, 186)
        Me.lvTransactions.TabIndex = 15
        Me.lvTransactions.UseCompatibleStateImageBehavior = False
        Me.lvTransactions.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ID"
        Me.ColumnHeader3.Width = 51
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Sender"
        Me.ColumnHeader4.Width = 69
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Receiver"
        Me.ColumnHeader5.Width = 81
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Token"
        Me.ColumnHeader6.Width = 61
        '
        'btnNext
        '
        Me.btnNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(690, 735)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(142, 36)
        Me.btnNext.TabIndex = 17
        Me.btnNext.Text = "Next step"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.body)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.header)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.lvSelectedBlock)
        Me.GroupBox4.Location = New System.Drawing.Point(15, 413)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(839, 300)
        Me.GroupBox4.TabIndex = 19
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Bloco selecionado:"
        '
        'body
        '
        Me.body.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.body.Location = New System.Drawing.Point(490, 71)
        Me.body.Multiline = True
        Me.body.Name = "body"
        Me.body.ReadOnly = True
        Me.body.Size = New System.Drawing.Size(327, 210)
        Me.body.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(429, 71)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 16)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Body:"
        '
        'header
        '
        Me.header.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.header.Location = New System.Drawing.Point(490, 32)
        Me.header.Name = "header"
        Me.header.ReadOnly = True
        Me.header.Size = New System.Drawing.Size(327, 22)
        Me.header.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(428, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Header:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(879, 783)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lvTransactions)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lvBlockchain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Simulação básica de uma Blockchain"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvBlockchain As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents lvSelectedBlock As ListView
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents C1Owner As TextBox
    Friend WithEvents C2Owner As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ctToken As TextBox
    Friend WithEvents ctReceiver As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents ctSender As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lvTransactions As ListView
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents btnNext As Button
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents Label11 As Label
    Friend WithEvents ctId As TextBox
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents header As TextBox
    Friend WithEvents body As TextBox
    Friend WithEvents Label12 As Label
End Class
