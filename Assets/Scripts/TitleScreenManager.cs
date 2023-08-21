using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreenManager : MonoBehaviour
{
    public void OnStartPressed() => SceneManager.LoadScene(1);
}
