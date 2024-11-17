using Sistema_e_Abstraindo_um_Celular.Models;

internal class Program
{
    public static void Main(string[] args)
    {
        Smartphone meuIphone = new Iphone("123456789", "iPhone 14");
        Smartphone meuNokia = new Nokia("987654321", "Nokia 1100");
        
        Console.WriteLine($"Celular: {meuIphone.Marca} {meuIphone.Modelo}");
        meuIphone.Ligar();
        meuIphone.ReceberLigacao();
        meuIphone.InstalarAplicativo("WhatsApp");

        Console.WriteLine();

        Console.WriteLine($"Celular: {meuNokia.Marca} {meuNokia.Modelo}");
        meuNokia.Ligar();
        meuNokia.ReceberLigacao();
        meuNokia.InstalarAplicativo("Facebook");
    }
}