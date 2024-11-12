namespace _02___DispositivosEletronicos.Models
{
    public class Computador : DispositivoEletronico //Essa linha é responsável por herdar outra classe
    {
        public bool EhLaptop { get; set; }
        public int MemoriaRam { get; set; }
        public string SistemaOperacional { get; set; }

        public override string ExibirDetalhes()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}, Ano de fabricação: {AnoDeFabricacao}, Sistema Operacional: {SistemaOperacional}";
        }
    }
}
