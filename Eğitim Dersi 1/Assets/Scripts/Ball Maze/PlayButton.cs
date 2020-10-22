using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public string levelName;

    public void executeLevel()
    {
        SceneManager.LoadScene(levelName);
    }
}
