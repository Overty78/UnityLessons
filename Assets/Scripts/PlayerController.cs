using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed = 5;
    public int rotationSpeed = 50;

    private float verticalInput;
    private float horizontalInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput= Input.GetAxis("Vertical");
        horizontalInput= Input.GetAxis("Horizontal");

         transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput); 
         
         transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime * horizontalInput);
         //transform.position = new Vector3(0,0,5);
    }
}
