using System.Collections.Generic;

class noteService
{
    public Dictionary<int, List<string>> Notes = new Dictionary<int, List<string>>();

    public void addNote(int userID, string note)
    {
        if (!Notes.ContainsKey(userID))
            Notes[userID] = new List<string>();

        Notes[userID].Add(note);
    }

    public List<string> getNote(int userID) 
    {
        return Notes[userID];
    }
}