namespace AlmaDB
{
    partial class LoginForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Merchant = new System.Windows.Forms.RadioButton();
            this.MerchantManager = new System.Windows.Forms.RadioButton();
            this.MagazineManager = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.desc = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Zaloguj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MagazineManager);
            this.groupBox1.Controls.Add(this.MerchantManager);
            this.groupBox1.Controls.Add(this.Merchant);
            this.groupBox1.Location = new System.Drawing.Point(29, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 95);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wybierz funkcję";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Merchant
            // 
            this.Merchant.AutoSize = true;
            this.Merchant.Enabled = false;
            this.Merchant.Location = new System.Drawing.Point(17, 20);
            this.Merchant.Name = "Merchant";
            this.Merchant.Size = new System.Drawing.Size(83, 17);
            this.Merchant.TabIndex = 0;
            this.Merchant.TabStop = true;
            this.Merchant.Text = "Sprzedający";
            this.Merchant.UseVisualStyleBackColor = true;
            this.Merchant.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // MerchantManager
            // 
            this.MerchantManager.AutoSize = true;
            this.MerchantManager.Location = new System.Drawing.Point(17, 45);
            this.MerchantManager.Name = "MerchantManager";
            this.MerchantManager.Size = new System.Drawing.Size(141, 17);
            this.MerchantManager.TabIndex = 1;
            this.MerchantManager.TabStop = true;
            this.MerchantManager.Text = "Kierownik Sprzedawców";
            this.MerchantManager.UseVisualStyleBackColor = true;
            // 
            // MagazineManager
            // 
            this.MagazineManager.AutoSize = true;
            this.MagazineManager.Location = new System.Drawing.Point(17, 68);
            this.MagazineManager.Name = "MagazineManager";
            this.MagazineManager.Size = new System.Drawing.Size(79, 17);
            this.MagazineManager.TabIndex = 2;
            this.MagazineManager.TabStop = true;
            this.MagazineManager.Text = "Magazynier";
            this.MagazineManager.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(29, 108);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(255, 20);
            this.textBox2.TabIndex = 3;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(28, 37);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(104, 13);
            this.Username.TabIndex = 4;
            this.Username.Text = "Nazwa Użytkownika";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(29, 87);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(36, 13);
            this.Password.TabIndex = 5;
            this.Password.Text = "Hasło";
            this.Password.Click += new System.EventHandler(this.label1_Click);
            // 
            // desc
            // 
            this.desc.AutoSize = true;
            this.desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.desc.ForeColor = System.Drawing.Color.ForestGreen;
            this.desc.Location = new System.Drawing.Point(28, 9);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(256, 15);
            this.desc.TabIndex = 6;
            this.desc.Text = "Witaj w systemie obsługi sklepów Alma";
            this.desc.Click += new System.EventHandler(this.desc_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 262);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton MagazineManager;
        private System.Windows.Forms.RadioButton MerchantManager;
        private System.Windows.Forms.RadioButton Merchant;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Label desc;
    }
}