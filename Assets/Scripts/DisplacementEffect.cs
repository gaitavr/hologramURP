using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplacementEffect : MonoBehaviour
{
    [SerializeField]
    private Material _hologram;
    [SerializeField]
    private AnimationCurve _curve;

    private void Start()
    {
        _curve.postWrapMode = WrapMode.Loop;
    }
    
    private void Update()
    {
        _hologram.SetFloat("_Displacement", 
            _curve.Evaluate(Time.timeSinceLevelLoad));
    }
}
