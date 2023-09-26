using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanhSachCuTru_383XVNT
{
    internal class QuanLyDanhSach
    {
        private string _idStatus;
        private string _idCard;
        private string _fullName;
        private string _sex;
        private long _phone;
        private string _address;
        private DateTime _dateofBirth;
        private int _fee; //menhgia
        private int _month; //soluong

        public QuanLyDanhSach(string idStatus, string idCard, string fullName, string sex, long phone, string address, DateTime dateofBirth, int fee, int month)
        {
            _idStatus = idStatus;
            _idCard = idCard;
            _fullName = fullName;
            _sex = sex;
            _phone = phone;
            _address = address;
            _dateofBirth = dateofBirth;
            _fee = fee;
            _month = month;
        }

        public string IdStatus { get => _idStatus; set => _idStatus = value; }
        public string IdCard { get => _idCard; set => _idCard = value; }
        public string FullName { get => _fullName; set => _fullName = value; }
        public string Sex { get => _sex; set => _sex = value; }
        public long Phone { get => _phone; set => _phone = value; }
        public string Address { get => _address; set => _address = value; }
        public DateTime DateofBirth { get => _dateofBirth; set => _dateofBirth = value; }
        public int Fee { get => _fee; set => _fee = value; }
        public int Month { get => _month; set => _month = value; }

        public double Total() =>  (Fee * Month);
    }
}
