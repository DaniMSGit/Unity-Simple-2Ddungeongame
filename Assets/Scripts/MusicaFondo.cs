using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MusicaFondo : MonoBehaviour {

    public AudioSource AudioSource;
    public Slider volumen;
    bool sound = true;

    void Start() {

        AudioSource.volume = GameMaster.volumen;
        volumen.value = GameMaster.volumen;
        AudioSource.mute = GameMaster.sonido;
        sound = GameMaster.sonido;
    }
    



    public void sonido()
    {
        sound = !sound;
        if (!sound)
            {
                AudioSource.mute = false;
                GameMaster.sonido = false;
                
            }
            else
            {
                AudioSource.mute = true;
                GameMaster.sonido = true;     
            }
        
    }

    public void subirbajarV(float volumen)
    {
        AudioSource.volume = volumen;
        GameMaster.volumen = volumen;
    }

}
