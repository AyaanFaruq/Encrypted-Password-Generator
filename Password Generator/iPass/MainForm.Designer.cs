namespace iPass
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_generatepass = new System.Windows.Forms.Button();
            this.trckbar_length = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_passlength = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txb_password = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trckbar_length)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_generatepass
            // 
            this.btn_generatepass.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_generatepass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_generatepass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_generatepass.Location = new System.Drawing.Point(188, 103);
            this.btn_generatepass.Name = "btn_generatepass";
            this.btn_generatepass.Size = new System.Drawing.Size(155, 31);
            this.btn_generatepass.TabIndex = 0;
            this.btn_generatepass.Text = "Generate a password";
            this.btn_generatepass.UseVisualStyleBackColor = false;
            this.btn_generatepass.Click += new System.EventHandler(this.btn_generatepass_Click);
            // 
            // trckbar_length
            // 
            this.trckbar_length.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trckbar_length.Location = new System.Drawing.Point(140, 50);
            this.trckbar_length.Maximum = 19;
            this.trckbar_length.Name = "trckbar_length";
            this.trckbar_length.Size = new System.Drawing.Size(263, 45);
            this.trckbar_length.TabIndex = 2;
            this.trckbar_length.ValueChanged += new System.EventHandler(this.trckbar_length_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(192, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Passwords length :";
            // 
            // lbl_passlength
            // 
            this.lbl_passlength.AutoSize = true;
            this.lbl_passlength.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_passlength.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_passlength.Location = new System.Drawing.Point(317, 23);
            this.lbl_passlength.Name = "lbl_passlength";
            this.lbl_passlength.Size = new System.Drawing.Size(15, 15);
            this.lbl_passlength.TabIndex = 4;
            this.lbl_passlength.Text = "1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.panel1.Controls.Add(this.trckbar_length);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_generatepass);
            this.panel1.Controls.Add(this.lbl_passlength);
            this.panel1.Location = new System.Drawing.Point(-1, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 162);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MicrogrammaDMedExt", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(30, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Decrypted Password";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrchid;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(-1, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(539, 39);
            this.panel2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("MicrogrammaDMedExt", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(28, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(463, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Make Your Password Secure Encrypted ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrchid;
            this.panel3.Controls.Add(this.txb_password);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(-1, 244);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(539, 39);
            this.panel3.TabIndex = 8;
            // 
            // txb_password
            // 
            this.txb_password.BackColor = System.Drawing.Color.Gainsboro;
            this.txb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_password.Location = new System.Drawing.Point(286, 3);
            this.txb_password.Multiline = true;
            this.txb_password.Name = "txb_password";
            this.txb_password.Size = new System.Drawing.Size(205, 30);
            this.txb_password.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(533, 284);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encrypt Your Password";
            ((System.ComponentModel.ISupportInitialize)(this.trckbar_length)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_generatepass;
        private System.Windows.Forms.TrackBar trckbar_length;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_passlength;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txb_password;
    }
}

