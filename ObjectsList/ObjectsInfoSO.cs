using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenu(fileName = "Object Pool", menuName = "List/Objects Full Info")]
public class ObjectsInfoSO : ScriptableObject
{
    [Header("NotesDatabase")]
    //public ItemDatabase itemDB;
    public List<InstanceInfo> objectsInfo;
    
    /* public ObjectsListSO()
    {
        objectsSpawnTime = new List<SyncManager.ObjectSpawnTime>();
    } */
    
}
public class SortByHitTime : IComparer<InstanceInfo>
{
    public int Compare(InstanceInfo a, InstanceInfo b)
    {
        return a.hitTime.CompareTo(b.hitTime);
    }
}
