using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
namespace Projeto
{
    public partial class FrmVisualizar : Form
    {
        //variavél para conferir se o data grid está aberto
       
        public FrmVisualizar()
        {
            InitializeComponent();
        }

        private void FrmVisualizar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'db_empresaDataSet2.pedidos'. Você pode movê-la ou removê-la conforme necessário.
            this.pedidosTableAdapter1.Fill(this.db_empresaDataSet2.pedidos);
            // TODO: esta linha de código carrega dados na tabela 'db_empresaDataSet.pedidos'. Você pode movê-la ou removê-la conforme necessário.

            //inicio do timer de 5 segundos para fechamento da mensagem
            timerAviso.Start();

            dgvPedidos.Visible = false;

            //Balão pop up
            ToolTip toolTip1 = new ToolTip();
            toolTip1.AutoPopDelay = 10000;
            toolTip1.InitialDelay = 0;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;

            toolTip1.AutoPopDelay = 10000;
            toolTip1.InitialDelay = 0;
            toolTip1.ReshowDelay = 500;
            toolTip1.ShowAlways = true;

            toolTip1.SetToolTip(lblExibirPedidos, "Caso queira fechar a lista de pedidos basta dar dois cliques encima :)");
           
        }
        //evento do timer para fechar a label
        private void label2_Click(object sender, EventArgs e)
        {
            if (timerAviso.Interval == 5000)
            {
                lblAviso.Visible = false;
            }

        }
        //evento do datagrid que exibe os pedidos
        private void lblExibirPedidos_MouseMove(object sender, MouseEventArgs e)
        {
            dgvPedidos.Visible = true;
             //exibir as informações no dataGrid
            string conexao;
            conexao = "Data Source=DESKTOP-CHDV4PQ;Initial Catalog=db_empresa;Integrated Security=True";
            SqlConnection con = new SqlConnection(conexao);
            SqlCommand cn = new SqlCommand();
            cn.CommandType = CommandType.Text;
            cn.CommandText = "select *from pedidos;";
            con.Open();

        }
        //evento de fechar o data grid
        private void lblExibirPedidos_DoubleClick(object sender, EventArgs e)
        {
            dgvPedidos.Visible = false;
        }
        //fechar form
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}
