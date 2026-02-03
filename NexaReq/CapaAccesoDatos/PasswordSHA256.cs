using System.Security.Cryptography;
using System.Text;

namespace CapaAccesoDatos
{
    public class PasswordSHA256
    {
        public static string GetSha256(string pass)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] bytes = null;
            StringBuilder PassHash = new StringBuilder();
            bytes = sha256.ComputeHash(encoding.GetBytes(pass));

            for (int i = 0; i < bytes.Length; i++)
            {
                PassHash.AppendFormat("{0:x2}", bytes[i]);
            }
            return PassHash.ToString();
        }
    }
}
