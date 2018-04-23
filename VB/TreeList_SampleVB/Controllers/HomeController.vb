Imports System.Web.Mvc

Namespace Controllers
    Public Class HomeController
        Inherits Controller

        Public Function Index() As ActionResult
            Return View()
        End Function

        Public Function TreeListPartial(ByVal Expand? As Boolean) As ActionResult
            ViewData("Expand") = Expand
            Return PartialView(DepartmentsProvider.GetDepartments())
        End Function
    End Class
End Namespace