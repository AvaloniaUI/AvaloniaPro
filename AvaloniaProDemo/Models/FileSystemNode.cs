using System;
using System.Collections.ObjectModel;

namespace AvaloniaProDemo.Models;

public class FileSystemNode
{
    public string Name { get; set; } = "";
    public long Size { get; set; }
    public DateTime Modified { get; set; }
    public bool IsFolder { get; set; }
    public ObservableCollection<FileSystemNode> Children { get; } = new();

    public string SizeDisplay => IsFolder ? "" : FormatSize(Size);
    public string TypeDisplay => IsFolder ? "Folder" : GetExtension();
    public string ModifiedDisplay => Modified.ToString("yyyy-MM-dd");

    private string FormatSize(long bytes)
    {
        string[] suffixes = ["B", "KB", "MB", "GB"];
        int order = 0;
        double size = bytes;
        while (size >= 1024 && order < suffixes.Length - 1)
        {
            order++;
            size /= 1024;
        }
        return $"{size:0.#} {suffixes[order]}";
    }

    private string GetExtension()
    {
        var dot = Name.LastIndexOf('.');
        return dot >= 0 ? Name[dot..].ToUpperInvariant() + " File" : "File";
    }
}
