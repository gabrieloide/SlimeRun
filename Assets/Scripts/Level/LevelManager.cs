using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public List<LevelBlock> LevelBlock = new List<LevelBlock>();
    public List<LevelBlock> currentLevelBlock = new List<LevelBlock>();
    [SerializeField] Transform levelStartPos;
    [SerializeField] int amountToCreate;
    private void Start()
    {
        createAmountLevelBlock();
    }
    public void createLevelBlock()
    {
        int RandomIdx = Random.Range(0, LevelBlock.Count);
        LevelBlock block;
        Vector3 spawnPosition = Vector3.zero;
        if (currentLevelBlock.Count == 0)
        {
            block = Instantiate(LevelBlock[0]); 
            spawnPosition = levelStartPos.position;
        }
        else
        {
            block = Instantiate(LevelBlock[RandomIdx]);
            spawnPosition = currentLevelBlock[currentLevelBlock.Count - 1]
                                                        .EndPoint.position;
        }
        block.transform.SetParent(this.transform, false);

        Vector3 correction = new Vector3(spawnPosition.x - block.StartPoint.position.x, spawnPosition.y - block.StartPoint.position.y, 0);

        block.transform.position = correction;

        currentLevelBlock.Add(block);
    }
    public void RemoveLevelBlock()
    {
        LevelBlock oldBlock = currentLevelBlock[0];
        currentLevelBlock.Remove(oldBlock);
        Destroy(oldBlock.gameObject);

    }
    void createAmountLevelBlock()
    {
        for (int i = 0; i < amountToCreate; i++)
        {
            createLevelBlock();
        }
    }
}
