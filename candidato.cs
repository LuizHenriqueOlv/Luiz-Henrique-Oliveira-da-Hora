namespace Leds
{
    public class Candidato
    {
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public string CPF { get; set; }
        public string Profissoes { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome}, Nascimento: {DataNascimento}, CPF: {CPF}, Profissões: {Profissoes}";
        }
    }
}
