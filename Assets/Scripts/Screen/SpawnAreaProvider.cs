using UnityEngine;

using Random = UnityEngine.Random;

public class SpawnAreaProvider : MonoBehaviour
{
    [SerializeField]
    private ScreenSizeProvider _provider;

    [SerializeField]
    private float _leftSideOffset;

    [SerializeField]
    private float _rightSideOffset;
    
    [SerializeField]
    private float _height;

    [SerializeField]
    private float _offsetY;

    [SerializeField]
    private float _allowedDifferenceInRepeatedPositions = 1f;
    
    private Rect _rect;

    private Vector2 _previousPosition = Vector2.zero;
    
    private void Awake()
    {
        _provider.CalculateArea();
        
        CalculateSpawnArea();
    }

    private void CalculateSpawnArea()
    {
        var leftSide = _provider.GetLeftSide();
        var rightSide = _provider.GetRightSide();

        _rect.x = leftSide.x + _leftSideOffset;
        _rect.y = leftSide.y + _offsetY;

        _rect.width = (rightSide.x - _rightSideOffset) - (leftSide.x  + _leftSideOffset);
        _rect.height = _height;
    }

    public Vector2 GetUniquePosition()
    {
        var positionToReturn = GenerateRandomPosition();
        
        if (PositionsApproximatelyEqual(positionToReturn, _previousPosition))
        {
            return GetUniquePosition();
        }

        _previousPosition = positionToReturn;

        return positionToReturn;
    }

    private Vector2 GenerateRandomPosition()
    {
        var positionToReturn = new Vector2 {
            x = Random.Range(_rect.xMin, _rect.xMax),
            y = Random.Range(_rect.yMin, _rect.yMax)
        };

        return positionToReturn;
    }

    private bool PositionsApproximatelyEqual(Vector2 firstPos, Vector2 secondPos)
    {
        var dx = firstPos.x - secondPos.x;
        
        if (Mathf.Abs(dx) > _allowedDifferenceInRepeatedPositions)
            return false;
 
        var dy = firstPos.y - secondPos.y;
        
        if (Mathf.Abs(dy) > _allowedDifferenceInRepeatedPositions)
            return false;

        return true;
    }
}
