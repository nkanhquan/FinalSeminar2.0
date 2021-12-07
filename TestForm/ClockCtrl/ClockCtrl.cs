using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm
{
    //source from Nguyen Duc Huy 
    public partial class UserControl2 : UserControl
    {
        
        int mm, ss, ms;
        int _mmBegin, _ssBegin;
        bool flag;
        //Định nghĩa gọi các hàm sự kiện --> Đặt trái banh
        public delegate void uscEClock_ExitHandle();
        public event uscEClock_ExitHandle uscEClock_Exit;
        public UserControl2()
        {
            InitializeComponent();
            line1.Image = imageList.Images[10];
            line2.Image = imageList.Images[10];
            SetImage();
        }
        private void SetImage()
        {
            mm1.Image = imageList.Images[mm / 10];
            mm2.Image = imageList.Images[mm % 10];
            ss1.Image = imageList.Images[ss / 10];
            ss2.Image = imageList.Images[ss % 10];
            ms1.Image = imageList.Images[ms / 10];
            ms2.Image = imageList.Images[ms % 10];
        }
        public int _mm
        {
            get
            {
                return _mmBegin;
            }
            set
            {
                if (value < 0)
                    _mmBegin = 0;

                else if (value > 99)
                    _mmBegin = 99;
                else
                    _mmBegin = value;
                mm1.Image = imageList.Images[_mmBegin / 10];
                mm2.Image = imageList.Images[_mmBegin % 10];
            }
        }

        public int _ss
        {
            get
            {
                return _ssBegin;
            }
            set
            {
                if (value < 0)
                    _ssBegin = 0;
                else
                if (value > 60)
                {
                    _ssBegin = value % 60;
                    _mmBegin = value / 60;
                }
                else
                    _ssBegin = value;
                ss1.Image = imageList.Images[_ssBegin / 10];
                ss2.Image = imageList.Images[_ssBegin % 10];
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (flag)
            {
                ms++;
                if (ms >= 100)
                {
                    ms = 0;
                    ss++;
                }
                if (ss >= 60)
                {
                    ss = 0;
                    mm++;
                }
                if (mm >= 99)
                    mm = 0;
            }
            else
            {
                ms--;
                if (ms < 0)
                {
                    ms = 99;
                    ss--;
                }
                if (ss < 0)
                {
                    ss = 59;
                    mm--;
                }
                if (mm < 0)
                    mm = 99;
            }
            SetImage();

            if (!flag && mm == 0 && ss == 0 && ms == 0)
            {
                //stop time when run out of time 
                timer.Enabled = false;
                SysTime.Enabled = false;
                mm = ss = ms = 0;
                line1.Image = imageList.Images[10];
                line2.Image = imageList.Images[10];
                SetImage();
                uscEClock_Exit();
                MessageBox.Show("Time out ");
            };
        }

        private void SysTime_Tick(object sender, EventArgs e)
        {
            ms++;
            if (ms >= 60)
            {
                ms = 0;
                ss++;
            }
            if (ss >= 60)
            {
                ss = 0;
                mm++;

                if (mm >= 24)
                    mm = 0;
                SetImage();
            }
        }

       

        private void ms2_Click(object sender, EventArgs e)
        {

        }

       
        public void Start()
        {
            timer.Enabled = true;
            flag = true;
            if (_mmBegin != 0)
            {
                mm = _mmBegin;
                flag = false;
            }
            if (_ssBegin != 0)
            {
                ss = _ssBegin;
                flag = false;
            }
        }
        private void UserControl2_Load(object sender, EventArgs e)
        {

        }
    }
}
