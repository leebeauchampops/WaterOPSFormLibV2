using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WatOpsFormLibV2.Models;
using WatOpsFormLibV2.Services;

namespace WatOpsFormLibV2.Pages.FormView
{

    public class FormFillPageModel : PageModel
        {
        private readonly IFormRepo formRepo;

        public FormFillPageModel(IFormRepo formRepo)
        {
            this.formRepo = formRepo;
        }

        public Form Form { get; set; }



        public IActionResult OnGet(int formid)
            {
            
            if(Form == null)
            {
                return RedirectToPage("Error");
            }

            return Page();
            }
    }

}