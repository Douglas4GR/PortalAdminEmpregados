namespace PortalAdminEmpregados.Models.DTO
{
    public class UpdateEmpregadoDto
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public decimal Salario { get; set; }
    }
}
