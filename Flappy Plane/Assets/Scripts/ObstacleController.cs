using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class ObstacleController : MonoBehaviour
{
    // Vari�vel que guarda velocidade da montanha
    private float obstacleSpeed;

    private GameController game;

    // Start is called before the first frame update
    void Start()
    {
        //Definindo posi��o inicial do obst�culo, o colocando fora da tela e determinando altura
        transform.position = new Vector3(10f, Random.Range(-2.25f, 0.9f), 0f);

        //Localizando objeto do GameController na cena via c�digo
        game = FindObjectOfType<GameController>();

    }

    // Update is called once per frame
    void Update()
    {
        MoveObstacle();
    }

    void MoveObstacle()
    {
        //Determinando que o objeto se mova para a esquerda
        transform.position += Vector3.left * obstacleSpeed * Time.deltaTime;

        //Incrementando velocidade da montanha baseado na dificuldade do jogo
        obstacleSpeed = 4f + game.getLevel();

        //Destruindo o obst�culo ap�s sair da tela pela esquerda
        if (transform.position.x < -11.5f)
        {
            Destroy(this.gameObject);
        }
    }
}
