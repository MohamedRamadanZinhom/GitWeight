using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetWeightVersion3.Model
{
    class Scale
    {

        public string F_Scale { get; set; }
        public string S_Scale { get; set; }
        public string Price { get; set; }
        public string Emp_Id { get; set; }
        public string Carid { get; set; }
        public string Caridchar { get; set; }
        public string Clear_Scale { get; set; }
        public string F_Date { get; set; }
        public string S_Date { get; set; }
        public string F_Time { get; set; }
        public string S_Time { get; set; }

        private string C_Scale { get; set; }

        public string calculateclear()
        {

          return  this.C_Scale =  Math.Abs(float.Parse(F_Scale) - float.Parse(S_Scale)).ToString();
           
        }

    }
}
