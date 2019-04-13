using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Windows.Forms;
//InteropServices is what allows us to use DllImport        

namespace FarmingBot
{

    public partial class Form1 : Form
    {
        int times = 1;
        DateTime cooldown;
        DateTime attackyail;
        DateTime sectime;

        sealed class Win32
        {

            Color col;
            [DllImport("user32.dll")]
            static extern IntPtr GetDC(IntPtr hwnd);

            [DllImport("user32.dll")]
            static extern Int32 ReleaseDC(IntPtr hwnd, IntPtr hdc);

            [DllImport("user32.dll")]
            static extern bool SetForegroundWindow(IntPtr hWnd);

            [DllImport("gdi32.dll")]
            static extern uint GetPixel(IntPtr hdc, int nXPos, int nYPos);

            static public System.Drawing.Color GetPixelColor(int x, int y)
            {
                IntPtr hdc = GetDC(IntPtr.Zero);
                uint pixel = GetPixel(hdc, x, y);
                ReleaseDC(IntPtr.Zero, hdc);
                Color color = Color.FromArgb((int)(pixel & 0x000000FF),
                             (int)(pixel & 0x0000FF00) >> 8,
                             (int)(pixel & 0x00FF0000) >> 16);

                return color;

            }
        }
        [DllImport("User32.dll", SetLastError = true)]
        public static extern int SendInput(int nInputs, ref INPUT pInputs,
                                           int cbSize);
        //mouse event constants
        bool star = true;
        const int MOUSEEVENTF_LEFTDOWN = 2;
        const int MOUSEEVENTF_LEFTUP = 4;
        //input type constant
        const int INPUT_MOUSE = 0;

        public struct MOUSEINPUT
        {
            public int dx;
            public int dy;
            public int mouseData;
            public int dwFlags;
            public int time;
            public IntPtr dwExtraInfo;
        }

        public struct INPUT
        {
            public uint type;
            public MOUSEINPUT mi;
        };

        public class Keyboard
        {
            [DllImport("user32.dll", SetLastError = true)]
            static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

            const int KEY_DOWN_EVENT = 0x0001; //Key down flag
            const int KEY_UP_EVENT = 0x0002; //Key up flag

            public static void HoldKey(byte key, double duration)
            {
                int totalDuration = 0;
                var startTime = DateTime.UtcNow.AddHours(2);;
                while (DateTime.UtcNow.AddHours(2) - startTime < TimeSpan.FromSeconds(duration))
                {
                    keybd_event(key, 0, KEY_DOWN_EVENT, 0);









                }
                keybd_event(key, 0, KEY_UP_EVENT, 0);


            }

        }
        //FindWindow
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(
            string lpClassName,
            string lpWindowName);

        //hWnd to make it easier
        IntPtr hWnd = FindWindow(
            null,
            "MapleStory");
        //187,238,0
        //PostMessage
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("user32.dll", SetLastError = true)]

        static extern bool PostMessage(
        IntPtr hWnd,

        uint Msg,
        int wParam,
        int lParam);
        //Define WM_KEYDOWN
        //102,221,255
  
        //170,102,17
        const int WM_KEYDOWN = 0x100;

        public Form1()
        {

            InitializeComponent();
        }

        //51,102,153
        private void Form1_Load(object sender, EventArgs e)
        {
            FindWindow(null, "MapleStory");
            timestart.Text = DateTime.UtcNow.AddHours(2).ToString();

           
     //102,51,34
            /*
             * 
             * 
              * '
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * */

            //119,68,34
            //85,34,17
        }

