using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject cube1, cube2, cube3, cube4, cube5, cube6, cube7, cube8;
  
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (cube1)
        {
            gameObject.transform.position= Vector3.MoveTowards(gameObject.transform.position, cube1.transform.position, 0.03f);
            if (Vector3.Distance(cube1.transform.position, transform.position) < 0.01)
            {
                GameObject.Destroy(cube1);
            }
        }
        if (cube2&&!cube1)
        {
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, cube2.transform.position, 0.03f);
            if (Vector3.Distance(cube2.transform.position, transform.position) < 0.01)
            {
                GameObject.Destroy(cube2);
            }
        }



        if (cube3 && !cube2)
        {
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, cube3.transform.position, 0.03f);
            if (Vector3.Distance(cube3.transform.position, transform.position) < 0.01)
            {
                GameObject.Destroy(cube3);
            }
        }

        if (cube4 && !cube3)
        {
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, cube4.transform.position, 0.03f);
            if (Vector3.Distance(cube4.transform.position, transform.position) < 0.01)
            {
                GameObject.Destroy(cube4);
            }
        }

        if (cube5 && !cube4)
        {
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, cube5.transform.position, 0.03f);
            if (Vector3.Distance(cube5.transform.position, transform.position) < 0.01)
            {
                GameObject.Destroy(cube5);
            }
        }

        if (cube6 && !cube5)
        {
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, cube6.transform.position, 0.03f);
            if (Vector3.Distance(cube6.transform.position, transform.position) < 0.01)
            {
                GameObject.Destroy(cube6);
            }
        }

        if (cube7 && !cube6)
        {
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, cube7.transform.position, 0.03f);
            if (Vector3.Distance(cube7.transform.position, transform.position) < 0.01)
            {
                GameObject.Destroy(cube7);
            }
        }

        if (cube8 && !cube7)
        {
            gameObject.transform.position = Vector3.MoveTowards(gameObject.transform.position, cube8.transform.position, 0.03f);
            if (Vector3.Distance(cube8.transform.position, transform.position) < 0.01)
            {
                GameObject.Destroy(cube8);
            }
        }
    }
}
