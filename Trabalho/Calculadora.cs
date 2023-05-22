namespace TesteEvellyn.Trabalho
{
    public class Calculadora
    {
        public int Bala { get; set; }
        public int Chiclete { get; set; }
        public int Pirulito { get; set; }

        public int CalcularBalaMaisChiclete()
        {
            int resultado = Bala + Chiclete;

            return resultado;
        }
        public int CalcularBalaMaisPirulito()
        {
            int resultado= Bala + Pirulito;
            return resultado;
        }
    }
}