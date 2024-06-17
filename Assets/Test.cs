using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EmotivUnityPlugin;

public class Test : MonoBehaviour
{
    private void Start()
    {
        Debug.Log(EmotivUnityItf.Instance.GetBandPowerLists());
    }
}
