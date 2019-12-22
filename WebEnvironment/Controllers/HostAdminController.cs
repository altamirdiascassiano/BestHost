using BestHost.BusinessRules;
using BestHost.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using WebEnvironment.Helper;

namespace WebEnvironment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HostAdminController : Controller
    {
        [HttpGet]
        public ActionResult<string> Get([FromServices] HostAdminBR hostAdminBR)
        {
            try
            {
                return hostAdminBR.GetAllHostAdmin();
            }
            catch (Exception ex)
            {
                LogEmailHelper.LogMail(ex);
                LogFileSystemHelper.LogFile("Não foi possível realizar a buscar dos dados!", ex);
                return BadRequest();
            }
        }

        [HttpPut]
        public ActionResult Put([FromServices] HostAdminBR hostAdminBR, [FromBody] HostAdmin hostAdmin)
        {
            try
            {
                hostAdminBR.Add(hostAdmin);
            }
            catch (Exception ex)
            {
                LogEmailHelper.LogMail(ex);
                LogFileSystemHelper.LogFile("Não foi possível realizar a inserção dos dados!", ex);
                return BadRequest();
            }
            return Ok();
        }

        [HttpDelete]
        public ActionResult Delete([FromServices] HostAdminBR hostAdminBR, [FromBody] HostAdmin hostAdmin)
        {
            try
            {
                hostAdminBR.Delete(hostAdmin);
                return Ok();
            }
            catch (Exception ex)
            {
                LogEmailHelper.LogMail(ex);
                LogFileSystemHelper.LogFile(string.Concat("Não foi possível realizar a deleção do HostAdmin", " - ", hostAdmin.Name, "!"), ex);
                return BadRequest();
            }
        }


        [HttpPost]
        public ActionResult Post([FromServices] HostAdminBR hostAdminBR, [FromBody] HostAdmin hostAdmin)
        {
            try
            {
                hostAdminBR.Update(hostAdmin);
                return Ok();
            }
            catch (Exception ex)
            {
                LogEmailHelper.LogMail(ex);
                LogFileSystemHelper.LogFile(string.Concat("Não foi possível realizar a atualização do HostAdmin", " - ", hostAdmin.Name, "!"), ex);
                return BadRequest();
            }
        }

    }
}