using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using GDS.Core.Events;
using UnityEngine;

namespace GDS.Core {
    /// <summary>
    /// Contains logging utility extension methods
    /// </summary>
    public static class LogUtil {

        public static void Log(IEnumerable<object> obj) => Debug.Log(obj.Count() == 0 ? "[Collection is empty]" : string.Join("\n", obj).Colorize());
        public static void Log(params object[] args) => Debug.Log(string.Join(" ", args));
        public static void LogTodo(params object[] args) => Debug.Log("[TODO] ".Orange() + string.Join(" ", args));
        public static void LogWarning(params object[] args) => Debug.LogWarning("[WARNING] ".Yellow() + string.Join(" ", args));
        public static void LogError(params object[] args) => Debug.Log("[ERROR] ".Red() + string.Join(" ", args));
        public static void LogEvent(object e) => Debug.Log($"[ON::{e.GetType().Name.Yellow()}] " + e.ToString().Colorize());
        public static void LogCreate(object o) => Debug.Log($"Creating ".Yellow() + $"[{o.GetType()}]".Gray());
        public static void LogInit(object o) => Debug.Log($"Initializing ".Yellow() + $"[{o.GetType()}]".Gray());
        public static T LogAndReturn<T>(this T value, string message) { Debug.Log(message); return value; }

        public static void LogResultEvent(object e) {
            if (e is Success) Debug.Log($"[Success::{e.GetType().Name.Green()}] " + e.ToString().Colorize());
            if (e is Fail) Debug.Log($"[Fail::{e.GetType().Name.Red()}] " + e.ToString().Colorize());
        }

        // string and collection
        public static string CommaJoin<T>(this IEnumerable<T> coll) => string.Join(", ", coll);
        public static string NewLineJoin<T>(this IEnumerable<T> coll) => "\n" + string.Join("\n", coll);
        public static string AsString<T>(this List<T> list) => string.Join("\n", list);
        public static string AsString<T, V>(this Dictionary<T, V> list) => string.Join("\n", list);

        // colorize
        public static string Colorize(this string input, string pattern = @"[{}=;,]") => Regex.Replace(input, pattern, match => match.Value switch {
            "," => match.Value.Blue(),
            ";" => match.Value.Blue(),
            "=" => match.Value.Yellow(),
            _ => match.Value.Pink()
        });

        public static string ColorizeMatrixValues(this string input, string pattern = @"[0-9,|,_,.,-]|\bNoItem\b") => Regex.Replace(input, pattern, match => match.Value switch {
            "1" => match.Value.Green(),
            "2" => match.Value.Yellow(),
            "3" => match.Value.Red(),
            "4" => match.Value.Red(),
            _ => match.Value.DarkGray()
        });

    }
}