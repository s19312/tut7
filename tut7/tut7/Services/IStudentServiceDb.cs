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
        bool validation(string login, string password);
        void assignRefreshToken(string login, Guid rtoken);
        bool checkrefreshToken(string token);
        void updateRefreshToken(string oldToken, Guid newToken);
        IActionResult Enrollment(Enrollment enrollment);
        IActionResult Promote(Promotion promotion);
    }
}
