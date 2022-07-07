using UnityEngine;

public class Item : MonoBehaviour
{

    public void OnMouseDown()
    {
        Debug.Log("아이템 클릭");
        GameManager.manager.targetObject = gameObject;
        GameManager.manager.SetTarget();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
