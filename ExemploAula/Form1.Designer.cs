namespace ExemploAula
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_login = new Label();
            label1 = new Label();
            lbl_usuario = new Label();
            lbl_senha = new Label();
            btn_login = new Button();
            txt_usuario = new TextBox();
            txt_senha = new TextBox();
            SuspendLayout();
            // 
            // lbl_login
            // 
            lbl_login.AutoSize = true;
            lbl_login.Font = new Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_login.Location = new Point(323, 9);
            lbl_login.Name = "lbl_login";
            lbl_login.Size = new Size(110, 41);
            lbl_login.TabIndex = 1;
            lbl_login.Text = "Login";
            lbl_login.Click += lbl_login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 102);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            // 
            // lbl_usuario
            // 
            lbl_usuario.AutoSize = true;
            lbl_usuario.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_usuario.Location = new Point(197, 102);
            lbl_usuario.Name = "lbl_usuario";
            lbl_usuario.Size = new Size(74, 22);
            lbl_usuario.TabIndex = 4;
            lbl_usuario.Text = "Usuário";
            // 
            // lbl_senha
            // 
            lbl_senha.AutoSize = true;
            lbl_senha.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_senha.Location = new Point(197, 209);
            lbl_senha.Name = "lbl_senha";
            lbl_senha.Size = new Size(64, 22);
            lbl_senha.TabIndex = 5;
            lbl_senha.Text = "Senha";
            // 
            // btn_login
            // 
            btn_login.Font = new Font("Arial", 14.25F);
            btn_login.Location = new Point(300, 345);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(169, 51);
            btn_login.TabIndex = 6;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // txt_usuario
            // 
            txt_usuario.Location = new Point(455, 102);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(100, 23);
            txt_usuario.TabIndex = 7;
            // 
            // txt_senha
            // 
            txt_senha.Location = new Point(455, 212);
            txt_senha.Name = "txt_senha";
            txt_senha.PasswordChar = '*';
            txt_senha.Size = new Size(100, 23);
            txt_senha.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_senha);
            Controls.Add(txt_usuario);
            Controls.Add(btn_login);
            Controls.Add(lbl_senha);
            Controls.Add(lbl_usuario);
            Controls.Add(label1);
            Controls.Add(lbl_login);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_login;
        private Label label1;
        private Label lbl_usuario;
        private Label lbl_senha;
        private Button btn_login;
        private TextBox txt_usuario;
        private TextBox txt_senha;
    }
}
