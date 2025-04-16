using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class State : MonoBehaviour
{
    private void Awake()    //데이터 받아오는걸 Awake에서
    {
        // Awake 함수란?
        // 게임 오브젝트가 생성되었을 때 단 한 번만 호출되며,
        // 스크립트가 비활성화되어 있는 상태에서도 호출되는 이벤트 함수입니다.

        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        // OnEnable 함수란?
        // 게임 오브젝트가 활성화되는 순간마다 호출되는 이벤트 함수입니다.        

        Debug.Log("OnEnable");
    }

    private void Start()    //데이터 쓰는걸 Start에서
    {
        // Start 함수란?
        // 게임 오브젝트가 생성되었을 때 단 한번만 호출되며,
        // 스크립트가 비활성화된 상태일 땐, 호출되지 않는 이벤트 함수입니다.
        // Awake 함수와는 다르게 스크립트가 비활성화되어 있는 상태에서는 호출되지 않습니다.

        Debug.Log("Start");
    }

    private void FixedUpdate()
    {
        // FixedUpdate 함수란?
        // TimeStep에 설정된 값에 따라 일정한 간격으로 호출되는 이벤트 합수입니다.

        Debug.Log("FixedUpdate");
        
    }

    private void Update()
    {
        // Update 함수란?
        // 게임이 실행되는 동안 매 프레임마다 호출되는 이벤트 함수입니다.

        Debug.Log("Update");
    }

    private void LateUpdate()
    {
        // LateUpdate 함수란?
        // Update 함수가 끝난 후에 호출되는 이벤트 함수입니다.
        // Update 함수에서 카메라의 위치를 변경한 후에, 그 위치를 기준으로 오브젝트를 이동시키고 싶을 때 사용합니다.

        Debug.Log("LateUpdate");
    }

    private void OnDisable()
    {
        // OnDisable 함수란?
        // 게임 오브젝트가 비활성화되는 순간마다 호출되는 이벤트 함수입니다.

        Debug.Log("OnDisable");
    }

    private void OnDestroy() {
        // OnDestroy 함수란?
        // 게임 오브젝트가 파괴되는 순간마다 호출되는 이벤트 함수입니다.
        // 게임 오브젝트가 파괴되기 전에 필요한 작업을 수행할 수 있습니다.

        Debug.Log("OnDestroy");
    }
    
}
