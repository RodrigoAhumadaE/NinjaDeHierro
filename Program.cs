/* En tu clase de programa, crea una instancia de un objeto Buffet y Ninja, ¡y haz que el Ninja coma hasta que esté lleno! */
Buffet buffet = new Buffet();

List<IConsumible> consumo = new List<IConsumible>();

Goloso ninjaGoloso = new Goloso();

int i = 0;

while(!ninjaGoloso.EstaLleno){
  consumo.Add(buffet.Servir());
  ninjaGoloso.Consumir(consumo[i]);
  i++;
}

consumo.Add(buffet.Servir());
ninjaGoloso.Consumir(consumo[i]);

Console.WriteLine("----------------------");
FanaticoDelAji ninjaAji = new FanaticoDelAji();
int j = 0;

while(!ninjaAji.EstaLleno){
  consumo.Add(buffet.Servir());
  ninjaAji.Consumir(consumo[j]);
  j++;
}

consumo.Add(buffet.Servir());
ninjaAji.Consumir(consumo[j]);