Imports Microsoft.VisualBasic
Imports System
Imports System.Globalization
Imports System.Web.UI
Imports DevExpress.Web.ASPxPivotGrid
Imports DevExpress.XtraPivotGrid

Namespace ASPxPivotGrid_HidingColumnsAndRows
	Partial Public Class _Default
		Inherits Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			If (Not IsCallback) AndAlso (Not IsPostBack) Then
				PivotHelper.FillPivot(pivotGrid)
			End If
			pivotGrid.DataSource = PivotHelper.GetDataTable()
		End Sub

		' Handles the CustomFieldValueCells event to remove
		' specific rows.
        Protected Sub pivotGrid_CustomFieldValueCells(ByVal sender As Object, _
                                ByVal e As PivotCustomFieldValueCellsEventArgs)
            If pivotGrid.DataSource Is Nothing Then
                Return
            End If
            If radioButtonList.SelectedIndex = 0 Then
                Return
            End If

            ' Iterates through all row headers.
            For i As Integer = e.GetCellCount(False) - 1 To 0 Step -1
                Dim cell As FieldValueCell = e.GetCell(False, i)
                If cell Is Nothing Then Continue For

                ' If the current header corresponds to the "Employee B"
                ' field value, and is not the Total Row header,
                ' it is removed with all corresponding rows.
                If Object.Equals(cell.Value, "Employee B") AndAlso _
                        cell.ValueType <> PivotGridValueType.Total Then
                    e.Remove(cell)
                End If
            Next i
        End Sub
        Protected Sub pivotGrid_FieldValueDisplayText(ByVal sender As Object, _
                                        ByVal e As PivotFieldDisplayTextEventArgs)
            If e.Field Is pivotGrid.Fields(PivotHelper.Month) Then
                e.DisplayText = _
                    CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(CInt(Fix(e.Value)))
            End If
        End Sub
    End Class
End Namespace
