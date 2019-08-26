Public Class Form
    Public Function Adult_Before_5(quantity As Integer, person As String, day As String, time As Decimal) As Double
        Dim actaul_price As Double = 15.5
        Dim total_price = actaul_price * quantity
        If time <= 5 Then
            Return total_price
        Else Return 0
        End If

    End Function
    Public Function Adult_After_5(quantity As Integer, person As String, day As String, time As Integer) As Double
        Dim actaul_price As Double = 18.5
        Dim total_price = actaul_price * quantity
        If time >= 5 Then
            Return total_price
        Else Return 0
        End If
    End Function

    Public Function Adult_Tuesday_AllDay(quantity As Integer, person As String, day As String, time As Integer) As Double
        Dim actaul_price As Double = 15.5
        Dim total_price = actaul_price * quantity
        If day = "tuesday" Then
            Return total_price
        Else Return 0
        End If
    End Function

    Public Function Child_Under_16(quantity As Integer, person As String, day As String, time As Integer, age As Double) As Double
        Dim actaul_price As Double = 13.5
        Dim total_price = actaul_price * quantity
        If age <= 16 Then
            Return total_price
        Else Return 0
        End If
    End Function
    Public Function Senior_Over_65(quantity As Integer, person As String, day As String, time As Integer, age As Double) As Double
        Dim actaul_price As Double = 14.0
        Dim total_price = actaul_price * quantity
        If age >= 65 Then
            Return total_price
        Else Return 0
        End If
    End Function
    Public Function Student_WithID(quantity As Integer, person As String, day As String, time As Integer, age As Double) As Double
        Dim actaul_price As Double = 15.5
        Dim total_price = actaul_price * quantity
        If person = "student" Then
            Return total_price
        Else Return 0
        End If
    End Function
    Public Function FamilyPass(quantity As Integer, person As String, day As String, time As Integer, age As Double) As Double
        Dim actaul_price As Double = 53.0
        Dim total_price = actaul_price * quantity
        If person = "family" Then
            Return total_price
        Else Return 0
        End If
    End Function


    Private Sub Cinemas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
