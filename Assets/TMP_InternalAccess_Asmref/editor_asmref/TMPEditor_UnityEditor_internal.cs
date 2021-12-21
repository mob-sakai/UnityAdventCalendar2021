using UnityEngine;
using UnityEditor;

public class TMPEditor_UnityEditor_internal
{
    [MenuItem("Test/CallDelayed")]
    private static void CallDelayed()
    {
        Debug.Log("[CallDelayed] Start!");
        EditorApplication.CallDelayed(Print, 5.0f);
    }

    private static void Print()
    {
        Debug.Log("[CallDelayed] Called!");
    }
}