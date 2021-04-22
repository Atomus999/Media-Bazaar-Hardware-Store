using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_App
{
    public class DepartmentManager
    {
        private List<Department> departments;

        private static DepartmentManager instance;

        public static DepartmentManager GetInstance()
        {
            if (instance == null)
                instance = new DepartmentManager();
            return instance;
        }

        public DatabaseHelperDepartment dataHelperDepartment { get; set; } = new DatabaseHelperDepartment();
        public List<Department> Departments
        {
            get { return departments; }
            set { this.departments = value; }
        }

        public DepartmentManager()
        {
            departments = new List<Department>();
        }
        public Department GetDepartmentById(int id)
        {
            foreach (Department department in departments)
            {
                if (department.Id == id)
                    return department;
            }
            return null;
        }

        public void LoadDepReqEmp()
        {
            foreach (Department department in departments)
            {
                ShiftPerDept s = dataHelperDepartment.LoadDepartmentReqEmp(department.Id);
                if (s != null)
                    department.ShiftPerDept = s;
            }
        }
        public void AddDepartment(Department department)
        {
            departments.Add(department);
            this.dataHelperDepartment.AddDepartment(department);
            LoadDepartments();
        }

        public void LoadDepartments()
        {
            this.departments = dataHelperDepartment.LoadDepartments();
        }

        public void UpdateDepartment()
        {

        }


        public void resetShiftDays()
        {
            foreach (Department department in Departments)
            {
                department.ShiftPerDept.resetFilledDays();
            }
        }

        public List<DatatableDepartment> GetDepartmentsDatatable()
        {
            List<DatatableDepartment> DepartmentDatatable = new List<DatatableDepartment>();

            foreach (Department department in this.departments)
            {
                DatatableDepartment dep = new DatatableDepartment(department.Id, department.Name, department.FTE);
                DepartmentDatatable.Add(dep);
            }

            return DepartmentDatatable;
        }

        public List<Department> GetAllDepartments()
        {
            return this.departments;
        }
    }
}
