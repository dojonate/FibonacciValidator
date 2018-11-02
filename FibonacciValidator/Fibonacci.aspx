<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Fibonacci.aspx.cs" Inherits="FibonacciValidator.Views.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Fibonacci</title>
    <link href="main.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox runat="server" ID="userInput" TextMode="Number" OnTextChanged="userInput_TextChanged"></asp:TextBox>
            <asp:Label runat="server" ID="inputLabel" Text="Input a positive integer!"></asp:Label>
            <br />
            <!--<asp:RegularExpressionValidator runat="server" ID="minValidator" ControlToValidate="userInput" 
                EnableClientScript="false" ErrorMessage="Must be positive integer" CssClass="validators" 
                ValidationExpression="\d+$"></asp:RegularExpressionValidator>-->
            <asp:CustomValidator runat="server" ID="inputValidator" ControlToValidate="userInput" 
                EnableClientScript="false" Text="Must be a smaller integer" CssClass="validators"
                OnServerValidate="checkRange" Display="Dynamic"></asp:CustomValidator>
            <br />
            <asp:Label runat="server" ID="output" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
