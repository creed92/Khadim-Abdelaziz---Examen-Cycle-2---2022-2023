using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;
    public GameObject propeller;
    public float prospeed;

    public TextMeshProUGUI rotationText;

    private bool isGameOver = false;

    public GameObject gameOverPanel; // Référence au panel de fin de jeu
    public GameObject tutoPanel;
    public AudioSource startSound; // Sound that plays from the start
    public AudioSource endGameSound; // Sound that starts when endgame is activated

    // Start is called before the first frame update
    void Start()
    {
        if (tutoPanel.activeSelf)
        {
            Time.timeScale = 0;
        }
        else Time.timeScale = 1;

        // Play the start sound
        startSound.Play();
    }

    private void Update()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        


        if (isGameOver) return;

        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * Time.deltaTime * speed);

        transform.Rotate(Vector3.back * -rotationSpeed * Time.deltaTime * verticalInput);

        propeller.gameObject.transform.Rotate(Vector3.right * Time.deltaTime * prospeed);

        float rotationZ = transform.rotation.eulerAngles.z;
        float rotationZ2 = transform.rotation.eulerAngles.z;

        if (rotationZ > 180f)
        {
            rotationZ2 = rotationZ - 360f;
        }
        rotationText.text = rotationZ2.ToString("F2");

        if ((rotationZ >= 60f && rotationZ <= 290f) || CheckCollision())
        {
            EndGame();
        }
    }

    bool CheckCollision()
    {
        Collider[] colliders = Physics.OverlapBox(transform.position, transform.localScale / 2f, transform.rotation);

        foreach (Collider collider in colliders)
        {
            if (collider != GetComponent<Collider>())
            {
                return true;
            }
        }

        return false;
    }

    void EndGame()
    {
        isGameOver = true;
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.useGravity = true;
        rb.mass = 100000000000000000000000f;

        // Stop the start sound
        startSound.Stop();

        // Play the endgame sound
        endGameSound.Play();

        gameOverPanel.SetActive(true);
        StartCoroutine(ShowGameOverPanel(3f));
    }

    IEnumerator ShowGameOverPanel(float delay)
    {
        yield return new WaitForSeconds(delay);
        Time.timeScale = 0;

    }
}