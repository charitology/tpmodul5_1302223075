// See https://aka.ms/new-console-template for more information
public class HaloGeneric
{
    public void SapaPengguna (string nama)
    {
        Console.WriteLine("Halo Pengguna " + nama + "!");

    }
    public static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        string nama = Console.ReadLine();
        halo.SapaPengguna(nama);
    }
}