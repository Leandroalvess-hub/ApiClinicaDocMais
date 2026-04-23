using System.ComponentModel.DataAnnotations;

namespace ClinicadocMais.Models
{
    public class PacienteModel
    {
        [Key] public string? cpf { get; set; }
        public string? nome { get; set; }
        public string? dataNascimento { get; set; }
        public string? telefone { get; set; }
        public string? email { get; set; }

        public PacienteModel (string? cpf, string? nome, string? dataNascimento, string v)
        {
            this.cpf = cpf;
            this.nome = nome;
            this.dataNascimento = dataNascimento;
          
        }
    }
}
