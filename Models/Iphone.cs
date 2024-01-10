namespace DesafioPOO.Models
{
    // IMPLEMENTADO!!!
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // IMPLEMENTADO!!!
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Você deseja instalar o aplicativo {nomeApp} em seu Iphone?");
        }
    }
}