using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    //Localizando o material que renderiza o Background
    private Renderer background;

    private float backgroundXOffset = 0f;

    // Start is called before the first frame update
    void Start()
    {
        //Pegando o renderer do background do jogo
        background = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        backgroundXOffset += Time.deltaTime;

        background.material.mainTextureOffset = Vector2.right * backgroundXOffset;
    }
}
