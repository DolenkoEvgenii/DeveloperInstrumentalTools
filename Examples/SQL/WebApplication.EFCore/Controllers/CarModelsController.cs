using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Database.EFCore.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApplication.EFCore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarModelsController : ControllerBase
    {
        private ILogger<CarModelsController> Logger { get; }
        private ICarModelDataAccess NewsDataAccess { get; }
        private IMapper Mapper { get;  }


        public CarModelsController(ILogger<CarModelsController> logger, ICarModelDataAccess carModelDataAccess, IMapper mapper)
        {
            Logger = logger;
            NewsDataAccess = carModelDataAccess;
            Mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<CarModelDto>> Get(CancellationToken ct = default)
        {
            this.Logger.LogDebug($"{nameof(CarModelsController)}.{nameof(Get)} executed");

            return this.Mapper.Map<IEnumerable<CarModelDto>>(await this.NewsDataAccess.GetAllAsync(ct));
        }
    }
}