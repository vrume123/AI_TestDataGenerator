using System.Globalization;
using CsvHelper;

namespace AI_TestDataGenerator;

public class CsvFileWriter
{
    private readonly string _baseFilePath;
    
    public CsvFileWriter(string baseFilePath = "") => 
        _baseFilePath = baseFilePath;

    public void WriteToFile<T>(IEnumerable<T> dataList, string fileName)
    {
        using var writer = new StreamWriter($@"{_baseFilePath}{fileName}.csv");
        using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
        csv.WriteRecords(dataList);
    }
}