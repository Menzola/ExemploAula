namespace ExemploAula
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_login_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(txt_usuario.Text == "Admin" && txt_senha.Text == "123456")
            {
                MessageBox.Show("Usuário Logado Com Sucesso");
                txt_usuario.Clear();
                txt_senha.Clear();

                Hide();
                frm_menu menu = new frm_menu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Usuário/senha invalidos");
                txt_usuario.Clear();
                txt_senha.Clear();
            }
        }
    }
}
