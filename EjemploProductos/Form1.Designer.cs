
namespace EjemploProductos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mtxtNombre = new System.Windows.Forms.MaskedTextBox();
            this.cmbTamanio = new System.Windows.Forms.ComboBox();
            this.chbBlanco = new System.Windows.Forms.CheckBox();
            this.chbGris = new System.Windows.Forms.CheckBox();
            this.rbtBueno = new System.Windows.Forms.RadioButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnMostrardatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(126, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tamaño";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Color";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(126, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estado";
            // 
            // mtxtNombre
            // 
            this.mtxtNombre.Location = new System.Drawing.Point(243, 82);
            this.mtxtNombre.Mask = "LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL";
            this.mtxtNombre.Name = "mtxtNombre";
            this.mtxtNombre.Size = new System.Drawing.Size(133, 20);
            this.mtxtNombre.TabIndex = 4;
            // 
            // cmbTamanio
            // 
            this.cmbTamanio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTamanio.FormattingEnabled = true;
            this.cmbTamanio.Items.AddRange(new object[] {
            "Pequeño",
            "Mediano",
            "Grande",
            "Extra Grande"});
            this.cmbTamanio.Location = new System.Drawing.Point(243, 129);
            this.cmbTamanio.Name = "cmbTamanio";
            this.cmbTamanio.Size = new System.Drawing.Size(134, 21);
            this.cmbTamanio.TabIndex = 5;
            // 
            // chbBlanco
            // 
            this.chbBlanco.AutoSize = true;
            this.chbBlanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbBlanco.Location = new System.Drawing.Point(242, 184);
            this.chbBlanco.Name = "chbBlanco";
            this.chbBlanco.Size = new System.Drawing.Size(65, 17);
            this.chbBlanco.TabIndex = 6;
            this.chbBlanco.Text = "Blanco";
            this.chbBlanco.UseVisualStyleBackColor = true;
            // 
            // chbGris
            // 
            this.chbGris.AutoSize = true;
            this.chbGris.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbGris.Location = new System.Drawing.Point(372, 181);
            this.chbGris.Name = "chbGris";
            this.chbGris.Size = new System.Drawing.Size(48, 17);
            this.chbGris.TabIndex = 7;
            this.chbGris.Text = "Gris";
            this.chbGris.UseVisualStyleBackColor = true;
            // 
            // rbtBueno
            // 
            this.rbtBueno.AutoSize = true;
            this.rbtBueno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtBueno.Location = new System.Drawing.Point(245, 224);
            this.rbtBueno.Name = "rbtBueno";
            this.rbtBueno.Size = new System.Drawing.Size(61, 17);
            this.rbtBueno.TabIndex = 8;
            this.rbtBueno.TabStop = true;
            this.rbtBueno.Text = "Bueno";
            this.rbtBueno.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(200, 287);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(113, 39);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnMostrardatos
            // 
            this.btnMostrardatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrardatos.Location = new System.Drawing.Point(386, 287);
            this.btnMostrardatos.Name = "btnMostrardatos";
            this.btnMostrardatos.Size = new System.Drawing.Size(120, 47);
            this.btnMostrardatos.TabIndex = 10;
            this.btnMostrardatos.Text = "Mostrar datos";
            this.btnMostrardatos.UseVisualStyleBackColor = true;
            this.btnMostrardatos.Click += new System.EventHandler(this.btnMostrardatos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(630, 450);
            this.Controls.Add(this.btnMostrardatos);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.rbtBueno);
            this.Controls.Add(this.chbGris);
            this.Controls.Add(this.chbBlanco);
            this.Controls.Add(this.cmbTamanio);
            this.Controls.Add(this.mtxtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Carmen Padilla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtxtNombre;
        private System.Windows.Forms.ComboBox cmbTamanio;
        private System.Windows.Forms.CheckBox chbBlanco;
        private System.Windows.Forms.CheckBox chbGris;
        private System.Windows.Forms.RadioButton rbtBueno;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnMostrardatos;
    }
}

