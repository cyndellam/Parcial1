namespace WindowsFormsBase
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEliminarID = new System.Windows.Forms.TextBox();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBultos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtModificarID = new System.Windows.Forms.TextBox();
            this.txtCantModificar = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbCantBulto = new System.Windows.Forms.ComboBox();
            this.btnAgregarALista = new System.Windows.Forms.Button();
            this.btnIngresarListados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(31, 472);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(148, 51);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "INGRESAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(745, 597);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(148, 51);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(416, 558);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(148, 51);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(242, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(885, 461);
            this.dataGridView1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "INGRESAR BEBIDAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "VER INGRESOS DE BEBIDAS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cantidad de bultos:";
            // 
            // cmbMarca
            // 
            this.cmbMarca.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(12, 128);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(206, 21);
            this.cmbMarca.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Seleccione marca:";
            // 
            // txtEliminarID
            // 
            this.txtEliminarID.Location = new System.Drawing.Point(394, 526);
            this.txtEliminarID.Name = "txtEliminarID";
            this.txtEliminarID.Size = new System.Drawing.Size(196, 20);
            this.txtEliminarID.TabIndex = 14;
            // 
            // textDescripcion
            // 
            this.textDescripcion.Location = new System.Drawing.Point(12, 60);
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(206, 20);
            this.textDescripcion.TabIndex = 17;
        
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Descripción:";
            // 
            // txtBultos
            // 
            this.txtBultos.Location = new System.Drawing.Point(12, 278);
            this.txtBultos.Name = "txtBultos";
            this.txtBultos.Size = new System.Drawing.Size(206, 20);
            this.txtBultos.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Cantidad por Bulto:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(12, 349);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(206, 20);
            this.txtDni.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "DNI Empleado responsable:";
            // 
            // txtObs
            // 
            this.txtObs.Location = new System.Drawing.Point(12, 427);
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(206, 20);
            this.txtObs.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 408);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Observaciones:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(391, 507);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "Detalle el ID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(716, 507);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Detalle el ID:";
            // 
            // txtModificarID
            // 
            this.txtModificarID.Location = new System.Drawing.Point(719, 526);
            this.txtModificarID.Name = "txtModificarID";
            this.txtModificarID.Size = new System.Drawing.Size(196, 20);
            this.txtModificarID.TabIndex = 25;
            // 
            // txtCantModificar
            // 
            this.txtCantModificar.Location = new System.Drawing.Point(719, 571);
            this.txtCantModificar.Name = "txtCantModificar";
            this.txtCantModificar.Size = new System.Drawing.Size(196, 20);
            this.txtCantModificar.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(716, 552);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 16);
            this.label12.TabIndex = 27;
            this.label12.Text = "Cantidad de bultos:";
            // 
            // cmbCantBulto
            // 
            this.cmbCantBulto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cmbCantBulto.FormattingEnabled = true;
            this.cmbCantBulto.Location = new System.Drawing.Point(12, 200);
            this.cmbCantBulto.Name = "cmbCantBulto";
            this.cmbCantBulto.Size = new System.Drawing.Size(206, 21);
            this.cmbCantBulto.TabIndex = 29;
            // 
            // btnAgregarALista
            // 
            this.btnAgregarALista.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAgregarALista.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarALista.Location = new System.Drawing.Point(31, 540);
            this.btnAgregarALista.Name = "btnAgregarALista";
            this.btnAgregarALista.Size = new System.Drawing.Size(148, 51);
            this.btnAgregarALista.TabIndex = 30;
            this.btnAgregarALista.Text = "AGREGAR A LISTA";
            this.btnAgregarALista.UseVisualStyleBackColor = false;
            this.btnAgregarALista.Click += new System.EventHandler(this.btnAgregarALista_Click);
            // 
            // btnIngresarListados
            // 
            this.btnIngresarListados.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIngresarListados.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarListados.Location = new System.Drawing.Point(31, 606);
            this.btnIngresarListados.Name = "btnIngresarListados";
            this.btnIngresarListados.Size = new System.Drawing.Size(148, 51);
            this.btnIngresarListados.TabIndex = 31;
            this.btnIngresarListados.Text = "INGRESAR LISTADOS";
            this.btnIngresarListados.UseVisualStyleBackColor = false;
            this.btnIngresarListados.Click += new System.EventHandler(this.btnIngresarListados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 679);
            this.Controls.Add(this.btnIngresarListados);
            this.Controls.Add(this.btnAgregarALista);
            this.Controls.Add(this.cmbCantBulto);
            this.Controls.Add(this.txtCantModificar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtModificarID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBultos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textDescripcion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtEliminarID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form1";
            this.Text = "Distribuidora de bebidas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEliminarID;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBultos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtModificarID;
        private System.Windows.Forms.TextBox txtCantModificar;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbCantBulto;
        private System.Windows.Forms.Button btnAgregarALista;
        private System.Windows.Forms.Button btnIngresarListados;
    }
}

