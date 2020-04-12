namespace PrimePendencias
{
    partial class frmBuscarPrimeiro
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
            this.lblPallet = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroPendencia = new System.Windows.Forms.TextBox();
            this.lblPalletResultado = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatusResultado = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblResultadoUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPallet
            // 
            this.lblPallet.AutoSize = true;
            this.lblPallet.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPallet.Location = new System.Drawing.Point(27, 154);
            this.lblPallet.Name = "lblPallet";
            this.lblPallet.Size = new System.Drawing.Size(47, 19);
            this.lblPallet.TabIndex = 12;
            this.lblPallet.Text = "Pallet";
            this.lblPallet.Visible = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(544, 63);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(119, 31);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Digite o Número";
            // 
            // txtNumeroPendencia
            // 
            this.txtNumeroPendencia.Location = new System.Drawing.Point(173, 63);
            this.txtNumeroPendencia.Name = "txtNumeroPendencia";
            this.txtNumeroPendencia.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroPendencia.TabIndex = 0;
            // 
            // lblPalletResultado
            // 
            this.lblPalletResultado.AutoSize = true;
            this.lblPalletResultado.Location = new System.Drawing.Point(173, 159);
            this.lblPalletResultado.Name = "lblPalletResultado";
            this.lblPalletResultado.Size = new System.Drawing.Size(0, 13);
            this.lblPalletResultado.TabIndex = 13;
            this.lblPalletResultado.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(27, 215);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 19);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Status";
            this.lblStatus.UseWaitCursor = true;
            this.lblStatus.Visible = false;
            // 
            // lblStatusResultado
            // 
            this.lblStatusResultado.AutoSize = true;
            this.lblStatusResultado.Location = new System.Drawing.Point(173, 220);
            this.lblStatusResultado.Name = "lblStatusResultado";
            this.lblStatusResultado.Size = new System.Drawing.Size(0, 13);
            this.lblStatusResultado.TabIndex = 13;
            this.lblStatusResultado.UseWaitCursor = true;
            this.lblStatusResultado.Visible = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(27, 291);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(58, 19);
            this.lblUsuario.TabIndex = 12;
            this.lblUsuario.Text = "Usúario";
            this.lblUsuario.UseWaitCursor = true;
            this.lblUsuario.Visible = false;
            // 
            // lblResultadoUsuario
            // 
            this.lblResultadoUsuario.AutoSize = true;
            this.lblResultadoUsuario.Location = new System.Drawing.Point(173, 291);
            this.lblResultadoUsuario.Name = "lblResultadoUsuario";
            this.lblResultadoUsuario.Size = new System.Drawing.Size(0, 13);
            this.lblResultadoUsuario.TabIndex = 13;
            this.lblResultadoUsuario.UseWaitCursor = true;
            this.lblResultadoUsuario.Visible = false;
            // 
            // frmBuscarPrimeiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 390);
            this.Controls.Add(this.lblResultadoUsuario);
            this.Controls.Add(this.lblStatusResultado);
            this.Controls.Add(this.lblPalletResultado);
            this.Controls.Add(this.txtNumeroPendencia);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblPallet);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBuscarPrimeiro";
            this.Text = "frmBuscarPrimeiro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPallet;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroPendencia;
        private System.Windows.Forms.Label lblPalletResultado;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStatusResultado;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblResultadoUsuario;
    }
}