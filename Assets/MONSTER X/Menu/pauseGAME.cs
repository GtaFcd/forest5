using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseGAME : MonoBehaviour
{
    public GameObject menuPausa;
    public bool playerPausado = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (playerPausado)
            {
                Reanudar();
            }
            else
            {
                Pausar();
            }
        }
    }

    public void Reanudar()
    {
        menuPausa.SetActive(false);
        Time.timeScale = 1;
        playerPausado = false;
    }

    public void Pausar()
    {
        menuPausa.SetActive(true);
        Time.timeScale = 0;
        playerPausado = true;
    }
}

