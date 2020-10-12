using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplication.Core.Entities;
using Aplication.Core.Services.Abstraction;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Server.Dtos;
using Server.Exeptions;

namespace Server.Controllers
{
    [Route("api/PhoneNumbersBase")]
    [ApiController]
    public class PhonebaseController : ControllerBase
    {
        private readonly IRepository<PhoneNumber> _repository;
        private readonly IPhoneBaseService _service;
        private readonly IMapper _mapper;

        public PhonebaseController(IRepository<PhoneNumber> repository,
            IPhoneBaseService service, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
            _service = service;
        }

        [HttpPost("Post PhoneNumbers")]
        public async Task<ActionResult> AddNumbers(IEnumerable<PhonenumbersWrite> userPhoneNumbers)
        {

            try
            {


              var mappedphonenumbers =  userPhoneNumbers.Select(p=>_mapper.Map<PhoneNumber>(p));


               await _repository.AddManyEntityAsync(mappedphonenumbers);
            }
            catch (Exception ex)
            {

                throw ex;
            }


            return Ok();

        }

        [HttpGet("Get Owner")]
        public async Task<ActionResult> AddNumbers(string userPhoneNumber)
        {
            if (userPhoneNumber == null)
                throw new ArgumentException();

            try
            {
             var phoneownernames =  await _service.GetPhoneNumberOwnerNames(userPhoneNumber);

            if (phoneownernames == null)
                throw new PhoneNumberNotFoundException();

            return Ok(phoneownernames);
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}
