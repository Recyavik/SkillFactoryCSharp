namespace Module_9_1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                Console.WriteLine("Блок try начался");
                // throw new FileNotFoundException();
            }
            catch (Exception ex) when (ex is ArgumentNullException)
            {
                Console.WriteLine("Аргумент пустой");
            }
            catch (Exception ex) when (ex is FileNotFoundException) 
            {
                Console.WriteLine("Файл не найден");
            }
            finally
            {
                Console.WriteLine("Блок finally сработал!");
            }

        }
    }
}