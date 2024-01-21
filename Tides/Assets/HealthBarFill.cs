using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarFill : MonoBehaviour
{
    public Health playerHealth;
    public Image fillImage;
    private Slider slider;

    void Awake()
    {
        slider = GetComponent<Slider>();
    }
    // Update is called once per frame
    void Update()
    {
        float fillValue = Mathf.Clamp01((float)playerHealth.currentHealth / playerHealth.maxHealth);
        slider.value = fillValue;
    }

}
