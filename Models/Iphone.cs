using System.Threading.Channels;

namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone: Smartphone
    {
        public Iphone(string numero, string modelo, string iMEI, string memoria) : base(numero, modelo, iMEI, memoria)
        {
        }

        public Iphone(string numero) : base(numero)
        {
        }

        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o app {nomeApp} no Smartphone Iphone");
        }
    }
}