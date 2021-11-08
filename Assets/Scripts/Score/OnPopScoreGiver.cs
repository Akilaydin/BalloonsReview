using UnityEngine;
using UnityEngine.Events;

public class OnPopScoreGiver : MonoBehaviour
{
	public UnityEvent<int> Popped;

	[SerializeField]
	private BalloonData _data;

	public void InvokePopped()
	{
		Popped?.Invoke(_data.PointsForDestroying);
	}

	public void RemoveListeners()
	{
		Popped.RemoveAllListeners();
	}
}
