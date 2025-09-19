using Microsoft.AspNetCore.Identity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regal.Domain.Entities.Users
{
    public class User : IdentityUser
    {
        public string Fullname { get; set; }
    }
}
