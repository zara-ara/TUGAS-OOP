using System;

// class abstract cat (parent)
abstract class Cat   // class & object (OOP Concept 1)
{
    private string nama;   // encapsulation & data hiding → field private
    private int hp;        // hanya bisa diakses lewat property

    // constructor
    public Cat(string nama, int hp)
    {
        this.nama = nama;
        this.hp = hp;
    }

    // properti (Encapsulation)
    public string Nama { get { return nama; } }
    public int HP
    {
        get { return hp; }
        set { hp = value < 0 ? 0 : value; }   // tidak bisa negatif
    }

    // method umum (bisa dioverride → Polymorphism)
    public virtual void Info()
    {
        Console.WriteLine($"{Nama} [HP: {HP}]");
    }

    // mengecek apakah masih hidup
    public bool ApakahHidup()
    {
        return HP > 0;
    }
}
