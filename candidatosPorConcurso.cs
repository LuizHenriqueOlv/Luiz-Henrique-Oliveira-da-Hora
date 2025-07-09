namespace Leds
{
    public static class CandidatosPorConcurso
    {
        public static void buscarCandidatos(List<Candidato> candidatos, List<Concurso> concursos)
        {
            Console.WriteLine("Informe o código do concurso:");
            string codigo = Console.ReadLine()?.Trim();

            bool concursoEncontrado = false;
            var candidatosMostrados = new HashSet<string>();

            foreach (var concurso in concursos)
            {
                if (concurso.Codigo == codigo)
                {
                    concursoEncontrado = true;
                    Console.WriteLine($"Concurso encontrado: {concurso.Orgao} - Edital: {concurso.Edital} - Código: {concurso.Codigo}");

                    var vagas = concurso.Vagas.Trim('[', ']').Split(',');

                    foreach (var vaga in vagas)
                    {
                        bool temCandidatoParaVaga = false;
                        string vagaTrim = vaga.Trim();

                        foreach (var candidato in candidatos)
                        {
                            if (candidato.Profissoes.ToLower().Contains(vagaTrim.ToLower()))
                            {
                                if (!candidatosMostrados.Contains(candidato.CPF))
                                {
                                    Console.WriteLine($"Nome: {candidato.Nome}, Data de Nascimento: {candidato.DataNascimento}, CPF: {candidato.CPF}");
                                    candidatosMostrados.Add(candidato.CPF);
                                    temCandidatoParaVaga = true;
                                }
                            }
                        }

                        if (!temCandidatoParaVaga)
                        {
                            Console.WriteLine($"Nenhum candidato encontrado para a vaga: {vagaTrim}");
                        }
                    }
                }
            }

            if (!concursoEncontrado)
            {
                Console.WriteLine("Concurso não encontrado.");
            }
        }
    }
}
