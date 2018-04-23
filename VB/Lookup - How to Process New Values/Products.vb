﻿Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System.Collections.ObjectModel

Public Class Product
	Private privateProductName As String
	Public Property ProductName() As String
		Get
			Return privateProductName
		End Get
		Set(ByVal value As String)
			privateProductName = value
		End Set
	End Property
	Private privateCountry As String
	Public Property Country() As String
		Get
			Return privateCountry
		End Get
		Set(ByVal value As String)
			privateCountry = value
		End Set
	End Property
	Private privateCity As String
	Public Property City() As String
		Get
			Return privateCity
		End Get
		Set(ByVal value As String)
			privateCity = value
		End Set
	End Property
	Private privateUnitPrice As Double
	Public Property UnitPrice() As Double
		Get
			Return privateUnitPrice
		End Get
		Set(ByVal value As Double)
			privateUnitPrice = value
		End Set
	End Property
	Private privateQuantity As Integer
	Public Property Quantity() As Integer
		Get
			Return privateQuantity
		End Get
		Set(ByVal value As Integer)
			privateQuantity = value
		End Set
	End Property
End Class

Public Class ProductList
	Inherits ObservableCollection(Of Product)
	Public Sub New()
		MyBase.New()
		Add(New Product() With {.ProductName = "Chang", .Country = "UK", .City = "Cowes", .UnitPrice = 19, .Quantity = 10})
		Add(New Product() With {.ProductName = "Gravad lax", .Country = "Italy", .City = "Reggio Emilia", .UnitPrice = 12.5, .Quantity = 16})
		Add(New Product() With {.ProductName = "Ravioli Angelo", .Country = "Brazil", .City = "Rio de Janeiro", .UnitPrice = 19, .Quantity = 12})
		Add(New Product() With {.ProductName = "Tarte au sucre", .Country = "Germany", .City = "QUICK-Stop", .UnitPrice = 22, .Quantity = 50})
		Add(New Product() With {.ProductName = "Steeleye Stout", .Country = "USA", .City = "Reggio Emilia", .UnitPrice = 18, .Quantity = 20})
		Add(New Product() With {.ProductName = "Pavlova", .Country = "Austria", .City = "Graz", .UnitPrice = 21, .Quantity = 52})
		Add(New Product() With {.ProductName = "Longlife Tofu", .Country = "USA", .City = "Boise", .UnitPrice = 7.75, .Quantity = 120})
		Add(New Product() With {.ProductName = "Alice Mutton", .Country = "Mexico", .City = "México D.F.", .UnitPrice = 21, .Quantity = 15})
		Add(New Product() With {.ProductName = "Alice Mutton", .Country = "Canada", .City = "Tsawwassen", .UnitPrice = 44, .Quantity = 16})
	End Sub
End Class
