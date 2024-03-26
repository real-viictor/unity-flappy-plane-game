using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    //Criando variável que controla o timer e atribuindo intervalo inicial do timer
    [SerializeField] private float timer = 2f;

    //Criando variável de controle de pontos
    private float points = 0f;

    //Criando variável que recebe o GameObject da montanha
    [SerializeField] private GameObject obstacle;

    //Criando variáveis de display na interface
    [SerializeField] private Text pointsDisplay;
    [SerializeField] private Text levelDisplay;

    //Criando variáveis de controle de level
    private int gameLevel = 1;
    [SerializeField] private int pointsToUpLevel = 10;

    private AudioSource levelUpSound;

    // Start is called before the first frame update
    void Start()
    {
        //Exibindo level do jogo na tela
        levelDisplay.text = "Level " + gameLevel.ToString();

        levelUpSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        CreateMountains();
        AddPoints();
        AddLevel();
    }

    //Criando montanhas baseado num timer
    void CreateMountains()
    {
        //Reduzindo tempo do timer por frame do jogo
        timer -= Time.deltaTime;
        
        //Se o valor do timer for menor ou igual a zero, instancie a montanha e redefina o timer
        if (timer <= 0)
        {
            //Redefinindo valor aleatório para o timer
            timer = Random.Range(1, 3);
            
            
            //Instanciando montanha
            Instantiate(obstacle);
        }
    }

    void AddPoints()
    {
        //Adicionando pontos ao jogador por tempo
        points += Time.deltaTime;

        //Exibindo pontos na tela
        pointsDisplay.text = "Pontos: " + Mathf.Round(points).ToString();
    }

    void AddLevel()
    {
        if(points >= pointsToUpLevel)
        {
            //Subindo nível do jogador em 1
            gameLevel++;

            //Dobrando o total de pontos necessário para passar de nível
            pointsToUpLevel*=2;

            //Alterando o level do jogo na tela quando o usuário passa de nível
            levelDisplay.text = "Level " + gameLevel.ToString();

            levelUpSound.Play();
        }
    }

    public int getLevel()
    {
        return gameLevel;
    }
}
