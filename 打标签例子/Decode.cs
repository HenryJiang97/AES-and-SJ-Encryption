using System;
using System.Security.Cryptography;
using System.Text;
using System.IO;

//str: 要解密的字符串， key：密钥
public static string AesDecrypt(string str, string key)
{
    if (string.IsNullOrEmpty(str)) return null;
    Byte[] toEncryptArray = Convert.FromBase64String(str);

    System.Security.Cryptography.RijndaelManaged rm = new System.Security.Cryptography.RijndaelManaged
    {
        Key = Encoding.UTF8.GetBytes(key),
        Mode = System.Security.Cryptography.CipherMode.ECB,
        Padding = System.Security.Cryptography.PaddingMode.PKCS7
    };

    System.Security.Cryptography.ICryptoTransform cTransform = rm.CreateDecryptor();
    Byte[] resultArray = cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);

    return Encoding.UTF8.GetString(resultArray);

}

print(AesDecrypt("1cRJzFAemxivBV+7d9CTNYl+wa9tTEnaPrmUAQGt5Kk=", "abcdef0123456789"));