using BLL.Interfaces;
using BLL.internalinterface;
using DAL.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task.Entites;
using Task.Interfaces;

namespace Task.Controllers
{
  
    public class ClientApiController : ControllerBase
    {
        private readonly IClientRepository _clientRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ClientApiController(IClientRepository clientRepository, IUnitOfWork unitOfWork)
        {
            _clientRepository = clientRepository;
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public ActionResult GetClientById(int id)
        {
            var client = _unitOfWork.ClientRepository.Get(id);
            return Ok(client);

        }
        [HttpPost]
        public ActionResult UpdateClient(int id,Client client)
        {
            var clients = _unitOfWork.OfficeRepository.Update(client);
            return Ok(clients);
        }
        [HttpDelete]
        public ActionResult DeleteOffice(int id, Client client)
        {
            var Clients = _unitOfWork.OfficeRepository.Delete(client);
            return NoContent();
        }
    }
}
