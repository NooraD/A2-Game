using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CreateItem{
    public static Itemm Create()
    {
        int num = 1;
        while (System.IO.File.Exists(EditorPrefs.GetString("DatabasePath") + "/Items/ItemScriptObjects/New Item" + "(" + num.ToString() + ")" + ".asset"))
            num++;
        Itemm asset = ScriptableObject.CreateInstance<Itemm>();
        AssetDatabase.CreateAsset(asset, EditorPrefs.GetString("DatabasePath") + "/Items/ItemScriptObjects/New Item(" + num.ToString() + ")" + ".asset");
        asset.itemName = asset.name;
        AssetDatabase.SaveAssets();
        return asset;
    }
}
