using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Spawner : MonoBehaviour
{
    public GameObject monster;
    //public UnityEvent OnSpawn;


    private void OnEnable()
    {
        Spawn();
        Debug.Log("On Enable");
    }

    private void OnDisable()
    {
        EventManager.instance.StartListening("Spawn", Spawn);
    }


    public void Spawn()
    {
        Instantiate(monster, this.transform.position, this.transform.rotation);
    }

}
