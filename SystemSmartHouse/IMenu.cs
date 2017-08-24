namespace SystemSmartHouse
{
    public interface IMenu
    {
        void SetCommand(int command);

        int GetCommand();

        void Handler();
    }
}