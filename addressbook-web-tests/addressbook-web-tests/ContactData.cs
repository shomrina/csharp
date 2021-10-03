using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public class ContactData
    {
        private string firstName;
        private string lastName;
        public string MiddleName { get; set; } = "";
        public string NickName { get; set; } = "";
        public string PhotoPath { get; set; } = ""; //?
        public string Title { get; set; } = "";
        public string Company { get; set; } = "";
        public string Address { get; set; } = "";

        //telephone
        public string PhoneHome { get; set; } = "";
        public string PhoneMobile { get; set; } = "";
        public string PhoneWork { get; set; } = "";
        public string PhoneFax { get; set; } = "";

        public string Email { get; set; } = "";
        public string Email2 { get; set; } = "";
        public string Email3 { get; set; } = "";
        public string Homepage { get; set; } = "";
        //birthday
        public string Bday { get; set; } = "";
        public string Bmonth { get; set; } = "-";
        public string Byear { get; set; } = "";
        //anniversary
        public string Aday { get; set; } = "";
        public string Amonth { get; set; } = "-";
        public string Ayear { get; set; } = "";
        public string GroupName { get; set; } = "[none]";
        //Secondary
        public string Address2 { get; set; } = "";
        public string Home { get; set; }  = "";
        public string Notes { get; set; } = "";

        public ContactData(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        //автопроперти
     //   public string Test { get; set; } = "";

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


    }
}
