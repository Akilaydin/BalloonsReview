using UnityEngine;

[CreateAssetMenu(order = 5, fileName = "ColorsData", menuName = "ColorsData")]
public class ColorsData : ScriptableObject
{
   public Color[] Colors => _colors;
   
   [SerializeField]
   private Color[] _colors;
}
