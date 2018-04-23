Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
        grid.DataSource = Enumerable.Range(0, 10).Select(Function(x) New SomeData With {.ProductID = x, .StartDate = Date.Now, .EndDate = Date.Now})
        grid.DataBind()
    End Sub
    Protected Sub grid_RowUpdating(ByVal sender As Object, ByVal e As DevExpress.Web.Data.ASPxDataUpdatingEventArgs)
        e.Cancel = True
    End Sub
    Protected Sub grid_RowInserting(ByVal sender As Object, ByVal e As DevExpress.Web.Data.ASPxDataInsertingEventArgs)
        e.Cancel = True
    End Sub
    Protected Sub grid_RowDeleting(ByVal sender As Object, ByVal e As DevExpress.Web.Data.ASPxDataDeletingEventArgs)
        e.Cancel = True
    End Sub

End Class
Public Class SomeData
    Public Property ProductID() As Integer
    Public Property StartDate() As Date
    Public Property EndDate() As Date
End Class