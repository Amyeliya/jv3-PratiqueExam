using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangementScene : MonoBehaviour
{
   public void LoadScene(string nomScene)
    {
        SceneManager.LoadScene(nomScene);
    }
}
