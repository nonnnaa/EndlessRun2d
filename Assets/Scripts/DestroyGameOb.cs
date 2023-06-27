using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGameOb : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Land"))
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("obstacles"))
        {
            Destroy(collision.gameObject);
        }
    }
}
