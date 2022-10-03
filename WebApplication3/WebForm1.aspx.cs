using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[,] ia_2Mindex = new int[2, 3]
            {
                {1,2,3 },
                {4,5,6 }
            };
            mt_PrintArray(ia_2Mindex);                       
        }
        void mt_PrintArray(int[,] ia_2Mindex)
        {
            for (int i = 0; i < ia_2Mindex.GetLength(0); i++)
            {
                for (int j = 0; j < ia_2Mindex.GetLength(1); j++)
                {
                    Response.Write(ia_2Mindex[i, j].ToString());
                }
            }
            

        }
    }
}