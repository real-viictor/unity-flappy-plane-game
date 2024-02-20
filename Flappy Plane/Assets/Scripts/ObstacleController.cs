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
        //Definindo posi��o inicial do obst�culo, o colocando fora da tela e determinando altura
        transform.position = new Vector3(10f, Random.Range(-2.25f, 0.9f), 0f); 

        //Determinando velocidade do obst�culo e multiplicando por DeltaTime para ajustar a velocidade para todos os frames do jogo
        obstacleSpeed = 0.15f * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        //Determinando que o objeto se mova para a esquerda
        transform.position += Vector3.left * obstacleSpeed; 
    }
}
