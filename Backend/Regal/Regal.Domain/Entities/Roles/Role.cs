using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regal.Domain.Entities.Roles
{
    public class Role : IdentityRole
    {
        public string Description { get; set; }
    }
}
