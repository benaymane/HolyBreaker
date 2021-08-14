using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonBehavior : MonoBehaviour
{
    public void startGame() {
        SceneManager.LoadScene(Constants.LEVEL_ONE_SCENE);
    }

}

