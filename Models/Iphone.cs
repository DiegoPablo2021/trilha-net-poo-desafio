namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(String numero, String modelo, String imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }

        public override void InstalarAplicativo(string whatsapp)
        {
            Console.WriteLine($"Instalando o aplicativo {whatsapp} no Iphone!" );
        }
    }
}