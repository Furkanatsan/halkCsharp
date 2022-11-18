namespace introduceDesktopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = new Button();
            button.Top = 250;
            button.Left = 250;
            button.Text = "Runtime...";

            button.Click += Runtime_Click;


            this.Controls.Add(button);
        }

        private void Runtime_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Runtime butonuna tıklandı");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}