using UnityEngine;

public class OnSpawnVelocitySetter : BaseSpawnedAction
{
    [SerializeField]
    private Vector2 _velocityToSetOnSpawn;
    
    [SerializeField]
    private Rigidbody2D _rigidbody2D;
    
    public override void DoOnSpawnAction()
    {
        _rigidbody2D.velocity = _velocityToSetOnSpawn;
    }
}
