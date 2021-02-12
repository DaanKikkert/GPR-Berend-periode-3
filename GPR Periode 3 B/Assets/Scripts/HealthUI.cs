using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    [SerializeField] Text healthText;
    [SerializeField] PlayerHealth playerHealth;

    // Start is called before the first frame update
    void Start()
    {
        healthText = gameObject.GetComponent<Text>();        
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = playerHealth.getHealth().ToString();
    }

    public void UpdateUI(float health)
    {
        healthText.text = health.ToString();
    }
}
