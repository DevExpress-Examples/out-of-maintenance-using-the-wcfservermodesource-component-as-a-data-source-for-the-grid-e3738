Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Runtime.Serialization
Imports System.ServiceModel
Imports System.ServiceModel.Web
Imports System.Text

Namespace WcfService1
	' NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
	Public Class Service1
		Implements IService1
		Public Function GetData(ByVal value As Integer) As String Implements IService1.GetData
			Return String.Format("You entered: {0}", value)
		End Function

		Public Function GetDataUsingDataContract(ByVal composite As CompositeType) As CompositeType Implements IService1.GetDataUsingDataContract
			If composite Is Nothing Then
				Throw New ArgumentNullException("composite")
			End If
			If composite.BoolValue Then
				composite.StringValue &= "Suffix"
			End If
			Return composite
		End Function
	End Class
End Namespace
