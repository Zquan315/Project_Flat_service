using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flat_Services_Application.connectDB
{
    internal class roomate
    {
        private string _id;
        private string _name;
        private string _sex;
        private DateTime _dateOfBirth;
        private string _idVehical;
        private string _phoneNumber;
        private string _address;
        private string _idTenant;


        public roomate()
        {

        }

        public roomate(string id, string name, string sex, DateTime dateOfBirth, string idVehical, string phoneNumber, string address, string idTenant)
        {
            _id = id;
            _name = name;
            _sex = sex;
            _dateOfBirth = dateOfBirth;
            _idVehical = idVehical;
            _phoneNumber = phoneNumber;
            _address = address;
            _idTenant = idTenant;
        }

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Sex { get => _sex; set => _sex = value; }
        public DateTime DateOfBirth { get => _dateOfBirth; set => _dateOfBirth = value; }
        public string IdVehical { get => _idVehical; set => _idVehical = value; }
        public string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }
        public string Address { get => _address; set => _address = value; }
        public string IdTenant { get => _idTenant; set => _idTenant = value; }
    }
}
