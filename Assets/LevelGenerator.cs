using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public Player player;
    public Vector3 spawnPosition;
    public LevelSegment LevelSegment;
    public Transform Container;
    public float spawnDelay;
    private float timer;
    private bool freezed;

    private List<LevelSegment> levelSegments = new List<LevelSegment>();
    public List<LevelSegment> LevelSegments => levelSegments;
    public LevelStateManager levelStateManager;

    private void Update()
    {
        if (freezed)
            return;

        timer += Time.deltaTime;

        if (timer > spawnDelay)
        {
            timer = 0f;
            LevelSegment levelSegment = Instantiate(LevelSegment, spawnPosition, Quaternion.identity, Container);
            levelSegment.Construct(levelStateManager);
            levelSegments.Add(levelSegment);
        }
    }

    public void Freeze()
    {
        freezed = true;

        foreach (LevelSegment levelSegment in levelSegments)
        {
            levelSegment.Freeze();
        }
    }

    public void Unfreeze()
    {
        freezed = false;
        timer = 0f;
        
        foreach (LevelSegment levelSegment in levelSegments)
        {
            Destroy(levelSegment.gameObject);
        }

        levelSegments.Clear();
    }
}
