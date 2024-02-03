using BLL.Interfaces;
using BLL.internalinterface;
using DAL.Entites;
using Microsoft.AspNetCore.Mvc;

namespace Task.Controllers
{
    public class OfficeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IOfficeRepository _officeRepository;

        public OfficeController(IOfficeRepository officeRepository , IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            _officeRepository = officeRepository;
        }
        public IActionResult Index()
        {
            var offices = _unitOfWork.OfficeRepository.GetAll();
            return View(offices);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Office office)
        {
            if (ModelState.IsValid)
            {
                _unitOfWork.OfficeRepository.Add(office);
                return RedirectToAction("Index");

            }
            return View(office);
        }
        public IActionResult Details(int? id)
        {
            if (id is null)
                return NotFound();

            var office = _unitOfWork.OfficeRepository.Get(id);

            if (office is null)
                return NotFound();

            return View(office);

        }

        public IActionResult Update(int? id)
        {
            if (id is null)
                return NotFound();
            var office = _unitOfWork.OfficeRepository.Get(id);

            if (office is null)
                return NotFound();

            return View(office);

        }
        [HttpPost]
        public IActionResult Update(int? id, Office office)
        {
            if (id != office.OfficeId)
                return NotFound();
            if (ModelState.IsValid)
            {

                try
                {
                    _unitOfWork.OfficeRepository.Update(office);
                    return RedirectToAction("Index");

                }
                catch (Exception ex)
                {
                    return View(office);

                }
            }
            return View(office);
        }

        public IActionResult Delele(int? id)
        {
            if (id is null)
                return NotFound();

            var office = _unitOfWork.OfficeRepository.Get(id);

            if (office is null)
                return NotFound();

            _unitOfWork.OfficeRepository.Delete(office);
            return RedirectToAction("Index");

            //return View(office);
        }




       

      
    }
}
