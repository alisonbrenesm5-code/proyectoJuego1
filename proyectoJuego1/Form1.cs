namespace proyectoJuego1
{
    public partial class Form1 : Form
    {
        float a = 0, b = 0, resultado = 0;
        int opee = 0, limite = 11;
        char operador = ' ';


        public Form1()
        {
            InitializeComponent();
        }

        private void Seleccion_Operacion()
        {
            a = Random.Shared.Next(1, limite);
            b = Random.Shared.Next(1, limite);
            opee = Random.Shared.Next(1, 5);

            switch (opee)
            {
                case 1:
                    operador = '-';
                    resultado = a + b;
                    break;
                case 2:
                    operador = '-';
                    resultado = a - b;
                    break;
                case 4:
                    operador = '*';
                    resultado = a * b;
                    break;


                default:
                    break;
            }

            n1.Text = a.ToString();
            n2.Text = b.ToString();
            op.Text = operador.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Llama aquí el método o código que genera los números
            Seleccion_Operacion(); // O el nombre del método que usa tu profe


            if (float.Parse(tresultado.Text).Equals(resultado))
            {
                MessageBox.Show("Correcto");
                laciertos.Text = (int.Parse(laciertos.Text) + 1).ToString();
            }
            else
            {
                MessageBox.Show("Incorrecto");
                lerrores.Text = (int.Parse(lerrores.Text) + 1).ToString();
            }
            Seleccion_Operacion();
        }
    }
}
