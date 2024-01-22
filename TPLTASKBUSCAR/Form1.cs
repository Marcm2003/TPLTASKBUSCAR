using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPLTASKBUSCAR
{
    public partial class Form1 : Form
    {
        List<string> resultados = new List<string>();
        List<string> resultadosEdu = new List<string>();
        List<string> resultadosInfo = new List<string>();
        string hola = "";

        public Form1()
        {
            InitializeComponent();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!chkCountry.Checked && !chkEmail.Checked && !chkFirst.Checked && !chkid.Checked && !chkIP.Checked && !chkLast.Checked)
            {
                txtResult.Text = "ERROR: Select at least one option";
                return;
            }

            resultados.Clear();
            resultadosEdu.Clear();
            resultadosInfo.Clear();
            hola = "";

            List<Task<List<string>>> tasks = new List<Task<List<string>>>();

            if (chkCountry.Checked)
                tasks.Add(Task.Run(() => trolo.buscar(txtbuscar.Text, 4)));
            if (chkEmail.Checked)
                tasks.Add(Task.Run(() => trolo.buscar(txtbuscar.Text, 3)));
            if (chkFirst.Checked)
                tasks.Add(Task.Run(() => trolo.buscar(txtbuscar.Text, 1)));
            if (chkid.Checked)
                tasks.Add(Task.Run(() => trolo.buscar(txtbuscar.Text, 0)));
            if (chkIP.Checked)
                tasks.Add(Task.Run(() => trolo.buscar(txtbuscar.Text, 5)));
            if (chkLast.Checked)
                tasks.Add(Task.Run(() => trolo.buscar(txtbuscar.Text, 2)));

            await Task.WhenAll(tasks);

            foreach (var result in tasks.SelectMany(t => t.Result).Where(r => !string.IsNullOrEmpty(r)))
            {
                resultados.Add(result);

                if (result.Contains(".edu"))
                {
                    resultadosEdu.Add(result);
                }
                else if (result.Contains(".info"))
                {
                    resultadosInfo.Add(result);
                }
            }

            if (resultados.Count > 0)
            {
                hola = string.Join(Environment.NewLine, resultados);
                txtResult.Text = hola;
            }
            else
            {
                txtResult.Text = "Nothing found";
            }

            textBox1.Text = $"({resultadosEdu.Count}.edu fount):{Environment.NewLine}" +
                            string.Join(Environment.NewLine, resultadosEdu);

            textBox2.Text = $"({resultadosInfo.Count}.info  fount):{Environment.NewLine}" +
                            string.Join(Environment.NewLine, resultadosInfo);
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}