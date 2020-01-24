using System;
using System.Collections.Generic;
using System.Text;

namespace WatOpsFormLibV2.Models
{
    public class Pws
    {
       
            public PwsId? PwsId { get; set; }
            public string PwsName { get; set; }
            public string PwsCounty { get; set; }
            public string PwsCity { get; set; }
            public string PwsState { get; set; }
            public string PwsWaterSource { get; set; }
            public double PwsPopServed { get; set; }
            public string PwsType { get; set; }
            public string PwsActivity { get; set; }




    }
}
