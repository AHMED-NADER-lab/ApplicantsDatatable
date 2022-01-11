using ApplicantsDatatable.Data.ViewModel;
using ApplicantsDatatable.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApplicantsDatatable.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationController : ControllerBase
    {
        private readonly IApplicationService _IApplicationService;
        public ApplicationController(IApplicationService IApplicationService)
        {
            _IApplicationService = IApplicationService;
        }
        // GET: api/<ApplicationController>
        [HttpGet]
        public IEnumerable<ApplicationVM> Get()
        {
            return _IApplicationService.GetAllApplication();
        }

        // GET api/<ApplicationController>/5
        [HttpGet("{id}")]
        public ApplicationVM Get(int id)
        {
            return _IApplicationService.GetApplication(id);
        }

        // POST api/<ApplicationController>
        [HttpPost]
        public async Task<bool> Post([FromBody] ApplicationVM value)
        {
            if (!ModelState.IsValid)
            {
                return false;
            }
            return await _IApplicationService.CreateApplication(value);
        }

        // PUT api/<ApplicationController>/5
        [HttpPut]
        public async Task<bool> Put([FromBody] ApplicationVM value)
        {
            if (!ModelState.IsValid)
            {
                return false;
            }
            return await _IApplicationService.UpdateApplication(value);
        }

        // DELETE api/<ApplicationController>/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int id)
        {
            return await _IApplicationService.DeleteApplication(id);
        }
    }
}
