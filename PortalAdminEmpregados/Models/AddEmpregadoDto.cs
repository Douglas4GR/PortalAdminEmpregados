namespace PortalAdminEmpregados.Models
{
    public class AddEmpregadoDto
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public decimal Salario { get; set; }
    }
}
