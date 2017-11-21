Public Class Form5

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim dt As New DateTime(2000, 9, 24, 15, 30, 0)

        'UTCに変換する
        Dim utcTime As DateTime = System.TimeZoneInfo.ConvertTimeToUtc(dt)
        '結果を表示する
        TextBox1.Text = utcTime
        '2000/09/24 6:30:00 / Utc
    End Sub
End Class