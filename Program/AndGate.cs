namespace DefaultNamespace;

public class AndGate: LogicGate
{
    private List<LogicGate> entradas;

    public And(List<Compuerta> entradas)
    {
        this.entradas = entradas;
    }

    public override bool Evaluar()
    {
        foreach (var entrada in entradas)
        {
            if (!entrada.Evaluar())
            {
                return false;
            }
        }
        return true;
    }
}

