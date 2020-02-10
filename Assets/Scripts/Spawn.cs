using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject prefabObstacle;
    public float randomRange= 2.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", 0f, 1.5f);                                 //InvokeRepeating llama a una funcion, al segundo x, cada x segundos.
    }

  

    void SpawnObstacle()
    {
        Vector3 spawnpPositionFede = new Vector3();                                 //Crea un vector llamado spawnPositionFede. Le asigna un new Vector3() para que se cree un vector
        spawnpPositionFede.x = transform.position.x;
        spawnpPositionFede.y = Random.Range(randomRange, -randomRange);
        spawnpPositionFede.z = transform.position.z;
        Instantiate(prefabObstacle, spawnpPositionFede, Quaternion.identity);       //Instantiate genera un objeto, con una posicíon, y una rotacion.

    }

}
