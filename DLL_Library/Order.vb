Imports CSLib
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Soap
Namespace IOTS
    <Serializable()>
    Public Class Order
        Implements IValidator
        Private orderNumber As Long
        Private orderDate As String
        Private ShipDate As String
        Private numberOrdered As Integer
        Private productId As String
        Private discount As Double
        Private custId As Long
        Public orderItems As New List(Of OrderItem)()

        Public Function addOrderItem(ByVal item As OrderItem) As Boolean
            Dim result As Boolean = False
            If (orderItems.Count < 10) Then
                orderItems.Add(item)
                result = True
            End If
            Return result
        End Function
        'the order number cannot be changed!
        Public ReadOnly Property _orderNumber() As Long
            Get
                Return orderNumber
            End Get
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
        Public Property _orderDate() As String
            Get
                Return orderDate
            End Get
            Set(ByVal Value As String)
                If Value = Nothing Then
                    Throw New OrderSystemExceptions("An exception has occurred, orderDate not valid.")
                Else
                    ' Dim dateIn As Date = Date.ParseExact(Value, "dd/MM/yyyy h:mm:ss tt",
                    '         System.Globalization.DateTimeFormatInfo.InvariantInfo)
                    Dim dateIn As Date = Date.Parse(Value)
                    'Order Date cannot be future
                    Dim result As Integer = DateTime.Compare(dateIn, Date.Now())
                    If result <= 0 Then
                        orderDate = dateIn
                    Else
                        Throw New OrderSystemExceptions("orderDate has to be earlier or same to current date.")
                    End If
                End If
            End Set
        End Property

        Public Property _shipDate() As String
            Get
                Return ShipDate
            End Get
            Set(ByVal Value As String)
                If Value = Nothing Then
                    Throw New OrderSystemExceptions("An exception has occurred, shipDate not valid.")
                Else
                    'Dim dateIn As Date = Date.ParseExact(Value, "dd/MM/yyyy",
                    'System.Globalization.DateTimeFormatInfo.InvariantInfo)
                    Dim dateIn As Date = Date.Parse(Value)
                    Dim result1 As Integer = DateTime.Compare(orderDate, dateIn)
                    Dim result2 As Integer = DateTime.Compare(dateIn, Date.Now())
                    'If result1 <= 0 And result2 >= 0 Then
                    If result1 <= 0 And result1 >= -180 Then
                        ShipDate = dateIn
                    Else
                        Throw New OrderSystemExceptions("shipDate has to be later than or same as orderDate as well as current date.")
                    End If
                End If
            End Set
        End Property

        Public Property _custId() As Long
            Get
                Return custId
            End Get
            Set(ByVal Value As Long)
                If Value > 0 Then
                    custId = Value
                Else
                    Throw New OrderSystemExceptions("custId has to be positive integer.")
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
        Sub New(ByVal orderNumber As Long, ByVal orderDate As String,
                ByVal ShipDate As String, ByVal numberOrdered As Integer,
                ByVal productId As String, ByVal discount As Double,
                ByVal custid As Long)
            MyClass.orderNumber = orderNumber
            _orderDate() = orderDate
            _shipDate() = ShipDate
            _numberOrdered = numberOrdered
            _productId = productId
            _discount = discount
            MyClass.custId = custid
        End Sub


        Sub New(ByVal orderNumber As Long, ByVal orderDate As String,
                ByVal ShipDate As String, ByVal custid As Long)
            MyClass.orderNumber = orderNumber
            _orderDate() = orderDate
            _shipDate() = ShipDate
            MyClass.custId = custid
        End Sub

        Sub New(ByVal orderDate As String,
                ByVal ShipDate As String, ByVal custid As Long)
            MyClass.orderNumber = orderNumber
            _orderDate() = orderDate
            _shipDate() = ShipDate
            MyClass.custId = custid
        End Sub

        Public Function IsValid(ByVal testData As String, ByVal regex As String) As Boolean Implements IValidator.IsValid
            Dim r As Regex = New Regex(regex, RegexOptions.IgnoreCase)
            Dim m As Match = r.Match(testData)
            Return m.Success
        End Function

        Public Overrides Function ToString() As String
            Return String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}", orderNumber, orderDate, ShipDate, numberOrdered, productId, discount.ToString("F2"), custId)
        End Function

        Public Event new_orderCreated()
    End Class



End Namespace