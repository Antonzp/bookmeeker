Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    
        Dim a, b, c, d As Integer
        Randomize()
        a = Rnd()
        b = Rnd()
        c = Rnd()
        d = Rnd()
        PictureBox1.Location = New Point(PictureBox1.Location.X + a, PictureBox1.Location.Y)
        PictureBox2.Location = New Point(PictureBox2.Location.X + b, PictureBox2.Location.Y)
        PictureBox3.Location = New Point(PictureBox3.Location.X + c, PictureBox3.Location.Y)
        PictureBox4.Location = New Point(PictureBox4.Location.X + d, PictureBox4.Location.Y)

        If PictureBox1.Location.X = 665 Then 'Or PictureBox2.Location.X = 665 Or PictureBox3.Location.X = 665 Or PictureBox4.Location.X = 665 Then
            Timer1.Stop()
            MsgBox("Первой пришла Синяя лошадь", , "Скачки окончены")
        ElseIf PictureBox2.Location.X = 665 Then
            Timer1.Stop()
            MsgBox("Первой пришла Зеленая лошадь", , "Скачки окончены")
        ElseIf PictureBox3.Location.X = 665 Then
            Timer1.Stop()
            MsgBox("Первой пришла Красная лошадь", , "Скачки окончены")
        ElseIf PictureBox4.Location.X = 665 Then
            Timer1.Stop()
            MsgBox("Первой пришла Желтая лошадь", , "Скачки окончены")

        End If

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Stop()
        PictureBox1.Location = New Point(PictureBox1.Location.X = 10, PictureBox1.Location.Y)
        PictureBox2.Location = New Point(PictureBox2.Location.X = 10, PictureBox2.Location.Y)
        PictureBox3.Location = New Point(PictureBox3.Location.X = 10, PictureBox3.Location.Y)
        PictureBox4.Location = New Point(PictureBox4.Location.X = 10, PictureBox4.Location.Y)
    End Sub
End Class
