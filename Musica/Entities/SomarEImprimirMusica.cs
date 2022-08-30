namespace Musica.Entities
{
    class SomarNumeroInteiro
    {
        private int Botao1 { get; set; }
        private int Botao2 { get; set; }
        private int Soma { get; set; }
        public SomarNumeroInteiro(int botao1, int botao2)
        {
            Botao1 = botao1;
            Botao2 = botao2;
        }
        public string CalcularSoma()
        {
            Soma = Botao1 + Botao2;
            switch (Soma)
            {
                case 0:
                    return "PROXYCITY";
                case 1:
                    return "P.Y.N.G.";
                case 2:
                    return "DNSUEY!";
                case 3:
                    return "SERVERS";
                case 4:
                    return "HOST!";
                case 5:
                    return "CRIPTONIZE";
                case 6:
                    return "OFFLINE DAY";
                case 7:
                    return "SALT";
                case 8:
                    return "ANSWER!";
                case 9:
                    return "RAR?";
                case 10:
                    return "WIFI ANTENNAS";
                default:
                    return "Por favor digite dois numeros inteiros, sendo a soma dos dois até o limite 10";
            }
        }
    }
}
