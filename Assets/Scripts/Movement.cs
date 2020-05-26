using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float scrollSpeed;

    public List<Renderer> scrollingRenderers = new List<Renderer>();

    private GameManager gameManager;

    public float speed = 0.0f; //current speed
    private float desiredSpeed;
    private float pos; //total texture offset
    public float acceleration = 0.1f;


    public float horizontalSpeed = 1; // speed in meters per second
    public float driftSpeed = 1; // speed in meters per second


    void Start()
    {
        // get references to scrolling textures
        GameObject[] scrollingObjects = GameObject.FindGameObjectsWithTag("ScrollingTexture");
        foreach (GameObject gameObject in scrollingObjects)
        {
            scrollingRenderers.Add(gameObject.GetComponent<Renderer>());
        }

        gameManager = FindObjectOfType<GameManager>();


        // start moving
        desiredSpeed = scrollSpeed;
    }

    public Vector3 playerControls()
    {
        Vector3 moveDir = Vector3.zero;
        moveDir.x = Input.GetAxis("Horizontal");
        return moveDir;
    }

    void Move()
    {


        float x = speed / desiredSpeed;

        float t = InverseEaseInQuart(x);

        t += Time.deltaTime * acceleration;

        x = EaseInQuart(t);

        speed = x * desiredSpeed;


        Vector3 moveDir = playerControls();

        //add current speed to the position
        pos += speed * Time.deltaTime;

        Vector2 offset = new Vector2(0, pos);
        foreach (Renderer renderer in scrollingRenderers)
        {
            renderer.material.SetTextureOffset("_MainTex", offset);
        }


        // horizontal movement
        transform.position += moveDir * -horizontalSpeed * speed * Time.deltaTime;

        // sideways drift
        transform.position += transform.right * driftSpeed * speed * Time.deltaTime;
    }

    public float EaseInQuart(float t)
    {
        return Mathf.Pow(Mathf.Clamp01(t), 4f);
    }

    public float InverseEaseInQuart(float x)
    {
        return Mathf.Pow(Mathf.Clamp01(x), 0.25f);
    }

    void Update()
    {
        // my kingdom for a trigger
        if (gameManager.gameStarted == false && Input.anyKey)
        {
            gameManager.StartGame();
        }



        if (gameManager.gameStarted == true)
        {
            Move();

            // to make sure you can't lose after winning
            if (gameManager.gameWon == false)
            {
                // checks if out of bounds
                if (transform.position.x > 5 || transform.position.x < -5)
                {
                    gameManager.EndGame();
                }
            }

        }

        if (gameManager.gameOver == true || gameManager.gameWon == true)
        {
            desiredSpeed = 0;
            horizontalSpeed = 0;
            driftSpeed = 0;
        }
    }
}
