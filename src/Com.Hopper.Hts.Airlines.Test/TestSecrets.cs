using SpreedlyModel = Com.Hopper.Hts.Airlines.Spreedly.Model;
using PiiEncryptionModel = Com.Hopper.Hts.Airlines.PiiEncryption.Model;
using Com.Hopper.Hts.Airlines.Client;

namespace Com.Hopper.Hts.Airlines
{

    public class TestSecrets
    {    
        // Spreedly access credentials
        public static string SpreedlyEnvironmentKey = "????";
        public static string SpreedlyAccessToken = "????";

        // Access token from Auth0
        public static string HtsfaAccessTokenThrowaway = "throwaway";

        public static string HtsfaAddress = "????";
        public static string HtsfaApiAddress = HtsfaAddress + "/airline/v1.1/";
        public static string HtsfaAuthAddress = HtsfaApiAddress + "auth";
        public static string HtsfaClientId = "????";
        public static string HtsfaClientSecret = "????";

        public static string SpreedlyCertificateToken = "????";
        public static string SpreedlyPublicKey = "????";

        // Follow these instructions to retrieve an RSA key from spreedly: https://developer.spreedly.com/reference/generate-certificates
        public static SpreedlyModel.Encryption Encryption = new SpreedlyModel.Encryption
        {
            CertificateToken = SpreedlyCertificateToken,
            PublicKey = SpreedlyPublicKey
        };

        // PII Encryption credentials
        public static string PiiEncryptionPartnerName = "????";
        public static string PiiEncryptionPublicKey = "????";

        // PII Encryption instance (mirrors Spreedly.Encryption pattern)
        public static PiiEncryptionModel.PiiEncryption PiiEncryption = new PiiEncryptionModel.PiiEncryption
        {
            PublicKeyPem = PiiEncryptionPublicKey
        };

        public static HopperCredentials Credentials = new HopperCredentials {
            Address = HtsfaAuthAddress,
            ClientId = HtsfaClientId,
            ClientSecret = HtsfaClientSecret,
        };
    }
}