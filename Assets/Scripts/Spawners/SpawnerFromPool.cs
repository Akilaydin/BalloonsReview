using UnityEngine;
using UnityEngine.Events;

public class SpawnerFromPool : MonoBehaviour
{
    [SerializeField]
    private UnityEvent<GameObject> _enemySpawned;
    
    [SerializeField]
    private SpawnedObjectsPool _objectsPool;

    public void Spawn()
    {
        var enemy = _objectsPool.GetObjectFromPool(transform);
        
        _enemySpawned?.Invoke(enemy);
    }
}
