using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallForce : MonoBehaviour
{
    public float kickForce = 10f;
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.GetComponent<Rigidbody>() != null)
        {
            hit.gameObject.GetComponent<Rigidbody>().AddForce(this.transform.forward * 2, ForceMode.Impulse);
        }
        // button give the ball tons of force leading to a BIIIIIIIIG kick
        if (Input.GetKey(KeyCode.Q))
        {
            hit.gameObject.GetComponent<Rigidbody>().AddForce(this.transform.forward * kickForce, ForceMode.Impulse);

        }

    }
}
