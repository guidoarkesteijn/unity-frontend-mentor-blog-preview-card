using UnityEngine;
using UnityEngine.UIElements;

public class Scren : MonoBehaviour
{
    protected void Start()
    {
        VisualElement card = GetComponent<UIDocument>().rootVisualElement.Q("Card");

        card.RegisterCallback<ClickEvent>(OnCardClickEvent);
    }

    private void OnCardClickEvent(ClickEvent clickEvent)
    {
        Debug.LogWarning("Clicked: " + clickEvent.target);
    }
}
