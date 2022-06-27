using System;
using FullSerializer;
using UnityEngine;

namespace AAJBSON
{
    public static class AAJbsonMapper
    {
        private static fsSerializer _serializer = new fsSerializer();
        
        
        public static string ToJson<T>(T instance, bool prettifyJson = false)
        {
            return ToJson(typeof(T), instance, prettifyJson);
        }
        
        public static string ToJson(Type type, object instance, bool prettifyJson = false)
        {
            _serializer.InternalSerialize_1_ProcessCycles(type, null, instance, out var result);
            //_serializer.TrySerialize(instance, out var result);
            return fsJsonPrinter.FormatJson(result, prettifyJson);
        }
        
        public static T TryDeserialize<T>(string jsonData) where T : new()
        {
            T t = new T();
            return TryDeserialize(jsonData, t);
        }

        public static T TryDeserialize<T>(string jsonData, T instance)
        {
            fsData fsData = new fsData(jsonData);
            _serializer.TryDeserialize(fsData, ref instance);
            return instance;
        }
    }
}