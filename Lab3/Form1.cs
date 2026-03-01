using static Lab3.Triangle;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Очищення всіх полів вводу
        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox textBox)
                {
                    textBox.Clear();
                }
            }
            listResult.Items.Clear();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtSideA.Text);
                double b = double.Parse(txtSideB.Text);
                double angle = double.Parse(txtAngle.Text);

                // реалізація поліморфізму: при запуску виконується відповідний перевизначений метод
                Triangle triangle = TriangleFactory.Create(a, b, angle);

                listResult.Items.Clear();
                listResult.Items.Add($"Тип трикутника: {triangle.GetType().Name}");
                listResult.Items.Add($"Периметр = {triangle.Perimeter():F3}");
                listResult.Items.Add($"Площа = {triangle.Area():F3}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
