using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMove : MonoBehaviour
{
    public float s;
    
    private void Start()
    {
        s = 0.13f;
    }

    void FixedUpdate ()
    {

        //����������� ����� ������� �������
        transform.position = new Vector3(transform.position.x - s, transform.position.y, 0);

        //��������� ���� ������� ������ ��� ����� -17.5
        if (transform.position.x <= -17.5f)
        {
            // �� ���������� ������
            // Destroy(gameObject);
        }
    }
}
