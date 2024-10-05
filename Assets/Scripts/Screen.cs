using UnityEngine;
using UnityEngine.UIElements;

public class Screen : MonoBehaviour
{
    [SerializeField] private PanelSettings panelSettings;
    [SerializeField] private ThemeStyleSheet darkTheme;
    [SerializeField] private ThemeStyleSheet lightTheme;

    private bool isDarkTheme;

    protected void Start()
    {
        isDarkTheme = panelSettings.themeStyleSheet == darkTheme;

        VisualElement card = GetComponent<UIDocument>().rootVisualElement.Q("Card");

        card.RegisterCallback<ClickEvent>(OnCardClickEvent);
    }

    private void OnCardClickEvent(ClickEvent clickEvent)
    {
        isDarkTheme = !isDarkTheme;

        panelSettings.themeStyleSheet = isDarkTheme ? darkTheme : lightTheme;
    }
}
