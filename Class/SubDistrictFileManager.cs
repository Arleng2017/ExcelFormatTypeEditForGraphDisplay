using ExcelFormatTypeEditForGraphDisplay.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExcelFormatTypeEditForGraphDisplay.Class
{
    public class SubDistrictFileManager
    {

        /// <summary>
        ///จัดการไฟล์ระดับตำบล
        /// </summary>
        public static void ManageFileDataInSubDistrictFile()
        {
            var filepath = @"C:\Users\Ar'leng Chalermchai\Documents\Programming\C#\ExcelFormatTypeEditForGraphDisplay\Import\cwt\CWT59.csv";
            var data = filepath.ReadData();
            var subDistrictDataList = GetSubDistrictDataList(data);
            subDistrictDataList.WriterCRVFile("CWT59");
        }

        static List<SubDistrict> GetSubDistrictDataList(IEnumerable<string> data)
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
                    subDistrictDataList.AddRange(InputDataToSubDistrictFormat(headerList, dataList));
                }
            }
            return subDistrictDataList;
        }

        static List<SubDistrict> InputDataToSubDistrictFormat(List<string> headerList, List<string> dataList)
        {
            var subDistrictDataList = new List<SubDistrict>();
            for (var i = 2; i < headerList.Count(); i++)
            {
                subDistrictDataList.Add(
                    new SubDistrict
                    {
                        //SubRiver = dataList.ElementAt(0),
                        //River = dataList.ElementAt(1),
                        //RegAreaCode = dataList.ElementAt(0),
                        //AreaCode = dataList.ElementAt(1),
                        //SubDistrictName = dataList.ElementAt(2),
                        //DistrictName = dataList.ElementAt(0),
                        //ProvinceName = dataList.ElementAt(0),
                        
                        
                        Reg = dataList.ElementAt(0),
                        ProvinceName = dataList.ElementAt(1),
                        HeaderName = headerList.ElementAt(i),
                        Data = dataList.ElementAt(i)
                    }); ;
            }
            var x = subDistrictDataList.SkipLast(0).ToList();
            return subDistrictDataList.SkipLast(0).ToList();
        }

    }
}
