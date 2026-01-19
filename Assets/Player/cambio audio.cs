using Unity.VisualScripting;
using UnityEngine;

public class cambioaudio : MonoBehaviour
{
    public AudioClip ClipPasosX;
    public GameObject player;

    private void OnCollisionEnter(Collision other)
    {
      if(other.tag=="Player")
        {
            {
                Debug.Log("Hola");
                player.GetComponent<AudioSource>().clip = ClipPasosX;
            }
        }
    }

}
