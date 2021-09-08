using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_I03
{
    public partial class ContadorForm : Form
    {
        public ContadorForm()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            string[] palabras = rtxtForm.Text.Split(' ', (char) StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> diccPalabras = CuentaPalabras(palabras);
            List<KeyValuePair<string, int>> cuentaPalabrasList = diccPalabras.ToList();
            cuentaPalabrasList.Sort(CompararCantidadRepeticiones);
            MostrarPalabras(cuentaPalabrasList);
        }

        private Dictionary<string, int> CuentaPalabras(string[] palabras)
        {
            Dictionary<string, int> diccPalabras = new Dictionary<string, int>();
            foreach (string palabra in palabras)
            {
                if (diccPalabras.ContainsKey(palabra))
                {
                    diccPalabras[palabra]++;
                }
                else
                {
                    diccPalabras.Add(palabra, 1);
                }
            }
            return diccPalabras;
        }

        private int CompararCantidadRepeticiones(KeyValuePair<string, int> palabraUno, 
            KeyValuePair<string, int> palabraDos)
        {
            return palabraDos.Value - palabraUno.Value;
        }

        private void MostrarPalabras(List<KeyValuePair<string, int>> palabras)
        {
            if (palabras.Count == 0)
            {
                MessageBox.Show("No se ingresaron palabras");
            } else
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < 4 && i < palabras.Count; i++)
                {
                    sb.AppendLine($"Palabra: {palabras[i].Key} - Valor: {palabras[i].Value}");
                }
                MessageBox.Show(sb.ToString());
            }
        }
    }
}
