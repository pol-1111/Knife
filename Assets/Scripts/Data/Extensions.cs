using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Extensions 
{
    public static void Show(this GameObject go)
    {
        go.SetActive(true);
    }

    public static void Hide(this GameObject go)
    {
        go.SetActive(false);
    }
}
