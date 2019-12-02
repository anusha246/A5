using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
	public float speed = 5.0f;
	private float x;
    private float y;
    private Vector3 rotateValue;
	
	
    // Start is called before the first frame update
    void Start()
    {
        
    }
	
    // Update is called once per frame
    void Update()
 {
     if(Input.GetKey(KeyCode.RightArrow))
     {
         transform.Translate(new Vector3(speed * Time.deltaTime,0,0));
     }
     if(Input.GetKey(KeyCode.LeftArrow))
     {
         transform.Translate(new Vector3(-speed * Time.deltaTime,0,0));
     }
     if(Input.GetKey(KeyCode.DownArrow))
     {
         transform.Translate(new Vector3(0,-speed * Time.deltaTime,0));
     }
     if(Input.GetKey(KeyCode.UpArrow))
     {
         transform.position += this.transform.forward * speed * Time.deltaTime;;
     }
	 
	 y = Input.GetAxis("Mouse X");
     x = Input.GetAxis("Mouse Y");
     Debug.Log(x + ":" + y);
	 rotateValue = new Vector3(x, y * -1, 0);
	 transform.eulerAngles = transform.eulerAngles - rotateValue;
 }
}
