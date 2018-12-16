namespace EncryptionApp
{
    partial class DecryptionFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DecryptionFrom));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_INPUT_filePath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbox_password_field = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbox_OUTPUT_path = new System.Windows.Forms.TextBox();
            this.btn_OUTpath_browse = new System.Windows.Forms.Button();
            this.btn_decrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(177, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Decryption";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Browse Encrypted file";
            // 
            // txtbox_INPUT_filePath
            // 
            this.txtbox_INPUT_filePath.Location = new System.Drawing.Point(127, 36);
            this.txtbox_INPUT_filePath.Name = "txtbox_INPUT_filePath";
            this.txtbox_INPUT_filePath.ReadOnly = true;
            this.txtbox_INPUT_filePath.Size = new System.Drawing.Size(335, 20);
            this.txtbox_INPUT_filePath.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(471, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter Password ";
            // 
            // txtbox_password_field
            // 
            this.txtbox_password_field.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_password_field.ForeColor = System.Drawing.Color.Maroon;
            this.txtbox_password_field.Location = new System.Drawing.Point(127, 63);
            this.txtbox_password_field.Name = "txtbox_password_field";
            this.txtbox_password_field.PasswordChar = '*';
            this.txtbox_password_field.Size = new System.Drawing.Size(335, 22);
            this.txtbox_password_field.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Output Decrpted file";
            // 
            // txtbox_OUTPUT_path
            // 
            this.txtbox_OUTPUT_path.Location = new System.Drawing.Point(127, 94);
            this.txtbox_OUTPUT_path.Name = "txtbox_OUTPUT_path";
            this.txtbox_OUTPUT_path.ReadOnly = true;
            this.txtbox_OUTPUT_path.Size = new System.Drawing.Size(342, 20);
            this.txtbox_OUTPUT_path.TabIndex = 7;
            // 
            // btn_OUTpath_browse
            // 
            this.btn_OUTpath_browse.Location = new System.Drawing.Point(475, 92);
            this.btn_OUTpath_browse.Name = "btn_OUTpath_browse";
            this.btn_OUTpath_browse.Size = new System.Drawing.Size(75, 23);
            this.btn_OUTpath_browse.TabIndex = 8;
            this.btn_OUTpath_browse.Text = "Save";
            this.btn_OUTpath_browse.UseVisualStyleBackColor = true;
            this.btn_OUTpath_browse.Click += new System.EventHandler(this.txtbox_OUTpath_Click);
            // 
            // btn_decrypt
            // 
            this.btn_decrypt.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_decrypt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_decrypt.Location = new System.Drawing.Point(214, 130);
            this.btn_decrypt.Name = "btn_decrypt";
            this.btn_decrypt.Size = new System.Drawing.Size(105, 38);
            this.btn_decrypt.TabIndex = 9;
            this.btn_decrypt.Text = "Decrypt";
            this.btn_decrypt.UseVisualStyleBackColor = true;
            this.btn_decrypt.Click += new System.EventHandler(this.btn_decrypt_Click);
            // 
            // DecryptionFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 193);
            this.Controls.Add(this.btn_decrypt);
            this.Controls.Add(this.btn_OUTpath_browse);
            this.Controls.Add(this.txtbox_OUTPUT_path);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbox_password_field);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbox_INPUT_filePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(583, 232);
            this.MinimumSize = new System.Drawing.Size(583, 232);
            this.Name = "DecryptionFrom";
            this.Text = "Skay_Encrypt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_INPUT_filePath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbox_password_field;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbox_OUTPUT_path;
        private System.Windows.Forms.Button btn_OUTpath_browse;
        private System.Windows.Forms.Button btn_decrypt;
    }
}