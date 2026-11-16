namespace 文件管理工具
{
    class 写文件
    {
        public static void 追加写入(string file ,string message)
        {
            using (StreamWriter wrt = new StreamWriter(file, true))
            {
                wrt.WriteLine(message);
            }
        }
        public static void 覆盖写入(string file ,string message)
        {
            using (StreamWriter wrt = new StreamWriter(file))
            {
                wrt.WriteLine(message);
            }
        }
    }
    class 读文件
    {
        public static List<string> 列表返回(string file)
        {
            try
            {
            
            List<string> lines = new List<string>();
            using (StreamReader wrr = new StreamReader(file))
            {
                string? line;
                while ((line = wrr.ReadLine())!= null)
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
        public static void 输出返回(string file)
        {
            try
            {
                using (StreamReader wrr = new StreamReader(file))
                {
                    string? line;
                    while ((line = wrr.ReadLine()) != null)
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
    class 创文件
    {
        public static void 创建普通文件(string file )
        {
            File.WriteAllText(file,"");
        }
        public static void 防撞名文件(string file )
        {
            Random random = new Random();
            int i = random.Next(10000,65535);
            int i1 = random.Next(0,10000);
            File.WriteAllText($"{i1}_{i}_{file}","");
        }
    }
    
}
