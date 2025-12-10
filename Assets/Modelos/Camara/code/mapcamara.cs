using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class mapcamara : MonoBehaviour
{
    public GameObject panelCamaras , estatic;
    public  GameObject camPlayer, cam1, cam2, cam3;
    public bool activcamaras;
    

    private void Update()
    {
        camara1();
        camara2();
        camara3();
        
       if (panelCamaras != null)
       {
         if (Input.GetKeyDown(KeyCode.Q))
        {
            if (activcamaras == true)
            {

            }
            
            if (panelCamaras == false)
            {
      
            }

            if (activcamaras)
            {
                panelCamaras.SetActive(true);
            }

            else
            {
                panelCamaras.SetActive(false);
                cam1.SetActive(false);
                cam2.SetActive(false);
                cam3.SetActive(false);
                camPlayer.SetActive(true);
            }
            
        }
       }
    }

    public void camara1()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            cam1.SetActive(true);
            cam2.SetActive(false);
            cam3.SetActive(false);
            camPlayer.SetActive(false);
            estatic.SetActive(true);
        }
    }

    public void camara2()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
            cam3.SetActive(false);
            camPlayer.SetActive(false);
            estatic.SetActive(true);
        }
    }

    public void camara3()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(true);
            camPlayer.SetActive(false);
            estatic.SetActive(true);
        }
    }
}
