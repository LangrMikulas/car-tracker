using AspNetCoreGeneratedDocument;
using CarTracker.WebMvcApp.Contexts;
using CarTracker.WebMvcApp.Entities;
using CarTracker.WebMvcApp.Entities.Logs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CarTracker.WebMvcApp.Controllers
{
    public class RepairLogsController : Controller
    {
        public AppDbContext AppDbContext { get; set; }
        public List<RepairLog> RepairLogs { get; set; }

        public RepairLogsController()
        {
            AppDbContext = new AppDbContext();
            RepairLogs = AppDbContext.RepairLog.ToList();
        }

        public IActionResult ShowRepairLog(int? carId)
        {
            var logsQuery = AppDbContext.RepairLogs.Include(r => r.Car).AsQueryable();
            if (carId.HasValue)
            {
                logsQuery = logsQuery.Where(r => r.CarId == carId);
            }

            var repairLogs = AppDbContext.RepairLog
                .Include(r => r.Car)
                .Include(r => r.User)
                .ToList();
            return View(RepairLogs);
        }


    }
}
