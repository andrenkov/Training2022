using static System.Console;
using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;
//using Newtonsoft.Json;
using WorkingWithFileSystems;
using System.Text.Json;
using System.Text.Json.Serialization;



#region Dirs and Drives Info
//OutputFileSystemInfo();
//WorkingWithDrives();

//static void OutputFileSystemInfo()
//{
//    WriteLine("{0,-33} {1}", arg0: "Path.Separator", arg1: PathSeparator);
//    WriteLine("{0,-33} {1}", arg0: "Path.DirectorySeparatorChar", arg1: DirectorySeparatorChar);
//    WriteLine("{0,-33} {1}", arg0: "Directory.GetCurrentDirectory", arg1: GetCurrentDirectory());
//    WriteLine("{0,-33} {1}", arg0: "Environment.SystemDirectory", arg1: SystemDirectory);
//}

//static void WorkingWithDrives()
//{
//    foreach (DriveInfo drive in DriveInfo.GetDrives())
//    {
//        WriteLine("{0,-30} | {1,-10} | {2,18:N0}", drive.Name, drive.DriveType, drive.TotalSize);
//    }
//}

#endregion

#region Files

WorkingWithFiles();

static void WorkingWithFiles()
{
    //string dir = Combine(GetFolderPath(SpecialFolder.Personal), "code", "chapter09", "outputfiles");
    //CreateDirectory(dir);

    ////create files
    //string textFile = Combine(dir, "dummer.txt");
    //string backupFile = Combine(dir, "dummer.bak");
    //WriteLine($"Working with : {textFile}");
    //WriteLine($"File exists? {File.Exists(textFile)}");

    ////write into file
    //StreamWriter textWriter = new StreamWriter(textFile);
    //textWriter.WriteLine("Hi Vladimir");
    //textWriter.Close();

    ////copy files
    //File.Copy(sourceFileName: textFile, destFileName: backupFile, overwrite: true);

    ////delete file
    //File.Delete(textFile);

    ////read from file
    //WriteLine($"Reading the backup file {backupFile}");
    //StreamReader textReader = new StreamReader(backupFile);
    //WriteLine(textReader.ReadToEnd());
    //textReader.Close();

    ////cleanup
    ////delete file
    ////File.Delete(backupFile);

    ////Parts of the Path
    //GetDirectoryName(backupFile);
    //GetFileName(backupFile);
    //GetFileNameWithoutExtension(backupFile);
    //GetExtension(backupFile);
    //string s = GetRandomFileName();
    //string t = GetTempFileName();

    //WriteLine(s+" "+t);

    ////working with file modes
    //FileStream file = File.Open(backupFile, FileMode.Open, FileAccess.ReadWrite, FileShare.Read);
    //FileInfo fileInfo = new FileInfo(backupFile);
    //WriteLine("File compressed: " + fileInfo.Attributes.HasFlag(FileAttributes.Compressed));

    ////XML
    //FileStream xmlFileStream = File.Create(backupFile);
    //XmlWriter xml = XmlWriter.Create(xmlFileStream, new XmlWriterSettings { Indent = true });
    //try
    //{
    //    xml.WriteStartDocument();
    //    //write root
    //    xml.WriteStartElement("root_name");
    //    //write element
    //    xml.WriteElementString("tag_name", "tag_value");

    //    xml.Close();
    //    xmlFileStream.Close();
    //}
    //catch
    //{ 
    //    xml.Dispose();
    //    file.Dispose();
    //}

    //further see using GZip or Broti algorithms for xml files compression p.386-388

    #region Encoding

    //WriteLine("Encodings:");
    //WriteLine("[1] ASCII");
    //WriteLine("[2] UTF-7");
    //WriteLine("[3] UTF-8");
    //WriteLine("[4] UTF-16 (Unicode)");
    //WriteLine("[5] UTF-32");
    //WriteLine("[any other key] Default");

    //Write("Press a number to choose an encoding:");
    //ConsoleKey number = ReadKey(intercept: false).Key;

    //WriteLine();

    //Encoding encoder = number switch 
    //{
    //    ConsoleKey.D1 => Encoding.ASCII,
    //    ConsoleKey.D2 => Encoding.UTF7,
    //    ConsoleKey.D3 => Encoding.UTF8,
    //    ConsoleKey.D4 => Encoding.Unicode,
    //    ConsoleKey.D5 => Encoding.UTF32,
    //    _             => Encoding.Default
    //};

    //WriteLine();

    //string message = "My best кофе Arabic $3.62";
    ////encode the string into bytes
    //byte[] encoded = encoder.GetBytes(message);
    ////enum each byte
    //WriteLine($"BYTE HEX CHAR");
    //foreach (byte b in encoded)
    //{
    //    Write($"{b,4} {b.ToString("X"),4} {(char)b,5}");
    //}

    ////decode
    //string decoded = encoder.GetString(encoded);
    //WriteLine(decoded);

    #endregion

    //see p.394 for serialization and Xml

}

#endregion

#region Json

//read
//https://docs.microsoft.com/en-us/dotnet/standard/serialization/system-text-json-migrate-from-newtonsoft-how-to?pivots=dotnet-6-0

WorkingWithJson();

async void WorkingWithJson()
{
    #region JsonSerializer
    //List<cactus> cacti = new()
    //{
    //    new cactus("astro", 1),
    //    new cactus("copiapoa", 2),
    //    new cactus("notocactus", 3)
    //};

    string jsonPath = Combine(CurrentDirectory, "cacti.json");
    //using (StreamWriter jsonStream = File.CreateText(jsonPath))
    //{

    //    //create object for formatting to json
    //    JsonSerializer jss = new();

    //    //serialize object into string
    //    jss.Serialize(jsonStream, cacti);

    //    jsonStream.Flush();
    //}

    //WriteLine();
    //WriteLine(File.ReadAllText(jsonPath));

    #region another approach
    //using (var stream = new MemoryStream())
    //using (var reader = new StreamReader(stream))
    //using (var writer = new StreamWriter(stream))
    //using (var jsonWriter = new JsonTextWriter(writer))
    //{
    //    new JsonSerializer().Serialize(jsonWriter, new { name = "Jamie" });

    //    jsonWriter.Flush();
    //    stream.Position = 0;

    //    WriteLine("stream contents: (" + reader.ReadToEnd() + ")");
    //}
    #endregion

    #endregion

    #region Deserialize

    #region Newsoft
    //using (StreamReader file = File.OpenText(jsonPath))
    //{
    //    JsonSerializer serializer = new();
    //    List<cactus>? cactiLoaded = (List<cactus>?)serializer.Deserialize(file, typeof(List<cactus>));

    //    if (cactiLoaded is not null)
    //    {
    //        foreach (cactus cactus in cactiLoaded)
    //        {
    //            WriteLine($"Species : {cactus.SpeciesName,-20} Cat num: {cactus.CatNum,5}");
    //        }
    //    }
    //}
    #endregion

    #region System.Text.Json
    using (StreamReader file = File.OpenText(jsonPath))
    {
        var options = new JsonSerializerOptions
        {
            AllowTrailingCommas = true
        };
        List<cactus>? cactiLoaded = JsonSerializer.Deserialize<List<cactus>>(file.ReadToEnd(), options);
        if (cactiLoaded is not null)
        {
            foreach (cactus cactus in cactiLoaded)
            {
                WriteLine($"Species : {cactus.SpeciesName,-20} Cat num: {cactus.CatNum,5}");
            }
        }
    }
    #endregion


    #endregion
}

#endregion