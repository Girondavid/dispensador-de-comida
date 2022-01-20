using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dispen
{
    public class dinero
    {
        public int compra;
        public int numero1;
        public int numero2;
        public int numero3;
        public int numero4;
        public int numero5;
        public int numero6;
        public int numero7;
        public int numero8;
        public int numero9;
        public int operacion;
        public int resultado;
        
        public dinero()
        {
            this.numero1 = 2000;
            this.numero2 = 2000;
            this.numero4 = 2000;
            this.numero6 = 2000;
            this.numero7 = 2500;
            this.numero8 = 3000;
            this.numero9 = 3500;
        }

        public void restar()
        {
            if (this.compra == numero8)
            {
                operacion = this.compra - this.numero8;
            }else if (this.compra >= numero1)
            {
                operacion = this.compra - this.numero1;
            }
            else
            {
                MessageBox.Show("error");
            }
        }
    }
}
