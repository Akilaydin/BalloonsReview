using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
	[SerializeField]
	private UnityEvent<int> _healthChanged;
	
	[SerializeField]
	private UnityEvent _playerDied;
	
	[SerializeField]
	private int _initialHealth = 100;

	private int _currentHealth;

	private void OnValidate()
	{
		Assert.IsTrue(_initialHealth > 0);
	}

	private void Awake()
	{
		_currentHealth = _initialHealth;
	}

	public void GetDamage(int damageAmount)
	{
		_currentHealth -= damageAmount;
		
		if (_currentHealth <= 0)
		{
			_currentHealth = 0;
			
			_playerDied?.Invoke();
		}
		
		_healthChanged?.Invoke(_currentHealth);
	}
}
