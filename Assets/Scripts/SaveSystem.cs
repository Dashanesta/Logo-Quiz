using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using File = System.IO.File;

public class SaveSystem : MonoBehaviour
{
    private const string FileType = ".txt";
    private static string SavePath => Application.persistentDataPath + "/Saves/";
    private static string BackupSavePath => Application.persistentDataPath + "/Backups/";

    private static int SaveCount;

    public static void SaveData<T> (T data, string fileName)
    {
        Directory.CreateDirectory(SavePath);
        Directory.CreateDirectory(BackupSavePath);

        if (SaveCount % 5 == 0) Save(BackupSavePath);
        Save(SavePath);

        SaveCount++;

        void Save(string path)
        {
            using (StreamWriter writer = new StreamWriter(path + fileName + FileType))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                MemoryStream memoryStream = new MemoryStream();
                formatter.Serialize(memoryStream, data);
                string dataToSave = Convert.ToBase64String(memoryStream.ToArray());
                writer.WriteLine(dataToSave);
            }
        }
    }

    public static T LoadData<T>(string fileName)
    {
        Directory.CreateDirectory(SavePath);
        Directory.CreateDirectory(BackupSavePath);

        bool backUpNeeded = false;
        T dataToReturn;

        Load(SavePath);
        if (backUpNeeded) Load(BackupSavePath);

        return dataToReturn;

        void Load(string path)
        {
            using (StreamReader reader = new StreamReader(path: path + fileName + FileType))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                string dataToLoad = reader.ReadToEnd();
                MemoryStream memoryStream = new MemoryStream(buffer: Convert.FromBase64String(dataToLoad));

                try
                {
                    dataToReturn = (T)formatter.Deserialize(memoryStream);
                }
                catch (Exception)
                {
                    backUpNeeded = true;
                    dataToReturn = default;
                }
            }
        }
    }

    public static bool SaveExists(string fileName) => 
        File.Exists(path: SavePath + fileName + FileType)
        || File.Exists(path: BackupSavePath + fileName + FileType);
}
