using System.Collections;
using System.Collections.Generic;
using UnityEngine;



  public class GameTest : MonoBehaviour
{
    //public SpawnManager spawnerManager;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            //SpawnManager.instance.Spawn();
            EventManager.instance.TriggerEvent("Spawn");
            Debug.Log("Test Spawn");

        }
    }
}

