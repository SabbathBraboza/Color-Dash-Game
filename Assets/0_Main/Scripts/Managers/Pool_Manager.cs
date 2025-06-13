using System;
using System.Collections.Generic;
using UnityEngine;

namespace ColorDash.Managers.PoolManager
{
    [Serializable]
    public class GatePoolItem
    {
        public string Tag;
        public GameObject Perfab;
        public int Size;
    }

    public class Pool_Manager : MonoBehaviour
    {
        public static Pool_Manager instance;

        [Header("P E R F A B S")]
        public List<GatePoolItem> poolItems;
        public Dictionary<string, Queue<GameObject>> pooldictionary;

        private void Awake() => instance = this;

        private void Start()
        {
            pooldictionary = new();

            foreach (var Item in poolItems)
            {
                Queue<GameObject> Objectpool = new();

                for (int i = 0; i < Item.Size; i++)
                {
                    GameObject obj = Instantiate(Item.Perfab);
                    obj.SetActive(false);
                    Objectpool.Enqueue(obj);
                }
                pooldictionary.Add(Item.Tag, Objectpool);
            }
        }

        public GameObject SpawnFromPool(string tag, Transform SpawnPoint)
        {
            GameObject ObjectToSpawn = pooldictionary[tag].Dequeue();

            ObjectToSpawn.SetActive(true);
            ObjectToSpawn.transform.position = SpawnPoint.transform.position;
            pooldictionary[tag].Enqueue(ObjectToSpawn);

            return ObjectToSpawn;
        }
    }
}