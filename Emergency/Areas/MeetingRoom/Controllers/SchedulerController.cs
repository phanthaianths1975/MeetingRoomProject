using Emergency.Areas.MeetingRoom.Models.SampleData;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Emergency.Areas.MeetingRoom.Controllers
{
    [Area("MeetingRoom")]//Declare Area
    public class SchedulerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult MeetingRoom()
        {
            //this.schedulerControl1.Views.DayView.VisibleTime = new DevExpress.XtraScheduler.TimeOfDayInterval(System.TimeSpan.Parse("07:00:00"), System.TimeSpan.Parse("22.00:00:00"));
            return View(SampleData.Appointments);
        }
        public Boolean AllowAdd()
        {
            if (12 > 10)
                return true;
            return false;
        }
    }
}
