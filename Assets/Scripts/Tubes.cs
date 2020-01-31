using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tubes : MonoBehaviour
{

    public float speed= 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyRodri", 6f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + speed * Time.deltaTime * Vector3.left;
    }

    private void DestroyRodri()
    {
        Destroy(gameObject);
    }

}
