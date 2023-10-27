namespace Models {
    public class Employee {

        public Employee() {
            MaNhanVien  =    "001";
            TenNhanVien =    "Hoang Luat";
            Tuoi        =    20;
            Luong       =    1000000;
        }
        public string MaNhanVien {get; set;}

        public string TenNhanVien {get; set;}

        public int Tuoi {get; set;}

        public int Luong {get; set;}

        public void NhapThongTin() 
        {
            Console.Write("Ma nhan vien = ");
            MaNhanVien = Console.ReadLine();

            Console.Write("Ten nhan vien = ");
            TenNhanVien = Console.ReadLine();
            
            Console.Write("Tuoi = ");
            Tuoi = Convert.ToInt16(Console.ReadLine());

            Console.Write("Tuoi = ");
            Luong = Convert.ToInt16(Console.ReadLine());
        }
    }
}