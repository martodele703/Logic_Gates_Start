namespace DefaultNamespace;

using System.Collections.Generic;

// Clase base abstracta para compuertas lógicas
abstract class LogicGate
{
    protected List<LogicGate> inputs; // Lista de entradas
    protected List<bool> directInputs; // Lista de entradas directas

    public LogicGate(List<LogicGate> inputs = null, List<bool> directInputs = null)
    {
        this.inputs = inputs ?? new List<LogicGate>(); // Inicializamos las entradas
        this.directInputs = directInputs ?? new List<bool>();
    }

    public abstract bool Evaluate();

    // Obtiene el valor de una entrada (puede ser una compuerta o un valor booleano directo)
    protected bool GetValue(int index)
    {
        if (index < inputs.Count && inputs[index] != null)
        {
            return inputs[index].Evaluate(); // Si es una compuerta, evaluamos su valor
        }
        if (index < directInputs.Count)
        {
            return directInputs[index]; // Si es un valor directo, lo devolvemos
        }
        throw new InvalidOperationException("Input no válido en índice: " + index);
    }
}