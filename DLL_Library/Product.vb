Imports CSLib
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Soap
Namespace IOTS
    <Serializable()>
    Public Class Product
        Implements IValidator
        Private ProductId As String
        Private Description As String
        Private QtyOnHand As Integer
        Private Price As Double

        Public Property _Price() As String
            Get
                ' Return the value stored in the local variable. 
                Return Price
            End Get
            Set(ByVal Value As String)
                ' Store the value in a local variable.
                'price can has 2 decimals max.
                Dim regName As String = "^\d+([.]\d{1,2})?$"
                If IsValid(Value.Trim, regName) Then
                    Price = Value
                Else
                    Throw New OrderSystemExceptions("An exception has occurred, price should have two decimal places.")
                End If
            End Set
        End Property
        Public Property _description() As String
            Get
                Return Description
            End Get
            Set(value As String)
                Description = value
            End Set
        End Property

        Public Property _QtyOnHand() As Integer
            Get
                ' Return the value stored in the local variable. 
                Return QtyOnHand
            End Get
            Set(ByVal Value As Integer)
                If Value >= 0 Then
                    QtyOnHand = Value
                Else
                    Throw New OrderSystemExceptions("An exception has occurred, quantity on hand cannot less than 0.")
                End If
            End Set
        End Property
        Public Property _productId() As String
            Get
                ' Return the value stored in the local variable. 
                Return ProductId
            End Get
            Set(ByVal Value As String)
                ' Store the value in a local variable.
                Dim regName As String = "^[A-Z][A-Z][0-9][0-9]$"
                If IsValid(Value, regName) Then
                    ProductId = Value
                Else
                    Throw New OrderSystemExceptions("An exception has occurred, productId should in XX00 format.")
                End If
            End Set
        End Property
        Sub New(ByVal ProductId As String, ByVal Description As String, ByVal QtyOnHand As Integer, ByVal Price As Double)
            _productId = ProductId
            MyClass.Description = Description
            _QtyOnHand = QtyOnHand
            _Price = Price
        End Sub


        Public Function IsValid(ByVal testData As String, ByVal regex As String) As Boolean Implements IValidator.IsValid
            Dim r As Regex = New Regex(regex, RegexOptions.IgnoreCase)
            Dim m As Match = r.Match(testData)
            Return m.Success
        End Function

        Public Overrides Function ToString() As String
            Return String.Format("{0}, {1}, {2}, {3}", ProductId, Description, QtyOnHand, Price)
        End Function

        Public Function GetDetails() As String
            Dim result As String = Nothing
            result = result + "Product Id:" + _productId + vbCrLf
            result = result + "Product Description: " + _description + vbCrLf
            result = result + "QtyOnHand: " + CStr(_QtyOnHand) + vbTab
            result = result + "Price: $" + CStr(_Price)

            Return result
        End Function


    End Class


End Namespace