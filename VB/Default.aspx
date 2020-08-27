<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v16.1, Version=16.1.17.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <dx:ASPxGridView ID="grid" KeyFieldName="ProductID" runat="server" OnRowUpdating="grid_RowUpdating" OnRowInserting="grid_RowInserting" OnRowDeleting="grid_RowDeleting">
            <Columns>
                <dx:GridViewCommandColumn ShowEditButton="true" ShowNewButtonInHeader="true" ShowDeleteButton="true"></dx:GridViewCommandColumn>
                <dx:GridViewDataDateColumn FieldName="StartDate">
                </dx:GridViewDataDateColumn>
                <dx:GridViewDataDateColumn FieldName="EndDate">
                    <PropertiesDateEdit>
                        <DateRangeSettings StartDateEditID="StartDate"/>
                    </PropertiesDateEdit>
                </dx:GridViewDataDateColumn>
            </Columns>

        </dx:ASPxGridView>
    </div>
    </form>
</body>
</html>