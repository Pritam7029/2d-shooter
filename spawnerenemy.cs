using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerenemy : MonoBehaviour
{
    [SerializeField] private GameObject[] enemies;

    public float minx;
    public float maxx;
    public int enemynumbers = 50;

    void Start()
    {
        for (int i = 0; i < enemynumbers; i++)
        {
            spawnrandomenemy(new Vector2(Random.Range(-minx, maxx), Random.Range(-minx, maxx)));
        } 
    }
   
    private void spawnrandomenemy(Vector2 pos)
    {
        GameObject prefab = enemies[Random.Range(0, enemies.Length)];
        Instantiate(prefab, pos, Quaternion.identity, transform);
      //  Debug.Log("gameobject is spawned");

    }
}
