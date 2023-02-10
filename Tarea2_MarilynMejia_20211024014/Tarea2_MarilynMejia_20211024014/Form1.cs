using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea2_MarilynMejia_20211024014
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void Promedio_button_Click(object sender, EventArgs e)
        {
            //VALIDANDO ERRORES
            //NOMBRE VACIO 
            if (Name_textBox.Text==string.Empty)
            {
                errorProvider5.SetError(Name_textBox, "INGRESE EL NOMBRE DEL ALUMNO");
                return;
            }
            //NOTA 1
            if (PrimerNota_textBox.Text == string.Empty)
            {
                errorProvider1.SetError(PrimerNota_textBox, "INGRESE LA NOTA");
                return;
            }
            if(Convert.ToDecimal(PrimerNota_textBox.Text) > 100 || Convert.ToDecimal(PrimerNota_textBox.Text) < 0)
            {
                errorProvider1.SetError(PrimerNota_textBox, "VALOR INVALIDO, INTENTE DE NUEVO ");
                return;
            }
            //NOTA 2
            if (SegundaNota_textBox.Text == string.Empty)
            {
                errorProvider2.SetError(SegundaNota_textBox, "INGRESE LA NOTA");
                return;
            }
            if (Convert.ToDecimal(SegundaNota_textBox.Text) > 100 || Convert.ToDecimal(SegundaNota_textBox.Text) < 0)
            {
                errorProvider2.SetError(SegundaNota_textBox, "VALOR INVALIDO, INTENTE DE NUEVO ");
                return;
            }
            //NOTA 3
            if (TercerNota_textBox.Text == string.Empty)
            {
                errorProvider3.SetError(TercerNota_textBox, "INGRESE LA NOTA");
                return;
            }
            if (Convert.ToDecimal(TercerNota_textBox.Text) > 100 || Convert.ToDecimal(TercerNota_textBox.Text) < 0)
            {
                errorProvider3.SetError(TercerNota_textBox, "VALOR INVALIDO, INTENTE DE NUEVO ");
                return;
            }
            //NOTA 4
            if (Cuarta_NotatextBox.Text == string.Empty)
            {
                errorProvider4.SetError(Cuarta_NotatextBox, "INGRESE LA NOTA");
                return;
            }
            if (Convert.ToDecimal(Cuarta_NotatextBox.Text) > 100 || Convert.ToDecimal(Cuarta_NotatextBox.Text) < 0)
            {
                errorProvider4.SetError(Cuarta_NotatextBox, "VALOR INVALIDO, INTENTE DE NUEVO ");
                return;
            }

            //GUARDANDO LOS VALORES QUE  INGRESE EL USUARIO  EN VARIABLES
            decimal nota1 = Convert.ToDecimal(PrimerNota_textBox.Text);
            decimal nota2 = Convert.ToDecimal(SegundaNota_textBox.Text);
            decimal nota3= Convert.ToDecimal(TercerNota_textBox.Text);
            decimal nota4 = Convert.ToDecimal(Cuarta_NotatextBox.Text);
            String nombre, name = Name_textBox.Text;
            nombre = name.ToUpper();

            //LLAMAMOS AL METODO ASINCRONO
            decimal promedioTotal = await promedioFinalAsync(nota1, nota2, nota3, nota4);
           // MessageBox.Show("EL PROMEDIO DEL ALUMNO "+ nombre +" TOTAL ES DE: "+ promedioTotal);
            RespuestaP_textBox.Text = Convert.ToString(promedioTotal);
            RespuestaN_textBox.Text = nombre;
        }
        //FUNCION ASINCRONA
        private async Task<decimal> promedioFinalAsync(decimal n1, decimal n2, decimal n3, decimal n4)
        {
            decimal promedio = await Task.Run(() => 
            {
                return (n1 + n2 + n3 + n4) / 4;
            });
            return promedio;
        }
        //LIMPIANDO LA PANTALLA
        private void LIMPIAR_BUTTON_Click(object sender, EventArgs e)
        {
            PrimerNota_textBox.Clear();
            SegundaNota_textBox.Clear();
            TercerNota_textBox.Clear();
            Cuarta_NotatextBox.Clear();
            Name_textBox.Clear();
            RespuestaN_textBox.Clear();
            RespuestaP_textBox.Clear();

        }
    }
}
