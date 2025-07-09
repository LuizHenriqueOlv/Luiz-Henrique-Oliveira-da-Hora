using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Leds
{
    public static class ListaConcurso
    {
        public static List<Concurso> listaDeConcursos(string arquivo)
        {
            // Lê o arquivo concursos.txt e cria uma lista de Concurso
            string[] concursosLines = File.ReadAllLines(arquivo);

            List<Concurso> concursos = new List<Concurso>();

            foreach (string linha in concursosLines)
            {
                // Regex para dividir a linha em partes, considerando que os campos podem conter vírgulas
                var partes = Regex.Matches(linha, "(?<=^|,)(\"[^\"]*\"|[^,]*)");

                string orgao = partes[0].Value;
                string edital = partes[1].Value;
                string codigo = partes[2].Value;
                string vagas = partes[3].Value.Trim('\"');

                Concurso concurso = new Concurso
                {
                    Orgao = orgao,
                    Edital = edital,
                    Codigo = codigo,
                    Vagas = vagas
                };
                concursos.Add(concurso);
            }

            return concursos;
        }
    }
}