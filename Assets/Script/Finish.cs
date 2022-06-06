using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public static Finish _instance;
    public Transform[] childrenList;

    public Color blueCaseColor = new Color32(115, 110, 231, 1);
    public Color redCaseColor = new Color32(231, 58, 52, 1);
    public Color greenCaseColor = new Color32(106, 231, 112, 1);
    public Color purpleCaseColor = new Color32(212, 17, 231, 1);

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
    }

    void Start()
    {
        Transform[] allChildren = GetComponentsInChildren<Transform>();
        childrenList = allChildren;
        for (int i = 1; i < allChildren.Length; i++)
        {
            int a = i % 4;
            if (a == 1)
            {
                Material newMaterial = new Material(Shader.Find("Standard"));
                newMaterial.color = redCaseColor;
                newMaterial.color = newMaterial.color*((i*0.3f)+1);
                
                allChildren[i].GetComponent<MeshRenderer>().material = newMaterial;
            }else if (a == 2)
            {
                Material newMaterial = new Material(Shader.Find("Standard"));
                newMaterial.color = blueCaseColor;
                newMaterial.color = newMaterial.color*((i*0.09f)+1);
                allChildren[i].GetComponent<MeshRenderer>().material = newMaterial;
            }else if (a == 3)
            {
                Material newMaterial = new Material(Shader.Find("Standard"));
                newMaterial.color = purpleCaseColor;
                newMaterial.color = newMaterial.color*((i*1f)+1);
                allChildren[i].GetComponent<MeshRenderer>().material = newMaterial;
            }else if (a == 0)
            {
                Material newMaterial = new Material(Shader.Find("Standard"));
                newMaterial.color = greenCaseColor;
                newMaterial.color = newMaterial.color*((i*0.09f)+1);
                allChildren[i].GetComponent<MeshRenderer>().material = newMaterial;
            } ;
            


        }

        

    }

    public void MakeColored(int i,Color colorReturn)
    {
        Vibration.VibratePop();
        Material newMaterial = new Material(Shader.Find("Standard"));
        
        if(childrenList[i].GetComponent<MeshRenderer>()==null)childrenList[i].AddComponent<MeshRenderer>();
        newMaterial.color = colorReturn;
        childrenList[i].GetComponent<MeshRenderer>().material = newMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
