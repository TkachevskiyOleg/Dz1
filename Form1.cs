namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            string info = $"Name:{textBox1.Text}\nLast_Name:{textBox2.Text}\nAge{textBox3.Text}";
            MessageBox.Show(info, "Rezume", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}