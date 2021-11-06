using UnityEngine;

[System.Serializable]
public class BounceScaleData
{
    public Vector2 Scale => _scale;
    
    public float Duration => _duration;

    [SerializeField]
    private Vector2 _scale;

    [SerializeField]
    private float _duration;
}
