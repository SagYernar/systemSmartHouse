using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Text;

namespace SystemSmartHouse
{
    public class ServiceController :IController
    {
        public bool Signal { get; set; }

        public void SendMessage(string command)
        {
            try
            {
                WebRequest request = WebRequest.Create("http://10.2.7.65"+command);
            }            catch (WebException ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public void ReceiveMessage()
        {
            UdpClient receivingUdpClient = new UdpClient(5002);

            IPEndPoint RemoteIpEndPoint = null;

            try
            {
               
                while (true)
                {
                    // Ожидание дейтаграммы
                    byte[] receiveBytes = receivingUdpClient.Receive(
                       ref RemoteIpEndPoint);

                    // Преобразуем и отображаем данные
                    string returnData = Encoding.UTF8.GetString(receiveBytes);
                    Console.WriteLine(returnData);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine( "Возникло исключение: " + ex.ToString() + "\n  " + ex.Message);
            }
        }

        public void Handler()
        {
            char key;

            for (;;)
            {
                Console.Clear();
                Console.WriteLine("0-light");
                Console.WriteLine("1-Humidity");
                Console.WriteLine("2-Temperature");
                Console.WriteLine("3-Multimedia");
                Console.WriteLine("4-Back");
                key = Console.ReadKey().KeyChar;
                if (key == '0')
                {
                    //Thread tRec = new Thread(new ThreadStart(ReceiveMessage));
                    for (; ; )
                    {
                        Console.Clear();
                        Console.WriteLine("0-Turn On");
                        Console.WriteLine("1-Turn Off");
                        Console.WriteLine("2-Back");
                        key = Console.ReadKey().KeyChar;
                        
                        if (key == '0')
                        {
                            SendMessage("/$1");
                            //tRec.Start();

                        }
                        else if (key == '1')
                        {
                            SendMessage("/$2");                   
                            //tRec.Start();
                        }
                        else if (key == '2')
                        {
                            Console.Clear();
                            break;
                        }
                    }
                }
                else if (key == '1')
                {
                    //Thread tRec = new Thread(new ThreadStart(ReceiveMessage));
                    for (; ; )
                    {
                        Console.Clear();
                        Console.WriteLine("0-Increase");
                        Console.WriteLine("1-Decrease");
                        Console.WriteLine("2-Back");
                        key = Console.ReadKey().KeyChar;
                        if (key == '0')
                        {
                            SendMessage("$1");
                            
                            //tRec.Start();
                        }
                        else if (key == '1')
                        {
                            SendMessage("$2");
                            
                            //tRec.Start();
                        }
                        else if (key == '2')
                        {
                            Console.Clear();
                            break;
                        }
                    }
                }
                else if (key == '2')
                {
                    for (; ; )
                    {
                        Console.Clear();
                        Console.WriteLine("0-Increase");
                        Console.WriteLine("1-Decrease");
                        Console.WriteLine("2-Back");
                        key = Console.ReadKey().KeyChar;
                        if (key == '0')
                        {
                            SendMessage("Increase Temperature");
                        }
                        else if (key == '1')
                        {
                            SendMessage("Decrease Temperature");
                        }
                        else if (key == '2')
                        {
                            Console.Clear();
                            break;
                        }
                    }
                }
                else if (key == '3')
                {
                    for (; ; )
                    {
                        Console.Clear();
                        Console.WriteLine("0-Video Monitoring");
                        Console.WriteLine("1-Speakers");
                        Console.WriteLine("2-Back");
                        key = Console.ReadKey().KeyChar;
                        if (key == '0')
                        {
                            for (; ; )
                            {
                                Console.Clear();
                                Console.WriteLine("0-First Camera");
                                Console.WriteLine("1-Second Camera");
                                Console.WriteLine("2-Back");
                                key = Console.ReadKey().KeyChar;
                                if (key == '0')
                                {
                                    SendMessage("Show First Camera");
                                }
                                else if (key == '1')
                                {
                                    SendMessage("Show Second Camera");
                                }
                                else if (key == '2')
                                {
                                    Console.Clear();
                                    break;
                                }
                            }
                        }
                        else if (key == '1')
                        {
                            for (; ; )
                            {
                                Console.Clear();
                                Console.WriteLine("0-Turn On");
                                Console.WriteLine("1-Turn Off");
                                Console.WriteLine("2-Turn Up");
                                Console.WriteLine("3-Turn Down");
                                Console.WriteLine("4-Back");
                                key = Console.ReadKey().KeyChar;
                                if (key == '0')
                                {
                                    SendMessage("Turn On Speakers");
                                }
                                else if (key == '1')
                                {
                                    SendMessage("Turn Off Speakers");
                                }
                                else if (key == '2')
                                {
                                    SendMessage("Turn Up Speakers");
                                }
                                else if (key == '3')
                                {
                                    SendMessage("Turn Down Speakers");
                                }
                                else if (key == '4')
                                {
                                    Console.Clear();
                                    break;
                                }
                            }
                        }
                        else if (key == '2')
                        {
                            Console.Clear();
                            break;
                        }
                    }
                }
                else if (key == '4')
                {
                    Console.Clear();
                    break;
                }
            }
        }
    }
}