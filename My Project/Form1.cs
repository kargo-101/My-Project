namespace My_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string username=txtName.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enetr your name");
            }
        }
    }
}
