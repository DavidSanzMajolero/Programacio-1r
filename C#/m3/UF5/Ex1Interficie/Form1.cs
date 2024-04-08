namespace Ex1Interficie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
           MessageBox.Show("Client name: " + textBox1.Text);
        }

        private void button1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (textBox1.Text == "")
            {
                errorProvider1.SetError(textBox1, "Client name is required");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox1, "");
                e.Cancel = false;
            }
        }
    }
}
