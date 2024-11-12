namespace _02___DispositivosEletronicos.Models
{
    public class Smartphone : DispositivoEletronico
    {
        public bool Tem5G {  get; set; }

        public override string ExibirDetalhes()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}, Ano de fabricação: {AnoDeFabricacao}, 5G? {(Tem5G ? "Sim" : "Não")}";
        }
    }
}
