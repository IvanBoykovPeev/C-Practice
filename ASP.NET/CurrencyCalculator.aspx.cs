using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class CurrencyCalculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Result_ServerClick(object sender, EventArgs e)
        {
            decimal USAmount = Decimal.Parse(US.Value);
            decimal euroAmount = USAmount * 0.85M;
            Result.InnerText = USAmount.ToString() + " U.S. dollars=";
            Result.InnerText += euroAmount.ToString() + " Euros.";
        }
    }
}