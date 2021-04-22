using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_App
{
    public class ReqFilledShiftEmp
    {

        public int Morning { get; set; }
        public int Afternoon { get; set; }
        public int Evening { get; set; }
        private List<int> allShifts;

        public ReqFilledShiftEmp()
        {
        }

        public int GetShift(int x)
        {
            switch (x)
            {
                case 0:
                    return Morning;
                case 1:
                    return Afternoon;
                case 2:
                    return Evening;
                default:
                    return -1;
            }
        }
    }
}
