using UnityEngine;

public class OutOfScreenDamageDealer : MonoBehaviour
{
    [SerializeField]
    private PlayerHealth _playerHealth;
    
    public void DealDamage(GameObject go)
    {
        if (go.TryGetComponent(out BalloonData data))
        {
            _playerHealth.GetDamage(data.DamageWhenOutOfScreen);
        }
    }
}
