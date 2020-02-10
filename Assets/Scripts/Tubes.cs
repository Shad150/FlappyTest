using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tubes : MonoBehaviour
{

    public float speed= 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyRodri", 6f);                                                                 //Llama a una función, al segundo x.
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + speed * Time.deltaTime * Vector3.left;            //Aplica el movimiento de las tuberias hacia la izquierda. la posicion +  la velocidad de la variable speed * el tiempo * la variable x.
    }

    private void DestroyRodri()
    {
        Destroy(gameObject);                                                                        //Destruye el objeto.
    }

}
