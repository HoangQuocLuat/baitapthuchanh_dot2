namespace Models
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Person ps2 = new Person();

            ps2.FullName = "Nguyen Van Nam";
            ps2.Address = "Nam Dinh";
            ps2.Age = 20;

            ps2.Display();
        }
    }

}
