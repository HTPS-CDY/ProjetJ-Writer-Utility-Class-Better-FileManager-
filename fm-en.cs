namespace FileManagerTools
{
    class FileWriter
    {
        public static void AppendWrite(string file, string message)
        {
            using (StreamWriter writer = new StreamWriter(file, true))
            {
                writer.WriteLine(message);
            }
        }
        public static void OverwriteWrite(string file, string message)
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.WriteLine(message);
            }
        }
    }


    class FileReader
    {
        public static List<string> ReadToList(string file)
        {
            try
            {
                List<string> lines = new List<string>();
                using (StreamReader reader = new StreamReader(file))
                {
                    string? line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        lines.Add(line);
                    }
                }
                return lines;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
                return new List<string>();
            }
        }
        public static void ReadAndPrint(string file)
        {
            try
            {
                using (StreamReader reader = new StreamReader(file))
                {
                    string? line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading file: {ex.Message}");
            }
        }
    }

    class FileCreator
    {
        public static void CreateFile(string file)
        {
            File.WriteAllText(file, "");
        }
        public static void CreateUniqueFile(string file)
        {
            Random random = new Random();
            int num1 = random.Next(10000, 65535);
            int num2 = random.Next(0, 10000);
            File.WriteAllText($"{num2}_{num1}_{file}", "");
        }
    }
}