        private void clicknpc()
        {  //set cursor position to memorized location
            Cursor.Position = new Point(511, 495);
            //set up the INPUT struct and fill it for the mouse down
            INPUT i = new INPUT();
            i.type = INPUT_MOUSE;
            i.mi.dx = 0;
            i.mi.dy = 0;
            i.mi.dwFlags = MOUSEEVENTF_LEFTDOWN;
            i.mi.dwExtraInfo = IntPtr.Zero;
            i.mi.mouseData = 0;
            i.mi.time = 0;
            //send the input 
            SendInput(1, ref i, Marshal.SizeOf(i));
            //set the INPUT for mouse up and send it
            i.mi.dwFlags = MOUSEEVENTF_LEFTUP;
            SendInput(1, ref i, Marshal.SizeOf(i));
        }
        private void clicknpcwhenfinishpq()
        {  //set cursor position to memorized location
            Cursor.Position = new Point(511, 530);
            //set up the INPUT struct and fill it for the mouse down
            INPUT i = new INPUT();
            i.type = INPUT_MOUSE;
            i.mi.dx = 0;
            i.mi.dy = 0;
            i.mi.dwFlags = MOUSEEVENTF_LEFTDOWN;
            i.mi.dwExtraInfo = IntPtr.Zero;
            i.mi.mouseData = 0;
            i.mi.time = 0;
            //send the input 
            SendInput(1, ref i, Marshal.SizeOf(i));
            //set the INPUT for mouse up and send it
            i.mi.dwFlags = MOUSEEVENTF_LEFTUP;
            SendInput(1, ref i, Marshal.SizeOf(i));
        }
        private void clickonlie()
        {  //set cursor position to memorized location
            Cursor.Position = new Point(575, 458);
            //set up the INPUT struct and fill it for the mouse down
            INPUT i = new INPUT();
            i.type = INPUT_MOUSE;
            i.mi.dx = 0;
            i.mi.dy = 0;
            i.mi.dwFlags = MOUSEEVENTF_LEFTDOWN;
            i.mi.dwExtraInfo = IntPtr.Zero;
            i.mi.mouseData = 0;
            i.mi.time = 0;
            //send the input 
            SendInput(1, ref i, Marshal.SizeOf(i));
            //set the INPUT for mouse up and send it
            i.mi.dwFlags = MOUSEEVENTF_LEFTUP;
            SendInput(1, ref i, Marshal.SizeOf(i));
        }
        private void finishliefuqellinia()
        {  //set cursor position to memorized location
            Cursor.Position = new Point(653, 503);
            //set up the INPUT struct and fill it for the mouse down
            INPUT i = new INPUT();
            i.type = INPUT_MOUSE;
            i.mi.dx = 0;
            i.mi.dy = 0;
            i.mi.dwFlags = MOUSEEVENTF_LEFTDOWN;
            i.mi.dwExtraInfo = IntPtr.Zero;
            i.mi.mouseData = 0;
            i.mi.time = 0;
            //send the input 
            SendInput(1, ref i, Marshal.SizeOf(i));
            //set the INPUT for mouse up and send it
            i.mi.dwFlags = MOUSEEVENTF_LEFTUP;
            SendInput(1, ref i, Marshal.SizeOf(i));
        }

        private void clicknpccontincue()
        {  //set cursor position to memorized location
            Cursor.Position = new Point(600, 275);
            //set up the INPUT struct and fill it for the mouse down
            INPUT i = new INPUT();
            i.type = INPUT_MOUSE;
            i.mi.dx = 0;
            i.mi.dy = 0;
            i.mi.dwFlags = MOUSEEVENTF_LEFTDOWN;
            i.mi.dwExtraInfo = IntPtr.Zero;
            i.mi.mouseData = 0;
            i.mi.time = 0;
            //send the input 
            SendInput(1, ref i, Marshal.SizeOf(i));
            //set the INPUT for mouse up and send it
            i.mi.dwFlags = MOUSEEVENTF_LEFTUP;
            SendInput(1, ref i, Marshal.SizeOf(i));
        }
        private void hey()
        {  //set cursor position to memorized location
            Cursor.Position = new Point(443, 391);
            //set up the INPUT struct and fill it for the mouse down
            INPUT i = new INPUT();
            i.type = INPUT_MOUSE;
            i.mi.dx = 0;
            i.mi.dy = 0;
            i.mi.dwFlags = MOUSEEVENTF_LEFTDOWN;
            i.mi.dwExtraInfo = IntPtr.Zero;
            i.mi.mouseData = 0;
            i.mi.time = 0;
            //send the input 
            SendInput(1, ref i, Marshal.SizeOf(i));
            //set the INPUT for mouse up and send it
            i.mi.dwFlags = MOUSEEVENTF_LEFTUP;
            SendInput(1, ref i, Marshal.SizeOf(i));
        }
        private void hey1()
        {  //set cursor position to memorized location
            Cursor.Position = new Point(457, 427);
            //set up the INPUT struct and fill it for the mouse down
            INPUT i = new INPUT();
            i.type = INPUT_MOUSE;
            i.mi.dx = 0;
            i.mi.dy = 0;
            i.mi.dwFlags = MOUSEEVENTF_LEFTDOWN;
            i.mi.dwExtraInfo = IntPtr.Zero;
            i.mi.mouseData = 0;
            i.mi.time = 0;
            //send the input 
            SendInput(1, ref i, Marshal.SizeOf(i));
            //set the INPUT for mouse up and send it
            i.mi.dwFlags = MOUSEEVENTF_LEFTUP;
            SendInput(1, ref i, Marshal.SizeOf(i));
        }
        private void accetparty()
        {  //set cursor position to memorized location
            Cursor.Position = new Point(584, 691);
            //set up the INPUT struct and fill it for the mouse down
            INPUT i = new INPUT();
            i.type = INPUT_MOUSE;
            i.mi.dx = 0;
            i.mi.dy = 0;
            i.mi.dwFlags = MOUSEEVENTF_LEFTDOWN;
            i.mi.dwExtraInfo = IntPtr.Zero;
            i.mi.mouseData = 0;
            i.mi.time = 0;
            //send the input 
            SendInput(1, ref i, Marshal.SizeOf(i));
            //set the INPUT for mouse up and send it
            i.mi.dwFlags = MOUSEEVENTF_LEFTUP;
            SendInput(1, ref i, Marshal.SizeOf(i));
        }

