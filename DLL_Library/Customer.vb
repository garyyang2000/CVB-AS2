
Imports CSLib
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Soap


Namespace IOTS
    <Serializable()>
    Public Class Customer
        Inherits Address
        Implements IValidator
        Private custId As Long
        Private firstName As String
        Private lastName As String
        Private streetAddress As String
        Private city As String
        Private province As String
        Private postalCode As String
        Private creditLimit As Double
        Private email As String
        Private count As Int16 = 0
        Private phoneNum As String


        Public Property _phoneNum() As String
            Get
                ' Return the value stored in the local variable. 
                Return phoneNum
            End Get
            Set(ByVal Value As String)
                ' Store the value in a local variable.

                If (Value.Length < 50) Then
                    phoneNum = Value
                Else
                    Throw New OrderSystemExceptions("An exception has occurred, phone number can not be more than 50.")
                End If
            End Set
        End Property
        Public ReadOnly Property _custId() As Long
            Get
                Return custId
            End Get
        End Property
        Public Property _firstName() As String
            Get
                ' Return the value stored in the local variable. 
                Return firstName
            End Get
            Set(ByVal Value As String)
                ' Store the value in a local variable.
                Dim regName As String = "^[A-Za-z]+$"
                If IsValid(Value, regName) Then
                    firstName = Value
                    count = count + 1
                Else
                    Throw New OrderSystemExceptions("An exception has occurred, name should contain only upper case and lower case alphabets.")
                End If
            End Set
        End Property
        Public Property _lastName() As String
            Get
                ' Return the value stored in the local variable. 
                Return lastName
            End Get
            Set(ByVal Value As String)
                ' Store the value in a local variable.
                Dim regName As String = "^[A-Za-z]+$"
                If IsValid(Value, regName) Then
                    lastName = Value
                    count = count + 1
                Else
                    Throw New OrderSystemExceptions("An exception has occurred, name should contain only upper case and lower case alphabets.")
                End If
            End Set
        End Property
        Public Property _streetAddress() As String
            Get
                ' Return the value stored in the local variable. 
                Return streetAddress
            End Get
            Set(ByVal Value As String)
                ' Store the value in a local variable.
                Dim regStreet As String = "^[0-9].*$"
                If IsValid(Value, regStreet) Then
                    streetAddress = Value
                    count = count + 1
                Else
                    Throw New OrderSystemExceptions("An exception has occurred, Street address should start with a digit.")
                End If
            End Set
        End Property
        Public Property _city() As String
            Get
                ' Return the value stored in the local variable. 
                Return city
            End Get
            Set(ByVal Value As String)
                ' Store the value in a local variable.
                Dim regName As String = "^[a-z A-Z]*$"
                If IsValid(Value, regName) Then
                    city = Value
                    count = count + 1
                Else
                    Throw New OrderSystemExceptions("An exception has occurred, city name should contain only upper case and lower case alphabets.")
                End If
            End Set
        End Property
        Public Property _province() As String
            Get
                ' Return the value stored in the local variable. 
                Return province
            End Get
            Set(ByVal Value As String)
                ' Store the value in a local variable.
                Dim regProv As String = "^[A-Za-z]{2}$"
                If IsValid(Value, regProv) Then
                    province = Value
                    count = count + 1
                Else
                    Throw New OrderSystemExceptions("An exception has occurred, Province should be 2 alphabets.")
                End If
            End Set
        End Property
        Public Property _postalCode() As String
            Get
                ' Return the value stored in the local variable. 
                Return postalCode
            End Get
            Set(ByVal Value As String)
                ' Store the value in a local variable.
                Dim regPCode As String = "^([A-Za-z][0-9]){3}$"
                If IsValid(Value, regPCode) Then
                    postalCode = Value
                    count = count + 1
                Else
                    Throw New OrderSystemExceptions("An exception has occurred, Postal code should be of the form X1X1X1.")
                End If
            End Set
        End Property

        Public Property _email() As String
            Get
                ' Return the value stored in the local variable. 
                Return email
            End Get
            Set(ByVal Value As String)
                ' Store the value in a local variable.
                Dim regEmail1 As String = "^.+@.+\..+$"
                If IsValid(Value, regEmail1) Then
                    Dim subString As String = Right(Value, 4)
                    Dim ending As String = subString.Split(".")(1)
                    Dim regEnding As String = "com|ca|org|net|biz"
                    If IsValid(ending, regEnding) Then
                        email = Value
                        count = count + 1
                    Else
                        Throw New OrderSystemExceptions("An exception has occurred, email domains may only end in com/.ca/.org/.net/.biz/.")
                    End If

                Else
                    Throw New OrderSystemExceptions("An exception has occurred, email should have @ and .")
                End If
            End Set
        End Property

        Public Property _creditLimit() As Double
            Get
                ' Return the value stored in the local variable. 
                Return creditLimit
            End Get
            Set(ByVal Value As Double)
                ' Store the value in a local variable.

                If (Value > 0) Then
                    creditLimit = Value
                Else
                    Throw New OrderSystemExceptions("An exception has occurred, Credit can not be negative.")
                End If
            End Set
        End Property

        Sub New(ByVal custid1, ByVal firstname, ByVal lastname, ByVal street, ByVal city, ByVal province, ByVal postalcode, ByVal credit, ByVal email, ByVal phoneNumber)
            Me.custId = custid1
            _firstName = firstname
            _lastName = lastname
            _streetAddress = street
            _city = city
            _province = province
            _postalCode = postalcode
            _creditLimit = credit
            _email = email
            _phoneNum = phoneNumber
        End Sub
        Sub New(ByVal firstname, ByVal lastname, ByVal street, ByVal city, ByVal province, ByVal postalcode, ByVal credit, ByVal email, ByVal phoneNumber)

            _firstName = firstname
            _lastName = lastname
            _streetAddress = street
            _city = city
            _province = province
            _postalCode = postalcode
            _creditLimit = credit
            _email = email
            _phoneNum = phoneNumber
        End Sub

        Sub New()

        End Sub

        'imlements the IsValid from IValidator
        Public Function IsValid(ByVal testData As String, ByVal regex As String) As Boolean Implements IValidator.IsValid
            Dim r As Regex = New Regex(regex, RegexOptions.IgnoreCase)
            Dim m As Match = r.Match(testData)
            Return m.Success
        End Function

        Public Overrides Function ToString() As String
            Return String.Format("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}", custId, firstName, lastName, streetAddress, city, province, postalCode, creditLimit, email)
        End Function

        Public Function GetDetails() As String
            Dim result As String = Nothing
            'result = result + "Customer Infomation:" + vbCrLf
            result = result + "Customer Id: " & CStr(_custId) & vbCrLf
            result = result + "Customer Name: " + _firstName + " " + _lastName & vbCrLf
            result = result + "Address: " + _streetAddress + "," + _city + "," + _province + " " + _postalCode + vbCrLf
            result = result + "Email: " + _email + vbTab + "Credit Limit:" + CStr(_creditLimit)
            Return result
        End Function

        Public Event new_Customer()

    End Class

End Namespace

