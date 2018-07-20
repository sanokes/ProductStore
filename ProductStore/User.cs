using System;

namespace ProductStore
{


  public class User
  {
    public Guid Id { get; }
    public string UserName { get; }
    public string Password { get; }

    public static void  GetByCredentials(string password, string userName)
    {

    }
  }
}