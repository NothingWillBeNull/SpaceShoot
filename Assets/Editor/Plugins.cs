#if UNITY_EDITOR
using System.IO;
using UnityEditor;
#endif
using UnityEngine;

namespace Demo
{
    public class Plugins : Editor
    {
        private const string TargetPath = @"Assets\Scripts\PathManager.cs";
        private const string PerfabsPath = @"Assets\Resources\Perfabs";

        private const string StartStr = "namespace Demo\r\n{\r\n    /// <summary>\r\n    /// 所有的路径相关 用静态常量存储对应字符串\r\n    /// </summary>\r\n    public class PathManager\r\n    {\r\n";
        private const string EndStr = "    }\r\n}";
        [MenuItem("Plugins/RefreshAssetName")]
        public static async void RefreshAssetName()
        {
            string content = string.Empty;
            string[] fileNames = Directory.GetFiles(PerfabsPath);
            if (fileNames.Length > 0)
            {
                foreach (var name in fileNames)
                {
                    if (name.IndexOf("meta") != -1) continue;
                    string noExtensionName = System.IO.Path.GetFileNameWithoutExtension(name);
                    string nowStr = $"\t\tpublic const string {noExtensionName} = \"Perfabs/{noExtensionName}\";\n";
                    content += nowStr;
                }
            }

            StreamWriter writer = new StreamWriter(TargetPath, false);
            string finalStr = StartStr + content + EndStr;
            await writer.WriteAsync(finalStr);
            writer.Close();
            AssetDatabase.Refresh();

            // 选择并高亮刚创建的C#脚本文件
            Object asset = AssetDatabase.LoadAssetAtPath(TargetPath, typeof(Object));
            Selection.activeObject = asset;
            EditorGUIUtility.PingObject(asset);

            Debug.LogWarning("刷新文件成功   ✅");
        }
    }
}


