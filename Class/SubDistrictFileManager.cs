using ExcelFormatTypeEditForGraphDisplay.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExcelFormatTypeEditForGraphDisplay.Class
{
    class SubDistrictFileManager
    {

        /// <summary>
        ///จัดการไฟล์ระดับตำบล
        /// </summary>
        public static void ManageFileDataInSubDistrictFile()
        {
            var filepath = @"C:\Users\Mana PC\Documents\Programming\C#\ExcelFormatTypeEditForGraphDisplay\Import\Sub-district.csv";
            var data = filepath.ReadData();
            var subDistrictDataList = GetSubDistrictDataList(data, 155, 23);
            subDistrictDataList.WriterCRVFile("SubDistrict-59Variable-Purple");
        }

        static List<SubDistrict> GetSubDistrictDataList(IEnumerable<string> data, int start, int end)
        {
            var subDistrictDataList = new List<SubDistrict>();
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
                    subDistrictDataList.AddRange(InputDataToSubDistrictFormat(headerList, dataList, start, end));
                }
            }
            return subDistrictDataList;
        }

        static List<SubDistrict> InputDataToSubDistrictFormat(List<string> headerList, List<string> dataList, int start, int end)
        {
            var subDistrictDataList = new List<SubDistrict>();
            for (var i = 4; i < headerList.Count(); i++)
            {
                subDistrictDataList.Add(
                    new SubDistrict
                    {
                        SubDistrictName = dataList.ElementAt(0),
                        DistrictName = dataList.ElementAt(1),
                        ProvinceName = dataList.ElementAt(2),
                        RegionName = dataList.ElementAt(3),
                        HeaderName = headerList.ElementAt(i),
                        Data = dataList.ElementAt(i)
                    });
            }
            return subDistrictDataList.Skip(start).SkipLast(end).ToList();
        }

    }
}
