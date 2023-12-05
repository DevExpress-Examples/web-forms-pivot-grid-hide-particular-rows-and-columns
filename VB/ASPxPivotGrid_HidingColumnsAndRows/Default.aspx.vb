Imports System
Imports System.Globalization
Imports System.Web.UI
Imports DevExpress.Web.ASPxPivotGrid
Imports DevExpress.XtraPivotGrid

Namespace ASPxPivotGrid_HidingColumnsAndRows

    Public Partial Class _Default
        Inherits Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            If Not IsCallback AndAlso Not IsPostBack Then
                PivotHelper.FillPivot(pivotGrid)
            End If

            pivotGrid.DataSource = GetDataTable()
        End Sub

        ' Handles the CustomFieldValueCells event to remove
        ' specific rows.
        Protected Sub pivotGrid_CustomFieldValueCells(ByVal sender As Object, ByVal e As PivotCustomFieldValueCellsEventArgs)
            If pivotGrid.DataSource Is Nothing Then Return
            If ASPxRadioButtonList1.SelectedIndex = 0 Then Return
            ' Iterates through all row headers.
            For i As Integer = e.GetCellCount(False) - 1 To 0 Step -1
                Dim cell As FieldValueCell = e.GetCell(False, i)
                If cell Is Nothing Then Continue For
                ' If the current header corresponds to the "Employee B"
                ' field value, and is not the Total Row header,
                ' it is removed with all corresponding rows.
                If Equals(cell.Value, "Employee B") AndAlso cell.ValueType <> PivotGridValueType.Total Then e.Remove(cell)
            Next
        End Sub

        Protected Sub pivotGrid_FieldValueDisplayText(ByVal sender As Object, ByVal e As PivotFieldDisplayTextEventArgs)
            Return
            If e.Field Is pivotGrid.Fields(Month) Then
                e.DisplayText = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(CInt(e.Value))
            End If
        End Sub
    End Class
End Namespace
