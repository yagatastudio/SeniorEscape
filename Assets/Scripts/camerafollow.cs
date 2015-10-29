using UnityEngine;
using System.Collections;

public class camerafollow : MonoBehaviour {

	public Transform target;
        public int cameraDistance = -10;
 
        void Update ()
        {
                transform.position = new Vector3 (target.position.x, target.position.y, cameraDistance);
        }
}

