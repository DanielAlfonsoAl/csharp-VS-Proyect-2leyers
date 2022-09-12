using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibNotas;

namespace AppNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double Nota1, Nota2, Nota3, Nota4;
            try
            {
                Nota1 = Convert.ToDouble(txtNota1.Text);
                Nota2 = Convert.ToDouble(txtNota2.Text);
                Nota3 = Convert.ToDouble(txtNota3.Text);
                Nota4 = Convert.ToDouble(txtNota4.Text);

                // Instanciar

                Notas objNotas = new Notas();

                objNotas.SetNota2 = Nota2;
                objNotas.SetNota3 = Nota3;
                objNotas.SetNota4 = Nota4;
                objNotas.SetNota1 = Nota1;

                if (!objNotas.Calcular_Prom())
                {
                    MessageBox.Show(objNotas.GetError);
                    objNotas = null;
                    return;
                }
                txtProm.Text = Convert.ToString(objNotas.GetPromedio);
                objNotas = null;
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
