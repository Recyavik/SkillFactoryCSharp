namespace Module_8_4_1
{
    internal class Program
    {
        const string SettingsFileName = @"E:\Develop\C#\SkillFactoryCSharp\SkillFactoryCSharp\Module_8_4_1\BinaryFile.bin";
        static void Main(string[] args)
        {
            // Считываем
            ReadValues();
            WriteValues();
        }
       static void WriteValues()
        {
            // Создаем объект BinaryWriter и указываем, куда будет направлен поток данных
            using (BinaryWriter writer = new BinaryWriter(File.Open(SettingsFileName, FileMode.Create)))
            {
                // записываем данные в разном формате
                writer.Write($"Файл изменен {DateTime.Now} на компьютере с ОС {Environment.OSVersion}");
            }
        }

        static void ReadValues()
        {
            string DataValue;
            if (File.Exists(SettingsFileName))
            {
                // Создаем объект BinaryReader и инициализируем его возвратом метода File.Open.
                using (BinaryReader reader = new BinaryReader(File.Open(SettingsFileName, FileMode.Open)))
                {
                    // Применяем специализированные методы Read для считывания соответствующего типа данных.
                    DataValue = reader.ReadString();
                }

                Console.WriteLine("Из файла считано:");
                Console.WriteLine("Дата: " + DataValue);

            }
        }
    }
}