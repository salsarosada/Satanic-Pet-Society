using UnityEngine;

public class Runner : MonoBehaviour
{
    public float fuerza;
    private bool isGrounded = false;
    Rigidbody2D RB;

    private int indicepersonaje;
    public GameObject[] personajes;
    public GameObject perder;
    public UIRunner ui;

    void Awake()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        indicepersonaje = PlayerPrefs.GetInt("Personaje");        

        //PERSONAJE
        for (int i = 0; i < personajes.Length; i++)
        {
            if (i != indicepersonaje)
            {
                Destroy(personajes[i]);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(isGrounded)
            {
                RB.AddForce(Vector2.up * fuerza);
                isGrounded = false;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            if (!isGrounded) { 
                isGrounded=true;
            }
        }

        if (collision.gameObject.CompareTag("Obstaculo"))
        {
            Time.timeScale = 0f;
            perder.gameObject.SetActive(true);
            ui.juego = false;
        }
    }    
}