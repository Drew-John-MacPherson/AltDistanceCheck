using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{

    public Transform playertransform;
    public Transform gameobjecttransform;
    public float checkpoint1Distance = 15f;
    public float checkpoint2Distance = 10f;
    public float checkpoint3Distance = 5f;
    [SerializeField] private bool passCheckpoint1 = false;
    [SerializeField] private bool passCheckpoint2 = false;
    [SerializeField] private bool passCheckpoint3 = false;
    public MeshRenderer gameobjectRenderer;


    void Update()
    {
        float distance = Vector3.Distance(playertransform.position, gameobjecttransform.position);
        // Debug.Log(distance + "to object");

        if (distance <= checkpoint1Distance && !passCheckpoint1)
        {
            passCheckpoint1 = true;
            Debug.Log("Passed Checkpoint 1!");
            gameobjectRenderer.material = Resources.Load<Material>("Cylinder Material");
        }

        if (distance <= checkpoint2Distance && !passCheckpoint2)
        {
            passCheckpoint2 = true;
            Debug.Log("Passed Checkpoint 2!");
            gameobjectRenderer.material = Resources.Load<Material>("Capsule Material");
        }
        
        if (distance <= checkpoint3Distance && !passCheckpoint3)
        {
            passCheckpoint3 = true;
            Debug.Log("Passed Checkpoint 3!");
            gameobjectRenderer.material = Resources.Load<Material>("Cube Material");
        }
    }
}
