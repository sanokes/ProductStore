using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductStore.Core
{
    public class Context
    {
        public static User User
        {
            get
            {
                if (HttpContext.Current.User.Identity.IsAuthenticated)
                {
                    var user = (User)HttpContext.Current.Session["User"];
                    if (user == null)
                    {
                        user = User.GetByUserName(HttpContext.Current.User.Identity.Name);
                        HttpContext.Current.Session["User"] = user;
                    }
                    return user;
                }
                return null;
            }
        }
    }
}