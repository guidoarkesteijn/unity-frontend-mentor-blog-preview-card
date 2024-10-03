using UnityEngine;

[CreateAssetMenu(fileName = nameof(Author))]
public class Author : ScriptableObject
{
    [SerializeField] private string authorName;
    [SerializeField] private Sprite avatar;
}
