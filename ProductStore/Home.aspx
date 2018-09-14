<!DOCTYPE html>
<html>
<head runat="server">     
   <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
   <meta name="viewport" content="width=device-width, initial-scale=1.0">
   <title>Home page</title>
</head>
<body>
    <p style="margin-left: 480px">
        <label id="Welcom">Hello, <%=ProductStore.Core.Context.User.UserName %> !</label> 
    </p>
</body>
</html>