namespace SystemSmartHouse
{
    public interface IGeneralService
    {
        int NumberOfService { get; set; }
        GeneralService RegistryService();
        void DeleteService();
        ServiceController Controller
        {
            get;
        }
        ServiceResource Resource
        {
            get;
        }
    }
}