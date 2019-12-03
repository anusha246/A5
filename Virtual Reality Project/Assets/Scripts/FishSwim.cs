using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSwim : MonoBehaviour
{
	
	public double t;
	public float speed = 0.5f;
	public float oscillateSpeed = 0.8f;
	
    //private Vector3 rotateValue;
	
	
    // Start is called before the first frame update
    void Start()
    {
     
	 
    }
	
    // Update is called once per frame
    void Update()
 {
	 
	 //t += Time.fixedDeltaTime;
     //rotate
	 //transform.Rotate(0, 5, 0);
     //rotateValue = new Vector3(0, 15, 0);
	 //transform.eulerAngles = transform.eulerAngles - rotateValue;
   
         
     transform.position += this.transform.forward * speed * Time.deltaTime;;
	 
	 float magnitude2 = oscillateSpeed * Mathf.Sin((Time.time / 3) * 2 * Mathf.PI);
     Vector3 newPos2 = transform.position;
     newPos2.x += magnitude2;
     transform.position = newPos2;
	 
	 transform.position += this.transform.forward * speed * Time.deltaTime;;
	 
	 //rotate other way
	 //transform.Rotate(0, -5, 0);
     //rotateValue = new Vector3(0, -15, 0);
	 //transform.eulerAngles = transform.eulerAngles - rotateValue;
     
	 
 }
}
