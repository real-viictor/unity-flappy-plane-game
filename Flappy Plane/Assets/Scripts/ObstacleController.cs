using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ObstacleController : MonoBehaviour
{
    private float obstacleSpeed;

    // Start is called before the first frame update
    void Start()
    {
        //Definindo posição inicial do obstáculo, o colocando fora da tela e determinando altura
        transform.position = new Vector3(10f, Random.Range(-2.25f, 0.9f), 0f); 

        //Determinando velocidade do obstáculo e multiplicando por DeltaTime para ajustar a velocidade para todos os frames do jogo
        obstacleSpeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        //Determinando que o objeto se mova para a esquerda
        transform.position += Vector3.left * obstacleSpeed * Time.deltaTime; 
    }
}
