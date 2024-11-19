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
            // Validar el tamaño ingresado
            if (int.TryParse(txtsize.Text, out int tamaño) && tamaño > 0)
            {
                vector = new int[tamaño]; // Crear vector dinámico
                MessageBox.Show($"Vector de tamaño {tamaño} generado correctamente.", "Éxito");
            }
            else
            {
                MessageBox.Show("Ingrese un tamaño válido (entero positivo).", "Error");
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
                vector[i] = random.Next(1, 101); // Llenar con números aleatorios entre 1 y 100
            }
            MessageBox.Show("Vector llenado con números aleatorios.", "Éxito");
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
                listBoxResults.Items.Add($"Índice {i}: {vector[i]}");
            }
        }
    }
}
