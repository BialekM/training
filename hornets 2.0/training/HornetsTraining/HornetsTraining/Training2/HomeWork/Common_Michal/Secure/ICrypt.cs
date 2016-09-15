namespace HornetsTraining.Training2.HomeWork.Common_Michal.Secure
{
    public interface ICrypt
    {
        string Encrypt(string plainText);
        string Decrypt(string cipherText);
    }
}