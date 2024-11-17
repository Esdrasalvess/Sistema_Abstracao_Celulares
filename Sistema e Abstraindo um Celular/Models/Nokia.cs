namespace Sistema_e_Abstraindo_um_Celular.Models
{
    // Herdando de Smartphone
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo) : base(numero, modelo, "Nokia")
        {
        }

        // Sobrescrevendo o método InstalarAplicativo
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} na loja Nokia...");
        }
    }
}