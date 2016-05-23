namespace Mobile.Services
{
    public class SystemSettings
    {
        public string GetWcfServicesRoot()
        {
            return System.Configuration.ConfigurationManager.AppSettings["CascadeHrEndPointRoot"].ToString();
        }

    }
}
