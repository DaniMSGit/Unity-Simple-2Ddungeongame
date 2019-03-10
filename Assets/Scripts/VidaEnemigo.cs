using UnityEngine;
using System.Collections;

public class VidaEnemigo : MonoBehaviour {


    private int Vida;
    
    // Use this for initialization
    void Start()
    {
		
        Vida = GameMaster.VidaEnemigo;
    }





    // Update is called once per frame
    void Update()
    {

        if (Vida <= 0)
        {
			
			Destroy(gameObject);
            
        }

    }

    public void herirEnemigo(int valor)
    {
        Vida -= valor;
    }

    public void Curar()
    {
        Vida = GameMaster.VidaEnemigo;

    }
}
