namespace InterfazTecnico
{
    partial class ClienteConsultaReparacion
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
            this.btnClienteIngresar = new System.Windows.Forms.Button();
            this.txtboxToken = new System.Windows.Forms.TextBox();
            this.txtboxClienteDni = new System.Windows.Forms.TextBox();
            this.lblClienteToken = new System.Windows.Forms.Label();
            this.lblClienteDni = new System.Windows.Forms.Label();
            this.lblClienteIniciarSesion = new System.Windows.Forms.Label();
            this.lblClienteFixify = new System.Windows.Forms.Label();
            this.btnClienteSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClienteIngresar
            // 
            this.btnClienteIngresar.Location = new System.Drawing.Point(300, 334);
            this.btnClienteIngresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClienteIngresar.Name = "btnClienteIngresar";
            this.btnClienteIngresar.Size = new System.Drawing.Size(116, 33);
            this.btnClienteIngresar.TabIndex = 17;
            this.btnClienteIngresar.Text = "&Ingresar";
            this.btnClienteIngresar.UseVisualStyleBackColor = true;
            this.btnClienteIngresar.Click += new System.EventHandler(this.btnClienteIngresar_Click);
            // 
            // txtboxToken
            // 
            this.txtboxToken.Location = new System.Drawing.Point(239, 274);
            this.txtboxToken.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtboxToken.Name = "txtboxToken";
            this.txtboxToken.Size = new System.Drawing.Size(227, 22);
            this.txtboxToken.TabIndex = 16;
            // 
            // txtboxClienteDni
            // 
            this.txtboxClienteDni.Location = new System.Drawing.Point(239, 183);
            this.txtboxClienteDni.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtboxClienteDni.Name = "txtboxClienteDni";
            this.txtboxClienteDni.Size = new System.Drawing.Size(227, 22);
            this.txtboxClienteDni.TabIndex = 15;
            // 
            // lblClienteToken
            // 
            this.lblClienteToken.AutoSize = true;
            this.lblClienteToken.Location = new System.Drawing.Point(284, 236);
            this.lblClienteToken.Name = "lblClienteToken";
            this.lblClienteToken.Size = new System.Drawing.Size(136, 16);
            this.lblClienteToken.TabIndex = 14;
            this.lblClienteToken.Text = "Token de reparación:";
            // 
            // lblClienteDni
            // 
            this.lblClienteDni.AutoSize = true;
            this.lblClienteDni.Location = new System.Drawing.Point(337, 150);
            this.lblClienteDni.Name = "lblClienteDni";
            this.lblClienteDni.Size = new System.Drawing.Size(33, 16);
            this.lblClienteDni.TabIndex = 13;
            this.lblClienteDni.Text = "DNI:";
            // 
            // lblClienteIniciarSesion
            // 
            this.lblClienteIniciarSesion.AutoSize = true;
            this.lblClienteIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteIniciarSesion.Location = new System.Drawing.Point(261, 84);
            this.lblClienteIniciarSesion.Name = "lblClienteIniciarSesion";
            this.lblClienteIniciarSesion.Size = new System.Drawing.Size(164, 24);
            this.lblClienteIniciarSesion.TabIndex = 12;
            this.lblClienteIniciarSesion.Text = "INICIAR SESION";
            // 
            // lblClienteFixify
            // 
            this.lblClienteFixify.AutoSize = true;
            this.lblClienteFixify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteFixify.Location = new System.Drawing.Point(260, 39);
            this.lblClienteFixify.Name = "lblClienteFixify";
            this.lblClienteFixify.Size = new System.Drawing.Size(154, 25);
            this.lblClienteFixify.TabIndex = 11;
            this.lblClienteFixify.Text = "Fixify Software";
            // 
            // btnClienteSalir
            // 
            this.btnClienteSalir.Location = new System.Drawing.Point(609, 434);
            this.btnClienteSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClienteSalir.Name = "btnClienteSalir";
            this.btnClienteSalir.Size = new System.Drawing.Size(76, 26);
            this.btnClienteSalir.TabIndex = 20;
            this.btnClienteSalir.Text = "&Atrás";
            this.btnClienteSalir.UseVisualStyleBackColor = true;
            this.btnClienteSalir.Click += new System.EventHandler(this.btnClienteSalir_Click);
            // 
            // ClienteConsultaReparacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 474);
            this.Controls.Add(this.btnClienteSalir);
            this.Controls.Add(this.btnClienteIngresar);
            this.Controls.Add(this.txtboxToken);
            this.Controls.Add(this.txtboxClienteDni);
            this.Controls.Add(this.lblClienteToken);
            this.Controls.Add(this.lblClienteDni);
            this.Controls.Add(this.lblClienteIniciarSesion);
            this.Controls.Add(this.lblClienteFixify);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ClienteConsultaReparacion";
            this.Text = "Iniciar sesión";
            this.Load += new System.EventHandler(this.ClienteConsultaReparacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClienteIngresar;
        private System.Windows.Forms.TextBox txtboxToken;
        private System.Windows.Forms.TextBox txtboxClienteDni;
        private System.Windows.Forms.Label lblClienteToken;
        private System.Windows.Forms.Label lblClienteDni;
        private System.Windows.Forms.Label lblClienteIniciarSesion;
        private System.Windows.Forms.Label lblClienteFixify;
        private System.Windows.Forms.Button btnClienteSalir;
    }
}