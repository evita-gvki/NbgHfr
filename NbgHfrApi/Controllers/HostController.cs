using Microsoft.AspNetCore.Mvc;
using NbgHfrCore.Model;
using Microsoft.Extensions.Logging;
using NbgHfrCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NbgHfrApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HostController : ControllerBase
    {

        private readonly ILogger<HostController> _logger;
        private readonly IHfrService _IHfrService;

        public HostController(ILogger<HostController> logger, IHfrService ihfrServices)
        {
            _logger = logger;
            _IHfrService = ihfrServices;

        }

        [HttpGet]

        // localhost/host/1
        [HttpGet("{HostId}")]
        public async Task<Host> GetProperties(int hostId)
        {
            return await _IHfrService.GetPropertiesByHost(hostId);
         }

    } }
