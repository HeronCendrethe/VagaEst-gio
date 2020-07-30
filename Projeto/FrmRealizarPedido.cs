using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace Projeto
{
    public partial class FrmRealizarPedido : Form
    {
        public FrmRealizarPedido()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerMessage.Start();
            lblTeste.Visible = false;
          
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

           
            

            classe_pedidos classe_Pedidos = new classe_pedidos();
            string conexao;
            conexao = "Data Source=DESKTOP-CHDV4PQ;Initial Catalog=db_empresa;Integrated Security=True";

            
            // conferencia se todos os dados foram preenchidos e atribuição dos mesmo
            if( txtBebida.Text != ""&
                txtMesa.Text != ""&
                txtNomeCliente.Text != ""&
                txtPrato.Text != ""&
                txtQuantidade.Text != "")
            {


                 classe_Pedidos.bebida = txtBebida.Text;
                 classe_Pedidos.mesa = Convert.ToInt32(txtMesa.Text);
                 classe_Pedidos.nomeCliente = txtNomeCliente.Text;
                 classe_Pedidos.prato = txtPrato.Text;
                 classe_Pedidos.quantidade = txtQuantidade.Text;

            }
            else
            {
                MessageBox.Show("Preencher todos os campos!");
            }

            // método de inserir os pedidos no banco de dados
            try
            {
                using (SqlConnection con = new SqlConnection(conexao))
                {
                    SqlCommand cn = new SqlCommand();
                    cn.CommandType = CommandType.Text;
                    con.Open();

                    cn.CommandText = "INSERT INTO pedidos VALUES (@prato, @bebida, @quantidade, @mesa, @nomeCliente);";
                    cn.Parameters.Add("prato", SqlDbType.VarChar).Value = classe_Pedidos.prato;
                    cn.Parameters.Add("bebida", SqlDbType.VarChar).Value = classe_Pedidos.bebida;
                    cn.Parameters.Add("quantidade", SqlDbType.VarChar).Value = classe_Pedidos.quantidade;
                    cn.Parameters.Add("mesa", SqlDbType.Int).Value = classe_Pedidos.mesa;
                    cn.Parameters.Add("nomeCliente", SqlDbType.VarChar).Value = classe_Pedidos.nomeCliente;
                    cn.Connection = con;

                    cn.ExecuteNonQuery();
                    
                    
                }


                MessageBox.Show("Pedido realizado com sucesso!");
            }


            catch
            {
                MessageBox.Show("Falha ao realizar pedido!");
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(timerMessage.Interval == 5000)
            {
                lblInfo.Visible = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
            this.Close();
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
          
            Random randNum = new Random();
           
            txtBebida.Text = "Coca Cola 2 litros 2 Unidade";
            txtMesa.Text = Convert.ToString(37);
            txtNomeCliente.Text = "Kiliam Francisco";
            txtPrato.Text = "Arroz Agrega com tropeiro ruts";
            txtQuantidade.Text = "5";

            btnConfirmar.PerformClick();

        }

        private void btnRealizarTeste_MouseMove(object sender, MouseEventArgs e)
        {
            lblTeste.Visible = true;
        }

        private void btnRealizarTeste_MouseLeave(object sender, EventArgs e)
        {
            lblTeste.Visible = false;
        }
    }
}
