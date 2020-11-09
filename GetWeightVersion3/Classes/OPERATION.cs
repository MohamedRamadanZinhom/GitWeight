using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetWeightVersion3.Classes
{
    interface OPERATION
    {

         OPERATION Get_Query();
         void Set_Query();
         void Reset_Query( );
         void Remove( );

    }
}
