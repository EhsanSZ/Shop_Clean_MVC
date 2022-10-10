using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Visitors.GetTodayReport;
using Application.Visitors.VisitorOnline;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Admin.EndPoint.Pages.Visitor
{

    public class IndexModel : PageModel
    {
        private readonly IGetTodayReportService _getTodayReportService;
        private readonly IVisitorOnlineService _visitorOnlineService;
        
        public ResultTodayReportDto ResultTodayReport;
        public int OnlineUser;

        public IndexModel(IGetTodayReportService getTodayReportService , IVisitorOnlineService visitorOnlineService)
        {
            _getTodayReportService = getTodayReportService;
            _visitorOnlineService = visitorOnlineService;
        }

        public void OnGet()
        {
            ResultTodayReport= _getTodayReportService.Execute();
            OnlineUser = _visitorOnlineService.GetCount();
        }
    }
}

