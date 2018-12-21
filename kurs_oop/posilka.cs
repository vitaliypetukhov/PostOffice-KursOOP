using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kurs_oop
{
    public class posilka : pochta
    {

        private string _otrpav; //отправитель
        private string _otkuda; // откуда отправлено
        private int _ves; // вес 

        public override string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public override string adress
        {
            get 
            {
                return _adress;
            }
            set
            {
               _adress = value;
            }
        }

        public override string otdelen
        {
            get
            {
                return _otdelen;
            }
            set
            {
                _otdelen = value;
            }
        }

        public override int cost
        {
            get
            {
                return _cost;
            }
            set
            {
                _cost = value;
            }
        }

       /* public override string track
        {
            get
            {
                return _track;
            }
            set
            {
                _track = value;
            }
        }*/

        public string otprav
        {
            get { return _otrpav; }
            set { _otrpav = value; }
        }

        public string otkuda
        {
            get { return _otkuda; }
            set { _otkuda = value; }
        }

        public int ves
        {
            get { return _ves; }
            set { _ves = value; }
        }

        public posilka(string _name, string _adress, string _otdelen, int _cost/*, string _track*/, string _votprav, string _votkuda,int _vves)
            : base(_name, _adress, _otdelen, _cost/*, _track*/)
        {
            otprav = _votprav;
            otkuda = _votkuda;
            ves = _vves;

        }
    }
}
