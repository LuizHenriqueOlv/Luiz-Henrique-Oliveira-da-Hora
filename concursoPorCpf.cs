namespace Leds
{
    public static class ConcursoPorCpf
    {
        public static void buscaPorCpf(List<Candidato> candidatos, List<Concurso> concursos)
        {
            Console.WriteLine("Informe o CPF do candidato:");
            string cpfCandidato = Console.ReadLine();

            cpfCandidato = cpfCandidato.Replace(".", "").Replace("-", "").Trim();

            if (cpfCandidato.Length < 11)
            {
                Console.WriteLine("CPF inválido! Deve conter 11 dígitos.");
                return;
            }

            bool encontrado = false;
            var concursosMostrados = new HashSet<string>();

            foreach (var candidato in candidatos)
            {
                if (candidato.CPF == cpfCandidato)
                {
                    Console.WriteLine("Candidato encontrado:");
                    encontrado = true;
                    Console.WriteLine(candidato.Nome);
                    foreach (var concurso in concursos)
                    {
                        var vagas = concurso.Vagas.Trim('[', ']').Split(',');

                        foreach (var vaga in vagas)
                        {
                            if (candidato.Profissoes.ToLower().Contains(vaga.Trim().ToLower()))
                            {
                               if (!concursosMostrados.Contains(concurso.Codigo))
                                {
                                    Console.WriteLine($"Concurso: {concurso.Orgao}, Edital: {concurso.Edital}, Código: {concurso.Codigo}");
                                    concursosMostrados.Add(concurso.Codigo);
                                }
                                break;
                            }
                        }
                    }

                }

            }

            if (!encontrado)
            {
                Console.WriteLine("Candidato não presente no banco de dados.");
            }            
        }
    }
} 