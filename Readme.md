<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128577545/10.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2767)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/ASPxPivotGrid_HidingColumnsAndRows/Default.aspx) (VB: [Default.aspx](./VB/ASPxPivotGrid_HidingColumnsAndRows/Default.aspx))
* [Default.aspx.cs](./CS/ASPxPivotGrid_HidingColumnsAndRows/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/ASPxPivotGrid_HidingColumnsAndRows/Default.aspx.vb))
<!-- default file list end -->
# How to hide particular rows and columns
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e2767/)**
<!-- run online end -->


<p>The following example demonstrates how to hide particular rows and columns by handling the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebASPxPivotGridASPxPivotGrid_CustomFieldValueCellstopic">CustomFieldValueCells Event</a>.</p>
<p>In this example, the event handler iterates through all row headers and removes rows that correspond to the "Employee B" field value, and that are not Total Rows.</p>

<br/>


