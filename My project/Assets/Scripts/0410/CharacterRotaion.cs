using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRotion : MonoBehaviour
{
    float rotSpeed = 0;                                                         //�Ÿ� ���̳� ȸ�� ���� ������ ������ ���� (float)
    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10000;
        }

        transform.Rotate(0, this.rotSpeed * Time.deltaTime, 0);                 //ĳ���͸� y���� ȸ���ϴ� ���·� ������.
                                                                                //Time delta ���� �������� ����Ǿ ������ ���� �����ؼ� �������Ѵ�.
        rotSpeed *= 0.99f;  
    }                                                                           //�����Ӹ��� �ӵ��� 1% �� �پ��� ���� (rotSpeed = rotSpeed * 0.99.0f

    // Update is called once per frame
    void Update()
    {
        
    }
}
