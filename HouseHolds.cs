using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project2
{
    class HouseHold
    {
        private string firstName;
        private string lastName;
        private string address;
        private string phoneNumber;
        private string typeofPaper;
        private int amountPaid = 0;
        private int billAmount;
        private int amountRemain = 0;

        public HouseHold()
        {
            firstName = " ";
            lastName = " ";
            address = " ";
            phoneNumber = " ";
            typeofPaper = " ";
        }

        public int BillAmount
        {
            get
            {
                return billAmount;
            }
            set
            {
                billAmount = value;
            }
        }

        public int AmountRemain
        {
            get
            {
                return amountPaid;
            }
            set
            {
                amountRemain = value;
            }
        }


        public int AmountPaid
        {
            get
            {
                return amountPaid;
            }
            set
            {
                amountPaid = value;
            }
        }

        public string FirstName
        {

            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

         public string LastName
        {

            get
            {
                return lastName;
            }

            set
            {
                lastName = value; 
            }
        }

         public string Address
         {

             get
             {
                 return address;
             }

             set
             {
                 address = value;
             }
         }

         public string PhoneNumber
         {

             get
             {
                 return phoneNumber;
             }

             set
             {
                 phoneNumber = value;
             }
         }

         public string PaperType
         {

             get
             {
                 return typeofPaper;
             }

             set
             {
                 typeofPaper = value;
             }
         }


    }
}
