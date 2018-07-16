<!DOCTYPE html>
<html>
<head runat="server">     
   <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
   <meta name="viewport" content="width=device-width, initial-scale=1.0">
   <title>Home page</title>
</head>
<body>
    <p style="margin-left: 480px">
        <label id="Welcom">Hello <%=HttpContext.Current.User.Identity.Name %></label> 
    </p>
</body>
</html>