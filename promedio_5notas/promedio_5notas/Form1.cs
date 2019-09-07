using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace promedio_5notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



          
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {

            string nota1 = txtnota1.Text;
            string nota2 = txtnota2.Text;
            string nota3 = txtnota3.Text;
            string nota4 = txtnota4.Text;
            string nota5 = txtnota5.Text;
            string promedio = lblresultado.Text;

            float not1 = float.Parse(nota1);
            float not2 = float.Parse(nota2);
            float not3 = float.Parse(nota3);
            float not4 = float.Parse(nota4);
            float not5 = float.Parse(nota5);
            float prom = (not1 + not2 + not3 + not4 + not5) / 5;

            if (prom >= 3.5){

                lblresultado.Text = prom.ToString();
                lblpasoono.Text = " has superado la materia ";
                lblresultado.Visible = true;
                lblpasoono.Visible = true;
                lblpasoono.ForeColor = Color.Blue;

            }else{

                lblresultado.Text = prom.ToString();
                lblpasoono.Text = " No superaste la competencia de la materia";
                lblresultado.Visible = true;
                lblpasoono.Visible = true;
                lblpasoono.ForeColor = Color.Red;
            }


        }
    }
}
