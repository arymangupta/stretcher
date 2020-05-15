using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{

    public float duration = 0.01f;
    public float magnitude = 0.01f;
    public float dist  = 0.5f;
    
    private bool inProcess = false;
    public void ShakeCamera()
    {
        if(inProcess) return;
        StartCoroutine(CamShake());
    }
    public IEnumerator CamShake(){
        Vector3 orginalPos = transform.position;
        float elapsed = 0.0f;
         inProcess = true;
        while(elapsed< duration){
            float x = Random.Range(-dist , dist)*magnitude;   
            float y = Random.Range(-dist , dist)*magnitude;  
            transform.localPosition = new Vector3( x , orginalPos.y , y);   
            elapsed+=Time.deltaTime;
            yield return null;  
        }
        inProcess = false;
        transform.localPosition = orginalPos;
    }
}
