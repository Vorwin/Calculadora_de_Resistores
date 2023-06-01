using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class MenuColor : Form
    {
        // se usa ',' para verificar que no este vacio el string
        String banda1 = ",";
        String banda2 = ",";
        String multiplicador = ",";
        String tolerancia = ",";
        String resultado = ",";

        public MenuColor()
        {
            InitializeComponent();
        }

        //Cerrar programa
        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Quieres cerrar el programa?", "Saliendo...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        //Regresar al menu
        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_menu menu = new form_menu();
            menu.ShowDialog();
        }

        //cambiar color a la banda 1 
        private void cambio_color_banda1(object sender, EventArgs e)
        {
            String color = Cbox_Banda1.Text;

            switch (color)
            {
                case "Negro":
                    Banda1_color.BackColor = Color.Black;
                    banda1 = "0";
                    break;

                case "Café":
                    Banda1_color.BackColor = Color.SaddleBrown;
                    banda1 = "1";
                    break;

                case "Rojo":
                    Banda1_color.BackColor = Color.Red;
                    banda1 = "2";
                    break;

                case "Naranja":
                    Banda1_color.BackColor = Color.Orange;
                    banda1 = "3";
                    break;

                case "Amarillo":
                    Banda1_color.BackColor = Color.Yellow;
                    banda1 = "4";
                    break;

                case "Verde":
                    Banda1_color.BackColor = Color.Green;
                    banda1 = "5";
                    break;

                case "Azul":
                    Banda1_color.BackColor = Color.Blue;
                    banda1 = "6";
                    break;

                case "Violeta":
                    Banda1_color.BackColor = Color.Violet;
                    banda1 = "7";
                    break;

                case "Gris":
                    Banda1_color.BackColor = Color.Gray;
                    banda1 = "8";
                    break;

                case "Blanco":
                    Banda1_color.BackColor = Color.White;
                    banda1 = "9";
                    break;
            }
        }

        //cambiar color a la banda 2
        private void cambio_color_banda2(object sender, EventArgs e)
        {
            String color = Cbox_Banda2.Text;

            switch (color)
            {
                case "Negro":
                    Banda2_color.BackColor = Color.Black;
                    banda2 = "0";
                    break;

                case "Café":
                    Banda2_color.BackColor = Color.SaddleBrown;
                    banda2 = "1";
                    break;

                case "Rojo":
                    Banda2_color.BackColor = Color.Red;
                    banda2 = "2";
                    break;

                case "Naranja":
                    Banda2_color.BackColor = Color.Orange;
                    banda2 = "3";
                    break;

                case "Amarillo":
                    Banda2_color.BackColor = Color.Yellow;
                    banda2 = "4";
                    break;

                case "Verde":
                    Banda2_color.BackColor = Color.Green;
                    banda2 = "5";
                    break;

                case "Azul":
                    Banda2_color.BackColor = Color.Blue;
                    banda2 = "6";
                    break;

                case "Violeta":
                    Banda2_color.BackColor = Color.Violet;
                    banda2 = "7";
                    break;

                case "Gris":
                    Banda2_color.BackColor = Color.Gray;
                    banda2 = "8";
                    break;

                case "Blanco":
                    Banda2_color.BackColor = Color.White;
                    banda2 = "9";
                    break;
            }
        }

        //cambiar color al multiplicador
        private void cambio_color_Multi(object sender, EventArgs e)
        {
            String color = Cbox_multi.Text;

            switch (color)
            {
                case "Negro":
                    multi_color.BackColor = Color.Black;
                    multiplicador = "";
                    break;

                case "Café":
                    multi_color.BackColor = Color.SaddleBrown;
                    multiplicador = "0";
                    break;

                case "Rojo":
                    multi_color.BackColor = Color.Red;
                    multiplicador = "00";
                    break;

                case "Naranja":
                    multi_color.BackColor = Color.Orange;
                    multiplicador = "K";
                    break;

                case "Amarillo":
                    multi_color.BackColor = Color.Yellow;
                    multiplicador = "0K";
                    break;

                case "Verde":
                    multi_color.BackColor = Color.Green;
                    multiplicador = "00K";
                    break;

                case "Azul":
                    multi_color.BackColor = Color.Blue;
                    multiplicador = "M";
                    break;


                case "Dorado":
                    multi_color.BackColor = Color.Gold;
                    multiplicador = " "; // se coloca el string vacio para realizar el calculo del multiplicador
                    break;

                case "Plateado":
                    multi_color.BackColor = Color.Silver;
                    multiplicador = " "; // se coloca el string vacio para realizar el calculo del multiplicador
                    break;

            }
        }

        //cambiar color a la tolerancia
        private void cambio_color_tolerancia(object sender, EventArgs e)
        {
            String color = Cbox_tolerancia.Text;

            switch (color)
            {
                case "Café":
                    tolerancia_color.BackColor = Color.SaddleBrown;
                    tolerancia = " ±1%";
                    break;

                case "Rojo":
                    tolerancia_color.BackColor = Color.Red;
                    tolerancia = " ±2%";
                    break;

                case "Dorado":
                    tolerancia_color.BackColor = Color.Gold;
                    tolerancia = " ±5%";
                    break;

                case "Plateado":
                    tolerancia_color.BackColor = Color.Silver;
                    tolerancia = " ±10%";
                    break;

                case "Sin banda":
                    tolerancia_color.BackColor = Color.Black;
                    tolerancia = " ±20%";
                    break;
            }
        }

        //calcular la resitencia
        private void btn_calcular_Click(object sender, EventArgs e)
        {
            //algun campo vacio, pide ser llenado

            if (tolerancia == "," || multiplicador == "," || banda2 == "," || banda1 == ",")
            {
                MessageBox.Show("Rellene todas las opciones", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // calcular el multiplicador 0.1
                if (Cbox_multi.Text == "Dorado")
                {
                    String aux = banda1 + banda2;
                    double aux2 = Double.Parse(aux) * 0.1;
                    multiplicador = aux2.ToString();
                    resultado = multiplicador + " Ω" + tolerancia;
                    lbl_resultado.Text = resultado;

                }

                // calcular el multiplicador 0.01
                else if (Cbox_multi.Text == "Plateado")
                {
                    String aux = banda1 + banda2;
                    double aux2 = Double.Parse(aux) * 0.01;
                    multiplicador = aux2.ToString();
                    resultado = multiplicador + " Ω" + tolerancia;
                    lbl_resultado.Text = resultado;
                }

                else if (banda1 == "0" && banda2 == "0") //Si existen dos ceros solo deja uno
                {
                    resultado = "0 Ω" + tolerancia;
                    lbl_resultado.Text = resultado;

                }

                else if (banda1 == "0")// Si existe un cero en la banda 1 lo elimina
                {
                    resultado = banda2 + multiplicador + " Ω" + tolerancia;
                    lbl_resultado.Text = resultado;
                }

                else if (banda2 == "0" || banda2 == "1" || banda2 == "2" || banda2 == "3" || banda2 == "4" || banda2 == "5" || banda2 == "6" || banda2 == "7" || banda2 == "8" || banda2 == "9")// Aproximar
                {
                    if (multiplicador == "") //multi negro
                    {
                        resultado = banda1 + banda2 + multiplicador + " Ω" + tolerancia;
                        lbl_resultado.Text = resultado;
                    }

                    else if (multiplicador == "0")//multi café
                    {
                        resultado = banda1 + banda2 + multiplicador + " Ω" + tolerancia;
                        lbl_resultado.Text = resultado;
                    }

                    else if (multiplicador == "00")//multi rojo
                    {
                        //Se aproxima a la siguiente multiplo
                        if (banda2 == "0")
                        {
                            resultado = banda1 + "K" + " Ω" + tolerancia;
                            lbl_resultado.Text = resultado;

                        }
                        else //Si la banda 2 es distinto de 0, se agrega un punto
                        {
                            resultado = banda1 + "." + banda2 + "K" + " Ω" + tolerancia;
                            lbl_resultado.Text = resultado;
                        }

                    }

                    else if (multiplicador == "K")//multi naranja 
                    {
                        resultado = banda1 + banda2 + multiplicador + " Ω" + tolerancia;
                        lbl_resultado.Text = resultado;

                    }

                    else if (multiplicador == "0K")//multi amarillo
                    {
                        resultado = banda1 + banda2 + multiplicador + " Ω" + tolerancia;
                        lbl_resultado.Text = resultado;
                    }

                    else if (multiplicador == "00K")//multi verde
                    {
                        //Se aproxima a la siguiente multiplo
                        if (banda2 == "0")
                        {
                            resultado = banda1 + "M" + " Ω" + tolerancia;
                            lbl_resultado.Text = resultado;

                        }
                        else //Si la banda 2 es distinto de 0, se agrega un punto
                        {
                            resultado = banda1 + "." + banda2 + "M" + " Ω" + tolerancia;
                            lbl_resultado.Text = resultado;
                        }
                    }
                    else if (multiplicador == "M")//multi azul
                    {
                        resultado = banda1 + banda2 + multiplicador + " Ω" + tolerancia;
                        lbl_resultado.Text = resultado;
                    }
                }
            }
        }
    }
}