using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerController : MonoBehaviour
{
	public Transform player;
	private Vector3 pos;
	public float offset =2f;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        pos = transform.position;
        pos.z = player.position.z + offset;
        pos.x = player.position.x;
        transform.position = pos;

    }
}
