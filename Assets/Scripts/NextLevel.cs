using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    public int nextScene;
    public void LoadLevel()
    {
        SceneManager.LoadScene(nextScene);
    }
}
