using System.Text.Unicode;
using SpreedlyModel = Com.Hopper.Hts.Airlines.Spreedly.Model;

namespace Example
{

    public class TestSecrets
    {    
        // Spreedly access credentials
        public static string SpreedlyEnvironmentKey = "????";
        public static string SpreedlyAccessToken = "????";

        // Access token from Auth0
        public static string HtsfaAccessToken = "????";

        // Follow these instructions to retrieve an RSA key from spreedly: https://developer.spreedly.com/reference/generate-certificates
        public static SpreedlyModel.Encryption Encryption = new SpreedlyModel.Encryption {
            CertificateToken = "????",
            PublicKey = "????"
        };
    }
}