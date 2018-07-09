using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductStore
{
   

public class User
  {
    public Guid Id { get; }
    public string UserName { get; }
    public string Password { get; }

    public static void GetByCredentials(string userName, string password)
    {
    }


  }
}