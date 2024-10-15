using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado = 0;

            if (!double.TryParse(txtNum1.Text, out num1) ||
                (!double.TryParse(txtNum2.Text, out num2) && !RbRaiz.Checked))
            {
                MessageBox.Show("Por favor, ingrese números válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (RbSuma.Checked)
                resultado = num1 + num2;
            else if (RbResta.Checked)
                resultado = num1 - num2;
            else if (RbMultiplicacion.Checked)
                resultado = num1 * num2;
            else if (RbDivision.Checked)
            {
                if (num2 != 0)
                    resultado = num1 / num2;
                else
                {
                    MessageBox.Show("No se puede dividir por cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (RbRaiz.Checked)
            {
                if (num1 >= 0)
                    resultado = Math.Sqrt(num1);
                else
                {
                    MessageBox.Show("No se puede calcular la raíz cuadrada de un número negativo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            lblResultado.Text = $"Resultado: {resultado}";
        }

    }
}

