using UnityEngine;

public class PaddleBehavior : MonoBehaviour
{
    void Start() {
        transform.position = new Vector2(Constants.PADDLE_START_X, Constants.PADDLE_Y);
    }

    void Update() {
        float mousePositionInUnits = (Input.mousePosition.x / Screen.width) * Constants.SCREEN_WIDTH_UNITS;
        
        transform.position = new Vector2(
            Mathf.Clamp(mousePositionInUnits, Constants.PADDLE_START_X, Constants.PADDLE_MAX_X),
            Constants.PADDLE_Y);
    }
}
