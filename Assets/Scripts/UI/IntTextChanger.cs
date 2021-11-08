using UnityEngine;
using UnityEngine.UI;

public class IntTextChanger : MonoBehaviour
{
    [SerializeField]
    private Text _text;
    
    [SerializeField]
    private string _pattern = "Health: ";

    public void Apply(int count)
    {
        _text.text = _pattern + count;
    }
}
