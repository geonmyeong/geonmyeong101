using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_006 : MonoBehaviour
{
    int[] array = new int[5];                                   //aaray <-- �̸����� 5���� �迭(���� int)�� ����
    int[] points = { 83, 99, 52, 93, 15 };            

    // Start is called before the first frame update
    void Start()
    {
        array[0] = 2;                                           //���� index(array[n]) ���� ���� �� �Է�
        array[1] = 10;
        array[2] = 5;
        array[3] = 15;
        array[4] = 3;

        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);                                // i (0 -> 4) ���� �����ϸ鼭 console.log â�� ������ ���� �����ش�.
                                                                // array[0}] , array[1], array[2], array[3], array[4] <---- for ���� �ذ�
        }

        int sum = 0;                                        //�߰� �κп��� ������ �ʿ��� ��� ���Ƿ� �����Ҽ� ����

        for (int i = 0; i < points.Length; i++)             //points,Length �� �迭�� ���� ���� ��ȯ��
        {
            if (points[i] > 90)                             // 90 �ʰ� �϶��� Debug,Log ���ǽ� ���
            {
                Debug.Log(points[i]);
            }
            sum += points[i];
        }
        int average = sum / points.Length;                  //��� ���� ���� �����ϰ� �Է�
        Debug.Log(average);                                 //��� �� ���
    }       

    // Update is called once per frame
    void Update()
    {
        
    }
}