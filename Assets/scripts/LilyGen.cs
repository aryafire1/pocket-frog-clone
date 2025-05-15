using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LilyGen : MonoBehaviour
{
    public Transform nodeParent, lilyParent;
    public List<Transform> lilyPool;
    public List<Transform> nodes = new List<Transform>();


    void Awake() {
        CreateLists();
        SetPosition();
    }

    void CreateLists() {
        for (int i=0; i < nodeParent.childCount; ++i) {
            nodes.Add(nodeParent.GetChild(i));
        }
        for (int i=0; i < lilyParent.childCount; ++i) {
            lilyPool.Add(lilyParent.GetChild(i));
        }
    }

    void SetPosition() {
        for (int i=0; i < lilyPool.Count; ++i) {
            Transform l = lilyPool[i];
            Transform n = nodes[Random.Range(0, nodes.Count)];
            l.position = new Vector3(n.position.x, 0, n.position.y) + (RandomSize() * Random.Range(1, 3));
            l.localScale = RandomSize();
        }
    }

    Vector3 RandomSize() {
        float rand = Random.Range(0.25f, 0.75f);
        Vector3 v = new Vector3(rand, 0, rand);
        return v;
    }
}
