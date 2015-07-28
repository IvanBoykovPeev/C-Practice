<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CurrencyCalculator.aspx.cs" Inherits="WebApplication1.CurrencyCalculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Currency Calculator</title>
</head>
<body>
    <form runat="server">
    <div>
    Convert: &nbsp;
        <input type="text" id="US" runat="server" />
        &nbsp; U.S. dollars to Euros.
        <br /><br />
        <input type="submit" value="OK" id="Convert" runat="server" 
            onserverclick="Result_ServerClick" />
        <br /><br />
        <p style="font-weight: bold" id="Result" runat="server"></p>
    </div>
    </form>
</body>
</html>
