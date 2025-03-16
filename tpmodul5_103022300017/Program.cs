class HaloGeneric
{
    public void SapaUser<T>(T data)
    {
        Console.WriteLine("Halo " + data);
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser<string>("Budi");
        halo.SapaUser("Andi");
    }
}