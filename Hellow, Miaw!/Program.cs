using System;

class Program
{
    static void Main(string[] args)
    {   // ini buat input nama
        Console.WriteLine("Selamat datang di Hellow, Miaw!");
        Console.Write("Masukkan nama kamu disini yah miaw: ");
        string namaPemain = Console.ReadLine();
        Console.WriteLine($"Halo {namaPemain}, siap nggak nih buat battle?\n");

        // ini arenanya
        Arena arena = new Arena();

        // milih karakter kucing disini
        // buat object kucing (object dari class >> OOP Concept 1)
        arena.TambahCat(new Oyen("Kucing Oyen"));
        arena.TambahCat(new MeongMujaer("Meong Mujaer"));
        arena.TambahCat(new MiawBekasiShortHair("Miaw Bekasi Shorthair"));

        // buat object jurus (composition)
        arena.TambahJurus(new Jurus("Cakaran Maut", "\"Hiyaaaakkk!!! SRAAAATTT\"", 20));
        arena.TambahJurus(new Jurus("Pukulan Mujaer", "\"DORRR!!! PLAANGGG\"", 25));
        arena.TambahJurus(new Jurus("Gigitan Meow", "\"KRAUKKK!!! MEONGGGGG\"", 30));

        Console.WriteLine("=== Pilih Karakter Kucing Kamu yaw, Miaw! ===");
        arena.TampilkanCat();

        Console.Write("\nPilih kucing kamu yaw.. (1-3): ");
        int pilihanCat = int.Parse(Console.ReadLine());
        Cat player = arena.PilihCat(pilihanCat);

        // lawan random
        Random rnd = new Random();
        Cat enemy;
        do { enemy = arena.PilihCat(rnd.Next(1, 4)); }
        while (enemy == player);

        Console.WriteLine($"\n({namaPemain}) memilih {player.Nama}!");
        Console.WriteLine($"Lawanmu adalah {enemy.Nama}!\n");

        // mulai battle
        Console.WriteLine("=== Hellow Miaw dimulai! ===");
        while (player.ApakahHidup() && enemy.ApakahHidup())
        {
            // giliran pemain
            Console.WriteLine($"\n{player.Nama}, pilih jurus yachh:");
            arena.TampilkanJurus();
            Console.Write("Masukkan pilihan jurus (1-3): ");
            int jurusPlayer = int.Parse(Console.ReadLine());

            // Tanya: mau pamer jurus atau menyerang?
            Console.Write("Mau pamer jurus dulu? (y/n): ");
            string pilihan = Console.ReadLine();

            if (pilihan.ToLower() == "y")
            {
                // Polymorphism - Overloading (Versi 2)
                arena.PilihJurus(jurusPlayer).Gunakan(player.Nama);
            }
            else
            {
                // polymorphism: Gunakan() sama, hasil beda tergantung jurus
                arena.PilihJurus(jurusPlayer).Gunakan(player.Nama, enemy);
                enemy.Info();
            }

            if (!enemy.ApakahHidup()) break;

            // giliran musuh (random)
            int jurusEnemy = rnd.Next(1, 4);
            Console.WriteLine($"\n{enemy.Nama} menyerang!");
            arena.PilihJurus(jurusEnemy).Gunakan(enemy.Nama, player);
            player.Info();
        }

        // hasil akhirnya
        if (player.ApakahHidup())
            Console.WriteLine($"\n{player.Nama} MENANG!");
        else
            Console.WriteLine($"\n{enemy.Nama} MENANG!");
    }
}
