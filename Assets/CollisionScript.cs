
using UnityEngine;
using System.Collections;

public class CollisionScript : MonoBehaviour {

  //for this to work both need colliders, one must have rigid body (spaceship) the other must have is trigger checked.
  void OnTriggerEnter (Collider col)
  {
   //GameObject explosion = Instantiate(Resources.Load("FlareMobile", typeof(GameObject))) as GameObject;
   // explosion.transform.position = transform.position;
    Destroy(col.gameObject);
   //Destroy (explosion, 2);
    Destroy (gameObject);
  }

}

