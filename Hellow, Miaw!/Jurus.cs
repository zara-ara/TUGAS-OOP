using System;

// ini composition
class Jurus
{
    public string Nama { get; }       // encapsulation, cuman bisa diisi lewat constructor
    public string Output { get; }
    public int Damage { get; }

    // constructor
    public Jurus(string nama, string output, int damage)
    {
        Nama = nama;
        Output = output;
        Damage = damage;
    }

    // method untuk menggunakan jurus
    // polymorphism (OOP Concept 5: method bisa dipakai oleh semua kucing)
    public void Gunakan(string namaKucing, Cat target)
    {
        Console.WriteLine($"{namaKucing} menggunakan jurus: {Nama}");
        Console.WriteLine(Output);
        target.HP -= Damage;   // encapsulation, HP lawan diubah via property
    }

    // method overloading → versi 2 (cuma pamer jurus tanpa menyerang)
    public void Gunakan(string namaKucing)
    {
        Console.WriteLine($"{namaKucing} mencoba jurus: {Nama}");
        Console.WriteLine(Output);
    }
}
