using UnityEngine;

public class SpriteRendererColorChanger : BaseColorChanger
{
	[SerializeField]
	private SpriteRenderer _renderer;

	public override void ChangeColor(Color color)
	{
		_renderer.color = color;
	}
}

