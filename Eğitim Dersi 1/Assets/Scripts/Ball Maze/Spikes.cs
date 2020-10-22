using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spikes : MonoBehaviour
{
    public string levelName;

    private void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(levelName);
    }

}
