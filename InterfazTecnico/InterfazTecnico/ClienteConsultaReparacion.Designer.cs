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
            this.btnClienteIngresar.Location = new System.Drawing.Point(225, 271);
            this.btnClienteIngresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnClienteIngresar.Name = "btnClienteIngresar";
            this.btnClienteIngresar.Size = new System.Drawing.Size(87, 27);
            this.btnClienteIngresar.TabIndex = 17;
            this.btnClienteIngresar.Text = "&Ingresar";
            this.btnClienteIngresar.UseVisualStyleBackColor = true;
            this.btnClienteIngresar.Click += new System.EventHandler(this.btnClienteIngresar_Click);
            // 
            // txtboxToken
            // 
            this.txtboxToken.Location = new System.Drawing.Point(179, 223);
            this.txtboxToken.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxToken.Name = "txtboxToken";
            this.txtboxToken.Size = new System.Drawing.Size(171, 20);
            this.txtboxToken.TabIndex = 16;
            // 
            // txtboxClienteDni
            // 
            this.txtboxClienteDni.Location = new System.Drawing.Point(179, 149);
            this.txtboxClienteDni.Margin = new System.Windows.Forms.Padding(2);
            this.txtboxClienteDni.Name = "txtboxClienteDni";
            this.txtboxClienteDni.Size = new System.Drawing.Size(171, 20);
            this.txtboxClienteDni.TabIndex = 15;
            // 
            // lblClienteToken
            // 
            this.lblClienteToken.AutoSize = true;
            this.lblClienteToken.Location = new System.Drawing.Point(213, 192);
            this.lblClienteToken.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClienteToken.Name = "lblClienteToken";
            this.lblClienteToken.Size = new System.Drawing.Size(109, 13);
            this.lblClienteToken.TabIndex = 14;
            this.lblClienteToken.Text = "Token de reparación:";
            // 
            // lblClienteDni
            // 
            this.lblClienteDni.AutoSize = true;
            this.lblClienteDni.Location = new System.Drawing.Point(253, 122);
            this.lblClienteDni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClienteDni.Name = "lblClienteDni";
            this.lblClienteDni.Size = new System.Drawing.Size(29, 13);
            this.lblClienteDni.TabIndex = 13;
            this.lblClienteDni.Text = "DNI:";
            // 
            // lblClienteIniciarSesion
            // 
            this.lblClienteIniciarSesion.AutoSize = true;
            this.lblClienteIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteIniciarSesion.Location = new System.Drawing.Point(196, 68);
            this.lblClienteIniciarSesion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClienteIniciarSesion.Name = "lblClienteIniciarSesion";
            this.lblClienteIniciarSesion.Size = new System.Drawing.Size(133, 18);
            this.lblClienteIniciarSesion.TabIndex = 12;
            this.lblClienteIniciarSesion.Text = "INICIAR SESION";
            // 
            // lblClienteFixify
            // 
            this.lblClienteFixify.AutoSize = true;
            this.lblClienteFixify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteFixify.Location = new System.Drawing.Point(195, 32);
            this.lblClienteFixify.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClienteFixify.Name = "lblClienteFixify";
            this.lblClienteFixify.Size = new System.Drawing.Size(127, 20);
            this.lblClienteFixify.TabIndex = 11;
            this.lblClienteFixify.Text = "Fixify Software";
            // 
            // btnClienteSalir
            // 
            this.btnClienteSalir.Location = new System.Drawing.Point(457, 353);
            this.btnClienteSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnClienteSalir.Name = "btnClienteSalir";
            this.btnClienteSalir.Size = new System.Drawing.Size(57, 21);
            this.btnClienteSalir.TabIndex = 20;
            this.btnClienteSalir.Text = "&Atrás";
            this.btnClienteSalir.UseVisualStyleBackColor = true;
            this.btnClienteSalir.Click += new System.EventHandler(this.btnClienteSalir_Click);
            // 
            // ClienteConsultaReparacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 385);
            this.Controls.Add(this.btnClienteSalir);
            this.Controls.Add(this.btnClienteIngresar);
            this.Controls.Add(this.txtboxToken);
            this.Controls.Add(this.txtboxClienteDni);
            this.Controls.Add(this.lblClienteToken);
            this.Controls.Add(this.lblClienteDni);
            this.Controls.Add(this.lblClienteIniciarSesion);
            this.Controls.Add(this.lblClienteFixify);
            this.Name = "ClienteConsultaReparacion";
            this.Text = "Iniciar sesión";
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