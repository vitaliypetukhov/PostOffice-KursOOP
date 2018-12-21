using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kurs_oop
{
    class zak_pismo : pismo
    {
        private int _index;

        public int index
        {
            get { return _index; }
            set { _index = value; }
        }

        public zak_pismo(string _name, string _adress, string _otdelen, int _cost/*, string _track*/, string _otprav, string _otkuda, int _dindex)
            : base(_name, _adress, _otdelen, _cost/*, _track*/, _otprav, _otkuda)
        {
            index = _dindex;
        }
    }
}
