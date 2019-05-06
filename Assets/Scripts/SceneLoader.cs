using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{

    public void LoadScene(string level)
    {
        SceneManager.LoadScene(level, LoadSceneMode.Single);
    }
}