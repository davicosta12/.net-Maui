using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAJD.Infra
{
    public class GetCompanyUser
    {
        public int groupId { get; set; }
        public int tenantId { get; set; }
        public int id { get; set; }
        public string userName { get; set; }
        public string? emailAddress { get; set; }
        public string? urlImage { get; set; }
        public string? phone { get; set; }
        //public int? profileId { get; set; }
        public List<int>? branchList { get; set; }
        public bool isAdmin { get; set; }
        public bool sysAdmin { get; set; }
        public bool corpAdmin { get; set; }
        public bool isSeller { get; set; } = false;
        public int sellerId { get; set; } = 0;
        public DateTime dataUpdate { get; set; }
        public bool isActive { get; set; }
    }
}
