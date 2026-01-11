using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void ManageScene()
    {
        SceneManager.LoadScene(1);
        SceneManager.LoadScene(2);
    }
}
