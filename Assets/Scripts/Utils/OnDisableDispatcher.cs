using UnityEngine;
using UnityEngine.Events;

public class OnDisableDispatcher : MonoBehaviour
{
    [SerializeField]
    private UnityEvent _disabled;

    private void OnDisable()
    {
        _disabled?.Invoke();
    }
}
