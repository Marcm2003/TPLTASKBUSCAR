using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace TPLTASKBUSCAR
{
    class trolo
    {
        public static List<string> buscar(string texto, int tipo)
        {
            var reader = new StreamReader(File.OpenRead(@"data\arxiuUsers.csv"));
            List<string> resultados = new List<string>();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                if (texto.Equals(values[tipo]))
                {
                    resultados.Add(line);
                }
            }

            return resultados;
        }

    }
}
