using System.Collections.Generic;

interface INoteService
{
    void addNote(int uid, string note);
    List<string> getNote(int uid);
}
