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
    public class FormViewPageModel : PageModel
    {
        private readonly IFormRepo formRepo;

        public IEnumerable<Form> Forms { get; set; }

        public FormViewPageModel(IFormRepo formRepo)
        {
            this.formRepo = formRepo;
        }
        public void OnGet()
        {
            Forms = formRepo.GetForm();
        }
    }
}