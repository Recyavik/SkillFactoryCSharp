namespace Module_10_2_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Writer writer = new Writer();

            ((IWriter)writer).Write();

            Console.ReadKey();
        }
    }

    public class Writer : IWriter
    {
        void IWriter.Write()
        {
            throw new NotImplementedException();
        }
    }

    public interface IWriter
    {
        void Write();
    }
}