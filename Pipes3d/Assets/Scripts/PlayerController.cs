using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    private Rigidbody rb;
    private GameObject pipe;
    public float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
       
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Transform playerTransform = rb.transform;
        Vector3 playerpos = playerTransform.position;
        if (Input.GetKeyDown("space"))
        {
            print("space key was pressed at x: " +playerpos.x+ ", y : " + playerpos.y);
            GameObject pipe = (GameObject)Resources.Load("pipe");
            Transform pipeTransform = pipe.transform;
            Instantiate(pipeTransform,new Vector3(playerpos.x, 1, playerpos.z),Quaternion.identity);
         //   Instantiate(playerTransform, new Vector3(playerpos.x, playerpos.y, 0), Quaternion.identity);
        }
        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        rb.AddForce(movement*speed);
    }
}
