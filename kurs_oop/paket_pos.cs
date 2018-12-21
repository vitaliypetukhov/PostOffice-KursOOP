using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace kurs_oop
{
    class paket_pos : posilka
    {
        private string _track;

        public string track
        {
            get { return _track; }
            set { _track = value; }
        }

        public paket_pos(string _name, string _adress, string _otdelen, int _cost/*, string _track*/, string _otprav, string _otkuda, int _ves, string _dtrack)
            : base(_name, _adress, _otdelen, _cost/*, _track*/, _otprav, _otkuda, _ves)
        {
            track = _dtrack;
        }
    }
}
