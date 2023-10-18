class Goloso : Ninja{

    public override bool EstaLleno{
        get { return ConsumoCalorias > 1500; } 
    }

    public override void Consumir(IConsumible consumo) {
        if (!EstaLleno) {
            ConsumoCalorias += consumo.Calorias;
            // añade calorías a la ingesta calórica total de Goloso (+10 calorías adicionales si el artículo consumible es "Dulce")​
            if(consumo.EsDulce){
                ConsumoCalorias+=10;
            }
            HistorialConsumo.Add(consumo);
            Console.WriteLine(consumo.GetInfo());
        }else{
            Console.WriteLine("Ya has comido las calorías necesarias para hoy");
        }
    }
}
