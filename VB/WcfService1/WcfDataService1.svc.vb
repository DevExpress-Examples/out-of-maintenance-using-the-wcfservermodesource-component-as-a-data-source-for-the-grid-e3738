Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Data.Services
Imports System.Data.Services.Common
Imports System.Linq
Imports System.ServiceModel.Web
Imports System.Web

Namespace WcfService1
	Public Class WcfDataService1
		Inherits DataService(Of  AdventureWorksEntities )
		' This method is called only once to initialize service-wide policies.
		Public Shared Sub InitializeService(ByVal config As DataServiceConfiguration)
			' TODO: set rules to indicate which entity sets and service operations are visible, updatable, etc.
			' Examples:
			config.SetEntitySetAccessRule("*", EntitySetRights.AllRead)
			config.SetServiceOperationAccessRule("*", ServiceOperationRights.All)
			config.DataServiceBehavior.MaxProtocolVersion = DataServiceProtocolVersion.V2
		End Sub
	End Class
End Namespace
