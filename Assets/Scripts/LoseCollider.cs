using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision) {
        SceneManager.LoadScene(Constants.START_SCENE);
    }
}
