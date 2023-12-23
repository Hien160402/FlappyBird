using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MovePipe : MonoBehaviour
{
    [SerializeField] private Vector3 vel;
    [SerializeField] private GameObject[] Pipe;
    [SerializeField] private GameObject[] target;
    public static MovePipe instance;
    public static float speed = 1f;


    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        Pipe[0].transform.position += Vector3.left * Time.deltaTime * speed;
        Pipe[1].transform.position += Vector3.left * Time.deltaTime * speed;

        if (Pipe[0].transform.position.x < Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).x-1)
        {
            Pipe[0].transform.position = new Vector3(3, Random.Range(-1, 1));
            Bird.temp[0] = 1;
            target[0].SetActive(true);
        }
        if (Pipe[1].transform.position.x < Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0)).x-1)
        {
            Pipe[1].transform.position = new Vector3(3, Random.Range(-1, 1));
            Bird.temp[1] = 1;
            target[1].SetActive(true);
        }
    }
}
