using UnityEngine;
using UnityEngine.Events;

public class OnSpawnAction : MonoBehaviour
{
    [SerializeField]
    private UnityEvent _spawned;

    public void DoAction()
    {
        _spawned?.Invoke();
    }
}
