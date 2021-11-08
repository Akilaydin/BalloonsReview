using UnityEngine;
using UnityEngine.Events;

public class ScoreHolder : MonoBehaviour
{
    [SerializeField]
    private UnityEvent<int> _bestScoreChanged;

    [SerializeField]
    private UnityEvent<int> _scoreChanged;

    private int _currentScore;

    private int _bestScore;
    
    public void AddScore(int amount)
    {
        _currentScore += amount;

        if (_currentScore > _bestScore)
        {
            _bestScore = _currentScore;
            
            _bestScoreChanged?.Invoke(_bestScore);
        }
        
        _scoreChanged?.Invoke(_currentScore);
    }

    public void SetBestScore(int bestScore)
    {
        _bestScore = bestScore;
    }
}
