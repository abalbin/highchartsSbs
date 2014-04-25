<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Demo1.aspx.cs" Inherits="HighchartsSbs.Demo.Demo1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-1.7.1.js"></script>
    <script src="Scripts/highcharts.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div id="container" style="width:100%; height:400px;"></div>
            <asp:Literal ID="ltrChart" runat="server"></asp:Literal>
        </div>
    </form>
</body>
</html>
