using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    private bool ballLaunched = false;
    [SerializeField] GameObject paddle;

    // Start is called before the first frame update
    void Start()
    {
        if (!paddle) {
            Debug.Log("NO PADDLE DETECTED");
            return;
        }

        lockBallOnPaddle();
    }

    // Update is called once per frame
    void Update() {
        if(!paddle) {
            Debug.Log("NO PADDLE DETECTED");
            return;
        }
        
        if(!ballLaunched) {
            lockBallOnPaddle();
            launchBall();
        } 
    }

    private void launchBall() {
        if(Input.anyKeyDown) {
            GetComponent<Rigidbody2D>().velocity = new Vector2(
                randomDirectionSelector() * Constants.VELOCITY_MIN,
                Constants.VELOCITY_MAX);
            ballLaunched = true;
        }
    }

    private void lockBallOnPaddle() {
        transform.position = new Vector2(paddle.transform.position.x, Constants.BALL_START_Y);
    }

    private float randomDirectionSelector() {
        float randomNumber = Random.Range(-1f, 1);
        return (randomNumber >= 0) ? 1f : -1f;
    }
}
