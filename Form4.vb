Public Class GuidancePlan2

    Private Sub CheckTime(timectl As TextBox)
        'MsgBox関数に使う変数を宣言。
        Dim msg As String
        Dim title As String
        Dim style1 As MsgBoxStyle
        Dim style2 As MsgBoxStyle
        Dim res As MsgBoxResult

        'TryParse関数で変換後の値を格納する場所を宣言。
        Dim dt As DateTime

        'MsgBox関数に使う変数に値を代入。
        msg = "時刻が正しく入力されていません。" + vbCrLf + "正しい時刻を入力してください。" + vbCrLf + vbCrLf +
            "例：　9:00　16:00　23:00　など。"
        title = String.Empty
        style1 = MsgBoxStyle.ApplicationModal Or MsgBoxStyle.Critical
        style2 = MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.ApplicationModal

        'Timeの内容が空白である場合、
        If timectl.Text = String.Empty Then
            'Watermarkを最前面に設定。
            Me.TimeWater.BringToFront()
            'Timeの値にコロンが含まれていない場合、
        ElseIf System.Text.RegularExpressions.Regex.IsMatch(timectl.Text, ":") = False Then
            MsgBox(msg, style1, title)
            timectl.Text = String.Empty
            timectl.Focus()
            'TryParse関数でTimeの変換を行い、変換が失敗した場合、
        ElseIf DateTime.TryParse(timectl.Text, dt) = False Then
            Dim time() As String = Split(timectl.Text, ":")
            Dim hour As Integer
            Dim min As Integer

            'ISNumeric関数でTimeに入力された時間の部分が数値であると判断された場合、
            If IsNumeric(time(0)) Then
                'Parse関数でInteger型に変換して格納。
                hour = Integer.Parse(time(0))
            End If

            If IsNumeric(time(1)) Then
                min = Integer.Parse(time(1))
            End If

            If (DateTime.TryParse(timectl.Text, dt) = False) And (hour >= 24) Then
                res = MsgBox("時刻が " + timectl.Text + " になっていますが、正しいですか？", style2, title)
                If res = MsgBoxResult.No Then
                    timectl.Text = String.Empty
                    timectl.Focus()
                Else
                    If min < 0 Or min >= 60 Then
                        MsgBox(msg, style1, title)
                        timectl.Text = String.Empty
                        timectl.Focus()
                    End If
                End If
            Else
                MsgBox(msg, style1, title)
                timectl.Text = String.Empty
                timectl.Focus()
            End If
        End If
    End Sub

    Private Sub TextMen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextMen.KeyPress
        '�����ꂽ�L�[���u0�`9�łȂ��ꍇ�v���uBackSpace�łȂ��ꍇ�v�C�x���g���L�����Z������
        If (e.KeyChar < "0"c Or e.KeyChar > "9"c) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
        TextMen.MaxLength = 2

    End Sub

    Private Sub TextWomen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextWomen.KeyPress
        '�����ꂽ�L�[���u0�`9�łȂ��ꍇ�v���uBackSpace�łȂ��ꍇ�v�C�x���g���L�����Z������
        If (e.KeyChar < "0"c Or e.KeyChar > "9"c) And e.KeyChar <> vbBack Then
            e.Handled = True
        End If
        TextWomen.MaxLength = 2
    End Sub

    Private Sub TextMen_TextChanged(sender As Object, e As EventArgs) Handles TextMen.TextChanged
        Dim men As String = TextMen.Text
        Dim women As String = TextWomen.Text
        If men <> "" And women <> "" Then
            LabelSum.Text = Integer.Parse(TextMen.Text) + Integer.Parse(TextWomen.Text)
        End If
    End Sub

    Private Sub TextWomen_TextChanged(sender As Object, e As EventArgs) Handles TextWomen.TextChanged
        Dim men As String = TextMen.Text
        Dim women As String = TextWomen.Text
        If men <> "" And women <> "" Then
            LabelSum.Text = Integer.Parse(TextMen.Text) + Integer.Parse(TextWomen.Text)
        End If
    End Sub

    Private Sub TextMen_Enter(sender As Object, e As EventArgs) Handles TextMen.Enter
        If TextMen.Text = "0" Then
            TextMen.Clear()
        End If
    End Sub

    Private Sub TextMen_Leave(sender As Object, e As EventArgs) Handles TextMen.Leave
        If TextMen.Text = "" Then
            TextMen.Text = "0"
        End If
    End Sub

    Private Sub TextWomen_Enter(sender As Object, e As EventArgs) Handles TextWomen.Enter
        If TextWomen.Text = "0" Then
            TextWomen.Clear()
        End If
    End Sub

    Private Sub TextWomen_Leave(sender As Object, e As EventArgs) Handles TextWomen.Leave
        If TextWomen.Text = "" Then
            TextWomen.Text = "0"
        End If
    End Sub

    'Watermarkにフォーカスした場合、
    Private Sub Watermark1_GotFocus(sender As Object, e As EventArgs) Handles Watermark1.GotFocus
        'Watermarkを最背面に設定。
        Me.Watermark1.SendToBack()
        'Concernにフォーカス。
        Me.Concern1.Focus()
    End Sub

    'Concernからフォーカスが外れて、
    Private Sub Concern1_LostFocus(sender As Object, e As EventArgs) Handles Concern1.LostFocus
        'Concernの内容が空白である場合、
        If Concern1.Text = "" Then
            'Watermarkを最前面に設定。
            Me.Watermark1.BringToFront()
        End If
    End Sub

    'Watermarkにフォーカスした場合、
    Private Sub Watermark2_GotFocus(sender As Object, e As EventArgs) Handles Watermark2.GotFocus
        'Watermarkを最背面に設定。
        Me.Watermark2.SendToBack()
        'Concernにフォーカス。
        Me.Concern2.Focus()
    End Sub

    'Concernからフォーカスが外れて、
    Private Sub Concern2_LostFocus(sender As Object, e As EventArgs) Handles Concern2.LostFocus
        'Concernの内容が空白である場合、
        If Concern2.Text = "" Then
            'Watermarkを最前面に設定。
            Me.Watermark2.BringToFront()
        End If
    End Sub

    'Watermarkにフォーカスした場合、
    Private Sub TimeWater_GotFocus(sender As Object, e As EventArgs) Handles TimeWater.GotFocus
        'Watermarkを最背面に設定。
        Me.TimeWater.SendToBack()
        'Timeにフォーカス。
        Me.Time1.Focus()
    End Sub

    'Timeにフォーカスした場合、
    Private Sub Time1_GotFocus(sender As Object, e As EventArgs) Handles Time1.GotFocus
        'Timeにフォーカス。
        Me.Time1.BringToFront()
    End Sub


    Private Sub Time1_KeyDown(sender As Object, e As KeyEventArgs) Handles Time1.KeyDown
        'Time内でEnterキーを押した場合、
        If e.KeyData = Keys.Return Then
            '隣のActionにフォーカス。
            Action1.Focus()
        End If
    End Sub

    Private Sub Time2_KeyDown(sender As Object, e As KeyEventArgs) Handles Time2.KeyDown
        'Time内でEnterキーを押した場合、
        If e.KeyData = Keys.Return Then
            '隣のActionにフォーカス。
            Action2.Focus()
        End If
    End Sub

    Private Sub Time3_KeyDown(sender As Object, e As KeyEventArgs) Handles Time3.KeyDown
        'Time内でEnterキーを押した場合、
        If e.KeyData = Keys.Return Then
            '隣のActionにフォーカス。
            Action3.Focus()
        End If
    End Sub

    Private Sub Time4_KeyDown(sender As Object, e As KeyEventArgs) Handles Time4.KeyDown
        'Time内でEnterキーを押した場合、
        If e.KeyData = Keys.Return Then
            '隣のActionにフォーカス。
            Action4.Focus()
        End If
    End Sub

    Private Sub Time5_KeyDown(sender As Object, e As KeyEventArgs) Handles Time5.KeyDown
        'Time内でEnterキーを押した場合、
        If e.KeyData = Keys.Return Then
            '隣のActionにフォーカス。
            Action5.Focus()
        End If
    End Sub

    Private Sub Time6_KeyDown(sender As Object, e As KeyEventArgs) Handles Time6.KeyDown
        'Time内でEnterキーを押した場合、
        If e.KeyData = Keys.Return Then
            '隣のActionにフォーカス。
            Action6.Focus()
        End If
    End Sub

    Private Sub Time7_KeyDown(sender As Object, e As KeyEventArgs) Handles Time7.KeyDown
        'Time内でEnterキーを押した場合、
        If e.KeyData = Keys.Return Then
            '隣のActionにフォーカス。
            Action7.Focus()
        End If
    End Sub

    Private Sub Time8_KeyDown(sender As Object, e As KeyEventArgs) Handles Time8.KeyDown
        'Time内でEnterキーを押した場合、
        If e.KeyData = Keys.Return Then
            '隣のActionにフォーカス。
            Action8.Focus()
        End If
    End Sub

    Private Sub Time9_KeyDown(sender As Object, e As KeyEventArgs) Handles Time9.KeyDown
        'Time内でEnterキーを押した場合、
        If e.KeyData = Keys.Return Then
            '隣のActionにフォーカス。
            Action9.Focus()
        End If
    End Sub

    Private Sub Time10_KeyDown(sender As Object, e As KeyEventArgs) Handles Time10.KeyDown
        'Time内でEnterキーを押した場合、
        If e.KeyData = Keys.Return Then
            '隣のActionにフォーカス。
            Action10.Focus()
        End If
    End Sub

    Private Sub Time11_KeyDown(sender As Object, e As KeyEventArgs) Handles Time11.KeyDown
        'Time内でEnterキーを押した場合、
        If e.KeyData = Keys.Return Then
            '隣のActionにフォーカス。
            Action11.Focus()
        End If
    End Sub

    Private Sub Time12_KeyDown(sender As Object, e As KeyEventArgs) Handles Time12.KeyDown
        'Time内でEnterキーを押した場合、
        If e.KeyData = Keys.Return Then
            '隣のActionにフォーカス。
            Action12.Focus()
        End If
    End Sub

    Private Sub Time13_KeyDown(sender As Object, e As KeyEventArgs) Handles Time13.KeyDown
        'Time内でEnterキーを押した場合、
        If e.KeyData = Keys.Return Then
            '隣のActionにフォーカス。
            Action13.Focus()
        End If
    End Sub

    Private Sub Time14_KeyDown(sender As Object, e As KeyEventArgs) Handles Time14.KeyDown
        'Time内でEnterキーを押した場合、
        If e.KeyData = Keys.Return Then
            '隣のActionにフォーカス。
            Action14.Focus()
        End If
    End Sub

    Private Sub Time1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Time1.KeyPress
        '0～9と、バックスペース以外の時は、イベントをキャンセルする
        If (e.KeyChar < "0"c Or "9"c < e.KeyChar) And e.KeyChar <> ControlChars.Back And e.KeyChar <> ":"c Then
            e.Handled = True
        End If
    End Sub

    'Timeからフォーカスが外れた場合、
    Private Sub Time1_LostFocus(sender As Object, e As EventArgs) Handles Time1.LostFocus
        'CheckTime関数にTimeを渡して実行。
        CheckTime(Time1)
    End Sub

    'Timeからフォーカスが外れた場合、
    Private Sub Time2_LostFocus(sender As Object, e As EventArgs) Handles Time2.LostFocus
        'CheckTime関数にTimeを渡して実行。
        CheckTime(Time2)
    End Sub

    'Timeからフォーカスが外れた場合、
    Private Sub Time3_LostFocus(sender As Object, e As EventArgs) Handles Time3.LostFocus
        'CheckTime関数にTimeを渡して実行。
        CheckTime(Time3)
    End Sub

    'Timeからフォーカスが外れた場合、
    Private Sub Time4_LostFocus(sender As Object, e As EventArgs) Handles Time4.LostFocus
        'CheckTime関数にTimeを渡して実行。
        CheckTime(Time4)
    End Sub

    'Timeからフォーカスが外れた場合、
    Private Sub Time5_LostFocus(sender As Object, e As EventArgs) Handles Time5.LostFocus
        'CheckTime関数にTimeを渡して実行。
        CheckTime(Time5)
    End Sub

    'Timeからフォーカスが外れた場合、
    Private Sub Time6_LostFocus(sender As Object, e As EventArgs) Handles Time6.LostFocus
        'CheckTime関数にTimeを渡して実行。
        CheckTime(Time6)
    End Sub

    'Timeからフォーカスが外れた場合、
    Private Sub Time7_LostFocus(sender As Object, e As EventArgs) Handles Time7.LostFocus
        'CheckTime関数にTimeを渡して実行。
        CheckTime(Time7)
    End Sub

    'Timeからフォーカスが外れた場合、
    Private Sub Time8_LostFocus(sender As Object, e As EventArgs) Handles Time8.LostFocus
        'CheckTime関数にTimeを渡して実行。
        CheckTime(Time8)
    End Sub

    'Timeからフォーカスが外れた場合、
    Private Sub Time9_LostFocus(sender As Object, e As EventArgs) Handles Time9.LostFocus
        'CheckTime関数にTimeを渡して実行。
        CheckTime(Time9)
    End Sub

    'Timeからフォーカスが外れた場合、
    Private Sub Time10_LostFocus(sender As Object, e As EventArgs) Handles Time10.LostFocus
        'CheckTime関数にTimeを渡して実行。
        CheckTime(Time10)
    End Sub

    'Timeからフォーカスが外れた場合、
    Private Sub Time11_LostFocus(sender As Object, e As EventArgs) Handles Time11.LostFocus
        'CheckTime関数にTimeを渡して実行。
        CheckTime(Time11)
    End Sub

    'Timeからフォーカスが外れた場合、
    Private Sub Time12_LostFocus(sender As Object, e As EventArgs) Handles Time12.LostFocus
        'CheckTime関数にTimeを渡して実行。
        CheckTime(Time12)
    End Sub

    'Timeからフォーカスが外れた場合、
    Private Sub Time13_LostFocus(sender As Object, e As EventArgs) Handles Time13.LostFocus
        'CheckTime関数にTimeを渡して実行。
        CheckTime(Time13)
    End Sub

    'Timeからフォーカスが外れた場合、
    Private Sub Time14_LostFocus(sender As Object, e As EventArgs) Handles Time14.LostFocus
        'CheckTime関数にTimeを渡して実行。
        CheckTime(Time14)
    End Sub

    'Focusにフォーカスした場合、
    Private Sub Focus1_GotFocus(sender As Object, e As EventArgs) Handles Focus1.GotFocus
        'Watermarkにフォーカス。
        Me.TimeWater.Focus()
    End Sub

    'Focusにフォーカスした場合、
    Private Sub Focus2_GotFocus(sender As Object, e As EventArgs) Handles Focus2.GotFocus
        'Timeにフォーカス。
        Me.Time2.Focus()
    End Sub

    'Focusにフォーカスした場合、
    Private Sub Focus3_GotFocus(sender As Object, e As EventArgs) Handles Focus3.GotFocus
        'Timeにフォーカス。
        Me.Time3.Focus()
    End Sub

    'Focusにフォーカスした場合、
    Private Sub Focus4_GotFocus(sender As Object, e As EventArgs) Handles Focus4.GotFocus
        'Timeにフォーカス。
        Me.Time4.Focus()
    End Sub

    'Focusにフォーカスした場合、
    Private Sub Focus5_GotFocus(sender As Object, e As EventArgs) Handles Focus5.GotFocus
        'Timeにフォーカス。
        Me.Time5.Focus()
    End Sub

    'Focusにフォーカスした場合、
    Private Sub Focus6_GotFocus(sender As Object, e As EventArgs) Handles Focus6.GotFocus
        'Timeにフォーカス。
        Me.Time6.Focus()
    End Sub

    'Focusにフォーカスした場合、
    Private Sub Focus7_GotFocus(sender As Object, e As EventArgs) Handles Focus7.GotFocus
        'Timeにフォーカス。
        Me.Time7.Focus()
    End Sub

    'Focusにフォーカスした場合、
    Private Sub Focus8_GotFocus(sender As Object, e As EventArgs) Handles Focus8.GotFocus
        'Timeにフォーカス。
        Me.Time8.Focus()
    End Sub

    'Focusにフォーカスした場合、
    Private Sub Focus9_GotFocus(sender As Object, e As EventArgs) Handles Focus9.GotFocus
        'Timeにフォーカス。
        Me.Time9.Focus()
    End Sub

    'Focusにフォーカスした場合、
    Private Sub Focus10_GotFocus(sender As Object, e As EventArgs) Handles Focus10.GotFocus
        'Timeにフォーカス。
        Me.Time10.Focus()
    End Sub

    'Focusにフォーカスした場合、
    Private Sub Focus11_GotFocus(sender As Object, e As EventArgs) Handles Focus11.GotFocus
        'Timeにフォーカス。
        Me.Time11.Focus()
    End Sub

    'Focusにフォーカスした場合、
    Private Sub Focus12_GotFocus(sender As Object, e As EventArgs) Handles Focus12.GotFocus
        'Timeにフォーカス。
        Me.Time12.Focus()
    End Sub

    'Focusにフォーカスした場合、
    Private Sub Focus13_GotFocus(sender As Object, e As EventArgs) Handles Focus13.GotFocus
        'Timeにフォーカス。
        Me.Time13.Focus()
    End Sub

    'Focusにフォーカスした場合、
    Private Sub Focus14_GotFocus(sender As Object, e As EventArgs) Handles Focus14.GotFocus
        'Timeにフォーカス。
        Me.Time14.Focus()
    End Sub

    Private Sub GuidancePlan2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Panel.Location = New Point(0, -30)
        Me.Panel.Anchor = AnchorStyles.Top
    End Sub
End Class