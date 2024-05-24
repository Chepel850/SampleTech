using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class WebFunctions : MonoBehaviour
{
    [DllImport("__Internal")]

    private static extern void ReturnHome();
    
    public void ReturnUserHome()
    {
        ReturnHome();
    }
}
