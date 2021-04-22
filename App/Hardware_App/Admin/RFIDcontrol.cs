using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_App
{
    public class RFIDcontrol
    {
        private bool isAssigned;
        private string serialNumber;

        public bool IsAssigned
        {
            get { return this.isAssigned; }
            set { this.isAssigned = value; }
        }
        public string SerialNumber
        {
            get { return this.serialNumber; }
            set { this.serialNumber = value; }
        }

        public RFIDcontrol(string serial, bool isAssigned)
        {
            this.serialNumber = serial;
            this.isAssigned = isAssigned;
        }

        public override string ToString()
        {
            return this.serialNumber;
        }
    }
}
