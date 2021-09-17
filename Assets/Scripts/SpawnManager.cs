using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public static SpawnManager Instance;

    [SerializeField] private bool canSpawn;
    [SerializeField] private GameObject[] entitiesPrefabs;
    [SerializeField] private Vector3 spawnPosition;
    [SerializeField] private float xMargin=2;
    [SerializeField] private float entitiesSpeed=50;
    [SerializeField] private float spawnTimer;
    [SerializeField] private float spawnTimerMax=0.5f;

     private void Awake()
     {
         Instance=this;
     }

    private void Update()
    {
      TrySpawn();
    }

    private void TrySpawn()
    {
        if(!canSpawn)
          return;
        if(spawnTimer>0)
        {
            spawnTimer-=Time.deltaTime;
        }
        else
        {
            spawnTimer=spawnTimerMax;
            spawnEntity();
        }
    }

    public void StartScript()
    {
        canSpawn=true;
        spawnTimer=spawnTimerMax;
    }

    private void spawnEntity()
    {
          GameObject entityToSpawn=entitiesPrefabs[Random.Range(0,entitiesPrefabs.Length)];
          spawnPosition.x=Random.Range(-xMargin,xMargin);
          GameObject spawnEntity = Instantiate(entityToSpawn,spawnPosition,Quaternion.identity);
          spawnEntity.GetComponent<Rigidbody2D>().velocity=new Vector2(0,-entitiesSpeed);
    }


    
}
