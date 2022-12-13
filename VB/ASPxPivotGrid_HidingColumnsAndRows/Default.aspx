<%@ Page Language="vb" AutoEventWireup="true" CodeBehind="Default.aspx.vb"
    Inherits="ASPxPivotGrid_HidingColumnsAndRows._Default" %>
<%@ Register Assembly="DevExpress.Web.ASPxPivotGrid.v21.2, Version=21.2.12.0,
    Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.Web.ASPxPivotGrid"
    TagPrefix="dx" %>
<%@ Register assembly="DevExpress.Web.v21.2, Version=21.2.12.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <dx:ASPxRadioButtonList ID="ASPxRadioButtonList1" runat="server" SelectedIndex="0" AutoPostBack="true" >
            <Items>
                <dx:ListEditItem Text="Default Layout" Value="Default Layout" />
                <dx:ListEditItem Text="Delete All Rows Corresponding to &quot;Employee B&quot;" 
                    Value="Delete All Rows Corresponding to &quot;Employee B&quot;" />
            </Items>
        </dx:ASPxRadioButtonList>        
        <div>
            <dx:ASPxPivotGrid ID="pivotGrid" runat="server" Width="500px" 
                OnFieldValueDisplayText="pivotGrid_FieldValueDisplayText"
                OnCustomFieldValueCells="pivotGrid_CustomFieldValueCells"
                OptionsCustomization-AllowFilter="false"
                OptionsCustomization-AllowDrag="false"
                OptionsData-DataProcessingEngine="Optimized">
            </dx:ASPxPivotGrid>
        </div>
    </form>    
</body>

</html>