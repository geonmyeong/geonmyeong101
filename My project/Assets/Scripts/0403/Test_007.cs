using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_007 : MonoBehaviour
{
    void sayHello()                                     //sayHello �Լ��� ����
    {
        Debug.Log("Hello");                             //Hello ������ console.log�� ���
    }

    void CallName(string name)                          //CallName �Լ� ���� (string ������ �μ�(name)�� ����)
    {
        Debug.Log("Hello" + name);
    }

    int Add(int a , int b)                              //Add �Լ� ���� (�μ� , ��ȯ��, �����Ҷ� (int)
    {
        int c = a + b;
        return c;
    }
    // Start is called before the first frame update
    void Start()
    {
        sayHello();
        sayHello();
        CallName("TOM");
        CallName("SAM");
        int answer = Add(2, 5);
        Debug.Log(answer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
