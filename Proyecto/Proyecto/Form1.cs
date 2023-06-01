using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class form_menu : Form
    {
        public form_menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Quieres cerrar el programa?", "Saliendo...", MessageBoxButtons.YesNo, MessageBoxIcon.Question); 

            if(resultado == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void btn_MenuColor_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuColor calculoXcolor = new MenuColor();
            calculoXcolor.ShowDialog();
             
        }

        private void btn_MenuValor_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            MenuValores calculoXvalores = new MenuValores();
            calculoXvalores.ShowDialog();
        }

        private void btn_MenuInstrucciones_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            MenuInstru instru = new MenuInstru();
            instru.ShowDialog();
        }

    }
}
