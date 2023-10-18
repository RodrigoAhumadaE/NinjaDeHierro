abstract class Ninja
{
    protected int ConsumoCalorias;
    public List<IConsumible> HistorialConsumo;
    public Ninja()
    {
        ConsumoCalorias = 0;
        HistorialConsumo = new List<IConsumible>();
    }
    public abstract bool EstaLleno {get;}
    public abstract void Consumir(IConsumible item);
}

