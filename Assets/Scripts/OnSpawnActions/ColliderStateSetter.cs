using UnityEngine;

public class ColliderStateSetter : MonoBehaviour
{
    [SerializeField]
    private Collider2D _collider;

    public void SetState(bool state)
    {
        _collider.enabled = state;
    }
}
