using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SISSchedule_BusinessServices;
using SISSchedule_DTO;
using SISSchedule_Entities;
using SISSchedule_Repository;
using SISSchedule_Utilities;   
using System.Net;
using System.Net.Http;
using Microsoft.Extensions.Logging;

namespace SISSchedule_API.Controllers
{
    /// <summary>
    /// Provider details
    /// </summary>
    [Route("sisschedulereport/v1/[controller]")]
    [ApiController]
    public class ProviderController : BaseController
    {
        private readonly IProviderDataRepository<Providers, ProviderDTO> _dataRepository;
        private ILogger _logger;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="dataRepository"></param>
        /// <param name="logger"></param>
        public ProviderController(IProviderDataRepository<Providers, ProviderDTO> dataRepository, ILogger<ProviderController> logger)
        {
            _logger = logger;
            _dataRepository = dataRepository;
        }

        /// <summary>
        /// Fetch all Providers details 
        /// </summary>
        /// <returns></returns>
        [ProducesResponseType(404)]
        [ProducesResponseType(200, Type = typeof(Providers))]
        [HttpGet]
        [Route("/sisschedulereport/v1/providers")]
        public IActionResult Providers()
        {
            var provider = _dataRepository.GetAll();
            return Ok(provider);
        }

        /// <summary>
        /// Get the Provider details for given provider id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ProducesResponseType(404)]
        [ProducesResponseType(200, Type = typeof(Providers))]
        [HttpGet]
        [Route("/sisschedulereport/v1/provider")]
        public IActionResult Provider(int id)
        {
            var provider = _dataRepository.Get(id);
            if (provider == null)
            {
                return NotFound("Provider not found.");
            }

            return Ok(provider);
        }




        /// <summary>
        /// Create the provider details
        /// </summary>
        /// <param name="projects"></param>
        /// <returns></returns>

        [ProducesResponseType(201)]
        [HttpPost]
        public IActionResult Post([FromBody] Providers provider)
        {
            if (provider is null)
            {
                return BadRequest("provider is null.");
            }
            //else if (provider.RecordID == 0)
            //{
            //    return BadRequest("RecordID is empty.");
            //}
            else if (provider.Provider == string.Empty)
            {
                return BadRequest("Provider name is empty.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            int intProvider = 0;
            var providername = _dataRepository.GetProvider(provider.Provider);
            if (providername is null)
            {

                intProvider = _dataRepository.Add(provider);
            }
            else
            {
                return BadRequest("Provider name already exists.");
            }

            bool bkProvider = false;
            if (intProvider > 0)
            {
                bkProvider = true;
            }
            return Ok(BuildServiceResponse(bkProvider, bkProvider ? SISScheduleMessage.ProviderSuccess: SISScheduleMessage.ProviderFailure, bkProvider ? ServiceCode.Success : ServiceCode.Failure, intProvider));
        }

        /// <summary>
        /// Update the provider given record id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="provider"></param>
        /// <returns></returns>

        [ProducesResponseType(404)]
        [ProducesResponseType(204)]
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] ProviderDTO provider)
        {
            if (provider == null)
            {
                return BadRequest("Provider is null.");
            }
            else if (provider.RecordID == 0)
            {
                return BadRequest("Record ID is empty.");
            }
            else if (provider.Provider == string.Empty)
            {
                return BadRequest("Provider is empty.");
            }
            var providerToUpdate = _dataRepository.Get(id);
            if (providerToUpdate == null)
            {
                return NotFound("The provider record couldn't be found.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            int intProvider = _dataRepository.Update(providerToUpdate, provider);


            bool bkProvider = false;
            if (intProvider > 0)
            {
                bkProvider = true;
            }
            return Ok(BuildServiceResponse(bkProvider, bkProvider ? SISScheduleMessage.ProviderUpdateSuccess : SISScheduleMessage.ProviderUpdateFailure, bkProvider ? ServiceCode.Success : ServiceCode.Failure, intProvider));
        }

        /// <summary>
        /// Delete the Provider given provider id
        /// </summary>
        /// <param name="id"></param>       
        /// <returns></returns>      
       
        [ProducesResponseType(404)]
        [ProducesResponseType(204)]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id <= 0)
            {
                return BadRequest("id value zero.");
            }

            var providerToDelete = _dataRepository.Get(id);
            if (providerToDelete == null)
            {
                return NotFound("The provider record couldn't be found.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            bool bkProvider = _dataRepository.Delete(providerToDelete);
            return Ok(BuildServiceResponse(bkProvider, bkProvider ? SISScheduleMessage.ProviderDeleteSucccess : SISScheduleMessage.ProviderDeleteFaillure, bkProvider ? ServiceCode.Success : ServiceCode.Failure));
        }

    }
}

