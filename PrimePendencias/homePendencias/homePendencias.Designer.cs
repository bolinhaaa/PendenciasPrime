namespace PrimePendencias
{
    partial class homePendencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homePendencias));
            this.picWebSite = new System.Windows.Forms.PictureBox();
            this.picFace = new System.Windows.Forms.PictureBox();
            this.lblSite = new System.Windows.Forms.Label();
            this.lblFace = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picWebSite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).BeginInit();
            this.SuspendLayout();
            // 
            // picWebSite
            // 
            this.picWebSite.Image = ((System.Drawing.Image)(resources.GetObject("picWebSite.Image")));
            this.picWebSite.Location = new System.Drawing.Point(210, 138);
            this.picWebSite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picWebSite.Name = "picWebSite";
            this.picWebSite.Size = new System.Drawing.Size(117, 123);
            this.picWebSite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picWebSite.TabIndex = 0;
            this.picWebSite.TabStop = false;
            this.picWebSite.Click += new System.EventHandler(this.picWebSite_Click);
            // 
            // picFace
            // 
            this.picFace.Image = ((System.Drawing.Image)(resources.GetObject("picFace.Image")));
            this.picFace.Location = new System.Drawing.Point(480, 138);
            this.picFace.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picFace.Name = "picFace";
            this.picFace.Size = new System.Drawing.Size(117, 123);
            this.picFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picFace.TabIndex = 0;
            this.picFace.TabStop = false;
            this.picFace.Click += new System.EventHandler(this.picFace_Click);
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSite.Location = new System.Drawing.Point(241, 270);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(55, 30);
            this.lblSite.TabIndex = 1;
            this.lblSite.Text = "Site";
            // 
            // lblFace
            // 
            this.lblFace.AutoSize = true;
            this.lblFace.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFace.Location = new System.Drawing.Point(472, 270);
            this.lblFace.Name = "lblFace";
            this.lblFace.Size = new System.Drawing.Size(133, 30);
            this.lblFace.TabIndex = 1;
            this.lblFace.Text = "Facebook";
            // 
            // homePendencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1003, 480);
            this.Controls.Add(this.lblFace);
            this.Controls.Add(this.lblSite);
            this.Controls.Add(this.picFace);
            this.Controls.Add(this.picWebSite);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "homePendencias";
            this.Text = "homePendencias";
            ((System.ComponentModel.ISupportInitialize)(this.picWebSite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picWebSite;
        private System.Windows.Forms.PictureBox picFace;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.Label lblFace;
    }
}