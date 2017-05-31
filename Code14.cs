    //
    // Note: This is sample code for demonstration purposes only and is provided as-is.   
    //
public string[] AggregateLogs(string logDirPath, int daysInPast)
{
    var mergedLines = new List<string>();
    var filePaths = Directory.GetFiles(logDirPath, "*.log");
    foreach (var filePath in filePaths)
    {
        if (this.IsInDateRange(filePath, daysInPast))
        {
            mergedLines.AddRange(File.ReadAllLines(filePath));
        }
    }
 
    return mergedLines.ToArray();
}