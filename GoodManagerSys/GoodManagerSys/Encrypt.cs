using System.Security.Cryptography;

public class Encrypt {
    public static string GetMD5(string password) {
        MD5 md5 = new MD5CryptoServiceProvider();
        byte[] fromData = System.Text.Encoding.Default.GetBytes(password);
        byte[] targetData = md5.ComputeHash(fromData);
        string byte2String = null;
        for (int i = 0; i < targetData.Length; i++) {
            byte2String += targetData[i].ToString("X2");
        }
        return byte2String;
    }
}
