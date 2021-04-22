using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_App
{ 
   public class ReqFilledDayEmp
    {
        public ReqFilledShiftEmp Monday { get; set; } = new ReqFilledShiftEmp();
        public ReqFilledShiftEmp Tuesday { get; set; } = new ReqFilledShiftEmp();
        public ReqFilledShiftEmp Wednesday { get; set; } = new ReqFilledShiftEmp();
        public ReqFilledShiftEmp Thursday { get; set; } = new ReqFilledShiftEmp();
        public ReqFilledShiftEmp Friday { get; set; } = new ReqFilledShiftEmp();
        public ReqFilledShiftEmp Saturday { get; set; } = new ReqFilledShiftEmp();
        public ReqFilledShiftEmp Sunday { get; set; } = new ReqFilledShiftEmp();

        private List<ReqFilledShiftEmp> allDays = new List<ReqFilledShiftEmp>();

        public List<ReqFilledShiftEmp> AllDays { get { return allDays; } }
        public ReqFilledDayEmp()
        {
            allDays.Add(Monday);
            allDays.Add(Tuesday);
            allDays.Add(Wednesday);
            allDays.Add(Thursday);
            allDays.Add(Friday);
            allDays.Add(Saturday);
            allDays.Add(Sunday);            
        }
        
    }
}
