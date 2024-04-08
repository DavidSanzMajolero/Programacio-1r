using System.Text.RegularExpressions;

namespace Ex40
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            if (textAlumno.Text == "")
            {
                errorProvider.SetError(calcular, "Ingresa el nombre del alumno");
                return;
            }
            if (nota1.Text == "" || nota2.Text == "" || nota3.Text == "" || nota4.Text == "" ||
            !EsNumero(nota1.Text) || !EsNumero(nota2.Text) || !EsNumero(nota3.Text) || !EsNumero(nota4.Text))
            {
                errorProvider.SetError(calcular, "Ingresa las notas correctamente");
                return;
            }

            if (float.Parse(nota1.Text) < 0 || float.Parse(nota1.Text) > 10 ||
            float.Parse(nota2.Text) < 0 || float.Parse(nota2.Text) > 10 ||
            float.Parse(nota3.Text) < 0 || float.Parse(nota3.Text) > 10 ||
            float.Parse(nota4.Text) < 0 || float.Parse(nota4.Text) > 10)
            {
                errorProvider.SetError(calcular, "Las notas han de estar en el rango [0-10]");
                return;
            }
            float promedio = Promedio();
            resultPromedio.Text = promedio.ToString();

            List<float> notas = new List<float> { float.Parse(nota1.Text), float.Parse(nota2.Text), float.Parse(nota3.Text), float.Parse(nota4.Text) };
            float notaBaja = MasBaja(notas);
            resultMasBaja.Text = notaBaja.ToString();

            Condicion(promedio);
        }
        private bool EsNumero(string texto)
        {
            return Regex.IsMatch(texto, @"^[0-9]+(\,[0-9]+)?$");
        }
        private float Promedio()
        {
            float promedio = 0;
            promedio = (float.Parse(nota1.Text) + float.Parse(nota2.Text) + float.Parse(nota3.Text) + float.Parse(nota4.Text)) / 4;
            return promedio = (float)Math.Round(promedio, 2);
        }
        private float MasBaja(List<float> notas)
        {
            float notaBaja = 0;
            foreach (var nota in notas)
            {
                if (notaBaja == 0) notaBaja = nota;

                if (nota < notaBaja) notaBaja = nota;

            }
            return notaBaja;
        }
        private void Condicion(float promedio)
        {
            if (promedio > 0 && promedio <= 4)
            {
                resultCondicion.Text = "Suspendido";
            }
            else if (promedio >= 5 && promedio < 7)
            {
                resultCondicion.Text = "Suficiente";
            }
            else if (promedio >= 7 && promedio < 9)
            {
                resultCondicion.Text = "Notable";
            }
            else if (promedio >= 9 && promedio <= 10)
            {
                resultCondicion.Text = "Excelente";
            }
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            textAlumno.Text = "";
            resultCondicion.Text = "--------";
            resultMasBaja.Text = "00.00";
            resultPromedio.Text = "00.00";
            nota1.Text = "";
            nota2.Text = "";
            nota3.Text = "";
            nota4.Text = "";
        }
    }
}
