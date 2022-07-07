
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public static GameManager manager;
    public enum State { Nothing, Eat, Play, Move, Talk }
    public State state;
    public int stateCode;
    public Text text;
    public Dictionary<int, string> dictionary = new Dictionary<int, string>();

    public Charactor charactor;
    public GameObject targetObject;
    public string item;


    void Start()
    {
        manager = this;

        stateCode = Random.Range(0, 5);
        state = (State)stateCode;

        dictionary.Add(0, "�����");
        dictionary.Add(1, "�ܹ���");

        item = dictionary[Random.Range(0, 1)];
    }


    void Update()
    {
        
        text.text = "����: " + state + " " + item;
    }

    public void SetTarget()
    {
        Debug.Log(targetObject);
        charactor.targetPosition = targetObject.transform.position;
    }

    public void ChooseItem()
    {
        var itemNum = Random.Range(0, 2);
        item = dictionary[itemNum];
        Debug.Log("������ ����" + itemNum);
    }
}
