namespace TahminOyunu;

class Yazdir
    {
        enum Renkler
        {
            Beyaz = 0, Yesil, Kirmizi, Sari, Siyah, Turkuaz
        }

        static void SwitchRenk(string RENK)
        {
            switch (RENK)
            {
                case "Beyaz": Console.ForegroundColor = ConsoleColor.White; break;
                case "Yeşil": Console.ForegroundColor = ConsoleColor.Green; break;
                case "Kırmızı": Console.ForegroundColor = ConsoleColor.Red; break;
                case "Sarı": Console.ForegroundColor = ConsoleColor.Yellow; break;
                case "Siyah": Console.ForegroundColor = ConsoleColor.Black; break;
                case "Turkuaz": Console.ForegroundColor = ConsoleColor.Cyan; break;
            }
        }
        public static void KR (string RENKILK, string MESAJRENKLI, string RENKSON)
        {
            SwitchRenk(RENKILK);
            Console.Write(" {0} ",MESAJRENKLI);
            SwitchRenk(RENKSON);
        }
        public static void KR (string RENKILK, string MESAJRENKLI, string RENKSON, string MESAJSON)
        {
            SwitchRenk(RENKILK);
            Console.Write(" {0} ",MESAJRENKLI);
            SwitchRenk(RENKSON);
            Console.Write("{0}",MESAJSON);
        }
        public static void KR (string MESAJILK, string RENKILK, string MESAJRENKLI, string RENKSON, string MESAJSON)
        {
            Console.Write("{0}",MESAJILK);
            SwitchRenk(RENKILK);
            Console.Write(" {0} ",MESAJRENKLI);
            SwitchRenk(RENKSON);
            Console.Write("{0}",MESAJSON);
        }
    }