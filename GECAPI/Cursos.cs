using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
using System.Windows.Forms;

namespace GECAPI
{
    public partial class Cursos : Form
    {
        private int _estado;
        private string _tmpCurso;

        public Cursos()
        {
            InitializeComponent();
        }

        private void Cursos_Load(object sender, EventArgs e)
        {
            _estado = 0;

            for (Int16 i=0; i <= 20; i++)
            {
                lvCursos.Items.Add("Prueba " + i.ToString());    
            }
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCurso_TextChanged(object sender, EventArgs e)
        {
            btnAgregar.Enabled = (_estado == 0 && txtCurso.TextLength != 0);
        }

        private void lvCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCursos.SelectedItems.Count == 0)
            {
                _estado = 0;
                txtCurso.Text = "";
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                return;
            }

            _estado = 1;
            txtCurso.Text = lvCursos.SelectedItems[0].Text;
            _tmpCurso = lvCursos.SelectedItems[0].Text;
            //this.Text = lvCursos.SelectedItems[0].Index.ToString();
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }
    }
}
