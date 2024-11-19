namespace Vectores
{
    public partial class Form1 : Form
    {
        private int[] vector;
        public Form1()
        {
            InitializeComponent();

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Validar el tama�o ingresado
            if (int.TryParse(txtsize.Text, out int tama�o) && tama�o > 0)
            {
                vector = new int[tama�o]; // Crear vector din�mico
                MessageBox.Show($"Vector de tama�o {tama�o} generado correctamente.", "�xito");
            }
            else
            {
                MessageBox.Show("Ingrese un tama�o v�lido (entero positivo).", "Error");
            }

        }

        private void btnfill_Click(object sender, EventArgs e)
        {
            if (vector == null)
            {
                MessageBox.Show("Primero genere un vector.", "Error");
                return;
            }

            Random random = new Random();
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = random.Next(1, 101); // Llenar con n�meros aleatorios entre 1 y 100
            }
            MessageBox.Show("Vector llenado con n�meros aleatorios.", "�xito");
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            if (vector == null)
            {
                MessageBox.Show("Primero genere un vector.", "Error");
                return;
            }

            listBoxResults.Items.Clear(); // Limpiar resultados previos
            for (int i = 0; i < vector.Length; i++)
            {
                listBoxResults.Items.Add($"�ndice {i}: {vector[i]}");
            }
        }
    }
}
