﻿using Microsoft.AspNetCore.Mvc;
using MultiShop.Cargo.BusinessLayer.Abstract;
using MultiShop.Cargo.DtoLayer.Dtos.CargoOperationDtos;
using MultiShop.Cargo.EntityLayer.Concrete;

namespace MultiShop.Cargo.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoOperationsController : ControllerBase
    {
        private readonly ICargoOperationService _cargoOperationService;

        public CargoOperationsController(ICargoOperationService cargoOperationService)
        {
            _cargoOperationService = cargoOperationService;
        }

        [HttpGet]
        public IActionResult CargoOperationList()
        {
            var values = _cargoOperationService.TGetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateCargoCompany(CreateCargoOperationDto createCargoOperationDto)
        {
            CargoOperation cargoOperation = new CargoOperation()
            {
                Barcode = createCargoOperationDto.Barcode,
                Description = createCargoOperationDto.Description,
                OperationDate = createCargoOperationDto.OperationDate
            };

            _cargoOperationService.TInsert(cargoOperation);
            return Ok("Kargo operasyonu başarıyla oluşturuldu");
        }

        [HttpDelete]
        public IActionResult RemoveCargoCompany(int id)
        {
            _cargoOperationService.TDelete(id);
            return Ok("Kargo operasyonu başarıyla silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetCargoCompanyById(int id)
        {
            var values = _cargoOperationService.TGetById(id);
            return Ok(values);
        }

        [HttpPut]

        public IActionResult UpdateCargoCompany(UpdateCargoOperationDto updateCargoOperationDto)
        {
            CargoOperation cargoOperation = new CargoOperation()
            {
              Barcode= updateCargoOperationDto.Barcode,
              Description= updateCargoOperationDto.Description,
              CargoOperationId = updateCargoOperationDto.CargoOperationId,
              OperationDate = updateCargoOperationDto.OperationDate
            };
            _cargoOperationService.TUpdate(cargoOperation);
            return Ok("Kargo operasyonu başarıyla güncellendi");
        }
    }
}
