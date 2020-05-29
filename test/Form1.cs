using System;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        Estudiante juanpablo;

        private void Form1_Load(object sender, EventArgs e)
        {
            juanpablo = new Estudiante();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("yayyyyy");


            juanpablo.TomarExamen();
            tbNota1.Text = juanpablo.nota1.ToString();
            tbNota2.Text = juanpablo.nota2.ToString();
            tbNota3.Text = juanpablo.nota3.ToString();
        }
    }



    public class Estudiante
    {
        public int nota1;
        public int nota2;
        public int nota3;

        public Estudiante()
        {
            nota1 = 0;
            nota2 = 0;
            nota3 = 0;
        }

        public void TomarExamen()
        {
            Random rnd = new Random();
            nota1  = rnd.Next(0, 11);
            nota2 = rnd.Next(0, 11);
            nota3 = rnd.Next(0, 11);
        }
    }
}
