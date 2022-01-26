using UnityEngine;
using UnityEditor;
using System.Collections.Generic;

public class CreateFolderStructure : ScriptableWizard
{
    public string FolderName = "Game";
    static void CreateWizard()
    {
        ScriptableWizard.DisplayWizard("Create Project Folders", typeof(CreateFolderStructure), "Create");
    }
    void OnEnable()
    {

    }
    void OnWizardCreate()
    {
        string primaryFolder = AssetDatabase.CreateFolder("Assets", FolderName);
    }
    void OnWizardErase()
    {
        bool deleteFolder = AssetDatabase.DeleteAsset("Assets" + "/" + FolderName);
    }
}