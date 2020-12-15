using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEDInterfaces
{
    public class SeccionSubpotencial
    {
        private RadioButton2 rbOpcionSi;
        private RadioButton2 rbOpcionNo;

        public SeccionSubpotencial()
        {
        }

        public RadioButton2 RbOpcionSi { get => rbOpcionSi; set => rbOpcionSi = value; }
        public RadioButton2 RbOpcionNo { get => rbOpcionNo; set => rbOpcionNo = value; }
    }
}
