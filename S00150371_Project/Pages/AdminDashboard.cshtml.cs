using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HDip_project_S00150371_V2.Pages
{
    [Authorize]
    public class AdminDashboardModel : PageModel
    {
        public void OnGet()
        {

        }
    }
}