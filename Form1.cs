using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace ComDelegateTest
{
    public partial class Form1 : Form
    {
        //声明
        public delegate void ComRecvCall(String buf,int size);
        //设置回调函数
        [DllImport("ComDelegate.dll")]
        public static extern bool CommSetCallback(ComRecvCall fa);
        [DllImport("ComDelegate.dll")]
        public static extern String version();
        [DllImport("ComDelegate.dll")]
        public static extern int activate(String sign);
        [DllImport("ComDelegate.dll")]
        public static extern int setComIn(String com_in);
        [DllImport("ComDelegate.dll")]
        public static extern int setComOut(String com_out);
        [DllImport("ComDelegate.dll")]
        public static extern int initDelegate();
        [DllImport("ComDelegate.dll")]
        public static extern int uninitDelegate();

        //声明回调的函数
        public void ComRecvCallImp(String buf, int size)
        {
            MessageBox.Show(buf);
            return;
        }

        public Form1()
        {
            InitializeComponent();
            //调用
            CommSetCallback(ComRecvCallImp);
        }

        private void run_btn_Click(object sender, EventArgs e)
        {
            if (run_btn.Text == "启动")
            {
                String com_port = com_in_text.Text;
                com_port = com_port + "&9600&N&8&1";
                setComIn(com_port);

                com_port = com_out_text.Text;
                com_port = com_port + "&9600&N&8&1";
                setComOut(com_port);

                initDelegate();

                run_btn.Text = "停止";
            }
            else
            {
                run_btn.Text = "启动";
                uninitDelegate();
            }
        }
    }
}
