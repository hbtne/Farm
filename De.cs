
    public class De : GiaSuc
    {
        private static Random rand = new Random();

        public De(int soLuongBanDau)
        {
            SoLuong = soLuongBanDau;
        }

        public override string PhatTiengKeu()
        {
            return "Be be";
        }

        public override int SinhCon()
        {
            int soConSinhRa = rand.Next(1, 4); 
            SoLuong += soConSinhRa;
            return soConSinhRa;
        }

        public override double ChoSua()
        {
            return rand.NextDouble() * 10; 
        }
    }

