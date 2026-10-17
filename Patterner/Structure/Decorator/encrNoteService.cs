
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

public class EncryptionNoteService : INoteService
{

    public noteService ns;
    private RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(1024);


    public string Encrypt(string msg)
    {
        byte[] plainBytes = System.Text.Encoding.UTF8.GetBytes(msg);
        var result = rsa.Encrypt(plainBytes, false);
        return Convert.ToBase64String(result);
    }

    public string Decrypt(string msg)
    {
        byte[] encryptedData = System.Text.Encoding.UTF8.GetBytes(msg);
        byte[] decryptedBytes = rsa.Decrypt(encryptedData, false);

        return System.Text.Encoding.UTF8.GetString(decryptedBytes);

    }

    public List<string> getNote(int id)
    {
        return ns.getNote(id).Select(x => Decrypt(x)).ToList();

    }

    public void addNote(int id, string note)
    {
        string encryptednote = Encrypt(note);
        this.ns.addNote(id, encryptednote);
    }
}
