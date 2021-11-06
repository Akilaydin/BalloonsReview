using UnityEngine;
using UnityEngine.Events;

public class SpawnerFromPool : MonoBehaviour
{
    [SerializeField]
    private UnityEvent<GameObject> _objectSpawned;
    
    [SerializeField]
    private SpawnedObjectsPool _objectsPool;

    private GameObject _currentObject;

    public void Spawn()
    {
        _currentObject = _objectsPool.GetObjectFromPool(transform);
                
       if (_currentObject.TryGetComponent(out OnSpawnActionsContainer pooledObjectComponent))
       { 
           foreach (var action in pooledObjectComponent.Actions) 
           {
               action.DoOnSpawnAction(); 
           }
       }

       _objectSpawned?.Invoke(_currentObject);
    }
}
