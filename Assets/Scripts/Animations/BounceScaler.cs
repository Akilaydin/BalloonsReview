using UnityEngine;
using UnityEngine.Events;

using DG.Tweening;

public class BounceScaler : MonoBehaviour
{
	[SerializeField]
	private UnityEvent _scaleCompleted;

    [SerializeField]
    private Transform _transformToScale;

    [SerializeField]
    private BounceScaleData[] _scaleData;
    
    private Sequence _scaleSequence;
    
    public void BeginScale()
    {
	    _scaleSequence = DOTween.Sequence();

	    for (int i = 0; i < _scaleData.Length; i++)
	    {
		    _scaleSequence.Append(_transformToScale.DOScale((_scaleData[i].Scale), _scaleData[i].Duration));
	    }

	    _scaleSequence.OnComplete(() => _scaleCompleted?.Invoke());
    }
}
