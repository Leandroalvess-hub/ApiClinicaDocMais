using ClinicadocMais.Models;

namespace ClinicadocMais.Services
{
    public class MedicoService
    {
        public static List<MedicoModel> listaMedicos = new();

        public bool EditarMedico(MedicoModel medicoEditado, string crm)
        {
            MedicoModel? medico = listaMedicos.FirstOrDefault(m => m.crm == crm);

            if (medico == null)
            {
                return false;
            }

            medico.nome = medicoEditado.nome;
            medico.especialidade = medicoEditado.especialidade;
            medico.Telefone = medicoEditado.Telefone;

            return true;
        }
    }
}
