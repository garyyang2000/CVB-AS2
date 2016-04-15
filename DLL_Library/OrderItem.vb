Imports System.Text.RegularExpressions
Imports CSLib
Namespace IOTS


    <Serializable()>
    Public Class OrderItem
        Implements IValidator
        Private orderNumber As Long
        Private numberOrdered As Integer
        Private productId As String
        Private discount As Double

        Public ReadOnly Property _orderNumber() As Long
            Get
                Return orderNumber
            End Get
        End Property

        Public Property _numberOrdered() As Integer
            Get
                ' Return the value stored in the local variable. 
                Return numberOrdered
            End Get
            Set(ByVal Value As Integer)
                If Value > 0 Then
                    numberOrdered = Value
                Else
                    Throw New OrderSystemExceptions("An exception has occurred, number ordered should more than 0.")
                End If
            End Set
        End Property

        Public Property _discount() As Double
            Get
                Return discount
            End Get
            Set(value As Double)
                Dim regName As String = "^\d+([.]\d{1,2})?$"
                If IsValid(value.ToString, regName) And (value >= 0) Then
                    discount = value
                Else
                    Throw New OrderSystemExceptions("Discount must be numbers with maximum of 2 decimals")
                End If
            End Set
        End Property
        Public Property _productId() As String
            Get
                ' Return the value stored in the local variable. 
                Return productId
            End Get
            Set(ByVal Value As String)
                ' Store the value in a local variable.
                Dim regName As String = "^[A-Z][A-Z][0-9][0-9]$"
                If IsValid(Value, regName) Then
                    productId = Value
                Else
                    Throw New OrderSystemExceptions("An exception has occurred, productId should in XX00 format.")
                End If
            End Set
        End Property
        Public Function IsValid(ByVal testData As String, ByVal regex As String) As Boolean Implements IValidator.IsValid
            Dim r As Regex = New Regex(regex, RegexOptions.IgnoreCase)
            Dim m As Match = r.Match(testData)
            Return m.Success
        End Function
    End Class
End Namespace