namespace Module_7_3_3
{
    abstract class ComputerPart
    {   
        public virtual void Description()
        {
            Console.WriteLine("Устройство компьютера неизвестно");
        }
    }
    class Processor : ComputerPart
    {
        public override void Description()
        {
            Console.WriteLine("Устройство - процессор ");
        }
    }
    class MotherBoard : ComputerPart
    {
        public override void Description()
        {
            Console.WriteLine("Устройство - материнская плата ");
        }
    }
    class GraphicCard : ComputerPart
    {
        public override void Description()
        {
            Console.WriteLine("Устройство - видеокарта ");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Processor proc = new Processor();
            MotherBoard mat = new MotherBoard();
            GraphicCard card = new GraphicCard();

            proc.Description();
            mat.Description();
            card.Description();

            ComputerPart part = proc;
            part.Description();

        }
    }
}