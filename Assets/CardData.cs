using System.Runtime.CompilerServices;
using UnityEngine;

public class CardData : MonoBehaviour
{
    [SerializeField] private CardDataSO _cardDataSO;

private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _cardDataSO.hP *= 2;
            _cardDataSO.SayHello();
        }
    }
}