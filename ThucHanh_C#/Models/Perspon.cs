namespace Models
{
    public class Person
    {
        public string FullName { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        public void EnterData()
        {
            Console.Write("Full name: ");
            FullName = Console.ReadLine();

            Console.Write("Address: ");
            Address = Console.ReadLine();

            Console.Write("Age: ");
            Age = Convert.ToInt32(Console.ReadLine());
        }

        public void Display()
        {
            Console.WriteLine("{0} - {1} - {2} tuổi", FullName, Address, Age);
        }
    }
}
