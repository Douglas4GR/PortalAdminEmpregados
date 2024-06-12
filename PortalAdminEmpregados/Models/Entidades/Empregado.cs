namespace PortalAdminEmpregados.Models.Entidades
{
    public class Empregado
    {
        public Guid Id { get; set; }
        public required string Nome { get; set; }
        public required string Email { get; set; }
        public string? Telefone { get; set; }
        public required string CPF { get; set; }
        public decimal Salario { get; set; }
    }
}
  