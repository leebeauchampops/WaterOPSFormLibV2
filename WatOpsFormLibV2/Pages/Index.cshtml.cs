using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WatOpsFormLibV2.Models;
using WatOpsFormLibV2.Services;

namespace WatOpsFormLibV2.Pages
{
    public class IndexModel : PageModel
    {
         private readonly ILogger<IndexModel> _logger;

         public IndexModel(ILogger<IndexModel> logger)
         {
             _logger = logger;
         }

        //private readonly IPwsRepo pwsRepo;

       //public IEnumerable<Pws> Pws { get; set; }

       // public IndexModel(IPwsRepo pwsRepo)
        // {
         // this.pwsRepo = pwsRepo;
        // }
        public void OnGet()
        {

           // Pws = pwsRepo.GetAllPws();
        }
    }
}
