namespace Module_9_1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                Console.WriteLine("Блок try начался");
                Method2();
            }
            catch (Exception ex) when (ex is ArgumentNullException)
            {
                Console.WriteLine("Аргумент пустой");
            }
            catch (Exception ex) when (ex is FileNotFoundException) 
            {
                Console.WriteLine("Файл не найден");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace.ToString());
            }
            finally
            {
                Console.WriteLine("Блок finally сработал!");
            }
        }

        static void Method1()
        {
            try 
            {
                throw new Exception("Внутреннее исключение");
            }
            catch (Exception)
            {
                throw;
            }
        }
        static void Method2()
        {
            try
            {
                Method1();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}