using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pipo : MonoBehaviour
{

    private Rigidbody2D myRigidbody2D;
    [Range(3,8)]                                                                             //Determina un rango para la variable de velocidad entre 3 y 8.
    public float speed = 4f;

    public Text scoreText;
    private int score = 0;


    private int highscore = 0;
    public Text highscoreText;

    public Transform lookAt;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();

        highscore = PlayerPrefs.GetInt("highScore");
        highscoreText.text = "HIGHSCORE: " + highscore.ToString();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody2D.velocity = Vector2.up * speed;                                    //Vector2.up es el equivalente al eje y. Lo multiplico  por la velocidad.
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)                                  //Para q funcione se necesitan 2 colliders y un rigidbody.
    {
        string sceneName = SceneManager.GetActiveScene().name;                              //Recoge el nombre de la escena.
        SceneManager.LoadScene(sceneName);                                                  //Carga la escena con el nombre recogido.

        PlayerPrefs.SetInt("score", score);

        if (PlayerPrefs.GetInt("highScore") < score)
        {
            PlayerPrefs.SetInt("highScore", score);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        score ++;

        scoreText.text = score.ToString();      //.ToString() para convertirlo en texto
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody2D.velocity = Vector2.up * speed;       //Vector2.up es el equivalente al eje y. Lo multiplico  por la velocidad.
        }

        Vector3 targetPosition = lookAt.position;                                           //Crea un Vector3 que guarda la posicion de lookAt.
        targetPosition.x = targetPosition.x - transform.position.x;                         //Resta la posición del vector con la actual en x.
        targetPosition.y = targetPosition.y - transform.position.y;                         //Lo mismo pero en y.

        float angle = Mathf.Atan2(targetPosition.y,targetPosition.x) * Mathf.Rad2Deg;       //Crea un float para almacenar el resultado de utilizar las funciones matemáticas para conseguir el angulo.
        transform.rotation = Quaternion.Euler(0, 0, angle);                                 //Le aplica la rotacion con el angulo calculado para que siga con la vista al objeto.
    }

}
