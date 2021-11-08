using UnityEngine;

public class TimeScaleChanger : MonoBehaviour
{ 
    [SerializeField]
    private float _increaseAmount;

    [SerializeField]
    private float _currentTimeScale;
    
    public void IncreaseTimeScale()
    {
        Time.timeScale += _increaseAmount;
    }
    
    public void ResetToDefault()
    {
        Time.timeScale = 1;
    }

    public void SetToZero()
    {
        Time.timeScale = 0;
    }

    public void PauseTime()
    {
        _currentTimeScale = Time.timeScale;
        SetToZero();
    }

    public void UnpauseTime()
    {
        Time.timeScale = _currentTimeScale;
    }
}
