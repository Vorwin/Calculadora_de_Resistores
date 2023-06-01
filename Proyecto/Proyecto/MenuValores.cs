using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class MenuValores : Form
    {
        //Variables
        String banda1 = "";
        String banda2 = "";
        String multiplicador = "";
        String tolerancia = "";
        String resultado = "";

        //Regex
        Regex reg_valores = new Regex(@"\A([0-9][0-9]?)(0|00|000|0000|00000|000000)?\Z");//valores sin punto
        Regex reg_valores_Ing = new Regex(@"\A(([0-9]\.?[0-9]?0?))(M|K|k|m)\Z");//notació de ing
        Regex reg_valorPunto = new Regex(@"\A([0-9]\.[0-9]?)\Z");// valores con un punto
        Regex reg_valoreCeroPunto = new Regex(@"\A(0\.[0-9][0-9]?)\Z");// valorer que empiezan con 0.
        public MenuValores()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Quieres cerrar el programa?", "Saliendo...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_menu menu = new form_menu();
            menu.ShowDialog();
        }

        private void cambiar_bandaT(object sender, EventArgs e)
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

        private void calcular_valor(object sender, EventArgs e)
        {
            String valor = txt_valor.Text;
             

            if (reg_valores.IsMatch(valor)) //verificar si el texto es notación normal
            {

                if (valor.Length == 1)
                {
                    banda1 = "0";
                    banda2 = valor;
                    color_banda1("0");
                    color_banda2(valor);
                    multi_color.BackColor = Color.Black;
                    lbl_resultado.Text = valor + " Ω" + tolerancia;
                }
                else if (valor.Length == 2)
                {
                    banda1 = valor.Substring(0, 1);
                    banda2 = valor.Substring(1, 1);
                    color_banda1(banda1);
                    color_banda2(banda2);
                    multi_color.BackColor = Color.Black;
                    lbl_resultado.Text = valor + " Ω" + tolerancia;
                }
                else if (valor.Length == 3)
                {
                    banda1 = valor.Substring(0, 1);
                    banda2 = valor.Substring(1, 1);
                    multiplicador = valor.Substring(2);
                    color_banda1(banda1);
                    color_banda2(banda2);
                    color_multi(multiplicador);
                    lbl_resultado.Text = valor + " Ω" + tolerancia;
                }
                else if (valor.Length == 4)
                {
                    banda1 = valor.Substring(0, 1);
                    banda2 = valor.Substring(1, 1);
                    multiplicador = valor.Substring(2, 2);
                    color_banda1(banda1);
                    color_banda2(banda2);
                    color_multi(multiplicador);
                    lbl_resultado.Text = valor + " Ω" + tolerancia;
                }
                else if (valor.Length == 5)
                {
                    banda1 = valor.Substring(0, 1);
                    banda2 = valor.Substring(1, 1);
                    multiplicador = valor.Substring(2, 3);
                    color_banda1(banda1);
                    color_banda2(banda2);
                    color_multi(multiplicador);
                    lbl_resultado.Text = valor + " Ω" + tolerancia;
                }
                else if (valor.Length == 6)
                {
                    banda1 = valor.Substring(0, 1);
                    banda2 = valor.Substring(1, 1);
                    multiplicador = valor.Substring(2, 4);
                    color_banda1(banda1);
                    color_banda2(banda2);
                    color_multi(multiplicador);
                    lbl_resultado.Text = valor + " Ω" + tolerancia;
                }
                else if (valor.Length == 7)
                {
                    banda1 = valor.Substring(0, 1);
                    banda2 = valor.Substring(1, 1);
                    multiplicador = valor.Substring(2, 5);
                    color_banda1(banda1);
                    color_banda2(banda2);
                    color_multi(multiplicador);
                    lbl_resultado.Text = valor + " Ω" + tolerancia;
                }
                else if (valor.Length == 8) // 33000000 
                {
                    banda1 = valor.Substring(0, 1);
                    banda2 = valor.Substring(1, 1);
                    multiplicador = valor.Substring(2, 6);
                    color_banda1(banda1);
                    color_banda2(banda2);
                    color_multi(multiplicador);
                    lbl_resultado.Text = valor + " Ω" + tolerancia;
                }

            }
            else if (reg_valorPunto.IsMatch(valor))//verificar si el texto tiene un punto
            {
                if(valor.Length == 3)
                {
                    banda1 = valor.Substring(0, 1);
                    banda2 = valor.Substring(2, 1);
                    color_banda1(banda1);
                    color_banda2(banda2);
                    multi_color.BackColor = Color.Gold; 
                    lbl_resultado.Text = valor + " Ω" + tolerancia;
                }
            }
            else if (reg_valoreCeroPunto.IsMatch(valor))//verificar si el texto tiene 0.
            {
                if (valor.Length == 4) 
                {
                    banda1 = valor.Substring(2, 1);
                    banda2 = valor.Substring(3, 1);
                    color_banda1(banda1);
                    color_banda2(banda2);
                    multi_color.BackColor = Color.Silver;
                    lbl_resultado.Text = valor + " Ω" + tolerancia;
                }
            }
            else if (reg_valores_Ing.IsMatch(valor)) //verificar si el texto es notación de Ingenieria
            {

                if(valor.Contains(".")) //si tiene punto se lo elimina
                {
                    valor = valor.Contains("K") ? valor.Replace("K", "00").Replace(".", "") : valor.Replace("k", "00").Replace(".", ""); // verificar miles
                    valor = valor.Contains("M") ? valor.Replace("M", "00000").Replace(".", "") : valor.Replace("m", "00000").Replace(".", ""); // verificar millones
                    //lbl_resultado.Text = valor + " Ω" + tolerancia;

                    
                    if (valor.Length == 4)
                    {
                        banda1 = valor.Substring(0, 1);
                        banda2 = valor.Substring(1, 1);
                        multiplicador = valor.Substring(2, 2);
                        color_banda1(banda1);
                        color_banda2(banda2);
                        color_multi(multiplicador);
                        lbl_resultado.Text = valor + " Ω" + tolerancia;
                    }
                    else if (valor.Length == 5)
                    {
                        banda1 = valor.Substring(0, 1);
                        banda2 = valor.Substring(1, 1);
                        multiplicador = valor.Substring(2, 3);
                        color_banda1(banda1);
                        color_banda2(banda2);
                        color_multi(multiplicador);
                        lbl_resultado.Text = valor + " Ω" + tolerancia;
                    }
                    else if (valor.Length == 6)
                    {
                        banda1 = valor.Substring(0, 1);
                        banda2 = valor.Substring(1, 1);
                        multiplicador = valor.Substring(2, 4);
                        color_banda1(banda1);
                        color_banda2(banda2);
                        color_multi(multiplicador);
                        lbl_resultado.Text = valor + " Ω" + tolerancia;
                    }
                    else if (valor.Length == 7)
                    {
                        banda1 = valor.Substring(0, 1);
                        banda2 = valor.Substring(1, 1);
                        multiplicador = valor.Substring(2, 5);
                        color_banda1(banda1);
                        color_banda2(banda2);
                        color_multi(multiplicador);
                        lbl_resultado.Text = valor + " Ω" + tolerancia;
                    }
                    else if (valor.Length == 8)
                    {
                        banda1 = valor.Substring(0, 1);
                        banda2 = valor.Substring(1, 1);
                        multiplicador = valor.Substring(2, 6);
                        color_banda1(banda1);
                        color_banda2(banda2);
                        color_multi(multiplicador);
                        lbl_resultado.Text = valor + " Ω" + tolerancia;
                    }
                }
                else
                {
                    valor = valor.Contains("K") ? valor.Replace("K", "000") : valor.Replace("k", "000"); // verificar miles
                    valor = valor.Contains("M") ? valor.Replace("M", "000000") : valor.Replace("m", "000000"); // verificar millones
                    lbl_resultado.Text = valor + " Ω" + tolerancia;

                    if (valor.Length == 4)
                    {
                        banda1 = valor.Substring(0, 1);
                        banda2 = valor.Substring(1, 1);
                        multiplicador = valor.Substring(2, 2);
                        color_banda1(banda1);
                        color_banda2(banda2);
                        color_multi(multiplicador);
                        lbl_resultado.Text = valor + " Ω" + tolerancia;
                    }
                    else if (valor.Length == 5)
                    {
                        banda1 = valor.Substring(0, 1);
                        banda2 = valor.Substring(1, 1);
                        multiplicador = valor.Substring(2, 3);
                        color_banda1(banda1);
                        color_banda2(banda2);
                        color_multi(multiplicador);
                        lbl_resultado.Text = valor + " Ω" + tolerancia;
                    }
                    else if (valor.Length == 6)
                    {
                        banda1 = valor.Substring(0, 1);
                        banda2 = valor.Substring(1, 1);
                        multiplicador = valor.Substring(2, 4);
                        color_banda1(banda1);
                        color_banda2(banda2);
                        color_multi(multiplicador);
                        lbl_resultado.Text = valor + " Ω" + tolerancia;
                    }
                    else if (valor.Length == 7)
                    {
                        banda1 = valor.Substring(0, 1);
                        banda2 = valor.Substring(1, 1);
                        multiplicador = valor.Substring(2, 5);
                        color_banda1(banda1);
                        color_banda2(banda2);
                        color_multi(multiplicador);
                        lbl_resultado.Text = valor + " Ω" + tolerancia;
                    }
                    else if (valor.Length == 8)
                    {
                        banda1 = valor.Substring(0, 1);
                        banda2 = valor.Substring(1, 1);
                        multiplicador = valor.Substring(2, 6);
                        color_banda1(banda1);
                        color_banda2(banda2);
                        color_multi(multiplicador);
                        lbl_resultado.Text = valor + " Ω" + tolerancia;
                    }
                }
            }   
            else
            {
                MessageBox.Show("Valor ingresado incorrectamente", "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
        }

        //Funciones para colorear las bandas
        public void color_banda1(String banda1)
        {
            if(banda1 == "0")
            {
                Banda1_color.BackColor = Color.Black;
            }
            else if (banda1 == "1")
            {
                Banda1_color.BackColor = Color.SaddleBrown;
            }
            else if (banda1 == "2")
            {
                Banda1_color.BackColor = Color.Red;
            }
            else if (banda1 == "3")
            {
                Banda1_color.BackColor = Color.Orange;
            }
            else if (banda1 == "4")
            {
                Banda1_color.BackColor = Color.Yellow;
            }
            else if (banda1 == "5")
            {
                Banda1_color.BackColor = Color.Green;
            }
            else if (banda1 == "6")
            {
                Banda1_color.BackColor = Color.Blue;
            }
            else if (banda1 == "7")
            {
                Banda1_color.BackColor = Color.Violet;
            }
            else if (banda1 == "8")
            {
                Banda1_color.BackColor = Color.Gray;
            }
            else if (banda1 == "9")
            {
                Banda1_color.BackColor = Color.White;
            }
        }
        public void color_banda2(String banda2)
        {
            if (banda2 == "0")
            {
                Banda2_color.BackColor = Color.Black;
            }
            else if (banda2 == "1")
            {
                Banda2_color.BackColor = Color.SaddleBrown;
            }
            else if (banda2 == "2")
            {
                Banda2_color.BackColor = Color.Red;
            }
            else if (banda2 == "3")
            {
                Banda2_color.BackColor = Color.Orange;
            }
            else if (banda2 == "4")
            {
                Banda2_color.BackColor = Color.Yellow;
            }
            else if (banda2 == "5")
            {
                Banda2_color.BackColor = Color.Green;
            }
            else if (banda2 == "6")
            {
                Banda2_color.BackColor = Color.Blue;
            }
            else if (banda2 == "7")
            {
                Banda2_color.BackColor = Color.Violet;
            }
            else if (banda2 == "8")
            {
                Banda2_color.BackColor = Color.Gray;
            }
            else if (banda2 == "9")
            {
                Banda2_color.BackColor = Color.White;
            }
        }
        public void color_multi(String multi)
        {
            if (multi == "0")
            {
                multi_color.BackColor = Color.SaddleBrown;
            }
            else if (multi == "00")
            {
                multi_color.BackColor = Color.Red;
            }
            else if (multi == "000")
            {
                multi_color.BackColor = Color.Orange;
            }
            else if (multi == "0000")
            {
                multi_color.BackColor = Color.Yellow;
            }
            else if (multi == "00000")
            {
                multi_color.BackColor = Color.Green;
            }
            else if (multi == "000000")
            {
                multi_color.BackColor = Color.Blue;
            }
        }
    }
}
