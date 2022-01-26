using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ContainerDeItems : MonoBehaviour
{
    enum TiposDeObjetos {item, Pocao, Vestuario}

    [Header("Predefinições")]   
    [SerializeField] 
    TiposDeObjetos tiposDeObjetos;
    public Object[] itemsPrefabs;
    public void SetPrefabsFromAFolder(string folderName)
    {
        if(folderName == null || folderName == "" || Resources.LoadAll(folderName, typeof(GameObject)) == null)
        {
            Debug.Log("Pasta inesistente ou vazia!");
        }
        else
        {
            itemsPrefabs = Resources.LoadAll(folderName, typeof(GameObject));
        }
    }
    public Object[] GetGameObjectArray()
    {
        return itemsPrefabs;
    }
}