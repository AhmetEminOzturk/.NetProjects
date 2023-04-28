using Api.BusinessLayer.Abstract;
using Api.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace Api.PresentationLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BalanceController : ControllerBase
    {
        private readonly IBalanceService _balanceService;
        private readonly ICustomerService _customerService;

        public BalanceController(IBalanceService balanceService, ICustomerService customerService)
        {
            _balanceService = balanceService;
            _customerService = customerService;
        }
        [HttpGet]
        public IActionResult BalanceList() 
        {
            var values = _balanceService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddBalance(Balance balance)
        {
            _balanceService.TInsert(balance);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteBalance(int id) 
        {
            var values = _balanceService.TGetById(id);
            _balanceService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateBalance(Balance balance) 
        {
            _balanceService.TUpdate(balance);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetBalance(int id)
        {
            var values = _balanceService.TGetById(id);
            return Ok(values);
        }
    }
}
