using System;
using System.Collections.Generic;
using WatOpsFormLibV2.Models;

namespace WatOpsFormLibV2.Services
{
    public interface IFormRepo
    {
        IEnumerable<Form> GetForm(int formId);
        Form GetForm(object id);
    }
}
