using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tut7.Models;
using tut7.Services;

namespace tut7.Controllers
{
    [ApiController]
    [Route("api/enrollments")]
    public class EnrollmentsController : ControllerBase
    {
        private IStudentServiceDb _service;

        public EnrollmentsController(IStudentServiceDb service)
        {
            _service = service;
        }

        [HttpPost("/promotions")]
        [Authorize(Roles = "employee")]
        public IActionResult Promotion(Promotion promotion)

        {
            return _service.Promote(promotion);

        }

        [HttpPost]
        [Authorize(Roles = "employee")]
        public IActionResult Enrollment(Enrollment enrollment)

        {
            return _service.Enrollment(enrollment);

        }
    }
}
