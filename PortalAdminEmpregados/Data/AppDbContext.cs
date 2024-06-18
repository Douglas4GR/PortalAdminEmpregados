using Microsoft.EntityFrameworkCore;
using PortalAdminEmpregados.Models.Entidades;

namespace PortalAdminEmpregados.Data
{
    public class AppDbContext : DbContext // herdar de DbContext para usar o EntityFramework
    {
        // escrever ctor cria o construtor
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        /*
          O AppDbContext é uma classe que herda de DbContext, que é uma classe do EntityFramework.
        */

        // escrever prop cria a propriedade
        public DbSet<Empregado> Empregados { get; set; }
        /*
          DbSet é uma coleção de objetos que representam uma tabela no banco de dados.
          Aqui, estamos dizendo que a tabela Empregados no banco de dados é representada pela coleção Empregados.
        */
    }
}
