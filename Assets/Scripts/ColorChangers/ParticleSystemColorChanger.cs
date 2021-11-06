using UnityEngine;

public class ParticleSystemColorChanger : BaseColorChanger
{
	[SerializeField]
	private ParticleSystem _particleSystem;
	
	public override void ChangeColor(Color color)
	{
		var m = _particleSystem.main;
		
		m.startColor = color;
	}
}
