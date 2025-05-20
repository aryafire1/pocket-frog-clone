using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LilyOverlap : MonoBehaviour
{
    void OnTriggerStay(Collider other) {
        if (other.gameObject.CompareTag("lily")) {
            Debug.Log("collision");
            Vector3 pos = other.transform.position;
            other.transform.position = new Vector3(pos.x + Random.Range(-3f, 3f), pos.y, pos.z + Random.Range(-3f, 3f));
        }
    }
}
