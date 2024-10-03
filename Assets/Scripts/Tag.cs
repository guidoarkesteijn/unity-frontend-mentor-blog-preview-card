using UnityEngine;

[CreateAssetMenu(fileName = nameof(Tag))]
public class Tag : ScriptableObject
{
    [SerializeField] private string tag;
    [SerializeField] private Color color;
}
