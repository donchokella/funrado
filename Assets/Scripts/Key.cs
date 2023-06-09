using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField] Inventory.AllKeys keyColor;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Inventory.Instance.AddKey(keyColor);   // Add the key to the inventory
            GameManager.instance.GetComponent<EffectManagar>().CollectKeyEffect();

            Destroy(gameObject);
        }
    }
}