        private void clickrepeat()
        {  //set cursor position to memorized location
            Cursor.Position = new Point(1122, 436);
            //set up the INPUT struct and fill it for the mouse down
            INPUT i = new INPUT();
            i.type = INPUT_MOUSE;
            i.mi.dx = 0;
            i.mi.dy = 0;
            i.mi.dwFlags = MOUSEEVENTF_LEFTDOWN;
            i.mi.dwExtraInfo = IntPtr.Zero;
            i.mi.mouseData = 0;
            i.mi.time = 0;
            //send the input 
            SendInput(1, ref i, Marshal.SizeOf(i));
            //set the INPUT for mouse up and send it
            i.mi.dwFlags = MOUSEEVENTF_LEFTUP;
            SendInput(1, ref i, Marshal.SizeOf(i));
        }
        public void tradeprogram()
        {
            if (Win32.GetPixelColor(555, 700).ToString() == "Color [A=255, R=51, G=102, B=153]")
            {
                accepttrade();
                System.Threading.Thread.Sleep(3000);
                SendKeys.SendWait("hi");
                System.Threading.Thread.Sleep(1000);
                SendKeys.SendWait("{ENTER}");
                System.Threading.Thread.Sleep(5000);
                SendKeys.SendWait("im no speak english sry");
                System.Threading.Thread.Sleep(1000);
                SendKeys.SendWait("{ENTER}");
                label7.Text = "wtf";
            }
        }
        private void clickMaple()
        {  //set cursor position to memorized location
            Cursor.Position = new Point(350, 150);
            //set up the INPUT struct and fill it for the mouse down
            INPUT i = new INPUT();
            i.type = INPUT_MOUSE;
            i.mi.dx = 0;
            i.mi.dy = 0;
            i.mi.dwFlags = MOUSEEVENTF_LEFTDOWN;
            i.mi.dwExtraInfo = IntPtr.Zero;
            i.mi.mouseData = 0;
            i.mi.time = 0;
            //send the input 
            SendInput(1, ref i, Marshal.SizeOf(i));
            //set the INPUT for mouse up and send it
            i.mi.dwFlags = MOUSEEVENTF_LEFTUP;
            SendInput(1, ref i, Marshal.SizeOf(i));
        }
        private void leavept()
        {  //set cursor position to memorized location
            Cursor.Position = new Point(820, 350);
            //set up the INPUT struct and fill it for the mouse down
            INPUT i = new INPUT();
            i.type = INPUT_MOUSE;
            i.mi.dx = 0;
            i.mi.dy = 0;
            i.mi.dwFlags = MOUSEEVENTF_LEFTDOWN;
            i.mi.dwExtraInfo = IntPtr.Zero;
            i.mi.mouseData = 0;
            i.mi.time = 0;
            //send the input 
            SendInput(1, ref i, Marshal.SizeOf(i));
            //set the INPUT for mouse up and send it
            i.mi.dwFlags = MOUSEEVENTF_LEFTUP;
            SendInput(1, ref i, Marshal.SizeOf(i));
        }
      
