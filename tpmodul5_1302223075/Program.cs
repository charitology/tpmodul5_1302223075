// See https://aka.ms/new-console-template for more information
public class HaloGeneric
{
    public void SapaPengguna<X>(X nama)
    {
        Console.WriteLine("Halo Pengguna " + nama + "!");

    }
    public class DataGeneric<T>
    {
        public T data { get; set; }

        public DataGeneric(T data)
        {
        this.data = data;
        }

        public void PrintData()
        {
        Console.WriteLine("Data yang tersimpan: " + data);
        }
    }
    
    public static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        Console.WriteLine("Dengan siapa disini?");
        string nama = Console.ReadLine();
        halo.SapaPengguna(nama);

        Console.WriteLine("Berapa NIM-mu?");
        string nim = Console.ReadLine();
        DataGeneric<string> dataStr = new DataGeneric<string>(nim);
        dataStr.PrintData();

    }
}

internal class DataGeneric<T>
{
    private string? nim;

    public DataGeneric(string? nim)
    {
        this.nim = nim;
    }
}