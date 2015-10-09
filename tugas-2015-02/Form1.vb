Public Class Form1
    Dim angka1 As Integer
    Dim angka2 As Integer
    Dim operasi As String
    Dim status As Boolean

    Private Sub input(ByVal angka As Char)
        If Me.status = True Then
            If (Me.Texthasil.Text = "0") Then
                Me.Texthasil.Text = Convert.ToString(angka)
            Else
                Dim Texthasil As TextBox = Me.Texthasil
                Texthasil.Text = (Texthasil.Text & Convert.ToString(angka))
            End If
        Else
            Me.Texthasil.Text = Convert.ToString(angka)
            Me.status = True
        End If
    End Sub

    Public Sub inputOprator(ByVal oprator As String)
        If (Me.Texthasil.Text <> "0") Then
            If (Me.operasi = String.Empty) Then
                Me.angka1 = Convert.ToInt32(Me.Texthasil.Text)
                Me.Texthasil.Text = Me.angka1.ToString
                Me.status = False
            Else
                Me.hitung()
            End If
            Me.operasi = oprator
        End If
    End Sub

    Private Sub hitung()
        Me.angka2 = Convert.ToInt32(Me.Texthasil.Text)
        Select Case Me.operasi
            Case "+"
                Me.angka1 = (Me.angka1 + Me.angka2)
                Exit Select
            Case "-"
                Me.angka1 = (Me.angka1 - Me.angka2)
                Exit Select
        End Select
        Me.Texthasil.Text = Me.angka1.ToString
        Me.status = False
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If (Me.status AndAlso (Me.Texthasil.Text <> "0")) Then
            Dim Texthasil As TextBox = Me.Texthasil
            Texthasil.Text = (Texthasil.Text & "0")
        End If
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs)
        Me.input("1")
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Me.input("2")
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Me.input("3")
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        Me.input("4")
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        Me.input("5")
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        Me.input("6")
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        Me.input("7")
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        Me.input("8")
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        Me.input("9")
    End Sub

    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        Me.Texthasil.Text = "0"
        Me.angka1 = 0
        Me.operasi = String.Empty
    End Sub

    Private Sub btnnegatif_Click(sender As Object, e As EventArgs) Handles btnnegatif.Click
        Me.inputOprator("-")
    End Sub

    Private Sub btntambah_Click(sender As Object, e As EventArgs) Handles btntambah.Click
        Me.inputOprator("+")
    End Sub

    Private Sub btnsamadengan_Click(sender As Object, e As EventArgs) Handles btnsamadengan.Click
        If ((Me.Texthasil.Text <> "0") And (Me.angka1 <> 0)) Then
            Me.hitung()
            Me.operasi = String.Empty
        End If
    End Sub

    Private Sub btn1_Click_1(sender As Object, e As EventArgs) Handles btn1.Click
        Me.input("1")
    End Sub
End Class
