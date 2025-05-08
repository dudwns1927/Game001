using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] bool state;
    [SerializeField] new Rigidbody rigidbody;
    [SerializeField] Vector3 direction;

    private void Awake() {
        rigidbody = GetComponent<Rigidbody>();
    
    }
    /*
    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            state = true;
        }

    }
    */

    private void Start() {
        StartCoroutine(Coroutine());
    }

    private void FixedUpdate() {
        // ForceMode.Force : 매 프레임마다 지속적인 힘을 가하는 함수입니다. (Mass를 받는다)
        // ForceMode.Impulse : 순간적인 힘을 가하는 함수입니다. (Mass를 받지 않는다)
        // ForceMode.Acceleration : 매 프레임마다 지속적인 힘을 가하는 함수입니다. (Mass를 받지 않는다)
        // ForceMode.VelocityChange : 순간적인 힘을 가하는 함수입니다. (Mass를 받지 않는다)

        if (state) {
            rigidbody.AddForce(direction, ForceMode.Impulse);

            state = false;
        }
        
    }

    IEnumerator Coroutine() {
        while (true) {
            Debug.Log("Coroutine Start");

            yield return new WaitForSeconds(2);

            state = true;
            Debug.Log("Coroutine Exit");
        }

    }


}
