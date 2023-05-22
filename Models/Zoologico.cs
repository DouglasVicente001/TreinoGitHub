namespace TesteEvellyn.Models
{
    public class Zoologico
    {
        public string ?Cabra { get; set; }
        public string ?Girafa { get; set; }
        public string ?Jacare { get; set; }

    public Zoologico(string ?cabra, string girafa, string jacare)
    {
        Cabra = cabra;
        Girafa = girafa;
        Jacare = jacare;
    }

    public override string ToString()
    {
       return  $"Cabrinha: {Cabra} Girafa: {Girafa} Jacaré: {Jacare}";
    }
    
    }
}