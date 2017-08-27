namespace SystemSmartHouse
{
    public interface IResource
    {
        void CheckState();
        void MakeRequest();
        void DistributeResource();


    }
}