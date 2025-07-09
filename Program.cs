using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Leds
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Candidato> candidatos = ListaCandidatos.listaDeCandidatos("candidatos.txt");
            List<Concurso> concursos = ListaConcurso.listaDeConcursos("concursos.txt");
            ConcursoPorCpf.buscaPorCpf(candidatos, concursos);
            CandidatosPorConcurso.buscarCandidatos(candidatos, concursos);
            
        }
    }
}