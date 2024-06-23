using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteAJD.Services
{
    public interface INavigationService
    {
        Task NavigateToAsync(string ContentPageName, IDictionary<string, object> parameters = null);
    }
}
