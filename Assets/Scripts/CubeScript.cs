using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public GameObject player;

    /*
    void Update()
    {
        
        //Get the distance to player using Vector3.Distance
        float distancetoPlayer = Vector3.Distance(player.transform.position, transform.position);

        //Debug it out
        Debug.Log("player is " + distancetoPlayer + " away from us");

        float x = player.transform.position.x - transform.position.x;
        float y = player.transform.position.y - transform.position.y;
        float z = player.transform.position.z - transform.position.z;

        //square root of the x y z squared
        x = Mathf.Pow(x, 2);
        y = Mathf.Pow(y, 2);
        z = Mathf.Pow(z, 2);

        float sqXYZ = x + y + z;


        float calcDistance + Mathf.Sqrt(sqXYZ);
        Debug.Log("Our calculated distance is " + calcDistance);
        

        Debug.Log(CalculateDistanceBetweenVectors(player.transform.position, transform.position));
        

        // look at the player
        transform.LookAt(player.transform.position);

        //grab the distance from between the vectore using out new function
        float distanceToPlayer = CalculateDistanceBetweenVectors(player.transform.position, transform.position);
        //when the player is far away (5 units), chase the player
        if ( distanceToPlayer > 5.0f)
        {
            //chasse the player
            transform.Translate(Vector3.forward * Time.deltaTime);
        }
       


    }

    public float CalculateDistanceBetweenVectors(Vector3 v1, Vector3 v2)
    {
        //square root of 1.x-2.x squared, plus 1.y-2.y squared
        float x = v1.x - v2.x;
        float y = v1.y - v2.y;
        float z = v1.z - v2.z;

        //square root of the x y z squared
        x = Mathf.Pow(x, 2);
        y = Mathf.Pow(y, 2);
        z = Mathf.Pow(z, 2);

        // add the squared values
        float sqXYZ = x + y + z;

        //

        return Mathf.Sqrt(sqXYZ);


    }

*/
}
