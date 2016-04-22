using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace applicationproject
{
    public partial class Form1 : Form
    {
        TcpClient client = new TcpClient();
        NetworkStream ns;

        public Form1()
        {
            InitializeComponent();
        }

        private void conBut_Click(object sender, EventArgs e)
        {
            try
            {
                client.Connect("13.95.147.25", 48724); //13.95.147.25:48724
                ns = client.GetStream();

                if (client.Connected)
                {
                    listBox1.Items.Add(">> Connection Started...");
                }

            }
            catch (Exception)
            {
                listBox1.Items.Add(">> Connection Failed!");
            }
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[1717];
                    byte[] rfc = new byte[] { 17, 0, 0, 148, 11 };
                    byte[] ack = new byte[] { 17, 0, 16, 148, 11 };


                    ns.Write(rfc, 0, rfc.Length);

                    if (ns.CanRead)
                    {
                        StreamReader bb = new StreamReader(ns);
                        byte[] data = new byte[client.ReceiveBufferSize];
                        dnmBox.Text = bb.ToString();

                        ns.Read(data, 0, (int)client.ReceiveBufferSize);
                        
                    }
                }
                catch (Exception ex)
                {
                    listBox1.Items.Add(ex.ToString());
                    ns.Close();
                    break;
                }

            }
        }

        private void exitBut_Click(object sender, EventArgs e)
        {
            client.Close();
            ns.Close();
            Application.Exit();
        }
    }
}
