Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports CinemaVBApp

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub Adult_Before_5_Test()
        Dim form1 As Form = New Form
        Dim adult_before_5 = form1.Adult_Before_5(2, "person", "wednesday", 4)

        Assert.AreEqual(31.0, adult_before_5)
    End Sub
    <TestMethod()> Public Sub Adult_After_5_Test()
        Dim form1 As Form = New Form
        Dim adult_after_5 = form1.Adult_After_5(2, "person", "wednesday", 6)

        Assert.AreEqual(37.0, adult_after_5)
    End Sub
    <TestMethod()> Public Sub Adult_Tuesday_AllDay_Test()
        Dim form1 As Form = New Form
        Dim Adult_Tuesday_AllDay = form1.Adult_Tuesday_AllDay(2, "person", "tuesday", 6)

        Assert.AreEqual(31.0, Adult_Tuesday_AllDay)
    End Sub
    <TestMethod()> Public Sub Child_Under_16_Test()
        Dim form1 As Form = New Form
        Dim Child_Under_16 = form1.Child_Under_16(2, "person", "wednesday", 6, 15)

        Assert.AreEqual(27.0, Child_Under_16)
    End Sub
    <TestMethod()> Public Sub Senior_Over_65_Test()
        Dim form1 As Form = New Form
        Dim Senior_Over_65 = form1.Senior_Over_65(2, "person", "wednesday", 6, 65)

        Assert.AreEqual(28.0, Senior_Over_65)
    End Sub
    <TestMethod()> Public Sub Student_WithID_Test()
        Dim form1 As Form = New Form
        Dim Student_WithID = form1.Student_WithID(2, "student", "wednesday", 6, 20)

        Assert.AreEqual(31.0, Student_WithID)
    End Sub
    <TestMethod()> Public Sub FamilyPass()
        Dim form1 As Form = New Form
        Dim FamilyPass = form1.FamilyPass(1, "family", "wednesday", 6, 20)

        Assert.AreEqual(53.0, FamilyPass)
    End Sub

End Class