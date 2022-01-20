using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dispen
{
    public partial class Form1 : Form
    {
        public dinero dinero;        
        public Form1()
        {
            dinero = new dinero();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.resulcodigo.Text = this.resulcodigo.Text + "A";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.resulcodigo.Text = this.resulcodigo.Text + "B";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.resulcodigo.Text = this.resulcodigo.Text + "C";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.resulcodigo.Text = this.resulcodigo.Text + "1";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.resulcodigo.Text = this.resulcodigo.Text + "2";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.resulcodigo.Text = this.resulcodigo.Text + "3";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.resulcodigo.Text = this.resulcodigo.Text + "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            resulcodigo.Clear();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void baceptar_TextChanged(object sender, EventArgs e)
        {
            this.dinero.numero1 = '0';
            if (this.dinero.numero1 == -1)
            {
                this.dinero.numero1 = Convert.ToInt32(this.dineroponer.Text);
                this.dineroponer.Text = "";
            }
            else
            {
                
            }
        }

        private void maspapapo_Click(object sender, EventArgs e)
        {
            this.tpapaspo.Text = this.tpapaspo.Text + "10";
        }

        private void maspapana_Click(object sender, EventArgs e)
        {
            this.tpapasna.Text = this.tpapasna.Text + "10";

        }

        private void maspapali_Click(object sender, EventArgs e)
        {
            this.tpapasli.Text = this.tpapasli.Text + "10";
        }

        private void maspepsi_Click(object sender, EventArgs e)
        {
            this.tpepse.Text = this.tpepse.Text + "10";
        }

        private void mascoca_Click(object sender, EventArgs e)
        {
            this.tcoca.Text = this.tcoca.Text = "10";
        }

        private void mascifrut_Click(object sender, EventArgs e)
        {
            this.tcifrut.Text = this.tcifrut.Text + "10";
        }

        private void masyumbo_Click(object sender, EventArgs e)
        {
            this.tyumbo.Text = this.tyumbo.Text + "10";
        }

        private void mastrululu_Click(object sender, EventArgs e)
        {
            this.ttrululu.Text = this.ttrululu.Text + "10";
        }

        private void maschocorra_Click(object sender, EventArgs e)
        {
            this.tchocorr.Text = this.tchocorr.Text + "10";
        }

        private void masagua_Click(object sender, EventArgs e)
        {
            this.tagua.Text = this.tagua.Text + "10";
        }

        public void btacep_Click(object sender, EventArgs e)
        {
            if (this.tpapaspo.Text == "")
            {
                MessageBox.Show("error");
                this.resulcodigo.Clear();

            }
            else if (this.dineroponer.Text == "AB")
            {
                MessageBox.Show("error");
                this.resulcodigo.Clear();
            }
            else if (this.resulcodigo.Text == "A1")
            {
                MessageBox.Show("papas de pollo enviada");
                this.resulcodigo.Clear();
            }
            else if (this.resulcodigo.Text == "A2")
            {
                MessageBox.Show("papas natural enviada");
                this.resulcodigo.Clear();
            }
            else if (this.resulcodigo.Text == "A3")
            {
                MessageBox.Show("papas de limon enviada");
                this.resulcodigo.Clear();
            }
            else if (this.resulcodigo.Text == "B1")
            {
                MessageBox.Show("pepsi enviada");
                this.resulcodigo.Clear();
            }
            else if (this.resulcodigo.Text == "B2")
            {
                MessageBox.Show("coca-cola enviada");
                this.resulcodigo.Clear();
            }
            else if (this.resulcodigo.Text == "B3")
            {
                MessageBox.Show("cifrut enviado");
                this.resulcodigo.Clear();
            }
            else if (this.resulcodigo.Text == "C1")
            {
                MessageBox.Show("Jumbo enviado");
                this.resulcodigo.Clear();
            }
            else if (this.resulcodigo.Text == "C2")
            {
                MessageBox.Show("trululu enviado");
                this.resulcodigo.Clear();
            }
            else if (this.resulcodigo.Text == "C3")
            {
                this.dinero.numero3 = Convert.ToInt32(this.resulcodigo.Text);
                MessageBox.Show("chocorramo enviado");
                this.resulcodigo.Clear();
            }
            else if (this.resulcodigo.Text == "C4")
            {
                MessageBox.Show("botella de agua enviada");
                this.resulcodigo.Clear();
            }
        }

        private void cancelarbtn_Click(object sender, EventArgs e)
        {
            this.dineroponer.Clear();
        }

        private void baceptar_Click(object sender, EventArgs e)
        {
            this.dinero.compra = Convert.ToInt32(this.dineroponer.Text);
            this.dineroponer.Text = "";
            this.dinero.restar();
            this.dineroponer.Text = this.dinero.operacion.ToString();

        }

        public void resulcodigo_TextChanged(object sender, EventArgs e)
        {   
        }

        private void retirar_Click(object sender, EventArgs e)
        {
            this.dinero.compra = Convert.ToInt32(this.dineroponer.Text);
            this.dineroponer.Text = "";
            this.tresidu.Text = this.dinero.operacion.ToString();
        }

        private void tresidu_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.tresidu.Clear();
        }
    }
}
