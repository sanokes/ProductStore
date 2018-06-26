<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login2.aspx.cs" Inherits="WebApplication3.Login" %>

<!DOCTYPE html>

<html lang="en">
<head>
    <meta charset="utf-8">
	<meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">
	<title>Вход на сайт</title>
	<link rel="stylesheet" href="Content/StyleSheet1.css">
	<link rel="icon" href="http://www.audit4web.ru/ico/bqw.gif" type="image/x-icon">
	<link rel="shortcut icon" href="http://www.audit4web.ru/ico/bqw.gif" type="image/x-icon">
 </head>
<body>
   <form method="post" action="" class="login">
    <p>
      <label for="UserName">UserName:</label>
      <input type="text" name="txtlogin" id="TextBox1" value="">
    </p>
    <p>
      <label for="Password">Password:</label> 
      <input type="password" name="txtpass" id="TextBox2" value="">
    </p>

    <p class="login-submit">
      
         <button type="submit" class="login-button"> <a href="http://localhost:61217/Home.aspx"></a>Войти</button>
    </p>
    <div class="Label1">Wrong pass or name</div>
     <!--  <p class="forgot-password"><a href="index.html">Забыл пароль?</a></p>-->
       </form>
</body>
</html>
