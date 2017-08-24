namespace SystemSmartHouse
{
    public interface IResource
    {
        bool CheckState();
        void MakeRequest();
        void DistributeResource();


    }
}