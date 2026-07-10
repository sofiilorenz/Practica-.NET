using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Video4 : Form
    {
        public Video4()
        {
            InitializeComponent();
        }

        private void btn_volver_inicio_Click(object sender, EventArgs e)
        {
            Inicio formInicio = new Inicio();
            formInicio.Show();
            this.Hide();
        }
    }
}
