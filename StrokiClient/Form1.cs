using static Stroki.Parsing;
namespace StrokiClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckTypeBTN_Click(object sender, EventArgs e)
        {
            Out.Text = CheckType(StrInput.Text);
            Out.Text += $"\n{comboBox1.SelectedIndex}";
        }
    }
}