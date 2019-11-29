using UnityEngine;
using UnityEngine.AI;

//Script Based on Professor's Script
public abstract class AiBase : ScriptableObject, AiBase.IAi
{
    public FloatData speedData;
    public FloatData angularSpeed;
    public abstract void Navigate(NavMeshAgent ai);
    
    public interface IAi
    {
    }
}