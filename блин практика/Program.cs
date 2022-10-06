namespace блин_практика
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вау, вы зашли в пианино. Ну окей, выберите октаву:");
            Console.WriteLine("F3 - большая октава\nF4 - малая октава\nF5 - первая октава\nF6 - вторая октава\nF7 - третья октава\nF8 - четвёртая октава\nF9 - пятая октава\nEscape - выйти из программы");

            Console.WriteLine("Выберите октаву: ");
            ConsoleKeyInfo klavisha = Console.ReadKey();
            while (true)
            {
                if (klavisha.Key == ConsoleKey.Escape)
                {
                    Console.WriteLine("ВВыход..");
                    break;
                }
                if (klavisha.Key == ConsoleKey.F5)
                {
                    Octava1();
                    int[] massive = Octava1();
                    Octava1_Output();

                }
                if (klavisha.Key == ConsoleKey.F6)
                {
                    Octava2();
                    int[] massive = Octava2();
                    Octava2_Output();
                }
                if (klavisha.Key == ConsoleKey.F7)
                {
                    Octava3();
                    int[] massive = Octava3();
                    Octava3_Output();
                }
                if (klavisha.Key == ConsoleKey.F8)
                {
                    Octava4();
                    int[] massive = Octava4();
                    Octava4_Output();
                }
                if (klavisha.Key == ConsoleKey.F9)
                {
                    Octava5();
                    int[] massive = Octava5();
                    Octava5_Output();
                }
                if (klavisha.Key == ConsoleKey.F4)
                {
                    Octava_malaya();
                    int[] massive = Octava_malaya();
                    Octava_malaya_Output();
                }
                if (klavisha.Key == ConsoleKey.F3)
                {
                    Octava_BIG();
                    int[] massive = Octava_BIG();
                    Octava_BIG_Output();
                }
            }
        }
        static int[] Octava1()
        {
            int[] octava1 = new int[] { 261, 293, 329, 349, 392, 440, 494, 277, 311, 370, 415, 466 }; // C, D, E, F, G, A, B
                                                                                                      // C#, D#, F#, G#, A#
            return octava1;
        }
        static void Octava1_Output(int duration = 600)
        {
            int[] massive = Octava1();
            Console.WriteLine("1-ая октава");
            while (true)
            {

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.A: // C
                        Console.Beep(massive[0], duration);
                        break;
                    case ConsoleKey.S: // D
                        Console.Beep(massive[1], duration);
                        break;
                    case ConsoleKey.D: // E
                        Console.Beep(massive[2], duration);
                        break;
                    case ConsoleKey.F: // F
                        Console.Beep(massive[3], duration);
                        break;
                    case ConsoleKey.G: // G
                        Console.Beep(massive[4], duration);
                        break;
                    case ConsoleKey.H: // A
                        Console.Beep(massive[5], duration);
                        break;
                    case ConsoleKey.J: // B
                        Console.Beep(massive[6], duration);
                        break;
                    case ConsoleKey.W: // C#
                        Console.Beep(massive[7], duration);
                        break;
                    case ConsoleKey.E: // D#
                        Console.Beep(massive[8], duration);
                        break;
                    case ConsoleKey.T: // F#
                        Console.Beep(massive[9], duration);
                        break;
                    case ConsoleKey.Y: // G#
                        Console.Beep(massive[10], duration);
                        break;
                    case ConsoleKey.U: // A#
                        Console.Beep(massive[11], duration);
                        break;
                    default:
                        TeleportNaOctavy();
                        break;
                }
            }
        }
        static void TeleportNaOctavy()
        {
            Console.WriteLine("\nВы вышли. Список октав:");
            Console.WriteLine("F3 - большая октава\nF4 - малая октава\nF5 - первая октава\nF6 - вторая октава\nF7 - третья октава\nF8 - четвёртая октава\nF9 - пятая октава");
            Console.WriteLine("Выберите октаву: ");
            ConsoleKeyInfo octava = Console.ReadKey();
            if (octava.Key == ConsoleKey.F5)
            {
                Octava1();
                int[] massive = Octava1();
                Octava1_Output();
            }
            if (octava.Key == ConsoleKey.F6)
            {
                Octava2();
                int[] massive = Octava2();
                Octava2_Output();
            }
            if (octava.Key == ConsoleKey.F7)
            {
                Octava3();
                int[] massive = Octava3();
                Octava3_Output();
            }
            if (octava.Key == ConsoleKey.F8)
            {
                Octava4();
                int[] massive = Octava4();
                Octava4_Output();
            }
            if (octava.Key == ConsoleKey.F9)
            {
                Octava5();
                int[] massive = Octava5();
                Octava5_Output();
            }
            if (octava.Key == ConsoleKey.F4)
            {
                Octava_malaya();
                int[] massive = Octava_malaya();
                Octava_malaya_Output();
            }
            if (octava.Key == ConsoleKey.F3)
            {
                Octava_BIG();
                int[] massive = Octava_BIG();
                Octava_BIG_Output();
            }
        }
        static int[] Octava2()
        {
            int[] octava2 = new int[] { 523, 587, 659, 698, 784, 880, 987, 554, 622, 740, 830, 932 }; // C, D, E, F, G, A, B
                                                                                                      // C#, D#, F#, G#, A#
            return octava2;
        }
        static void Octava2_Output(int duration = 600)
        {
            int[] massive = Octava2();
            Console.WriteLine("2-ая октава");
            while (true)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.A: // C
                        Console.Beep(massive[0], duration);
                        break;
                    case ConsoleKey.S: // D
                        Console.Beep(massive[1], duration);
                        break;
                    case ConsoleKey.D: // E
                        Console.Beep(massive[2], duration);
                        break;
                    case ConsoleKey.F: // F
                        Console.Beep(massive[3], duration);
                        break;
                    case ConsoleKey.G: // G
                        Console.Beep(massive[4], duration);
                        break;
                    case ConsoleKey.H: // A
                        Console.Beep(massive[5], duration);
                        break;
                    case ConsoleKey.J: // B
                        Console.Beep(massive[6], duration);
                        break;
                    case ConsoleKey.W: // C#
                        Console.Beep(massive[7], duration);
                        break;
                    case ConsoleKey.E: // D#
                        Console.Beep(massive[8], duration);
                        break;
                    case ConsoleKey.T: // F#
                        Console.Beep(massive[9], duration);
                        break;
                    case ConsoleKey.Y: // G#
                        Console.Beep(massive[10], duration);
                        break;
                    case ConsoleKey.U: // A#
                        Console.Beep(massive[11], duration);
                        break;
                    default:
                        TeleportNaOctavy();
                        break;
                }
            }
        }
        static int[] Octava3()
        {
            int[] octava3 = new int[] { 1047, 1175, 1319, 1397, 1568, 1760, 1976, 1109, 1245, 1480, 1661, 1865 }; // C, D, E, F, G, A, B
                                                                                                                  // C#, D#, F#, G#, A#
            return octava3;
        }
        static void Octava3_Output(int duration = 600)
        {
            int[] massive = Octava3();
            Console.WriteLine("3-ая октава");
            while (true)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.A: // C
                        Console.Beep(massive[0], duration);
                        break;
                    case ConsoleKey.S: // D
                        Console.Beep(massive[1], duration);
                        break;
                    case ConsoleKey.D: // E
                        Console.Beep(massive[2], duration);
                        break;
                    case ConsoleKey.F: // F
                        Console.Beep(massive[3], duration);
                        break;
                    case ConsoleKey.G: // G
                        Console.Beep(massive[4], duration);
                        break;
                    case ConsoleKey.H: // A
                        Console.Beep(massive[5], duration);
                        break;
                    case ConsoleKey.J: // B
                        Console.Beep(massive[6], duration);
                        break;
                    case ConsoleKey.W: // C#
                        Console.Beep(massive[7], duration);
                        break;
                    case ConsoleKey.E: // D#
                        Console.Beep(massive[8], duration);
                        break;
                    case ConsoleKey.T: // F#
                        Console.Beep(massive[9], duration);
                        break;
                    case ConsoleKey.Y: // G#
                        Console.Beep(massive[10], duration);
                        break;
                    case ConsoleKey.U: // A#
                        Console.Beep(massive[11], duration);
                        break;
                    default:
                        TeleportNaOctavy();
                        break;
                }
            }
        }
        static int[] Octava4()
        {
            int[] octava4 = new int[] { 2093, 2349, 2637, 2794, 3136, 3520, 3951, 2217, 2489, 2960, 3322, 3729 }; // C, D, E, F, G, A, B
                                                                                                                  // C#, D#, F#, G#, A#
            return octava4;
        }
        static void Octava4_Output(int duration = 600)
        {
            int[] massive = Octava4();
            Console.WriteLine("4-ая октава");
            while (true)
            {

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.A: // C
                        Console.Beep(massive[0], duration);
                        break;
                    case ConsoleKey.S: // D
                        Console.Beep(massive[1], duration);
                        break;
                    case ConsoleKey.D: // E
                        Console.Beep(massive[2], duration);
                        break;
                    case ConsoleKey.F: // F
                        Console.Beep(massive[3], duration);
                        break;
                    case ConsoleKey.G: // G
                        Console.Beep(massive[4], duration);
                        break;
                    case ConsoleKey.H: // A
                        Console.Beep(massive[5], duration);
                        break;
                    case ConsoleKey.J: // B
                        Console.Beep(massive[6], duration);
                        break;
                    case ConsoleKey.W: // C#
                        Console.Beep(massive[7], duration);
                        break;
                    case ConsoleKey.E: // D#
                        Console.Beep(massive[8], duration);
                        break;
                    case ConsoleKey.T: // F#
                        Console.Beep(massive[9], duration);
                        break;
                    case ConsoleKey.Y: // G#
                        Console.Beep(massive[10], duration);
                        break;
                    case ConsoleKey.U: // A#
                        Console.Beep(massive[11], duration);
                        break;
                    default:
                        TeleportNaOctavy();
                        break;
                }
            }
        }
        static int[] Octava5()
        {
            int[] octava5 = new int[] { 4186, 4699, 5274, 5588, 6272, 7040, 7902, 4435, 4978, 5920, 6645, 7459 }; // C, D, E, F, G, A, B
                                                                                                                  // C#, D#, F#, G#, A#
            return octava5;
        }
        static void Octava5_Output(int duration = 600)
        {
            int[] massive = Octava5();
            Console.WriteLine("5-ая октава");
            while (true)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.A: // C
                        Console.Beep(massive[0], duration);
                        break;
                    case ConsoleKey.S: // D
                        Console.Beep(massive[1], duration);
                        break;
                    case ConsoleKey.D: // E
                        Console.Beep(massive[2], duration);
                        break;
                    case ConsoleKey.F: // F
                        Console.Beep(massive[3], duration);
                        break;
                    case ConsoleKey.G: // G
                        Console.Beep(massive[4], duration);
                        break;
                    case ConsoleKey.H: // A
                        Console.Beep(massive[5], duration);
                        break;
                    case ConsoleKey.J: // B
                        Console.Beep(massive[6], duration);
                        break;
                    case ConsoleKey.W: // C#
                        Console.Beep(massive[7], duration);
                        break;
                    case ConsoleKey.E: // D#
                        Console.Beep(massive[8], duration);
                        break;
                    case ConsoleKey.T: // F#
                        Console.Beep(massive[9], duration);
                        break;
                    case ConsoleKey.Y: // G#
                        Console.Beep(massive[10], duration);
                        break;
                    case ConsoleKey.U: // A#
                        Console.Beep(massive[11], duration);
                        break;
                    default:
                        TeleportNaOctavy();
                        break;
                }
            }
        }
        static int[] Octava_malaya()
        {
            int[] octava_malaya = new int[] { 130, 146, 164, 174, 196, 220, 246, 138, 155, 185, 207, 233 }; // C, D, E, F, G, A, B
                                                                                                            // C#, D#, F#, G#, A#
            return octava_malaya;
        }
        static void Octava_malaya_Output(int duration = 800)
        {
            int[] massive = Octava_malaya();
            Console.WriteLine("Малая октава:");
            while (true)
            {

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.A: // C
                        Console.Beep(massive[0], duration);
                        break;
                    case ConsoleKey.S: // D
                        Console.Beep(massive[1], duration);
                        break;
                    case ConsoleKey.D: // E
                        Console.Beep(massive[2], duration);
                        break;
                    case ConsoleKey.F: // F
                        Console.Beep(massive[3], duration);
                        break;
                    case ConsoleKey.G: // G
                        Console.Beep(massive[4], duration);
                        break;
                    case ConsoleKey.H: // A
                        Console.Beep(massive[5], duration);
                        break;
                    case ConsoleKey.J: // B
                        Console.Beep(massive[6], duration);
                        break;
                    case ConsoleKey.W: // C#
                        Console.Beep(massive[7], duration);
                        break;
                    case ConsoleKey.E: // D#
                        Console.Beep(massive[8], duration);
                        break;
                    case ConsoleKey.T: // F#
                        Console.Beep(massive[9], duration);
                        break;
                    case ConsoleKey.Y: // G#
                        Console.Beep(massive[10], duration);
                        break;
                    case ConsoleKey.U: // A#
                        Console.Beep(massive[11], duration);
                        break;
                    default:
                        TeleportNaOctavy();
                        break;
                }
            }
        }
        static int[] Octava_BIG()
        {
            int[] Octava_BIG = new int[] { 65, 73, 82, 87, 98, 110, 123, 69, 77, 92, 103, 116 }; // C, D, E, F, G, A, B
                                                                                                 // C#, D#, F#, G#, A#
            return Octava_BIG;
        }
        static void Octava_BIG_Output(int duration = 1500)
        {
            int[] massive = Octava_BIG();
            Console.WriteLine("Большая октава: ");
            while (true)
            {

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.A: // C
                        Console.Beep(massive[0], duration);
                        break;
                    case ConsoleKey.S: // D
                        Console.Beep(massive[1], duration);
                        break;
                    case ConsoleKey.D: // E
                        Console.Beep(massive[2], duration);
                        break;
                    case ConsoleKey.F: // F
                        Console.Beep(massive[3], duration);
                        break;
                    case ConsoleKey.G: // G
                        Console.Beep(massive[4], duration);
                        break;
                    case ConsoleKey.H: // A
                        Console.Beep(massive[5], duration);
                        break;
                    case ConsoleKey.J: // B
                        Console.Beep(massive[6], duration);
                        break;
                    case ConsoleKey.W: // C#
                        Console.Beep(massive[7], duration);
                        break;
                    case ConsoleKey.E: // D#
                        Console.Beep(massive[8], duration);
                        break;
                    case ConsoleKey.T: // F#
                        Console.Beep(massive[9], duration);
                        break;
                    case ConsoleKey.Y: // G#
                        Console.Beep(massive[10], duration);
                        break;
                    case ConsoleKey.U: // A#
                        Console.Beep(massive[11], duration);
                        break;
                    default:
                        TeleportNaOctavy();
                        break;
                }
            }
        }
    }
}
