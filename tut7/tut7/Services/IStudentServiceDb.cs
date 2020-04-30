using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tut7.Models;

namespace tut7.Services
{
    public interface IStudentServiceDb
    {
        IActionResult Enrollment(Enrollment enrollment);

        IActionResult Promote(Promotion promotion);
    }
}
