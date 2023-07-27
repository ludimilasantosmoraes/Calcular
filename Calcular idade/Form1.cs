namespace Calcular_idade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idade = DateTime.Now.Year - dataN.Value.Year;
            if(DateTime.Now.DayOfYear < dataN.Value.DayOfYear)//indica que se o dia do ano do nascimento for maior que o atual então ainda não completou a idade
            {
                idade--;
            }
            label1.Text = $"Idade: {idade} anos";
            MessageBox.Show(idade.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}