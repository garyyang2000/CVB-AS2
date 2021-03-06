﻿Imports System.Data.SqlClient
Imports DLL_Library.IOTS
Imports DLL_Library.OrderSystemExceptions
Imports System.Windows.Forms


Public Class DBManager
    Private strConn As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Michael\Documents\Visual Studio 2015\Projects\CVB-AS2\DBManager\InnoTrackSys.mdf;Integrated Security=True"
    Private sqlCon As SqlConnection
    Public productList As List(Of Product)
    Public customerList As List(Of Customer)
    Public orderList As List(Of Order)

    Public Event orderUpdate(ByVal reason As Int16)
    Public Sub New()
        productList = Me.getAllProduct
        customerList = getAllCustomer()
        orderList = getAllOrder()

    End Sub


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
        Dim sqlReader As SqlDataReader = Nothing
        strQuery = "SELECT * FROM Customer"

        sqlCon = New SqlConnection(strConn)

        Using (sqlCon)

            Dim sqlComm As SqlCommand = New SqlCommand(strQuery, sqlCon)
            Try
                sqlCon.Open()
                sqlReader = sqlComm.ExecuteReader()
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
            Catch ex As Exception
                MessageBox.Show("Fail to get customer from database", "Data Access Error")
            Finally
                If sqlReader IsNot Nothing Then
                    sqlReader.Close()
                End If
            End Try
        End Using
        Return result


    End Function

    Public Function getAllProduct() As List(Of Product)
        Dim result As New List(Of Product)()

        sqlCon = New SqlConnection(strConn)
        Using (sqlCon)
            Dim strQuery As String
            strQuery = "SELECT * FROM Product"
            Try
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
            Catch ex As Exception
                MessageBox.Show("Fail to get product from database", "Data Access Error")
            End Try

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
            Try
                sqlCon.Open()
                Dim sqlReader As SqlDataReader = sqlComm.ExecuteReader()
                If sqlReader.HasRows Then
                    While (sqlReader.Read())
                        Dim orderNumber As Long = CLng(sqlReader.GetInt32(0))
                        Dim orderDate As String = sqlReader.Item(1).ToString
                        Dim shipDate As String = sqlReader.Item(2).ToString
                        Dim custId As Long = sqlReader.GetInt32(3)
                        Dim newOrder As New Order(orderNumber, orderDate, shipDate, custId)
                        getOrderItems(newOrder)
                        result.Add(newOrder)
                    End While
                End If
                sqlReader.Close()
            Catch
                MessageBox.Show("Fail to get order from database", "Data Access Error")
            End Try
        End Using
        Return result

    End Function

    Public Function getCustomerByID(ByVal custID As Long)
        Dim cust As Customer = Nothing
        For Each cust1 In customerList
            If cust1._custId = custID Then
                cust = cust1
                Exit For
            End If
        Next
        Return cust
    End Function

    Public Function getOrderByID(ByVal orderNumber As Long)
        Dim order1 As Order = Nothing
        For Each order2 In orderList
            If order2._orderNumber = orderNumber Then
                order1 = order2
                Exit For
            End If
        Next

        Return order1
    End Function

    Public Sub getOrderItems(ByRef order1 As Order)
        Dim sqlCon As New SqlConnection(strConn)
        Using (sqlCon)
            Dim strQuery As String
            strQuery = "SELECT * FROM OrderItem WHERE orderNumber=" + order1._orderNumber.ToString
            Try
                Dim sqlComm As New SqlCommand(strQuery, sqlCon)
                'sqlComm.Parameters.AddWithValue("@orderNum", order1._orderNumber.ToString)
                sqlCon.Open()
                Dim sqlReader As SqlDataReader = sqlComm.ExecuteReader()
                If sqlReader.HasRows Then
                    While (sqlReader.Read())
                        Dim productId = sqlReader.GetString(1).Trim
                        Dim qty = sqlReader.GetInt32(2)
                        Dim discount As Double = sqlReader.GetSqlMoney(3).ToDouble()
                        Dim item = New OrderItem(order1._orderNumber, qty, productId, discount)

                        order1.orderItems.Add(item)
                    End While
                End If
            Catch ex As Exception
                MessageBox.Show("Fail to get order item from database", "Data Access Error")
            End Try
        End Using

    End Sub

    Public Sub addNewCustomer(ByVal cust As Customer)
        Dim sqlCon As New SqlConnection(strConn)
        Using (sqlCon)
            Dim strQuery As String
            strQuery = "insert INTO Customer(firstName, lastName,streetAddress,city,province,postalCode,creditLimit,email,phoneNumber) "
            strQuery = strQuery & "Values(@fName,@lName,@StreetAddr,@city,@prov,@pCode,@credit,@email,@phoneNum)"
            Try
                Dim sqlComm As New SqlCommand(strQuery, sqlCon)
                'sqlComm.Parameters.AddWithValue("@custId", cust._custId)
                sqlComm.Parameters.AddWithValue("@fName", cust._firstName)
                sqlComm.Parameters.AddWithValue("@lName", cust._lastName)
                sqlComm.Parameters.AddWithValue("@StreetAddr", cust._streetAddress)
                sqlComm.Parameters.AddWithValue("@city", cust._city)
                sqlComm.Parameters.AddWithValue("@prov", cust._province)
                sqlComm.Parameters.AddWithValue("@pCode", cust._postalCode)
                sqlComm.Parameters.AddWithValue("@credit", cust._creditLimit)
                sqlComm.Parameters.AddWithValue("@email", cust._email)
                sqlComm.Parameters.AddWithValue("@phoneNum", cust._phoneNum)
                sqlCon.Open()
                sqlComm.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Fail to add customer to database", "Data Access Error")
            End Try
        End Using
        customerList = getAllCustomer()

    End Sub
    Public Sub addNewProduct(ByVal prod As Product)
        Dim sqlCon As New SqlConnection(strConn)
        Using (sqlCon)
            Dim strQuery As String
            strQuery = "insert INTO Product Values(@prodId,@desc,@stock,@price)"
            Try
                Dim sqlComm As New SqlCommand(strQuery, sqlCon)
                sqlComm.Parameters.AddWithValue("@prodId", prod._productId)
                sqlComm.Parameters.AddWithValue("@desc", prod._description)
                sqlComm.Parameters.AddWithValue("@stock", prod._QtyOnHand)
                sqlComm.Parameters.AddWithValue("@price", prod._Price)

                sqlCon.Open()
                sqlComm.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Fail to new product to database", "Data Access Error")
            End Try
        End Using
        productList.Add(prod)
    End Sub

    Public Function checkCreditLimit(ByVal custId As Long, ByVal item As OrderItem) As Boolean
        Dim cust = getCustomerByID(custId)
        Dim credit As Double = cust._creditLimit
        Dim orders As List(Of Order) = getCustOrders(cust._custId)
        For Each order1 In orders
            For Each item1 In order1.orderItems
                Dim product1 = getProductById(item1._productId)
                credit = credit - (product1._Price - item1._discount) * item._numberOrdered

            Next
        Next
        Dim product2 = getProductById(item._productId)
        credit = credit - (product2._Price - item._discount) * item._numberOrdered
        If credit >= 0 Then
            Return True
        Else
            Return False
        End If
    End Function


    Public Sub addOrderItem(ByVal item As OrderItem)
        If item IsNot Nothing Then
            Dim order1 As Order = getOrderByID(item._orderNumber)
            Dim cust As Customer = getCustomerByID(order1._custId)
            If Not checkCreditLimit(order1._custId, item) Then
                Dim strMsg = "The credit of customer" & cust._firstName
                strMsg = strMsg & " " & cust._lastName & "is not enough to cover new items."
                MessageBox.Show(strMsg, "Failed to add product")
                Return
            End If

            Dim sqlCon As New SqlConnection(strConn)
                Using (sqlCon)
                    Dim strQuery As String
                    strQuery = "insert INTO [OrderItem] Values(@orderNum,@prodId,@quantity,@discount)"
                    Try
                        Dim sqlComm As New SqlCommand(strQuery, sqlCon)
                        sqlComm.Parameters.AddWithValue("@orderNum", item._orderNumber)
                        sqlComm.Parameters.AddWithValue("@prodId", item._productId)
                        sqlComm.Parameters.AddWithValue("@quantity", item._numberOrdered)
                        sqlComm.Parameters.AddWithValue("@discount", item._discount)

                        sqlCon.Open()
                        sqlComm.ExecuteNonQuery()
                    Catch ex As Exception
                        MessageBox.Show("Fail to add order item to database", "Data Access Error")
                    End Try
                End Using
                orderList = getAllOrder()
            End If
    End Sub
    Public Sub addNewOrder(ByVal order1 As Order)
        Dim sqlCon As New SqlConnection(strConn)
        Using (sqlCon)
            Dim strQuery As String
            strQuery = "insert INTO [Order](orderDate,shipDate,custId) Values(@orderDate,@shipDate,@custId)"
            Try
                Dim sqlComm As New SqlCommand(strQuery, sqlCon)

                sqlComm.Parameters.AddWithValue("@orderDate", DateTime.Parse(order1._orderDate))
                sqlComm.Parameters.AddWithValue("@shipDate", DateTime.Parse(order1._shipDate))
                sqlComm.Parameters.AddWithValue("@custId", order1._custId)

                sqlCon.Open()
                sqlComm.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Fail to add new order to database", "Data Access Error")
            End Try

        End Using
        RaiseEvent orderUpdate(1)
        orderList = getAllOrder()
    End Sub

    Public Sub deleteOrder(ByVal orderId As Long)
        Dim sqlCon As New SqlConnection(strConn)

        Using (sqlCon)
            Dim sqlComm As New SqlCommand()
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "Delete FROM OrderItem WHERE orderNumber=@orderNum1;Delete From [Order] WHERE orderNumber=@orderNum2"
            Try
                sqlComm.Parameters.AddWithValue("@orderNum1", orderId.ToString)
                sqlComm.Parameters.AddWithValue("@orderNum2", orderId.ToString)
                sqlCon.Open()
                sqlComm.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Fail to delete order from database", "Data Access Error")
            End Try
        End Using

        For x = orderList.Count - 1 To 0 Step -1
            Dim Needed = orderList(x)
            If Needed._orderNumber = orderId Then
                orderList.RemoveAt(x)
                Exit For
            End If
        Next

    End Sub


    Public Sub deleteProduct(ByVal prodId As String)
        Dim orders As List(Of Order) = getProductOrders(prodId)
        If orders.Count > 0 Then
            MessageBox.Show("Reason: Cannot delete product with orders", "Fail to delete product")
        Else
            Dim sqlCon As New SqlConnection(strConn)
            Using (sqlCon)
                Dim sqlComm As New SqlCommand()
                Try
                    sqlComm.Connection = sqlCon
                    sqlComm.CommandText = "Delete FROM Product WHERE ProductId=@prodId"
                    sqlComm.Parameters.AddWithValue("@prodId", prodId)
                    sqlCon.Open()
                    sqlComm.ExecuteNonQuery()
                Catch
                    MessageBox.Show("Fail to delete product from database", "Data Access Error")
                End Try
            End Using
            For x = productList.Count - 1 To 0 Step -1
                Dim Needed = productList(x)
                If Needed._productId.Equals(prodId) Then
                    productList.RemoveAt(x)
                    Exit For
                End If
            Next
        End If
    End Sub

    Public Function getProductOrders(ByVal prodId As String) As List(Of Order)
        Dim result As New List(Of Order)()
        For Each order1 In orderList
            For Each item In order1.orderItems
                If item._productId.Equals(prodId) Then
                    Dim order2 As Order = order1
                    result.Add(order2)
                    Exit For
                End If
            Next
        Next
        Return result
    End Function

    Public Function getCustOrders(ByVal custId As Long) As List(Of Order)
        Dim result As New List(Of Order)()
        For Each order1 In orderList
            If order1._custId = custId Then
                Dim order2 As Order = order1
                result.Add(order2)
            End If
        Next
        Return result
    End Function
    Public Sub deleteCustomer(ByVal custId As Long)
        Dim orders As List(Of Order) = getCustOrders(custId)
        If orders.Count > 0 Then
            MessageBox.Show("Reason: Cann't delete customer has orders. ", "Failed to delete Customer")
        Else
            Dim sqlCon As New SqlConnection(strConn)
            Using (sqlCon)
                Dim sqlComm As New SqlCommand()
                sqlComm.Connection = sqlCon
                sqlComm.CommandText = "Delete FROM Customer WHERE custId=@custId"
                Try
                    sqlComm.Parameters.AddWithValue("@custId", custId.ToString)
                    sqlCon.Open()
                    sqlComm.ExecuteNonQuery()
                Catch ex As Exception
                    MessageBox.Show("Fail to delete customer from database", "Data Access Error")
                End Try
            End Using
            For x = customerList.Count - 1 To 0 Step -1
                Dim Needed = customerList(x)
                If Needed._custId = custId Then
                    customerList.RemoveAt(x)
                    Exit For
                End If
            Next
        End If
    End Sub

    Public Sub deleteProductFromOrderById(ByVal orderId As Long, ByVal prodId As String)
        Dim sqlCon As New SqlConnection(strConn)

        Using (sqlCon)
            Dim sqlComm As New SqlCommand()
            sqlComm.Connection = sqlCon
            sqlComm.CommandText = "Delete FROM OrderItem WHERE orderNumber=@orderNum AND productId=@prodId"
            Try
                sqlComm.Parameters.AddWithValue("@orderNum", orderId.ToString)
                sqlComm.Parameters.AddWithValue("@prodId", prodId.ToString)
                sqlCon.Open()
                sqlComm.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Fail to delet order item from database", "Data Access Error")
            End Try
        End Using
        Dim done = False
        For Each order1 In orderList
            If order1._orderNumber = orderId Then
                For x = order1.orderItems.Count - 1 To 0 Step -1
                    Dim Needed = order1.orderItems(x)
                    If Needed._productId.Equals(prodId) Then
                        done = True
                        order1.orderItems.RemoveAt(x)
                        Exit For
                    End If
                Next
            End If
            If done Then Exit For
        Next

    End Sub
    Public Sub updateCustomer(ByVal cust As Customer)
        Dim sqlCon As New SqlConnection(strConn)
        Using (sqlCon)
            Dim strQuery As String
            strQuery = "UPDATE Customer SET firstName=@fName,"
            strQuery = strQuery & "lastName =@lName,streetAddress=@StreetAddr,"
            strQuery = strQuery & "city=@city,province=@prov,postalCode=@pCode,"
            strQuery = strQuery & "creditLimit=@credit,email=@email,phoneNumber=@phoneNum "
            strQuery = strQuery & " WHERE custId=@custId"
            Dim sqlComm As New SqlCommand(strQuery, sqlCon)
            sqlComm.Parameters.AddWithValue("@fName", cust._firstName)
            sqlComm.Parameters.AddWithValue("@lName", cust._lastName)
            sqlComm.Parameters.AddWithValue("@StreetAddr", cust._streetAddress)
            sqlComm.Parameters.AddWithValue("@city", cust._city)
            sqlComm.Parameters.AddWithValue("@prov", cust._province)
            sqlComm.Parameters.AddWithValue("@pCode", cust._postalCode)
            sqlComm.Parameters.AddWithValue("@credit", cust._creditLimit)
            sqlComm.Parameters.AddWithValue("@email", cust._email)
            sqlComm.Parameters.AddWithValue("@phoneNum", cust._phoneNum)
            sqlComm.Parameters.AddWithValue("@custId", cust._custId)
            Try
                sqlCon.Open()
                sqlComm.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Fail to update customer information to database", "Data Access Error")
            End Try
        End Using
        For x = customerList.Count - 1 To 0 Step -1
            Dim Needed = customerList(x)
            If Needed._custId = cust._custId Then
                customerList.RemoveAt(x)
                Exit For
            End If
        Next
        customerList.Add(cust)

    End Sub


    Public Sub updateProduct(ByVal prod As Product)
        Dim sqlCon As New SqlConnection(strConn)
        Using (sqlCon)
            Dim strQuery As String
            strQuery = "Update PRODUCT SET "
            strQuery = strQuery & "description=@desc, stock=@stock, price=@price "
            strQuery = strQuery & "WHERE productId=@prodId"
            Dim sqlComm As New SqlCommand(strQuery, sqlCon)
            Try
                sqlComm.Parameters.AddWithValue("@desc", prod._description)
                sqlComm.Parameters.AddWithValue("@stock", prod._QtyOnHand)
                sqlComm.Parameters.AddWithValue("@price", prod._Price)
                sqlComm.Parameters.AddWithValue("@prodId", prod._productId)
                sqlCon.Open()
                sqlComm.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Fail to update product information to database", "Data Access Error")
            End Try
        End Using

        For x = productList.Count - 1 To 0 Step -1
            Dim Needed = productList(x)
            If Needed._productId.Equals(prod._productId) Then
                productList.RemoveAt(x)
                Exit For
            End If
        Next
        productList.Add(prod)

    End Sub

    Public Sub updateOrder(ByVal order1 As Order)
        Dim order2 As Order = getOrderByID(order1._orderNumber)

        orderList.Remove(order2)
        orderList.Add(order1)
        Dim sqlCon As New SqlConnection(strConn)
        Using (sqlCon)
            Dim strQuery As String
            strQuery = "Update [Order] Set orderDate=@orderDate,shipDate=@shipDate,custId=@custId WHERE orderNumber=@orderNum"
            Dim sqlComm As New SqlCommand(strQuery, sqlCon)
            Try
                sqlComm.Parameters.AddWithValue("@orderDate", DateTime.Parse(order1._orderDate))
                sqlComm.Parameters.AddWithValue("@shipDate", DateTime.Parse(order1._shipDate))
                sqlComm.Parameters.AddWithValue("@custId", order1._custId)
                sqlComm.Parameters.AddWithValue("@orderNum", order1._orderNumber)
                sqlCon.Open()
                sqlComm.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Fail to update order information to database", "Data Access Error")
            End Try
        End Using

    End Sub

    Public Sub updateOrderItem(ByVal item As OrderItem)
        Dim sqlCon As New SqlConnection(strConn)
        Using (sqlCon)
            Dim strQuery As String
            strQuery = "Update [OrderItem] SET quantity=@quantity,discount=@discount WHERE orderNumber=@orderNum AND ProductId=@prodId"
            Dim sqlComm As New SqlCommand(strQuery, sqlCon)
            Try
                sqlComm.Parameters.AddWithValue("@quantity", item._numberOrdered)
                sqlComm.Parameters.AddWithValue("@discount", item._discount)
                sqlComm.Parameters.AddWithValue("@orerNum", item._orderNumber)
                sqlComm.Parameters.AddWithValue("@prodId", item._productId)
                sqlCon.Open()
                sqlComm.ExecuteNonQuery()
            Catch
                MessageBox.Show("Fail to update order item to database", "Data Access Error")
            End Try
        End Using
    End Sub


    Public Function searchProduct(ByVal desc As String) As List(Of Product)
        Dim result As New List(Of Product)()
        Dim sqlCon As New SqlConnection(strConn)
        Using (sqlCon)
            Dim strQuery As String
            strQuery = "SELECT * FROM Product WHERE description LIKE @desc"
            Try
                Dim sqlComm As SqlCommand = New SqlCommand(strQuery, sqlCon)
                desc = "%" + desc + "%"
                sqlComm.Parameters.AddWithValue("@desc", desc)
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
            Catch ex As Exception
                MessageBox.Show("Fail to search product information from database", "Data Access Error")
            End Try
        End Using
        Return result
    End Function

    Public Function searchCustomer(ByVal name As String)
        Dim result As New List(Of Customer)()
        Dim sqlCon As New SqlConnection(strConn)
        Using (sqlCon)
            Dim strQuery As String
            strQuery = "SELECT * FROM Customer WHERE firstName LIKE @name OR lastName LIKE @name"
            Try
                Dim sqlComm As SqlCommand = New SqlCommand(strQuery, sqlCon)
                name = "%" + name + "%"
                sqlComm.Parameters.AddWithValue("@name", name)
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
            Catch ex As Exception
                MessageBox.Show("Fail to search customer information from database", "Data Access Error")
            End Try
        End Using
        Return result


    End Function
    Public Function searchOrder(ByVal ordernumber As String, ByVal dtOrderDateStart As Date, ByVal dtOrderDateEnd As Date, ByVal dtShipDateStart As Date, ByVal dtShipDateEnd As Date)
        Dim result As New List(Of Order)()

        sqlCon = New SqlConnection(strConn)
        Using (sqlCon)
            Dim strQuery As String
            strQuery = "SELECT * FROM [Order] WHERE orderNumber=@orderNum "
            strQuery = strQuery & " OR (orderDate>=@orderDateStart AND orderDate<=@orderDateEnd)"
            strQuery = strQuery & " OR (shipDate>=@shipDateStart AND orderDate<=@shipDateEnd)"
            Try
                Dim sqlComm As SqlCommand = New SqlCommand(strQuery, sqlCon)
                sqlComm.Parameters.AddWithValue("@orderNum", ordernumber)
                sqlComm.Parameters.AddWithValue("@orderDateStart", dtOrderDateStart)
                sqlComm.Parameters.AddWithValue("@orderDateEnd", dtOrderDateEnd)
                sqlComm.Parameters.AddWithValue("@shipDateStart", dtShipDateStart)
                sqlComm.Parameters.AddWithValue("@shipDateEnd", dtShipDateEnd)

                sqlCon.Open()
                Dim sqlReader As SqlDataReader = sqlComm.ExecuteReader()
                If sqlReader.HasRows Then
                    While (sqlReader.Read())
                        Dim orderNum As Long = CLng(sqlReader.GetInt32(0))
                        Dim orderDate As String = sqlReader.Item(1).ToString
                        Dim shipDate As String = sqlReader.Item(2).ToString
                        Dim custId As Long = sqlReader.GetInt32(3)
                        Dim newOrder As New Order(orderNum, orderDate, shipDate, custId)
                        getOrderItems(newOrder)
                        result.Add(newOrder)
                    End While
                End If
                sqlReader.Close()
            Catch ex As Exception
                MessageBox.Show("Fail to search order information from database", "Data Access Error")
            End Try
        End Using
        Return result

    End Function

    Public Function checkOrderItem(ByVal orderNum As Long, ByVal prodId As String)
        Dim result As OrderItem = Nothing
        Dim order1 As Order = getOrderByID(orderNum)
        For Each item In order1.orderItems
            If item._productId.Equals(prodId) Then
                result = item
            End If
        Next
        Return result

    End Function

End Class
