using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{

    [System.Serializable]

    public class Pool
    {
        public string name;
        public GameObject prefab;
        public int maxNumber;
        public Queue<GameObject> objects = new Queue<GameObject>();
    }

    public Pool[] pools;

    public static ObjectPooler instance;

    void Awake()
    {
        instance = this;
        foreach (Pool pool in pools)
        {
            for (int i = 0; i < pool.maxNumber; i++)
            {
                GameObject o = Instantiate(pool.prefab);
                o.SetActive(false);
                pool.objects.Enqueue(o);

            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject InstantiateFromPool(int index, Vector3 pos, Quaternion rotation)
    {
        GameObject o = pools[index].objects.Dequeue();
        o.SetActive(true);
        o.transform.position = pos;
        o.transform.rotation = rotation;
        pools[index].objects.Enqueue(o);
        return o;
    }

      // In Player Controller

      // "ObjectPooler.instance.InstantiateFromPool(0, this.transform.position, Quaternion.identity);"
      //"showAd();"


    // Update is called once per frame
    void Update()
    {
        
    }



}
