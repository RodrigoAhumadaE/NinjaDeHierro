interface IConsumible
{
    string Nombre {get;set;}
    int Calorias {get;set;}
    bool EsPicante {get;set;}
    bool EsDulce {get;set;}
    string GetInfo();
}   

