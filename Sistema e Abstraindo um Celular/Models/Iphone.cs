namespace Sistema_e_Abstraindo_um_Celular.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo) : base(numero, modelo, "Apple")
        {
        }
        
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} na App Store do iPhone...");
        }
    }
}