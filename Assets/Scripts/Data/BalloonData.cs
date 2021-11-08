using UnityEngine;

public class BalloonData : MonoBehaviour
{
    public int PointsForDestroying => RandomizePoints();

    public int DamageWhenOutOfScreen => RandomizeDamage();

    [SerializeField]
    private int _minPointsForDestroying;
    
    [SerializeField]
    private int _maxPointsForDestroying;

    [SerializeField]
    private int _minDamageWhenOutOfScreen;
    
    [SerializeField]
    private int _maxDamageWhenOutOfScreen;

    private int RandomizePoints()
    {
        return Random.Range(_minPointsForDestroying, _maxPointsForDestroying);
    }

    private int RandomizeDamage()
    {
        return Random.Range(_minDamageWhenOutOfScreen, _maxDamageWhenOutOfScreen);
    }
}
