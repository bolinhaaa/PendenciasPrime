namespace PrimePendencias
{
    partial class frmAddPendencias
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
            this.txtNumeroPendencia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPallet = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPallet = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblUsuarioAdd = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumeroPendencia
            // 
            this.txtNumeroPendencia.Location = new System.Drawing.Point(186, 67);
            this.txtNumeroPendencia.Name = "txtNumeroPendencia";
            this.txtNumeroPendencia.Size = new System.Drawing.Size(100, 21);
            this.txtNumeroPendencia.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Digite o Número";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(26, 326);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(58, 19);
            this.lblUsuario.TabIndex = 13;
            this.lblUsuario.Text = "Usúario";
            this.lblUsuario.UseWaitCursor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(26, 250);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 19);
            this.lblStatus.TabIndex = 14;
            this.lblStatus.Text = "Status";
            this.lblStatus.UseWaitCursor = true;
            // 
            // lblPallet
            // 
            this.lblPallet.AutoSize = true;
            this.lblPallet.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPallet.Location = new System.Drawing.Point(26, 189);
            this.lblPallet.Name = "lblPallet";
            this.lblPallet.Size = new System.Drawing.Size(47, 19);
            this.lblPallet.TabIndex = 15;
            this.lblPallet.Text = "Pallet";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(620, 68);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(119, 31);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPallet
            // 
            this.txtPallet.Location = new System.Drawing.Point(186, 189);
            this.txtPallet.Name = "txtPallet";
            this.txtPallet.Size = new System.Drawing.Size(100, 21);
            this.txtPallet.TabIndex = 17;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(186, 248);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(100, 21);
            this.txtStatus.TabIndex = 17;
            // 
            // lblUsuarioAdd
            // 
            this.lblUsuarioAdd.AutoSize = true;
            this.lblUsuarioAdd.Location = new System.Drawing.Point(186, 326);
            this.lblUsuarioAdd.Name = "lblUsuarioAdd";
            this.lblUsuarioAdd.Size = new System.Drawing.Size(0, 16);
            this.lblUsuarioAdd.TabIndex = 18;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(186, 135);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 21);
            this.txtNome.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nome";
            // 
            // frmAddPendencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 390);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblUsuarioAdd);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtPallet);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblPallet);
            this.Controls.Add(this.txtNumeroPendencia);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAddPendencias";
            this.Text = "ADICIONAR PENDENCIAS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumeroPendencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPallet;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPallet;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblUsuarioAdd;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
    }
}