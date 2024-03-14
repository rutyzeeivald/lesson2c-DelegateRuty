namespace delig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //nameValidationTextBox1.InvalidKeyPressed += InvalidKeyPressed;
        }

        private void InvalidKeyPressed()
        {
            MessageBox.Show("Invalid key pressed");
        }
    }
}