namespace SystemSmartHouse
{
    public interface IController

    {
        bool Signal { get; set; }
        void Handler();
        void SendMessage(string obj);
        string ReceiveMessage();
    }
}