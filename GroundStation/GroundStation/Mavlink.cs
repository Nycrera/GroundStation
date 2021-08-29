using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GroundStation
{
    public class Mavlink
    {
        public String ReceivedString;
        //public String ReceivedStringSAVED;
        public String LastSendedTelemetry;
        public char[] MARKERS = { '>', '<', '\n' };
        public Regex pattern = new Regex("[<>]");

        public String COMMAND = "0";
        public List<String> COMMAND_QUEUE = new List<String>();


        public static UdpClient CLIENT = new UdpClient(3333);
        //public static IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Parse("192.168.1.102"), 3333); // 22 idi ip
        public static IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Parse("192.168.1.101"), 3333); // 22 idi ip
        //public static IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 3333);

        public static bool VIDEO_SIZE_SENDED = false;
        public int VIDEO_SIZE = 1000000; // 10 000 Byte

        public string VIDEO_BYTE = "111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111"; // 200 Byte
        public static bool VIDEO_SENDING_ACTIVE = false;
        public static bool VIDEO_SENDING_COMPLETED = false;

        public static bool SENDING_PERMISSION = false;
        public static bool MissingTelemetry = false;

        public static Stopwatch timePassedWatch = new Stopwatch();
        // Amaç , Data gonderdikten sonra veya command, bir yanıt gelmedi ise;
        // M C veya VS , veya V gonderdikten sonra ozellikle, Yanıt gelmediyse belirlenen sure içerisinde
        // Timer Tick etsin. ve datayı tekrar gondersin.

        public static int SENDED_BYTE = 0;
        public static int REACHED_BYTE = 0;

        public static int INCREASED_TIMES = 1;

        public string[] Splitted_Telemetry;
        private Form mainForm;
        private Label REACHED_VIDEO_LABEL;
        private Label SENDED_BYTE_LABEL;
        private Timer PermissionTimer;
        private Label TOTAL_PACK;
        private Label TRANSFER_STATUS;

        

        EventHandler UpdateDataCallback;

        public Mavlink(Form mainForm, EventHandler UpdateDataCallback, Label SENDED_BYTE_LABEL, Label REACHED_VIDEO_LABEL,
            Timer PermissionTimer, Label TOTAL_PACK, Label TRANSFER_STATUS)
        {
            TextBox.CheckForIllegalCrossThreadCalls = false;
            this.mainForm = mainForm;
            this.UpdateDataCallback = UpdateDataCallback;
            this.SENDED_BYTE_LABEL = SENDED_BYTE_LABEL;
            this.REACHED_VIDEO_LABEL = REACHED_VIDEO_LABEL;
            this.PermissionTimer = PermissionTimer;
            this.TOTAL_PACK = TOTAL_PACK;
            this.TRANSFER_STATUS = TRANSFER_STATUS;

            Console.WriteLine(VIDEO_SIZE);
            SENDED_BYTE_LABEL.Text = SENDED_BYTE.ToString() + " Byte Transferred";
            REACHED_VIDEO_LABEL.Text = REACHED_BYTE.ToString() + " Byte Received";
            
        }

        public void SetVideoData(int size, string data)
        { // Added extra, sets the video data, used by the main form.
            VIDEO_SIZE = size;
            VIDEO_BYTE = data;
        }
        public void Connect_Event(object sender, EventArgs e)
        {
            string MY_STRING = "S";
            byte[] WILL_SEND = Encoding.ASCII.GetBytes(MY_STRING);
            CLIENT.Send(WILL_SEND, WILL_SEND.Length, RemoteIpEndPoint);
            CLIENT.BeginReceive(new AsyncCallback(DataRECV_EVENT), null);
            Console.WriteLine("Sending Start Byte!");
        }

        public void setIP(string IP)
        {
            RemoteIpEndPoint = new IPEndPoint(IPAddress.Parse(IP), 3333);
        }

        public void setLastSendedTelemetry(String LASTWRITED)
        {
            LastSendedTelemetry = LASTWRITED;
        }

        public void DataRECV_EVENT(IAsyncResult res)
        {
            byte[] received = CLIENT.EndReceive(res, ref RemoteIpEndPoint);
            ReceivedString = Encoding.UTF8.GetString(received);
            //ReceivedString = serialPort1.ReadLine();
            //serialPort1.DiscardInBuffer();
            ReceivedString = ReceivedString.Replace("\n", string.Empty).Replace("\r", string.Empty); // Removed "\n" , "\r"
            if (ReceivedString.StartsWith("<")) // Telemetri)
            {
                ReceivedString = pattern.Replace(ReceivedString, ""); // Removed  "<" , ">" 
                Console.WriteLine($"Telemetri came {ReceivedString}");
                Splitted_Telemetry = ReceivedString.Split(',');

                if (SENDING_PERMISSION && MissingTelemetry) // SENDING PERMISSION VARSA INTERVAL COKTAN GELMIS DEMEKTIR
                                                            // VE HATALI PAKET GELDI KI MISSINGTELEMETRY OLMUS BU YUZDEN INVOK EDEBEILIRIZ.
                {
                    mainForm.Invoke(new EventHandler(checkTelemetries));
                    //checkTelemetries();
                }
                //checkTelemetries();

            }
            else if (ReceivedString.StartsWith("I"))
            {

                Console.WriteLine($"Interval Came! {ReceivedString}");
                //this.Invoke(new EventHandler(SetInterval));
                // System.Threading.Thread.Sleep(5);
                mainForm.Invoke(new EventHandler(SetInterval));
                //SetInterval();
            }
            else if (ReceivedString.StartsWith("V"))
            {
                string[] splitted_STR = ReceivedString.Split(' ');
                if (splitted_STR[0].ToString() == "VS")
                {
                    Console.WriteLine($"VS BILGISI CAME {ReceivedString}");
                    String VS_REACHED = splitted_STR[1];
                    if (VS_REACHED == "1")
                    {
                        VIDEO_SIZE_SENDED = true; // SENDED SUCESSFULLY.
                        VIDEO_SENDING_ACTIVE = true;
                        timePassedWatch.Start();
                    }
                    //VIDEO_SEND_PROCESSING(); // IF SENDED OR NOT, DOESNT MATTER , GO TO THE FUNCTION,
                    // IF VS SENDED SEND VBINARY , IF NOT , SEND VS AGAIN.
                    mainForm.Invoke(new EventHandler(VIDEO_SEND_PROCESSING));
                    //VIDEO_SEND_PROCESSING();
                }
                else if (splitted_STR[0].ToString() == "V")
                {
                    Console.WriteLine(ReceivedString);

                    String V_REACHED = splitted_STR[1].ToString();
                    if (V_REACHED == "3")
                    {
                        VIDEO_SENDING_COMPLETED = true;
                        VIDEO_SENDING_ACTIVE = false;
                        REACHED_BYTE += VIDEO_BYTE.Length;
                        REACHED_VIDEO_LABEL.Text = REACHED_BYTE.ToString() + " Byte Received";
                        Console.WriteLine($"INCREASED TIMES _-------------> {INCREASED_TIMES}");
                        timePassedWatch.Stop();
                        Console.WriteLine($"TOTAL TIME TO REACH ALL BYTES {timePassedWatch.ElapsedMilliseconds}");
                    }
                    else if (!VIDEO_SENDING_COMPLETED)
                    {
                        if (V_REACHED == "1")
                        {
                            /* 
                                    INCREASE INDEX OF ARRAY. YENI STRINGE ATA ARRAYDAKI VALUEYI
                                    ORNEK :  array = [1,1,1,1,0,1]
                                    // indx = 40        
                                    // 111111111111111111111111
                                    // 000000000000000000000000
                            // array[0:first] , [first : first+40]
                                    VIDEO_BYTE =  array[FIRST_IDX : LAST_IDX].T oString() gibisinden..
                                */
                            INCREASED_TIMES += 1;
                            REACHED_BYTE += VIDEO_BYTE.Length;
                            REACHED_VIDEO_LABEL.Text = REACHED_BYTE.ToString() + " Byte Received";
                        }
                        else
                        {
                            Console.WriteLine("NOTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT");
                        }
                        // ELSE GEREK YOK ZATEN YUKARIDA IF'E GIREMDIGI ICIN INDEX FALN ARTMAYCAK.. OTOYINE
                        // AYNI VIDEO BYTE OLMUS OLACAK.
                        //System.Threading.Thread.Sleep(5);
                        //VIDEO_SEND_PROCESSING();
                        mainForm.Invoke(new EventHandler(VIDEO_SEND_PROCESSING));
                    }
                }
                //CLIENT.BeginReceive(new AsyncCallback(DataRECV_EVENT), null);
            }
            else if (ReceivedString.StartsWith("E"))
            {
                Console.WriteLine("------------COMM ENDED SIGNAL---------");
                SENDING_PERMISSION = false;
                MissingTelemetry = false;
                //PermissionTimer.Stop();
            }

            else
            {
                Console.WriteLine(ReceivedString);
            }

            CLIENT.BeginReceive(new AsyncCallback(DataRECV_EVENT), null);
        }

        public void SetInterval(object sender, EventArgs e) // object sender , EventArgs e 
        {
            Console.WriteLine($"RECEIVEDSTR {ReceivedString}"); // INTERVAL -50
            int INTERVAL = int.Parse(ReceivedString.Split(' ')[1].ToString());
            Console.WriteLine($"INTERVAL SETTED TO {INTERVAL - 45}"); // INTERVAL -50
            PermissionTimer.Interval = INTERVAL - 45;                 // INTERVAL -50
            PermissionTimer.Stop();
            PermissionTimer.Start();
            SENDING_PERMISSION = true;
            Console.WriteLine("PERMISSION IS GIVEN...");
            mainForm.Invoke(new EventHandler(checkTelemetries));
            //checkTelemetries();
            //if (VIDEO_SENDING_ACTIVE && !VIDEO_SENDING_COMPLETED)
            //{
            //    this.Invoke(new EventHandler(VIDEO_SEND_PROCESSING));
            //}
        }
        public void checkTelemetries(object sender, EventArgs e) //object sender, EventArgs e
        {
            //ReceivedStringSAVED = ReceivedString; // WE COPIED IT. (Another Event can be trigger Thats why.)
            //string[] Splitted_Telemetry = ReceivedStringSAVED.Split(',');
            if (Splitted_Telemetry.Length != 17)
            {
                Console.WriteLine("MISISNG_TEL??");
                MissingTelemetry = true;
                //COMMAND_QUEUE_REQUEST();
                mainForm.Invoke(new EventHandler(COMMAND_QUEUE_REQUEST));
                //COMMAND_QUEUE.Remove(COMMAND_QUEUE.ElementAt(0));
                if (SENDING_PERMISSION)
                {
                    byte[] SENDED = Encoding.ASCII.GetBytes($"M {COMMAND}");
                    CLIENT.Send(SENDED, SENDED.Length, RemoteIpEndPoint);
                }
            }
            else
            {
                MissingTelemetry = false;
                TOTAL_PACK.Text = Splitted_Telemetry[1];
                TRANSFER_STATUS.Text = "Status: " + Splitted_Telemetry[16];
                Console.WriteLine("No missing Telemetries Checking videos and etc..");
                if (VIDEO_SENDING_ACTIVE && !VIDEO_SENDING_COMPLETED)
                {
                    Console.WriteLine("Videos IDENTIFIED ..");
                    //VIDEO_SEND_PROCESSING();
                    mainForm.Invoke(new EventHandler(VIDEO_SEND_PROCESSING));
                }
                else
                {
                    if (SENDING_PERMISSION)
                    {
                        //COMMAND_QUEUE_REQUEST();
                        mainForm.Invoke(new EventHandler(COMMAND_QUEUE_REQUEST));
                        if (COMMAND_QUEUE.Count > 0)
                        {
                            COMMAND_QUEUE.Remove(COMMAND_QUEUE.ElementAt(0));
                        }
                        string testStr = $"N {COMMAND}";
                        //byte[] SENDED = Encoding.ASCII.GetBytes($"N {COMMAND}");
                        byte[] SENDED = Encoding.ASCII.GetBytes(testStr);
                        CLIENT.Send(SENDED, SENDED.Length, RemoteIpEndPoint);

                    }
                }
                //UpdateDataCallback(); // Ping the main form so that it can update itself with the new arrived data , the public Splitted_Telemetry[].
                mainForm.Invoke(new EventHandler(UpdateDataCallback));
            }


        }

        public void Manual_Motor_Always_Click(object sender, EventArgs e)
        {
            COMMAND_QUEUE.Add("99");
        }

        public void COMMAND_QUEUE_REQUEST(object sender, EventArgs e) // NO EVENT INTHERE NORMALLY.
        {
            if (COMMAND_QUEUE.Count() == 0)
            {
                COMMAND = "0";
            }
            else
            {
                COMMAND = COMMAND_QUEUE.ElementAt(0);
                //COMMAND_QUEUE.Remove(COMMAND_QUEUE.ElementAt(0));
            }
        }

        public void TenSecond_Active_Click(object sender, EventArgs e)
        {
            COMMAND_QUEUE.Add("77");
        }

        public void Manual_Release_Click(object sender, EventArgs e)
        {
            COMMAND_QUEUE.Add("88");
        }

        public void SEND_VIDEO_Click(object sender, EventArgs e)
        {
            VIDEO_SENDING_ACTIVE = true;
            //VIDEO_SEND_PROCESSING();
            mainForm.Invoke(new EventHandler(VIDEO_SEND_PROCESSING));
            //VIDEO_SEND_PROCESSING();
        }
        public void VIDEO_SEND_PROCESSING(object sender, EventArgs e) // object sender, EventArgs e
        {
            //COMMAND_QUEUE_REQUEST();
            mainForm.Invoke(new EventHandler(COMMAND_QUEUE_REQUEST));

            if (COMMAND_QUEUE.Count > 0)
            {
                COMMAND_QUEUE.Remove(COMMAND_QUEUE.ElementAt(0));
            }
            //serialPort1.DiscardOutBuffer();
            if (!VIDEO_SIZE_SENDED && SENDING_PERMISSION)
            {

                Console.WriteLine($"VS {COMMAND} {VIDEO_SIZE.ToString().Length} {VIDEO_SIZE}");
                byte[] SENDED = Encoding.ASCII.GetBytes($"VS {COMMAND} {VIDEO_SIZE.ToString().Length} {VIDEO_SIZE}");
                CLIENT.Send(SENDED, SENDED.Length, RemoteIpEndPoint);
            }
            else
            {

                if (!VIDEO_SENDING_COMPLETED && SENDING_PERMISSION && VIDEO_SENDING_ACTIVE) //VIDEO_SENDING_ACTIVE ADDED.
                {

                    Console.WriteLine($"V {COMMAND} {VIDEO_BYTE.Length} {VIDEO_BYTE}");
                    //serialPort1.Write($"<V {COMMAND} {VIDEO_BYTE.Length} {VIDEO_BYTE}>");
                    byte[] SENDED = Encoding.ASCII.GetBytes($"V {COMMAND} {VIDEO_BYTE.Length} {VIDEO_BYTE}");
                    CLIENT.Send(SENDED, SENDED.Length, RemoteIpEndPoint);
                    //serialPort1.Write(CHAR_ARRAY, 0, CHAR_ARRAY.Length);

                    //for (int i = 0; i < 50; i++)
                    //{
                    //    serialPort1.Write("1");
                    //}
                    //serialPort1.Write(">");
                    SENDED_BYTE += VIDEO_BYTE.Length;
                    SENDED_BYTE_LABEL.Text = SENDED_BYTE.ToString() + " Byte Transferred";
                }
            }
        }

        public void Permission_OVER_EVENT(object sender, EventArgs e)
        {
            Console.WriteLine("PERMİSSİON OVER.!!!!!!!!!!!!!!!!!!!");
            SENDING_PERMISSION = false;
            PermissionTimer.Stop();
            MissingTelemetry = false;
        }
    }
}
