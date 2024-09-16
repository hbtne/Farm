
    public class Bo : GiaSuc
    {
        private static Random rand = new Random();

        public Bo(int soLuongBanDau)
        {
            SoLuong = soLuongBanDau;
        }

        public override string PhatTiengKeu()
        {
            return "Mooo";
        }

        public override int SinhCon()
        {
            int soConSinhRa = rand.Next(1, 4); 
            SoLuong += soConSinhRa;
            return soConSinhRa;
        }

        public override double ChoSua()
        {
            return rand.NextDouble() * 20;
        }
    }
