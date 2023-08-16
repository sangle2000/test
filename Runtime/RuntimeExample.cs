using UnityEngine;
using UnityEditor;

[InitializeOnLoad]
public static class RuntimeExample
{
    static RuntimeExample()
    {
        Debug.Log("Hello 2 ");
    }
}