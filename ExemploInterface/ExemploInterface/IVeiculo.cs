namespace ExemploInterface
{
    public interface IVeiculo
    {
        string Modelo { get; set; }

        string Cor { get; set; }

        int Ano { get; set; }

        void Ligar();

    }
}
