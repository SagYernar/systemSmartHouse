namespace SystemSmartHouse
{
    public interface IGeneralService
    {
        int NumberOfService { get; set; }
        GeneralService RegistryService();
        void DeleteService();
        IController Controller
        {
            get;
        }
        IServiceResource Resource
        {
            get;
        }
    }
}