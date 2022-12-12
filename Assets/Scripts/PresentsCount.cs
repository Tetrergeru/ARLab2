using TMPro;
using UnityEngine;

public class PresentsCount : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _counterField;

    private int _counter = 0;

    public void AddPoint()
    {
        _counter += 1;
        _counterField.text = $"{_counter}";
    }
}
