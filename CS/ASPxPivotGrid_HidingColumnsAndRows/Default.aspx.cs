using System;
using System.Globalization;
using System.Web.UI;
using DevExpress.Web.ASPxPivotGrid;
using DevExpress.XtraPivotGrid;

namespace ASPxPivotGrid_HidingColumnsAndRows {
    public partial class _Default : Page {
        protected void Page_Load(object sender, EventArgs e) {
            if (!IsCallback && !IsPostBack) {
                PivotHelper.FillPivot(pivotGrid);
            }
            pivotGrid.DataSource = PivotHelper.GetDataTable();
        }

        // Handles the CustomFieldValueCells event to remove
        // specific rows.
        protected void pivotGrid_CustomFieldValueCells(object sender,
                             PivotCustomFieldValueCellsEventArgs e) {
                                
            if (pivotGrid.DataSource == null) return;
            if (ASPxRadioButtonList1.SelectedIndex == 0) return;

            // Iterates through all row headers.
            for (int i = e.GetCellCount(false) - 1; i >= 0; i--) {
                FieldValueCell cell = e.GetCell(false, i);
                if (cell == null) continue;

                // If the current header corresponds to the "Employee B"
                // field value, and is not the Total Row header,
                // it is removed with all corresponding rows.
                if (object.Equals(cell.Value, "Employee B") &&
                    cell.ValueType != PivotGridValueType.Total)
                    e.Remove(cell);
            }
        }
        protected void pivotGrid_FieldValueDisplayText(object sender, 
                                    PivotFieldDisplayTextEventArgs e) {
                                        return;
            if (e.Field == pivotGrid.Fields[PivotHelper.Month]) {
                e.DisplayText = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName((int)e.Value);
            }
        }
    }
}
