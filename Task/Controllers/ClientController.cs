using BLL.Interfaces;
using BLL.internalinterface;
using DAL.Entites;
using Microsoft.AspNetCore.Mvc;
using Task.Entites;
using Task.Interfaces;

namespace Task.Controllers
{
    public class ClientController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IClientRepository _clientRepository;
        private readonly IOfficeRepository _officeRepository;

        public ClientController(IClientRepository clientRepository, IOfficeRepository officeRepository, IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _clientRepository = clientRepository;
            _officeRepository = officeRepository;
        }
        public IActionResult Index()
        {
            var clients = _unitOfWork.ClientRepository.GetALL();
            return View(clients);
        }
        [HttpGet]
        public IActionResult Create()
        {
            var offices = _unitOfWork.OfficeRepository.GetAll();
            return View();
        }
        [HttpPost]
        public IActionResult Create(Client client)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.ClientRepository.Add(client);
                return RedirectToAction("Index");

            }
            return View(client);
        }
        public IActionResult Details(int? id)
        {
            if (id is null)
                return NotFound();

            var client = _unitOfWork.ClientRepository.Get(id);

            if (client is null)
                return NotFound();

            return View(client);

        }

        public IActionResult Update(int? id)
        {
            if (id is null)
                return NotFound();
            var client = _unitOfWork.ClientRepository.Get(id);

            if (client is null)
                return NotFound();

            return View(client);

        }
        [HttpPost]
        public IActionResult Update(int? id, Client client)
        {
            if (id != client.ClientId)
                return NotFound();
            if (ModelState.IsValid)
            {

                try
                {
                    _unitOfWork.ClientRepository.Update(client);
                    return RedirectToAction("Index");

                }
                catch (Exception ex)
                {
                    return View(client);

                }
            }
            return View(client);
        }

        public IActionResult Delele(int? id)
        {
            if (id is null)
                return NotFound();

            var client = _unitOfWork.ClientRepository.Get(id);

            if (client is null)
                return NotFound();

            _unitOfWork.ClientRepository.Delete(client);
            return RedirectToAction("Index");

            //return View(office);
        }
    }
}
