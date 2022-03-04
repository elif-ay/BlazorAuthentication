using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorAuthentication.Shared
{
    public class UserLoginDTO
    {
        public string UserName { get; set; } = String.Empty;

        public string Password { get; set; } = String.Empty;

    }
}
