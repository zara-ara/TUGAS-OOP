using System;
using System.Collections.Generic;

// composition
class Arena
{
    private List<Cat> cats = new List<Cat>();         // composition: arena "memiliki" kucing
    private List<Jurus> jurusList = new List<Jurus>(); // composition: arena juga "memiliki" jurus

    public void TambahCat(Cat c) => cats.Add(c);      // method buat nambah kucing ke arena
    public void TambahJurus(Jurus j) => jurusList.Add(j);

    // menampilkan daftar kucing
    public void TampilkanCat()
    {
        for (int i = 0; i < cats.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            cats[i].Info();
        }
    }

    // menampilkan daftar jurus
    public void TampilkanJurus()
    {
        for (int i = 0; i < jurusList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {jurusList[i].Nama}");
        }
    }

    // getter
    public Cat PilihCat(int index) => cats[index - 1];
    public Jurus PilihJurus(int index) => jurusList[index - 1];
}
