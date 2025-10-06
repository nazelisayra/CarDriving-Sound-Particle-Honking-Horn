using TMPro;

using UnityEngine;



public class PlayerController : MonoBehaviour

{



    public AudioSource ExplosionAudio;



    public GameObject ExplosionPrefab;





    public float speed = 20;

    private float turnSpeed = 50;

    private float horizontalInput;

    private float forwardInput;



    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()

    {



    }



    // Update is called once per frame

    void Update()

    {

        horizontalInput = Input.GetAxis("Horizontal");

        forwardInput = Input.GetAxis("Vertical");



        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

    }





    void OnTriggerEnter(Collider other)

    {

        if (other.gameObject.CompareTag("Barrel_02"))

        {

            other.gameObject.SetActive(false);









            ExplosionAudio.Play();

            Vector3 explositionPosition = other.gameObject.transform.position;

            Instantiate(ExplosionPrefab, explositionPosition, Quaternion.identity);

        }



    }



}