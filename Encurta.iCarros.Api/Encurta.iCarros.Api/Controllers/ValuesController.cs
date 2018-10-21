using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Dapper;
using Encurta.iCarros.Domain.Entities;
using Encurta.iCarros.Domain.Intefaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Encurta.iCarros.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ValuesController : Controller
    {
        private IConfiguration config;

        public ValuesController(IConfiguration configuration)
        {
            config = configuration;
        }
            
        //// Get api/values
        [HttpGet("{Command}")]        
        public List<Usuario> Get(string usuario, string senha)
        {
            using (SqlConnection conexao = new SqlConnection(
                config.GetConnectionString("DefaultConnection")))
            {
                List<Usuario> usuarios = conexao.Query<Usuario>(string.Format("SELECT * FROM TB_USUARIO WHERE DS_ALIAS = '{0}' AND DS_SENHA = '{1}'", usuario, senha)).AsList();
                                 
                return usuarios;
            }
         
        }
             
    }
}