                private void accepttrade()
        {  //set cursor position to memorized location
            Cursor.Position = new Point(583, 692);
            //set up the INPUT struct and fill it for the mouse down
            INPUT i = new INPUT();
            i.type = INPUT_MOUSE;
            i.mi.dx = 0;
            i.mi.dy = 0;
            i.mi.dwFlags = MOUSEEVENTF_LEFTDOWN;
            i.mi.dwExtraInfo = IntPtr.Zero;
            i.mi.mouseData = 0;
            i.mi.time = 0;
            //send the input 
            SendInput(1, ref i, Marshal.SizeOf(i));
            //set the INPUT for mouse up and send it
            i.mi.dwFlags = MOUSEEVENTF_LEFTUP;
            SendInput(1, ref i, Marshal.SizeOf(i));
        }
        private void clickkeyboard()
        {  //set cursor position to memorized location
            Cursor.Position = new Point(1, 941);
            //set up the INPUT struct and fill it for the mouse down
            INPUT i = new INPUT();
            i.type = INPUT_MOUSE;
            i.mi.dx = 0;
            i.mi.dy = 0;
            i.mi.dwFlags = MOUSEEVENTF_LEFTDOWN;
            i.mi.dwExtraInfo = IntPtr.Zero;
            i.mi.mouseData = 0;
            i.mi.time = 0;
            //send the input 
            SendInput(1, ref i, Marshal.SizeOf(i));
            //set the INPUT for mouse up and send it
            i.mi.dwFlags = MOUSEEVENTF_LEFTUP;
            SendInput(1, ref i, Marshal.SizeOf(i));
        }
        private void clickok()
        {  //set cursor position to memorized location
            Cursor.Position = new Point(517, 412);
            //set up the INPUT struct and fill it for the mouse down
            INPUT i = new INPUT();
            i.type = INPUT_MOUSE;
            i.mi.dx = 0;
            i.mi.dy = 0;
            i.mi.dwFlags = MOUSEEVENTF_LEFTDOWN;
            i.mi.dwExtraInfo = IntPtr.Zero;
            i.mi.mouseData = 0;
            i.mi.time = 0;
            //send the input 
            SendInput(1, ref i, Marshal.SizeOf(i));
            //set the INPUT for mouse up and send it
            i.mi.dwFlags = MOUSEEVENTF_LEFTUP;
            SendInput(1, ref i, Marshal.SizeOf(i));
        }
        public void button1_Click(object sender, EventArgs e)
        {
            int count = 0;
            int firstattack = 0;
            
            //578,436
            var attackingdelaymoving = DateTime.UtcNow;
            bool flag = false;
            //95,108,122
            var dcdetect =DateTime.UtcNow;
    

            FindWindow(null, "MapleStory");
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            System.Threading.Thread.Sleep(2000);//442,415
            var startTime = DateTime.UtcNow.AddHours(2);
            var lastpqtime = DateTime.UtcNow.AddHours(2);
            int pqnumberint = int.Parse(pqsnumber.Text);
            int pqcheck = 100;
            var emailsending = DateTime.UtcNow.AddHours(2);
            while (Win32.GetPixelColor(880, 790).ToString() != "Color [A=255, R=17, G=119, B=170]")
            {
                if (int.Parse(pqsnumber.Text) % 15 == 0 && pqcheck != int.Parse(pqsnumber.Text))
                {
                   

                    mail.From = new MailAddress("autobotupdate@gmail.com");
                    mail.To.Add("autobotupdate@gmail.com");
                    mail.Subject = "Done 30 PQs:" + lastpqtime +" nx got:" + nxgot.Text;
                    mail.Body = "Bot Done 30 PQs";

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("autobotupdate@gmail.com", "mommom123moM");
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                    pqcheck = int.Parse(pqsnumber.Text);

                }
                while (Win32.GetPixelColor(74, 110).ToString() == "Color [A=255, R=68, G=51, B=0]" && Win32.GetPixelColor(395, 319).ToString() != "Color [A=255, R=238, G=136, B=0]" && Win32.GetPixelColor(880, 790).ToString() != "Color [A=255, R=17, G=119, B=170]")
                {

                    if (DateTime.UtcNow - dcdetect >= TimeSpan.FromMinutes(2))
                    {
                        SendKeys.SendWait("{ENTER}");
                        SendKeys.SendWait("{ENTER}");
                        SendKeys.SendWait("{ENTER}");
                        System.Threading.Thread.Sleep(1000);
                        leavept();
                        System.Threading.Thread.Sleep(1000);
                        PostMessage(hWnd, WM_KEYDOWN, 0x50, 0x190001);
                        System.Threading.Thread.Sleep(1000);
                        leavept();
                        System.Threading.Thread.Sleep(1000);
                        leavept();
                        System.Threading.Thread.Sleep(1000);
                        SendKeys.SendWait("{ENTER}");
                        System.Threading.Thread.Sleep(1000);
                        PostMessage(hWnd, WM_KEYDOWN, 0x50, 0x190001);
                    }
                    count = 0;


                    Process p = Process.GetProcessesByName("nox.exe").FirstOrDefault();
                    SetForegroundWindow(p.MainWindowHandle);
                    lastpq.Text = (DateTime.UtcNow.AddHours(2) - lastpqtime).ToString();
                    pqtimelast.Text = DateTime.UtcNow.AddHours(2).ToString();
                    pqsnumber.Text = (int.Parse(pqsnumber.Text) + 1).ToString();
                    nxgot.Text = (int.Parse(nxgot.Text) + 141123).ToString();
                    bp.Text = (int.Parse(bp.Text) + 364129).ToString();
                    attackingdelaymoving = DateTime.UtcNow;
                    System.Threading.Thread.Sleep(1000);
                    LieBotFinder();
                    System.Threading.Thread.Sleep(1500);
                    PostMessage(hWnd, WM_KEYDOWN, 0x31, 0x20001);
                    System.Threading.Thread.Sleep(2000);
                    PostMessage(hWnd, WM_KEYDOWN, 0x33, 0x40001);
                    System.Threading.Thread.Sleep(2000);
                    PostMessage(hWnd, WM_KEYDOWN, 0x2e, 0x1530001);
                    System.Threading.Thread.Sleep(3000);
                    if (Win32.GetPixelColor(555, 700).ToString() == "Color [A=255, R=51, G=102, B=153]")

                        tradeprogram();
                    if (int.Parse(pqsnumber.Text) % 2 == 0) { System.Threading.Thread.Sleep(2000); PostMessage(hWnd, WM_KEYDOWN, 0x34, 0x50001); System.Threading.Thread.Sleep(3000); PostMessage(hWnd, WM_KEYDOWN, 0x35, 0x60001); System.Threading.Thread.Sleep(500); }

                    clicknpcwhenfinishpq();

              

                    while (Win32.GetPixelColor(660, 415).ToString() != "Color [A=255, R=255, G=255, B=255]")
                    {
                        if (Win32.GetPixelColor(74, 110).ToString() != "Color [A=255, R=68, G=51, B=0]")
                            break;


                        System.Threading.Thread.Sleep(500);
                        clicknpcwhenfinishpq();

                    }
                    if (Win32.GetPixelColor(74, 110).ToString() != "Color [A=255, R=68, G=51, B=0]") break;
                    System.Threading.Thread.Sleep(500);
                    SendKeys.SendWait("{ENTER}");
                    startTime = DateTime.UtcNow.AddHours(2); ;
                    while (Win32.GetPixelColor(660, 415).ToString() != "Color [A=255, R=255, G=255, B=255]")
                    {
                        System.Threading.Thread.Sleep(500);
                        clicknpcwhenfinishpq();

                    }
                    System.Threading.Thread.Sleep(1500);
                    hey1();
                    System.Threading.Thread.Sleep(3000);
                  
                    

                    
                    //Lie bot detector
                    LieBotFinder();
                    lastpqtime = DateTime.UtcNow.AddHours(2);
                }

                if (Win32.GetPixelColor(416, 443).ToString() != "Color [A=255, R=85, G=34, B=34]" && Win32.GetPixelColor(578, 436).ToString() != "Color [A=255, R=153, G=119, B=51]" && Win32.GetPixelColor(442, 415).ToString() != "Color [A=255, R=68, G=34, B=17]" && Win32.GetPixelColor(90, 139).ToString() != "Color [A=255, R=102, G=51, B=34]" || Win32.GetPixelColor(460, 413).ToString() == "Color [A=255, R=119, G=68, B=34]" || Win32.GetPixelColor(423, 436).ToString() == "Color [A=255, R=85, G=34, B=34]" && Win32.GetPixelColor(880, 790).ToString() != "Color [A=255, R=17, G=119, B=170]")
                {
                    //187,238,0

                    if (Win32.GetPixelColor(343, 488).ToString() == "Color [A=255, R=187, G=238, B=0]") SendKeys.SendWait("{ESC}");//check bug.
                    if (Win32.GetPixelColor(417, 747).ToString() == "Color [A=255, R=255, G=255, B=255]" && Win32.GetPixelColor(460, 413).ToString() != "Color [A=255, R=119, G=68, B=34]" && Win32.GetPixelColor(423, 436).ToString() != "Color [A=255, R=85, G=34, B=34]")

                        SendKeys.SendWait("{ENTER}");






                    if (Win32.GetPixelColor(979, 705).ToString() == "Color [A=255, R=255, G=255, B=255]")
                    {
                        Keyboard.HoldKey((byte)Keys.Left, 0.04);
                        PostMessage(hWnd, WM_KEYDOWN, 0x11, 0x1d0001);
                        Keyboard.HoldKey((byte)Keys.Left, 3);
                 
                    }

                    else if (Win32.GetPixelColor(45, 708).ToString() == "Color [A=255, R=255, G=255, B=255]" || Win32.GetPixelColor(160, 708).ToString() == "Color [A=255, R=255, G=255, B=255]") Keyboard.HoldKey((byte)Keys.Right, 1.1);
                    else
                    {










                        while ((Win32.GetPixelColor(979, 705).ToString() != "Color [A=255, R=255, G=255, B=255]" && Win32.GetPixelColor(34, 705).ToString() != "Color [A=255, R=255, G=255, B=255]" && Win32.GetPixelColor(416, 443).ToString() != "Color [A=255, R=85, G=34, B=34]" && Win32.GetPixelColor(578, 436).ToString() != "Color [A=255, R=153, G=119, B=51]" && Win32.GetPixelColor(442, 415).ToString() != "Color [A=255, R=68, G=34, B=17]" && Win32.GetPixelColor(90, 139).ToString() != "Color [A=255, R=102, G=51, B=34]" || Win32.GetPixelColor(460, 413).ToString() == "Color [A=255, R=119, G=68, B=34]" || Win32.GetPixelColor(423, 436).ToString() == "Color [A=255, R=85, G=34, B=34]" && Win32.GetPixelColor(880, 790).ToString() != "Color [A=255, R=17, G=119, B=170]" && Win32.GetPixelColor(45, 708).ToString() != "Color [A=255, R=255, G=255, B=255]" && Win32.GetPixelColor(160, 708).ToString() != "Color [A=255, R=255, G=255, B=255]" && Win32.GetPixelColor(979, 705).ToString() != "Color [A=255, R=255, G=255, B=255]"))
                        {
                            attackyail = DateTime.UtcNow;
                            while (DateTime.UtcNow - attackyail < TimeSpan.FromSeconds(10) && Win32.GetPixelColor(112, 133).ToString() != "Color [A=255, R=0, G=221, B=0]" && Win32.GetPixelColor(45, 708).ToString() != "Color [A=255, R=255, G=255, B=255]" && Win32.GetPixelColor(700, 770).ToString() != "Color [A=255, R=119, G=187, B=238]")
                            {
                                for (int i = 0; i < 257; i += 35)

                                    if (Win32.GetPixelColor(i, 708).ToString() == "Color [A=255, R=255, G=255, B=255]") { Keyboard.HoldKey((byte)Keys.Right, 0.3); continue; };



                                PostMessage(hWnd, WM_KEYDOWN, 0x11, 0x1d0001); dcdetect = DateTime.UtcNow;
                            }
                            System.Threading.Thread.Sleep(400);
                            Keyboard.HoldKey((byte)Keys.Right, 0.1);

                            if (Win32.GetPixelColor(700, 770).ToString() == "Color [A=255, R=119, G=187, B=238]")
                            {
                                clickkeyboard();
                                System.Threading.Thread.Sleep(29000);
                                clickonlie();
                                System.Threading.Thread.Sleep(2000);
                                LieBotFinder();
                                
                            }

                 

                             if (Win32.GetPixelColor(45, 708).ToString() == "Color [A=255, R=255, G=255, B=255]")

                
                            if (Win32.GetPixelColor(555, 700).ToString() == "Color [A=255, R=51, G=102, B=153]")

                                tradeprogram();
                        }
                    }










                    //409,389

                }




                /* null would be where the Window Class would be.
                 * Which is MapleStoryClass for MS. But apparently the class
                 * when the 'play screen' is up isnt' MapleStoryClass,
                 * and I like opening my stuff at the play screen.
                 * So I just used the Window Name instead.
                 */
            }

            clickkeyboard();
            System.Threading.Thread.Sleep(22500);
        }
        public void LieBotFinder()
        {
            string[] s = new string[6];
            int i = 0;
            if (Win32.GetPixelColor(395, 319).ToString() == "Color [A=255, R=238, G=136, B=0]")
            {

                for (int d = 0; d < 6; d++)
                {

                    if (Win32.GetPixelColor(506 + i, 380).ToString() == "Color [A=255, R=255, G=255, B=255]" && Win32.GetPixelColor(509 + i, 386).ToString() == "Color [A=255, R=255, G=255, B=255]" && Win32.GetPixelColor(507 + i, 389).ToString() == "Color [A=255, R=255, G=255, B=255]" && Win32.GetPixelColor(505 + i, 387).ToString() == "Color [A=255, R=255, G=255, B=255]" && Win32.GetPixelColor(507 + i, 385).ToString() == "Color [A=255, R=68, G=136, B=187]") //0-sifra 1 
                    {
                        s[d] = "0";
                    }
                    else if (Win32.GetPixelColor(508 + i, 387).ToString() == "Color [A=255, R=255, G=255, B=255]" && Win32.GetPixelColor(508 + i, 383).ToString() == "Color [A=255, R=255, G=255, B=255]" && Win32.GetPixelColor(508 + i, 384).ToString() == "Color [A=255, R=255, G=255, B=255]" && Win32.GetPixelColor(505 + i, 386).ToString() == "Color [A=255, R=68, G=136, B=187]" && Win32.GetPixelColor(505 + i, 388).ToString() == "Color [A=255, R=68, G=136, B=187]" && Win32.GetPixelColor(510 + i, 387).ToString() == "Color [A=255, R=68, G=136, B=187]") //1-sifra 1 
                    {
                        s[d] = "1";
                    }
                    else if (Win32.GetPixelColor(509 + i, 382).ToString() == "Color [A=255, R=255, G=255, B=255]" && Win32.GetPixelColor(510 + i, 389).ToString() == "Color [A=255, R=255, G=255, B=255]" && Win32.GetPixelColor(505 + i, 383).ToString() == "Color [A=255, R=255, G=255, B=255]") //2-sifra 1 
                    {
                        s[d] = "2";
                    }
                    else if (Win32.GetPixelColor(505 + i, 389).ToString() == "Color [A=255, R=255, G=255, B=255]" && Win32.GetPixelColor(505 + i, 382).ToString() == "Color [A=255, R=255, G=255, B=255]" && Win32.GetPixelColor(507 + i, 385).ToString() == "Color [A=255, R=255, G=255, B=255]" && Win32.GetPixelColor(503 + i, 385).ToString() == "Color [A=255, R=68, G=136, B=187]" && Win32.GetPixelColor(506 + i, 385).ToString() == "Color [A=255, R=68, G=136, B=187]") //3-sifra 1 
                    {
                        s[d] = "3";
                    }
                    else if (Win32.GetPixelColor(508 + i, 382).ToString() == "Color [A=255, R=255, G=255, B=255]" && Win32.GetPixelColor(509 + i, 388).ToString() == "Color [A=255, R=255, G=255, B=255]" && Win32.GetPixelColor(509 + i, 389).ToString() == "Color [A=255, R=255, G=255, B=255]" && Win32.GetPixelColor(506 + i, 387).ToString() == "Color [A=255, R=255, G=255, B=255]" && Win32.GetPixelColor(507 + i, 386).ToString() == "Color [A=255, R=68, G=136, B=187]" && Win32.GetPixelColor(507 + i, 391).ToString() == "Color [A=255, R=68, G=136, B=187]") //4-sifra 1
                    {
                        s[d] = "4";
                    }
                    else if (Win32.GetPixelColor(508 + i, 383).ToString() == "Color [A=255, R=255, G=255, B=255]" && Win32.GetPixelColor(505 + i, 387).ToString() == "Color [A=255, R=255, G=255, B=255]" && Win32.GetPixelColor(506 + i, 383).ToString() == "Color [A=255, R=255, G=255, B=255]" && Win32.GetPixelColor(505 + i, 385).ToString() == "Color [A=255, R=255, G=255, B=255]" && Win32.GetPixelColor(507 + i, 387).ToString() == "Color [A=255, R=68, G=136, B=187]") //5-sifra 1
                    {
                        s[d] = "5";
                    }
                    else if (Win32.GetPixelColor(507 + i, 381).ToString() == "Color [A=255, R=255, G=255, B=255]" && Win32.GetPixelColor(507 + i, 389).ToString() == "Color [A=255, R=255, G=255, B=255]" && Win32.GetPixelColor(509 + i, 388).ToString() == "Color [A=255, R=255, G=255, B=255]" && Win32.GetPixelColor(507 + i, 383).ToString() == "Color [A=255, R=68, G=136, B=187]" && Win32.GetPixelColor(511 + i, 388).ToString() == "Color [A=255, R=68, G=136, B=187]" && Win32.GetPixelColor(506 + i, 384).ToString() == "Color [A=255, R=187, G=221, B=238]") //6-sifra 1
                    {
                        s[d] = "6";
                    }
                    else if (Win32.GetPixelColor(507 + i, 384).ToString() == "Color [A=255, R=255, G=255, B=255]" && Win32.GetPixelColor(507 + i, 390).ToString() == "Color [A=255, R=255, G=255, B=255]" && Win32.GetPixelColor(506 + i, 385).ToString() == "Color [A=255, R=255, G=255, B=255]" && Win32.GetPixelColor(507 + i, 386).ToString() == "Color [A=255, R=68, G=136, B=187]" && Win32.GetPixelColor(504 + i, 384).ToString() == "Color [A=255, R=68, G=136, B=187]" && Win32.GetPixelColor(507 + i, 383).ToString() == "Color [A=255, R=68, G=136, B=187]") //8-sifra 1
                    {
                        s[d] = "8";
                    }
                    else if (Win32.GetPixelColor(506 + i, 386).ToString() == "Color [A=255, R=255, G=255, B=255]" && Win32.GetPixelColor(507 + i, 385).ToString() == "Color [A=255, R=255, G=255, B=255]" && Win32.GetPixelColor(507 + i, 381).ToString() == "Color [A=255, R=255, G=255, B=255]" && Win32.GetPixelColor(510 + i, 386).ToString() == "Color [A=255, R=255, G=255, B=255]" && Win32.GetPixelColor(507 + i, 384).ToString() == "Color [A=255, R=68, G=136, B=187]") //9-sifra 1
                    {
                        s[d] = "9";
                    }
                    else
                        s[d] = "7";
                    i += 8;
                }
                clickonlie();
                System.Threading.Thread.Sleep(2000);
                if (s.Length != 6) LieBotFinder();
                else
                {
                    for (int p = 0; p < s.Length; p++)
                    {
                        SendKeys.SendWait(s[p]);
                        System.Threading.Thread.Sleep(2000);
                    }


                    if (Win32.GetPixelColor(540, 457).ToString() != "Color [A=255, R=255, G=255, B=255]" || Win32.GetPixelColor(539, 463).ToString() != "Color [A=255, R=255, G=255, B=255]" || Win32.GetPixelColor(540, 462).ToString() != "Color [A=255, R=255, G=255, B=255]" || Win32.GetPixelColor(538, 460).ToString() != "Color [A=255, R=255, G=255, B=255]" || Win32.GetPixelColor(539, 460).ToString() != "Color [A=255, R=255, G=255, B=255]" || Win32.GetPixelColor(540, 463).ToString() != "Color [A=255, R=255, G=255, B=255]" || Win32.GetPixelColor(538, 462).ToString() != "Color [A=255, R=255, G=255, B=255]" || Win32.GetPixelColor(543, 465).ToString() != "Color [A=255, R=255, G=255, B=255]")
                    {
                        for (int d = 0; d < 13; d++)
                        {
                            SendKeys.SendWait("{BACKSPACE}");
                            System.Threading.Thread.Sleep(300);
                        }
                        LieBotFinder();
                    }
                    else
                    {
                        System.Threading.Thread.Sleep(2000);
                        finishliefuqellinia();


  
                        detectedcount.Text = (int.Parse(detectedcount.Text) + 1).ToString();
                        //}
                        System.Threading.Thread.Sleep(1000);
                        MailMessage mail = new MailMessage();
                        SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                        mail.From = new MailAddress("autobotupdate@gmail.com");
                        mail.To.Add("autobotupdate@gmail.com");
                        mail.Subject = "Numbers detected:" + detectedcount.Text + " time:" + pqtimelast.Text;
                        mail.Body = lastpq.Text;

                        SmtpServer.Port = 587;
                        SmtpServer.Credentials = new System.Net.NetworkCredential("autobotupdate@gmail.com", "mommom123moM");
                        SmtpServer.EnableSsl = true;

                        SmtpServer.Send(mail);

                    }
                }
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.F4) Application.Exit();
        }
              
                }
        }
        



