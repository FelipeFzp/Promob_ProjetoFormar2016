namespace ExemploInterface
{
    public class Onibus : IVeiculoTransporte
    {
        public int Ano { get; set; }

        public string Cor { get; set; }
      

        public string Modelo { get; set; }


        public Onibus(int numeroPassageiros, int ano, string cor, string modelo)
        {
            _numeroMaxPassageiros = numeroPassageiros;
            this.Ano = ano;
            this.Cor = cor;
            this.Modelo = modelo;
        }

        private int _numeroMaxPassageiros;
        public int NumeroMaxPassageiros
        {
            get
            {
                return _numeroMaxPassageiros;
            }
        }

        public string GetNumeroLicenca()
        {
            return string.Empty;
        }

        public void Ligar()
        {
           
        }
    }
}
