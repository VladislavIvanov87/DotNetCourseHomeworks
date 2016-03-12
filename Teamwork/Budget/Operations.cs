namespace Budget
{
    using System;
    using System.Collections.Generic;
    using System.IO;


    public class Operations
    {
        public const string FilePath = @"C:\Users\Vlado\Desktop\SIPartTwo\Expenses.txt";

        public static List<Info> TakeInfoFromTheBase()
        {
            var listOfInformation = new List<Info>();
            using (StreamReader reader = new StreamReader(Operations.FilePath))
            {
                var line = reader.ReadLine();
                while (line != null)
                {
                    var currentInfo = line.Split('|');
                    var infoForProduct = new Info(
                        DateTime.Parse(currentInfo[0].Trim()),
                        currentInfo[1].Trim(),
                        double.Parse(currentInfo[2].Trim()));
                    listOfInformation.Add(infoForProduct);
                    line = reader.ReadLine();
                }
                return listOfInformation;
            }
        }

        public static bool AddInfo(Info infoToAdd)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(Operations.FilePath, true))
                {
                    writer.WriteLine(infoToAdd);
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}