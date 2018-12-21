using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kurs_oop
{
    public abstract class pochta
    {
        protected string _name; // имя получателя
        protected string _adress; // адресс
        protected string _otdelen; // отделение почты
        protected int _cost; // стоимость посылки

        public virtual string name
        {
            get {return _name;}
            set { _name = value; }
        }

        public virtual string adress
        {
            get { return _adress; }
            set { _adress = value; }
        }

        public virtual string otdelen
        {
            get { return _otdelen; }
            set { _otdelen = value; }
        }

        public virtual int cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

      

        public pochta(string _iname, string _iadress, string _iotdelen , int _icost)
        {
            name = _iname;
            adress = _iadress;
            otdelen = _iotdelen;
            cost = _icost;
            
        }

        public pochta() { }
    }
}
