using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wobble : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.localPosition = new Vector3(Mathf.Sin(4f * Time.time), Mathf.Sin(2f * Time.time), Mathf.Sin(7f * Time.time));
        gameObject.transform.localScale = new Vector3(Mathf.Sin(4f * Time.time), Mathf.Sin(4f * Time.time), Mathf.Sin(4f * Time.time));
        gameObject.transform.rotation = new Quaternion(Mathf.Sin(6f * Time.time), Mathf.Sin(8f * Time.time), Mathf.Sin(3f * Time.time), Mathf.Sin(2f * Time.time));
        GetComponent<Rigidbody>().mass = 20f * Mathf.Sin(10f * Time.time);
    }
}
