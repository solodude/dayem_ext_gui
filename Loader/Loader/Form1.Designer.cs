namespace Loader
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_register = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.signin = new System.Windows.Forms.Button();
            this.rememberme = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 98);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button_register
            // 
            this.button_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.button_register.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_register.BackgroundImage")));
            this.button_register.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_register.FlatAppearance.BorderSize = 0;
            this.button_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_register.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_register.ForeColor = System.Drawing.Color.Snow;
            this.button_register.Location = new System.Drawing.Point(0, 325);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(321, 72);
            this.button_register.TabIndex = 2;
            this.button_register.Text = "Register";
            this.button_register.UseVisualStyleBackColor = false;
            this.button_register.MouseLeave += new System.EventHandler(this.button_register_MouseLeave);
            this.button_register.MouseHover += new System.EventHandler(this.button_register_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.rememberme);
            this.panel1.Controls.Add(this.signin);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.username);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 227);
            this.panel1.TabIndex = 3;
            // 
            // username
            // 
            this.username.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username.Font = new System.Drawing.Font("Lato Hairline", 15F);
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.Location = new System.Drawing.Point(12, 32);
            this.username.MaximumSize = new System.Drawing.Size(297, 30);
            this.username.MinimumSize = new System.Drawing.Size(297, 30);
            this.username.Multiline = true;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(297, 30);
            this.username.TabIndex = 0;
            this.username.Text = "Username";
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Font = new System.Drawing.Font("Lato Hairline", 15F);
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.Location = new System.Drawing.Point(12, 85);
            this.password.MaximumSize = new System.Drawing.Size(297, 30);
            this.password.MinimumSize = new System.Drawing.Size(297, 30);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(297, 30);
            this.password.TabIndex = 1;
            this.password.Text = "Password";
            // 
            // signin
            // 
            this.signin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signin.BackgroundImage")));
            this.signin.FlatAppearance.BorderSize = 0;
            this.signin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signin.Font = new System.Drawing.Font("Lato", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signin.ForeColor = System.Drawing.Color.Snow;
            this.signin.Location = new System.Drawing.Point(12, 143);
            this.signin.Name = "signin";
            this.signin.Size = new System.Drawing.Size(297, 42);
            this.signin.TabIndex = 4;
            this.signin.Text = "Sign-in";
            this.signin.UseVisualStyleBackColor = true;
            this.signin.Click += new System.EventHandler(this.button1_Click);
            this.signin.MouseLeave += new System.EventHandler(this.signin_MouseLeave);
            this.signin.MouseHover += new System.EventHandler(this.signin_MouseHover);
            // 
            // rememberme
            // 
            this.rememberme.AutoSize = true;
            this.rememberme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.rememberme.Location = new System.Drawing.Point(12, 191);
            this.rememberme.Name = "rememberme";
            this.rememberme.Size = new System.Drawing.Size(97, 17);
            this.rememberme.TabIndex = 5;
            this.rememberme.Text = "remember me ";
            this.rememberme.UseVisualStyleBackColor = false;
            this.rememberme.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.DarkGray;
            this.button1.Location = new System.Drawing.Point(307, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(11, 12);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 397);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Lato Hairline", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button signin;
        private System.Windows.Forms.CheckBox rememberme;
        private System.Windows.Forms.Button button1;
    }
}

