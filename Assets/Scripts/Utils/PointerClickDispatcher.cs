using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class PointerClickDispatcher : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    private UnityEvent _onPointerClick;

    public void OnPointerClick(PointerEventData eventData)
    {
        _onPointerClick?.Invoke();
    }
}
