using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewStructure.Models;

namespace ViewStructure.ViewComponents
{
    public class WorkChartViewCompenent : ViewComponent
    {
        List<WorkChart> workChart = new List<WorkChart>()
        {

            new WorkChart("Oguzhan",new List<bool>(){true,false,false,true,true}),
            new WorkChart("Alp",new List<bool>(){true,false,true,false,true}),
            new WorkChart("Yavuz",new List<bool>(){false,false,false,true,true}),
            new WorkChart("Ece",new List<bool>(){true,false,false,true,false}),
            new WorkChart("Selin",new List<bool>(){true,true,false,false,true})

        };

        public IViewComponentResult Invoke()
        {
            return View(workChart);

        }
    }
}
