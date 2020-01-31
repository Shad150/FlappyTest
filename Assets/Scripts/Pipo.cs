using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pipo : MonoBehaviour
{

    private Rigidbody2D myRigidbody2D;
    [Range(3,8)]
    public float speed = 4f;
    public Text scoreText;
    private int score = 0;
    public Transform lookAt;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody2D.velocity = Vector2.up * speed;       //Vector2.up es el equivalente al eje y. Lo multiplico  por la velocidad.
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)      //Para q funcione se necesitan 2 colliders y un rigidbody
    {
        string sceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(sceneName);
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        score ++;
        scoreText.text = score.ToString();      //.ToString() para convertirlo en texto
    }

    private void Update()
    {
        Vector3 targetPosition = lookAt.position;
        targetPosition.x = targetPosition.x - transform.position.x;
        targetPosition.y = targetPosition.y - transform.position.y;

        float angle = Mathf.Atan2(targetPosition.y,targetPosition.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

}
