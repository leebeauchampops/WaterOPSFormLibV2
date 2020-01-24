using System;
using System.Collections.Generic;
using System.Text;

namespace WatOpsFormLibV2.Models
{
    public class Form
    {
        public int FormId { get; set; }

        /// <summary>
        /// Is based on the State that requires that form
        /// </summary>

        public string FormName { get; set; }

        public FormState? FormState { get; set; }

        /// <summary>
        /// Determines what type of water supply - Ground water, surface water, SW/GWUDI
        /// </summary>
        public string FormWatSource { get; set; }

        /// <summary>
        /// Determine if the Form is for a community or non-community system
        /// </summary>
        public string FormPwsTyp { get; set; }


        /// <summary>
        /// FormTypTime is to decide if the form is for monthly, quartlery, yearly reporting
        /// </summary>
        public string FormTypTime { get; set; }

        public string FormLocationPath { get; set; }
    }
}
