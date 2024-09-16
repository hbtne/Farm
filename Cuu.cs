
    public class Cuu : GiaSuc
    {
        private static Random rand = new Random();

        public Cuu(int soLuongBanDau)
        {
            SoLuong = soLuongBanDau;
        }

        public override string PhatTiengKeu()
        {
            return "Beeeeeeee";
        }

        public override int SinhCon()
        {
            int soConSinhRa = rand.Next(1, 3); 
            SoLuong += soConSinhRa;
            return soConSinhRa;
        }

        public override double ChoSua()
        {
            return rand.NextDouble() * 5; 
        }
    }

