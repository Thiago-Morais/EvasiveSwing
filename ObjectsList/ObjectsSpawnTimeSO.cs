using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "Object Pool", menuName = "List/Pool of Objects")]
public class ObjectsSpawnTimeSO : ScriptableObject
{
    [Header("NotesDatabase")]
    //public ItemDatabase itemDB;
    public List<SyncManager.ObjectSpawnTime> objectsSpawnTime;
    /* public ObjectsListSO()
    {
        objectsSpawnTime = new List<SyncManager.ObjectSpawnTime>();
    } */
    
}
