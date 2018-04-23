Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports WcfServerModeSourceDemo.ServiceReference1
Imports DevExpress.Data.WcfLinq

Namespace WcfServerModeSourceDemo
	Partial Public Class Form1
		Inherits Form
		Private db As AdventureWorksEntities
		Public Sub New()
			InitializeComponent()
			db = New AdventureWorksEntities(New Uri("http://localhost:61617/WcfDataService1.svc"))
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			gridControl1.DataSource = New WcfServerModeSource() With {.KeyExpression = "EmployeeID", .Query = db.Employee}
		End Sub
	End Class
End Namespace
