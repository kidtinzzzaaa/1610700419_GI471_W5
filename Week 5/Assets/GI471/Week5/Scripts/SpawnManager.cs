using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


 public class SpawnManager : MonoBehaviour
    {

        public List<Spawner> spawnerList = new List<Spawner>();

        public static SpawnManager instance;


        private void Awake()
        {
            instance = this;
            Init();
        }


        private void Init()
        {
            Spawner[] spawnerArr = FindObjectsOfType<Spawner>();

            //for(int i = 0; i < spawnerArr.Length; i++)
            //{
            //    spawnerList.Add(spawnerArr[i]);
            //}

            spawnerList = spawnerArr.ToList<Spawner>();
        }

        public void Spawn()
        {
            foreach (Spawner spawner in spawnerList)
            {
                spawner.Spawn();
            }
        }





 }


