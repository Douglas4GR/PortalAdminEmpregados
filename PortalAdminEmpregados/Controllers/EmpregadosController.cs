using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PortalAdminEmpregados.Data;
using PortalAdminEmpregados.Models;
using PortalAdminEmpregados.Models.Entidades;

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

        // aqui é necessário a criação de um objeto, que será quem vai receber os dados do empregado, 
        // para isso usamos DTOs (Data Transfer Object), qu transferem de uma camada para outra
        [HttpPost]
        public IActionResult AdicionarEmpregado(AddEmpregadoDto addEmpregadoDto)
        {
            // primeiramente devemos mapear o DTO para a entidade (converter o DTO para a entidade)
            // porque o dbContext que iremos usar apenas aceita entidades
            var empregadoEntidade = new Empregado()
            {
                Nome = addEmpregadoDto.Nome,
                Email = addEmpregadoDto.Email,
                Telefone = addEmpregadoDto.Telefone,
                CPF = addEmpregadoDto.CPF,
                Salario = addEmpregadoDto.Salario
            };

            dbContext.Empregados.Add(empregadoEntidade);
            dbContext.SaveChanges();

            return Ok(empregadoEntidade);
            // aqui estamos retornando um status 200 (OK) e o empregado que acabamos de adicionar
        }
    }
}
