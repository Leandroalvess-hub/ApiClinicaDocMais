using ClinicadocMais.Models;
using Microsoft.EntityFrameworkCore;

namespace ClinicadocMais.Data
{
    public class ClinicaContext : DbContext
    { 
        public ClinicaContext(DbContextOptions<ClinicaContext> options) : base(options)
        {

        }

        public DbSet<PacienteModel> Paciente { get; set; }
        public DbSet<MedicoModel> Medicos { get; set; }
        public DbSet<AgendamentoModel> agendamento {  get; set; }
        public DbSet <ChamadaModel> Chamadas { get; set; }
    }
}
