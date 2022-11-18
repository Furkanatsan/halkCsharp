namespace SchoolDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillClassDepartments();
        }

        private void fillClassDepartments()
        {
            var names = Enum.GetNames<Departments>();
            names.ToList().ForEach(n => comboBoxBolum.Items.Add(n));
        }
    }
}