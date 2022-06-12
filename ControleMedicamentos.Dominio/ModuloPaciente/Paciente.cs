namespace ControleMedicamentos.Dominio.ModuloPaciente
{
    public class Paciente : EntidadeBase
    {
        public Paciente()
        {
        }

        public Paciente(string nome, string cartaoSUS)
        {
            Nome = nome;
            CartaoSUS = cartaoSUS;
        }

        public string Nome { get; set; }
        public string CartaoSUS { get; set; }

        public override string ToString()
        {
            return $"{id}{" - "}{Nome}{" - "}{CartaoSUS}";
        }
    }
}
