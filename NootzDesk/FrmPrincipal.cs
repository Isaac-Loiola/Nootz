using NootzClass;

namespace NootzDesk
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdicionar01_Click(object sender, EventArgs e)
        {
            Note note = new(textBox1.Text, 1);
            note.Adicionar();
        }

        private void btnAdicionar02_Click(object sender, EventArgs e)
        {
            Note note = new(textBox2.Text, 2);
            note.Adicionar();
        }

        private void btnAdicionar03_Click(object sender, EventArgs e)
        {
            Note note = new(textBox3.Text, 3);
            note.Adicionar();
        }

        private void btnAdicionar04_Click(object sender, EventArgs e)
        {
            Note note = new(textBox4.Text, 4);
            note.Adicionar();

        }

        private void btnAdicionar05_Click(object sender, EventArgs e)
        {
            Note note = new(textBox5.Text, 5);
            note.Adicionar();
        }

        private void btnAdicionar06_Click(object sender, EventArgs e)
        {
            Note note = new(textBox6.Text, 6);
            note.Adicionar();
        }

        private void btnAdicionar07_Click(object sender, EventArgs e)
        {
            Note note = new(textBox7.Text, 7);
            note.Adicionar();
        }

        private void btnAdicionar08_Click(object sender, EventArgs e)
        {
            Note note = new(textBox8.Text, 8);
            note.Adicionar();
        }

        private void btnExcluir01_Click(object sender, EventArgs e)
        {
            Note.Excluir(1);
            textBox1.Text = "";
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            textBox1.Text = Note.BuscarRegistro(1);

            textBox2.Text = Note.BuscarRegistro(2);

            textBox3.Text = Note.BuscarRegistro(3);

            textBox4.Text = Note.BuscarRegistro(4);

            textBox5.Text = Note.BuscarRegistro(5);

            textBox6.Text = Note.BuscarRegistro(6);

            textBox7.Text = Note.BuscarRegistro(7);

            textBox8.Text = Note.BuscarRegistro(8);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExcluir02_Click(object sender, EventArgs e)
        {
            Note.Excluir(2);
            textBox1.Text = "";
        }

        private void btnExcluir03_Click(object sender, EventArgs e)
        {
            Note.Excluir(3);
            textBox1.Text = "";
        }

        private void btnExcluir04_Click(object sender, EventArgs e)
        {
            Note.Excluir(4);
            textBox1.Text = "";
        }

        private void btnExluir05_Click(object sender, EventArgs e)
        {
            Note.Excluir(5);
            textBox1.Text = "";
        }

        private void btnExcluir06_Click(object sender, EventArgs e)
        {
            Note.Excluir(6);
            textBox1.Text = "";
        }

        private void btnExcluir07_Click(object sender, EventArgs e)
        {
            Note.Excluir(7);
            textBox1.Text = "";
        }

        private void btnExcluir08_Click(object sender, EventArgs e)
        {
            Note.Excluir(8);
            textBox1.Text = "";
        }
    }
}

