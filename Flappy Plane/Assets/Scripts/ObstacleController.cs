using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class ObstacleController : MonoBehaviour
{
    //Definindo velocidade base da montanha
    private float obstacleSpeed = 4f;

    private GameController game;

    private int currentLevel;

    // Start is called before the first frame update
    void Start()
    {
        //Definindo posição inicial do obstáculo, o colocando fora da tela e determinando altura
        transform.position = new Vector3(10f, Random.Range(-2.25f, 0.9f), 0f);

        //Localizando objeto do GameController na cena via código
        game = FindObjectOfType<GameController>();

        //Coletando nível atual do jogador
        currentLevel = game.getLevel();

        //Incrementando velocidade da montanha baseado na dificuldade do jogo
        obstacleSpeed += currentLevel;
    }

    // Update is called once per frame
    void Update()
    {
        MoverObstaculo();
    }

    void MoverObstaculo()
    {
        //Determinando que o objeto se mova para a esquerda
        transform.position += Vector3.left * obstacleSpeed * Time.deltaTime;

        //Destruindo o obstáculo após sair da tela pela esquerda
        if (transform.position.x < -11.5f)
        {
            Destroy(this.gameObject);
        }
    }
}
