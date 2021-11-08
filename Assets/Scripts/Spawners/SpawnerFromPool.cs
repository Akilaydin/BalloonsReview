using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SpawnerFromPool : MonoBehaviour
{
    [SerializeField]
    private ScoreHolder _scoreHolder;
    
    [SerializeField]
    private UnityEvent<GameObject> _objectSpawned;
    
    [SerializeField]
    private SpawnedObjectsPool _objectsPool;

    private GameObject _currentObject;

    public void Spawn()
    {
        _currentObject = _objectsPool.GetObjectFromPool(transform);
                
       if (_currentObject.TryGetComponent(out OnSpawnAction action))
       { 
           action.DoAction();
       }

       if (_currentObject.TryGetComponent(out OnPopScoreGiver scoreGiver))
       {
           scoreGiver.Popped.AddListener(_scoreHolder.AddScore);
       }

       _objectSpawned?.Invoke(_currentObject);
    }
}
