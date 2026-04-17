namespace ClinicadocMais.Models
{
    public class MedicoModel
    {
        public string? nome { get; set; }
        public string? crm { get; set; }

        public string? especialidade { get; set; }

        public string? Telefone { get; set; }  
        public DateOnly? dataNascimento { get; set; }
    }
}
