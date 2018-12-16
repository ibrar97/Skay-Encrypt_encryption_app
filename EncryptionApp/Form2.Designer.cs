namespace EncryptionApp
{
    partial class EncryptionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EncryptionForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_filepath = new System.Windows.Forms.TextBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_password = new System.Windows.Forms.TextBox();
            this.btn_encrypt_it = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(136, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Encryption";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbox_filepath
            // 
            this.txtbox_filepath.Location = new System.Drawing.Point(16, 46);
            this.txtbox_filepath.Name = "txtbox_filepath";
            this.txtbox_filepath.ReadOnly = true;
            this.txtbox_filepath.Size = new System.Drawing.Size(302, 20);
            this.txtbox_filepath.TabIndex = 1;
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(324, 44);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 23);
            this.btn_browse.TabIndex = 2;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter password";
            // 
            // txtbox_password
            // 
            this.txtbox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_password.ForeColor = System.Drawing.Color.Maroon;
            this.txtbox_password.Location = new System.Drawing.Point(104, 75);
            this.txtbox_password.Name = "txtbox_password";
            this.txtbox_password.PasswordChar = '*';
            this.txtbox_password.Size = new System.Drawing.Size(213, 22);
            this.txtbox_password.TabIndex = 4;
            // 
            // btn_encrypt_it
            // 
            this.btn_encrypt_it.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_encrypt_it.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_encrypt_it.Location = new System.Drawing.Point(162, 104);
            this.btn_encrypt_it.Name = "btn_encrypt_it";
            this.btn_encrypt_it.Size = new System.Drawing.Size(105, 38);
            this.btn_encrypt_it.TabIndex = 5;
            this.btn_encrypt_it.Text = "Encrypt it !";
            this.btn_encrypt_it.UseVisualStyleBackColor = true;
            this.btn_encrypt_it.Click += new System.EventHandler(this.btn_encrypt_it_Click);
            // 
            // EncryptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 164);
            this.Controls.Add(this.btn_encrypt_it);
            this.Controls.Add(this.txtbox_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.txtbox_filepath);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(449, 203);
            this.MinimumSize = new System.Drawing.Size(449, 203);
            this.Name = "EncryptionForm";
            this.Text = "Skay-Encrypt ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_filepath;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_password;
        private System.Windows.Forms.Button btn_encrypt_it;
    }
}