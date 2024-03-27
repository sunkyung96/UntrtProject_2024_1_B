using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody m_Rigidbody;  //리지드 바디를 소스로 사용히게 받아 온다.
    public int Force = 100; //int 정수로 힘을 100을 설정 한다.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    //if(Input. GetMouseButtonDown(0)) //마우스 입력이 들어왔을 때
        if(Input.GetKeyDown(KeyCode.Space))
        {
            m_Rigidbody.AddForce(transform.up * Force); //transform.up(위쪽 방향)으로 리지드 바디에 Force 힘만큼 물리의 힘을 준다 
        }
    }


    private void OnCollisionEnter(Collision collision) //충돌이 시작되었을 때
    {
        if(collision !=null) //충돌 물체가 존재할 경우
        {
        Debug.Log(collision.gameObject.name); //해당 오브젝트의 이름을 출력한다.
    }
}
}
