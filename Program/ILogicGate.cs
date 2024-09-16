namespace DefaultNamespace;
using System.Collections.Generic;
public interface ILogicGate
{
    //Evalua la compuerta
    public abstract bool Evaluate();

    // Obtiene el valor de una entrada (puede ser una compuerta o un valor booleano directo)
    protected bool GetValue(int index);
}
