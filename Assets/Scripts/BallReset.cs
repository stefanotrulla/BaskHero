using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallReset : MonoBehaviour
{
    public GameObject ball;
    public float delay;
    public Vector3 ballResetPosition;

    private void OnCollisionEnter(Collision collision)
    {
        print("Dentro IF");
        StartCoroutine(ReloadSceneAfterDelay(delay));
    }

    IEnumerator ReloadSceneAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        Instantiate(ball);
        ball.transform.position = ballResetPosition;
        print("Dentro IEnumerator");
    }

    public void CollisioneCuletto ()
    {
        print("Dentro IUtile");
        StartCoroutine(ReloadSceneAfterDelay(delay));

    }

}


