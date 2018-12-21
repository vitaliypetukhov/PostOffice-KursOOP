using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace kurs_oop
{
    class order
    {
        // создаем обьекты класса письмо
        public List<zak_pismo> _zak_pismo = new List<zak_pismo>();
        public int _Zpcount = 0;

        public List<ob_pismo> _ob_pismo = new List<ob_pismo>();
        public int _Opcount = 0;

        // создаем обьекты класса посылка
        public List<ems_pos> _ems_pos = new List<ems_pos>();
        public int _Ecount = 0;

        public List<paket_pos> _p_pos = new List<paket_pos>();
        public int _Pcount = 0;

        public List<bander_pos> _ban_pos = new List<bander_pos>();
        public int _Bcount = 0;

        // посылка бандероль

        public void dobBan(string _name, string _adress, string _otdelen, int _cost, string _otprav, string _otkuda, int _ves, string _track)
        {
            bander_pos _bpos = new bander_pos(_name, _adress, _otdelen, _cost, _otprav, _otkuda, _ves, _track);
            _ban_pos.Add(_bpos);
            _Bcount++;
        }

        public void ReadBan()
        {
            StreamReader fi = new StreamReader("bander.txt");
            while (!fi.EndOfStream)
            {
                string _name = fi.ReadLine();
                string _adress = fi.ReadLine();
                string _otdelen = fi.ReadLine();
                string _cost = fi.ReadLine();
                string _otprav = fi.ReadLine();
                string _otkuda = fi.ReadLine();
                string _ves = fi.ReadLine();
                string _track = fi.ReadLine();
                dobBan(_name, _adress, _otdelen, int.Parse(_cost), _otprav, _otkuda, int.Parse(_ves), _track);
            }

            fi.Close();
        }

        // посылка пакет
        public void dobPak(string _name, string _adress, string _otdelen, int _cost, string _otprav, string _otkuda, int _ves, string _track)
        {
            paket_pos _ppos = new paket_pos(_name, _adress, _otdelen, _cost, _otprav, _otkuda, _ves, _track);
            _p_pos.Add(_ppos);
            _Pcount++;
        }

        public void ReadPak()
        {
            StreamReader fi = new StreamReader("paket.txt");
            while (!fi.EndOfStream)
            {
                string _name = fi.ReadLine();
                string _adress = fi.ReadLine();
                string _otdelen = fi.ReadLine();
                string _cost = fi.ReadLine();
                string _otprav = fi.ReadLine();
                string _otkuda = fi.ReadLine();
                string _ves = fi.ReadLine();
                string _track = fi.ReadLine();
                dobPak(_name, _adress, _otdelen, int.Parse(_cost), _otprav, _otkuda, int.Parse(_ves), _track);
            }

            fi.Close();
        }
       

        // посылка емс
        public void dobEms(string _name, string _adress, string _otdelen, int _cost, string _otprav, string _otkuda, int _ves, string _track)
        {
            ems_pos _empos = new ems_pos(_name, _adress, _otdelen, _cost, _otprav, _otkuda, _ves, _track);
            _ems_pos.Add(_empos);
            _Ecount++;
        }

        public void ReadEms()
        {
            StreamReader fi = new StreamReader("ems.txt");
            while (!fi.EndOfStream)
            {
                string _name = fi.ReadLine();
                string _adress = fi.ReadLine();
                string _otdelen = fi.ReadLine();
                string _cost = fi.ReadLine();
                string _otprav = fi.ReadLine();
                string _otkuda = fi.ReadLine();
                string _ves = fi.ReadLine();
                string _track = fi.ReadLine();
                dobEms(_name, _adress, _otdelen, int.Parse(_cost), _otprav, _otkuda, int.Parse(_ves),_track);
            }

            fi.Close();
        }
        // заказное письмо
        public void dobZp(string _name, string _adress, string _otdelen, int _cost/*, string _track*/, string _otprav, string _otkuda, int _index)
        {
            zak_pismo _zp = new zak_pismo(_name, _adress, _otdelen, _cost, _otprav, _otkuda, _index); 
            _zak_pismo.Add(_zp);
            _Zpcount++;
        }

        public void ReadZp()
        {
            StreamReader fi = new StreamReader("zak_pismo.txt");
            while (!fi.EndOfStream)
            {
                string _name = fi.ReadLine();
                string _adress = fi.ReadLine();
                string _otdelen = fi.ReadLine();
                string _cost = fi.ReadLine();
                string _otprav = fi.ReadLine();
                string _otkuda = fi.ReadLine();
                string _index = fi.ReadLine();
                dobZp(_name, _adress, _otdelen, int.Parse(_cost), _otprav, _otkuda, int.Parse(_index));
            }
            fi.Close();
        }

        // обычная письмо
        public void dobOp(string _name, string _adress, string _otdelen, int _cost/*, string _track*/, string _otprav, string _otkuda, int _index)
        {
            ob_pismo _op = new ob_pismo(_name, _adress, _otdelen, _cost, _otprav, _otkuda, _index);
            _ob_pismo.Add(_op);
            _Opcount++;
        }

        public void ReadOp()
        {
            StreamReader fi = new StreamReader("ob_pismo.txt");
            while (!fi.EndOfStream)
            {
                string _name = fi.ReadLine();
                string _adress = fi.ReadLine();
                string _otdelen = fi.ReadLine();
                string _cost = fi.ReadLine();
                string _otprav = fi.ReadLine();
                string _otkuda = fi.ReadLine();
                string _index = fi.ReadLine();
               dobOp(_name, _adress, _otdelen, int.Parse(_cost),_otprav, _otkuda, int.Parse(_index));
            }
            fi.Close();
        }

    }
}
