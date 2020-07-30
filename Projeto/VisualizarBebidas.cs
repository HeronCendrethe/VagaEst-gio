using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class VisualizarBebidas : Form
    {
        public VisualizarBebidas()
        {
            InitializeComponent();
        }

        private void VisualizarBebidas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_empresaDataSet1.copa'. Você pode movê-la ou removê-la conforme necessário.
            this.copaTableAdapter.Fill(this.db_empresaDataSet1.copa);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}
