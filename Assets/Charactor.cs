
using UnityEngine;


public class Charactor : MonoBehaviour
{

    public Vector3 mousePosition;
    public Vector3 worldPosition;
    public Vector3 targetPosition;
    public bool isKeyboardActing;
    public float checkTime;
    
    void Update()
    {
        if(Input.GetAxisRaw("Horizontal") != 0)
        {
            transform.position += Vector3.right * Time.deltaTime * Input.GetAxisRaw("Horizontal"); ;
            isKeyboardActing = true;

        } else
        {
            if (isKeyboardActing)
            {
                checkTime += Time.deltaTime;
                if(checkTime > 2f)
                {
                    isKeyboardActing = false;
                }
            } else
            {
                if (transform.position.x - targetPosition.x > 0.1) //0으로 하면 오차 발생?
                {
                    Debug.Log("왼쪽으로 이동");

                    transform.position += Vector3.left * Time.deltaTime;
                    GameManager.manager.state = GameManager.State.Move;
                }
                else if (transform.position.x - targetPosition.x < -0.1f)
                {
                    Debug.Log("오른쪽으로 이동");
                    transform.position += Vector3.right * Time.deltaTime;
                    GameManager.manager.state = GameManager.State.Move;
                }

            }           
        }


        if(Input.GetMouseButtonDown(1))
        {         
            mousePosition = Input.mousePosition;

            worldPosition = Camera.main.ScreenToWorldPoint(mousePosition + new Vector3(0, 0, 10f));
            Debug.Log(worldPosition.x);

            targetPosition = worldPosition;
        }

    }
}
