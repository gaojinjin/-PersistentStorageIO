using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;

public class SaveManager : MonoBehaviour
{
    // Start is called before the first frame update
    public string fileName;
    void Start()
    {

        /* fileName = Application.streamingAssetsPath + "/" + fileName + "0.txt";
         File.WriteAllText(fileName,"今天我又进步了");*/

        /*fileName = Application.streamingAssetsPath + "/" + fileName + "1.txt";
        FileStream fs = new FileStream(fileName,FileMode.OpenOrCreate);
        byte[] tempBytes = Encoding.UTF8.GetBytes("今天变帅了");
        fs.Write(tempBytes, 0, tempBytes.Length);
        fs.Close();*/
        fileName = Application.streamingAssetsPath + "/" + fileName + "2.txt";

        StreamWriter sw = new StreamWriter(fileName);
        for (int i = 0; i < 100; i++)
        {
            sw.WriteLine("夸夸自己" +i);
        }
        sw.Close();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
