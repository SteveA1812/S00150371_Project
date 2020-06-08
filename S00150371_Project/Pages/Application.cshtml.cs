using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using S00150371_Project.Data;
using S00150371_Project.Models;

namespace HDip_project_S00150371_V2.Pages
{
    [Authorize]

    public class ApplicationModel : PageModel
    {

        private readonly ApplicationDbContext _db;

        public ApplicationModel(ApplicationDbContext db)
        {
            _db = db;
        }



        [TempData]
        public string Message { get; set; }






        [BindProperty]
        public StaffApplication StaffApplication { get; set; } = new StaffApplication();






        public void OnGet()
        {

        }

        //public async Task<IActionResult> OnPostAsync()
        //{
           

        //    if (ModelState.IsValid)
        //    {
        //        _db.StaffApplication.Add(StaffApplication);
        //        await _db.SaveChangesAsync();
        //        Message = $"Your application has been submitted. You have stated that you will begin a course in  {StaffApplication.CourseName} to begin in {StaffApplication.StartYear} ";
        //        return RedirectToPage("Confirmation");

        //    }
        //    else
        //    {
        //        return Page();
        //    }
        //}
    }
}