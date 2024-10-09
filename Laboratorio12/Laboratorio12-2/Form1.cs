using System.Windows.Forms;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics.Tracing;

namespace Laboratorio12_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

         
            {
                double nota1, nota2, nota3;

                // intento de conversión manual utilizando tryparse
                bool isNota1Valid = double.TryParse(textBox1.Text, out nota1);
                bool isNota2Valid = double.TryParse(textBox2.Text, out nota2);
                bool isNota3Valid = double.TryParse(textBox3.Text, out nota3);

                if (isNota1Valid && isNota2Valid && isNota3Valid)
                {
                    // calcular el promedio si todas las notas son válidas
                    double promedio = (nota1 + nota2 + nota3) / 3;

                    // mostrar el promedio en el textbox4
                    textBox4.Text = promedio.ToString("0.00");
                }
                else
                {
                    // mostrar mensaje de error si alguna nota no es válida
                    MessageBox.Show("Por favor, ingrese números válidos en las notas.", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}