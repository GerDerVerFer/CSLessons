using System;

public class Decorator
{
    static void decorator()
    {
        EncryptionNoteService ens = new EncryptionNoteService();

        ens.addNote(1, ens.Encrypt("Test"));
        var notes = ens.getNote(1);

        Console.WriteLine(ens.Decrypt(notes[0]));
    }
    public static void Run()
    {
        decorator();
    }
}