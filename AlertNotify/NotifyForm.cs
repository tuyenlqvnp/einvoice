using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Web.Script.Serialization;
using System.Threading;
using System.IO;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;

namespace AlertNotify
{
    public partial class NotifyForm : Form
    {
        static HttpListener listener;
        static Thread listenThread;

        public NotifyForm()
        {
            InitializeComponent();
            this.FormClosed += NotifyForm_FormClosed;
            this.Resize += NotifyForm_Resize;

            this.notifyIcon.BalloonTipText = "Alert Notify ...";
            this.notifyIcon.BalloonTipTitle = "Alert";
            this.notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            this.notifyIcon.MouseDoubleClick += NotifyForm_MouseDoubleClick;

            try
            {
                string port = ConfigurationManager.AppSettings["port"];
                listener = new HttpListener();
                //netsh http add iplisten ipaddress=0.0.0.0:8080
                //netsh http add urlacl url=http://*:8080/ user=Everyone listen=yes
                listener.Prefixes.Add("http://*:"+ port +"/");
                listener.AuthenticationSchemes = AuthenticationSchemes.Anonymous;

                listener.Start();
                listenThread = new Thread(new ParameterizedThreadStart(StartListener));
                listenThread.Start();
            }
            catch(Exception e)
            {
                this.tbMsg.Text = e.ToString();
            }
        }

        private void StartListener(object s)
        {
            while (true)
            {
                ProcessRequest();
            }
        }

        private void ProcessRequest()
        {
            if(listener.IsListening)
            {
                var result = listener.BeginGetContext(ListenerCallback, listener);
                result.AsyncWaitHandle.WaitOne();
            }
        }

        byte[] getPayload(HttpListenerContext context)
        {
            int length = (int)context.Request.ContentLength64;
            byte[] payload = new byte[length];
            int numRead = 0;
            while (numRead < length)
            {
                numRead += context.Request.InputStream.Read(payload, numRead, length - numRead);
            }
            return payload;
        }

        private void ListenerCallback(IAsyncResult result)
        {
            try
            {
                if (listener.IsListening)
                {
                    var context = listener.EndGetContext(result);
                    byte[] data = getPayload(context);
                    string data_text = System.Text.UTF8Encoding.UTF8.GetString(data);
                    this.Invoke(new Action(() =>
                    {
                        this.tbMsg.Text = data_text;
                        this.Show();
                        this.WindowState = FormWindowState.Normal;
                        this.Activate();
                        this.labelFocus.Focus();
                    }));

                    X509Certificate2 test = EInvoiceLib.X509Fn.GetCertificateBySerial("54018ef116dc26d07254d81de2fb6de6");
                    string s = test.Subject;
                    //string s = "aaaaaaaaaaaaaa";
                    byte[] bytes = System.Text.Encoding.UTF8.GetBytes(s);

                    context.Response.Headers.Add("Access-Control-Allow-Origin", "*");
                    context.Response.Headers.Add("Access-Control-Allow-Methods", "POST, GET");

                    context.Response.OutputStream.Write(bytes, 0, bytes.Length);

                    context.Response.StatusCode = 200;
                    context.Response.StatusDescription = "OK";
                    context.Response.Close();
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void NotifyForm_FormClosed(Object sender, FormClosedEventArgs e)
        {
            Stop();
            Application.Exit();
        }

        private void Stop()
        {
            if (listener != null)
            {
                listener.Stop();
                listener.Close();
            }
            if (listenThread != null)
            {
                listenThread.Abort();
            }
        }

        void NotifyForm_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                this.notifyIcon.Visible = true;
                this.notifyIcon.ShowBalloonTip(500);
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                this.notifyIcon.Visible = false;
            }
        }

        void NotifyForm_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }
    }
}
