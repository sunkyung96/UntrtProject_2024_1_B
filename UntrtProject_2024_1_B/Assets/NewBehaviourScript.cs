using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody m_Rigidbody;  //������ �ٵ� �ҽ��� ������� �޾� �´�.
    public int Force = 100; //int ������ ���� 100�� ���� �Ѵ�.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    //if(Input. GetMouseButtonDown(0)) //���콺 �Է��� ������ ��
        if(Input.GetKeyDown(KeyCode.Space))
        {
            m_Rigidbody.AddForce(transform.up * Force); //transform.up(���� ����)���� ������ �ٵ� Force ����ŭ ������ ���� �ش� 
        }
    }


    private void OnCollisionEnter(Collision collision) //�浹�� ���۵Ǿ��� ��
    {
        if(collision !=null) //�浹 ��ü�� ������ ���
        {
        Debug.Log(collision.gameObject.name); //�ش� ������Ʈ�� �̸��� ����Ѵ�.
    }
}
}
