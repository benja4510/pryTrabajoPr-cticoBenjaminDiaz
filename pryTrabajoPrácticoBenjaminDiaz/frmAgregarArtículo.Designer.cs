namespace pryTrabajoPrácticoBenjaminDiaz
{
    partial class frmAgregarArtículo
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
            this.gboDatos = new System.Windows.Forms.GroupBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.cmbRubros = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.gboAviso = new System.Windows.Forms.GroupBox();
            this.lblAviso = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gboDatos.SuspendLayout();
            this.gboAviso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // gboDatos
            // 
            this.gboDatos.BackColor = System.Drawing.Color.Transparent;
            this.gboDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gboDatos.Controls.Add(this.txtStock);
            this.gboDatos.Controls.Add(this.label5);
            this.gboDatos.Controls.Add(this.txtCosto);
            this.gboDatos.Controls.Add(this.cmbRubros);
            this.gboDatos.Controls.Add(this.txtDescripcion);
            this.gboDatos.Controls.Add(this.txtCodigo);
            this.gboDatos.Controls.Add(this.label4);
            this.gboDatos.Controls.Add(this.label3);
            this.gboDatos.Controls.Add(this.label2);
            this.gboDatos.Controls.Add(this.label1);
            this.gboDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboDatos.ForeColor = System.Drawing.Color.LightGray;
            this.gboDatos.Location = new System.Drawing.Point(42, 50);
            this.gboDatos.Name = "gboDatos";
            this.gboDatos.Size = new System.Drawing.Size(653, 204);
            this.gboDatos.TabIndex = 0;
            this.gboDatos.TabStop = false;
            this.gboDatos.Text = "Datos del Producto";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(351, 150);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 24);
            this.txtStock.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Stock:";
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(160, 153);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(100, 24);
            this.txtCosto.TabIndex = 5;
            // 
            // cmbRubros
            // 
            this.cmbRubros.FormattingEnabled = true;
            this.cmbRubros.Location = new System.Drawing.Point(160, 110);
            this.cmbRubros.Name = "cmbRubros";
            this.cmbRubros.Size = new System.Drawing.Size(145, 26);
            this.cmbRubros.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(160, 74);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(194, 24);
            this.txtDescripcion.TabIndex = 3;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(160, 39);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 24);
            this.txtCodigo.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Costo ($):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rubro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // btnGrabar
            // 
            this.btnGrabar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnGrabar.Location = new System.Drawing.Point(160, 291);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(104, 39);
            this.btnGrabar.TabIndex = 1;
            this.btnGrabar.Text = "GRABAR ARTÍCULO";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnLimpiar.Location = new System.Drawing.Point(482, 291);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(104, 39);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "LIMPIAR CAMPOS";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnVolver.Location = new System.Drawing.Point(42, 399);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(90, 23);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver al Menú";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // gboAviso
            // 
            this.gboAviso.BackColor = System.Drawing.Color.Transparent;
            this.gboAviso.Controls.Add(this.lblAviso);
            this.gboAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboAviso.ForeColor = System.Drawing.Color.White;
            this.gboAviso.Location = new System.Drawing.Point(202, 368);
            this.gboAviso.Name = "gboAviso";
            this.gboAviso.Size = new System.Drawing.Size(499, 114);
            this.gboAviso.TabIndex = 4;
            this.gboAviso.TabStop = false;
            this.gboAviso.Text = "AVISO";
            // 
            // lblAviso
            // 
            this.lblAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAviso.Location = new System.Drawing.Point(17, 31);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(476, 73);
            this.lblAviso.TabIndex = 0;
            this.lblAviso.Text = "Gestión de Rubros: Cree y Edite (añadiendo rubros)  el archivo \'Rubros.csv\' en la" +
    " carpeta Debug del proyecto  para actualizar los Rubros del sistema.  Asegurarse" +
    " de eliminar  \".txt\" al final";
            this.lblAviso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryTrabajoPrácticoBenjaminDiaz.Properties.Resources.Rubros_CSV;
            this.pictureBox1.Location = new System.Drawing.Point(97, 519);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(606, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::pryTrabajoPrácticoBenjaminDiaz.Properties.Resources.Rubros_CSV_txt;
            this.pictureBox2.Location = new System.Drawing.Point(96, 637);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(607, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(39, 557);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "✔";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(39, 677);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "✖";
            // 
            // frmAgregarArtículo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(739, 754);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gboAviso);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.gboDatos);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "frmAgregarArtículo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Nuevo Artículo - CyberStock";
            this.Load += new System.EventHandler(this.frmAgregarArtículo_Load);
            this.gboDatos.ResumeLayout(false);
            this.gboDatos.PerformLayout();
            this.gboAviso.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboDatos;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.ComboBox cmbRubros;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox gboAviso;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}