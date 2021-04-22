using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_App
{
    public class ShiftPerDept
    {
        public ReqFilledDayEmp RequiredEmployees { get; set; } = new ReqFilledDayEmp();
        public ReqFilledDayEmp FilledEmployees { get; set; } = new ReqFilledDayEmp();

        public ShiftPerDept() { }
        public ShiftPerDept(int ReqEmpMonMor,
                            int ReqEmpMonAft,
                            int ReqEmpMonEve,
                            int ReqEmpTueMor,
                            int ReqEmpTueAft,
                            int ReqEmpTueEve,
                            int ReqEmpWedMor,
                            int ReqEmpWedAft,
                            int ReqEmpWedEve,
                            int ReqEmpThuMor,
                            int ReqEmpThuAft,
                            int ReqEmpThuEve,
                            int ReqEmpFriMor,
                            int ReqEmpFriAft,
                            int ReqEmpFriEve,
                            int ReqEmpSatMor,
                            int ReqEmpSatAft,
                            int ReqEmpSatEve,
                            int ReqEmpSunMor,
                            int ReqEmpSunAft,
                            int ReqEmpSunEve)
        {
            RequiredEmployees.Monday.Morning = ReqEmpMonMor;
            RequiredEmployees.Monday.Afternoon = ReqEmpMonAft;
            RequiredEmployees.Monday.Evening = ReqEmpMonEve;

            RequiredEmployees.Tuesday.Morning = ReqEmpTueMor;
            RequiredEmployees.Tuesday.Afternoon = ReqEmpTueAft;
            RequiredEmployees.Tuesday.Evening = ReqEmpTueEve;

            RequiredEmployees.Wednesday.Morning = ReqEmpWedMor;
            RequiredEmployees.Wednesday.Afternoon = ReqEmpWedAft;
            RequiredEmployees.Wednesday.Evening = ReqEmpWedEve;

            RequiredEmployees.Thursday.Morning = ReqEmpThuMor;
            RequiredEmployees.Thursday.Afternoon = ReqEmpThuAft;
            RequiredEmployees.Thursday.Evening = ReqEmpThuEve;

            RequiredEmployees.Friday.Morning = ReqEmpFriMor;
            RequiredEmployees.Friday.Afternoon = ReqEmpFriAft;
            RequiredEmployees.Friday.Evening = ReqEmpFriEve;

            RequiredEmployees.Saturday.Morning = ReqEmpSatMor;
            RequiredEmployees.Saturday.Afternoon = ReqEmpSatAft;
            RequiredEmployees.Saturday.Evening = ReqEmpSatEve;

            RequiredEmployees.Sunday.Morning = ReqEmpSunMor;
            RequiredEmployees.Sunday.Afternoon = ReqEmpSunAft;
            RequiredEmployees.Sunday.Evening = ReqEmpSunEve;

        }
        public void resetFilledDays()
        {

            FilledEmployees.Monday.Morning = 0;
            FilledEmployees.Monday.Afternoon = 0;
            FilledEmployees.Monday.Evening = 0;

            FilledEmployees.Tuesday.Morning = 0;
            FilledEmployees.Tuesday.Afternoon = 0;
            FilledEmployees.Tuesday.Evening = 0;

            FilledEmployees.Wednesday.Morning = 0;
            FilledEmployees.Wednesday.Afternoon = 0;
            FilledEmployees.Wednesday.Evening = 0;

            FilledEmployees.Thursday.Morning = 0;
            FilledEmployees.Thursday.Afternoon = 0;
            FilledEmployees.Thursday.Evening = 0;

            FilledEmployees.Friday.Morning = 0;
            FilledEmployees.Friday.Afternoon = 0;
            FilledEmployees.Friday.Evening = 0;

            FilledEmployees.Saturday.Morning = 0;
            FilledEmployees.Saturday.Afternoon = 0;
            FilledEmployees.Saturday.Evening = 0;

            FilledEmployees.Sunday.Morning = 0;
            FilledEmployees.Sunday.Afternoon = 0;
            FilledEmployees.Sunday.Evening = 0;

        }         

    }
}
