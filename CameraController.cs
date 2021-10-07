using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameController gameCtrl;

    public bool inGame;

    public Transform target;

    private Vector3 cameraPosition = Vector3.zero;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        inGame = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(inGame == true)
        {
            cameraPosition = new Vector3(transform.position.x, Mathf.SmoothStep(transform.position.y, target.transform.position.y, speed * Time.deltaTime));
            transform.position = cameraPosition + Vector3.forward * -10;
        }
    }
}
