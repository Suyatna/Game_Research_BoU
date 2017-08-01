using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorPlatformer : MonoBehaviour {

    public GameObject myPlatformer;
    //public Rigidbody2D pijakan;
    public float distanceBetween;
    public Transform generationPoint;

    public float Posisix;

    private float widthPlatformer;

	// Use this for initialization
	void Start () {
        //widthPlatformer = myPlatformer.GetComponent<BoxCollider2D>().size.x;
        //myPlatformer = GetComponent<GameObject>();
		
	}
	
	// Update is called once per frame
	void Update () {

        Posisix = Random.Range(-3, 3);

		if (transform.position.y < generationPoint.position.y)
        {
            transform.position = new Vector3(Posisix, transform.position.y + distanceBetween, 0);
            Instantiate(myPlatformer, transform.position, transform.rotation);
            //Rigidbody2D clone;
            //clone = Instantiate(pijakan, transform.position, transform.rotation) as Rigidbody2D;
        }
	}
}
