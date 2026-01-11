using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit_level : MonoBehaviour
{
    public void ManageScene()
    {
        SceneManager.LoadScene(0);
    }
}
