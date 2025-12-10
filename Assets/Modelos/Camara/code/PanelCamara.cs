using UnityEngine;

public class PanelCamara : MonoBehaviour
{
    public GameObject panelCamaras , estatic;
    public GameObject camPlayer, cam1, cam2, cam3;
    public GameObject objectATuControlar;
    public bool activcamaras;

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (panelCamaras ==true)
            {

            }
        }
        
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (panelCamaras ==false)
            {
                
            }
        }
    }

}


