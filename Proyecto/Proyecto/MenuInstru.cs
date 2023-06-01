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
    public partial class MenuInstru : Form
    {
        public MenuInstru()
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
    }
}
