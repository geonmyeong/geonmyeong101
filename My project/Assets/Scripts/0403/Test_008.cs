using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player
{
    private int hp = 100;                                               //hp �� �������� 100�� ���� �Է�
    private int power = 50;                                             //power�� ������ �� 50�� ���� �Է�

    public void Attack()
    {
        Debug.Log(this.power + "�������� ������.");                    //this�� player Ŭ������ �̾߱��Ѵ�.
    }

    public void Damage(int damage)                                     //Damage �Լ��� int ���·� ���� ���̹� �μ��� �޴´�.
    {
        this.hp -= damage;
        Debug.Log(damage + "�������� �Ծ���.");
    }

    public int GetHp()                                                  //private �� ����Ǿ��ִ� Hp ���� ���� �Լ��� ���ؼ� ����
    {
        return this.hp;
    }
}

public class Test_008 : MonoBehaviour
{
    public Player player_01 = new Player();
    public Player player_02 = new Player();
    public Text player01Hp;
    public Text player02Hp;
    // Start is called before the first frame update
    void Start()
    {

        player_01.Attack();                                             //������  player_01 �� Attack �Լ��� �����Ų��.
        player_01.Damage(30);                                           //������ player_01 �� Damage �Լ��� �����Ų��. (�μ� 30�� �־��ش�.)

    }   

    // Update is called once per frame
    void Update()
    {
        player01Hp.text = "Player 01 Hp : " + player_01.GetHp().ToString();
        player02Hp.text = "Player 02 Hp : " + player_02.GetHp().ToString();

        if(Input.GetMouseButtonDown(0))
        {
            player_01.Damage(1);
        }

        if(Input.GetMouseButtonDown(1))
        {
            player_02.Damage(1);
        }
    }
}
