using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    [SerializeField] float moveSpeed; //take variable and render it into inspector (please input the number above 0)

    [SerializeField] public bool canShoot;//print() not initiate it because it is always false

    [SerializeField] public GameObject projectile;

    [SerializeField] public bool isFinish;

    // Update is called once per frame
    void Update()
    {
     Movement;  
    }

    private void Movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, -1, 0));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, 1, 0));
        }
    }

    pprivate void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (canShoot) // if shoot is false, it will skip this code below.
            {
                Instantiate(projectile, transform.position, transform.rotation);
            }
        }
    }


}
