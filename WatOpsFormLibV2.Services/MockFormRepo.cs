using System;
using System.Collections.Generic;
using System.Text;
using WatOpsFormLibV2.Models;

namespace WatOpsFormLibV2.Services
{
    public class MockFormRepo : IFormRepo
    {
        private List<Form> _formlist;

        public MockFormRepo()
        {
            _formlist = new List<Form>()
            {
                new Form()
                {   FormId =1,
                    FormName = "Surface Water / GWUDI Monthly Compliance Determination",
                    FormPwsTyp = "Community",
                    FormState = FormState.MD,
                    FormWatSource = "Surface Water",
                    FormTypTime = "Monthly",
                    FormLocationPath ="MD_Bact_Mo_Rp.png"},

                new Form()
                {   FormId =2,
                    FormName = "Ground Water Rule Monitoring Report Form",
                    FormPwsTyp = "Community",
                    FormState = FormState.MD,
                    FormWatSource = "Ground Water",
                    FormTypTime = "Monthly",
                    FormLocationPath ="MD_GWR_Rp.png" },

                new Form()
                {   FormId =3,
                    FormName = "Bacteriological Monitoring Report Form",
                    FormPwsTyp = "Community",
                    FormState = FormState.MD,
                    FormWatSource = "Ground Water" + "Surface Water",
                    FormTypTime = "Monthly",
                    FormLocationPath ="MD_Bact_Mo_Rp.png" },

                new Form()
                {   FormId =4,
                    FormName = "Disinfectant Residual Monitoring Report Form",
                    FormPwsTyp = "Community",
                    FormState = FormState.MD,
                    FormWatSource = "Ground Water" + "Surface Water",
                    FormTypTime = "Quarterly"},

                new Form()
                {   FormId =5,
                    FormName = "Water Works Reporting Form",
                    FormPwsTyp = "Community",
                    FormState = FormState.DE,
                    FormWatSource = "Ground Water" + "Surface Water",
                    FormTypTime = "Monthly"},

                new Form()
                {   FormId =6,
                    FormName = "Water Works Reporting Form",
                    FormPwsTyp = "Community",
                    FormState = FormState.NY,
                    FormWatSource = "Ground Water" + "Surface Water",
                    FormTypTime = "Monthly"},

                new Form()
                {   FormId =7,
                    FormName = "Water Works Reporting Form",
                    FormPwsTyp = "Community",
                    FormState = FormState.PA,
                    FormWatSource = "Ground Water" + "Surface Water",
                    FormTypTime = "Monthly"},
            };
        }
        public IEnumerable<Form> GetForm()
        {
            return _formlist;
        }
    }
}
