using ExcelFormatTypeEditForGraphDisplay.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExcelFormatTypeEditForGraphDisplay.Class
{
    class DistrictFileManger
    {
        /// <summary>
        /// จัดการไฟล์ระดับอำเภอ
        /// </summary>
        public static void ManageFileDataInDistrictFile()
        {
            var filepath = @"C:\Users\Mana PC\Documents\Programming\C#\ExcelFormatTypeEditForGraphDisplay\Import\SubProvince.csv";
            var data = filepath.ReadData();
            var provinceDataList = GetSubProviceDataList(data, 155, 23);
            provinceDataList.WriterCRVFile("District-59Variables-Purple");
        }

        static List<SubProvince> GetSubProviceDataList(IEnumerable<string> data, int start, int end)
        {
            var provinceDataList = new List<SubProvince>();
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
                    provinceDataList.AddRange(InputDataToSubProvinceFormat(headerList, dataList, start, end));
                }
            }
            return provinceDataList;
        }

        static List<SubProvince> InputDataToSubProvinceFormat(List<string> headerList, List<string> dataList, int start, int end)
        {
            var subProvinceDataList = new List<SubProvince>();
            for (var i = 3; i < headerList.Count(); i++)
            {
                subProvinceDataList.Add(
                    new SubProvince
                    {
                        SubProvinceName = dataList.ElementAt(0),
                        ProvinceName = dataList.ElementAt(1),
                        RegionName = dataList.ElementAt(2),
                        HeaderName = headerList.ElementAt(i),
                        Data = dataList.ElementAt(i)
                    });
            }
            return subProvinceDataList.Skip(start).SkipLast(end).ToList();
        }

    }
}
