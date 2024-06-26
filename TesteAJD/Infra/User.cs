using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAJD.Infra
{
    public class CompanyUserToken
    {
        public GetCompanyUser user { get; set; }
        public string token { get; set; }
        public DateTime validToken { get; set; }
    }

    public class AuthenticationModel
    {
        [Required]
        public string user { get; set; }

        [Required]
        public string password { get; set; }
    }
}
