﻿using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ExcelFormatTypeEditForGraphDisplay
{
    public static class FileService
    {
        public static void WriterCRVFile<T>(this List<T> records, string filename)
        {
            var filePath = $@"C:\Users\Mana PC\Documents\Programming\C#\ExcelFormatTypeEditForGraphDisplay\Export\{filename}.csv";
            using (var writer = new StreamWriter(filePath))
            using (CsvWriter csv = new CsvWriter(writer))
            {
                csv.WriteRecords(records);
            }
        }

        public static IEnumerable<string> ReadData(this string filePath)
        {
            IEnumerable<string> rawData;
            using (StreamReader rd = new StreamReader(filePath, Encoding.UTF8))
            {
                var readLine = rd.ReadToEnd();
                rawData = readLine.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList().Skip(1);
            }
            return rawData;
        }
    }
}
