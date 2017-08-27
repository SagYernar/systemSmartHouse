using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SystemSmartHouse
{
    public class ServiceController :IController
    {
        public bool Signal { get; set; }

        public void SendMessage(string obj)
        {
            IPAddress ipAddr = IPAddress.Parse("127.0.0.1");

            try
            {
                // Создаем UdpClient
                UdpClient udpClient = new UdpClient();

                // Соединяемся с удаленным хостом
                udpClient.Connect(ipAddr, 8001);

                // Отправка простого сообщения
                byte[] bytes = Encoding.UTF8.GetBytes(obj);
                udpClient.Send(bytes, bytes.Length);

                // Закрываем соединение
                udpClient.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public string ReceiveMessage()
        {
            UdpClient receiver = new UdpClient(8002); // UdpClient для получения данных
            IPEndPoint remoteIp = null; // адрес входящего подключения
            try
            {
                while (true)
                {
                    byte[] data = receiver.Receive(ref remoteIp); // получаем данные
                    string message = Encoding.Unicode.GetString(data);
                    return message;
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                receiver.Close();
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
                    for (; ; )
                    {
                        Console.Clear();
                        Console.WriteLine("0-Turn On");
                        Console.WriteLine("1-Turn Off");
                        Console.WriteLine("2-Back");
                        key = Console.ReadKey().KeyChar;
                        if (key == '0')
                        {
                            SendMessage("Turn On Light");
                            Console.WriteLine(ReceiveMessage());
                        }
                        else if (key == '1')
                        {
                            SendMessage("Turn Off Light");
                            Console.WriteLine(ReceiveMessage());
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
                        Console.WriteLine("0-Increase");
                        Console.WriteLine("1-Decrease");
                        Console.WriteLine("2-Back");
                        key = Console.ReadKey().KeyChar;
                        if (key == '0')
                        {
                            SendMessage("Increase Humidity");
                            Console.WriteLine(ReceiveMessage());
                        }
                        else if (key == '1')
                        {
                            SendMessage("Decrease Humidity");
                            Console.WriteLine(ReceiveMessage());
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