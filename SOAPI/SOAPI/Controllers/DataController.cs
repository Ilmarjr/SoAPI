using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SOAPI.Models;

namespace SOAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        SQLServerDAO sqlServerObj;

        [HttpGet]

        public List<Guest> GetGuests()
        {
            sqlServerObj = new SQLServerDAO();
            return sqlServerObj.getGuests();
        }

        [HttpGet("1")]
        public Guest Get(string cpf)
        {
            sqlServerObj = new SQLServerDAO();
            return sqlServerObj.getGuest(cpf);
        }

        [HttpPost]
        public string PostGuest(Guest guest)
        {
            sqlServerObj = new SQLServerDAO();
            return sqlServerObj.inserir(guest);
        }

        [HttpPut]
        public string Put(Guest guest )
        {
            sqlServerObj = new SQLServerDAO();
            return sqlServerObj.updateGuest(guest);
        }

        [HttpDelete]
        public string Delete(string cpf)
        {

            sqlServerObj = new SQLServerDAO();
            sqlServerObj.Delete(cpf);
            return "Registro Removido com sucesso";
        }
    }
}
