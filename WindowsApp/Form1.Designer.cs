namespace WindowsApp
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
            this.btnCrearProducto = new System.Windows.Forms.Button();
            this.btnCrearEmpresa = new System.Windows.Forms.Button();
            this.btnCrearPersona = new System.Windows.Forms.Button();
            this.btnCrearDocComercial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearProducto
            // 
            this.btnCrearProducto.Location = new System.Drawing.Point(212, 85);
            this.btnCrearProducto.Name = "btnCrearProducto";
            this.btnCrearProducto.Size = new System.Drawing.Size(155, 23);
            this.btnCrearProducto.TabIndex = 0;
            this.btnCrearProducto.Text = "Crear Producto";
            this.btnCrearProducto.UseVisualStyleBackColor = true;
            this.btnCrearProducto.Click += new System.EventHandler(this.btnCrearProducto_Click);
            // 
            // btnCrearEmpresa
            // 
            this.btnCrearEmpresa.Location = new System.Drawing.Point(212, 26);
            this.btnCrearEmpresa.Name = "btnCrearEmpresa";
            this.btnCrearEmpresa.Size = new System.Drawing.Size(155, 23);
            this.btnCrearEmpresa.TabIndex = 1;
            this.btnCrearEmpresa.Text = "Crear Empresa";
            this.btnCrearEmpresa.UseVisualStyleBackColor = true;
            this.btnCrearEmpresa.Click += new System.EventHandler(this.btnCrearEmpresa_Click);
            // 
            // btnCrearPersona
            // 
            this.btnCrearPersona.Location = new System.Drawing.Point(25, 26);
            this.btnCrearPersona.Name = "btnCrearPersona";
            this.btnCrearPersona.Size = new System.Drawing.Size(155, 23);
            this.btnCrearPersona.TabIndex = 2;
            this.btnCrearPersona.Text = "Crear Persona";
            this.btnCrearPersona.UseVisualStyleBackColor = true;
            this.btnCrearPersona.Click += new System.EventHandler(this.btnCrearPersona_Click);
            // 
            // btnCrearDocComercial
            // 
            this.btnCrearDocComercial.Location = new System.Drawing.Point(25, 85);
            this.btnCrearDocComercial.Name = "btnCrearDocComercial";
            this.btnCrearDocComercial.Size = new System.Drawing.Size(155, 23);
            this.btnCrearDocComercial.TabIndex = 3;
            this.btnCrearDocComercial.Text = "Crear Documento Comercial";
            this.btnCrearDocComercial.UseVisualStyleBackColor = true;
            this.btnCrearDocComercial.Click += new System.EventHandler(this.btnCrearDocComercial_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 135);
            this.Controls.Add(this.btnCrearDocComercial);
            this.Controls.Add(this.btnCrearPersona);
            this.Controls.Add(this.btnCrearEmpresa);
            this.Controls.Add(this.btnCrearProducto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearProducto;
        private System.Windows.Forms.Button btnCrearEmpresa;
        private System.Windows.Forms.Button btnCrearPersona;
        private System.Windows.Forms.Button btnCrearDocComercial;
    }
}

