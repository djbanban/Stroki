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
        }

        private void FindSubStrBTN_Click(object sender, EventArgs e)
        {
            Out.Text = KMP(Converter(SubStrInput.Text, CheckType(SubStrInput.Text)), Converter(StrInput.Text, CheckType(StrInput.Text)));
        }
        private void TransformTypeBTN_Click(object sender, EventArgs e)
        {
            Out.Text = $"Начальный тип: {CheckType(StrInput.Text)}\nПреобразованный текст: {Converter(StrInput.Text, CheckType(StrInput.Text))}";
        }
    }
}