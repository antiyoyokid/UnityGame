using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float player = 1F;
    public Vector3 playerposition ;

    Rigidbody2D rb;
    void Update()
    {
        float xPos = gameObject.transform.position.x + (Input.GetAxis("Horizontal") * player);
        float yPos = gameObject.transform.position.y + (Input.GetAxis("Vertical") * player);
        playerposition = new Vector3(Mathf.Clamp(xPos,-8,8), -4 , 0); // y was -4 here
        gameObject.transform.position = playerposition;

        
            transform.Translate(-Input.acceleration.x, 0, 0);
        
    }


}
