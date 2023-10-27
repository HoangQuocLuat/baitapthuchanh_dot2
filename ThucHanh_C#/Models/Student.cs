namespace Models {
    public class Student {
        public string HoTen {get; set;}

        public string DiaChi {get; set;}

        public int Tuoi {get; set;}

        public int SDT {get; set;}

        public void NhapThongTin() 
        {
            Console.Write("Nhap ho ten = ");
            HoTen = Console.ReadLine();

            Console.Write("Dia chi = ");
            DiaChi = Console.ReadLine();
            
            Console.Write("Tuoi = ");
            Tuoi = Convert.ToInt16(Console.ReadLine());

            Console.Write("So dien thoai = ");
            SDT = Convert.ToInt16(Console.ReadLine());
        }
    }
}