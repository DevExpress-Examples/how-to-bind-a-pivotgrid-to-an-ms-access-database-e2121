﻿Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.OleDb
Imports System.Windows
Imports DevExpress.Xpf.PivotGrid
Imports HowToBindToMDB.NwindDataSetTableAdapters

Namespace HowToBindToMDB
	Partial Public Class MainWindow
		Inherits Window
		Private salesPersonDataTable As New NwindDataSet.SalesPersonDataTable()
		Private salesPersonDataAdapter As New SalesPersonTableAdapter()

		Public Sub New()
			InitializeComponent()
			pivotGridControl1.DataSource = salesPersonDataTable
		End Sub

		Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			salesPersonDataAdapter.Fill(salesPersonDataTable)
		End Sub
	End Class
End Namespace
