using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class heatlhbar : MonoBehaviour
{
    public float maxheatlh = 100f;
    public float currenthealth;
    public Image _heatlhbar;
    private controller PLayer;


    void Start()
    {
        _heatlhbar = GetComponent<Image>();
         PLayer = FindObjectOfType<controller>();

    }


    // Update is called once per frame
    void Update()
    {
        currenthealth = PLayer.health;
      _heatlhbar.fillAmount  = currenthealth / maxheatlh;
        
    }
}
