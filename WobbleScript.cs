using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WobbleScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.localPosition = new Vector3(Mathf.Sin(1.2f * Time.time), Mathf.Sin(3f* Time.time), Mathf.Sin(4f * Time.time));
        gameObject.transform.localScale = new Vector3(Mathf.Sin(3f * Time.time), Mathf.Sin(2f * Time.time), Mathf.Sin(1f * Time.time));
        gameObject.transform.rotation = new Quaternion(Mathf.Sin(3f * Time.time), Mathf.Sin(2f * Time.time), Mathf.Sin(1f * Time.time), Mathf.Sin(1.5f * Time.time));
        GetComponent<Rigidbody>().mass = 20f*Mathf.Sin(20f * Time.time);
    }
}
