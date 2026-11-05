using UnityEngine;

public class PlayerController : MonoBehaviour
{ 
    public int speed ;
    public int xBounds ;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput= Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);

        if(transform.position.x > xBounds)
        {
            transform.position = new Vector3(xBounds,transform.position.y,transform.position.z);
        
        }

        if(transform.position.x < -xBounds)
        {
            transform.position = new Vector3(-xBounds,transform.position.y,transform.position.z);

        }
    }
}
