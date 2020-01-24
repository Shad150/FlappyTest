using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    public GameObject prefabObstacle;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", 0f, 0.5f);
    }

  

    void SpawnObstacle()
    {
        Instantiate(prefabObstacle, transform.position, Quaternion.identity);

    }

}
