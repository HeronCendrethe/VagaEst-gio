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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        //sequencia de eventos para instanciação das telas nos devidos botões
        private void btnRealizarPedido_Click(object sender, EventArgs e)
        {
            FrmRealizarPedido frmRealizar = new FrmRealizarPedido();
            frmRealizar.Show();
            this.Hide();
        }

        private void btnVisuzalizarPedido_Click(object sender, EventArgs e)
        {
            FrmVisualizar frmVisualizar = new FrmVisualizar();
            frmVisualizar.Show();
            this.Hide();
        }

        private void btnVisualizarCopa_Click(object sender, EventArgs e)
        {
            VisualizarBebidas visualizarBebidas = new VisualizarBebidas();
            visualizarBebidas.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Mudar a string de conexão caso não funcione!!!!!!!!!!");
            lblInfo.Visible = false;
            //pop up
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 10000;
            toolTip1.InitialDelay = 0;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(btnFechar, "Fechar");
            toolTip1.AutoPopDelay = 10000;
            toolTip1.InitialDelay = 0;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;


         
            toolTip1.AutoPopDelay = 10000;
            toolTip1.InitialDelay = 0;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(btnMinimizar, "Minimizar");
            toolTip1.AutoPopDelay = 10000;
            toolTip1.InitialDelay = 0;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;
        }

        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            lblInfo.Visible = true;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
        }
        //sequencia de eventos para mudar a cor dos botões de fechar e minimizar
        private void btnFechar_MouseMove(object sender, MouseEventArgs e)
        {
            btnFechar.BackColor = Color.Red;
        }

        private void btnFechar_MouseLeave(object sender, EventArgs e)
        {
            btnFechar.BackColor = Color.Transparent;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            btnMinimizar.BackColor = Color.Red;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            btnMinimizar.BackColor = Color.Transparent;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //sequencia de metodos para mudar,abrir e fechar a label de informações
        private void btnRealizarPedido_MouseMove(object sender, MouseEventArgs e)
        {
            lblInfo.Visible = true;
            lblInfo.Text = "Clique aqui para acessar a aba de realizar pedido.";
        }

        private void btnRealizarPedido_MouseLeave(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
        }

        private void btnVisuzalizarPedido_MouseMove(object sender, MouseEventArgs e)
        {
            lblInfo.Visible = true;
            lblInfo.Text = "Clique aqui para acessar a aba com todos os pedidos realizados.";
        }

        private void btnVisuzalizarPedido_MouseLeave(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
        }

        private void btnVisualizarCopa_MouseMove(object sender, MouseEventArgs e)
        {
            lblInfo.Visible = true;
            lblInfo.Text = "Clique aqui para acessar a aba de visualizar pedidos da copa.";
        }

        private void btnVisualizarCopa_MouseLeave(object sender, EventArgs e)
        {
            lblInfo.Visible = false;
        }
    }
}
