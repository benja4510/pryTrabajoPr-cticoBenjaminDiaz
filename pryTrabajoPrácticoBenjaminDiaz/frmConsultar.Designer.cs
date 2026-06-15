namespace pryTrabajoPrácticoBenjaminDiaz
{
    partial class frmConsultar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultar));
            this.gboBusqueda = new System.Windows.Forms.GroupBox();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.cboRubros = new System.Windows.Forms.ComboBox();
            this.lblRubro = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCosto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.gboBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // gboBusqueda
            // 
            this.gboBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.gboBusqueda.Controls.Add(this.btnExportar);
            this.gboBusqueda.Controls.Add(this.btnMostrar);
            this.gboBusqueda.Controls.Add(this.cboRubros);
            this.gboBusqueda.Controls.Add(this.lblRubro);
            this.gboBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboBusqueda.ForeColor = System.Drawing.Color.FloralWhite;
            this.gboBusqueda.Location = new System.Drawing.Point(33, 27);
            this.gboBusqueda.Name = "gboBusqueda";
            this.gboBusqueda.Size = new System.Drawing.Size(539, 113);
            this.gboBusqueda.TabIndex = 0;
            this.gboBusqueda.TabStop = false;
            this.gboBusqueda.Text = "Busqueda de Articulos";
            // 
            // btnExportar
            // 
            this.btnExportar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnExportar.Location = new System.Drawing.Point(434, 45);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(89, 35);
            this.btnExportar.TabIndex = 4;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnMostrar.Location = new System.Drawing.Point(329, 45);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(89, 35);
            this.btnMostrar.TabIndex = 2;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // cboRubros
            // 
            this.cboRubros.FormattingEnabled = true;
            this.cboRubros.Items.AddRange(new object[] {
            ""});
            this.cboRubros.Location = new System.Drawing.Point(189, 49);
            this.cboRubros.Name = "cboRubros";
            this.cboRubros.Size = new System.Drawing.Size(121, 28);
            this.cboRubros.TabIndex = 3;
            // 
            // lblRubro
            // 
            this.lblRubro.AutoSize = true;
            this.lblRubro.Location = new System.Drawing.Point(16, 52);
            this.lblRubro.Name = "lblRubro";
            this.lblRubro.Size = new System.Drawing.Size(156, 20);
            this.lblRubro.TabIndex = 2;
            this.lblRubro.Text = "Seleccione Rubro:";
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.BackgroundColor = System.Drawing.Color.White;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colDescripcion,
            this.colCosto,
            this.colStock,
            this.colValor});
            this.dgvConsulta.Location = new System.Drawing.Point(33, 159);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.RowHeadersVisible = false;
            this.dgvConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsulta.Size = new System.Drawing.Size(539, 208);
            this.dgvConsulta.TabIndex = 1;
            // 
            // colCodigo
            // 
            this.colCodigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.NullValue = null;
            this.colCodigo.DefaultCellStyle = dataGridViewCellStyle6;
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            // 
            // colDescripcion
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.NullValue = null;
            this.colDescripcion.DefaultCellStyle = dataGridViewCellStyle7;
            this.colDescripcion.HeaderText = "Descripción";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
            // 
            // colCosto
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.Format = "C2";
            dataGridViewCellStyle8.NullValue = null;
            this.colCosto.DefaultCellStyle = dataGridViewCellStyle8;
            this.colCosto.HeaderText = "Costo";
            this.colCosto.Name = "colCosto";
            this.colCosto.ReadOnly = true;
            // 
            // colStock
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N0";
            dataGridViewCellStyle9.NullValue = null;
            this.colStock.DefaultCellStyle = dataGridViewCellStyle9;
            this.colStock.HeaderText = "Stock";
            this.colStock.Name = "colStock";
            this.colStock.ReadOnly = true;
            // 
            // colValor
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "C2";
            dataGridViewCellStyle10.NullValue = null;
            this.colValor.DefaultCellStyle = dataGridViewCellStyle10;
            this.colValor.HeaderText = "Valor en Stock";
            this.colValor.Name = "colValor";
            this.colValor.ReadOnly = true;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCantidad.Location = new System.Drawing.Point(369, 388);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(187, 18);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad de Artículos: 0";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTotal.Location = new System.Drawing.Point(369, 422);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(195, 18);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total Valor Stock: $ 0.00";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(53, 388);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(111, 39);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir Reporte";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // frmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(619, 449);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.dgvConsulta);
            this.Controls.Add(this.gboBusqueda);
            this.Name = "frmConsultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Articulos por Rubro- CyberStock";
            this.Load += new System.EventHandler(this.frmConsultar_Load);
            this.gboBusqueda.ResumeLayout(false);
            this.gboBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboBusqueda;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCosto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValor;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ComboBox cboRubros;
        private System.Windows.Forms.Label lblRubro;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblTotal;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button btnImprimir;
    }
}