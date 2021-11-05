using System.Collections.Generic;

using UnityEngine;

public class SpawnedObjectsPool : MonoBehaviour
{
    [SerializeField]
    private GameObject _prefabToSpawn;

    [SerializeField]
    private int _poolSize;
    
    private Queue<GameObject> _objectsToPool = new Queue<GameObject>();

    public GameObject GetObjectFromPool(Transform spawnTransform)
    {
        if (_objectsToPool.Count <= 0)
        {
            FillQueue();
        }
        
        var obj = _objectsToPool.Dequeue();

        obj.SetActive(true);
        obj.transform.position = spawnTransform.position;
        obj.transform.rotation = spawnTransform.rotation;
        
        if (obj.TryGetComponent(out ISpawnedObject pooledObjectComponent))
        {
            pooledObjectComponent.DoOnSpawnAction();
        }

        _objectsToPool.Enqueue(obj);

        return obj;
    }
    
    private void FillQueue()
    {
        for (int i = 0; i < _poolSize; i++)
        {
            var spawnedObject = Instantiate(_prefabToSpawn);

            spawnedObject.SetActive(false);
            
            _objectsToPool.Enqueue(spawnedObject);
        }
    }
}