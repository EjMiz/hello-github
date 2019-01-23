<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.pnlTop = New System.Windows.Forms.Panel()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.cmbLineTerminate = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbCharType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numY = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.numX = New System.Windows.Forms.NumericUpDown()
        Me.lbl = New System.Windows.Forms.Label()
        Me.pnlBody = New System.Windows.Forms.Panel()
        Me.chkTopMost = New System.Windows.Forms.CheckBox()
        Me.txtResult = New System.Windows.Forms.TextBox()
        Me.cmbNames = New System.Windows.Forms.ComboBox()
        Me.pnlTop.SuspendLayout()
        CType(Me.numY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlBody.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.Controls.Add(Me.cmbNames)
        Me.pnlTop.Controls.Add(Me.btnCopy)
        Me.pnlTop.Controls.Add(Me.cmbLineTerminate)
        Me.pnlTop.Controls.Add(Me.Label4)
        Me.pnlTop.Controls.Add(Me.cmbCharType)
        Me.pnlTop.Controls.Add(Me.Label3)
        Me.pnlTop.Controls.Add(Me.Label2)
        Me.pnlTop.Controls.Add(Me.numY)
        Me.pnlTop.Controls.Add(Me.Label1)
        Me.pnlTop.Controls.Add(Me.numX)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(720, 40)
        Me.pnlTop.TabIndex = 0
        '
        'btnCopy
        '
        Me.btnCopy.ForeColor = System.Drawing.Color.Blue
        Me.btnCopy.Location = New System.Drawing.Point(204, 8)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(75, 23)
        Me.btnCopy.TabIndex = 2
        Me.btnCopy.Text = "コピー"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'cmbLineTerminate
        '
        Me.cmbLineTerminate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.DummyText.My.MySettings.Default, "UseLineEnd", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbLineTerminate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLineTerminate.FormattingEnabled = True
        Me.cmbLineTerminate.Items.AddRange(New Object() {"末", "ん", "あ", "か", "〆"})
        Me.cmbLineTerminate.Location = New System.Drawing.Point(665, 10)
        Me.cmbLineTerminate.Name = "cmbLineTerminate"
        Me.cmbLineTerminate.Size = New System.Drawing.Size(39, 20)
        Me.cmbLineTerminate.TabIndex = 9
        Me.cmbLineTerminate.Text = Global.DummyText.My.MySettings.Default.UseLineEnd
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(629, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 12)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "行末："
        '
        'cmbCharType
        '
        Me.cmbCharType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.DummyText.My.MySettings.Default, "UseCharType", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbCharType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCharType.FormattingEnabled = True
        Me.cmbCharType.Items.AddRange(New Object() {"漢字", "ひらがな", "カタカナ", "空白", "アンダースコア（＿）", "プラス（＋）", "マイナス（－）", "中黒（・）", "×"})
        Me.cmbCharType.Location = New System.Drawing.Point(505, 10)
        Me.cmbCharType.Name = "cmbCharType"
        Me.cmbCharType.Size = New System.Drawing.Size(113, 20)
        Me.cmbCharType.TabIndex = 7
        Me.cmbCharType.Text = Global.DummyText.My.MySettings.Default.UseCharType
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 12)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "名称："
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(480, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 12)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "行"
        '
        'numY
        '
        Me.numY.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DummyText.My.MySettings.Default, "Lines", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.numY.Location = New System.Drawing.Point(416, 11)
        Me.numY.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.numY.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numY.Name = "numY"
        Me.numY.Size = New System.Drawing.Size(58, 19)
        Me.numY.TabIndex = 5
        Me.numY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numY.Value = Global.DummyText.My.MySettings.Default.Lines
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(361, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 12)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "文字　×"
        '
        'numX
        '
        Me.numX.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.DummyText.My.MySettings.Default, "Chars", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.numX.Location = New System.Drawing.Point(297, 11)
        Me.numX.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.numX.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numX.Name = "numX"
        Me.numX.Size = New System.Drawing.Size(58, 19)
        Me.numX.TabIndex = 3
        Me.numX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numX.Value = Global.DummyText.My.MySettings.Default.Chars
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lbl.Location = New System.Drawing.Point(0, 170)
        Me.lbl.Name = "lbl"
        Me.lbl.Padding = New System.Windows.Forms.Padding(5)
        Me.lbl.Size = New System.Drawing.Size(59, 22)
        Me.lbl.TabIndex = 2
        Me.lbl.Text = "welcome"
        '
        'pnlBody
        '
        Me.pnlBody.AutoScroll = True
        Me.pnlBody.Controls.Add(Me.chkTopMost)
        Me.pnlBody.Controls.Add(Me.txtResult)
        Me.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlBody.Location = New System.Drawing.Point(0, 40)
        Me.pnlBody.Name = "pnlBody"
        Me.pnlBody.Size = New System.Drawing.Size(720, 130)
        Me.pnlBody.TabIndex = 3
        '
        'chkTopMost
        '
        Me.chkTopMost.AutoSize = True
        Me.chkTopMost.Checked = Global.DummyText.My.MySettings.Default.WindowTopMost
        Me.chkTopMost.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.DummyText.My.MySettings.Default, "WindowTopMost", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.chkTopMost.Location = New System.Drawing.Point(12, 104)
        Me.chkTopMost.Name = "chkTopMost"
        Me.chkTopMost.Size = New System.Drawing.Size(102, 16)
        Me.chkTopMost.TabIndex = 1
        Me.chkTopMost.Text = "常に手前に表示"
        Me.chkTopMost.UseVisualStyleBackColor = True
        '
        'txtResult
        '
        Me.txtResult.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.txtResult.Location = New System.Drawing.Point(0, 0)
        Me.txtResult.Multiline = True
        Me.txtResult.Name = "txtResult"
        Me.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtResult.Size = New System.Drawing.Size(233, 98)
        Me.txtResult.TabIndex = 0
        Me.txtResult.Text = "あいうえおかきくけこ"
        '
        'cmbNames
        '
        Me.cmbNames.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.DummyText.My.MySettings.Default, "TextName", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbNames.FormattingEnabled = True
        Me.cmbNames.Items.AddRange(New Object() {"対象", "手段", "意図"})
        Me.cmbNames.Location = New System.Drawing.Point(43, 10)
        Me.cmbNames.Name = "cmbNames"
        Me.cmbNames.Size = New System.Drawing.Size(141, 20)
        Me.cmbNames.TabIndex = 10
        Me.cmbNames.Text = Global.DummyText.My.MySettings.Default.TextName
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(720, 192)
        Me.Controls.Add(Me.pnlBody)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.pnlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DummyText"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlTop.PerformLayout()
        CType(Me.numY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlBody.ResumeLayout(False)
        Me.pnlBody.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlTop As Panel
    Friend WithEvents cmbLineTerminate As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbCharType As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents numY As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents numX As NumericUpDown
    Friend WithEvents btnCopy As Button
    Friend WithEvents lbl As Label
    Friend WithEvents pnlBody As Panel
    Friend WithEvents chkTopMost As CheckBox
    Friend WithEvents txtResult As TextBox
    Friend WithEvents cmbNames As ComboBox
End Class
