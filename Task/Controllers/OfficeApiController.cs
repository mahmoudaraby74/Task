using BLL.Interfaces;
using BLL.internalinterface;
using DAL.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Task.Controllers
{

    public class OfficeApiController : ControllerBase
    {
        private readonly IOfficeRepository _officeRepository;
        private readonly IUnitOfWork _unitOfWork;

        public OfficeApiController(IOfficeRepository officeRepository, IUnitOfWork unitOfWork)
        {
            _officeRepository = officeRepository;
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public ActionResult GetOfficeById(int id)
        {
            var office = _unitOfWork.OfficeRepository.Get(id);
            return Ok(office);

        }
        [HttpPost]
        public ActionResult UpdateOffice(Office office)
        {
            var offices = _unitOfWork.OfficeRepository.Update(office);
            return Ok(offices);
        }
        [HttpDelete]
        public ActionResult DeleteOffice(int id ,Office office)
        {
            _unitOfWork.OfficeRepository.Delete(office);
            return NoContent();
        }



    }
}
