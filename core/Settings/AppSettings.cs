

namespace core.Settings
{
    public class AppSettings
    {
        public bool HttpsRedirection { get; set; }
        // public ConnectionString ConnectionString { get; set; }
        // public EmailSettings EmailSettings { get; set; }
        // public TokenSettings TokenSettings { get; set; }
        // public CryptographySettings CryptographySettings { get; set; }
        public string ApplicationName => Assembly.GetEntryAssembly().GetName().Name;
        // public BaseUrlSettings BaseUrlSettings { get; set; }
    }
}