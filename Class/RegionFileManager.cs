using ExcelFormatTypeEditForGraphDisplay.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExcelFormatTypeEditForGraphDisplay.Class
{
    class RegionFileManager
    {
        /// <summary>
        /// จัดการไฟล์ระดับภูมิภาค
        /// </summary>
        public static void ManageFileDataInRegionFile()
        {
            var filepath = @"C:\Users\Mana PC\Documents\Programming\C#\ExcelFormatTypeEditForGraphDisplay\Import\Region.csv";
            var data = filepath.ReadData();
            var regionDataList = GetRegionDataList(data, 155, 23);
            regionDataList.WriterCRVFile("Region-59Variable-Purple");
        }

        static List<Region> GetRegionDataList(IEnumerable<string> data, int start, int end)
        {
            var regionDataList = new List<Region>();
            var headerList = new List<string>();
            for (int i = 0; i < data.Count(); i++)
            {
                if (i == 0)
                {
                    headerList.AddRange(data.ElementAt(0).Split(","));
                }
                if (i > 0)
                {
                    var dataList = new List<string>();
                    dataList.AddRange(data.ElementAt(i).Split(","));
                    regionDataList.AddRange(InputDataToRegionFormat(headerList, dataList, start, end));
                }
            }
            return regionDataList;
        }

        static List<Region> InputDataToRegionFormat(List<string> headerList, List<string> dataList, int start, int end)
        {
            var regionDataList = new List<Region>();
            for (var i = 1; i < headerList.Count(); i++)
            {
                regionDataList.Add(
                    new Region
                    {
                        RegionName = dataList.ElementAt(0),
                        HeaderName = headerList.ElementAt(i),
                        Data = dataList.ElementAt(i)

                    });
            }
            return regionDataList.Skip(start).SkipLast(end).ToList();
        }
    }
}
