using UnityEditor;
using System.Linq;
using UnityEngine;

public class M1_c1 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Tags>(out var tags))
        {
            Debug.Log("hello");
            Debug.Log(string.Join(',', tags.All.Select(t => t.Name)));   
        }
    }
}