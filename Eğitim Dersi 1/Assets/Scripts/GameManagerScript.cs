using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    public bool[] isCollected;
    public int collectedCount = 0;

    public GameObject spawnLocation;
    public GameObject grenade;

    //cameras
    public GameObject ccTV;
    public GameObject playerCamera;
    //

    public int grenadeCount;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha3)&& grenadeCount > 0)
        {
            Instantiate(grenade, spawnLocation.transform.position, spawnLocation.transform.rotation);
            grenadeCount--;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (playerCamera.activeSelf == true)
            {
                ccTV.SetActive(true);
                playerCamera.SetActive(false);
            }
            else if(playerCamera.activeSelf == false)
            {
                ccTV.SetActive(false);
                playerCamera.SetActive(true);

            }
        }

    }



}
