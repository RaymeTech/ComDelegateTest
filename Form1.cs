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
        [DllImport("ComDelegate.dll")]
        public static extern int setLogPath(String path);

        // 模拟键盘输入 //
        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags,
           int dwExtraInfo);

        // 键盘键值定义 //
        const byte key_1_value = 0x31;
        const byte key_2_value = 0x32;
        const byte key_3_value = 0x33;
        const byte key_4_value = 0x34;
        const byte key_5_value = 0x35;
        const byte key_6_value = 0x36;
        const byte key_7_value = 0x37;
        const byte key_8_value = 0x38;
        const byte key_9_value = 0x39;
        const byte key_0_value = 0x30;

        const byte key_1_scan = 0x02;
        const byte key_2_scan = 0x03;
        const byte key_3_scan = 0x04;
        const byte key_4_scan = 0x05;
        const byte key_5_scan = 0x06;
        const byte key_6_scan = 0x07;
        const byte key_7_scan = 0x08;
        const byte key_8_scan = 0x09;
        const byte key_9_scan = 0x0a;
        const byte key_0_scan = 0x0b;

        const byte key_enter_value = 0x0d;
        const byte key_enter_scan = 0x1c;
        const byte key_point_value = 0x6e;
        const byte key_point_scan = 0x31;

        private void ClickKey(byte value, byte scan)
        {
            keybd_event(value, scan, 0, 0);
            keybd_event(value, scan, 2, 0);
        }

        delegate void SetTextCallBack(string text);
        private void SetText(string text)
        {
            if (this.log_text.InvokeRequired)
            {
                SetTextCallBack stcb = new SetTextCallBack(SetText);
                this.Invoke(stcb, new object[] { text });
            }
            else
            {
                this.log_text.AppendText(text);
            }
        }

        //声明回调的函数
        public void ComRecvCallImp(String buf, int size)
        {
            //MessageBox.Show(buf);
            //log_text.AppendText(buf+"\r\n");
            SetText(buf+"\r\n");
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
                String baud = baud_text.Text;
                String data = data_text.Text;
                String stop = stop_text.Text;
                String parity = parity_text.Text;
                com_port = com_port + "&" + baud + "&" + parity + "&" + data + "&" + stop;
                setComIn(com_port);

                com_port = com_out_text.Text;
                com_port = com_port + "&" + baud + "&" + parity + "&" + data + "&" + stop;
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

        private void log_btn_Click(object sender, EventArgs e)
        {
            if (log_btn.Text == "开启日志")
            {
                String path = System.Environment.CurrentDirectory+"\\";
                setLogPath(path);
                log_btn.Text = "关闭日志";
            } else {
                setLogPath("");
                log_btn.Text = "开启日志";
            }
        }
    }
}
