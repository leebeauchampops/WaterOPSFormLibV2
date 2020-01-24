using System;
using System.Collections.Generic;
using System.Text;
using WatOpsFormLibV2.Models;

namespace WatOpsFormLibV2.Services
{
    public interface IPwsRepo
    {
        IEnumerable<Pws> GetAllPws();
    }
}
