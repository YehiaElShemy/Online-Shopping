using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShopingStore.Areas.Admin.Model
{
    public class UserRoleMap
    {
        public string UserId { get; set; }
        public string RoleId { get; set; }
        public string Username { get; set; }
        public string RoleName { get; set; }
    }
}
