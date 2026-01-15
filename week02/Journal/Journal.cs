using System.IO;

public class Journal
{
    public List<Entry> Entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        Entries.Add(entry);
    }

    public void DisplayJournal()
    {
        foreach (Entry entry in Entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))


        {
            foreach (Entry entry in Entries)
            {
                writer.WriteLine($"{entry._date}|{entry._prompt}|{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        Entries.Clear();

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            Entry entry = new Entry(parts[0], parts[1], parts[2]);
            Entries.Add(entry);
        }
    }
}
