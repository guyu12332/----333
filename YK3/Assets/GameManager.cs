using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject boy, bear, cubeboss;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            Physics.Raycast(ray, out hit);
            Debug.LogError(hit.point.x);
            if (bear&&boy&&cubeboss)
            {
                if (hit.point.x <= -2)
                {
                    GameObject.Destroy(bear);
                    GameObject.Destroy(cubeboss);
                    Camera.main.transform.SetParent(boy.transform);
                    Camera.main.transform.position = boy.transform.position + new Vector3(0.2f, 1, 0);
                    Camera.main.transform.rotation = new Quaternion(0, 0, 0,0);
                    boy.AddComponent<Player>();
                }
                if (hit.point.x >= 0 && hit.point.x <= 1)
                {
                    GameObject.Destroy(boy);
                    GameObject.Destroy(cubeboss);
                    Camera.main.transform.SetParent(bear.transform);
                    Camera.main.transform.position = bear.transform.position + new Vector3(0.2f, 1, 0);
                    Camera.main.transform.rotation = new Quaternion(0, 0, 0, 0);
                    bear.AddComponent<Player>();
                }
                if (hit.point.x >= 2)
                {
                    GameObject.Destroy(bear);
                    GameObject.Destroy(boy);
                    Camera.main.transform.SetParent(cubeboss.transform);
                    Camera.main.transform.position = cubeboss.transform.position + new Vector3(0.2f, 1, 0);
                    Camera.main.transform.rotation = new Quaternion(0, 0, 0, 0);
                    cubeboss.AddComponent<Player>();
                }
            }
           
        }
       
    }
}
