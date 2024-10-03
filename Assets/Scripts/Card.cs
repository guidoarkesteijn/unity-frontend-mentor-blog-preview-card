using UnityEngine;

[CreateAssetMenu(fileName = nameof(Card))]
public class Card : ScriptableObject
{
    [SerializeField] private Sprite Image;
    [SerializeField] private string Title;
    [SerializeField] private string Description;
    [SerializeField] private UDateTime DateTime;
    [SerializeField] private Tag[] Tags;
    [SerializeField] private Author Author;
}
