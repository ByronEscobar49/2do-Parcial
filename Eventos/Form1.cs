namespace Eventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Pasar(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C://Users//BYRON !//Pictures/1gamer.png";
        }

        private void Afuera(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C://Users//BYRON !//Pictures/2gamer.png";
        }
    }
    }

