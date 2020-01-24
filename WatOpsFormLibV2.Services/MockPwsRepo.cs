using System;
using System.Collections.Generic;
using System.Text;
using WatOpsFormLibV2.Models;

namespace WatOpsFormLibV2.Services
{
    public class MockPwsRepo :IPwsRepo
    {
        private List<Pws> _pwslist;

        public MockPwsRepo()
        {
            _pwslist = new List<Pws>()
            {
                new Pws()
                 {  PwsId = PwsId.MD0300002,
                    PwsName = "CITY OF BALTIMORE",
                    PwsCounty = "BALTIMORE CITY",
                    PwsCity = "NOT REPORTED",
                    PwsState = "MD",
                    PwsWaterSource = "Surface water",
                    PwsPopServed = 1600000,
                    PwsType = "CWS",
                    PwsActivity = "Active"},

                new Pws()
                 {  PwsId = PwsId.MD0220004,
                    PwsName = "CITY OF SALISBURY",
                    PwsCounty = "WICOMICO",
                    PwsCity = "NOT REPORTED",
                    PwsState = "MD",
                    PwsWaterSource = "Ground water",
                    PwsPopServed = 30343,
                    PwsType = "CWS",
                    PwsActivity = "Active"},

                new Pws()
                 {  PwsId = PwsId.NY5903423,
                    PwsName = "CORTLANDT CONSOLIDATED WD",
                    PwsCounty = "WESTCHESTER",
                    PwsCity = "CORTLANDT (T)",
                    PwsState = "NY",
                    PwsWaterSource = "Surface water purchased",
                    PwsPopServed = 28369,
                    PwsType = "CWS",
                    PwsActivity = "Active"},

                new Pws()
                 {  PwsId = PwsId.DE0000597,
                    PwsName = "LAUREL WATER DEPARTMENT",
                    PwsCounty = "SUSSEX",
                    PwsCity = "LAUREL",
                    PwsState = "DE",
                    PwsWaterSource = "Ground water",
                    PwsPopServed = 3984,
                    PwsType = "CWS",
                    PwsActivity = "Active"},
            };
        }
       

        public IEnumerable<Pws> GetAllPws()
        {
            return _pwslist;
        }
    }
}
