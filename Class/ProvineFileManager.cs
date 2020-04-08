using ExcelFormatTypeEditForGraphDisplay.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExcelFormatTypeEditForGraphDisplay.Class
{
    class ProvineFileManager
    {
        /// <summary>
        /// จัดการไฟล์ระดับจังหวัด
        /// </summary>
        /// <param name="data"></param>
        public static void ManageFileDataInProvinceFile()
        {
            var filepath = @"C:\Users\Mana PC\Documents\Programming\C#\ExcelFormatTypeEditForGraphDisplay\Import\Province.csv";
            var data = filepath.ReadData();
            var provinceDataList = GetProviceDataList(data, 155, 23);
            provinceDataList.WriterCRVFile("Province-59Variable-Purple");
        }

        static List<Province> GetProviceDataList(IEnumerable<string> data, int start, int end)
        {
            var provinceDataList = new List<Province>();
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
                    provinceDataList.AddRange(InputDataToProvinceFormat(headerList, dataList, start, end));
                }
            }
            return provinceDataList;
        }

        static List<Province> InputDataToProvinceFormat(List<string> headerList, List<string> dataList, int start, int end)
        {
            var provinceDataList = new List<Province>();
            for (var i = 2; i < headerList.Count(); i++)
            {
                provinceDataList.Add(
                    new Province
                    {
                        ProvinceName = dataList.ElementAt(0),
                        RegionName = dataList.ElementAt(1),
                        HeaderName = headerList.ElementAt(i),
                        Data = dataList.ElementAt(i)
                    });
            }
            return provinceDataList.Skip(start).SkipLast(end).ToList();
        }
    }
}
