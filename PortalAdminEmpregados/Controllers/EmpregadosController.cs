using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PortalAdminEmpregados.Data;

namespace PortalAdminEmpregados.Controllers
{
    [Route("api/[controller]")] // localhost:5001/api/empregados
    [ApiController]
    public class EmpregadosController : ControllerBase
    {
        private readonly AppDbContext dbContext;

        public EmpregadosController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult GetTodosEmpregados()
        {
            // vai retornar o tipo IActionResult, que é um tipo genérico que pode retornar qualquer tipo de resposta HTTP
            var todosEmpregados = dbContext.Empregados.ToList();
            return Ok(todosEmpregados);
            // aqui estamos retornando um status 200 (OK) e a lista de todos os empregados
        }
    }
}
