using UnityEngine;
using UnityEngine.EventSystems;

public class Button : MonoBehaviour, IPointerClickHandler

{
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Å¬¸¯");
        /*GameManager.manager.stateCode += 1;
        if (GameManager.manager.stateCode == 5)
            GameManager.manager.stateCode = 0;*/

        GameManager.manager.stateCode = Random.Range(0, 5);
        GameManager.manager.ChooseItem();


        GameManager.manager.state = (GameManager.State)GameManager.manager.stateCode;
    }

}
