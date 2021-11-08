using UnityEngine;

public class RandomizedVelocitySetter : MonoBehaviour
{
    [SerializeField]
    private Vector2 _minVelocityToSet;
    
    [SerializeField]
    private Vector2 _maxVelocityToSet;
    
    [SerializeField]
    private Rigidbody2D _rigidbody2D;

    private Vector2 _velocityToSet;
    
    public void SetVelocity()
    {
        _velocityToSet.x = Random.Range(_minVelocityToSet.x, _maxVelocityToSet.x);
        _velocityToSet.y = Random.Range(_minVelocityToSet.y, _maxVelocityToSet.y);

        _rigidbody2D.velocity = _velocityToSet;
    }
}
