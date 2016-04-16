Imports System.Data.SqlClient
Imports DLL_Library.IOTS
Imports DLL_Library.OrderSystemExceptions

Public Class DBManager
    Private strConn As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Michael\Documents\Visual Studio 2015\Projects\CVB-AS2\DBManager\InnoTrackSys.mdf;Integrated Security=True"
    Private sqlCon As SqlConnection
    Public productList As List(Of Product)
    Public customerList As List(Of Customer)
    Public orderList As List(Of Order)
    Public Function getProductById(ByVal productId As String) As Product
        Dim result As Product = Nothing
        For Each product1 In productList
            If product1._productId.Equals(productId) Then
                result = product1
                Exit For
            End If
        Next
        Return result
    End Function
    Public Function getAllCustomer() As List(Of Customer)
        Dim result As New List(Of Customer)()
        Dim strQuery As String


        strQuery = "SELECT * FROM Customer"

        sqlCon = New SqlConnection(strConn)

        Using (sqlCon)

            Dim sqlComm As SqlCommand = New SqlCommand(strQuery, sqlCon)
            sqlCon.Open()
            Dim sqlReader As SqlDataReader = sqlComm.ExecuteReader()
            If sqlReader.HasRows Then
                Dim mailAddr As String = Nothing
                Dim mailId As Int32 = 0
                While (sqlReader.Read())
                    Dim custId = sqlReader.Item(0)
                    Dim first_name = sqlReader.Item(1).ToString().Trim
                    Dim last_name = sqlReader.Item(2).ToString().Trim
                    Dim address = sqlReader.Item(3).ToString().Trim
                    Dim city = sqlReader.Item(4).ToString().Trim
                    Dim province = sqlReader.Item(5).ToString().Trim
                    Dim postalcode = sqlReader.Item(6).ToString().Trim
                    Dim credit_limit = sqlReader.Item(7)
                    Dim email = sqlReader.Item(8)
                    Dim phone = sqlReader.Item(9)
                    Dim newCust As New DLL_Library.IOTS.Customer(custId,
                             first_name, last_name, address, city, province, postalcode, credit_limit, email, phone)
                    result.Add(newCust)
                End While
            End If
            sqlReader.Close()
        End Using
        Return result


    End Function

    Public Function getAllProduct() As List(Of Product)
        Dim result As New List(Of Product)()
        Dim strQuery As String
        strQuery = "SELECT * FROM Product"
        sqlCon = New SqlConnection(strConn)
        Using (sqlCon)
            Dim sqlComm As SqlCommand = New SqlCommand(strQuery, sqlCon)
            sqlCon.Open()
            Dim sqlReader As SqlDataReader = sqlComm.ExecuteReader()
            If sqlReader.HasRows Then
                While (sqlReader.Read())
                    Dim productId As String = sqlReader.Item(0).ToString.Trim
                    Dim description As String = sqlReader.Item(1)
                    Dim qtyOnHand As Int32 = sqlReader.Item(2)
                    Dim price As Double = sqlReader.GetSqlMoney(3).ToDouble()
                    Dim newProd As New DLL_Library.IOTS.Product(productId, description, qtyOnHand, price)
                    result.Add(newProd)
                End While
            End If
            sqlReader.Close()
        End Using
        Return result
    End Function

    Public Function getAllOrder()
        Dim result As New List(Of Order)()
        Dim strQuery As String
        strQuery = "SELECT * FROM [Order]"
        sqlCon = New SqlConnection(strConn)
        Using (sqlCon)
            Dim sqlComm As SqlCommand = New SqlCommand(strQuery, sqlCon)
            sqlCon.Open()
            Dim sqlReader As SqlDataReader = sqlComm.ExecuteReader()
            If sqlReader.HasRows Then
                While (sqlReader.Read())
                    Dim orderNumber As Long = CLng(sqlReader.GetString(0))
                    Dim orderDate As String = sqlReader.Item(1).ToString
                    Dim shipDate As String = sqlReader.Item(2).ToString
                    Dim custId As Long = sqlReader.GetInt32(3)
                    Dim newOrder As New Order(orderNumber, orderDate, shipDate, custId)

                    result.Add(newOrder)
                End While
            End If
            sqlReader.Close()
        End Using
        Return result

    End Function

    Public Function getCustomerByID(ByVal custID As Long)
        Return Nothing
    End Function

    Public Function getOrderByID(ByVal orderNumber As Long)
        Return Nothing
    End Function

    Public Sub getOrderItems(ByRef order1 As Order)
        Dim sqlCon As New SqlConnection(strConn)

        Dim strQuery As String
        strQuery = "SELECT * FROM OrderItem WHERE orderNumber=@orderNum"
        Using (sqlCon)
            Dim sqlComm As New SqlCommand(strQuery, sqlCon)
            sqlComm.Parameters.AddWithValue("@orderNum", order1._orderNumber.ToString)
            sqlCon.Open()
            Dim sqlReader As SqlDataReader = sqlComm.ExecuteReader()
            If sqlReader.HasRows Then
                Dim productId = sqlReader.Item(1).ToString.Trim
                Dim qty = sqlReader.GetInt32(2)
                Dim discount As Double = sqlReader.GetSqlMoney(3).ToDouble()
                Dim item = New OrderItem(order1._orderNumber, qty, productId, discount)
                'item._orderNumber = order1._orderNumber
                order1.orderItems.Add(item)
            End If
        End Using

    End Sub

    Public Sub addNewCustomer()

    End Sub
    Public Sub addNewProduct()

    End Sub

    Public Sub addNewOrder()

    End Sub

    Public Sub deleteOrder(ByVal orderId As Long)

    End Sub
    Public Sub deleteProduct(ByVal prodId As String)

    End Sub
    Public Sub deleteCustomer(ByVal custId As Long)

    End Sub

    Public Sub deleteProductFromOrderById(ByVal orderId As Long, ByVal prodId As Long)

    End Sub
    Public Sub updateCustomer()

    End Sub

    Public Sub updateProduct()

    End Sub

    Public Sub updateOrder()

    End Sub

    Public Sub searchProduct()

    End Sub

    Public Sub searchCustomer()

    End Sub
    Public Sub searchOrder()

    End Sub

End Class
