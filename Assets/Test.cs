using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EmotivUnityPlugin;
using System;

public class Test : MonoBehaviour
{
    MeshRenderer meshRenderer;
    Color32 currentStressColor;
    Color32 currentRelaxColor;
    Color32 currentAttentionColor;

    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }
    private void Update()
    {
        float stressValue = (float)EmotivUnityItf.Instance.stressPow;
        currentStressColor = Color.red * stressValue;
        meshRenderer.material.color = currentStressColor;
    }
}
