namespace ExemploInterface
{
    public interface IVeiculoTransporte: IVeiculo
    {
        int NumeroMaxPassageiros { get; }

        string GetNumeroLicenca();
    }
}
