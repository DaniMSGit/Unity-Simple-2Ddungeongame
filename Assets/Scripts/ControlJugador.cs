using UnityEngine;
using System.Collections;

public class ControlJugador : MonoBehaviour {

	public AudioSource sonidoespada;
    public float VelocidadMov;
    private float VelocidadActual;
    public float ModificadorDiagonal;

    private Animator anim;
    private Rigidbody2D cuerpoRigido;
    private bool JugadorMoviendose;
    public Vector2 ultimoMov;

    private static bool ExisteJugador;
    private bool atacando;
    public float tiempoAtacando;
    private float tiempoAtacandoContador;
    private bool reset = false;

	// Use this for initialization
	void Start () {

        GameMaster.Jugador = gameObject;

        anim = GetComponent<Animator>();
        cuerpoRigido = GetComponent<Rigidbody2D>();
        

        
        if (!ExisteJugador)
        {
            ExisteJugador = true;
            DontDestroyOnLoad(transform.gameObject);
        }else
        {
            Destroy(gameObject);
        }
	}

    // Update is called once per frame
    void Update() {

        JugadorMoviendose = false;

        if (reset == true) {
            ultimoMov = new Vector2(0f, 0f);
			this.transform.position = new Vector3(-0.35f, -1.13f,0f);
            reset = false;
        }

        if (!atacando)
        { 
            if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
            {
                //transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * VelocidadMov * Time.deltaTime,0f,0f));
                cuerpoRigido.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * VelocidadActual, cuerpoRigido.velocity.y);
                JugadorMoviendose = true;
                ultimoMov = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
            }

            if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
            {
                //transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * VelocidadMov * Time.deltaTime, 0f));
                cuerpoRigido.velocity = new Vector2(cuerpoRigido.velocity.x, Input.GetAxisRaw("Vertical") * VelocidadActual);
                JugadorMoviendose = true;
                ultimoMov = new Vector2(0f, Input.GetAxisRaw("Vertical"));
            }

            if (Input.GetAxisRaw("Horizontal") < 0.5f && Input.GetAxisRaw("Horizontal") > -0.5f)
            {
                cuerpoRigido.velocity = new Vector2(0f, cuerpoRigido.velocity.y);

            }

            if (Input.GetAxisRaw("Vertical") < 0.5f && Input.GetAxisRaw("Vertical") > -0.5f)
            {
                cuerpoRigido.velocity = new Vector2(cuerpoRigido.velocity.x,0f);
            }

            if (Input.GetKey(KeyCode.Space))
            {
				if(tiempoAtacandoContador < 0) sonidoespada.Play();
                tiempoAtacandoContador = tiempoAtacando;
                atacando = true;
                cuerpoRigido.velocity = Vector2.zero;
                anim.SetBool("JugadorAtacando", true);
            }

            if (Mathf.Abs(Input.GetAxis("Horizontal")) > 0.5f && Mathf.Abs(Input.GetAxis("Vertical")) > 0.5f)
            {
                VelocidadActual = VelocidadMov * ModificadorDiagonal;
            }
            else {
                VelocidadActual = VelocidadMov;
            }
        }

        if (tiempoAtacandoContador >= 0)
        {
            tiempoAtacandoContador -= Time.deltaTime;
        }

        if(tiempoAtacandoContador < 0)
        {
            atacando = false;
            anim.SetBool("JugadorAtacando", false);
        }

        anim.SetFloat("MoveX", Input.GetAxisRaw("Horizontal"));
        anim.SetFloat("MoveY", Input.GetAxisRaw("Vertical"));
        anim.SetBool("JugadorMoviendose", JugadorMoviendose);
        anim.SetFloat("LastMoveX", ultimoMov.x);
        anim.SetFloat("LastMoveY", ultimoMov.y);
    }

    public void resetear() {

        reset = true;
    }
}
