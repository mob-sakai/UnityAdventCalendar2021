using System;
using TMPro;
using UnityEngine;

public class TMP_ListPoolUser_OpenSesame : MonoBehaviour
{
    private void Start()
    {
#if CUSTOM_COMPILE
        var l = TMP_ListPool<int>.Get();

        l.Add(0);
        l.Add(1);
        l.Add(2);

        Debug.Log($"List count is {l.Count}");

        TMP_ListPool<int>.Release(l);
#else
        throw new NotImplementedException();
#endif
    }
}