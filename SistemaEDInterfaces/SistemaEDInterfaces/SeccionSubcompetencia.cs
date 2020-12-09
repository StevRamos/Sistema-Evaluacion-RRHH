using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SistemaEDInterfaces
{
    public class SeccionSubcompetencia
    {
        private RadioButton2 rbNota1;
        private RadioButton2 rbNota2;
        private RadioButton2 rbNota3;
        private RadioButton2 rbNota4;
        private RadioButton2 rbNota5;

        public SeccionSubcompetencia()
        {
        }   

        public RadioButton2 RbNota1 { get => rbNota1; set => rbNota1 = value; }
        public RadioButton2 RbNota2 { get => rbNota2; set => rbNota2 = value; }
        public RadioButton2 RbNota3 { get => rbNota3; set => rbNota3 = value; }
        public RadioButton2 RbNota4 { get => rbNota4; set => rbNota4 = value; }
        public RadioButton2 RbNota5 { get => rbNota5; set => rbNota5 = value; }
    }
}
