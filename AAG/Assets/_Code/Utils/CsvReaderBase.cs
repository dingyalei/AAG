using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace Utils
{
    [AttributeUsage(AttributeTargets.Class)]
    public class CsvReaderAttribute : Attribute
    {
        private string path;
        public string FileName => path;

        public CsvReaderAttribute(string filePath)
        {
            path = filePath;
        }
    }

    public abstract class CsvRenderBase
    {
        public string FilePath
        {
            get { return this.GetType().GetCustomAttribute<CsvReaderAttribute>().FileName; }
        }
    }
}