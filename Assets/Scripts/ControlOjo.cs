using UnityEngine;
using System.Collections;

public class ControlOjo : MonoBehaviour {

    public float Velocidad;
    private Rigidbody2D miCuerpo;
    private bool moviendose;
    public float tiempoEntreMovimiento;
    private float tiempoEntreMovimientoContador;
    public float tiempoMoviendose;
    private float tiempoMoviendoseContador;
    private Vector3 DireccionMov;

	// Use this for initialization
	void Start () {
        miCuerpo = GetComponent<Rigidbody2D>();

        //tiempoEntreMovimientoContador = tiempoEntreMovimiento;
        //tiempoMoviendoseContador = tiempoMoviendose;

        tiempoEntreMovimientoContador = Random.Range(tiempoEntreMovimiento * 0.75f, tiempoEntreMovimiento * 1.25f);
        tiempoMoviendoseContador = Random.Range(tiempoMoviendose * 0.75f, tiempoMoviendose * 1.25f);
    }
	
	// Update is called once per frame
	void Update () {

        if (GameObject.Find("Jugador") != null)
        {
            Transform target = GameObject.Find("Jugador").transform;
            var distance = Vector3.Distance(transform.position, target.position);
            if (distance <= 5f) { 
                Vector3 targetDirection = target.position - transform.position;
                transform.position += targetDirection.normalized * 2f * Time.deltaTime;
            }else
            {
                if (moviendose)
                {
                    tiempoMoviendoseContador -= Time.deltaTime;
                    miCuerpo.velocity = DireccionMov;

                    if (tiempoMoviendoseContador < 0f)
                    {
                        moviendose = false;
                        //tiempoEntreMovimientoContador = tiempoEntreMovimiento;
                        tiempoEntreMovimientoContador = Random.Range(tiempoEntreMovimiento * 0.75f, tiempoEntreMovimiento * 1.25f);
                    }
                }
                else
                {
                    tiempoEntreMovimientoContador -= Time.deltaTime;
                    miCuerpo.velocity = Vector2.zero;
                    if (tiempoEntreMovimientoContador < 0f)
                    {
                        moviendose = true;
                        //tiempoMoviendoseContador = tiempoMoviendose;
                        tiempoMoviendoseContador = Random.Range(tiempoMoviendose * 0.75f, tiempoMoviendose * 1.25f);
                        DireccionMov = new Vector3(Random.Range(-1f, 1f) * Velocidad, Random.Range(-1f, 1f) * Velocidad, 0f);
                    }
                }

            }
        }


        

    }

    void OnCollisionEnter2D(Collision2D otro)
    {
        /*if (otro.gameObject.name == "Jugador") {
            //Destroy(otro.gameObject);
            otro.gameObject.SetActive(false);
        }*/


    }
}
