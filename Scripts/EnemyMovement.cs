using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
    public Vector3 seekPoint;
    GameObject helper;

    // Use this for initialization
    void Awake()
    {
        helper = new GameObject();
        helper.transform.parent = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    ///  I am the spherical wandering function. I use a random point circeling a 
    /// sphere to impliment wandering
    /// </summary>
    //void WanderSphere()
    //{
    //    // slowly move shift
    //    wanderCount -= Time.deltaTime;
    //    // only update wanderVal on timeed event
    //    if (wanderCount < 0)
    //    {
    //        wanderCount = wanderCountMax;
    //        wanderVal = Random.Range(-wanderRandMax, wanderRandMax);
    //    }
    //    wanderYaw += wanderVal * Time.deltaTime *
    //        Mathf.Cos(wanderCount * 6.28f / wanderCountMax);	// sin added for smooth curve

    //    //if(wanderYaw < -180) wanderYaw+=360;
    //    //if(wanderYaw > 180) wanderYaw-=360;

    //    helper.transform.rotation = Quaternion.identity;
    //    helper.transform.Rotate(Vector3.up, wanderYaw);//+myMoveObj.curYaw

    //    seekPoint = transform.position + helper.transform.forward * 10f;
    //}
}
