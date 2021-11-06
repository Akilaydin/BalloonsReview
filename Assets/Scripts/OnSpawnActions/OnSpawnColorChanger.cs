using UnityEngine;

public class OnSpawnColorChanger : BaseSpawnedAction
{
    [SerializeField]
    private ColorsData _colorsData;

    [SerializeField]
    private BaseColorChanger[] _changers;

    private int _colorIndex;
    
    public override void DoOnSpawnAction()
    {
        ColorizeBalloon();
    }

    private void ColorizeBalloon()
    {
        _colorIndex = Random.Range(0, _colorsData.Colors.Length);

        foreach (var changer in _changers)
        {
            changer.ChangeColor(_colorsData.Colors[_colorIndex]);
        }
    }
}
