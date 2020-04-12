namespace PrimePendencias
{
    partial class frmEditarStatusPendencia
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
            this.txtStatus2 = new System.Windows.Forms.TextBox();
            this.txtStatus1 = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPallet = new System.Windows.Forms.Label();
            this.txtStatus3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtStatus2
            // 
            this.txtStatus2.Location = new System.Drawing.Point(172, 176);
            this.txtStatus2.Name = "txtStatus2";
            this.txtStatus2.Size = new System.Drawing.Size(100, 20);
            this.txtStatus2.TabIndex = 25;
            // 
            // txtStatus1
            // 
            this.txtStatus1.Location = new System.Drawing.Point(172, 108);
            this.txtStatus1.Name = "txtStatus1";
            this.txtStatus1.Size = new System.Drawing.Size(100, 20);
            this.txtStatus1.TabIndex = 26;
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(534, 54);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(119, 31);
            this.btnEditar.TabIndex = 24;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(12, 244);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(154, 19);
            this.lblUsuario.TabIndex = 21;
            this.lblUsuario.Text = "Status da Pendência";
            this.lblUsuario.UseWaitCursor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(12, 176);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(154, 19);
            this.lblStatus.TabIndex = 22;
            this.lblStatus.Text = "Status da Pendência";
            this.lblStatus.UseWaitCursor = true;
            // 
            // lblPallet
            // 
            this.lblPallet.AutoSize = true;
            this.lblPallet.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPallet.Location = new System.Drawing.Point(12, 108);
            this.lblPallet.Name = "lblPallet";
            this.lblPallet.Size = new System.Drawing.Size(154, 19);
            this.lblPallet.TabIndex = 23;
            this.lblPallet.Text = "Status da Pendência";
            // 
            // txtStatus3
            // 
            this.txtStatus3.Location = new System.Drawing.Point(172, 244);
            this.txtStatus3.Name = "txtStatus3";
            this.txtStatus3.Size = new System.Drawing.Size(100, 20);
            this.txtStatus3.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Edite os status das Pendência";
            // 
            // frmEditarStatusPendencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(860, 390);
            this.Controls.Add(this.txtStatus3);
            this.Controls.Add(this.txtStatus2);
            this.Controls.Add(this.txtStatus1);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPallet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditarStatusPendencia";
            this.Text = "frmEditarStatusPendencia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtStatus2;
        private System.Windows.Forms.TextBox txtStatus1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblPallet;
        private System.Windows.Forms.TextBox txtStatus3;
        private System.Windows.Forms.Label label1;
    }
}