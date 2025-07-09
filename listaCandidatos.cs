using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Leds
{
    public static class ListaCandidatos
    {
        public static List<Candidato> listaDeCandidatos(string arquivo)
        {
            // Lê o arquivo candidatos.txt e cria uma lista de Candidato
            string[] candidatosLines = File.ReadAllLines(arquivo);

            List<Candidato> candidatos = new List<Candidato>();

            foreach (string linha in candidatosLines)
            {
                // Regex para dividir a linha em partes, considerando que os campos podem conter vírgulas
                var partes = Regex.Matches(linha, "(?<=^|,)(\"[^\"]*\"|[^,]*)");

                string nome = partes[0].Value;
                string dataNascimento = partes[1].Value;
                string cpf = partes[2].Value;
                string profissoes = partes[3].Value.Trim('\"');

                Candidato candidato = new Candidato
                {
                    Nome = nome,
                    DataNascimento = dataNascimento,
                    CPF = cpf.Replace(".", "").Replace("-", ""),
                    Profissoes = profissoes
                };
                candidatos.Add(candidato);
            }

            return candidatos;
        }
    }
}
