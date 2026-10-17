using System.Collections.Generic;

class Folder
{
    public string Name;
    public string Path; 
    public List<File> files = new List<File>();
    public List<Folder> folders = new List<Folder>();    

    public int getSize()
    {
        int sum = 0;
        foreach (var file in files)
        {
            sum += file.Size;
        }
        foreach (var folder in folders)
        {
            foreach (var file in folder.files)
            {
                sum += file.Size;
            }
        }

        
        return sum;
    }
}