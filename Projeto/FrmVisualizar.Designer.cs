namespace Projeto
{
    partial class FrmVisualizar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVisualizar));
            this.label1 = new System.Windows.Forms.Label();
            this.timerAviso = new System.Windows.Forms.Timer(this.components);
            this.lblAviso = new System.Windows.Forms.Label();
            this.dgvPedidos = new System.Windows.Forms.DataGridView();
            this.idPedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pratoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bebidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedidosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_empresaDataSet = new Projeto.db_empresaDataSet();
            this.lblExibirPedidos = new System.Windows.Forms.Label();
            this.pedidosTableAdapter = new Projeto.db_empresaDataSetTableAdapters.pedidosTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.db_empresaDataSet2 = new Projeto.db_empresaDataSet2();
            this.pedidosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pedidosTableAdapter1 = new Projeto.db_empresaDataSet2TableAdapters.pedidosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_empresaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_empresaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 15.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(72, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Visualizar Pedidos";
            // 
            // timerAviso
            // 
            this.timerAviso.Enabled = true;
            this.timerAviso.Interval = 5000;
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblAviso.Font = new System.Drawing.Font("Yu Gothic", 15.75F);
            this.lblAviso.ForeColor = System.Drawing.Color.Coral;
            this.lblAviso.Location = new System.Drawing.Point(417, 26);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(295, 54);
            this.lblAviso.TabIndex = 1;
            this.lblAviso.Text = "Nesta tela você ira visualizar\r\n todos os pedidos realizados";
            this.lblAviso.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgvPedidos
            // 
            this.dgvPedidos.AllowUserToAddRows = false;
            this.dgvPedidos.AllowUserToDeleteRows = false;
            this.dgvPedidos.AutoGenerateColumns = false;
            this.dgvPedidos.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPedidoDataGridViewTextBoxColumn,
            this.pratoDataGridViewTextBoxColumn,
            this.bebidaDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn,
            this.mesaDataGridViewTextBoxColumn,
            this.nomeClienteDataGridViewTextBoxColumn});
            this.dgvPedidos.DataSource = this.pedidosBindingSource1;
            this.dgvPedidos.Location = new System.Drawing.Point(113, 159);
            this.dgvPedidos.Name = "dgvPedidos";
            this.dgvPedidos.ReadOnly = true;
            this.dgvPedidos.Size = new System.Drawing.Size(641, 279);
            this.dgvPedidos.TabIndex = 2;
            // 
            // idPedidoDataGridViewTextBoxColumn
            // 
            this.idPedidoDataGridViewTextBoxColumn.DataPropertyName = "idPedido";
            this.idPedidoDataGridViewTextBoxColumn.HeaderText = "idPedido";
            this.idPedidoDataGridViewTextBoxColumn.Name = "idPedidoDataGridViewTextBoxColumn";
            this.idPedidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pratoDataGridViewTextBoxColumn
            // 
            this.pratoDataGridViewTextBoxColumn.DataPropertyName = "prato";
            this.pratoDataGridViewTextBoxColumn.HeaderText = "prato";
            this.pratoDataGridViewTextBoxColumn.Name = "pratoDataGridViewTextBoxColumn";
            this.pratoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bebidaDataGridViewTextBoxColumn
            // 
            this.bebidaDataGridViewTextBoxColumn.DataPropertyName = "bebida";
            this.bebidaDataGridViewTextBoxColumn.HeaderText = "bebida";
            this.bebidaDataGridViewTextBoxColumn.Name = "bebidaDataGridViewTextBoxColumn";
            this.bebidaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            this.quantidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mesaDataGridViewTextBoxColumn
            // 
            this.mesaDataGridViewTextBoxColumn.DataPropertyName = "mesa";
            this.mesaDataGridViewTextBoxColumn.HeaderText = "mesa";
            this.mesaDataGridViewTextBoxColumn.Name = "mesaDataGridViewTextBoxColumn";
            this.mesaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeClienteDataGridViewTextBoxColumn
            // 
            this.nomeClienteDataGridViewTextBoxColumn.DataPropertyName = "nomeCliente";
            this.nomeClienteDataGridViewTextBoxColumn.HeaderText = "nomeCliente";
            this.nomeClienteDataGridViewTextBoxColumn.Name = "nomeClienteDataGridViewTextBoxColumn";
            this.nomeClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pedidosBindingSource
            // 
            this.pedidosBindingSource.DataMember = "pedidos";
            this.pedidosBindingSource.DataSource = this.db_empresaDataSet;
            // 
            // db_empresaDataSet
            // 
            this.db_empresaDataSet.DataSetName = "db_empresaDataSet";
            this.db_empresaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblExibirPedidos
            // 
            this.lblExibirPedidos.AutoSize = true;
            this.lblExibirPedidos.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblExibirPedidos.Font = new System.Drawing.Font("Yu Gothic", 15.75F);
            this.lblExibirPedidos.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblExibirPedidos.Location = new System.Drawing.Point(72, 103);
            this.lblExibirPedidos.Name = "lblExibirPedidos";
            this.lblExibirPedidos.Size = new System.Drawing.Size(460, 27);
            this.lblExibirPedidos.TabIndex = 3;
            this.lblExibirPedidos.Text = "Passe o mause encima para exibir os pedidos";
            this.lblExibirPedidos.DoubleClick += new System.EventHandler(this.lblExibirPedidos_DoubleClick);
            this.lblExibirPedidos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblExibirPedidos_MouseMove);
            // 
            // pedidosTableAdapter
            // 
            this.pedidosTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 450);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // db_empresaDataSet2
            // 
            this.db_empresaDataSet2.DataSetName = "db_empresaDataSet2";
            this.db_empresaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pedidosBindingSource1
            // 
            this.pedidosBindingSource1.DataMember = "pedidos";
            this.pedidosBindingSource1.DataSource = this.db_empresaDataSet2;
            // 
            // pedidosTableAdapter1
            // 
            this.pedidosTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmVisualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblExibirPedidos);
            this.Controls.Add(this.dgvPedidos);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVisualizar";
            this.Text = "FrmVisualizar";
            this.Load += new System.EventHandler(this.FrmVisualizar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_empresaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_empresaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerAviso;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.DataGridView dgvPedidos;
        private System.Windows.Forms.Label lblExibirPedidos;
        private db_empresaDataSet db_empresaDataSet;
        private System.Windows.Forms.BindingSource pedidosBindingSource;
        private db_empresaDataSetTableAdapters.pedidosTableAdapter pedidosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pratoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bebidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private db_empresaDataSet2 db_empresaDataSet2;
        private System.Windows.Forms.BindingSource pedidosBindingSource1;
        private db_empresaDataSet2TableAdapters.pedidosTableAdapter pedidosTableAdapter1;
    }
}