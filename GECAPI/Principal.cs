using System;
// using System.Collections.Generic;
// using System.ComponentModel;
// using System.Data;
// using System.Drawing;
// using System.Linq;
// using System.Text;
using System.Windows.Forms;

namespace GECAPI
{
    public partial class Principal : Form
    {

        public Principal()
        {
            InitializeComponent();
        }

        private void SubMenuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubMenuCursos_Click(object sender, EventArgs e)
        {
            var fCursos = new Cursos {MdiParent = this};
            fCursos.Show();
        }

    }
}
