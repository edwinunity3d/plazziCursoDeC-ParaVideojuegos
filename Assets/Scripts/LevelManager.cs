using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public static LevelManager singleton ;

    public List<LevelBlock> allTheLevelBlocks = new List<LevelBlock>();

    public List<LevelBlock> currentLevelBlocks = new List<LevelBlock>();
    public Transform LevelStartPosition;


    void Awake()
    {
        if(singleton == null)
        {
            singleton = this;
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GenerateInitialBlocks();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddLeveBlock()
    {
        
    }


    public void removeLevelBlock()
    {
        
    }


    public void RemoveAllLevelBlocks()
    {
        
    }

    public void  GenerateInitialBlocks()
    {
        for(int i = 0; i < 2; i++)
        {
            AddLeveBlock();
        }
    }
}
