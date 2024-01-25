public class CarroCombustao
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int AnoFabricacao { get; set; }
    public decimal Preco { get; set; }
    public string Cor { get; set; }
    public int Quilometragem { get; set; }
    public int NumeroPortas { get; set; }
    public bool TetoSolar { get; set; }
    public string Placa { get; set; }
    public Motor MotorSelecionado { get; set; }
    public Tanque TanqueSelecionado { get; set; }
    public Motor[] MotoresDisponiveis { get; set; }
    public Tanque[] TanquesDisponiveis { get; set; }
}

public class Motor
{
    public string Modelo { get; set; }
    public double Potencia { get; set; }
}

public class Tanque
{
    public string Modelo { get; set; }
    public int CapacidadeL { get; set; }
}
