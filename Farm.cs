
    public class Farm
    {
        private List<GiaSuc> danhSachGiaSuc;

        public Farm(int soBo, int soCuu, int soDe)
        {
            danhSachGiaSuc = new List<GiaSuc>();
            for (int i = 0; i < soBo; i++)
            {
                danhSachGiaSuc.Add(new Bo(1));
            }
            for (int i = 0; i < soCuu; i++)
            {
                danhSachGiaSuc.Add(new Cuu(1));
            }
            for (int i = 0; i < soDe; i++)
            {
                danhSachGiaSuc.Add(new De(1));
            }
        }

        public void TatCaGiaSucDoi()
        {
            foreach (var giaSuc in danhSachGiaSuc)
            {
                Console.WriteLine(giaSuc.PhatTiengKeu());
            }
        }

        public void ThongKe()
        {
            int tongGiaSucBo = 0;
            int tongGiaSucCuu = 0;
            int tongGiaSucDe = 0;
            
            int tongConSinhRaBo = 0;
            int tongConSinhRaCuu = 0;
            int tongConSinhRaDe = 0;

            double tongSuaBo = 0;
            double tongSuaCuu = 0;
            double tongSuaDe = 0;

            foreach (var giaSuc in danhSachGiaSuc)
            {
                if (giaSuc is Bo bo)
                {
                    int soConSinhRa = bo.SinhCon();
                    double suaChoRa = bo.ChoSua();

                    tongGiaSucBo += bo.SoLuong;
                    tongConSinhRaBo += soConSinhRa;
                    tongSuaBo += suaChoRa;

                    Console.WriteLine($"So bo con sinh ra: {soConSinhRa}");
                    Console.WriteLine($"Luong sua bo cho ra: {suaChoRa}");
                }
                else if (giaSuc is Cuu cuu)
                {
                    int soConSinhRa = cuu.SinhCon();
                    double suaChoRa = cuu.ChoSua();

                    tongGiaSucCuu += cuu.SoLuong;
                    tongConSinhRaCuu += soConSinhRa;
                    tongSuaCuu += suaChoRa;

                   
                    Console.WriteLine($"So cuu con sinh ra: {soConSinhRa}");
                    Console.WriteLine($"Luong sua cuu cho ra: {suaChoRa}");
                }
                else if (giaSuc is De de)
                {
                    int soConSinhRa = de.SinhCon();
                    double suaChoRa = de.ChoSua();

                    tongGiaSucDe += de.SoLuong;
                    tongConSinhRaDe += soConSinhRa;
                    tongSuaDe += suaChoRa;

                   
                    Console.WriteLine($"So de con sinh ra: {soConSinhRa}");
                    Console.WriteLine($"Luong sua de  cho ra: {suaChoRa}");
                }

                Console.WriteLine();
            }

            Console.WriteLine($"Tong Bo: {tongGiaSucBo}");
            Console.WriteLine($"Tong Cuu: {tongGiaSucCuu}");
            Console.WriteLine($"Tong De: {tongGiaSucDe}");

            Console.WriteLine($"Tong so bo con sinh ra: {tongConSinhRaBo}");
            Console.WriteLine($"Tong so cuu con sinh ra : {tongConSinhRaCuu}");
            Console.WriteLine($"Tong so de con sinh ra : {tongConSinhRaDe}");
            
            Console.WriteLine($"Tong gia suc sau sinh: {tongGiaSucBo + tongGiaSucCuu + tongGiaSucDe}");

            Console.WriteLine($"Tong sua thu duoc Bo: {tongSuaBo:0.00} lít");
            Console.WriteLine($"Tong sua thu duoc Cuu: {tongSuaCuu:0.00} lít");
            Console.WriteLine($"Tong sua thu duoc De: {tongSuaDe:0.00} lít");

            
            Console.WriteLine($"Tong sua thu duoc: {tongSuaBo + tongSuaCuu + tongSuaDe:0.00} lít");
        }
    }
