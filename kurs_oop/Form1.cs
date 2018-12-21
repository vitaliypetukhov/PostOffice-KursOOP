using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace kurs_oop
{
    public partial class Font_image : Form
    {
        //private ListBox listBox1;
        List<TextBox> _tb = new List<TextBox>();
        List<Label> _lb = new List<Label>();
        List<ComboBox> _cb = new List<ComboBox>();
        

        order _order = new order();


        public int _Num = 0;
        public int _Flag = 0;
        public int _Prov = 0;


        public Font_image()
        {
            InitializeComponent();

            //--- текстбоксы
            _tb.Add(tb_test);
            _tb.Add(tb_test2);
            _tb.Add(tb_test3);
            _tb.Add(tb_test4);
            _tb.Add(tb_test5);
            _tb.Add(tb_test6);
            _tb.Add(tb_test7);
            _tb.Add(tb_test8);
            _tb.Add(tb_test9);
            _tb.Add(tb_test10);
            _tb.Add(tb_test11);

            //----- листбоксы

            _lb.Add(lb_test);
            _lb.Add(lb_test2);
            _lb.Add(lb_test3);
            _lb.Add(lb_test4);
            _lb.Add(lb_test5);
            _lb.Add(lb_test6);
            _lb.Add(lb_test7);
            _lb.Add(lb_test8);
            _lb.Add(lb_test9);
            _lb.Add(lb_test10);
            _lb.Add(lb_test11);
            _lb.Add(lb_test12);
            _lb.Add(lb_test13);
            _lb.Add(lb_test14);

            _cb.Add(cb_test);
            _cb.Add(cb_test1);
            _cb.Add(cb_test2);


            for (int i = 0; i < 8; i++)
            {
                _tb[i].Visible = false;
                _lb[i].Visible = false;
            }
            for (int i = 0; i < 3; i++)
            {
                _cb[i].Visible = false;
            }
            //--- find
            _tb[8].Visible = false;
            _lb[8].Visible = false;
            _lb[9].Visible = false;

            //-- filter
            _lb[10].Visible = false;
            _tb[9].Visible = false;
            _lb[11].Visible = false;
            _lb[12].Visible = false;
            _lb[13].Visible = false;
            _tb[10].Visible = false;





            //------------ загружаем данные
            _order.ReadPak();
            _order.ReadBan();
            _order.ReadEms();
            _order.ReadOp();
            _order.ReadZp();

            //------- - кнопки 

            M_pak_button.Visible = false;
            naz.Visible = false;
            vper.Visible = false;
            Ban_button.Visible = false;
            Ems_button.Visible = false;
            save_button.Visible = false;
            glav_men_button.Visible = false;
            nazad.Visible = false;
            dobavel_button.Visible = false;
            dobv_button.Visible = false;
            poisk_button.Visible = false;
            pictureBox1.Visible = false;


            pictureBox2.Visible = true;// почтовое отделение
            try
            {
                Image l = new Bitmap("lol.jpg");
                pictureBox2.Image = l;
            }
            catch
            {
                Image l = new Bitmap("not_found_image.jpg");
                pictureBox2.Image = l;
            }


            zakpis_button.Visible = false;
            obpis_button.Visible = false;
            dostavka_button.Visible = true;
            button1.Visible = true;
            del_button.Visible = false;
            filter_button.Visible = false;
        }

           

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void dostavka_button_Click(object sender, EventArgs e)
        {

            M_pak_button.Visible = true;
            Ban_button.Visible = true;
            Ems_button.Visible = true;
            zakpis_button.Visible = true;
            obpis_button.Visible = true;
            dobv_button.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            dostavka_button.Visible = false;
            button1.Visible = false;
            dobavel_button.Visible = false;
            save_button.Visible = false;
            filter_button.Visible = false;
            del_button.Visible = false;
            nazad.Visible = false;
            glav_men_button.Visible = true;

            for (int i = 0; i < 3; i++)
            {
                _cb[i].Visible = false;
            }
            //--- find
            _tb[8].Visible = false;
            _lb[8].Visible = false;
            _lb[9].Visible = false;

            //-- filter
            _lb[10].Visible = false;
            _tb[9].Visible = false;
            _lb[11].Visible = false;
            _lb[12].Visible = false;
            _lb[13].Visible = false;
            _tb[10].Visible = false;
            //-----------------------------   
        }
  
        private void glav_men_button_Click(object sender, EventArgs e)
        {
                dostavka_button.Visible = true;
                button1.Visible = true;
                M_pak_button.Visible = false;
                obpis_button.Visible = false;
                Ban_button.Visible = false;
                zakpis_button.Visible = false;
                Ems_button.Visible = false;
                dobv_button.Visible = false;
                del_button.Visible = false;
                poisk_button.Visible = false;
                filter_button.Visible = false;
                glav_men_button.Visible = false;

                for (int i = 0; i < 8; i++)
                {
                    _tb[i].Visible = false;
                    _lb[i].Visible = false;
                }

                naz.Visible = false;
                vper.Visible = false;
                save_button.Visible = false;
                dobavel_button.Visible = false;
                pictureBox1.Visible = false;

                pictureBox2.Visible = true;
                try
                {
                    Image l = new Bitmap("lol.jpg");
                    pictureBox2.Image = l;
                }
                catch
                {
                    Image l = new Bitmap("not_found_image.jpg");
                    pictureBox2.Image = l;
                }

                for (int i = 0; i < 3; i++)
                {
                    _cb[i].Visible = false;
                }
                //--- find
                _tb[8].Visible = false;
                _lb[8].Visible = false;
                _lb[9].Visible = false;

                //-- filter
                _lb[10].Visible = false;
                _tb[9].Visible = false;
                _lb[11].Visible = false;
                _lb[12].Visible = false;
                _lb[13].Visible = false;
                _tb[10].Visible = false;
                _tb[9].Text = "";
                _tb[10].Text = "";
        }

        private void M_pak_button_Click(object sender, EventArgs e)
        {

            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            _Prov = 4;

            try
            {
                Image l = new Bitmap("1.jpg");
                pictureBox1.Image = l;
            }
            catch
            {
                Image l = new Bitmap("not_found_image.jpg");
                pictureBox1.Image = l;
            }

            naz.Visible = true;
            vper.Visible = true;
            save_button.Visible = true;
            del_button.Visible = true;
            dobv_button.Visible = true;

            for (int i = 0; i < 8; i++)
            {
                _tb[i].Visible = true;
                _lb[i].Visible = true;
            }

            _lb[0].Text = "Ф.И.О. получателя посылки: ";
            _tb[0].Text = _order._p_pos[_Num].name;
            _lb[1].Text = "Адрес получателя посылки: ";
            _tb[1].Text = _order._p_pos[_Num].adress;
            _lb[2].Text = "Отделение почты: ";
            _tb[2].Text = _order._p_pos[_Num].otdelen;
            _lb[3].Text = "Стоимость посылки: ";
            _tb[3].Text = _order._p_pos[_Num].cost.ToString();
            _lb[4].Text = "Отправитель: ";
            _tb[4].Text = _order._p_pos[_Num].otprav;
            _lb[5].Text = "Откуда отправлена: ";
            _tb[5].Text = _order._p_pos[_Num].otkuda;
            _lb[6].Text = "Вес посылки: ";
            _tb[6].Text = _order._p_pos[_Num].ves.ToString();
            _lb[7].Text = "Трек номер: ";
            _tb[7].Text = _order._p_pos[_Num].track;

            M_pak_button.Visible = false;
            Ban_button.Visible = false;
            Ems_button.Visible = false;
            zakpis_button.Visible = false;
            obpis_button.Visible = false;
            dobavel_button.Visible = false;
            poisk_button.Visible = true;
            dostavka_button.Visible = false;
            button1.Visible = false;
            nazad.Visible = false;
            glav_men_button.Visible = true;
            filter_button.Visible = true;

            for (int i = 0; i < 3; i++)
            {
                _cb[i].Visible = false;
            }
            //--- find
            _tb[8].Visible = false;
            _lb[8].Visible = false;
            _lb[9].Visible = false;

            //-- filter
            _lb[10].Visible = false;
            _tb[9].Visible = false;
            _lb[11].Visible = false;
            _lb[12].Visible = false;
            _lb[13].Visible = false;
            _tb[10].Visible = false;
        }
        private void naz_Click(object sender, EventArgs e)
        {
            if (_Prov == 1)
            {
                if (_Num > 0)
                {
                    _Num--;
                    _lb[0].Text = "Ф.И.О. получателя письма: ";
                    _tb[0].Text = _order._ob_pismo[_Num].name;
                    _lb[1].Text = "Адрес получателя письма: ";
                    _tb[1].Text = _order._ob_pismo[_Num].adress;
                    _lb[2].Text = "Отделение почты: ";
                    _tb[2].Text = _order._ob_pismo[_Num].otdelen;
                    _lb[3].Text = "Стоимость письма: ";
                    _tb[3].Text = _order._ob_pismo[_Num].cost.ToString();
                    _lb[4].Text = "Отправитель: ";
                    _tb[4].Text = _order._ob_pismo[_Num].otprav;
                    _lb[5].Text = "Откуда отправлена: ";
                    _tb[5].Text = _order._ob_pismo[_Num].otkuda;
                    _lb[6].Text = "Индекс: ";
                    _tb[6].Text = _order._ob_pismo[_Num].index.ToString();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Вы не можете листать назад, т.к. находитесь на первом элементе!");
                }
            }
            if (_Prov == 2)
            {
                if (_Num > 0)
                {
                    _Num--;
                    _lb[0].Text = "Ф.И.О. получателя письма: ";
                    _tb[0].Text = _order._zak_pismo[_Num].name;
                    _lb[1].Text = "Адрес получателя письма: ";
                    _tb[1].Text = _order._zak_pismo[_Num].adress;
                    _lb[2].Text = "Отделение почты: ";
                    _tb[2].Text = _order._zak_pismo[_Num].otdelen;
                    _lb[3].Text = "Стоимость письма: ";
                    _tb[3].Text = _order._zak_pismo[_Num].cost.ToString();
                    _lb[4].Text = "Отправитель: ";
                    _tb[4].Text = _order._zak_pismo[_Num].otprav;
                    _lb[5].Text = "Откуда отправлена: ";
                    _tb[5].Text = _order._zak_pismo[_Num].otkuda;
                    _lb[6].Text = "Индекс: ";
                    _tb[6].Text = _order._zak_pismo[_Num].index.ToString();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Вы не можете листать назад, т.к. находитесь на первом элементе!");
                }
            }
            if (_Prov == 3)
            {
                if (_Num > 0)
                {
                    _Num--;
                    _lb[0].Text = "Ф.И.О. получателя посылки: ";
                    _tb[0].Text = _order._ems_pos[_Num].name;
                    _lb[1].Text = "Адрес получателя посылки: ";
                    _tb[1].Text = _order._ems_pos[_Num].adress;
                    _lb[2].Text = "Отделение почты: ";
                    _tb[2].Text = _order._ems_pos[_Num].otdelen;
                    _lb[3].Text = "Стоимость посылки: ";
                    _tb[3].Text = _order._ems_pos[_Num].cost.ToString();
                    _lb[4].Text = "Отправитель: ";
                    _tb[4].Text = _order._ems_pos[_Num].otprav;
                    _lb[5].Text = "Откуда отправлена: ";
                    _tb[5].Text = _order._ems_pos[_Num].otkuda;
                    _lb[6].Text = "Вес посылки: ";
                    _tb[6].Text = _order._ems_pos[_Num].ves.ToString();
                    _lb[7].Text = "Трек номер: ";
                    _tb[7].Text = _order._ems_pos[_Num].track;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Вы не можете листать назад, т.к. находитесь на первом элементе!");
                }
            }
            if (_Prov == 4)
            {
                if (_Num > 0)
                {
                    _Num--;
                    _lb[0].Text = "Ф.И.О. получателя посылки: ";
                    _tb[0].Text = _order._p_pos[_Num].name;
                    _lb[1].Text = "Адрес получателя посылки: ";
                    _tb[1].Text = _order._p_pos[_Num].adress;
                    _lb[2].Text = "Отделение почты: ";
                    _tb[2].Text = _order._p_pos[_Num].otdelen;
                    _lb[3].Text = "Стоимость посылки: ";
                    _tb[3].Text = _order._p_pos[_Num].cost.ToString();
                    _lb[4].Text = "Отправитель: ";
                    _tb[4].Text = _order._p_pos[_Num].otprav;
                    _lb[5].Text = "Откуда отправлена: ";
                    _tb[5].Text = _order._p_pos[_Num].otkuda;
                    _lb[6].Text = "Вес посылки: ";
                    _tb[6].Text = _order._p_pos[_Num].ves.ToString();
                    _lb[7].Text = "Трек номер: ";
                    _tb[7].Text = _order._p_pos[_Num].track;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Вы не можете листать назад, т.к. находитесь на первом элементе!");
                }
            }
            if (_Prov == 5)
            {
                if (_Num > 0)
                {
                    _Num--;
                    _lb[0].Text = "Ф.И.О. получателя посылки: ";
                    _tb[0].Text = _order._ban_pos[_Num].name;
                    _lb[1].Text = "Адрес получателя посылки: ";
                    _tb[1].Text = _order._ban_pos[_Num].adress;
                    _lb[2].Text = "Отделение почты: ";
                    _tb[2].Text = _order._ban_pos[_Num].otdelen;
                    _lb[3].Text = "Стоимость посылки: ";
                    _tb[3].Text = _order._ban_pos[_Num].cost.ToString();
                    _lb[4].Text = "Отправитель: ";
                    _tb[4].Text = _order._ban_pos[_Num].otprav;
                    _lb[5].Text = "Откуда отправлена: ";
                    _tb[5].Text = _order._ban_pos[_Num].otkuda;
                    _lb[6].Text = "Вес посылки: ";
                    _tb[6].Text = _order._ban_pos[_Num].ves.ToString();
                    _lb[7].Text = "Трек номер: ";
                    _tb[7].Text = _order._ban_pos[_Num].track;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Вы не можете листать назад, т.к. находитесь на первом элементе!");
                }
            }
        }

        private void vper_Click(object sender, EventArgs e)
        {
            if (_Prov == 1)
            {
                if ((_order._Opcount - 1) > _Num)
                {
                    _Num++;
                    _lb[0].Text = "Ф.И.О. получателя письма: ";
                    _tb[0].Text = _order._ob_pismo[_Num].name;
                    _lb[1].Text = "Адрес получателя письма: ";
                    _tb[1].Text = _order._ob_pismo[_Num].adress;
                    _lb[2].Text = "Отделение почты: ";
                    _tb[2].Text = _order._ob_pismo[_Num].otdelen;
                    _lb[3].Text = "Стоимость письма: ";
                    _tb[3].Text = _order._ob_pismo[_Num].cost.ToString();
                    _lb[4].Text = "Отправитель: ";
                    _tb[4].Text = _order._ob_pismo[_Num].otprav;
                    _lb[5].Text = "Откуда отправлена: ";
                    _tb[5].Text = _order._ob_pismo[_Num].otkuda;
                    _lb[6].Text = "Индекс: ";
                    _tb[6].Text = _order._ob_pismo[_Num].index.ToString();

                    if (_Flag == 1)
                    {
                        for (int i = 0; i < 8; i++)
                        {
                            _tb[i].Visible = true;
                            _lb[i].Visible = true;
                        }
                    }
                 
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Вы не можете листать вперед, т.к. находитесь на последнем элементе!");
                }
            }
            if (_Prov == 2)
            {
                if ((_order._Zpcount - 1) > _Num)
                {
                    _Num++;
                    _lb[0].Text = "Ф.И.О. получателя письма: ";
                    _tb[0].Text = _order._zak_pismo[_Num].name;
                    _lb[1].Text = "Адрес получателя письма: ";
                    _tb[1].Text = _order._zak_pismo[_Num].adress;
                    _lb[2].Text = "Отделение почты: ";
                    _tb[2].Text = _order._zak_pismo[_Num].otdelen;
                    _lb[3].Text = "Стоимость письма: ";
                    _tb[3].Text = _order._zak_pismo[_Num].cost.ToString();
                    _lb[4].Text = "Отправитель: ";
                    _tb[4].Text = _order._zak_pismo[_Num].otprav;
                    _lb[5].Text = "Откуда отправлена: ";
                    _tb[5].Text = _order._zak_pismo[_Num].otkuda;
                    _lb[6].Text = "Индекс: ";
                    _tb[6].Text = _order._ob_pismo[_Num].index.ToString();

                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Вы не можете листать вперед, т.к. находитесь на последнем элементе!");
                }
            }
            if (_Prov == 3)
            {
                if ((_order._Ecount - 1) > _Num)
                {
                    _Num++;
                    _lb[0].Text = "Ф.И.О. получателя посылки: ";
                    _tb[0].Text = _order._ems_pos[_Num].name;
                    _lb[1].Text = "Адрес получателя посылки: ";
                    _tb[1].Text = _order._ems_pos[_Num].adress;
                    _lb[2].Text = "Отделение почты: ";
                    _tb[2].Text = _order._ems_pos[_Num].otdelen;
                    _lb[3].Text = "Стоимость посылки: ";
                    _tb[3].Text = _order._ems_pos[_Num].cost.ToString();
                    _lb[4].Text = "Отправитель: ";
                    _tb[4].Text = _order._ems_pos[_Num].otprav;
                    _lb[5].Text = "Откуда отправлена: ";
                    _tb[5].Text = _order._ems_pos[_Num].otkuda;
                    _lb[6].Text = "Вес посылки: ";
                    _tb[6].Text = _order._ems_pos[_Num].ves.ToString();
                    _lb[7].Text = "Трек номер: ";
                    _tb[7].Text = _order._ems_pos[_Num].track;

                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Вы не можете листать вперед, т.к. находитесь на последнем элементе!");
                }
            }
            if (_Prov == 4)
            {
                if ((_order._Pcount - 1) > _Num)
                {
                    _Num++;
                    _lb[0].Text = "Ф.И.О. получателя посылки: ";
                    _tb[0].Text = _order._p_pos[_Num].name;
                    _lb[1].Text = "Адрес получателя посылки: ";
                    _tb[1].Text = _order._p_pos[_Num].adress;
                    _lb[2].Text = "Отделение почты: ";
                    _tb[2].Text = _order._p_pos[_Num].otdelen;
                    _lb[3].Text = "Стоимость посылки: ";
                    _tb[3].Text = _order._p_pos[_Num].cost.ToString();
                    _lb[4].Text = "Отправитель: ";
                    _tb[4].Text = _order._p_pos[_Num].otprav;
                    _lb[5].Text = "Откуда отправлена: ";
                    _tb[5].Text = _order._p_pos[_Num].otkuda;
                    _lb[6].Text = "Вес посылки: ";
                    _tb[6].Text = _order._p_pos[_Num].ves.ToString();
                    _lb[7].Text = "Трек номер: ";
                    _tb[7].Text = _order._p_pos[_Num].track;

                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Вы не можете листать вперед, т.к. находитесь на последнем элементе!");
                }
            }
            if (_Prov == 5)
            {
                if ((_order._Bcount - 1) > _Num)
                {
                    _Num++;
                    _lb[0].Text = "Ф.И.О. получателя посылки: ";
                    _tb[0].Text = _order._ban_pos[_Num].name;
                    _lb[1].Text = "Адрес получателя посылки: ";
                    _tb[1].Text = _order._ban_pos[_Num].adress;
                    _lb[2].Text = "Отделение почты: ";
                    _tb[2].Text = _order._ban_pos[_Num].otdelen;
                    _lb[3].Text = "Стоимость посылки: ";
                    _tb[3].Text = _order._ban_pos[_Num].cost.ToString();
                    _lb[4].Text = "Отправитель: ";
                    _tb[4].Text = _order._ban_pos[_Num].otprav;
                    _lb[5].Text = "Откуда отправлена: ";
                    _tb[5].Text = _order._ban_pos[_Num].otkuda;
                    _lb[6].Text = "Вес посылки: ";
                    _tb[6].Text = _order._ban_pos[_Num].ves.ToString();
                    _lb[7].Text = "Трек номер: ";
                    _tb[7].Text = _order._ban_pos[_Num].track;

                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Вы не можете листать вперед, т.к. находитесь на последнем элементе!");
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Данная программное средство разработано в рамках курсового проекта \nПо дисциплине: Объектно Ориентированное Программирование \nСтудентом группы 11-ИТ-3: Петуховым Виталием");
        }

        private void Ban_button_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            _Prov = 5;

            try
            {
                Image l = new Bitmap("3.jpg");
                pictureBox1.Image = l;
            }
            catch
            {
                Image l = new Bitmap("not_found_image.jpg");
                pictureBox1.Image = l;
            }

            naz.Visible = true;
            vper.Visible = true;
            save_button.Visible = true;
            del_button.Visible = true;
            dobv_button.Visible = true;

            for (int i = 0; i < 8; i++)
            {
                _tb[i].Visible = true;
                _lb[i].Visible = true;
            }

            _lb[0].Text = "Ф.И.О. получателя посылки: ";
            _tb[0].Text = _order._ban_pos[_Num].name;
            _lb[1].Text = "Адрес получателя посылки: ";
            _tb[1].Text = _order._ban_pos[_Num].adress;
            _lb[2].Text = "Отделение почты: ";
            _tb[2].Text = _order._ban_pos[_Num].otdelen;
            _lb[3].Text = "Стоимость посылки: ";
            _tb[3].Text = _order._ban_pos[_Num].cost.ToString();
            _lb[4].Text = "Отправитель: ";
            _tb[4].Text = _order._ban_pos[_Num].otprav;
            _lb[5].Text = "Откуда отправлена: ";
            _tb[5].Text = _order._ban_pos[_Num].otkuda;
            _lb[6].Text = "Вес посылки: ";
            _tb[6].Text = _order._ban_pos[_Num].ves.ToString();
            _lb[7].Text = "Трек номер: ";
            _tb[7].Text = _order._ban_pos[_Num].track;

            M_pak_button.Visible = false;
            Ban_button.Visible = false;
            Ems_button.Visible = false;
            zakpis_button.Visible = false;
            obpis_button.Visible = false;
            dobavel_button.Visible = false;
            poisk_button.Visible = true;
            dostavka_button.Visible = false;
            button1.Visible = false;
            nazad.Visible = false;
            glav_men_button.Visible = true;
            filter_button.Visible = true;

            for (int i = 0; i < 3; i++)
            {
                _cb[i].Visible = false;
            }
            //--- find
            _tb[8].Visible = false;
            _lb[8].Visible = false;
            _lb[9].Visible = false;

            //-- filter
            _lb[10].Visible = false;
            _tb[9].Visible = false;
            _lb[11].Visible = false;
            _lb[12].Visible = false;
            _lb[13].Visible = false;
            _tb[10].Visible = false;
        }

        private void Ems_button_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            _Prov = 3;

            try
            {
                Image l = new Bitmap("2.jpg");
                pictureBox1.Image = l;
            }
            catch
            {
                Image l = new Bitmap("not_found_image.jpg");
                pictureBox1.Image = l;
            }

            naz.Visible = true;
            vper.Visible = true;
            save_button.Visible = true;
            del_button.Visible = true;
            dobv_button.Visible = true;

            for (int i = 0; i < 8; i++)
            {
                _tb[i].Visible = true;
                _lb[i].Visible = true;
            }

            _lb[0].Text = "Ф.И.О. получателя посылки: ";
            _tb[0].Text = _order._ems_pos[_Num].name;
            _lb[1].Text = "Адрес получателя посылки: ";
            _tb[1].Text = _order._ems_pos[_Num].adress;
            _lb[2].Text = "Отделение почты: ";
            _tb[2].Text = _order._ems_pos[_Num].otdelen;
            _lb[3].Text = "Стоимость посылки: ";
            _tb[3].Text = _order._ems_pos[_Num].cost.ToString();
            _lb[4].Text = "Отправитель: ";
            _tb[4].Text = _order._ems_pos[_Num].otprav;
            _lb[5].Text = "Откуда отправлена: ";
            _tb[5].Text = _order._ems_pos[_Num].otkuda;
            _lb[6].Text = "Вес посылки: ";
            _tb[6].Text = _order._ems_pos[_Num].ves.ToString();
            _lb[7].Text = "Трек номер: ";
            _tb[7].Text = _order._ems_pos[_Num].track;

            M_pak_button.Visible = false;
            Ban_button.Visible = false;
            Ems_button.Visible = false;
            obpis_button.Visible = false;
            zakpis_button.Visible = false;
            dobavel_button.Visible = false;
            poisk_button.Visible = true;
            dostavka_button.Visible = false;
            button1.Visible = false;
            nazad.Visible = false;
            glav_men_button.Visible = true;
            filter_button.Visible = true;

            for (int i = 0; i < 3; i++)
            {
                _cb[i].Visible = false;
            }
            //--- find
            _tb[8].Visible = false;
            _lb[8].Visible = false;
            _lb[9].Visible = false;

            //-- filter
            _lb[10].Visible = false;
            _tb[9].Visible = false;
            _lb[11].Visible = false;
            _lb[12].Visible = false;
            _lb[13].Visible = false;
            _tb[10].Visible = false;

        }

        private void dobv_button_Click(object sender, EventArgs e)
        {
            naz.Visible = false;
            vper.Visible = false;
            nazad.Visible = true;
            glav_men_button.Visible = false;
            dobv_button.Visible = false;
            del_button.Visible = false;
            save_button.Visible = false;
            poisk_button.Visible = false;
            filter_button.Visible = false;
            dobavel_button.Visible = true;

            if (_Prov == 1 || _Prov == 2)
            {
                for (int i = 0; i < 7; i++)
                {
                    _tb[i].Text = "";
                }
            }

            if (_Prov == 4 || _Prov == 3 || _Prov == 5)
            {
                for (int i = 0; i < 8; i++)
                {
                    _tb[i].Text = "";
                }
            }
        }



        private void dobavel_button_Click(object sender, EventArgs e)
        {
            if (_Prov == 1)
            {

                if (_tb[0].Text == "" || _tb[1].Text == "" || _tb[2].Text == "" || _tb[3].Text == "" || _tb[4].Text == "" ||
                    _tb[5].Text == "" || _tb[6].Text == "")
                {
                    System.Windows.Forms.MessageBox.Show("Одно из полей пусто!");
                }
                else
                {
                    _Num++;
                    _order.dobOp(_tb[0].Text, _tb[1].Text, _tb[2].Text, int.Parse(_tb[3].Text), _tb[4].Text, _tb[5].Text, int.Parse(_tb[6].Text));
                    for (int i = 0; i < 7; i++)
                    {
                        _tb[i].Text = "";

                    }
                    System.Windows.Forms.MessageBox.Show("Элемент добавлен в список писем с типом обычное письмо!");
                    for (int i = 0; i < 8; i++)
                    {
                        _tb[i].Visible = false;
                        _lb[i].Visible = false;
                    }
                    nazad.Visible = true;
                    glav_men_button.Visible = true;
                    obpis_button.Visible = true;
                    zakpis_button.Visible = true;
                    Ems_button.Visible = true;
                    Ban_button.Visible = true;
                    M_pak_button.Visible = true;
                    dobavel_button.Visible = false;
                    dobv_button.Visible = false;
                    save_button.Visible = false;
                    del_button.Visible = false;
                    poisk_button.Visible = false;
                    naz.Visible = false;
                    vper.Visible = false;
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    filter_button.Visible = false;

                    for (int i = 0; i < 3; i++)
                    {
                        _cb[i].Visible = false;
                    }
                    //--- find
                    _tb[8].Visible = false;
                    _lb[8].Visible = false;
                    _lb[9].Visible = false;

                    //-- filter
                    _lb[10].Visible = false;
                    _tb[9].Visible = false;
                    _lb[11].Visible = false;
                    _lb[12].Visible = false;
                    _lb[13].Visible = false;
                    _tb[10].Visible = false;
                }
            }
            if (_Prov == 2)
            {
                if (_tb[0].Text == "" || _tb[1].Text == "" || _tb[2].Text == "" || _tb[3].Text == "" || _tb[4].Text == "" ||
                    _tb[5].Text == "" || _tb[6].Text == "")
                {
                    System.Windows.Forms.MessageBox.Show("Одно из полей пусто!");
                }
                else
                {
                    _Num++;
                    _order.dobOp(_tb[0].Text, _tb[1].Text, _tb[2].Text, int.Parse(_tb[3].Text), _tb[4].Text, _tb[5].Text, int.Parse(_tb[6].Text));
                    for (int i = 0; i < 7; i++)
                    {
                        _tb[i].Text = "";

                    }
                    System.Windows.Forms.MessageBox.Show("Элемент добавлен в список писем с типом заказное письмо!");
                    for (int i = 0; i < 8; i++)
                    {
                        _tb[i].Visible = false;
                        _lb[i].Visible = false;
                    }
                    nazad.Visible = true;
                    glav_men_button.Visible = false;
                    obpis_button.Visible = true;
                    zakpis_button.Visible = true;
                    Ems_button.Visible = true;
                    Ban_button.Visible = true;
                    M_pak_button.Visible = true;
                    dobavel_button.Visible = false;
                    dobv_button.Visible = false;
                    save_button.Visible = false;
                    del_button.Visible = false;
                    poisk_button.Visible = false;
                    naz.Visible = false;
                    vper.Visible = false;
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    filter_button.Visible = false;

                    for (int i = 0; i < 3; i++)
                    {
                        _cb[i].Visible = false;
                    }
                    //--- find
                    _tb[8].Visible = false;
                    _lb[8].Visible = false;
                    _lb[9].Visible = false;

                    //-- filter
                    _lb[10].Visible = false;
                    _tb[9].Visible = false;
                    _lb[11].Visible = false;
                    _lb[12].Visible = false;
                    _lb[13].Visible = false;
                    _tb[10].Visible = false;
                }
            }
            if (_Prov == 3)
            {
                if (_tb[0].Text == "" || _tb[1].Text == "" || _tb[2].Text == "" || _tb[3].Text == "" || _tb[4].Text == "" ||
                    _tb[5].Text == "" || _tb[6].Text == "" || _tb[7].Text == "")
                {
                    System.Windows.Forms.MessageBox.Show("Одно из полей пусто!");
                }
                else
                {
                    _Num++;
                    _order.dobEms(_tb[0].Text, _tb[1].Text, _tb[2].Text, int.Parse(_tb[3].Text), _tb[4].Text, _tb[5].Text, int.Parse(_tb[6].Text), _tb[7].Text);
                    for (int i = 0; i < 8; i++)
                    {
                        _tb[i].Text = "";
                    }
                    System.Windows.Forms.MessageBox.Show("Элемент добавлен в список посылок с типом EMS  доставки!");
                    for (int i = 0; i < 8; i++)
                    {
                        _tb[i].Visible = false;
                        _lb[i].Visible = false;
                    }
                    nazad.Visible = true;
                    glav_men_button.Visible = false;
                    obpis_button.Visible = true;
                    zakpis_button.Visible = true;
                    Ems_button.Visible = true;
                    Ban_button.Visible = true;
                    M_pak_button.Visible = true;
                    dobavel_button.Visible = false;
                    dobv_button.Visible = false;
                    del_button.Visible = false;
                    save_button.Visible = false;
                    poisk_button.Visible = false;
                    naz.Visible = false;
                    vper.Visible = false;
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    filter_button.Visible = false;

                    for (int i = 0; i < 3; i++)
                    {
                        _cb[i].Visible = false;
                    }
                    //--- find
                    _tb[8].Visible = false;
                    _lb[8].Visible = false;
                    _lb[9].Visible = false;

                    //-- filter
                    _lb[10].Visible = false;
                    _tb[9].Visible = false;
                    _lb[11].Visible = false;
                    _lb[12].Visible = false;
                    _lb[13].Visible = false;
                    _tb[10].Visible = false;

                }
            }
            if (_Prov == 4)
            {
                if (_tb[0].Text == "" || _tb[1].Text == "" || _tb[2].Text == "" || _tb[3].Text == "" || _tb[4].Text == ""||
                    _tb[5].Text == "" || _tb[6].Text == "" || _tb[7].Text == "") 
                {
                    System.Windows.Forms.MessageBox.Show("Одно из полей пусто!");
                }
                else
                {
                    _Num++;
                    _order.dobPak(_tb[0].Text, _tb[1].Text, _tb[2].Text, int.Parse(_tb[3].Text), _tb[4].Text, _tb[5].Text, int.Parse(_tb[6].Text), _tb[7].Text);
                    for (int i = 0; i < 8; i++)
                    {
                        _tb[i].Text = "";
                    }
                    System.Windows.Forms.MessageBox.Show("Элемент добавлен в список посылок с типом мелкий пакет!");
                    //------------ удаление кнопочек 
                    for (int i = 0; i < 8; i++)
                    {
                        _tb[i].Visible = false;
                        _lb[i].Visible = false;
                    }
                    nazad.Visible = true;
                    glav_men_button.Visible = false;
                    obpis_button.Visible = true;
                    zakpis_button.Visible = true;
                    Ems_button.Visible = true;
                    Ban_button.Visible = true;
                    M_pak_button.Visible = true;
                    dobavel_button.Visible = false;
                    dobv_button.Visible = false;
                    del_button.Visible = false;
                    save_button.Visible = false;
                    poisk_button.Visible = false;
                    naz.Visible = false;
                    vper.Visible = false;
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    filter_button.Visible = false;

                    for (int i = 0; i < 3; i++)
                    {
                        _cb[i].Visible = false;
                    }
                    //--- find
                    _tb[8].Visible = false;
                    _lb[8].Visible = false;
                    _lb[9].Visible = false;

                    //-- filter
                    _lb[10].Visible = false;
                    _tb[9].Visible = false;
                    _lb[11].Visible = false;
                    _lb[12].Visible = false;
                    _lb[13].Visible = false;
                    _tb[10].Visible = false;
                }
            }
            if (_Prov == 5)
            {
                if (_tb[0].Text == "" || _tb[1].Text == "" || _tb[2].Text == "" || _tb[3].Text == "" || _tb[4].Text == "" ||
                    _tb[5].Text == "" || _tb[6].Text == "" || _tb[7].Text == "")
                {
                    System.Windows.Forms.MessageBox.Show("Одно из полей пусто!");
                }
                else
                {
                    _Num++;
                    _order.dobBan(_tb[0].Text, _tb[1].Text, _tb[2].Text, int.Parse(_tb[3].Text), _tb[4].Text, _tb[5].Text, int.Parse(_tb[6].Text), _tb[7].Text);
                    for (int i = 0; i < 8; i++)
                    {
                        _tb[i].Text = "";
                    }
                    System.Windows.Forms.MessageBox.Show("Элемент добавлен в список посылок с типом Бандероль!");
                    //------------ удаление кнопочек 
                    for (int i = 0; i < 8; i++)
                    {
                        _tb[i].Visible = false;
                        _lb[i].Visible = false;
                    }
                    nazad.Visible = true;
                    glav_men_button.Visible = false;
                    obpis_button.Visible = true;
                    zakpis_button.Visible = true;
                    Ems_button.Visible = true;
                    Ban_button.Visible = true;
                    M_pak_button.Visible = true;
                    dobavel_button.Visible = false;
                    dobv_button.Visible = false;
                    save_button.Visible = false;
                    del_button.Visible = false;
                    poisk_button.Visible = false;
                    naz.Visible = false;
                    vper.Visible = false;
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = false;
                    filter_button.Visible = false;

                    for (int i = 0; i < 3; i++)
                    {
                        _cb[i].Visible = false;
                    }
                    //--- find
                    _tb[8].Visible = false;
                    _lb[8].Visible = false;
                    _lb[9].Visible = false;

                    //-- filter
                    _lb[10].Visible = false;
                    _tb[9].Visible = false;
                    _lb[11].Visible = false;
                    _lb[12].Visible = false;
                    _lb[13].Visible = false;
                    _tb[10].Visible = false;
                }
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (_Prov == 1)
            {
                StreamWriter fi = new StreamWriter("ob_pismo.txt");
                for (int i = 0; i < _order._Opcount; i++)
                {
                    fi.WriteLine(_order._ob_pismo[i].name);
                    fi.WriteLine(_order._ob_pismo[i].adress);
                    fi.WriteLine(_order._ob_pismo[i].otdelen);
                    fi.WriteLine(_order._ob_pismo[i].cost.ToString());
                    fi.WriteLine(_order._ob_pismo[i].otprav);
                    fi.WriteLine(_order._ob_pismo[i].otkuda);
                    fi.WriteLine(_order._ob_pismo[i].index.ToString());
                }
                fi.Close();
                System.Windows.Forms.MessageBox.Show("Изменения успешно сохранены!");
            }
            if (_Prov == 1)
            {
                StreamWriter fi = new StreamWriter("zak_pismo.txt");
                for (int i = 0; i < _order._Zpcount; i++)
                {
                    fi.WriteLine(_order._zak_pismo[i].name);
                    fi.WriteLine(_order._zak_pismo[i].adress);
                    fi.WriteLine(_order._zak_pismo[i].otdelen);
                    fi.WriteLine(_order._zak_pismo[i].cost.ToString());
                    fi.WriteLine(_order._zak_pismo[i].otprav);
                    fi.WriteLine(_order._zak_pismo[i].otkuda);
                    fi.WriteLine(_order._zak_pismo[i].index.ToString());
                }
                fi.Close();
                System.Windows.Forms.MessageBox.Show("Изменения успешно сохранены!");
            }
            if (_Prov == 3)
            {
                StreamWriter fi = new StreamWriter("ems.txt");
                for (int i = 0; i < _order._Ecount; i++)
                {
                    //dobEms(_name, _adress, _otdelen, int.Parse(_cost), _otprav, _otkuda, int.Parse(_ves),_track);
                    fi.WriteLine(_order._ems_pos[i].name);
                    fi.WriteLine(_order._ems_pos[i].adress);
                    fi.WriteLine(_order._ems_pos[i].otdelen);
                    fi.WriteLine(_order._ems_pos[i].cost.ToString());
                    fi.WriteLine(_order._ems_pos[i].otprav);
                    fi.WriteLine(_order._ems_pos[i].otkuda);
                    fi.WriteLine(_order._ems_pos[i].ves.ToString());
                    fi.WriteLine(_order._ems_pos[i].track);
                }
                fi.Close();
                System.Windows.Forms.MessageBox.Show("Изменения успешно сохранены!");
            }
            if (_Prov == 4)
            {
                StreamWriter fi = new StreamWriter("paket.txt");
                for (int i = 0; i < _order._Pcount; i++)
                {
                    fi.WriteLine(_order._p_pos[i].name);
                    fi.WriteLine(_order._p_pos[i].adress);
                    fi.WriteLine(_order._p_pos[i].otdelen);
                    fi.WriteLine(_order._p_pos[i].cost.ToString());
                    fi.WriteLine(_order._p_pos[i].otprav);
                    fi.WriteLine(_order._p_pos[i].otkuda);
                    fi.WriteLine(_order._p_pos[i].ves.ToString());
                    fi.WriteLine(_order._p_pos[i].track);
                }
                fi.Close();
                System.Windows.Forms.MessageBox.Show("Изменения успешно сохранены!");
            }
            if (_Prov == 5)
            {
                StreamWriter fi = new StreamWriter("bander.txt");
                for (int i = 0; i < _order._Bcount; i++)
                {
                    fi.WriteLine(_order._ban_pos[i].name);
                    fi.WriteLine(_order._ban_pos[i].adress);
                    fi.WriteLine(_order._ban_pos[i].otdelen);
                    fi.WriteLine(_order._ban_pos[i].cost.ToString());
                    fi.WriteLine(_order._ban_pos[i].otprav);
                    fi.WriteLine(_order._ban_pos[i].otkuda);
                    fi.WriteLine(_order._ban_pos[i].ves.ToString());
                    fi.WriteLine(_order._ban_pos[i].track);
                }
                fi.Close();
                System.Windows.Forms.MessageBox.Show("Изменения успешно сохранены!");
            }
        }

        private void zakpis_button_Click(object sender, EventArgs e)
        {
            _Prov = 2;
            pictureBox1.Visible = true;
            pictureBox2.Visible = false;
            try
            {
                Image l = new Bitmap("5.jpg");
                pictureBox1.Image = l;
            }
            catch
            {
                Image l = new Bitmap("not_found_image.jpg");
                pictureBox1.Image = l;
            }

            naz.Visible = true;
            vper.Visible = true;
            save_button.Visible = true;
            poisk_button.Visible = true;
            del_button.Visible = true;
            dobv_button.Visible = true;

            for (int i = 0; i < 7; i++)
            {
                _tb[i].Visible = true;
                _lb[i].Visible = true;
            }

            _lb[0].Text = "Ф.И.О. получателя посылки: ";
            _tb[0].Text = _order._zak_pismo[_Num].name;
            _lb[1].Text = "Адрес получателя посылки: ";
            _tb[1].Text = _order._zak_pismo[_Num].adress;
            _lb[2].Text = "Отделение почты: ";
            _tb[2].Text = _order._zak_pismo[_Num].otdelen;
            _lb[3].Text = "Стоимость посылки: ";
            _tb[3].Text = _order._zak_pismo[_Num].cost.ToString();
            _lb[4].Text = "Отправитель: ";
            _tb[4].Text = _order._zak_pismo[_Num].otprav;
            _lb[5].Text = "Откуда отправлена: ";
            _tb[5].Text = _order._zak_pismo[_Num].otkuda;
            _lb[6].Text = "Индекс: ";
            _tb[6].Text = _order._zak_pismo[_Num].index.ToString();

            M_pak_button.Visible = false;
            Ban_button.Visible = false;
            Ems_button.Visible = false;
            zakpis_button.Visible = false;
            obpis_button.Visible = false;
            dobavel_button.Visible = false;
            dostavka_button.Visible = false;
            button1.Visible = false;
            nazad.Visible = false;
            glav_men_button.Visible = true;
            filter_button.Visible = true;

            for (int i = 0; i < 3; i++)
            {
                _cb[i].Visible = false;
            }
            //--- find
            _tb[8].Visible = false;
            _lb[8].Visible = false;
            _lb[9].Visible = false;

            //-- filter
            _lb[10].Visible = false;
            _tb[9].Visible = false;
            _lb[11].Visible = false;
            _lb[12].Visible = false;
            _lb[13].Visible = false;
            _tb[10].Visible = false;
        }

        private void obpis_button_Click(object sender, EventArgs e)
        {
            _Prov = 1;
            pictureBox1.Visible = true;
            try
            {
                Image l = new Bitmap("4.jpg");
                pictureBox1.Image = l;
            }
            catch
            {
                Image l = new Bitmap("not_found_image.jpg");
                pictureBox1.Image = l;
            }

            naz.Visible = true;
            vper.Visible = true;
            save_button.Visible = true;
            del_button.Visible = true;
            poisk_button.Visible = true;
            dobv_button.Visible = true;

            for (int i = 0; i < 7; i++)
            {
                _tb[i].Visible = true;
                _lb[i].Visible = true;
            }

            _lb[0].Text = "Ф.И.О. получателя посылки: ";
            _tb[0].Text = _order._ob_pismo[_Num].name;
            _lb[1].Text = "Адрес получателя посылки: ";
            _tb[1].Text = _order._ob_pismo[_Num].adress;
            _lb[2].Text = "Отделение почты: ";
            _tb[2].Text = _order._ob_pismo[_Num].otdelen;
            _lb[3].Text = "Стоимость посылки: ";
            _tb[3].Text = _order._ob_pismo[_Num].cost.ToString();
            _lb[4].Text = "Отправитель: ";
            _tb[4].Text = _order._ob_pismo[_Num].otprav;
            _lb[5].Text = "Откуда отправлена: ";
            _tb[5].Text = _order._ob_pismo[_Num].otkuda;
            _lb[6].Text = "Индекс: ";
            _tb[6].Text = _order._ob_pismo[_Num].index.ToString();

            M_pak_button.Visible = false;
            Ban_button.Visible = false;
            Ems_button.Visible = false;
            zakpis_button.Visible = false;
            obpis_button.Visible = false;
            dobavel_button.Visible = false;
            dostavka_button.Visible = false;
            button1.Visible = false;
            nazad.Visible = false;
            glav_men_button.Visible = true;
            filter_button.Visible = true;

            for (int i = 0; i < 3; i++)
            {
                _cb[i].Visible = false;
            }
            //--- find
            _tb[8].Visible = false;
            _lb[8].Visible = false;
            _lb[9].Visible = false;

            //-- filter
            _lb[10].Visible = false;
            _tb[9].Visible = false;
            _lb[11].Visible = false;
            _lb[12].Visible = false;
            _lb[13].Visible = false;
            _tb[10].Visible = false;
        }

        private void del_button_Click(object sender, EventArgs e)
        {
            if (_Prov == 1)
            {
                _Flag = 0;
                if (_Num > 0)
                {
                    _Num--;
                    for (int i = 0; i < 7; i++)
                    {
                        _tb[i].Text = "";
                    }
                    System.Windows.Forms.MessageBox.Show("Элемент успешно удален!");
                }
                else
                {
                    _Flag = 1;
                    System.Windows.Forms.MessageBox.Show("Cписок пуст!");
                }

            }
            if (_Prov == 2)
            {
                _Flag = 0;
                if (_Num > 0)
                {
                    _Num--;
                    for (int i = 0; i < 7; i++)
                    {
                        _tb[i].Text = "";
                    }
                    System.Windows.Forms.MessageBox.Show("Элемент успешно удален!");
                }
                else
                {
                    _Flag = 1;
                    System.Windows.Forms.MessageBox.Show("Cписок пуст!");
                }

                

            }
            if (_Prov == 3)
            {
                if (_Num > 0)
                {
                    _Num--;
                    for (int i = 0; i < 8; i++)
                    {
                        _tb[i].Text = "";
                    }
                    System.Windows.Forms.MessageBox.Show("Элемент успешно удален!");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Cписок пуст!");
                }

            }
            if (_Prov == 4)
            {
                if (_Num > 0)
                {
                    _Num--;
                    for (int i = 0; i < 8; i++)
                    {
                        _tb[i].Text = "";
                    }
                    System.Windows.Forms.MessageBox.Show("Элемент успешно удален!");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Cписок пуст!");
                }

            }
            if (_Prov == 5)
            {
                if (_Num > 0)
                {
                    _Num--;
                    for (int i = 0; i < 8; i++)
                    {
                        _tb[i].Text = "";
                    }
                    System.Windows.Forms.MessageBox.Show("Элемент успешно удален!");
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Cписок пуст!");
                }

            }
        }

        private void poisk_button_Click(object sender, EventArgs e)
        {
            //------------ удаление кнопочек 
            for (int i = 0; i < 8; i++)
            {
                _tb[i].Visible = false;
                _lb[i].Visible = false;
            }
            nazad.Visible = true;
            glav_men_button.Visible = false;
            obpis_button.Visible = false;
            poisk_button.Visible = false;
            zakpis_button.Visible = false;
            Ems_button.Visible = false;
            Ban_button.Visible = false;
            M_pak_button.Visible = false;
            save_button.Visible = false;
            dobavel_button.Visible = false;
            dobv_button.Visible = false;
            del_button.Visible = false;
            naz.Visible = false;
            vper.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            filter_button.Visible = false;

            //--- find
            _tb[8].Visible = true;
            _lb[8].Visible = true;
            _lb[9].Visible = true;
            _cb[0].Visible = true;

            //-- filter
            _lb[10].Visible = false;
            _tb[9].Visible = false;
            _tb[10].Visible = false;
            _lb[11].Visible = false;
            _lb[12].Visible = false;
            _lb[13].Visible = false;
            _cb[1].Visible = false;
            _cb[2].Visible = false;

            

        }

        private void filter_button_Click(object sender, EventArgs e)
        {
            //------------ удаление кнопочек 
            for (int i = 0; i < 8; i++)
            {
                _tb[i].Visible = false;
                _lb[i].Visible = false;
            }
            nazad.Visible = true;
            glav_men_button.Visible = false;
            obpis_button.Visible = false;
            poisk_button.Visible = false;
            zakpis_button.Visible = false;
            Ems_button.Visible = false;
            Ban_button.Visible = false;
            M_pak_button.Visible = false;
            save_button.Visible = false;
            dobavel_button.Visible = false;
            dobv_button.Visible = false;
            del_button.Visible = false;
            naz.Visible = false;
            vper.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            filter_button.Visible = false;

            if (_Prov == 1 || _Prov == 2)
            {
                lb_test11.Text = "Введите индекс";
            }
            else
            {
                lb_test11.Text = "Введите вес";
            }

            //--- find
            _tb[8].Visible = false;
            _lb[8].Visible = false;
            _lb[9].Visible = false;
            _cb[0].Visible = false;

            //-- filter
            _lb[10].Visible = true;
            _tb[9].Visible = true;
            _tb[10].Visible = true;
            _lb[11].Visible = true;
            _lb[12].Visible = true;
            _lb[13].Visible = true;
            _cb[1].Visible = true;
            _cb[2].Visible = true;
        }

        private void tb_test9_TextChanged(object sender, EventArgs e)
        {
            string find = tb_test9.Text;
            _cb[0].Items.Clear();

                if (find != "" && _Prov == 1)
                {
                    for (int i = 0; i < _order._Opcount; i++)
                    {
                        if (_order._ob_pismo[i].name == find)
                        {
                            _cb[0].Items.Add(_order._ob_pismo[i].name + "| " + _order._ob_pismo[i].adress + "| " + _order._ob_pismo[i].otdelen + "| "
                                    + _order._ob_pismo[i].cost + "| " + _order._ob_pismo[i].otprav + "| " + _order._ob_pismo[i].otkuda + "| " + _order._ob_pismo[i].index);

                        }
                        else if (_order._ob_pismo[i].adress == find)
                        {
                            _cb[0].Items.Add(_order._ob_pismo[i].name + "| " + _order._ob_pismo[i].adress + "| " + _order._ob_pismo[i].otdelen + "| "
                                    + _order._ob_pismo[i].cost + "| " + _order._ob_pismo[i].otprav + "| " + _order._ob_pismo[i].otkuda + "| " + _order._ob_pismo[i].index);

                        }
                        else if (_order._ob_pismo[i].otdelen == find)
                        {
                            _cb[0].Items.Add(_order._ob_pismo[i].name + "| " + _order._ob_pismo[i].adress + "| " + _order._ob_pismo[i].otdelen + "| "
                                    + _order._ob_pismo[i].cost + "| " + _order._ob_pismo[i].otprav + "| " + _order._ob_pismo[i].otkuda + "| " + _order._ob_pismo[i].index);

                        }
                        else if (_order._ob_pismo[i].otprav == find)
                        {
                            _cb[0].Items.Add(_order._ob_pismo[i].name + "| " + _order._ob_pismo[i].adress + "| " + _order._ob_pismo[i].otdelen + "| "
                                    + _order._ob_pismo[i].cost + "| " + _order._ob_pismo[i].otprav + "| " + _order._ob_pismo[i].otkuda + "| " + _order._ob_pismo[i].index);

                        }
                        else if (_order._ob_pismo[i].otkuda == find)
                        {
                            _cb[0].Items.Add(_order._ob_pismo[i].name + "| " + _order._ob_pismo[i].adress + "| " + _order._ob_pismo[i].otdelen + "| "
                                    + _order._ob_pismo[i].cost + "| " + _order._ob_pismo[i].otprav + "| " + _order._ob_pismo[i].otkuda + "| " + _order._ob_pismo[i].index);

                        }
                        
                    }
                }
                if (find != "" && _Prov == 2)
                {
                    for (int i = 0; i < _order._Zpcount; i++)
                    {
                        if (_order._zak_pismo[i].name == find)
                        {
                            _cb[0].Items.Add(_order._zak_pismo[i].name + "| " + _order._zak_pismo[i].adress + "| " + _order._zak_pismo[i].otdelen + "| "
                                    + _order._zak_pismo[i].cost + "| " + _order._zak_pismo[i].otprav + "| " + _order._zak_pismo[i].otkuda + "| " + _order._zak_pismo[i].index);

                        }
                        else if (_order._zak_pismo[i].adress == find)
                        {
                            _cb[0].Items.Add(_order._zak_pismo[i].name + "| " + _order._zak_pismo[i].adress + "| " + _order._zak_pismo[i].otdelen + "| "
                                    + _order._zak_pismo[i].cost + "| " + _order._zak_pismo[i].otprav + "| " + _order._zak_pismo[i].otkuda + "| " + _order._zak_pismo[i].index);

                        }
                        else if (_order._zak_pismo[i].otdelen == find)
                        {
                            _cb[0].Items.Add(_order._zak_pismo[i].name + "| " + _order._zak_pismo[i].adress + "| " + _order._zak_pismo[i].otdelen + "| "
                                    + _order._zak_pismo[i].cost + "| " + _order._zak_pismo[i].otprav + "| " + _order._zak_pismo[i].otkuda + "| " + _order._zak_pismo[i].index);

                        }
                        else if (_order._zak_pismo[i].otprav == find)
                        {
                            _cb[0].Items.Add(_order._zak_pismo[i].name + "| " + _order._zak_pismo[i].adress + "| " + _order._zak_pismo[i].otdelen + "| "
                                    + _order._zak_pismo[i].cost + "| " + _order._zak_pismo[i].otprav + "| " + _order._zak_pismo[i].otkuda + "| " + _order._zak_pismo[i].index);

                        } 
                        else if (_order._zak_pismo[i].otkuda == find)
                        {
                            _cb[0].Items.Add(_order._zak_pismo[i].name + "| " + _order._zak_pismo[i].adress + "| " + _order._zak_pismo[i].otdelen + "| "
                                    + _order._zak_pismo[i].cost + "| " + _order._zak_pismo[i].otprav + "| " + _order._zak_pismo[i].otkuda + "| " + _order._zak_pismo[i].index);

                        }
                       
                    }
                }
                if (find != "" && _Prov == 3)
                {
                    for (int i = 0; i < _order._Ecount; i++)
                    {
                        if (_order._ems_pos[i].name == find)
                        {
                            _cb[0].Items.Add(_order._ems_pos[i].name + "| " + _order._ems_pos[i].adress + "| " + _order._ems_pos[i].otdelen + "| "
                                    + _order._ems_pos[i].cost + "| " + _order._ems_pos[i].otprav + "| " + _order._ems_pos[i].otkuda + "| " + _order._ems_pos[i].ves);

                        }
                        else if (_order._ems_pos[i].adress == find)
                        {
                            _cb[0].Items.Add(_order._ems_pos[i].name + "| " + _order._ems_pos[i].adress + "| " + _order._ems_pos[i].otdelen + "| "
                                    + _order._ems_pos[i].cost + "| " + _order._ems_pos[i].otprav + "| " + _order._ems_pos[i].otkuda + "| " + _order._ems_pos[i].ves);

                        }
                        else if (_order._ems_pos[i].otdelen == find)
                        {
                            _cb[0].Items.Add(_order._ems_pos[i].name + "| " + _order._ems_pos[i].adress + "| " + _order._ems_pos[i].otdelen + "| "
                                    + _order._ems_pos[i].cost + "| " + _order._ems_pos[i].otprav + "| " + _order._ems_pos[i].otkuda + "| " + _order._ems_pos[i].ves);

                        }
                        else if (_order._ems_pos[i].otprav == find)
                        {
                            _cb[0].Items.Add(_order._ems_pos[i].name + "| " + _order._ems_pos[i].adress + "| " + _order._ems_pos[i].otdelen + "| "
                                    + _order._ems_pos[i].cost + "| " + _order._ems_pos[i].otprav + "| " + _order._ems_pos[i].otkuda + "| " + _order._ems_pos[i].ves);

                        }
                        else if (_order._ems_pos[i].otkuda == find)
                        {
                            _cb[0].Items.Add(_order._ems_pos[i].name + "| " + _order._ems_pos[i].adress + "| " + _order._ems_pos[i].otdelen + "| "
                                    + _order._ems_pos[i].cost + "| " + _order._ems_pos[i].otprav + "| " + _order._ems_pos[i].otkuda + "| " + _order._ems_pos[i].ves);

                        }
                        
                    }
                }
                if (find != "" && _Prov == 4)
                {
                    for (int i = 0; i < _order._Pcount; i++)
                    {
                        if (_order._p_pos[i].name == find)
                        {
                            _cb[0].Items.Add(_order._p_pos[i].name + "| " + _order._p_pos[i].adress + "| " + _order._p_pos[i].otdelen + "| "
                                    + _order._p_pos[i].cost + "| " + _order._p_pos[i].otprav + "| " + _order._p_pos[i].otkuda + "| " + _order._p_pos[i].ves);

                        }
                        else if (_order._p_pos[i].adress == find)
                        {
                            _cb[0].Items.Add(_order._p_pos[i].name + "| " + _order._p_pos[i].adress + "| " + _order._p_pos[i].otdelen + "| "
                                    + _order._p_pos[i].cost + "| " + _order._p_pos[i].otprav + "| " + _order._p_pos[i].otkuda + "| " + _order._p_pos[i].ves);

                        }
                        else if (_order._p_pos[i].otdelen == find)
                        {
                            _cb[0].Items.Add(_order._p_pos[i].name + "| " + _order._p_pos[i].adress + "| " + _order._p_pos[i].otdelen + "| "
                                    + _order._p_pos[i].cost + "| " + _order._p_pos[i].otprav + "| " + _order._p_pos[i].otkuda + "| " + _order._p_pos[i].ves);

                        }
                        else if (_order._p_pos[i].otprav == find)
                        {
                            _cb[0].Items.Add(_order._p_pos[i].name + "| " + _order._p_pos[i].adress + "| " + _order._p_pos[i].otdelen + "| "
                                    + _order._p_pos[i].cost + "| " + _order._p_pos[i].otprav + "| " + _order._p_pos[i].otkuda + "| " + _order._p_pos[i].ves);

                        }
                        else if (_order._p_pos[i].otkuda == find)
                        {
                            _cb[0].Items.Add(_order._p_pos[i].name + "| " + _order._p_pos[i].adress + "| " + _order._p_pos[i].otdelen + "| "
                                    + _order._p_pos[i].cost + "| " + _order._p_pos[i].otprav + "| " + _order._p_pos[i].otkuda + "| " + _order._p_pos[i].ves);

                        }
                      

                    }
                }
                if (find != "" && _Prov == 5)
                {
                    for (int i = 0; i < _order._Bcount; i++)
                    {
                        if (_order._ban_pos[i].name == find)
                        {
                            _cb[0].Items.Add(_order._ban_pos[i].name + "| " + _order._ban_pos[i].adress + "| " + _order._ban_pos[i].otdelen + "| "
                                + _order._ban_pos[i].cost + "| " + _order._ban_pos[i].otprav + "| " + _order._ban_pos[i].otkuda + "| " + _order._ban_pos[i].ves);

                        }
                        else if (_order._ban_pos[i].adress == find)
                        {
                            _cb[0].Items.Add(_order._ban_pos[i].name + "| " + _order._ban_pos[i].adress + "| " + _order._ban_pos[i].otdelen + "| "
                                + _order._ban_pos[i].cost + "| " + _order._ban_pos[i].otprav + "| " + _order._ban_pos[i].otkuda + "| " + _order._ban_pos[i].ves);

                        }
                        else if (_order._ban_pos[i].otdelen == find)
                        {
                            _cb[0].Items.Add(_order._ban_pos[i].name + "| " + _order._ban_pos[i].adress + "| " + _order._ban_pos[i].otdelen + "| "
                                + _order._ban_pos[i].cost + "| " + _order._ban_pos[i].otprav + "| " + _order._ban_pos[i].otkuda + "| " + _order._ban_pos[i].ves);

                        }
                        
                        else if (_order._ban_pos[i].otprav == find)
                        {
                            _cb[0].Items.Add(_order._ban_pos[i].name + "| " + _order._ban_pos[i].adress + "| " + _order._ban_pos[i].otdelen + "| "
                                + _order._ban_pos[i].cost + "| " + _order._ban_pos[i].otprav + "| " + _order._ban_pos[i].otkuda + "| " + _order._ban_pos[i].ves);

                        }
                        else if (_order._ban_pos[i].otkuda == find)
                        {
                            _cb[0].Items.Add(_order._ban_pos[i].name + "| " + _order._ban_pos[i].adress + "| " + _order._ban_pos[i].otdelen + "| "
                                + _order._ban_pos[i].cost + "| " + _order._ban_pos[i].otprav + "| " + _order._ban_pos[i].otkuda + "| " + _order._ban_pos[i].ves);

                        }
                        

                    }
                }
            
           
            
        }

        private void tb_test10_TextChanged(object sender, EventArgs e)
        {
            string filter = tb_test10.Text;
            _cb[1].Items.Clear();

            
            if (filter != "" && _Prov == 1)
            {
                for (int i = 0; i < _order._Opcount; i++)
                {
                    if (_order._ob_pismo[i].index >= int.Parse(filter))
                    {
                        _cb[1].Items.Add(_order._ob_pismo[i].name + "| " + _order._ob_pismo[i].adress + "| " + _order._ob_pismo[i].otdelen + "| "
                                + _order._ob_pismo[i].cost + "| " + _order._ob_pismo[i].otprav + "| " + _order._ob_pismo[i].otkuda + "| " + _order._ob_pismo[i].index);

                    }
                }
                
            }
            if (filter != "" && _Prov == 2)
            {
                for (int i = 0; i < _order._Zpcount; i++)
                {
                    if (_order._zak_pismo[i].index >= int.Parse(filter))
                    {
                        _cb[1].Items.Add(_order._zak_pismo[i].name + "| " + _order._zak_pismo[i].adress + "| " 
                                        + _order._zak_pismo[i].otdelen + "| "+ _order._zak_pismo[i].cost + "| " 
                                        + _order._zak_pismo[i].otprav + "| " + _order._zak_pismo[i].otkuda + "| "
                                        + _order._zak_pismo[i].index);

                    }
                }

            }
            if (filter != "" && _Prov == 3)
            {
                for (int i = 0; i < _order._Ecount; i++)
                {
                    if (_order._ems_pos[i].ves >= int.Parse(filter))
                    {
                        _cb[1].Items.Add(_order._ems_pos[i].name + "| " + _order._ems_pos[i].adress + "| "
                                        + _order._ems_pos[i].otdelen + "| " + _order._ems_pos[i].cost + "| "
                                        + _order._ems_pos[i].otprav + "| " + _order._ems_pos[i].otkuda + "| "
                                        + _order._ems_pos[i].ves);

                    }
                }

            }
            if (filter != "" && _Prov == 4)
            {
                for (int i = 0; i < _order._Pcount; i++)
                {
                    if (_order._p_pos[i].ves >= int.Parse(filter))
                    {
                        _cb[1].Items.Add(_order._p_pos[i].name + "| " + _order._p_pos[i].adress + "| "
                                        + _order._p_pos[i].otdelen + "| " + _order._p_pos[i].cost + "| "
                                        + _order._p_pos[i].otprav + "| " + _order._p_pos[i].otkuda + "| "
                                        + _order._p_pos[i].ves);

                    }
                }

            }
            if (filter != "" && _Prov == 5)
            {
                for (int i = 0; i < _order._Bcount; i++)
                {
                    if (_order._ban_pos[i].ves >= int.Parse(filter))
                    {
                        _cb[1].Items.Add(_order._ban_pos[i].name + "| " + _order._ban_pos[i].adress + "| "
                                        + _order._ban_pos[i].otdelen + "| " + _order._ban_pos[i].cost + "| "
                                        + _order._ban_pos[i].otprav + "| " + _order._ban_pos[i].otkuda + "| "
                                        + _order._ban_pos[i].ves);

                    }
                }

            }
        }

        private void tb_test11_TextChanged(object sender, EventArgs e)
        {
            string filter = tb_test11.Text;
            _cb[2].Items.Clear();


            if (filter != "" && _Prov == 1)
            {
                for (int i = 0; i < _order._Opcount; i++)
                {
                    if (_order._ob_pismo[i].cost >= int.Parse(filter))
                    {
                        _cb[2].Items.Add(_order._ob_pismo[i].name + "| " + _order._ob_pismo[i].adress + "| " + _order._ob_pismo[i].otdelen + "| "
                                + _order._ob_pismo[i].cost + "| " + _order._ob_pismo[i].otprav + "| " + _order._ob_pismo[i].otkuda + "| " + _order._ob_pismo[i].index);

                    }
                }

            }
            if (filter != "" && _Prov == 2)
            {
                for (int i = 0; i < _order._Zpcount; i++)
                {
                    if (_order._zak_pismo[i].cost >= int.Parse(filter))
                    {
                        _cb[2].Items.Add(_order._zak_pismo[i].name + "| " + _order._zak_pismo[i].adress + "| "
                                        + _order._zak_pismo[i].otdelen + "| " + _order._zak_pismo[i].cost + "| "
                                        + _order._zak_pismo[i].otprav + "| " + _order._zak_pismo[i].otkuda + "| "
                                        + _order._zak_pismo[i].index);

                    }
                }

            }
            if (filter != "" && _Prov == 3)
            {
                for (int i = 0; i < _order._Ecount; i++)
                {
                    if (_order._ems_pos[i].cost >= int.Parse(filter))
                    {
                        _cb[2].Items.Add(_order._ems_pos[i].name + "| " + _order._ems_pos[i].adress + "| "
                                        + _order._ems_pos[i].otdelen + "| " + _order._ems_pos[i].cost + "| "
                                        + _order._ems_pos[i].otprav + "| " + _order._ems_pos[i].otkuda + "| "
                                        + _order._ems_pos[i].ves);

                    }
                }

            }
            if (filter != "" && _Prov == 4)
            {
                for (int i = 0; i < _order._Pcount; i++)
                {
                    if (_order._p_pos[i].cost >= int.Parse(filter))
                    {
                        _cb[2].Items.Add(_order._p_pos[i].name + "| " + _order._p_pos[i].adress + "| "
                                        + _order._p_pos[i].otdelen + "| " + _order._p_pos[i].cost + "| "
                                        + _order._p_pos[i].otprav + "| " + _order._p_pos[i].otkuda + "| "
                                        + _order._p_pos[i].ves);

                    }
                }

            }
            if (filter != "" && _Prov == 5)
            {
                for (int i = 0; i < _order._Bcount; i++)
                {
                    if (_order._ban_pos[i].cost >= int.Parse(filter))
                    {
                        _cb[2].Items.Add(_order._ban_pos[i].name + "| " + _order._ban_pos[i].adress + "| "
                                        + _order._ban_pos[i].otdelen + "| " + _order._ban_pos[i].cost + "| "
                                        + _order._ban_pos[i].otprav + "| " + _order._ban_pos[i].otkuda + "| "
                                        + _order._ban_pos[i].ves);

                    }
                }

            }
        }

        private void tb_test_TextChanged(object sender, EventArgs e)
        {
            String[] a = new String[54] { "q","w","e","r","t","y","u","i","o","p","a","s","d","f","g","h","j","k","l","z","x","c","v","b","n","m",
                                          "Q","W","E","R","T","Y","U","I","O","P","A","S","D","F","G","H","J","K","L","Z","X","C","V","B","N","M",
                                          " ","-" };
            string textbox_content = tb_test.Text.Trim();
            bool isnotcorrect = false;
            string textbox_newcontent = "";
            foreach (char symbol in textbox_content.Trim())
            {
                if (symbol != Convert.ToChar(a[0]) && symbol != Convert.ToChar(a[1]) &&
                    symbol != Convert.ToChar(a[2]) && symbol != Convert.ToChar(a[3]) &&
                    symbol != Convert.ToChar(a[4]) && symbol != Convert.ToChar(a[5]) &&
                    symbol != Convert.ToChar(a[6]) && symbol != Convert.ToChar(a[7]) &&
                    symbol != Convert.ToChar(a[8]) && symbol != Convert.ToChar(a[9]) &&
                    symbol != Convert.ToChar(a[10])&& symbol != Convert.ToChar(a[11]) &&
                    symbol != Convert.ToChar(a[12]) && symbol != Convert.ToChar(a[13]) &&
                    symbol != Convert.ToChar(a[14]) && symbol != Convert.ToChar(a[15]) &&
                    symbol != Convert.ToChar(a[16]) && symbol != Convert.ToChar(a[17]) &&
                    symbol != Convert.ToChar(a[18]) && symbol != Convert.ToChar(a[19]) &&
                    symbol != Convert.ToChar(a[20]) && symbol != Convert.ToChar(a[21]) &&
                    symbol != Convert.ToChar(a[22]) && symbol != Convert.ToChar(a[23]) &&
                    symbol != Convert.ToChar(a[24]) && symbol != Convert.ToChar(a[25]) &&
                    symbol != Convert.ToChar(a[26]) && symbol != Convert.ToChar(a[27]) &&
                    symbol != Convert.ToChar(a[28]) && symbol != Convert.ToChar(a[29]) &&
                    symbol != Convert.ToChar(a[30]) && symbol != Convert.ToChar(a[31]) &&
                    symbol != Convert.ToChar(a[32]) && symbol != Convert.ToChar(a[33]) &&
                    symbol != Convert.ToChar(a[34]) && symbol != Convert.ToChar(a[35]) &&
                    symbol != Convert.ToChar(a[36]) && symbol != Convert.ToChar(a[37]) &&
                    symbol != Convert.ToChar(a[38]) && symbol != Convert.ToChar(a[39]) &&
                    symbol != Convert.ToChar(a[40]) && symbol != Convert.ToChar(a[41]) &&
                    symbol != Convert.ToChar(a[42]) && symbol != Convert.ToChar(a[43]) &&
                    symbol != Convert.ToChar(a[44]) && symbol != Convert.ToChar(a[45]) &&
                    symbol != Convert.ToChar(a[46]) && symbol != Convert.ToChar(a[47]) &&
                    symbol != Convert.ToChar(a[48]) && symbol != Convert.ToChar(a[49]) &&
                    symbol != Convert.ToChar(a[50]) && symbol != Convert.ToChar(a[51]) &&
                    symbol != Convert.ToChar(a[52]) && symbol != Convert.ToChar(a[53]))
                {
                    isnotcorrect = true;
                }
            }
            /*if (isnotcorrect)
            {
                System.Windows.Forms.MessageBox.Show("Недопустимый формат ввода! Необходимо вводить только буквы.");
            } */
            if (isnotcorrect)
            {
                int step = 0;
                int count = textbox_content.Length - 1;
                textbox_newcontent = "";
                System.Windows.Forms.MessageBox.Show("Недопустимый формат ввода в поле Ф.И.О. получателя");
                foreach (char s in textbox_content)
                {
                        if (step >= count)
                        {
                            break;
                        }
                        else
                        {
                            textbox_newcontent += s;
                        }
                        step++;
                }
                tb_test.Text = textbox_newcontent;
                tb_test.SelectionStart = tb_test.Text.Length;
              } 
                
        }

        private void tb_test2_TextChanged(object sender, EventArgs e)
        {
            String[] a = new String[67] { "q","w","e","r","t","y","u","i","o","p","a","s","d","f","g","h","j","k","l","z","x","c","v","b","n","m",
                                          "Q","W","E","R","T","Y","U","I","O","P","A","S","D","F","G","H","J","K","L","Z","X","C","V","B","N","M",
                                          " ","-",".","/",",","0", "1", "2", "3", "4", "5", "6", "7", "8", "9"};
            string textbox_content = tb_test2.Text.Trim();
            bool isnotcorrect = false;
            string textbox_newcontent = "";
            foreach (char symbol in textbox_content.Trim())
            {
                if (symbol != Convert.ToChar(a[0]) && symbol != Convert.ToChar(a[1]) &&
                    symbol != Convert.ToChar(a[2]) && symbol != Convert.ToChar(a[3]) &&
                    symbol != Convert.ToChar(a[4]) && symbol != Convert.ToChar(a[5]) &&
                    symbol != Convert.ToChar(a[6]) && symbol != Convert.ToChar(a[7]) &&
                    symbol != Convert.ToChar(a[8]) && symbol != Convert.ToChar(a[9]) &&
                    symbol != Convert.ToChar(a[10]) && symbol != Convert.ToChar(a[11]) &&
                    symbol != Convert.ToChar(a[12]) && symbol != Convert.ToChar(a[13]) &&
                    symbol != Convert.ToChar(a[14]) && symbol != Convert.ToChar(a[15]) &&
                    symbol != Convert.ToChar(a[16]) && symbol != Convert.ToChar(a[17]) &&
                    symbol != Convert.ToChar(a[18]) && symbol != Convert.ToChar(a[19]) &&
                    symbol != Convert.ToChar(a[20]) && symbol != Convert.ToChar(a[21]) &&
                    symbol != Convert.ToChar(a[22]) && symbol != Convert.ToChar(a[23]) &&
                    symbol != Convert.ToChar(a[24]) && symbol != Convert.ToChar(a[25]) &&
                    symbol != Convert.ToChar(a[26]) && symbol != Convert.ToChar(a[27]) &&
                    symbol != Convert.ToChar(a[28]) && symbol != Convert.ToChar(a[29]) &&
                    symbol != Convert.ToChar(a[30]) && symbol != Convert.ToChar(a[31]) &&
                    symbol != Convert.ToChar(a[32]) && symbol != Convert.ToChar(a[33]) &&
                    symbol != Convert.ToChar(a[34]) && symbol != Convert.ToChar(a[35]) &&
                    symbol != Convert.ToChar(a[36]) && symbol != Convert.ToChar(a[37]) &&
                    symbol != Convert.ToChar(a[38]) && symbol != Convert.ToChar(a[39]) &&
                    symbol != Convert.ToChar(a[40]) && symbol != Convert.ToChar(a[41]) &&
                    symbol != Convert.ToChar(a[42]) && symbol != Convert.ToChar(a[43]) &&
                    symbol != Convert.ToChar(a[44]) && symbol != Convert.ToChar(a[45]) &&
                    symbol != Convert.ToChar(a[46]) && symbol != Convert.ToChar(a[47]) &&
                    symbol != Convert.ToChar(a[48]) && symbol != Convert.ToChar(a[49]) &&
                    symbol != Convert.ToChar(a[50]) && symbol != Convert.ToChar(a[51]) &&
                    symbol != Convert.ToChar(a[52]) && symbol != Convert.ToChar(a[53]) &&
                    symbol != Convert.ToChar(a[54]) && symbol != Convert.ToChar(a[55]) &&
                    symbol != Convert.ToChar(a[56]) && symbol != Convert.ToChar(a[57]) &&
                    symbol != Convert.ToChar(a[58]) && symbol != Convert.ToChar(a[59]) &&
                    symbol != Convert.ToChar(a[60]) && symbol != Convert.ToChar(a[61]) &&
                    symbol != Convert.ToChar(a[62]) && symbol != Convert.ToChar(a[63]) &&
                    symbol != Convert.ToChar(a[64]) && symbol != Convert.ToChar(a[65]) &&
                    symbol != Convert.ToChar(a[66]))
                {
                    isnotcorrect = true;
                }
            }
            /*if (isnotcorrect)
            {
                System.Windows.Forms.MessageBox.Show("Недопустимый формат ввода! Необходимо вводить только буквы.");
            } */
            if (isnotcorrect)
            {
                int step = 0;
                int count = textbox_content.Length - 1;
                textbox_newcontent = "";
                System.Windows.Forms.MessageBox.Show("Недопустимый формат ввода в поле Адрес");
                foreach (char s in textbox_content)
                {
                    if (step >= count)
                    {
                        break;
                    }
                    else
                    {
                        textbox_newcontent += s;
                    }
                    step++;
                }
                tb_test2.Text = textbox_newcontent;
                tb_test2.SelectionStart = tb_test2.Text.Length;
            } 
        }

        private void tb_test3_TextChanged(object sender, EventArgs e)
        {
            String[] a = new String[67] { "q","w","e","r","t","y","u","i","o","p","a","s","d","f","g","h","j","k","l","z","x","c","v","b","n","m",
                                          "Q","W","E","R","T","Y","U","I","O","P","A","S","D","F","G","H","J","K","L","Z","X","C","V","B","N","M",
                                          " ","-",".","/",",","0", "1", "2", "3", "4", "5", "6", "7", "8", "9"};
            string textbox_content = tb_test2.Text.Trim();
            bool isnotcorrect = false;
            string textbox_newcontent = "";
            foreach (char symbol in textbox_content.Trim())
            {
                if (symbol != Convert.ToChar(a[0]) && symbol != Convert.ToChar(a[1]) &&
                    symbol != Convert.ToChar(a[2]) && symbol != Convert.ToChar(a[3]) &&
                    symbol != Convert.ToChar(a[4]) && symbol != Convert.ToChar(a[5]) &&
                    symbol != Convert.ToChar(a[6]) && symbol != Convert.ToChar(a[7]) &&
                    symbol != Convert.ToChar(a[8]) && symbol != Convert.ToChar(a[9]) &&
                    symbol != Convert.ToChar(a[10]) && symbol != Convert.ToChar(a[11]) &&
                    symbol != Convert.ToChar(a[12]) && symbol != Convert.ToChar(a[13]) &&
                    symbol != Convert.ToChar(a[14]) && symbol != Convert.ToChar(a[15]) &&
                    symbol != Convert.ToChar(a[16]) && symbol != Convert.ToChar(a[17]) &&
                    symbol != Convert.ToChar(a[18]) && symbol != Convert.ToChar(a[19]) &&
                    symbol != Convert.ToChar(a[20]) && symbol != Convert.ToChar(a[21]) &&
                    symbol != Convert.ToChar(a[22]) && symbol != Convert.ToChar(a[23]) &&
                    symbol != Convert.ToChar(a[24]) && symbol != Convert.ToChar(a[25]) &&
                    symbol != Convert.ToChar(a[26]) && symbol != Convert.ToChar(a[27]) &&
                    symbol != Convert.ToChar(a[28]) && symbol != Convert.ToChar(a[29]) &&
                    symbol != Convert.ToChar(a[30]) && symbol != Convert.ToChar(a[31]) &&
                    symbol != Convert.ToChar(a[32]) && symbol != Convert.ToChar(a[33]) &&
                    symbol != Convert.ToChar(a[34]) && symbol != Convert.ToChar(a[35]) &&
                    symbol != Convert.ToChar(a[36]) && symbol != Convert.ToChar(a[37]) &&
                    symbol != Convert.ToChar(a[38]) && symbol != Convert.ToChar(a[39]) &&
                    symbol != Convert.ToChar(a[40]) && symbol != Convert.ToChar(a[41]) &&
                    symbol != Convert.ToChar(a[42]) && symbol != Convert.ToChar(a[43]) &&
                    symbol != Convert.ToChar(a[44]) && symbol != Convert.ToChar(a[45]) &&
                    symbol != Convert.ToChar(a[46]) && symbol != Convert.ToChar(a[47]) &&
                    symbol != Convert.ToChar(a[48]) && symbol != Convert.ToChar(a[49]) &&
                    symbol != Convert.ToChar(a[50]) && symbol != Convert.ToChar(a[51]) &&
                    symbol != Convert.ToChar(a[52]) && symbol != Convert.ToChar(a[53]) &&
                    symbol != Convert.ToChar(a[54]) && symbol != Convert.ToChar(a[55]) &&
                    symbol != Convert.ToChar(a[56]) && symbol != Convert.ToChar(a[57]) &&
                    symbol != Convert.ToChar(a[58]) && symbol != Convert.ToChar(a[59]) &&
                    symbol != Convert.ToChar(a[60]) && symbol != Convert.ToChar(a[61]) &&
                    symbol != Convert.ToChar(a[62]) && symbol != Convert.ToChar(a[63]) &&
                    symbol != Convert.ToChar(a[64]) && symbol != Convert.ToChar(a[65]) &&
                    symbol != Convert.ToChar(a[66]))
                {
                    isnotcorrect = true;
                }
            }
            /*if (isnotcorrect)
            {
                System.Windows.Forms.MessageBox.Show("Недопустимый формат ввода! Необходимо вводить только буквы.");
            } */
            if (isnotcorrect)
            {
                int step = 0;
                int count = textbox_content.Length - 1;
                textbox_newcontent = "";
                System.Windows.Forms.MessageBox.Show("Недопустимый формат ввода в поле Отделение Почты");
                foreach (char s in textbox_content)
                {
                    if (step >= count)
                    {
                        break;
                    }
                    else
                    {
                        textbox_newcontent += s;
                    }
                    step++;
                }
                tb_test2.Text = textbox_newcontent;
                tb_test2.SelectionStart = tb_test2.Text.Length;
            } 
        }

        private void tb_test4_TextChanged(object sender, EventArgs e)
        {
            String[] a = new String[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string textbox_content = tb_test4.Text.Trim();
            bool isnotcorrect = false;
            string textbox_newcontent = "";

            foreach (char symbol in textbox_content.Trim())
            {
                if (symbol != Convert.ToChar(a[0]) && symbol != Convert.ToChar(a[1]) &&
                    symbol != Convert.ToChar(a[2]) && symbol != Convert.ToChar(a[3]) &&
                    symbol != Convert.ToChar(a[4]) && symbol != Convert.ToChar(a[5]) &&
                    symbol != Convert.ToChar(a[6]) && symbol != Convert.ToChar(a[7]) &&
                    symbol != Convert.ToChar(a[8]) && symbol != Convert.ToChar(a[9]))
                {
                    isnotcorrect = true; 
                } 
            }
            if (isnotcorrect)
            {
                int step = 0;
                int count = textbox_content.Length - 1;
                System.Windows.Forms.MessageBox.Show("Недопустимый формат ввода в поле Стоимость");
                textbox_newcontent = "";
                foreach (char s in textbox_content)
                {
                    if (step >= count)
                    {
                        break;
                    }
                    else
                    {
                        textbox_newcontent += s;
                    }
                    step++;
                }
                tb_test4.Text = textbox_newcontent;
                tb_test4.SelectionStart = tb_test4.Text.Length;
            } 
            
        }

        private void tb_test5_TextChanged(object sender, EventArgs e)
        {
            String[] a = new String[57] { "q","w","e","r","t","y","u","i","o","p","a","s","d","f","g","h","j","k","l","z","x","c","v","b","n","m",
                                          "Q","W","E","R","T","Y","U","I","O","P","A","S","D","F","G","H","J","K","L","Z","X","C","V","B","N","M",
                                          " ","-",".","/",","};
            string textbox_content = tb_test5.Text.Trim();
            bool isnotcorrect = false;
            string textbox_newcontent = "";
            foreach (char symbol in textbox_content.Trim())
            {
                if (symbol != Convert.ToChar(a[0]) && symbol != Convert.ToChar(a[1]) &&
                    symbol != Convert.ToChar(a[2]) && symbol != Convert.ToChar(a[3]) &&
                    symbol != Convert.ToChar(a[4]) && symbol != Convert.ToChar(a[5]) &&
                    symbol != Convert.ToChar(a[6]) && symbol != Convert.ToChar(a[7]) &&
                    symbol != Convert.ToChar(a[8]) && symbol != Convert.ToChar(a[9]) &&
                    symbol != Convert.ToChar(a[10]) && symbol != Convert.ToChar(a[11]) &&
                    symbol != Convert.ToChar(a[12]) && symbol != Convert.ToChar(a[13]) &&
                    symbol != Convert.ToChar(a[14]) && symbol != Convert.ToChar(a[15]) &&
                    symbol != Convert.ToChar(a[16]) && symbol != Convert.ToChar(a[17]) &&
                    symbol != Convert.ToChar(a[18]) && symbol != Convert.ToChar(a[19]) &&
                    symbol != Convert.ToChar(a[20]) && symbol != Convert.ToChar(a[21]) &&
                    symbol != Convert.ToChar(a[22]) && symbol != Convert.ToChar(a[23]) &&
                    symbol != Convert.ToChar(a[24]) && symbol != Convert.ToChar(a[25]) &&
                    symbol != Convert.ToChar(a[26]) && symbol != Convert.ToChar(a[27]) &&
                    symbol != Convert.ToChar(a[28]) && symbol != Convert.ToChar(a[29]) &&
                    symbol != Convert.ToChar(a[30]) && symbol != Convert.ToChar(a[31]) &&
                    symbol != Convert.ToChar(a[32]) && symbol != Convert.ToChar(a[33]) &&
                    symbol != Convert.ToChar(a[34]) && symbol != Convert.ToChar(a[35]) &&
                    symbol != Convert.ToChar(a[36]) && symbol != Convert.ToChar(a[37]) &&
                    symbol != Convert.ToChar(a[38]) && symbol != Convert.ToChar(a[39]) &&
                    symbol != Convert.ToChar(a[40]) && symbol != Convert.ToChar(a[41]) &&
                    symbol != Convert.ToChar(a[42]) && symbol != Convert.ToChar(a[43]) &&
                    symbol != Convert.ToChar(a[44]) && symbol != Convert.ToChar(a[45]) &&
                    symbol != Convert.ToChar(a[46]) && symbol != Convert.ToChar(a[47]) &&
                    symbol != Convert.ToChar(a[48]) && symbol != Convert.ToChar(a[49]) &&
                    symbol != Convert.ToChar(a[50]) && symbol != Convert.ToChar(a[51]) &&
                    symbol != Convert.ToChar(a[52]) && symbol != Convert.ToChar(a[53]) &&
                    symbol != Convert.ToChar(a[54]) && symbol != Convert.ToChar(a[55]) &&
                    symbol != Convert.ToChar(a[56]))
                {
                    isnotcorrect = true;
                }
            }
            if (isnotcorrect)
            {
                int step = 0;
                int count = textbox_content.Length - 1;
                textbox_newcontent = "";
                System.Windows.Forms.MessageBox.Show("Недопустимый формат ввода в поле Отправитель");
                foreach (char s in textbox_content)
                {
                    if (step >= count)
                    {
                        break;
                    }
                    else
                    {
                        textbox_newcontent += s;
                    }
                    step++;
                }
                tb_test5.Text = textbox_newcontent;
                tb_test5.SelectionStart = tb_test5.Text.Length;
            } 
        }

        private void tb_test6_TextChanged(object sender, EventArgs e)
        {
            String[] a = new String[54] { "q","w","e","r","t","y","u","i","o","p","a","s","d","f","g","h","j","k","l","z","x","c","v","b","n","m",
                                          "Q","W","E","R","T","Y","U","I","O","P","A","S","D","F","G","H","J","K","L","Z","X","C","V","B","N","M",
                                          " ","-" };
            string textbox_content = tb_test6.Text.Trim();
            bool isnotcorrect = false;
            string textbox_newcontent = "";
            foreach (char symbol in textbox_content.Trim())
            {
                if (symbol != Convert.ToChar(a[0]) && symbol != Convert.ToChar(a[1]) &&
                    symbol != Convert.ToChar(a[2]) && symbol != Convert.ToChar(a[3]) &&
                    symbol != Convert.ToChar(a[4]) && symbol != Convert.ToChar(a[5]) &&
                    symbol != Convert.ToChar(a[6]) && symbol != Convert.ToChar(a[7]) &&
                    symbol != Convert.ToChar(a[8]) && symbol != Convert.ToChar(a[9]) &&
                    symbol != Convert.ToChar(a[10]) && symbol != Convert.ToChar(a[11]) &&
                    symbol != Convert.ToChar(a[12]) && symbol != Convert.ToChar(a[13]) &&
                    symbol != Convert.ToChar(a[14]) && symbol != Convert.ToChar(a[15]) &&
                    symbol != Convert.ToChar(a[16]) && symbol != Convert.ToChar(a[17]) &&
                    symbol != Convert.ToChar(a[18]) && symbol != Convert.ToChar(a[19]) &&
                    symbol != Convert.ToChar(a[20]) && symbol != Convert.ToChar(a[21]) &&
                    symbol != Convert.ToChar(a[22]) && symbol != Convert.ToChar(a[23]) &&
                    symbol != Convert.ToChar(a[24]) && symbol != Convert.ToChar(a[25]) &&
                    symbol != Convert.ToChar(a[26]) && symbol != Convert.ToChar(a[27]) &&
                    symbol != Convert.ToChar(a[28]) && symbol != Convert.ToChar(a[29]) &&
                    symbol != Convert.ToChar(a[30]) && symbol != Convert.ToChar(a[31]) &&
                    symbol != Convert.ToChar(a[32]) && symbol != Convert.ToChar(a[33]) &&
                    symbol != Convert.ToChar(a[34]) && symbol != Convert.ToChar(a[35]) &&
                    symbol != Convert.ToChar(a[36]) && symbol != Convert.ToChar(a[37]) &&
                    symbol != Convert.ToChar(a[38]) && symbol != Convert.ToChar(a[39]) &&
                    symbol != Convert.ToChar(a[40]) && symbol != Convert.ToChar(a[41]) &&
                    symbol != Convert.ToChar(a[42]) && symbol != Convert.ToChar(a[43]) &&
                    symbol != Convert.ToChar(a[44]) && symbol != Convert.ToChar(a[45]) &&
                    symbol != Convert.ToChar(a[46]) && symbol != Convert.ToChar(a[47]) &&
                    symbol != Convert.ToChar(a[48]) && symbol != Convert.ToChar(a[49]) &&
                    symbol != Convert.ToChar(a[50]) && symbol != Convert.ToChar(a[51]) &&
                    symbol != Convert.ToChar(a[52]) && symbol != Convert.ToChar(a[53]))
                {
                    isnotcorrect = true;
                }
            }
            /*if (isnotcorrect)
            {
                System.Windows.Forms.MessageBox.Show("Недопустимый формат ввода! Необходимо вводить только буквы.");
            } */
            if (isnotcorrect)
            {
                int step = 0;
                int count = textbox_content.Length - 1;
                textbox_newcontent = "";
                System.Windows.Forms.MessageBox.Show("Недопустимый формат ввода в поле Откуда отправлено");
                foreach (char s in textbox_content)
                {
                    if (step >= count)
                    {
                        break;
                    }
                    else
                    {
                        textbox_newcontent += s;
                    }
                    step++;
                }
                tb_test6.Text = textbox_newcontent;
                tb_test6.SelectionStart = tb_test6.Text.Length;
            } 
        }

        private void tb_test7_TextChanged(object sender, EventArgs e)
        {
            String[] a = new String[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string textbox_content = tb_test7.Text.Trim();
            bool isnotcorrect = false;
            string textbox_newcontent = "";

            foreach (char symbol in textbox_content.Trim())
            {
                if (symbol != Convert.ToChar(a[0]) && symbol != Convert.ToChar(a[1]) &&
                    symbol != Convert.ToChar(a[2]) && symbol != Convert.ToChar(a[3]) &&
                    symbol != Convert.ToChar(a[4]) && symbol != Convert.ToChar(a[5]) &&
                    symbol != Convert.ToChar(a[6]) && symbol != Convert.ToChar(a[7]) &&
                    symbol != Convert.ToChar(a[8]) && symbol != Convert.ToChar(a[9]))
                {
                    isnotcorrect = true;
                }
            }
            if (isnotcorrect)
            {
                int step = 0;
                int count = textbox_content.Length - 1;
                System.Windows.Forms.MessageBox.Show("Недопустимый формат ввода в поле Вес");
                textbox_newcontent = "";
                foreach (char s in textbox_content)
                {
                    if (step >= count)
                    {
                        break;
                    }
                    else
                    {
                        textbox_newcontent += s;
                    }
                    step++;
                }
                tb_test7.Text = textbox_newcontent;
                tb_test7.SelectionStart = tb_test7.Text.Length;
            } 
        }

        private void tb_test8_TextChanged(object sender, EventArgs e)
        {
            String[] a = new String[36] { "1","2","3","4","5","6","7","8","9","0",
                                          "Q","W","E","R","T","Y","U","I","O","P",
                                          "A","S","D","F","G","H","J","K","L","Z",
                                          "X","C","V","B","N","M"
                                    };
            string textbox_content = tb_test8.Text.Trim();
            bool isnotcorrect = false;
            string textbox_newcontent = "";
            foreach (char symbol in textbox_content.Trim())
            {
                if (symbol != Convert.ToChar(a[0]) && symbol != Convert.ToChar(a[1]) &&
                    symbol != Convert.ToChar(a[2]) && symbol != Convert.ToChar(a[3]) &&
                    symbol != Convert.ToChar(a[4]) && symbol != Convert.ToChar(a[5]) &&
                    symbol != Convert.ToChar(a[6]) && symbol != Convert.ToChar(a[7]) &&
                    symbol != Convert.ToChar(a[8]) && symbol != Convert.ToChar(a[9]) &&
                    symbol != Convert.ToChar(a[10]) && symbol != Convert.ToChar(a[11]) &&
                    symbol != Convert.ToChar(a[12]) && symbol != Convert.ToChar(a[13]) &&
                    symbol != Convert.ToChar(a[14]) && symbol != Convert.ToChar(a[15]) &&
                    symbol != Convert.ToChar(a[16]) && symbol != Convert.ToChar(a[17]) &&
                    symbol != Convert.ToChar(a[18]) && symbol != Convert.ToChar(a[19]) &&
                    symbol != Convert.ToChar(a[20]) && symbol != Convert.ToChar(a[21]) &&
                    symbol != Convert.ToChar(a[22]) && symbol != Convert.ToChar(a[23]) &&
                    symbol != Convert.ToChar(a[24]) && symbol != Convert.ToChar(a[25]) &&
                    symbol != Convert.ToChar(a[26]) && symbol != Convert.ToChar(a[27]) &&
                    symbol != Convert.ToChar(a[28]) && symbol != Convert.ToChar(a[29]) &&
                    symbol != Convert.ToChar(a[30]) && symbol != Convert.ToChar(a[31]) &&
                    symbol != Convert.ToChar(a[32]) && symbol != Convert.ToChar(a[33]) &&
                    symbol != Convert.ToChar(a[34]) && symbol != Convert.ToChar(a[35]))
                {
                    isnotcorrect = true;
                }
            }
            if (isnotcorrect)
            {
                int step = 0;
                int count = textbox_content.Length - 1;
                textbox_newcontent = "";
                System.Windows.Forms.MessageBox.Show("Недопустимый формат ввода в поле Трек-Номер");
                foreach (char s in textbox_content)
                {
                    if (step >= count)
                    {
                        break;
                    }
                    else
                    {
                        textbox_newcontent += s;
                    }
                    step++;
                }
                tb_test8.Text = textbox_newcontent;
                tb_test8.SelectionStart = tb_test8.Text.Length;
            } 
        }

        private void nazad_Click(object sender, EventArgs e)
        {
            dostavka_button.Visible = false;
            button1.Visible = false;
            M_pak_button.Visible = true;
            obpis_button.Visible = true;
            Ban_button.Visible = true;
            zakpis_button.Visible = true;
            Ems_button.Visible = true;
            dobv_button.Visible = false;
            del_button.Visible = false;
            poisk_button.Visible = false;
            filter_button.Visible = false;
            glav_men_button.Visible = false;

            for (int i = 0; i < 8; i++)
            {
                _tb[i].Visible = false;
                _lb[i].Visible = false;
            }

            naz.Visible = false;
            nazad.Visible = false;
            vper.Visible = false;
            save_button.Visible = false;
            dobavel_button.Visible = false;
            pictureBox1.Visible = false;

            pictureBox2.Visible = false;
            try
            {
                Image l = new Bitmap("lol.jpg");
                pictureBox2.Image = l;
            }
            catch
            {
                Image l = new Bitmap("not_found_image.jpg");
                pictureBox2.Image = l;
            }

            for (int i = 0; i < 3; i++)
            {
                _cb[i].Visible = false;
            }
            //--- find
            _tb[8].Visible = false;
            _lb[8].Visible = false;
            _lb[9].Visible = false;

            //-- filter
            _lb[10].Visible = false;
            _tb[9].Visible = false;
            _lb[11].Visible = false;
            _lb[12].Visible = false;
            _lb[13].Visible = false;
            _tb[10].Visible = false;
            _tb[9].Text = "";
            _tb[10].Text = "";
        }

        

    }
}
