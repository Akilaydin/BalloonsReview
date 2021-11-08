using UnityEngine;

public class ScreenSizeProvider : MonoBehaviour
{
    private Vector2 _rightSide, _leftSide;

    public void CalculateArea()
    {
        var widthSenter = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

        _rightSide = new Vector2(widthSenter.x, widthSenter.y);
        _leftSide = new Vector2(-widthSenter.x, widthSenter.y);
    }

    public Vector2 GetLeftSide()
    {
        return _leftSide;
    }

    public Vector2 GetRightSide()
    {
        return _rightSide;
    }
}
