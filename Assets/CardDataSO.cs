using UnityEngine;

[CreateAssetMenu(fileName = "NewScriptableObjectScript", menuName = "Scriptable Objects/NewScriptableObjectScript")]
public class CardDataSO : ScriptableObject
{
    public string cardName;
    public int hP;
    public int damage;

    public void SayHello()
    {
        Debug.Log(cardName);
        Debug.Log(hP);
        Debug.Log(damage);
    }
}
