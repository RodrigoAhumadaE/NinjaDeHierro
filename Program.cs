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
Console.WriteLine($"Has consumido {i} elementos del menu");
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
Console.WriteLine($"Has consumido {j} elementos del menu");
ninjaAji.Consumir(consumo[j]);

if(i > j){
  Console.WriteLine("¡¡Ninja goloso ha consumido más!!");
}else if(j > i){
  Console.WriteLine("¡¡Ninja fanatico del ají ha consumido más!!");
}else{
  Console.WriteLine("¡¡Ambos han consumido lo mismo!!");
}