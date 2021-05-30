using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactLib
{
    public class Contact
    {
        private string _firstName;
        private string _lastName;
        private string _mobileNo;
        private string _emailId;


        public Contact(string fname,string lname,string mobileno, string emailid )
        {
            FirstName = fname;
            LastName = lname;
            MobileNo = mobileno;
            EmailId = emailid;

        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }

            set
            {
                _firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }

            set
            {
                _lastName = value;
            }
        }

        public string MobileNo
        {
            get
            {
                return _mobileNo;
            }

            set
            {
                _mobileNo = value;
            }
        }

        public string EmailId
        {
            get
            {
                return _emailId;
            }

            set
            {
                _emailId = value;
            }
        }

    }
}
