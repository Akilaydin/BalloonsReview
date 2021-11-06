using UnityEngine;

public class ProgressiveTimeScaleIncreaser : MonoBehaviour
{ 
    [SerializeField]
    private float _increaseAmount;

    public void IncreaseTimeScale()
    {
        Time.timeScale += _increaseAmount;
    }
    
    public void ResetToDefault()
    {
        Time.timeScale = 1;
    }
}
