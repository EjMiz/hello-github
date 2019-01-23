Imports System.Text

Public Class frmMain

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        'cmbCharType.SelectedIndex = 0
        'cmbLineTerminate.SelectedIndex = 0
        MakeText()
    End Sub

    Private Sub numX_ValueChanged(sender As Object, e As EventArgs) Handles numX.ValueChanged, numY.ValueChanged
        MakeText()
    End Sub

    Private Sub cmbCharType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCharType.SelectedIndexChanged, cmbLineTerminate.SelectedIndexChanged
        MakeText()
    End Sub

    Sub MakeText()
        If cmbCharType.SelectedIndex < 0 Then Return
        If cmbLineTerminate.SelectedIndex < 0 Then Return

        Dim sb As New StringBuilder
        Dim w As Integer = CInt(numX.Value)
        Dim h As Integer = CInt(numY.Value)
        Dim name As String = cmbNames.Text
        If w <= 0 OrElse h <= 0 Then Return

        name &= String.Format("({0}x{1})", w, h)
        name = StrConv(name, VbStrConv.Wide)

        Dim charArray As Char() = Nothing
        Select Case cmbCharType.Text
            Case "漢字"
                charArray = "一二三四五六七八九十".ToCharArray
            Case "ひらがな"
                charArray = "あいうえおかきくけこ".ToCharArray
            Case "カタカナ"
                charArray = "アイウエオカキクケコ".ToCharArray
            Case "空白"
                charArray = "　".ToCharArray
            Case "アンダースコア（＿）"
                charArray = "＿".ToCharArray
            Case "プラス（＋）"
                charArray = "＋".ToCharArray
            Case "マイナス（－）"
                charArray = "－".ToCharArray
            Case "中黒（・）"
                charArray = "・".ToCharArray
            Case "×"
                charArray = "×".ToCharArray
            Case Else
                charArray = "　".ToCharArray
        End Select

        Dim lineEnd As String = cmbLineTerminate.Text

        For y As Integer = 0 To h - 1
            For x As Integer = 0 To w - 1
                If x = w - 1 Then
                    sb.Append(lineEnd) '行末
                Else
                    If y = 0 Then
                        If x < name.Length Then
                            sb.Append(name.Substring(x, 1)) '先頭行の名前部分
                        Else
                            sb.Append(ConvNum((x + 1) Mod 10))　'先頭行の列番号
                        End If
                    ElseIf y Mod 10 = 0 Then
                        '十行ごとの列番号
                        sb.Append(ConvNum((x + 1) Mod 10))
                    ElseIf x = 0 Then
                        '一列目の行番号
                        sb.Append(ConvNum((y + 1) Mod 10))
                    Else
                        sb.Append(charArray(x Mod charArray.Length))
                    End If
                End If

            Next
        Next

        AdjustSize(w, h)
        txtResult.Text = sb.ToString

        lbl.Text = String.Format("{0}文字 x {1}行 = 全{2}字", w, h, w * h)

    End Sub

    Sub AdjustSize(w As Integer, h As Integer)
        With txtResult
            Dim ww As Integer = 12 * w
            Dim border As Integer = 1 * 2
            Dim padding As Integer = 5 * 2
            .Width = ww + border + padding + SystemInformation.VerticalScrollBarWidth
        End With
    End Sub

    Private Function ConvNum(ByVal n As Integer) As String
        Dim s As String = ""
        If cmbCharType.Text = "漢字" Then
            Select Case n
                Case 0 : s = "零"
                Case 1 : s = "一"
                Case 2 : s = "二"
                Case 3 : s = "三"
                Case 4 : s = "四"
                Case 5 : s = "五"
                Case 6 : s = "六"
                Case 7 : s = "七"
                Case 8 : s = "八"
                Case 9 : s = "九"
            End Select
        Else
            s = StrConv(n.ToString, VbStrConv.Wide)
        End If
        Return s
    End Function

    Private Sub btnCopy_Click(sender As Object, e As EventArgs) Handles btnCopy.Click
        Try
            My.Computer.Clipboard.SetText(txtResult.Text)
            lbl.Text &= "   コピーしました。"
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub chkTopMost_CheckedChanged(sender As Object, e As EventArgs) Handles chkTopMost.CheckedChanged
        Me.TopMost = chkTopMost.Checked
    End Sub

    Private Sub pnlTop_Paint(sender As Object, e As PaintEventArgs) Handles pnlTop.Paint

    End Sub

    Private Sub cmbNames_TextChanged(sender As Object, e As EventArgs) Handles cmbNames.TextChanged
        MakeText()
    End Sub
End Class
