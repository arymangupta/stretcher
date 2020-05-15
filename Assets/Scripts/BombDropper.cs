using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombDropper : MonoBehaviour
{
    public GameObject[] bomb;
    public float dropHeight =5f;
    public float zRandom = 5;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("DropBomb", 2.0f, 2f);
        player =  GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   void DropBomb(){
       Vector3 pos = player.transform.position;
       float z = Random.Range(0 , zRandom);
       float x = Random.Range(0 , zRandom);
       pos.z+=z;
       pos.y = pos.y+dropHeight;
       int i  = Random.Range( 0 , bomb.Length);
       Instantiate(bomb[i] , pos , Quaternion.identity);
   }
}
