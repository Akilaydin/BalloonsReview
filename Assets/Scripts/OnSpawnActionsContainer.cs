using UnityEngine;

public class OnSpawnActionsContainer : MonoBehaviour
{
    public BaseSpawnedAction[] Actions => _actions;
    
    [SerializeField]
    private BaseSpawnedAction[] _actions;
}
