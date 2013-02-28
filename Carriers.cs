using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project2
{
    class Carrier
    {
        private string carrierFirstName;
        private string carrierLastName;
        private string carrierAddress;
        private string carrierPhoneNumber;

        public Carrier()
        {
            carrierFirstName = " ";
            carrierLastName = " ";
            carrierAddress = " ";
            carrierPhoneNumber = " ";
        }

        public string CarrierFirstName
        {
            get
            {
                return carrierFirstName;
            }

            set
            {
                carrierFirstName = value;
            }
        }

        public string CarrierLastName
        {
            get
            {
                return carrierLastName;
            }
            set
            {
                carrierLastName = value;
            }
        }

        public string CarrierAddress
        {
            get
            {
                return carrierAddress;
            }
            set
            {
                carrierAddress = value;
            }
        }

        public string CarrierPhoneNumber
        {
            get
            {
                return carrierPhoneNumber;
            }
            set
            {
                carrierPhoneNumber = value;
            }
        }


    }
}
