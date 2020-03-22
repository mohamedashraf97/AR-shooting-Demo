using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    void Update()
    {
          if (GameObject.FindGameObjectsWithTag("Player").Length <= 1){

      GameObject enemy = Instantiate(Resources.Load("enemy", typeof(GameObject))) as GameObject;
      GameObject enemy1 = Instantiate(Resources.Load("enemy1", typeof(GameObject))) as GameObject;
      GameObject enemy2 = Instantiate(Resources.Load("enemy2", typeof(GameObject))) as GameObject;
      GameObject enemy3 = Instantiate(Resources.Load("enemy3", typeof(GameObject))) as GameObject;

    }

    }
}
