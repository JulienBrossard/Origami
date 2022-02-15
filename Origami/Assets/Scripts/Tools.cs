using System.Linq;
using UnityEngine;

public class Tools : MonoBehaviour
{
    public static Tools instance;

    private void Awake()
    {
        instance = this;
    }

    public void AddVariableInArray <T>(T[] array, T variable)
    {
        array.ToList().Add(variable);
        array.ToArray();
    }
    
    public void AddVariablesInArray <T>(T[] array, T variable, int number)
    {
        for (int i = 0; i < number; i++)
        {
            array.ToList().Add(variable);
        }
        array.ToArray();
    }

    public void FillArray (int minValue, int maxValue, int[] array)
    {
        array = new int[maxValue];
        for (int i = minValue; i < maxValue; i++)
        {
            array[i] = i;
        }
    }
}
