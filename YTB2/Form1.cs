namespace YTB2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = "Ahmet Aksakal";
            if (string.IsNullOrEmpty(username))
            {
                throw new Exception("Hata");
            }
        }
    }
}
