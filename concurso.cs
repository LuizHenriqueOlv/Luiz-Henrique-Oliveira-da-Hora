namespace Leds
{
    public class Concurso
    {
        public string Orgao { get; set; }

        public string Edital { get; set; }

        public string Codigo { get; set; }

        public string Vagas { get; set; }

        public override string ToString()
        {
            return $"Orgão: {Orgao}, Edital: {Edital}, Código: {Codigo}, Lista de Vagas: {Vagas}";
        }
    }
}