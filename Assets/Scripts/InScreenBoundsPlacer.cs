using UnityEngine;

public class InScreenBoundsPlacer : MonoBehaviour, IPlacer
{
	[SerializeField]
	private SpawnAreaProvider _provider;

	public void Place(GameObject objectToPlace)
	{
		objectToPlace.transform.position = _provider.GetUniquePosition();
	}
}
