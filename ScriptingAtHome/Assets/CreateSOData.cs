using UnityEngine;

public class CreateSOData : MonoBehaviour
{
    public IntData data;
    private IntData newData;
    
    void Start()
    {
        newData = ScriptableObject.CreateInstance<IntData>();
        newData.value = data.value;
    }

  
}
