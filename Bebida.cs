class Bebida : IConsumible
{
    public string Nombre {get;set;}
    public int Calorias {get;set;}
    public bool EsPicante {get;set;}
    public bool EsDulce {get;set;}
    
    public string GetInfo()
    {
        string mensaje = $"{Nombre} (Bebida) Calorias: {Calorias} ";
        if(EsPicante){
            mensaje += "Es picante: Si ";
        }else{
            mensaje += "Es picante: No ";
        }
        if(EsDulce){
            mensaje += "Es dulce: Si";
        }else{
            mensaje += "Es dulce: No";
        }
        return mensaje;
    }

    public Bebida(string nombre, int calorias, bool picante, bool dulce)
    {
        Nombre = nombre;
        Calorias = calorias;
        EsPicante = picante;
        EsDulce = dulce;
    }
}   

