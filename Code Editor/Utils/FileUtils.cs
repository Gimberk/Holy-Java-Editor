using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Code_Editor
{
    public class FileUtils
    {
        static readonly List<string> files = new List<string>();
        static readonly List<string> dirs = new List<string>();
        public static List<string> ProcessDirectory
            (string targetDirectory, string[] blackListedDirs, bool filesB = true, bool recursive = false)
        {
            if (!recursive)
            {
                files.Clear();
                dirs.Clear();
            }

            string[] fileEntries = Directory.GetFiles(targetDirectory);
            foreach (string fileName in fileEntries)
                files.Add(fileName);

            string[] subdirectoryEntries = Directory.GetDirectories(targetDirectory);
            foreach (string subdirectory in subdirectoryEntries)
            {
                DirectoryInfo di = new DirectoryInfo(subdirectory);
                if (blackListedDirs.Contains(di.Name))
                    continue;

                dirs.Add(subdirectory);
                ProcessDirectory(subdirectory, blackListedDirs, false, true);
            }

            if (filesB)
                return files;
            else
                return dirs;
        }

        static TreeNode result = null;
        public static TreeNode SearchNode(TreeNode node, string nodeName)
        {
            if (node.Text == nodeName) return node;

            foreach (TreeNode treeNode in node.Nodes)
            {
                if (treeNode.Text == nodeName)
                {
                    result = treeNode;
                    return treeNode;
                }
                
                SearchNode(treeNode, nodeName);
            }

            return result;
        }
    }
}
