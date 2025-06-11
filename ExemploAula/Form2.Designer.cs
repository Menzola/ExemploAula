namespace ExemploAula
{
    partial class frm_menu
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
            lbl_login = new Label();
            btn_logout = new Button();
            SuspendLayout();
            // 
            // lbl_login
            // 
            lbl_login.AutoSize = true;
            lbl_login.Font = new Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_login.Location = new Point(191, 9);
            lbl_login.Name = "lbl_login";
            lbl_login.Size = new Size(406, 41);
            lbl_login.TabIndex = 2;
            lbl_login.Text = "Seja bem-vindo, Admin!";
            // 
            // btn_logout
            // 
            btn_logout.Font = new Font("Arial", 14.25F);
            btn_logout.Location = new Point(306, 378);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(169, 51);
            btn_logout.TabIndex = 7;
            btn_logout.Text = "Logout";
            btn_logout.UseVisualStyleBackColor = true;
            btn_logout.Click += btn_logout_Click;
            // 
            // frm_menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_logout);
            Controls.Add(lbl_login);
            Name = "frm_menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_login;
        private Button btn_logout;
    }
}